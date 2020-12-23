namespace demo
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SuperMap.Data.GeoStyle geoStyle4 = new SuperMap.Data.GeoStyle();
            SuperMap.Data.GeoRegion geoRegion2 = new SuperMap.Data.GeoRegion();
            SuperMap.Mapping.GridSetting gridSetting2 = new SuperMap.Mapping.GridSetting();
            SuperMap.Data.GeoStyle geoStyle5 = new SuperMap.Data.GeoStyle();
            SuperMap.Data.GeoStyle geoStyle6 = new SuperMap.Data.GeoStyle();
            SuperMap.Mapping.MapOverlapDisplayedOptions mapOverlapDisplayedOptions2 = new SuperMap.Mapping.MapOverlapDisplayedOptions();
            SuperMap.Data.TextStyle textStyle2 = new SuperMap.Data.TextStyle();
            SuperMap.Data.CoordSysTransParameter coordSysTransParameter2 = new SuperMap.Data.CoordSysTransParameter();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_PanScene = new System.Windows.Forms.ToolStripButton();
            this.btn_SelectScene = new System.Windows.Forms.ToolStripButton();
            this.btn_Pan2Scene = new System.Windows.Forms.ToolStripButton();
            this.btn_EntireScene = new System.Windows.Forms.ToolStripButton();
            this.btn_RefreshScene = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.场景属性ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowFPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.SetSunVisible_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SunTrajectorySetting_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.SetShadowType_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShadowAll_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShadowSelection_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NoShadow_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.workspaceControl = new SuperMap.UI.WorkspaceControl();
            this.layersControl = new SuperMap.UI.LayersControl();
            this.mapControl = new SuperMap.UI.MapControl();
            this.workspace = new SuperMap.Data.Workspace(this.components);
            this.map = new SuperMap.Mapping.Map(this.components);
            this.contextMenuStripDataset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.DelDataset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripLayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VisibleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.RemoveLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlyToLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripWorkspace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemOpenWorkspace = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddToMapcontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.contextMenuStripDataset.SuspendLayout();
            this.contextMenuStripLayer.SuspendLayout();
            this.contextMenuStripWorkspace.SuspendLayout();
            this.contextMenuStripMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator8,
            this.btn_PanScene,
            this.btn_SelectScene,
            this.btn_Pan2Scene,
            this.btn_EntireScene,
            this.btn_RefreshScene});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1061, 27);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_PanScene
            // 
            this.btn_PanScene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_PanScene.Image = ((System.Drawing.Image)(resources.GetObject("btn_PanScene.Image")));
            this.btn_PanScene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_PanScene.Name = "btn_PanScene";
            this.btn_PanScene.Size = new System.Drawing.Size(24, 24);
            this.btn_PanScene.Text = "Pan";
            // 
            // btn_SelectScene
            // 
            this.btn_SelectScene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_SelectScene.Image = ((System.Drawing.Image)(resources.GetObject("btn_SelectScene.Image")));
            this.btn_SelectScene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SelectScene.Name = "btn_SelectScene";
            this.btn_SelectScene.Size = new System.Drawing.Size(24, 24);
            this.btn_SelectScene.Text = "Select";
            // 
            // btn_Pan2Scene
            // 
            this.btn_Pan2Scene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Pan2Scene.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pan2Scene.Image")));
            this.btn_Pan2Scene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Pan2Scene.Name = "btn_Pan2Scene";
            this.btn_Pan2Scene.Size = new System.Drawing.Size(24, 24);
            this.btn_Pan2Scene.Text = "Pan2";
            // 
            // btn_EntireScene
            // 
            this.btn_EntireScene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_EntireScene.Image = ((System.Drawing.Image)(resources.GetObject("btn_EntireScene.Image")));
            this.btn_EntireScene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_EntireScene.Name = "btn_EntireScene";
            this.btn_EntireScene.Size = new System.Drawing.Size(24, 24);
            this.btn_EntireScene.Text = "ViewEntire";
            // 
            // btn_RefreshScene
            // 
            this.btn_RefreshScene.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_RefreshScene.Image = ((System.Drawing.Image)(resources.GetObject("btn_RefreshScene.Image")));
            this.btn_RefreshScene.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_RefreshScene.Name = "btn_RefreshScene";
            this.btn_RefreshScene.Size = new System.Drawing.Size(24, 24);
            this.btn_RefreshScene.Text = "Refresh";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.场景属性ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1061, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 场景属性ToolStripMenuItem
            // 
            this.场景属性ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShowFPSToolStripMenuItem,
            this.toolStripSeparator26,
            this.SetSunVisible_ToolStripMenuItem,
            this.SunTrajectorySetting_ToolStripMenuItem,
            this.toolStripSeparator6,
            this.SetShadowType_ToolStripMenuItem});
            this.场景属性ToolStripMenuItem.Name = "场景属性ToolStripMenuItem";
            this.场景属性ToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.场景属性ToolStripMenuItem.Text = "Scene Property";
            // 
            // ShowFPSToolStripMenuItem
            // 
            this.ShowFPSToolStripMenuItem.Name = "ShowFPSToolStripMenuItem";
            this.ShowFPSToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.ShowFPSToolStripMenuItem.Text = "Display Frame Rate";
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(250, 6);
            // 
            // SetSunVisible_ToolStripMenuItem
            // 
            this.SetSunVisible_ToolStripMenuItem.Checked = true;
            this.SetSunVisible_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SetSunVisible_ToolStripMenuItem.Name = "SetSunVisible_ToolStripMenuItem";
            this.SetSunVisible_ToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.SetSunVisible_ToolStripMenuItem.Text = "Open The Sun";
            // 
            // SunTrajectorySetting_ToolStripMenuItem
            // 
            this.SunTrajectorySetting_ToolStripMenuItem.Name = "SunTrajectorySetting_ToolStripMenuItem";
            this.SunTrajectorySetting_ToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.SunTrajectorySetting_ToolStripMenuItem.Text = "Set Sun Trajectory";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(250, 6);
            // 
            // SetShadowType_ToolStripMenuItem
            // 
            this.SetShadowType_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ShadowAll_ToolStripMenuItem,
            this.ShadowSelection_ToolStripMenuItem,
            this.NoShadow_ToolStripMenuItem});
            this.SetShadowType_ToolStripMenuItem.Name = "SetShadowType_ToolStripMenuItem";
            this.SetShadowType_ToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.SetShadowType_ToolStripMenuItem.Text = "Set Layer Shadow Type";
            // 
            // ShadowAll_ToolStripMenuItem
            // 
            this.ShadowAll_ToolStripMenuItem.Name = "ShadowAll_ToolStripMenuItem";
            this.ShadowAll_ToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.ShadowAll_ToolStripMenuItem.Text = "All Objects Produce Shadows";
            // 
            // ShadowSelection_ToolStripMenuItem
            // 
            this.ShadowSelection_ToolStripMenuItem.Name = "ShadowSelection_ToolStripMenuItem";
            this.ShadowSelection_ToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.ShadowSelection_ToolStripMenuItem.Text = "Select Object to Produce A Shadow";
            // 
            // NoShadow_ToolStripMenuItem
            // 
            this.NoShadow_ToolStripMenuItem.Checked = true;
            this.NoShadow_ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NoShadow_ToolStripMenuItem.Name = "NoShadow_ToolStripMenuItem";
            this.NoShadow_ToolStripMenuItem.Size = new System.Drawing.Size(344, 26);
            this.NoShadow_ToolStripMenuItem.Text = "No shadow";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapControl);
            this.splitContainer1.Size = new System.Drawing.Size(1061, 539);
            this.splitContainer1.SplitterDistance = 353;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.workspaceControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.layersControl);
            this.splitContainer2.Size = new System.Drawing.Size(353, 539);
            this.splitContainer2.SplitterDistance = 298;
            this.splitContainer2.TabIndex = 0;
            // 
            // workspaceControl
            // 
            this.workspaceControl.AllowDefaultAction = true;
            this.workspaceControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceControl.Location = new System.Drawing.Point(0, 0);
            this.workspaceControl.Name = "workspaceControl";
            this.workspaceControl.Size = new System.Drawing.Size(353, 298);
            this.workspaceControl.TabIndex = 0;
            // 
            // 
            // 
            this.workspaceControl.WorkspaceToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.workspaceControl.WorkspaceToolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.workspaceControl.WorkspaceToolBar.Location = new System.Drawing.Point(0, 0);
            this.workspaceControl.WorkspaceToolBar.Name = "WorkspaceToolBar";
            this.workspaceControl.WorkspaceToolBar.Size = new System.Drawing.Size(353, 27);
            this.workspaceControl.WorkspaceToolBar.TabIndex = 0;
            // 
            // 
            // 
            this.workspaceControl.WorkspaceTree.AllowDrop = true;
            this.workspaceControl.WorkspaceTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.workspaceControl.WorkspaceTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workspaceControl.WorkspaceTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workspaceControl.WorkspaceTree.ItemHeight = 21;
            this.workspaceControl.WorkspaceTree.Location = new System.Drawing.Point(0, 54);
            this.workspaceControl.WorkspaceTree.Name = "WorkspaceTree";
            this.workspaceControl.WorkspaceTree.SelectedNodes = new System.Windows.Forms.TreeNode[0];
            this.workspaceControl.WorkspaceTree.Size = new System.Drawing.Size(353, 244);
            this.workspaceControl.WorkspaceTree.TabIndex = 1;
            this.workspaceControl.WorkspaceTree.Workspace = null;
            this.workspaceControl.WorkspaceTree.DoubleClick += new System.EventHandler(this.workspaceControl_WorkspaceTree_DoubleClick);
            // 
            // layersControl
            // 
            this.layersControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layersControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layersControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersControl.Location = new System.Drawing.Point(0, 0);
            this.layersControl.Map = null;
            this.layersControl.Name = "layersControl";
            this.layersControl.Scene = null;
            this.layersControl.Size = new System.Drawing.Size(353, 237);
            this.layersControl.TabIndex = 0;
            // 
            // mapControl
            // 
            this.mapControl.Action = SuperMap.UI.Action.Select2;
            this.mapControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Margin = new System.Windows.Forms.Padding(60, 28, 60, 28);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(704, 539);
            this.mapControl.TabIndex = 0;
            this.mapControl.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // workspace
            // 
            this.workspace.Caption = "UntitledWorkspace";
            this.workspace.Description = "";
            this.workspace.DesktopInfo = "";
            // 
            // map
            // 
            geoStyle4.AcrossLongtitude = false;
            geoStyle4.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle4.FillBackOpaque = true;
            geoStyle4.FillForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle4.FillGradientAngle = 0D;
            geoStyle4.FillGradientMode = SuperMap.Data.FillGradientMode.None;
            geoStyle4.FillGradientOffsetRatioX = 0;
            geoStyle4.FillGradientOffsetRatioY = 0;
            geoStyle4.FillOpaqueRate = 100;
            geoStyle4.FillSymbolID = 0;
            geoStyle4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            geoStyle4.LineSymbolID = 0;
            geoStyle4.LineWidth = 0.1D;
            geoStyle4.MarkerAngle = 0D;
            geoStyle4.MarkerSymbolID = 0;
            geoStyle4.PicturePath = "";
            geoStyle4.SVGPath = "";
            this.map.BackgroundStyle = geoStyle4;
            geoRegion2.ID = 0;
            geoRegion2.Style = null;
            this.map.ClipRegion = geoRegion2;
            this.map.CurrentPlayerTick = 0;
            this.map.DPI = 96D;
            geoStyle5.AcrossLongtitude = false;
            geoStyle5.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle5.FillBackOpaque = true;
            geoStyle5.FillForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            geoStyle5.FillGradientAngle = 0D;
            geoStyle5.FillGradientMode = SuperMap.Data.FillGradientMode.None;
            geoStyle5.FillGradientOffsetRatioX = 0;
            geoStyle5.FillGradientOffsetRatioY = 0;
            geoStyle5.FillOpaqueRate = 100;
            geoStyle5.FillSymbolID = 0;
            geoStyle5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            geoStyle5.LineSymbolID = 2;
            geoStyle5.LineWidth = 0.1D;
            geoStyle5.MarkerAngle = 0D;
            geoStyle5.MarkerSymbolID = 0;
            geoStyle5.PicturePath = "";
            geoStyle5.SVGPath = "";
            gridSetting2.DashStyle = geoStyle5;
            gridSetting2.HorizontalSpacing = 0D;
            gridSetting2.IsSizeFixed = false;
            gridSetting2.IsSnapable = false;
            gridSetting2.IsVisible = false;
            geoStyle6.AcrossLongtitude = false;
            geoStyle6.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle6.FillBackOpaque = true;
            geoStyle6.FillForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            geoStyle6.FillGradientAngle = 0D;
            geoStyle6.FillGradientMode = SuperMap.Data.FillGradientMode.None;
            geoStyle6.FillGradientOffsetRatioX = 0;
            geoStyle6.FillGradientOffsetRatioY = 0;
            geoStyle6.FillOpaqueRate = 100;
            geoStyle6.FillSymbolID = 0;
            geoStyle6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            geoStyle6.LineSymbolID = 0;
            geoStyle6.LineWidth = 0.1D;
            geoStyle6.MarkerAngle = 0D;
            geoStyle6.MarkerSymbolID = 0;
            geoStyle6.PicturePath = "";
            geoStyle6.SVGPath = "";
            gridSetting2.SolidStyle = geoStyle6;
            gridSetting2.Type = SuperMap.Mapping.GridType.Point;
            gridSetting2.VerticalSpacing = 0D;
            this.map.Grid = gridSetting2;
            this.map.IsCustomBoundsEnabled = false;
            this.map.IsDebugMode = false;
            this.map.IsDisableAutoAvoidEffect = false;
            this.map.IsDisableDynamicEffect = false;
            this.map.IsFillMarkerAngleFixed = true;
            this.map.IsGraphicsAlphaEnabled = true;
            this.map.IsMapThreadDrawingEnabled = true;
            this.map.IsModified = true;
            this.map.IsOverlapDisplayed = false;
            this.map.IsShowTime = false;
            this.map.IsSymbolFillIgnored = false;
            this.map.IsTileZoomInCacheEnable = true;
            this.map.IsVisibleScalesEnabled = false;
            this.map.MapEndTime = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.map.MapStartTime = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.map.MaxScale = 1000000000000D;
            this.map.MaxVisibleVertex = 3600000;
            this.map.MinScale = 0D;
            this.map.Name = "UntitledMap";
            mapOverlapDisplayedOptions2.AllowPointOverlap = true;
            mapOverlapDisplayedOptions2.AllowPointWithTextDisplay = true;
            mapOverlapDisplayedOptions2.AllowTextAndPointOverlap = true;
            mapOverlapDisplayedOptions2.AllowTextOverlap = false;
            mapOverlapDisplayedOptions2.AllowThemeGraduatedSymbolOverlap = false;
            mapOverlapDisplayedOptions2.AllowThemeGraphOverlap = false;
            this.map.OverlapDisplayedOptions = mapOverlapDisplayedOptions2;
            this.map.Resources = null;
            this.map.TempCacheFileEnable = false;
            this.map.TileRefreshIntervals = 200;
            this.map.TimeEnable = false;
            this.map.TimeFormat = "YYYY/MM/DD hh:mm:ss";
            this.map.TimeStep = System.TimeSpan.Parse("00:00:00");
            this.map.TimeTextPosition = SuperMap.Mapping.TextPosition.BottomRight;
            textStyle2.Alignment = SuperMap.Data.TextAlignment.BottomRight;
            textStyle2.AlignmentString = SuperMap.Data.StringAlignment.Left;
            textStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.BackOpaque = false;
            textStyle2.Bold = false;
            textStyle2.BorderSpacingWidth = 4;
            textStyle2.FontHeight = 6D;
            textStyle2.FontName = "Times New Roman";
            textStyle2.FontScale = 1D;
            textStyle2.FontWidth = 0D;
            textStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.IsSizeFixed = true;
            textStyle2.Italic = false;
            textStyle2.ItalicAngle = 0D;
            textStyle2.OpaqueRate = 100;
            textStyle2.Outline = false;
            textStyle2.OutlineWidth = 1;
            textStyle2.Rotation = 0D;
            textStyle2.Shadow = false;
            textStyle2.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            textStyle2.ShadowOffsetX = 1D;
            textStyle2.ShadowOffsetY = 1D;
            textStyle2.Strikeout = false;
            textStyle2.Underline = false;
            textStyle2.Weight = 400;
            this.map.TimeTextStyle = textStyle2;
            this.map.TimeWindow = System.TimeSpan.Parse("00:00:00");
            this.map.TransMethod = SuperMap.Data.CoordSysTransMethod.GeocentricTranslation;
            coordSysTransParameter2.RotateX = 0D;
            coordSysTransParameter2.RotateY = 0D;
            coordSysTransParameter2.RotateZ = 0D;
            coordSysTransParameter2.RotationOriginX = 0D;
            coordSysTransParameter2.RotationOriginY = 0D;
            coordSysTransParameter2.RotationOriginZ = 0D;
            coordSysTransParameter2.ScaleDifference = 0D;
            coordSysTransParameter2.TranslateX = 0D;
            coordSysTransParameter2.TranslateY = 0D;
            coordSysTransParameter2.TranslateZ = 0D;
            this.map.TransParameter = coordSysTransParameter2;
            this.map.TransRunnable = null;
            this.map.UseSystemDPI = true;
            this.map.VisibleScales = new double[0];
            // 
            // contextMenuStripDataset
            // 
            this.contextMenuStripDataset.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDataset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.DelDataset_ToolStripMenuItem});
            this.contextMenuStripDataset.Name = "contextMenuStripDsVector";
            this.contextMenuStripDataset.Size = new System.Drawing.Size(213, 34);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(209, 6);
            // 
            // DelDataset_ToolStripMenuItem
            // 
            this.DelDataset_ToolStripMenuItem.Name = "DelDataset_ToolStripMenuItem";
            this.DelDataset_ToolStripMenuItem.Size = new System.Drawing.Size(212, 24);
            this.DelDataset_ToolStripMenuItem.Text = "Delete the dataset";
            this.DelDataset_ToolStripMenuItem.Click += new System.EventHandler(this.DelDataset_ToolStripMenuItem_Click);
            // 
            // contextMenuStripLayer
            // 
            this.contextMenuStripLayer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripLayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisibleToolStripMenuItem,
            this.SelectableToolStripMenuItem,
            this.EditableToolStripMenuItem,
            this.toolStripSeparator5,
            this.RemoveLayerToolStripMenuItem,
            this.FlyToLayerToolStripMenuItem});
            this.contextMenuStripLayer.Name = "contextMenuStripLayer";
            this.contextMenuStripLayer.Size = new System.Drawing.Size(250, 140);
            // 
            // VisibleToolStripMenuItem
            // 
            this.VisibleToolStripMenuItem.Checked = true;
            this.VisibleToolStripMenuItem.CheckOnClick = true;
            this.VisibleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VisibleToolStripMenuItem.Name = "VisibleToolStripMenuItem";
            this.VisibleToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.VisibleToolStripMenuItem.Text = "Visible";
            // 
            // SelectableToolStripMenuItem
            // 
            this.SelectableToolStripMenuItem.Checked = true;
            this.SelectableToolStripMenuItem.CheckOnClick = true;
            this.SelectableToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SelectableToolStripMenuItem.Name = "SelectableToolStripMenuItem";
            this.SelectableToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.SelectableToolStripMenuItem.Text = "Optional";
            // 
            // EditableToolStripMenuItem
            // 
            this.EditableToolStripMenuItem.Name = "EditableToolStripMenuItem";
            this.EditableToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.EditableToolStripMenuItem.Text = "Editable";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(246, 6);
            // 
            // RemoveLayerToolStripMenuItem
            // 
            this.RemoveLayerToolStripMenuItem.Name = "RemoveLayerToolStripMenuItem";
            this.RemoveLayerToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.RemoveLayerToolStripMenuItem.Text = "Remove Layer";
            // 
            // FlyToLayerToolStripMenuItem
            // 
            this.FlyToLayerToolStripMenuItem.Name = "FlyToLayerToolStripMenuItem";
            this.FlyToLayerToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.FlyToLayerToolStripMenuItem.Text = "Quickly locate this layer";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // contextMenuStripWorkspace
            // 
            this.contextMenuStripWorkspace.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripWorkspace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOpenWorkspace});
            this.contextMenuStripWorkspace.Name = "contextMenuStripWorkspace";
            this.contextMenuStripWorkspace.Size = new System.Drawing.Size(169, 28);
            // 
            // ToolStripMenuItemOpenWorkspace
            // 
            this.ToolStripMenuItemOpenWorkspace.Name = "ToolStripMenuItemOpenWorkspace";
            this.ToolStripMenuItemOpenWorkspace.Size = new System.Drawing.Size(168, 24);
            this.ToolStripMenuItemOpenWorkspace.Text = "打开工作空间";
            this.ToolStripMenuItemOpenWorkspace.Click += new System.EventHandler(this.ToolStripMenuItemOpenWorkspace_Click);
            // 
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddToMapcontrol,
            this.closeMapToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStripWorkspace";
            this.contextMenuStripMap.Size = new System.Drawing.Size(139, 52);
            // 
            // AddToMapcontrol
            // 
            this.AddToMapcontrol.Name = "AddToMapcontrol";
            this.AddToMapcontrol.Size = new System.Drawing.Size(138, 24);
            this.AddToMapcontrol.Text = "打开地图";
            this.AddToMapcontrol.Click += new System.EventHandler(this.AddToMapcontrol_Click);
            // 
            // closeMapToolStripMenuItem
            // 
            this.closeMapToolStripMenuItem.Name = "closeMapToolStripMenuItem";
            this.closeMapToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.closeMapToolStripMenuItem.Text = "关闭地图";
            this.closeMapToolStripMenuItem.Click += new System.EventHandler(this.closeMapToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 594);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.contextMenuStripDataset.ResumeLayout(false);
            this.contextMenuStripLayer.ResumeLayout(false);
            this.contextMenuStripWorkspace.ResumeLayout(false);
            this.contextMenuStripMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btn_PanScene;
        private System.Windows.Forms.ToolStripButton btn_SelectScene;
        private System.Windows.Forms.ToolStripButton btn_Pan2Scene;
        private System.Windows.Forms.ToolStripButton btn_EntireScene;
        private System.Windows.Forms.ToolStripButton btn_RefreshScene;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 场景属性ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowFPSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator26;
        private System.Windows.Forms.ToolStripMenuItem SetSunVisible_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SunTrajectorySetting_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem SetShadowType_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShadowAll_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShadowSelection_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NoShadow_ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private SuperMap.UI.LayersControl layersControl;
        private SuperMap.Data.Workspace workspace;
        private SuperMap.Mapping.Map map;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDataset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem DelDataset_ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripLayer;
        private System.Windows.Forms.ToolStripMenuItem VisibleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditableToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem RemoveLayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FlyToLayerToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripWorkspace;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpenWorkspace;
        private SuperMap.UI.WorkspaceControl workspaceControl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMap;
        private System.Windows.Forms.ToolStripMenuItem AddToMapcontrol;
        private SuperMap.UI.MapControl mapControl;
        private System.Windows.Forms.ToolStripMenuItem closeMapToolStripMenuItem;
    }
}

