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
    public partial class FrmRangesMap : Form
    {
        public FrmRangesMap()
        {
            InitializeComponent();
        }

        //设置颜色专题图中点的风格
        GeoStyle geostyle = new GeoStyle();
        Resources resources = PassParameter.passWorkspace.Resources;
        // 新建一个 SymbolDialog 对象
        SymbolDialog symbolFillDialog = new SymbolDialog();
        private void FrmRangesMap_Load(object sender, EventArgs e)
        {
            comboBoxMonth.SelectedIndex = 0;
            comboBoxrangeMode.SelectedIndex = 3;//默认标准差分段
            comboBoxcolorGradientType.SelectedIndex = 18;//默认蓝->红颜色渐变
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

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                string Month = comboBoxMonth.Text;
                //提前实例化一个分段专题地图图层
                Layer themeLayer;
                Map map = PassParameter.passMapControl.Map;

                //获得地图图层上的数据集
                DatasetVector dataset = PassParameter.passWorkspace.Datasources["World"].Datasets["World"] as DatasetVector;



                //实例化一个柱状专题图对象
                ThemeRange themerange = new ThemeRange();


                //对专题图作相应设置
                //设置用于创建分段专题图的字段
                String rangeExpression = Month;


                //设置分段模式
                //RangeMode rangeMode = (RangeMode)Enum.Parse(typeof(RangeMode), comboBoxrangeMode.Text);
                #region 设置分段模式
                //自定义分段
                //等计数分段
                //对数分段
                //标准差分段
                //平方根分段
                //等距离分段
                //EqualInterval
                //SquareRoot
                //StdDeviation
                //Logarithm
                //Quantile
                //CustomInterval
                //None
                #endregion
                RangeMode rangeMode = RangeMode.Logarithm;
                switch (comboBoxrangeMode.Text)
                {
                    case "自定义分段": { rangeMode = RangeMode.CustomInterval; break; }
                    case "等计数分段": { rangeMode = RangeMode.Quantile; break; }
                    case "对数分段": { rangeMode = RangeMode.Logarithm; break; }
                    case "标准差分段": { rangeMode = RangeMode.StdDeviation; break; }
                    case "平方根分段": { rangeMode = RangeMode.SquareRoot; break; }
                    case "等距离分段": { rangeMode = RangeMode.EqualInterval; break; }
                }



                //设置颜色渐变模式
                //ColorGradientType colorGradientType = (ColorGradientType)Enum.Parse(typeof(ColorGradientType),textBoxrangeParameter.Text);
                #region 颜色渐变模式
                //黑->白渐变色
                //红->白渐变色
                //绿->白渐变色
                //蓝->白渐变色
                //黄->白渐变色
                //粉红->白渐变色
                //青->白渐变色
                //红->黑渐变色
                //绿->黑渐变色
                //蓝->黑渐变色
                //黄->黑渐变色
                //粉红->黑渐变色
                //青->黑渐变色
                //黄->红渐变色
                //黄->绿渐变色
                //黄->蓝渐变色
                //绿->蓝渐变色
                //绿->红渐变色
                //蓝->红渐变色
                //青->红渐变色
                //青->蓝渐变色
                //青->蓝渐变色
                //青->绿渐变色
                //彩虹色
                //绿->桔黄->紫罗兰渐变色
                //地形渐变
                //光谱渐变
                //BlackWhite
                //RedWhite
                //GreenWhite
                //BlueWhite
                //YellowWhite
                //PinkWhite
                //CyanWhite
                //RedBlack
                //GreenBlack
                //BlueBlack
                //YellowBlack
                //PinkBlack
                //CyanBlack
                //YellowRed
                //YellowGreen
                //YellowBlue
                //GreenBlue
                //GreenRed
                //BlueRed
                //PinkRed
                //PinkBlue
                //CyanBlue
                //CyanGreen
                //Rainbow
                //GreenOrangeViolet
                //Terrain
                //Spectrum
                #endregion
                ColorGradientType colorGradientType = ColorGradientType.BlueRed;
                switch (comboBoxcolorGradientType.Text)
                {
                    case "黑->白渐变色": { colorGradientType = ColorGradientType.BlackWhite; break; }
                    case "红->白渐变色": { colorGradientType = ColorGradientType.RedWhite; break; }
                    case "绿->白渐变色": { colorGradientType = ColorGradientType.GreenWhite; break; }
                    case "蓝->白渐变色": { colorGradientType = ColorGradientType.BlueWhite; break; }
                    case "黄->白渐变色": { colorGradientType = ColorGradientType.YellowWhite; break; }
                    case "粉红->白渐变色": { colorGradientType = ColorGradientType.PinkWhite; break; }
                    case "青->白渐变色": { colorGradientType = ColorGradientType.CyanWhite; break; }
                    case "红->黑渐变色": { colorGradientType = ColorGradientType.RedBlack; break; }
                    case "绿->黑渐变色": { colorGradientType = ColorGradientType.GreenBlack; break; }
                    case "蓝->黑渐变色": { colorGradientType = ColorGradientType.BlueBlack; break; }
                    case "黄->黑渐变色": { colorGradientType = ColorGradientType.YellowBlack; break; }
                    case "粉红->黑渐变色": { colorGradientType = ColorGradientType.PinkBlack; break; }
                    case "青->黑渐变色": { colorGradientType = ColorGradientType.CyanBlack; break; }
                    case "黄->红渐变色": { colorGradientType = ColorGradientType.YellowRed; break; }
                    case "黄->绿渐变色": { colorGradientType = ColorGradientType.YellowGreen; break; }
                    case "黄->蓝渐变色": { colorGradientType = ColorGradientType.YellowBlue; break; }
                    case "绿->蓝渐变色": { colorGradientType = ColorGradientType.GreenBlue; break; }
                    case "绿->红渐变色": { colorGradientType = ColorGradientType.GreenRed; break; }
                    case "蓝->红渐变色": { colorGradientType = ColorGradientType.BlueRed; break; }
                    case "粉红->红渐变色": { colorGradientType = ColorGradientType.PinkRed; break; }
                    case "粉红->蓝渐变色": { colorGradientType = ColorGradientType.PinkBlue; break; }
                    case "青->蓝渐变色": { colorGradientType = ColorGradientType.CyanBlue; break; }
                    case "青->绿渐变色": { colorGradientType = ColorGradientType.CyanGreen; break; }
                    case "彩虹色": { colorGradientType = ColorGradientType.Rainbow; break; }
                    case "绿->桔黄->紫罗兰渐变色": { colorGradientType = ColorGradientType.GreenOrangeViolet; break; }
                    case "地形渐变": { colorGradientType = ColorGradientType.Terrain; break; }
                    case "光谱渐变": { colorGradientType = ColorGradientType.Spectrum; break; }
                }



                //设置分段参数
                Double rangeParameter;
                //当分段模式为等距离分段法，平方根分段，对数分段法，等计数分段法其中一种模式时，该参数为分段个数；
                //当分段模式为标准差分段法的时候，该参数不起作用；
                //当分段模式为自定义距离时，该参数表示自定义距离。
                rangeParameter = Convert.ToInt32(textBoxrangeParameter.Text);



                themerange = ThemeRange.MakeDefault(dataset, rangeExpression, rangeMode, rangeParameter, colorGradientType);


                //将生成的专题图添加到地图窗口中

                themeLayer = PassParameter.passMapControl.Map.Layers.Add(dataset, themerange, true);

                map.Refresh();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxrangeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当分段模式为标准差分段法的时候，rangeParameter不起作用；
            if (comboBoxrangeMode.Text == "标准差分段")
            {
                textBoxrangeParameter.Visible = false;
                lblrangeParameter.Visible = false;
                textBoxrangeParameter.Text = Convert.ToString(1000);
            }
            else
            {
                lblrangeParameter.Visible = true;
                textBoxrangeParameter.Visible = true;
            }
        }
    }
}
