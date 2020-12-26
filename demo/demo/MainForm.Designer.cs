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
            SuperMap.Data.GeoStyle geoStyle13 = new SuperMap.Data.GeoStyle();
            SuperMap.Data.GeoRegion geoRegion5 = new SuperMap.Data.GeoRegion();
            SuperMap.Mapping.GridSetting gridSetting5 = new SuperMap.Mapping.GridSetting();
            SuperMap.Data.GeoStyle geoStyle14 = new SuperMap.Data.GeoStyle();
            SuperMap.Data.GeoStyle geoStyle15 = new SuperMap.Data.GeoStyle();
            SuperMap.Mapping.MapOverlapDisplayedOptions mapOverlapDisplayedOptions5 = new SuperMap.Mapping.MapOverlapDisplayedOptions();
            SuperMap.Data.TextStyle textStyle5 = new SuperMap.Data.TextStyle();
            SuperMap.Data.CoordSysTransParameter coordSysTransParameter5 = new SuperMap.Data.CoordSysTransParameter();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_PanScene = new System.Windows.Forms.ToolStripButton();
            this.btn_SelectScene = new System.Windows.Forms.ToolStripButton();
            this.btn_Pan2Scene = new System.Windows.Forms.ToolStripButton();
            this.btn_EntireScene = new System.Windows.Forms.ToolStripButton();
            this.btn_RefreshScene = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.专题图制作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DotdensitymapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RangesmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.workspaceControl = new SuperMap.UI.WorkspaceControl();
            this.layersTree = new SuperMap.UI.LayersTree();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mapControl = new SuperMap.UI.MapControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.workspace = new SuperMap.Data.Workspace(this.components);
            this.map = new SuperMap.Mapping.Map(this.components);
            this.contextMenuStripDatasources = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenDBDatasourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewDBDatasourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStripDatasources.SuspendLayout();
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
            this.专题图制作ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1061, 28);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 专题图制作ToolStripMenuItem
            // 
            this.专题图制作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DotdensitymapToolStripMenuItem,
            this.GraphmapToolStripMenuItem,
            this.RangesmapToolStripMenuItem,
            this.toolStripSeparator6});
            this.专题图制作ToolStripMenuItem.Name = "专题图制作ToolStripMenuItem";
            this.专题图制作ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.专题图制作ToolStripMenuItem.Text = "专题图制作";
            // 
            // DotdensitymapToolStripMenuItem
            // 
            this.DotdensitymapToolStripMenuItem.Name = "DotdensitymapToolStripMenuItem";
            this.DotdensitymapToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.DotdensitymapToolStripMenuItem.Text = "点密度专题图";
            this.DotdensitymapToolStripMenuItem.Click += new System.EventHandler(this.DotdensitymapToolStripMenuItem_Click);
            // 
            // GraphmapToolStripMenuItem
            // 
            this.GraphmapToolStripMenuItem.Name = "GraphmapToolStripMenuItem";
            this.GraphmapToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.GraphmapToolStripMenuItem.Text = "柱状专题图";
            this.GraphmapToolStripMenuItem.Click += new System.EventHandler(this.GraphmapToolStripMenuItem_Click);
            // 
            // RangesmapToolStripMenuItem
            // 
            this.RangesmapToolStripMenuItem.Name = "RangesmapToolStripMenuItem";
            this.RangesmapToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.RangesmapToolStripMenuItem.Text = "颜色专题图";
            this.RangesmapToolStripMenuItem.Click += new System.EventHandler(this.RangesmapToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(171, 6);
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
            this.splitContainer1.Panel2.Controls.Add(this.tabControl);
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
            this.splitContainer2.Panel2.Controls.Add(this.layersTree);
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
            // layersTree
            // 
            this.layersTree.AllowDrop = true;
            this.layersTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.layersTree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layersTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layersTree.DragNodeEnabled = true;
            this.layersTree.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawText;
            this.layersTree.DropLineColor = System.Drawing.SystemColors.HotTrack;
            this.layersTree.HideSelection = false;
            this.layersTree.Icons = ((SuperMap.UI.TreeIconTypes)(((((SuperMap.UI.TreeIconTypes.Visible | SuperMap.UI.TreeIconTypes.Selectable) 
            | SuperMap.UI.TreeIconTypes.Editable) 
            | SuperMap.UI.TreeIconTypes.Snapable) 
            | SuperMap.UI.TreeIconTypes.TypeIcon)));
            this.layersTree.IconType = SuperMap.UI.LayersTree.IconTypes.None;
            this.layersTree.ItemHeight = 20;
            this.layersTree.Location = new System.Drawing.Point(0, 0);
            this.layersTree.Map = null;
            this.layersTree.Name = "layersTree";
            this.layersTree.SelectedNodes = new System.Windows.Forms.TreeNode[0];
            this.layersTree.SimpleMode = false;
            this.layersTree.Size = new System.Drawing.Size(353, 237);
            this.layersTree.TabIndex = 0;
            this.layersTree.VisibleScaleNodesList = ((System.Collections.Generic.List<SuperMap.UI.LayersTreeNodeBase>)(resources.GetObject("layersTree.VisibleScaleNodesList")));
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(704, 539);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mapControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(696, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "地图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mapControl
            // 
            this.mapControl.Action = SuperMap.UI.Action.Select2;
            this.mapControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mapControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(3, 3);
            this.mapControl.Margin = new System.Windows.Forms.Padding(60, 28, 60, 28);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(690, 504);
            this.mapControl.TabIndex = 0;
            this.mapControl.TrackMode = SuperMap.UI.TrackMode.Edit;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(696, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据库";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(3, 207);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 27;
            this.dataGridView.Size = new System.Drawing.Size(690, 300);
            this.dataGridView.TabIndex = 0;
            // 
            // workspace
            // 
            this.workspace.Caption = "UntitledWorkspace";
            this.workspace.Description = "";
            this.workspace.DesktopInfo = "";
            // 
            // map
            // 
            geoStyle13.AcrossLongtitude = false;
            geoStyle13.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle13.FillBackOpaque = true;
            geoStyle13.FillForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle13.FillGradientAngle = 0D;
            geoStyle13.FillGradientMode = SuperMap.Data.FillGradientMode.None;
            geoStyle13.FillGradientOffsetRatioX = 0;
            geoStyle13.FillGradientOffsetRatioY = 0;
            geoStyle13.FillOpaqueRate = 100;
            geoStyle13.FillSymbolID = 0;
            geoStyle13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            geoStyle13.LineSymbolID = 0;
            geoStyle13.LineWidth = 0.1D;
            geoStyle13.MarkerAngle = 0D;
            geoStyle13.MarkerSymbolID = 0;
            geoStyle13.PicturePath = "";
            geoStyle13.SVGPath = "";
            this.map.BackgroundStyle = geoStyle13;
            geoRegion5.ID = 0;
            geoRegion5.Style = null;
            this.map.ClipRegion = geoRegion5;
            this.map.CurrentPlayerTick = 0;
            this.map.DPI = 96D;
            geoStyle14.AcrossLongtitude = false;
            geoStyle14.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle14.FillBackOpaque = true;
            geoStyle14.FillForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            geoStyle14.FillGradientAngle = 0D;
            geoStyle14.FillGradientMode = SuperMap.Data.FillGradientMode.None;
            geoStyle14.FillGradientOffsetRatioX = 0;
            geoStyle14.FillGradientOffsetRatioY = 0;
            geoStyle14.FillOpaqueRate = 100;
            geoStyle14.FillSymbolID = 0;
            geoStyle14.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            geoStyle14.LineSymbolID = 2;
            geoStyle14.LineWidth = 0.1D;
            geoStyle14.MarkerAngle = 0D;
            geoStyle14.MarkerSymbolID = 0;
            geoStyle14.PicturePath = "";
            geoStyle14.SVGPath = "";
            gridSetting5.DashStyle = geoStyle14;
            gridSetting5.HorizontalSpacing = 0D;
            gridSetting5.IsSizeFixed = false;
            gridSetting5.IsSnapable = false;
            gridSetting5.IsVisible = false;
            geoStyle15.AcrossLongtitude = false;
            geoStyle15.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            geoStyle15.FillBackOpaque = true;
            geoStyle15.FillForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            geoStyle15.FillGradientAngle = 0D;
            geoStyle15.FillGradientMode = SuperMap.Data.FillGradientMode.None;
            geoStyle15.FillGradientOffsetRatioX = 0;
            geoStyle15.FillGradientOffsetRatioY = 0;
            geoStyle15.FillOpaqueRate = 100;
            geoStyle15.FillSymbolID = 0;
            geoStyle15.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            geoStyle15.LineSymbolID = 0;
            geoStyle15.LineWidth = 0.1D;
            geoStyle15.MarkerAngle = 0D;
            geoStyle15.MarkerSymbolID = 0;
            geoStyle15.PicturePath = "";
            geoStyle15.SVGPath = "";
            gridSetting5.SolidStyle = geoStyle15;
            gridSetting5.Type = SuperMap.Mapping.GridType.Point;
            gridSetting5.VerticalSpacing = 0D;
            this.map.Grid = gridSetting5;
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
            mapOverlapDisplayedOptions5.AllowPointOverlap = true;
            mapOverlapDisplayedOptions5.AllowPointWithTextDisplay = true;
            mapOverlapDisplayedOptions5.AllowTextAndPointOverlap = true;
            mapOverlapDisplayedOptions5.AllowTextOverlap = false;
            mapOverlapDisplayedOptions5.AllowThemeGraduatedSymbolOverlap = false;
            mapOverlapDisplayedOptions5.AllowThemeGraphOverlap = false;
            this.map.OverlapDisplayedOptions = mapOverlapDisplayedOptions5;
            this.map.Resources = null;
            this.map.TempCacheFileEnable = false;
            this.map.TileRefreshIntervals = 200;
            this.map.TimeEnable = false;
            this.map.TimeFormat = "YYYY/MM/DD hh:mm:ss";
            this.map.TimeStep = System.TimeSpan.Parse("00:00:00");
            this.map.TimeTextPosition = SuperMap.Mapping.TextPosition.BottomRight;
            textStyle5.Alignment = SuperMap.Data.TextAlignment.BottomRight;
            textStyle5.AlignmentString = SuperMap.Data.StringAlignment.Left;
            textStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.BackOpaque = false;
            textStyle5.Bold = false;
            textStyle5.BorderSpacingWidth = 4;
            textStyle5.FontHeight = 6D;
            textStyle5.FontName = "Times New Roman";
            textStyle5.FontScale = 1D;
            textStyle5.FontWidth = 0D;
            textStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.IsSizeFixed = true;
            textStyle5.Italic = false;
            textStyle5.ItalicAngle = 0D;
            textStyle5.OpaqueRate = 100;
            textStyle5.Outline = false;
            textStyle5.OutlineWidth = 1;
            textStyle5.Rotation = 0D;
            textStyle5.Shadow = false;
            textStyle5.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            textStyle5.ShadowOffsetX = 1D;
            textStyle5.ShadowOffsetY = 1D;
            textStyle5.Strikeout = false;
            textStyle5.Underline = false;
            textStyle5.Weight = 400;
            this.map.TimeTextStyle = textStyle5;
            this.map.TimeWindow = System.TimeSpan.Parse("00:00:00");
            this.map.TransMethod = SuperMap.Data.CoordSysTransMethod.GeocentricTranslation;
            coordSysTransParameter5.RotateX = 0D;
            coordSysTransParameter5.RotateY = 0D;
            coordSysTransParameter5.RotateZ = 0D;
            coordSysTransParameter5.RotationOriginX = 0D;
            coordSysTransParameter5.RotationOriginY = 0D;
            coordSysTransParameter5.RotationOriginZ = 0D;
            coordSysTransParameter5.ScaleDifference = 0D;
            coordSysTransParameter5.TranslateX = 0D;
            coordSysTransParameter5.TranslateY = 0D;
            coordSysTransParameter5.TranslateZ = 0D;
            this.map.TransParameter = coordSysTransParameter5;
            this.map.TransRunnable = null;
            this.map.UseSystemDPI = true;
            this.map.VisibleScales = new double[0];
            // 
            // contextMenuStripDatasources
            // 
            this.contextMenuStripDatasources.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDatasources.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenDBDatasourcesToolStripMenuItem,
            this.toolStripSeparator1,
            this.NewDBDatasourcesToolStripMenuItem});
            this.contextMenuStripDatasources.Name = "contextMenuStripDsVector";
            this.contextMenuStripDatasources.Size = new System.Drawing.Size(214, 58);
            // 
            // OpenDBDatasourcesToolStripMenuItem
            // 
            this.OpenDBDatasourcesToolStripMenuItem.Name = "OpenDBDatasourcesToolStripMenuItem";
            this.OpenDBDatasourcesToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.OpenDBDatasourcesToolStripMenuItem.Text = "打开数据库型数据源";
            this.OpenDBDatasourcesToolStripMenuItem.Click += new System.EventHandler(this.DelDataset_ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
            // 
            // NewDBDatasourcesToolStripMenuItem
            // 
            this.NewDBDatasourcesToolStripMenuItem.Name = "NewDBDatasourcesToolStripMenuItem";
            this.NewDBDatasourcesToolStripMenuItem.Size = new System.Drawing.Size(213, 24);
            this.NewDBDatasourcesToolStripMenuItem.Text = "新建数据库型数据源";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStripDatasources.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem 专题图制作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DotdensitymapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GraphmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RangesmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private SuperMap.Data.Workspace workspace;
        private SuperMap.Mapping.Map map;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDatasources;
        private System.Windows.Forms.ToolStripMenuItem OpenDBDatasourcesToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem closeMapToolStripMenuItem;
        private SuperMap.UI.LayersTree layersTree;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NewDBDatasourcesToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private SuperMap.UI.MapControl mapControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}

