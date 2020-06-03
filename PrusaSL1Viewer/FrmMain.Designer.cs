﻿namespace PrusaSL1Viewer
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpenNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileReload = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExtract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileConvert = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMutate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolsRepairLayers = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpDonate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.menuHelpInstallPrinters = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.sbLayers = new System.Windows.Forms.VScrollBar();
            this.mainTable = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbLayers = new System.Windows.Forms.Label();
            this.scCenter = new System.Windows.Forms.SplitContainer();
            this.pbLayer = new Cyotek.Windows.Forms.ImageBox();
            this.tsLayer = new System.Windows.Forms.ToolStrip();
            this.tsLayerImageExport = new System.Windows.Forms.ToolStripButton();
            this.tsLayerResolution = new System.Windows.Forms.ToolStripLabel();
            this.tsLayerImageRotate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLayerImageLayerDifference = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLayerPreviewTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLayerImageLayerOutline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLayerImagePixelEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLayerImageZoom = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.tsLayerImageMouseLocation = new System.Windows.Forms.ToolStripLabel();
            this.pbLayers = new System.Windows.Forms.ProgressBar();
            this.tabControlLeft = new System.Windows.Forms.TabControl();
            this.tbpThumbnailsAndInfo = new System.Windows.Forms.TabPage();
            this.scLeft = new System.Windows.Forms.SplitContainer();
            this.pbThumbnail = new System.Windows.Forms.PictureBox();
            this.tsThumbnails = new System.Windows.Forms.ToolStrip();
            this.tsThumbnailsPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsThumbnailsCount = new System.Windows.Forms.ToolStripLabel();
            this.tsThumbnailsNext = new System.Windows.Forms.ToolStripButton();
            this.tsThumbnailsExport = new System.Windows.Forms.ToolStripButton();
            this.tsThumbnailsResolution = new System.Windows.Forms.ToolStripLabel();
            this.lvProperties = new System.Windows.Forms.ListView();
            this.lvChKey = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvChValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsProperties = new System.Windows.Forms.ToolStrip();
            this.tsPropertiesLabelCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsPropertiesLabelGroups = new System.Windows.Forms.ToolStripLabel();
            this.tsPropertiesButtonSave = new System.Windows.Forms.ToolStripButton();
            this.tabPageGCode = new System.Windows.Forms.TabPage();
            this.tbGCode = new System.Windows.Forms.TextBox();
            this.tsGCode = new System.Windows.Forms.ToolStrip();
            this.tsGCodeLabelLines = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsGcodeLabelChars = new System.Windows.Forms.ToolStripLabel();
            this.tsGCodeButtonSave = new System.Windows.Forms.ToolStripButton();
            this.tabPageIslands = new System.Windows.Forms.TabPage();
            this.lvIslands = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsIslands = new System.Windows.Forms.ToolStrip();
            this.tsIslandsPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsIslandsCount = new System.Windows.Forms.ToolStripLabel();
            this.tsIslandsNext = new System.Windows.Forms.ToolStripButton();
            this.tsIslandsRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tsIslandsRemove = new System.Windows.Forms.ToolStripButton();
            this.imageList16x16 = new System.Windows.Forms.ImageList(this.components);
            this.menu.SuspendLayout();
            this.mainTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCenter)).BeginInit();
            this.scCenter.Panel1.SuspendLayout();
            this.scCenter.Panel2.SuspendLayout();
            this.scCenter.SuspendLayout();
            this.tsLayer.SuspendLayout();
            this.tabControlLeft.SuspendLayout();
            this.tbpThumbnailsAndInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).BeginInit();
            this.scLeft.Panel1.SuspendLayout();
            this.scLeft.Panel2.SuspendLayout();
            this.scLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).BeginInit();
            this.tsThumbnails.SuspendLayout();
            this.tsProperties.SuspendLayout();
            this.tabPageGCode.SuspendLayout();
            this.tsGCode.SuspendLayout();
            this.tabPageIslands.SuspendLayout();
            this.tsIslands.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.menuEdit,
            this.menuMutate,
            this.menuTools,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1631, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuFileOpenNewWindow,
            this.menuFileReload,
            this.menuFileSave,
            this.menuFileSaveAs,
            this.menuFileClose,
            this.toolStripSeparator1,
            this.menuFileExtract,
            this.menuFileConvert,
            this.toolStripSeparator2,
            this.menuFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Image = global::PrusaSL1Viewer.Properties.Resources.Open_16x16;
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(261, 22);
            this.menuFileOpen.Text = "&Open";
            this.menuFileOpen.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuFileOpenNewWindow
            // 
            this.menuFileOpenNewWindow.Image = global::PrusaSL1Viewer.Properties.Resources.Open_16x16;
            this.menuFileOpenNewWindow.Name = "menuFileOpenNewWindow";
            this.menuFileOpenNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.menuFileOpenNewWindow.Size = new System.Drawing.Size(261, 22);
            this.menuFileOpenNewWindow.Text = "Open in new window";
            this.menuFileOpenNewWindow.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuFileReload
            // 
            this.menuFileReload.Image = global::PrusaSL1Viewer.Properties.Resources.File_Refresh_16x16;
            this.menuFileReload.Name = "menuFileReload";
            this.menuFileReload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.menuFileReload.Size = new System.Drawing.Size(261, 22);
            this.menuFileReload.Text = "&Reload";
            this.menuFileReload.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Enabled = false;
            this.menuFileSave.Image = global::PrusaSL1Viewer.Properties.Resources.Save_16x16;
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(261, 22);
            this.menuFileSave.Text = "&Save";
            this.menuFileSave.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuFileSaveAs
            // 
            this.menuFileSaveAs.Enabled = false;
            this.menuFileSaveAs.Image = global::PrusaSL1Viewer.Properties.Resources.SaveAs_16x16;
            this.menuFileSaveAs.Name = "menuFileSaveAs";
            this.menuFileSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.menuFileSaveAs.Size = new System.Drawing.Size(261, 22);
            this.menuFileSaveAs.Text = "Save As";
            this.menuFileSaveAs.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuFileClose
            // 
            this.menuFileClose.Enabled = false;
            this.menuFileClose.Image = global::PrusaSL1Viewer.Properties.Resources.File_Close_16x16;
            this.menuFileClose.Name = "menuFileClose";
            this.menuFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuFileClose.Size = new System.Drawing.Size(261, 22);
            this.menuFileClose.Text = "&Close";
            this.menuFileClose.Click += new System.EventHandler(this.ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(258, 6);
            // 
            // menuFileExtract
            // 
            this.menuFileExtract.Enabled = false;
            this.menuFileExtract.Image = global::PrusaSL1Viewer.Properties.Resources.Extract_object_16x16;
            this.menuFileExtract.Name = "menuFileExtract";
            this.menuFileExtract.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuFileExtract.Size = new System.Drawing.Size(261, 22);
            this.menuFileExtract.Text = "&Extract";
            this.menuFileExtract.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuFileConvert
            // 
            this.menuFileConvert.Enabled = false;
            this.menuFileConvert.Image = global::PrusaSL1Viewer.Properties.Resources.Convert_16x16;
            this.menuFileConvert.Name = "menuFileConvert";
            this.menuFileConvert.Size = new System.Drawing.Size(261, 22);
            this.menuFileConvert.Text = "&Convert To";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(258, 6);
            // 
            // menuFileExit
            // 
            this.menuFileExit.Image = global::PrusaSL1Viewer.Properties.Resources.Exit_16x16;
            this.menuFileExit.Name = "menuFileExit";
            this.menuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuFileExit.Size = new System.Drawing.Size(261, 22);
            this.menuFileExit.Text = "&Exit";
            this.menuFileExit.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuEdit
            // 
            this.menuEdit.Enabled = false;
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.Size = new System.Drawing.Size(39, 20);
            this.menuEdit.Text = "&Edit";
            // 
            // menuMutate
            // 
            this.menuMutate.Enabled = false;
            this.menuMutate.Name = "menuMutate";
            this.menuMutate.Size = new System.Drawing.Size(57, 20);
            this.menuMutate.Text = "&Mutate";
            // 
            // menuTools
            // 
            this.menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolsRepairLayers});
            this.menuTools.Enabled = false;
            this.menuTools.Name = "menuTools";
            this.menuTools.Size = new System.Drawing.Size(46, 20);
            this.menuTools.Text = "&Tools";
            // 
            // menuToolsRepairLayers
            // 
            this.menuToolsRepairLayers.Image = global::PrusaSL1Viewer.Properties.Resources.Wrench_16x16;
            this.menuToolsRepairLayers.Name = "menuToolsRepairLayers";
            this.menuToolsRepairLayers.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.R)));
            this.menuToolsRepairLayers.Size = new System.Drawing.Size(204, 22);
            this.menuToolsRepairLayers.Text = "&Repair layers";
            this.menuToolsRepairLayers.Click += new System.EventHandler(this.ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Visible = false;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHelpWebsite,
            this.menuHelpDonate,
            this.menuHelpAbout,
            this.toolStripSeparator10,
            this.menuHelpInstallPrinters});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuHelpWebsite
            // 
            this.menuHelpWebsite.Image = global::PrusaSL1Viewer.Properties.Resources.Global_Network_icon_16x16;
            this.menuHelpWebsite.Name = "menuHelpWebsite";
            this.menuHelpWebsite.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.W)));
            this.menuHelpWebsite.Size = new System.Drawing.Size(229, 22);
            this.menuHelpWebsite.Text = "&Website";
            this.menuHelpWebsite.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuHelpDonate
            // 
            this.menuHelpDonate.Image = global::PrusaSL1Viewer.Properties.Resources.Donate_16x16;
            this.menuHelpDonate.Name = "menuHelpDonate";
            this.menuHelpDonate.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuHelpDonate.Size = new System.Drawing.Size(229, 22);
            this.menuHelpDonate.Text = "&Donate";
            this.menuHelpDonate.Click += new System.EventHandler(this.ItemClicked);
            // 
            // menuHelpAbout
            // 
            this.menuHelpAbout.Image = global::PrusaSL1Viewer.Properties.Resources.Button_Info_16x16;
            this.menuHelpAbout.Name = "menuHelpAbout";
            this.menuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuHelpAbout.Size = new System.Drawing.Size(229, 22);
            this.menuHelpAbout.Text = "&About";
            this.menuHelpAbout.Click += new System.EventHandler(this.ItemClicked);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(226, 6);
            // 
            // menuHelpInstallPrinters
            // 
            this.menuHelpInstallPrinters.Image = global::PrusaSL1Viewer.Properties.Resources.CNCMachine_16x16;
            this.menuHelpInstallPrinters.Name = "menuHelpInstallPrinters";
            this.menuHelpInstallPrinters.Size = new System.Drawing.Size(229, 22);
            this.menuHelpInstallPrinters.Text = "Instal printers into PrusaSlicer";
            this.menuHelpInstallPrinters.Click += new System.EventHandler(this.ItemClicked);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 761);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1631, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // sbLayers
            // 
            this.sbLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbLayers.Enabled = false;
            this.sbLayers.LargeChange = 1;
            this.sbLayers.Location = new System.Drawing.Point(0, 0);
            this.sbLayers.Name = "sbLayers";
            this.sbLayers.Size = new System.Drawing.Size(124, 670);
            this.sbLayers.TabIndex = 4;
            this.sbLayers.ValueChanged += new System.EventHandler(this.sbLayers_ValueChanged);
            // 
            // mainTable
            // 
            this.mainTable.ColumnCount = 3;
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.mainTable.Controls.Add(this.splitContainer1, 2, 0);
            this.mainTable.Controls.Add(this.scCenter, 1, 0);
            this.mainTable.Controls.Add(this.tabControlLeft, 0, 0);
            this.mainTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTable.Location = new System.Drawing.Point(0, 24);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowCount = 1;
            this.mainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTable.Size = new System.Drawing.Size(1631, 737);
            this.mainTable.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(1504, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sbLayers);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbLayers);
            this.splitContainer1.Size = new System.Drawing.Size(124, 731);
            this.splitContainer1.SplitterDistance = 670;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbLayers
            // 
            this.lbLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLayers.Location = new System.Drawing.Point(0, 0);
            this.lbLayers.Name = "lbLayers";
            this.lbLayers.Size = new System.Drawing.Size(124, 57);
            this.lbLayers.TabIndex = 0;
            this.lbLayers.Text = "Layers";
            this.lbLayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scCenter
            // 
            this.scCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scCenter.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scCenter.IsSplitterFixed = true;
            this.scCenter.Location = new System.Drawing.Point(403, 3);
            this.scCenter.Name = "scCenter";
            this.scCenter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scCenter.Panel1
            // 
            this.scCenter.Panel1.Controls.Add(this.pbLayer);
            this.scCenter.Panel1.Controls.Add(this.tsLayer);
            // 
            // scCenter.Panel2
            // 
            this.scCenter.Panel2.Controls.Add(this.pbLayers);
            this.scCenter.Panel2MinSize = 18;
            this.scCenter.Size = new System.Drawing.Size(1095, 731);
            this.scCenter.SplitterDistance = 702;
            this.scCenter.TabIndex = 4;
            // 
            // pbLayer
            // 
            this.pbLayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLayer.GridScale = Cyotek.Windows.Forms.ImageBoxGridScale.Large;
            this.pbLayer.Location = new System.Drawing.Point(0, 25);
            this.pbLayer.Name = "pbLayer";
            this.pbLayer.PanMode = Cyotek.Windows.Forms.ImageBoxPanMode.Left;
            this.pbLayer.ShowPixelGrid = true;
            this.pbLayer.Size = new System.Drawing.Size(1095, 677);
            this.pbLayer.TabIndex = 7;
            this.pbLayer.Zoomed += new System.EventHandler<Cyotek.Windows.Forms.ImageBoxZoomEventArgs>(this.pbLayer_Zoomed);
            this.pbLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbLayer_MouseMove);
            this.pbLayer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbLayer_MouseUp);
            // 
            // tsLayer
            // 
            this.tsLayer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLayerImageExport,
            this.tsLayerResolution,
            this.tsLayerImageRotate,
            this.toolStripSeparator5,
            this.tsLayerImageLayerDifference,
            this.toolStripSeparator6,
            this.tsLayerPreviewTime,
            this.toolStripSeparator7,
            this.tsLayerImageLayerOutline,
            this.toolStripSeparator9,
            this.tsLayerImagePixelEdit,
            this.toolStripSeparator8,
            this.tsLayerImageZoom,
            this.toolStripSeparator11,
            this.tsLayerImageMouseLocation});
            this.tsLayer.Location = new System.Drawing.Point(0, 0);
            this.tsLayer.Name = "tsLayer";
            this.tsLayer.Size = new System.Drawing.Size(1095, 25);
            this.tsLayer.TabIndex = 6;
            this.tsLayer.Text = "Layer Menu";
            // 
            // tsLayerImageExport
            // 
            this.tsLayerImageExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLayerImageExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLayerImageExport.Enabled = false;
            this.tsLayerImageExport.Image = global::PrusaSL1Viewer.Properties.Resources.Save_16x16;
            this.tsLayerImageExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLayerImageExport.Name = "tsLayerImageExport";
            this.tsLayerImageExport.Size = new System.Drawing.Size(23, 22);
            this.tsLayerImageExport.Text = "Save Layer";
            this.tsLayerImageExport.ToolTipText = "Save layer image to file";
            this.tsLayerImageExport.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tsLayerResolution
            // 
            this.tsLayerResolution.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLayerResolution.Name = "tsLayerResolution";
            this.tsLayerResolution.Size = new System.Drawing.Size(63, 22);
            this.tsLayerResolution.Text = "Resolution";
            this.tsLayerResolution.ToolTipText = "Layer Resolution";
            // 
            // tsLayerImageRotate
            // 
            this.tsLayerImageRotate.Checked = true;
            this.tsLayerImageRotate.CheckOnClick = true;
            this.tsLayerImageRotate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsLayerImageRotate.Image = global::PrusaSL1Viewer.Properties.Resources.Rotate_16x16;
            this.tsLayerImageRotate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLayerImageRotate.Name = "tsLayerImageRotate";
            this.tsLayerImageRotate.Size = new System.Drawing.Size(117, 22);
            this.tsLayerImageRotate.Text = "Rotate Image 90º";
            this.tsLayerImageRotate.ToolTipText = "Auto rotate layer preview image at 90º (This can slow down the layer preview) [CT" +
    "RL+R]";
            this.tsLayerImageRotate.Click += new System.EventHandler(this.ItemClicked);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLayerImageLayerDifference
            // 
            this.tsLayerImageLayerDifference.CheckOnClick = true;
            this.tsLayerImageLayerDifference.Image = global::PrusaSL1Viewer.Properties.Resources.layers_16x16;
            this.tsLayerImageLayerDifference.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLayerImageLayerDifference.Name = "tsLayerImageLayerDifference";
            this.tsLayerImageLayerDifference.Size = new System.Drawing.Size(81, 22);
            this.tsLayerImageLayerDifference.Text = "Difference";
            this.tsLayerImageLayerDifference.ToolTipText = "Show layer differences where daker pixels were also present on previous layer and" +
    " the white pixels the difference between previous and current layer.";
            this.tsLayerImageLayerDifference.Click += new System.EventHandler(this.ItemClicked);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLayerPreviewTime
            // 
            this.tsLayerPreviewTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsLayerPreviewTime.Name = "tsLayerPreviewTime";
            this.tsLayerPreviewTime.Size = new System.Drawing.Size(77, 22);
            this.tsLayerPreviewTime.Text = "Preview Time";
            this.tsLayerPreviewTime.ToolTipText = "Layer Resolution";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLayerImageLayerOutline
            // 
            this.tsLayerImageLayerOutline.CheckOnClick = true;
            this.tsLayerImageLayerOutline.Image = global::PrusaSL1Viewer.Properties.Resources.Geometry_16x16;
            this.tsLayerImageLayerOutline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLayerImageLayerOutline.Name = "tsLayerImageLayerOutline";
            this.tsLayerImageLayerOutline.Size = new System.Drawing.Size(66, 22);
            this.tsLayerImageLayerOutline.Text = "Outline";
            this.tsLayerImageLayerOutline.ToolTipText = "Show layer outlines only";
            this.tsLayerImageLayerOutline.Click += new System.EventHandler(this.ItemClicked);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLayerImagePixelEdit
            // 
            this.tsLayerImagePixelEdit.CheckOnClick = true;
            this.tsLayerImagePixelEdit.Image = global::PrusaSL1Viewer.Properties.Resources.pixel_16x16;
            this.tsLayerImagePixelEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLayerImagePixelEdit.Name = "tsLayerImagePixelEdit";
            this.tsLayerImagePixelEdit.Size = new System.Drawing.Size(75, 22);
            this.tsLayerImagePixelEdit.Text = "Pixel Edit";
            this.tsLayerImagePixelEdit.ToolTipText = "Edit layer image pixels (Righ click to add pixel and SHIFT + Right click to remov" +
    "e pixel)\r\nRed pixels are removed pixels\r\nGreen pixels are added pixels";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLayerImageZoom
            // 
            this.tsLayerImageZoom.Image = global::PrusaSL1Viewer.Properties.Resources.search_16x16;
            this.tsLayerImageZoom.Name = "tsLayerImageZoom";
            this.tsLayerImageZoom.Size = new System.Drawing.Size(89, 22);
            this.tsLayerImageZoom.Text = "Zoom: 100%";
            this.tsLayerImageZoom.ToolTipText = "Layer image zoom level, use mouse scroll to zoom in/out into image\r\nCtrl + 0 to s" +
    "cale to fit";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // tsLayerImageMouseLocation
            // 
            this.tsLayerImageMouseLocation.Image = global::PrusaSL1Viewer.Properties.Resources.pointer_16x16;
            this.tsLayerImageMouseLocation.Name = "tsLayerImageMouseLocation";
            this.tsLayerImageMouseLocation.Size = new System.Drawing.Size(79, 22);
            this.tsLayerImageMouseLocation.Text = "{X=0, Y=0}";
            this.tsLayerImageMouseLocation.ToolTipText = "Mouse over pixel location and pixel brightness";
            // 
            // pbLayers
            // 
            this.pbLayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLayers.Location = new System.Drawing.Point(0, 0);
            this.pbLayers.Name = "pbLayers";
            this.pbLayers.Size = new System.Drawing.Size(1095, 25);
            this.pbLayers.Step = 1;
            this.pbLayers.TabIndex = 6;
            // 
            // tabControlLeft
            // 
            this.tabControlLeft.Controls.Add(this.tbpThumbnailsAndInfo);
            this.tabControlLeft.Controls.Add(this.tabPageGCode);
            this.tabControlLeft.Controls.Add(this.tabPageIslands);
            this.tabControlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLeft.ImageList = this.imageList16x16;
            this.tabControlLeft.ItemSize = new System.Drawing.Size(130, 19);
            this.tabControlLeft.Location = new System.Drawing.Point(3, 3);
            this.tabControlLeft.Name = "tabControlLeft";
            this.tabControlLeft.SelectedIndex = 0;
            this.tabControlLeft.Size = new System.Drawing.Size(394, 731);
            this.tabControlLeft.TabIndex = 5;
            // 
            // tbpThumbnailsAndInfo
            // 
            this.tbpThumbnailsAndInfo.Controls.Add(this.scLeft);
            this.tbpThumbnailsAndInfo.ImageKey = "PhotoInfo-16x16.png";
            this.tbpThumbnailsAndInfo.Location = new System.Drawing.Point(4, 23);
            this.tbpThumbnailsAndInfo.Name = "tbpThumbnailsAndInfo";
            this.tbpThumbnailsAndInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpThumbnailsAndInfo.Size = new System.Drawing.Size(386, 704);
            this.tbpThumbnailsAndInfo.TabIndex = 0;
            this.tbpThumbnailsAndInfo.Text = "Information";
            this.tbpThumbnailsAndInfo.UseVisualStyleBackColor = true;
            // 
            // scLeft
            // 
            this.scLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLeft.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scLeft.Location = new System.Drawing.Point(3, 3);
            this.scLeft.Name = "scLeft";
            this.scLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLeft.Panel1
            // 
            this.scLeft.Panel1.Controls.Add(this.pbThumbnail);
            this.scLeft.Panel1.Controls.Add(this.tsThumbnails);
            this.scLeft.Panel1MinSize = 150;
            // 
            // scLeft.Panel2
            // 
            this.scLeft.Panel2.Controls.Add(this.lvProperties);
            this.scLeft.Panel2.Controls.Add(this.tsProperties);
            this.scLeft.Size = new System.Drawing.Size(380, 698);
            this.scLeft.SplitterDistance = 425;
            this.scLeft.TabIndex = 4;
            // 
            // pbThumbnail
            // 
            this.pbThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbThumbnail.Location = new System.Drawing.Point(0, 25);
            this.pbThumbnail.Name = "pbThumbnail";
            this.pbThumbnail.Size = new System.Drawing.Size(380, 400);
            this.pbThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbThumbnail.TabIndex = 4;
            this.pbThumbnail.TabStop = false;
            // 
            // tsThumbnails
            // 
            this.tsThumbnails.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsThumbnails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsThumbnailsPrevious,
            this.tsThumbnailsCount,
            this.tsThumbnailsNext,
            this.tsThumbnailsExport,
            this.tsThumbnailsResolution});
            this.tsThumbnails.Location = new System.Drawing.Point(0, 0);
            this.tsThumbnails.Name = "tsThumbnails";
            this.tsThumbnails.Size = new System.Drawing.Size(380, 25);
            this.tsThumbnails.TabIndex = 5;
            this.tsThumbnails.Text = "Thumbnail Menu";
            // 
            // tsThumbnailsPrevious
            // 
            this.tsThumbnailsPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsThumbnailsPrevious.Enabled = false;
            this.tsThumbnailsPrevious.Image = global::PrusaSL1Viewer.Properties.Resources.Back_16x16;
            this.tsThumbnailsPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThumbnailsPrevious.Name = "tsThumbnailsPrevious";
            this.tsThumbnailsPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsThumbnailsPrevious.Text = "toolStripButton1";
            this.tsThumbnailsPrevious.ToolTipText = "Show previous thumbnail";
            this.tsThumbnailsPrevious.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tsThumbnailsCount
            // 
            this.tsThumbnailsCount.Enabled = false;
            this.tsThumbnailsCount.Name = "tsThumbnailsCount";
            this.tsThumbnailsCount.Size = new System.Drawing.Size(24, 22);
            this.tsThumbnailsCount.Tag = "";
            this.tsThumbnailsCount.Text = "0/0";
            // 
            // tsThumbnailsNext
            // 
            this.tsThumbnailsNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsThumbnailsNext.Enabled = false;
            this.tsThumbnailsNext.Image = global::PrusaSL1Viewer.Properties.Resources.Next_16x16;
            this.tsThumbnailsNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThumbnailsNext.Name = "tsThumbnailsNext";
            this.tsThumbnailsNext.Size = new System.Drawing.Size(23, 22);
            this.tsThumbnailsNext.Text = "toolStripButton2";
            this.tsThumbnailsNext.ToolTipText = "Show next thumbnail";
            this.tsThumbnailsNext.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tsThumbnailsExport
            // 
            this.tsThumbnailsExport.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsThumbnailsExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsThumbnailsExport.Enabled = false;
            this.tsThumbnailsExport.Image = global::PrusaSL1Viewer.Properties.Resources.Save_16x16;
            this.tsThumbnailsExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsThumbnailsExport.Name = "tsThumbnailsExport";
            this.tsThumbnailsExport.Size = new System.Drawing.Size(23, 22);
            this.tsThumbnailsExport.Text = "Save Thumbnail";
            this.tsThumbnailsExport.ToolTipText = "Save thumbnail to file";
            this.tsThumbnailsExport.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tsThumbnailsResolution
            // 
            this.tsThumbnailsResolution.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsThumbnailsResolution.Name = "tsThumbnailsResolution";
            this.tsThumbnailsResolution.Size = new System.Drawing.Size(63, 22);
            this.tsThumbnailsResolution.Text = "Resolution";
            this.tsThumbnailsResolution.ToolTipText = "Thumbnail Resolution";
            // 
            // lvProperties
            // 
            this.lvProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvChKey,
            this.lvChValue});
            this.lvProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProperties.FullRowSelect = true;
            this.lvProperties.GridLines = true;
            this.lvProperties.HideSelection = false;
            this.lvProperties.Location = new System.Drawing.Point(0, 25);
            this.lvProperties.Name = "lvProperties";
            this.lvProperties.Size = new System.Drawing.Size(380, 244);
            this.lvProperties.TabIndex = 1;
            this.lvProperties.UseCompatibleStateImageBehavior = false;
            this.lvProperties.View = System.Windows.Forms.View.Details;
            // 
            // lvChKey
            // 
            this.lvChKey.Text = "Key";
            this.lvChKey.Width = 183;
            // 
            // lvChValue
            // 
            this.lvChValue.Text = "Value";
            this.lvChValue.Width = 205;
            // 
            // tsProperties
            // 
            this.tsProperties.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProperties.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPropertiesLabelCount,
            this.toolStripSeparator4,
            this.tsPropertiesLabelGroups,
            this.tsPropertiesButtonSave});
            this.tsProperties.Location = new System.Drawing.Point(0, 0);
            this.tsProperties.Name = "tsProperties";
            this.tsProperties.Size = new System.Drawing.Size(380, 25);
            this.tsProperties.TabIndex = 0;
            this.tsProperties.Text = "Properties";
            // 
            // tsPropertiesLabelCount
            // 
            this.tsPropertiesLabelCount.Name = "tsPropertiesLabelCount";
            this.tsPropertiesLabelCount.Size = new System.Drawing.Size(40, 22);
            this.tsPropertiesLabelCount.Text = "Count";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // tsPropertiesLabelGroups
            // 
            this.tsPropertiesLabelGroups.Name = "tsPropertiesLabelGroups";
            this.tsPropertiesLabelGroups.Size = new System.Drawing.Size(45, 22);
            this.tsPropertiesLabelGroups.Text = "Groups";
            // 
            // tsPropertiesButtonSave
            // 
            this.tsPropertiesButtonSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsPropertiesButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPropertiesButtonSave.Enabled = false;
            this.tsPropertiesButtonSave.Image = global::PrusaSL1Viewer.Properties.Resources.Save_16x16;
            this.tsPropertiesButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPropertiesButtonSave.Name = "tsPropertiesButtonSave";
            this.tsPropertiesButtonSave.Size = new System.Drawing.Size(23, 22);
            this.tsPropertiesButtonSave.Text = "Save Thumbnail";
            this.tsPropertiesButtonSave.ToolTipText = "Save properties to a file";
            this.tsPropertiesButtonSave.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tabPageGCode
            // 
            this.tabPageGCode.Controls.Add(this.tbGCode);
            this.tabPageGCode.Controls.Add(this.tsGCode);
            this.tabPageGCode.ImageKey = "GCode-16x16.png";
            this.tabPageGCode.Location = new System.Drawing.Point(4, 23);
            this.tabPageGCode.Name = "tabPageGCode";
            this.tabPageGCode.Size = new System.Drawing.Size(386, 704);
            this.tabPageGCode.TabIndex = 2;
            this.tabPageGCode.Text = "GCode";
            this.tabPageGCode.UseVisualStyleBackColor = true;
            // 
            // tbGCode
            // 
            this.tbGCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbGCode.Location = new System.Drawing.Point(0, 25);
            this.tbGCode.Multiline = true;
            this.tbGCode.Name = "tbGCode";
            this.tbGCode.ReadOnly = true;
            this.tbGCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbGCode.Size = new System.Drawing.Size(386, 679);
            this.tbGCode.TabIndex = 1;
            // 
            // tsGCode
            // 
            this.tsGCode.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGCodeLabelLines,
            this.toolStripSeparator3,
            this.tsGcodeLabelChars,
            this.tsGCodeButtonSave});
            this.tsGCode.Location = new System.Drawing.Point(0, 0);
            this.tsGCode.Name = "tsGCode";
            this.tsGCode.Size = new System.Drawing.Size(386, 25);
            this.tsGCode.TabIndex = 0;
            // 
            // tsGCodeLabelLines
            // 
            this.tsGCodeLabelLines.Name = "tsGCodeLabelLines";
            this.tsGCodeLabelLines.Size = new System.Drawing.Size(34, 22);
            this.tsGCodeLabelLines.Text = "Lines";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsGcodeLabelChars
            // 
            this.tsGcodeLabelChars.Name = "tsGcodeLabelChars";
            this.tsGcodeLabelChars.Size = new System.Drawing.Size(37, 22);
            this.tsGcodeLabelChars.Text = "Chars";
            // 
            // tsGCodeButtonSave
            // 
            this.tsGCodeButtonSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsGCodeButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsGCodeButtonSave.Image = global::PrusaSL1Viewer.Properties.Resources.Save_16x16;
            this.tsGCodeButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsGCodeButtonSave.Name = "tsGCodeButtonSave";
            this.tsGCodeButtonSave.Size = new System.Drawing.Size(23, 22);
            this.tsGCodeButtonSave.Text = "Save GCode";
            this.tsGCodeButtonSave.ToolTipText = "Save GCode to file";
            this.tsGCodeButtonSave.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tabPageIslands
            // 
            this.tabPageIslands.Controls.Add(this.lvIslands);
            this.tabPageIslands.Controls.Add(this.tsIslands);
            this.tabPageIslands.ImageKey = "island-16x16.png";
            this.tabPageIslands.Location = new System.Drawing.Point(4, 23);
            this.tabPageIslands.Name = "tabPageIslands";
            this.tabPageIslands.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageIslands.Size = new System.Drawing.Size(386, 704);
            this.tabPageIslands.TabIndex = 3;
            this.tabPageIslands.Text = "Islands";
            this.tabPageIslands.UseVisualStyleBackColor = true;
            // 
            // lvIslands
            // 
            this.lvIslands.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.lvIslands.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader2,
            this.columnHeader3});
            this.lvIslands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIslands.FullRowSelect = true;
            this.lvIslands.GridLines = true;
            this.lvIslands.HideSelection = false;
            this.lvIslands.Location = new System.Drawing.Point(3, 28);
            this.lvIslands.Name = "lvIslands";
            this.lvIslands.Size = new System.Drawing.Size(380, 673);
            this.lvIslands.TabIndex = 8;
            this.lvIslands.UseCompatibleStateImageBehavior = false;
            this.lvIslands.View = System.Windows.Forms.View.Details;
            this.lvIslands.ItemActivate += new System.EventHandler(this.lvIslands_ItemActivate);
            this.lvIslands.SelectedIndexChanged += new System.EventHandler(this.lvIslands_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "##";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "X, Y";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Pixels";
            this.columnHeader3.Width = 80;
            // 
            // tsIslands
            // 
            this.tsIslands.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsIslands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIslandsPrevious,
            this.tsIslandsCount,
            this.tsIslandsNext,
            this.tsIslandsRefresh,
            this.toolStripSeparator12,
            this.tsIslandsRemove});
            this.tsIslands.Location = new System.Drawing.Point(3, 3);
            this.tsIslands.Name = "tsIslands";
            this.tsIslands.Size = new System.Drawing.Size(380, 25);
            this.tsIslands.TabIndex = 7;
            this.tsIslands.Text = "Thumbnail Menu";
            // 
            // tsIslandsPrevious
            // 
            this.tsIslandsPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIslandsPrevious.Enabled = false;
            this.tsIslandsPrevious.Image = global::PrusaSL1Viewer.Properties.Resources.Back_16x16;
            this.tsIslandsPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIslandsPrevious.Name = "tsIslandsPrevious";
            this.tsIslandsPrevious.Size = new System.Drawing.Size(23, 22);
            this.tsIslandsPrevious.Text = "Previous";
            this.tsIslandsPrevious.ToolTipText = "Show previous island";
            this.tsIslandsPrevious.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tsIslandsCount
            // 
            this.tsIslandsCount.Enabled = false;
            this.tsIslandsCount.Name = "tsIslandsCount";
            this.tsIslandsCount.Size = new System.Drawing.Size(24, 22);
            this.tsIslandsCount.Text = "0/0";
            // 
            // tsIslandsNext
            // 
            this.tsIslandsNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIslandsNext.Enabled = false;
            this.tsIslandsNext.Image = global::PrusaSL1Viewer.Properties.Resources.Next_16x16;
            this.tsIslandsNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIslandsNext.Name = "tsIslandsNext";
            this.tsIslandsNext.Size = new System.Drawing.Size(23, 22);
            this.tsIslandsNext.Text = "tsIslandsNext";
            this.tsIslandsNext.ToolTipText = "Show next island";
            this.tsIslandsNext.Click += new System.EventHandler(this.ItemClicked);
            // 
            // tsIslandsRefresh
            // 
            this.tsIslandsRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsIslandsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsIslandsRefresh.Enabled = false;
            this.tsIslandsRefresh.Image = global::PrusaSL1Viewer.Properties.Resources.refresh_16x16;
            this.tsIslandsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIslandsRefresh.Name = "tsIslandsRefresh";
            this.tsIslandsRefresh.Size = new System.Drawing.Size(23, 22);
            this.tsIslandsRefresh.Text = "Update";
            this.tsIslandsRefresh.ToolTipText = "Compute Islands";
            this.tsIslandsRefresh.Click += new System.EventHandler(this.ItemClicked);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tsIslandsRemove
            // 
            this.tsIslandsRemove.Enabled = false;
            this.tsIslandsRemove.Image = global::PrusaSL1Viewer.Properties.Resources.delete_16x16;
            this.tsIslandsRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsIslandsRemove.Name = "tsIslandsRemove";
            this.tsIslandsRemove.Size = new System.Drawing.Size(70, 22);
            this.tsIslandsRemove.Text = "Remove";
            this.tsIslandsRemove.ToolTipText = "Remove selected islands";
            this.tsIslandsRemove.Click += new System.EventHandler(this.ItemClicked);
            // 
            // imageList16x16
            // 
            this.imageList16x16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16x16.ImageStream")));
            this.imageList16x16.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList16x16.Images.SetKeyName(0, "DataList-16x16.png");
            this.imageList16x16.Images.SetKeyName(1, "PhotoInfo-16x16.png");
            this.imageList16x16.Images.SetKeyName(2, "GCode-16x16.png");
            this.imageList16x16.Images.SetKeyName(3, "island-16x16.png");
            // 
            // FrmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 783);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "FrmMain";
            this.Text = "PrusaSL1Viewer";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.mainTable.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scCenter.Panel1.ResumeLayout(false);
            this.scCenter.Panel1.PerformLayout();
            this.scCenter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scCenter)).EndInit();
            this.scCenter.ResumeLayout(false);
            this.tsLayer.ResumeLayout(false);
            this.tsLayer.PerformLayout();
            this.tabControlLeft.ResumeLayout(false);
            this.tbpThumbnailsAndInfo.ResumeLayout(false);
            this.scLeft.Panel1.ResumeLayout(false);
            this.scLeft.Panel1.PerformLayout();
            this.scLeft.Panel2.ResumeLayout(false);
            this.scLeft.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLeft)).EndInit();
            this.scLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbThumbnail)).EndInit();
            this.tsThumbnails.ResumeLayout(false);
            this.tsThumbnails.PerformLayout();
            this.tsProperties.ResumeLayout(false);
            this.tsProperties.PerformLayout();
            this.tabPageGCode.ResumeLayout(false);
            this.tabPageGCode.PerformLayout();
            this.tsGCode.ResumeLayout(false);
            this.tsGCode.PerformLayout();
            this.tabPageIslands.ResumeLayout(false);
            this.tabPageIslands.PerformLayout();
            this.tsIslands.ResumeLayout(false);
            this.tsIslands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileExit;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuHelpWebsite;
        private System.Windows.Forms.ToolStripMenuItem menuHelpDonate;
        private System.Windows.Forms.ToolStripMenuItem menuHelpAbout;
        private System.Windows.Forms.VScrollBar sbLayers;
        private System.Windows.Forms.TableLayoutPanel mainTable;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbLayers;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.SplitContainer scCenter;
        private System.Windows.Forms.ProgressBar pbLayers;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuFileExtract;
        private System.Windows.Forms.ToolStripMenuItem menuFileConvert;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuFileReload;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileSaveAs;
        private System.Windows.Forms.ToolStrip tsLayer;
        private System.Windows.Forms.ToolStripButton tsLayerImageExport;
        private System.Windows.Forms.ToolStripLabel tsLayerResolution;
        private System.Windows.Forms.TabControl tabControlLeft;
        private System.Windows.Forms.TabPage tbpThumbnailsAndInfo;
        private System.Windows.Forms.SplitContainer scLeft;
        private System.Windows.Forms.PictureBox pbThumbnail;
        private System.Windows.Forms.ToolStrip tsThumbnails;
        private System.Windows.Forms.ToolStripButton tsThumbnailsPrevious;
        private System.Windows.Forms.ToolStripLabel tsThumbnailsCount;
        private System.Windows.Forms.ToolStripButton tsThumbnailsNext;
        private System.Windows.Forms.ToolStripButton tsThumbnailsExport;
        private System.Windows.Forms.ToolStripLabel tsThumbnailsResolution;
        private System.Windows.Forms.TabPage tabPageGCode;
        private System.Windows.Forms.ImageList imageList16x16;
        private System.Windows.Forms.TextBox tbGCode;
        private System.Windows.Forms.ToolStrip tsGCode;
        private System.Windows.Forms.ToolStripLabel tsGCodeLabelLines;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel tsGcodeLabelChars;
        private System.Windows.Forms.ToolStripButton tsGCodeButtonSave;
        private System.Windows.Forms.ListView lvProperties;
        private System.Windows.Forms.ColumnHeader lvChKey;
        private System.Windows.Forms.ColumnHeader lvChValue;
        private System.Windows.Forms.ToolStrip tsProperties;
        private System.Windows.Forms.ToolStripLabel tsPropertiesLabelCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tsPropertiesLabelGroups;
        private System.Windows.Forms.ToolStripButton tsPropertiesButtonSave;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpenNewWindow;
        private System.Windows.Forms.ToolStripButton tsLayerImageRotate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsLayerImageLayerDifference;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel tsLayerPreviewTime;
        private Cyotek.Windows.Forms.ImageBox pbLayer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripLabel tsLayerImageZoom;
        private System.Windows.Forms.ToolStripButton tsLayerImagePixelEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsLayerImageLayerOutline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem menuMutate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem menuHelpInstallPrinters;
        private System.Windows.Forms.TabPage tabPageIslands;
        private System.Windows.Forms.ToolStrip tsIslands;
        private System.Windows.Forms.ToolStripButton tsIslandsPrevious;
        private System.Windows.Forms.ToolStripButton tsIslandsNext;
        private System.Windows.Forms.ToolStripLabel tsIslandsCount;
        private System.Windows.Forms.ListView lvIslands;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripButton tsIslandsRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripLabel tsLayerImageMouseLocation;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripButton tsIslandsRemove;
        private System.Windows.Forms.ToolStripMenuItem menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuToolsRepairLayers;
    }
}

