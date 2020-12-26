using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.UI;
using SuperMap.Data;
using SuperMap.Mapping;
using System.Data.SqlClient;

namespace demo
{
    public partial class MainForm : Form
    {
        SceneControl sceneControl = null;
        
              public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //初始化workspaceControl和layersTree
            this.workspaceControl.WorkspaceTree.Workspace = new Workspace();
            this.layersTree.Map = mapControl.Map;

            // 右键菜单
            // Right-click menu
            this.workspaceControl.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Datasources] = contextMenuStripDatasources;
            this.workspaceControl.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.Workspace] = contextMenuStripWorkspace;
            this.workspaceControl.WorkspaceTree.NodeContextMenuStrips[WorkspaceTreeNodeDataType.MapName] = contextMenuStripMap;

            //建立MapControl与Workspace的连接
            mapControl.Map.Workspace = workspace;

            // 开启全屏反走样
            // Open full-screen anti-aliasing

            //打开数据库，并加载到dataGridView中
            sqlOpen();

        }

        private void ToolStripMenuItemOpenWorkspace_Click(object sender, EventArgs e)
        {
            //设置公用打开对话框
            openFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
            //判断打开的结果，如果打开就执行下列操作
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //避免连续打开工作空间导致程序异常     
                workspace.Close();
                mapControl.Map.Close();
                mapControl.Map.Refresh();
                //定义打开工作空间文件名
                String fileName = openFileDialog.FileName;
                //打开工作空间文件
                WorkspaceConnectionInfo connectionInfo = new WorkspaceConnectionInfo(fileName);
                //打开并绑定工作空间
                workspace.Open(connectionInfo);
                this.workspaceControl.WorkspaceTree.Workspace = workspace;
            }
        }

        private void DelDataset_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = this.workspaceControl.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            Dataset dataset = node.GetData() as Dataset;

            //// 如果该图层在mapcontrol中打开，移除图层
            //// If the layer opens in the scene, remove the layer
            //Layer layers = this.mapControl.layer;
            //int nLayer = layers.Count;
            //for (int i = 0; i < nLayer; i++)
            //{
            //    Layer3D layer = layers[i];
            //    if (layer.Caption.Contains(dataset.Name))
            //    {
            //        layers.Remove(layer.Name);
            //        nLayer--;
            //        i--;
            //    }
            //}
            Datasource datsource = dataset.Datasource;
            bool ret = datsource.Datasets.Delete(dataset.Name);
            datsource.Refresh();
        }

        private void AddToMapcontrol_Click(object sender, EventArgs e)
        {
            //避免连续打开地图导致程序异常     
            mapControl.Map.Close();
            mapControl.Map.Refresh();
            WorkspaceTreeNodeBase node = this.workspaceControl.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            //通过名称打开工作空间中的地图
            mapControl.Map.Open(node.Name);
            //刷新地图窗口
            mapControl.Map.Refresh();
        }

        private void closeMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = this.workspaceControl.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            if (mapControl.Map.Name == node.Name)
            {
                mapControl.Map.Close();
                mapControl.Map.Refresh();
            }
            else
            {
                MessageBox.Show("当前mapControl控件中不存在该地图!");
                return;
            }
        }

        //双击WorkspaceTree中节点响应事件
        private void workspaceControl_WorkspaceTree_DoubleClick(object sender, EventArgs e)
        {
            WorkspaceTreeNodeBase node = this.workspaceControl.WorkspaceTree.SelectedNode as WorkspaceTreeNodeBase;
            switch (node.NodeType)
            {
                //地图节点类型
                case WorkspaceTreeNodeDataType.MapName:
                    {
                        //避免连续打开地图导致程序异常     
                        mapControl.Map.Close();
                        mapControl.Map.Refresh();
                        //通过名称打开工作空间中的地图
                        mapControl.Map.Open(node.Name);
                        //刷新地图窗口
                        mapControl.Map.Refresh();
                        break;
                    }
                //工作空间节点类型
                case WorkspaceTreeNodeDataType.Workspace:
                    {
                        //设置公用打开对话框
                        openFileDialog.Filter = "SuperMap 工作空间文件(*.smwu)|*.smwu";
                        //判断打开的结果，如果打开就执行下列操作
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            //避免连续打开工作空间导致程序异常     
                            workspace.Close();
                            mapControl.Map.Close();
                            mapControl.Map.Refresh();
                            //mapControl.Map.Refresh();
                            //定义打开工作空间文件名
                            String fileName = openFileDialog.FileName;
                            //打开工作空间文件
                            WorkspaceConnectionInfo connectionInfo = new WorkspaceConnectionInfo(fileName);
                            //打开并绑定工作空间
                            workspace.Open(connectionInfo);
                            this.workspaceControl.WorkspaceTree.Workspace = workspace;
                        }
                        break;
                    }
            }
        }


        //打开数据库，并加载到dataGridView中
        public void sqlOpen()
        {
            string str = string.Format("select TOP 150 [SmID],[Capital],[Country], [Country_en],[Country_1],[Country_en_1],[February],[March],[April], [May] ,[June],[July] ,[August],[September],[October], [November],[December],[total] from SMDTV_27 order by  [total] desc");
            string coonString = "Data Source=.;Initial Catalog=demo;Integrated Security=True";
            SqlConnection con = new SqlConnection(coonString);
            con.Open();
            SqlDataAdapter data = new SqlDataAdapter(str, coonString);
            DataSet ds = new DataSet();
            data.Fill(ds);
            con.Close();
            dataGridView.DataSource = ds.Tables[0];
        }

        private void DotdensitymapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassParameter.passMapControl = mapControl;
            PassParameter.passWorkspace = workspace;
            FrmDotDensityMap frmDotDensityMap = new FrmDotDensityMap();
            frmDotDensityMap.ShowDialog();
            mapControl = PassParameter.passMapControl;
        }

        private void GraphmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassParameter.passMapControl = mapControl;
            PassParameter.passWorkspace = workspace;
            FrmGraphMap frmGraphMap = new FrmGraphMap();
            frmGraphMap.ShowDialog();
            mapControl = PassParameter.passMapControl;
        }

        private void RangesmapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PassParameter.passMapControl = mapControl;
            PassParameter.passWorkspace = workspace;
            FrmRangesMap frmRangeMap = new FrmRangesMap();
            frmRangeMap.ShowDialog();
            mapControl = PassParameter.passMapControl;
        }






    }
}
