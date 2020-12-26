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
    public partial class FrmDotDensityMap : Form
    {
        public FrmDotDensityMap()
        {
            InitializeComponent();
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

                //设置点密度专题图中点的风格

                GeoStyle geostyle = new GeoStyle();
                geostyle.LineColor = Color.Red;
                geostyle.MarkerSize = new Size2D(1, 1);



                //实例化一个点密度专题图对象

                ThemeDotDensity themedotdensity = new ThemeDotDensity();


                //对专题图作相应设置
                //设置用于创建点密度专题图的字段

                themedotdensity.DotExpression = Month;

                themedotdensity.Style = geostyle;

                //点密度等级
                switch (Convert.ToInt32 (comboBoxDensity.Text))
                {
                    case 1: { themedotdensity.Value = 1000; break; }
                    case 2: { themedotdensity.Value = 10; break; }
                    case 3: { themedotdensity.Value = 1; break; }
                }



                //将生成的专题图添加到地图窗口中

                themeLayer = PassParameter.passMapControl.Map.Layers.Add(dataset, themedotdensity, true);

                map.Refresh();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void FrmDotDensityMap_Load(object sender, EventArgs e)
        {
            comboBoxMonth.SelectedIndex = 0;
            comboBoxDensity.SelectedIndex = 0;
        }
    }
}
