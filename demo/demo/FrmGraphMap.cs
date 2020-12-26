using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperMap.Mapping;
using SuperMap.Data;
using SuperMap.UI;

namespace demo
{
    public partial class FrmGraphMap : Form
    {
        public FrmGraphMap()
        {
            InitializeComponent();
        }
        //设置柱状专题图中点的风格
        GeoStyle geostyle = new GeoStyle();
        Resources resources = PassParameter.passWorkspace.Resources;
        // 新建一个 SymbolDialog 对象
        SymbolDialog symbolFillDialog = new SymbolDialog();


        private void FrmGraphMap_Load(object sender, EventArgs e)
        {
            comboBoxMonth.SelectedIndex = 0;
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                string Month = comboBoxMonth.Text;
                //提前实例化一个点密度专题地图图层
                Layer themeLayer;
                Map map = PassParameter.passMapControl.Map;

                //获得地图图层上的数据集

                DatasetVector dataset = PassParameter.passWorkspace.Datasources["World"].Datasets["World"] as DatasetVector;




                //实例化一个柱状专题图对象
                ThemeGraph themegraph = new ThemeGraph();


                //对专题图作相应设置
                //设置用于创建柱状专题图的字段
                themegraph.MaxGraphSize = 100;
                themegraph.MinGraphSize = 0;
                themegraph.GraphType = ThemeGraphType.Bar;//设置统计专题图的统计图类型
                themegraph.IsGraphSizeFixed = false;//设置在放大或者缩小地图时统计图是否固定大小。
                themegraph.IsAxesTextDisplayed = true;//设置是否显示坐标轴的文本标注。 
                themegraph.GraphTextFormat = ThemeGraphTextFormat.CaptionValue;
                themegraph.BarWidthRatio = 1;


                //// 打开填充符号选择器
                //SymbolDialog.ShowDialog(resources, geostyle, SymbolType.Fill);

                ThemeGraphItem item0 = new ThemeGraphItem();
                item0.GraphExpression = "February";
                item0.UniformStyle = geostyle;

                ThemeGraphItem item1 = new ThemeGraphItem();
                item1.GraphExpression = "March";
                item1.UniformStyle = geostyle;

                ThemeGraphItem item2 = new ThemeGraphItem();
                item2.GraphExpression = "April";
                item2.UniformStyle = geostyle;

                ThemeGraphItem item3 = new ThemeGraphItem();
                item3.GraphExpression = "May";
                item3.UniformStyle = geostyle;

                ThemeGraphItem item4 = new ThemeGraphItem();
                item4.GraphExpression = "June";
                item4.UniformStyle = geostyle;

                ThemeGraphItem item5 = new ThemeGraphItem();
                item5.GraphExpression = "July";
                item5.UniformStyle = geostyle;

                ThemeGraphItem item6 = new ThemeGraphItem();
                item6.GraphExpression = "August";
                item6.UniformStyle = geostyle;

                ThemeGraphItem item7 = new ThemeGraphItem();
                item7.GraphExpression = "September";
                item7.UniformStyle = geostyle;

                ThemeGraphItem item8 = new ThemeGraphItem();
                item8.GraphExpression = "October";
                item8.UniformStyle = geostyle;

                ThemeGraphItem item9 = new ThemeGraphItem();
                item9.GraphExpression = "November";
                item9.UniformStyle = geostyle;

                ThemeGraphItem item10 = new ThemeGraphItem();
                item10.GraphExpression = "December";
                item10.UniformStyle = geostyle;

                ThemeGraphItem item11 = new ThemeGraphItem();
                item11.GraphExpression = "total";
                item11.UniformStyle = geostyle;
                

                themegraph.Add(item0);
                themegraph.Add(item1);
                themegraph.Add(item2);
                themegraph.Add(item3);
                themegraph.Add(item4);
                themegraph.Add(item5);
                themegraph.Add(item6);
                themegraph.Add(item7);
                themegraph.Add(item8);
                themegraph.Add(item9);
                themegraph.Add(item10);
                themegraph.Add(item11);
                themegraph.IsFlowEnabled = false;


                //将生成的专题图添加到地图窗口中

                themeLayer = PassParameter.passMapControl.Map.Layers.Add(dataset, themegraph, true);

                map.Refresh();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            // 指定符号选择器使用的资源
            symbolFillDialog.Resources = resources;

            // 设置打开的符号选择器的类型为填充符号选择器
            symbolFillDialog.Type = SymbolType.Fill;

            // 设置符号选择器默认的符号风格
            symbolFillDialog.Style = geostyle;

            // 设置符号选择器的对话框标题的显示文本
            symbolFillDialog.Title = "打开填充符号选择器示例";

            // 打开填充符号选择器
            symbolFillDialog.ShowDialog();
            geostyle = symbolFillDialog.Style;
            resources = symbolFillDialog.Resources;
        }
    }
}
