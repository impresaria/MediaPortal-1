#region Copyright (C) 2006 Team MediaPortal

/* 
 *	Copyright (C) 2006 Team MediaPortal
 *	http://www.team-mediaportal.com
 *
 *  This Program is free software; you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation; either version 2, or (at your option)
 *  any later version.
 *   
 *  This Program is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 *  GNU General Public License for more details.
 *   
 *  You should have received a copy of the GNU General Public License
 *  along with GNU Make; see the file COPYING.  If not, write to
 *  the Free Software Foundation, 675 Mass Ave, Cambridge, MA 02139, USA. 
 *  http://www.gnu.org/copyleft/gpl.html
 *
 */

#endregion

namespace SetupTv.Sections
{
  partial class TvMovieSetup
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.mpTabControl = new MediaPortal.UserInterface.Controls.MPTabControl();
      this.tabPageSettings = new System.Windows.Forms.TabPage();
      this.groupBoxInfos = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.linkLabelInfo = new System.Windows.Forms.LinkLabel();
      this.labelInfo = new System.Windows.Forms.Label();
      this.mpGroupBoxDescriptions = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.checkBoxSlowImport = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.mpGroupBoxGeneral = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.checkBoxEnableImport = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.checkBoxAdditionalInfo = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.checkBoxShowAudioFormat = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.checkBoxUseShortDesc = new MediaPortal.UserInterface.Controls.MPCheckBox();
      this.tabPageMapChannels = new MediaPortal.UserInterface.Controls.MPTabPage();
      this.labelNote = new MediaPortal.UserInterface.Controls.MPLabel();
      this.groupBoxMapping = new MediaPortal.UserInterface.Controls.MPGroupBox();
      this.panelTimeSpan = new System.Windows.Forms.Panel();
      this.maskedTextBoxTimeStart = new System.Windows.Forms.MaskedTextBox();
      this.label1 = new MediaPortal.UserInterface.Controls.MPLabel();
      this.maskedTextBoxTimeEnd = new System.Windows.Forms.MaskedTextBox();
      this.treeViewChannels = new System.Windows.Forms.TreeView();
      this.treeViewStations = new System.Windows.Forms.TreeView();
      this.listView1 = new MediaPortal.UserInterface.Controls.MPListView();
      this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
      this.listView2 = new MediaPortal.UserInterface.Controls.MPListView();
      this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
      this.mpTabControl.SuspendLayout();
      this.tabPageSettings.SuspendLayout();
      this.groupBoxInfos.SuspendLayout();
      this.mpGroupBoxDescriptions.SuspendLayout();
      this.mpGroupBoxGeneral.SuspendLayout();
      this.tabPageMapChannels.SuspendLayout();
      this.groupBoxMapping.SuspendLayout();
      this.panelTimeSpan.SuspendLayout();
      this.SuspendLayout();
      // 
      // openFileDialog
      // 
      this.openFileDialog.DefaultExt = "mdb";
      this.openFileDialog.FileName = "tvdaten.mdb";
      this.openFileDialog.Filter = "TV Movie Database|*.mdb";
      this.openFileDialog.RestoreDirectory = true;
      // 
      // mpTabControl
      // 
      this.mpTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.mpTabControl.Controls.Add(this.tabPageSettings);
      this.mpTabControl.Controls.Add(this.tabPageMapChannels);
      this.mpTabControl.Location = new System.Drawing.Point(0, 0);
      this.mpTabControl.Name = "mpTabControl";
      this.mpTabControl.SelectedIndex = 0;
      this.mpTabControl.Size = new System.Drawing.Size(464, 384);
      this.mpTabControl.TabIndex = 10;
      // 
      // tabPageSettings
      // 
      this.tabPageSettings.Controls.Add(this.groupBoxInfos);
      this.tabPageSettings.Controls.Add(this.mpGroupBoxDescriptions);
      this.tabPageSettings.Controls.Add(this.mpGroupBoxGeneral);
      this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
      this.tabPageSettings.Name = "tabPageSettings";
      this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageSettings.Size = new System.Drawing.Size(456, 358);
      this.tabPageSettings.TabIndex = 1;
      this.tabPageSettings.Text = "Settings";
      this.tabPageSettings.UseVisualStyleBackColor = true;
      // 
      // groupBoxInfos
      // 
      this.groupBoxInfos.Controls.Add(this.linkLabelInfo);
      this.groupBoxInfos.Controls.Add(this.labelInfo);
      this.groupBoxInfos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBoxInfos.Location = new System.Drawing.Point(16, 256);
      this.groupBoxInfos.Name = "groupBoxInfos";
      this.groupBoxInfos.Size = new System.Drawing.Size(424, 83);
      this.groupBoxInfos.TabIndex = 14;
      this.groupBoxInfos.TabStop = false;
      this.groupBoxInfos.Text = "Infos";
      // 
      // linkLabelInfo
      // 
      this.linkLabelInfo.AutoSize = true;
      this.linkLabelInfo.Location = new System.Drawing.Point(16, 48);
      this.linkLabelInfo.Name = "linkLabelInfo";
      this.linkLabelInfo.Size = new System.Drawing.Size(138, 13);
      this.linkLabelInfo.TabIndex = 1;
      this.linkLabelInfo.TabStop = true;
      this.linkLabelInfo.Text = "Click here to get more infos.";
      this.linkLabelInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
      // 
      // labelInfo
      // 
      this.labelInfo.AutoSize = true;
      this.labelInfo.Location = new System.Drawing.Point(16, 24);
      this.labelInfo.Name = "labelInfo";
      this.labelInfo.Size = new System.Drawing.Size(330, 13);
      this.labelInfo.TabIndex = 0;
      this.labelInfo.Text = "TV Movie Clickfinder is an EPG application for German TV channels.";
      // 
      // mpGroupBoxDescriptions
      // 
      this.mpGroupBoxDescriptions.Controls.Add(this.checkBoxSlowImport);
      this.mpGroupBoxDescriptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.mpGroupBoxDescriptions.Location = new System.Drawing.Point(16, 139);
      this.mpGroupBoxDescriptions.Name = "mpGroupBoxDescriptions";
      this.mpGroupBoxDescriptions.Size = new System.Drawing.Size(424, 56);
      this.mpGroupBoxDescriptions.TabIndex = 13;
      this.mpGroupBoxDescriptions.TabStop = false;
      this.mpGroupBoxDescriptions.Text = "Descriptions";
      // 
      // checkBoxSlowImport
      // 
      this.checkBoxSlowImport.AutoSize = true;
      this.checkBoxSlowImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxSlowImport.Location = new System.Drawing.Point(16, 26);
      this.checkBoxSlowImport.Name = "checkBoxSlowImport";
      this.checkBoxSlowImport.Size = new System.Drawing.Size(381, 17);
      this.checkBoxSlowImport.TabIndex = 11;
      this.checkBoxSlowImport.Text = "Slower import (uses less processing power to solve possible video stuttering)";
      this.checkBoxSlowImport.UseVisualStyleBackColor = true;
      // 
      // mpGroupBoxGeneral
      // 
      this.mpGroupBoxGeneral.Controls.Add(this.checkBoxEnableImport);
      this.mpGroupBoxGeneral.Controls.Add(this.checkBoxAdditionalInfo);
      this.mpGroupBoxGeneral.Controls.Add(this.checkBoxShowAudioFormat);
      this.mpGroupBoxGeneral.Controls.Add(this.checkBoxUseShortDesc);
      this.mpGroupBoxGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.mpGroupBoxGeneral.Location = new System.Drawing.Point(16, 16);
      this.mpGroupBoxGeneral.Name = "mpGroupBoxGeneral";
      this.mpGroupBoxGeneral.Size = new System.Drawing.Size(424, 120);
      this.mpGroupBoxGeneral.TabIndex = 0;
      this.mpGroupBoxGeneral.TabStop = false;
      this.mpGroupBoxGeneral.Text = "General";
      // 
      // checkBoxEnableImport
      // 
      this.checkBoxEnableImport.AutoSize = true;
      this.checkBoxEnableImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxEnableImport.Location = new System.Drawing.Point(16, 21);
      this.checkBoxEnableImport.Name = "checkBoxEnableImport";
      this.checkBoxEnableImport.Size = new System.Drawing.Size(189, 17);
      this.checkBoxEnableImport.TabIndex = 14;
      this.checkBoxEnableImport.Text = "Enable TV Movie Clickfinder import";
      this.checkBoxEnableImport.UseVisualStyleBackColor = true;
      // 
      // checkBoxAdditionalInfo
      // 
      this.checkBoxAdditionalInfo.AutoSize = true;
      this.checkBoxAdditionalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxAdditionalInfo.Location = new System.Drawing.Point(16, 64);
      this.checkBoxAdditionalInfo.Name = "checkBoxAdditionalInfo";
      this.checkBoxAdditionalInfo.Size = new System.Drawing.Size(222, 17);
      this.checkBoxAdditionalInfo.TabIndex = 13;
      this.checkBoxAdditionalInfo.Text = "Put additional info into the description field";
      this.checkBoxAdditionalInfo.UseVisualStyleBackColor = true;
      this.checkBoxAdditionalInfo.CheckedChanged += new System.EventHandler(this.checkBoxAdditionalInfo_CheckedChanged);
      // 
      // checkBoxShowAudioFormat
      // 
      this.checkBoxShowAudioFormat.AutoSize = true;
      this.checkBoxShowAudioFormat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxShowAudioFormat.Location = new System.Drawing.Point(16, 87);
      this.checkBoxShowAudioFormat.Name = "checkBoxShowAudioFormat";
      this.checkBoxShowAudioFormat.Size = new System.Drawing.Size(112, 17);
      this.checkBoxShowAudioFormat.TabIndex = 12;
      this.checkBoxShowAudioFormat.Text = "Show audio format";
      this.checkBoxShowAudioFormat.UseVisualStyleBackColor = true;
      // 
      // checkBoxUseShortDesc
      // 
      this.checkBoxUseShortDesc.AutoSize = true;
      this.checkBoxUseShortDesc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.checkBoxUseShortDesc.Location = new System.Drawing.Point(16, 42);
      this.checkBoxUseShortDesc.Name = "checkBoxUseShortDesc";
      this.checkBoxUseShortDesc.Size = new System.Drawing.Size(128, 17);
      this.checkBoxUseShortDesc.TabIndex = 11;
      this.checkBoxUseShortDesc.Text = "Use short descriptions";
      this.checkBoxUseShortDesc.UseVisualStyleBackColor = true;
      this.checkBoxUseShortDesc.CheckedChanged += new System.EventHandler(this.checkBoxUseShortDesc_CheckedChanged);
      // 
      // tabPageMapChannels
      // 
      this.tabPageMapChannels.Controls.Add(this.labelNote);
      this.tabPageMapChannels.Controls.Add(this.groupBoxMapping);
      this.tabPageMapChannels.Location = new System.Drawing.Point(4, 22);
      this.tabPageMapChannels.Name = "tabPageMapChannels";
      this.tabPageMapChannels.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageMapChannels.Size = new System.Drawing.Size(456, 358);
      this.tabPageMapChannels.TabIndex = 0;
      this.tabPageMapChannels.Text = "Map Channels";
      this.tabPageMapChannels.UseVisualStyleBackColor = true;
      // 
      // labelNote
      // 
      this.labelNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.labelNote.AutoSize = true;
      this.labelNote.Location = new System.Drawing.Point(218, 333);
      this.labelNote.Name = "labelNote";
      this.labelNote.Size = new System.Drawing.Size(223, 13);
      this.labelNote.TabIndex = 6;
      this.labelNote.Text = "Note: Use doubleclick to map/unmap stations";
      this.labelNote.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // groupBoxMapping
      // 
      this.groupBoxMapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBoxMapping.Controls.Add(this.panelTimeSpan);
      this.groupBoxMapping.Controls.Add(this.treeViewChannels);
      this.groupBoxMapping.Controls.Add(this.treeViewStations);
      this.groupBoxMapping.Controls.Add(this.listView1);
      this.groupBoxMapping.Controls.Add(this.listView2);
      this.groupBoxMapping.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.groupBoxMapping.Location = new System.Drawing.Point(16, 16);
      this.groupBoxMapping.Name = "groupBoxMapping";
      this.groupBoxMapping.Size = new System.Drawing.Size(424, 312);
      this.groupBoxMapping.TabIndex = 5;
      this.groupBoxMapping.TabStop = false;
      this.groupBoxMapping.Text = "Map Channels to TV Movie Stations";
      // 
      // panelTimeSpan
      // 
      this.panelTimeSpan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.panelTimeSpan.AutoSize = true;
      this.panelTimeSpan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panelTimeSpan.Controls.Add(this.maskedTextBoxTimeStart);
      this.panelTimeSpan.Controls.Add(this.label1);
      this.panelTimeSpan.Controls.Add(this.maskedTextBoxTimeEnd);
      this.panelTimeSpan.Location = new System.Drawing.Point(64, 279);
      this.panelTimeSpan.Name = "panelTimeSpan";
      this.panelTimeSpan.Size = new System.Drawing.Size(139, 27);
      this.panelTimeSpan.TabIndex = 7;
      this.panelTimeSpan.Visible = false;
      // 
      // maskedTextBoxTimeStart
      // 
      this.maskedTextBoxTimeStart.AsciiOnly = true;
      this.maskedTextBoxTimeStart.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
      this.maskedTextBoxTimeStart.Location = new System.Drawing.Point(0, 4);
      this.maskedTextBoxTimeStart.Mask = "90:00";
      this.maskedTextBoxTimeStart.Name = "maskedTextBoxTimeStart";
      this.maskedTextBoxTimeStart.PromptChar = '0';
      this.maskedTextBoxTimeStart.RejectInputOnFirstFailure = true;
      this.maskedTextBoxTimeStart.Size = new System.Drawing.Size(56, 20);
      this.maskedTextBoxTimeStart.TabIndex = 7;
      this.maskedTextBoxTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.maskedTextBoxTimeStart.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
      this.maskedTextBoxTimeStart.ValidatingType = typeof(System.DateTime);
      this.maskedTextBoxTimeStart.Validated += new System.EventHandler(this.maskedTextBoxTimeStart_Validated);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(63, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(10, 13);
      this.label1.TabIndex = 7;
      this.label1.Text = "-";
      // 
      // maskedTextBoxTimeEnd
      // 
      this.maskedTextBoxTimeEnd.AsciiOnly = true;
      this.maskedTextBoxTimeEnd.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
      this.maskedTextBoxTimeEnd.Location = new System.Drawing.Point(80, 4);
      this.maskedTextBoxTimeEnd.Mask = "90:00";
      this.maskedTextBoxTimeEnd.Name = "maskedTextBoxTimeEnd";
      this.maskedTextBoxTimeEnd.PromptChar = '0';
      this.maskedTextBoxTimeEnd.RejectInputOnFirstFailure = true;
      this.maskedTextBoxTimeEnd.Size = new System.Drawing.Size(56, 20);
      this.maskedTextBoxTimeEnd.TabIndex = 8;
      this.maskedTextBoxTimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.maskedTextBoxTimeEnd.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
      this.maskedTextBoxTimeEnd.ValidatingType = typeof(System.DateTime);
      this.maskedTextBoxTimeEnd.Validated += new System.EventHandler(this.maskedTextBoxTimeEnd_Validated);
      // 
      // treeViewChannels
      // 
      this.treeViewChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Left)));
      this.treeViewChannels.HideSelection = false;
      this.treeViewChannels.Location = new System.Drawing.Point(16, 48);
      this.treeViewChannels.Name = "treeViewChannels";
      this.treeViewChannels.ShowNodeToolTips = true;
      this.treeViewChannels.ShowPlusMinus = false;
      this.treeViewChannels.ShowRootLines = false;
      this.treeViewChannels.Size = new System.Drawing.Size(216, 225);
      this.treeViewChannels.Sorted = true;
      this.treeViewChannels.TabIndex = 1;
      this.treeViewChannels.DoubleClick += new System.EventHandler(this.treeViewChannels_DoubleClick);
      this.treeViewChannels.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewChannels_AfterSelect);
      // 
      // treeViewStations
      // 
      this.treeViewStations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.treeViewStations.HideSelection = false;
      this.treeViewStations.Location = new System.Drawing.Point(240, 48);
      this.treeViewStations.Name = "treeViewStations";
      this.treeViewStations.ShowNodeToolTips = true;
      this.treeViewStations.ShowPlusMinus = false;
      this.treeViewStations.ShowRootLines = false;
      this.treeViewStations.Size = new System.Drawing.Size(168, 248);
      this.treeViewStations.Sorted = true;
      this.treeViewStations.TabIndex = 2;
      this.treeViewStations.DoubleClick += new System.EventHandler(this.treeViewStations_DoubleClick);
      // 
      // listView1
      // 
      this.listView1.AllowDrop = true;
      this.listView1.AllowRowReorder = true;
      this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
      this.listView1.Location = new System.Drawing.Point(16, 27);
      this.listView1.Name = "listView1";
      this.listView1.Scrollable = false;
      this.listView1.Size = new System.Drawing.Size(216, 24);
      this.listView1.TabIndex = 8;
      this.listView1.UseCompatibleStateImageBehavior = false;
      this.listView1.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "MediaPortal Channels";
      this.columnHeader1.Width = 262;
      // 
      // listView2
      // 
      this.listView2.AllowDrop = true;
      this.listView2.AllowRowReorder = true;
      this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
      this.listView2.Location = new System.Drawing.Point(240, 27);
      this.listView2.Name = "listView2";
      this.listView2.Scrollable = false;
      this.listView2.Size = new System.Drawing.Size(168, 24);
      this.listView2.TabIndex = 9;
      this.listView2.UseCompatibleStateImageBehavior = false;
      this.listView2.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "TV Movie Stations";
      this.columnHeader2.Width = 179;
      // 
      // TvMovieSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.mpTabControl);
      this.Name = "TvMovieSetup";
      this.Size = new System.Drawing.Size(467, 388);
      this.mpTabControl.ResumeLayout(false);
      this.tabPageSettings.ResumeLayout(false);
      this.groupBoxInfos.ResumeLayout(false);
      this.groupBoxInfos.PerformLayout();
      this.mpGroupBoxDescriptions.ResumeLayout(false);
      this.mpGroupBoxDescriptions.PerformLayout();
      this.mpGroupBoxGeneral.ResumeLayout(false);
      this.mpGroupBoxGeneral.PerformLayout();
      this.tabPageMapChannels.ResumeLayout(false);
      this.tabPageMapChannels.PerformLayout();
      this.groupBoxMapping.ResumeLayout(false);
      this.groupBoxMapping.PerformLayout();
      this.panelTimeSpan.ResumeLayout(false);
      this.panelTimeSpan.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private MediaPortal.UserInterface.Controls.MPTabControl mpTabControl;
    private MediaPortal.UserInterface.Controls.MPTabPage tabPageMapChannels;
    private MediaPortal.UserInterface.Controls.MPLabel labelNote;
    private MediaPortal.UserInterface.Controls.MPGroupBox groupBoxMapping;
    private System.Windows.Forms.Panel panelTimeSpan;
    private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeStart;
    private MediaPortal.UserInterface.Controls.MPLabel label1;
    private System.Windows.Forms.MaskedTextBox maskedTextBoxTimeEnd;
    private System.Windows.Forms.TreeView treeViewChannels;
    private System.Windows.Forms.TreeView treeViewStations;
    private MediaPortal.UserInterface.Controls.MPListView listView1;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private MediaPortal.UserInterface.Controls.MPListView listView2;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.TabPage tabPageSettings;
    private MediaPortal.UserInterface.Controls.MPGroupBox mpGroupBoxDescriptions;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxSlowImport;
    private MediaPortal.UserInterface.Controls.MPGroupBox mpGroupBoxGeneral;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxAdditionalInfo;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxShowAudioFormat;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxUseShortDesc;
    private MediaPortal.UserInterface.Controls.MPCheckBox checkBoxEnableImport;
    private MediaPortal.UserInterface.Controls.MPGroupBox groupBoxInfos;
    private System.Windows.Forms.LinkLabel linkLabelInfo;
    private System.Windows.Forms.Label labelInfo;
  }
}
