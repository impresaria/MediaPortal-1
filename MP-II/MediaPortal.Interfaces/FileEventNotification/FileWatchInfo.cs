#region Copyright (C) 2007-2008 Team MediaPortal

/*
    Copyright (C) 2007-2008 Team MediaPortal
    http://www.team-mediaportal.com
 
    This file is part of MediaPortal II

    MediaPortal II is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    MediaPortal II is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with MediaPortal II.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

using MediaPortal.Core;
using MediaPortal.Core.Logging;


namespace MediaPortal.FileEventNotification
{

  /// <summary>
  /// Represents all data regarding a watched file,
  /// FileWatchInfo is needed to subscribe and unsubscribe a watch.
  /// </summary>
  public class FileWatchInfo
  {

    #region Constants

    /// <summary>
    /// The wildcard for all characters.
    /// </summary>
    protected const char CharWildcard = '*';
    /// <summary>
    /// The wildcard for numeric characters.
    /// </summary>
    protected const char NumWildcard = '?';

    #endregion

    #region Variables

    /// <summary>
    /// The path to watch.
    /// </summary>
    protected string _path;
    /// <summary>
    /// The FileWatchChangeTypes to raise events for.
    /// </summary>
    protected ICollection<FileWatchChangeType> _changeTypes;
    /// <summary>
    /// The string to filter events on.
    /// </summary>
    protected IList<string> _filter;
    /// <summary>
    /// Indicates whether the watch should be autorestored if lost.
    /// </summary>
    protected bool _autoRestore;
    /// <summary>
    /// Indicates whether subdirectories should be watched too.
    /// </summary>
    protected bool _includeSubdirectories;
    /// <summary>
    /// Reference to the method handling events.
    /// </summary>
    protected FileEventHandler _eventHandler;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the path to the directory to watch.
    /// </summary>
    public string Path
    {
      get { return _path; }
    }

    /// <summary>
    /// Gets the FileWatchChangeTypes to filter events on.
    /// </summary>
    public ICollection<FileWatchChangeType> ChangeTypes
    {
      get { return _changeTypes; }
      set { _changeTypes = value; }
    }

    /// <summary>
    /// Gets or sets the string to filter events on.
    /// </summary>
    public IList<string> Filter
    {
      get { return _filter; }
      set { _filter = value; }
    }

    /// <summary>
    /// Gets or sets whether the watch should autorestore if the path got lost.
    /// </summary>
    public bool AutoRestore
    {
      get { return _autoRestore; }
      set { _autoRestore = value; }
    }
    
    /// <summary>
    /// Gets whether subdirectories are watched too.
    /// </summary>
    public bool IncludeSubdirectories
    {
      get { return _includeSubdirectories; }
    }

    /// <summary>
    /// Gets or sets the reference to the method handling all events.
    /// </summary>
    public FileEventHandler EventHandler
    {
      get { return _eventHandler; }
      set { _eventHandler = value; }
    }

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor, doesn't initialize anything.
    /// </summary>
    protected FileWatchInfo()
    {
      
    }

    /// <summary>
    /// Initializes a new instance of the FileWatchInfo class,
    /// which can be used to subscribe to watch the specified path.
    /// </summary>
    /// <param name="path">The path to watch. Must end with '\' for directories.</param>
    /// <param name="includeSubDirectories">Specifies whether to also report changes in subdirectories.</param>
    /// <param name="eventHandler">Reference to the method handling all events.</param>
    public FileWatchInfo(string path, bool includeSubDirectories, FileEventHandler eventHandler)
      : this(path, includeSubDirectories, eventHandler, new List<string>(), new List<FileWatchChangeType>())
    {
    }

    /// <summary>
    /// Initializes a new instance of the FileWatchInfo class,
    /// which can be used to subscribe to watch the specified path.
    /// Events will be filtered by the given strings.
    /// </summary>
    /// <param name="path">The path to watch. Must end with '\' for directories.</param>
    /// <param name="includeSubDirectories">Specifies whether to also report changes in subdirectories.</param>
    /// <param name="eventHandler">Reference to the method handling all events.</param>
    /// <param name="filter">Filter strings.</param>
    public FileWatchInfo(string path, bool includeSubDirectories, FileEventHandler eventHandler, IList<string> filter)
      : this(path, includeSubDirectories, eventHandler, filter, new List<FileWatchChangeType>())
    {
    }

    /// <summary>
    /// Initializes a new instance of the FileWatchInfo class,
    /// which can be used to subscribe to watch the specified path.
    /// Events will be filtered by the given strings and the given changetypes.
    /// </summary>
    /// <param name="path">The path to watch. Must end with '\' for directories.</param>
    /// <param name="includeSubDirectories">Specifies whether to also report changes in subdirectories.</param>
    /// <param name="eventHandler">Reference to the method handling all events.</param>
    /// <param name="filter">Filter strings.</param>
    /// <param name="changeTypes">Changetypes to report events for.</param>
    public FileWatchInfo(string path, bool includeSubDirectories, FileEventHandler eventHandler, IList<string> filter, ICollection<FileWatchChangeType> changeTypes)
    {
      if (path == null)
        throw new ArgumentNullException("The specified path is a null reference.");
      if (filter == null)
        throw new ArgumentNullException("The specified filter is a null reference.");
      if (changeTypes == null)
        throw new ArgumentNullException("The specified changeTypes is a null reference.");
      _autoRestore = true;  // Most users will want to autorestore
      _includeSubdirectories = includeSubDirectories;
      _eventHandler = eventHandler;
      _changeTypes = changeTypes;
      _filter = filter;
      SetPath(path);        // Makes sure the path is set as a directory
    }

    #endregion

    #region Public Methods

    /// <summary>
    /// Returns whether an event may be raised for the given path and changetype.
    /// </summary>
    /// <param name="args">EventArgs to compare to the filter.</param>
    /// <returns></returns>
    public virtual bool MayRaiseEventFor(IFileWatchEventArgs args)
    {
      // May never raise an event if no EventHandler is specified
      if (_eventHandler == null)
        return false;
      FileInfo fileInfo = new FileInfo(args.Path);
      // First test if we have sufficient access to the FileInfo.
      bool fileAccess = false;
      try
      {
        fileAccess = fileInfo.Directory != null;
      }
      catch (SecurityException e)
      {
        ServiceScope.Get<ILogger>().Error("SecurityException when trying to access \"{0}\" - {1}", args.Path, e.Message);
      }
      catch (DirectoryNotFoundException e)
      {
        ServiceScope.Get<ILogger>().Error("DirectoryNotFoundException when trying to access \"{0}\" - {1}", args.Path,
                                          e.Message);
      }
      if (fileAccess)
      {
        if (fileInfo.DirectoryName + "\\" == _path)
          return true;
        // If we don't watch subdirectories,
        // and if the path's directory does not start with the one we want to watch.
        // --> Doesn't comply.
        if (!_includeSubdirectories
            && fileInfo.DirectoryName + "\\" != _path)
          return false;
        // If we watch subdirectories,
        // and the path doesn't start with the one we want to watch.
        // --> Doesn't comply.
        if (_includeSubdirectories
            && !(fileInfo.DirectoryName + "\\").StartsWith(_path))
          return false;
      }
      // Now lets check the changetype.
      if (!CompliesToChangeType(args.ChangeType))
        return false;
      // And lets check if the old path matches the filter.
      if (!CompliesToFilter(args.OldPath))
      {
            // No need to check the new path if it's the same as the old path.
        if (args.Path == args.OldPath
            // Check the new path, maybe this one matches.
            || !CompliesToFilter(args.Path))
          return false;
      }
      return true;
    }

    #endregion

    #region Private Methods

    /// <summary>
    /// Returns whether events may be raised for the given FileInfo.
    /// </summary>
    /// <param name="path">Path to compare to filter.</param>
    /// <returns></returns>
    private bool CompliesToFilter(string path)
    {
      FileInfo fileInfo = new FileInfo(path);
      if (_filter.Count == 0)
        // No filter defined, so will match anyway.
        return true;
      // Don't return inside of the lock.
      bool complies = false;
      lock (_filter)
      {
        foreach (string filterString in _filter)
        {
          // Convert the filterstring to a RegEx.
          string pattern = filterString.Replace("" + CharWildcard, ").+(");
          pattern = pattern.Replace("" + NumWildcard, @")\d(");
          pattern = pattern.TrimStart(')');
          pattern = pattern.TrimEnd('(');
          if (!pattern.StartsWith(".+") && !pattern.StartsWith(@"\d"))
            pattern = '(' + pattern;
          if (!pattern.EndsWith(".+") && !pattern.EndsWith(@"\d"))
            pattern = pattern + ')';
          pattern = pattern.Replace("()", "");
          pattern = "^" + pattern + "$";
          // Match the pattern to the filename.
          if (Regex.Match(fileInfo.Name, pattern).Success)
          {
            complies = true;
            break;
          }
        }
      }
      return complies;
    }

    /// <summary>
    /// Returns whether events may be raised for the given FileWatchChangType.
    /// </summary>
    /// <param name="changeType">FileWatchChangeType to test.</param>
    /// <returns></returns>
    private bool CompliesToChangeType(FileWatchChangeType changeType)
    {
      if (_changeTypes.Count == 0)
        return true;
      return (_changeTypes.Contains(changeType));
    }

    /// <summary>
    /// Sets the directory from the given path to the _path variable.
    /// If the specified path links to a file, the file is set to the filter.
    /// </summary>
    /// <param name="path">Path to set.</param>
    private void SetPath(string path)
    {
      // The code on the next line locks up for unavailable network shares.
      //  bool isDirectory = ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory);
      // So we'll have to guess if we're working with a file or directory.
      bool isDirectory = (path.EndsWith(@"\")       // Files will never end with '\'
                          || !path.Contains(@"\")); // It's a root
      // We can't check for extensions, some files might not have one.
      if (!isDirectory)
      {
        // We expect it to be a file
        int index = path.LastIndexOf('\\');
        _filter.Clear();
        _filter.Add(path.Substring(index));
        path = path.Substring(0, index);
      }
      else if (!path.EndsWith(@"\"))
      {
        path = path + @"\";
      }
      _path = path;
    }

    #endregion

  }
}