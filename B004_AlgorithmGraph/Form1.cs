using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace B004_AlgorithmGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Algorithm Chart in WinForm";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // chart1 컨트롤에 Collection에 있었던 내용을 삭제
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            // ChartArea 추가
            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;

            // ChartArea X축과 Y축을 설정
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisX.Maximum = 100;
            chart1.ChartAreas["Draw"].AxisX.Interval = 20;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["Draw"].AxisY.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 200;
            chart1.ChartAreas["Draw"].AxisY.Interval = 50;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Series 추가(ln N)      
            chart1.Series.Add("log2 N");
            chart1.Series["log2 N"].ChartType = SeriesChartType.Line;
            chart1.Series["log2 N"].Color = Color.LightGreen;
            chart1.Series["log2 N"].BorderWidth = 2;
            chart1.Series["log2 N"].LegendText = "log2 N";

            // Series 추가(N)   
            chart1.Series.Add("N");
            chart1.Series["N"].ChartType = SeriesChartType.Line;
            chart1.Series["N"].Color = Color.Orange;
            chart1.Series["N"].BorderWidth = 2;
            chart1.Series["N"].LegendText = "N";

            // Series 추가(N2)      
            chart1.Series.Add("N2");
            chart1.Series["N2"].ChartType = SeriesChartType.Line;
            chart1.Series["N2"].Color = Color.Red;
            chart1.Series["N2"].BorderWidth = 2;
            chart1.Series["N2"].LegendText = "N2";

            // Series 추가(NlnN)   
            chart1.Series.Add("Nlog2 N");
            chart1.Series["Nlog2 N"].ChartType = SeriesChartType.Line;
            chart1.Series["Nlog2 N"].Color = Color.Blue;
            chart1.Series["Nlog2 N"].BorderWidth = 2;
            chart1.Series["Nlog2 N"].LegendText = "Nlog2 N";

            for (double x = 0.01; x < 50; x += 1)
            {
                double y = Math.Log(x, 2);
                chart1.Series["log2 N"].Points.AddXY(x, y);

                y = x;
                chart1.Series["N"].Points.AddXY(x, y);

                y = x * x;
                chart1.Series["N2"].Points.AddXY(x, y);

                y = x * Math.Log(x, 2);
                chart1.Series["Nlog2 N"].Points.AddXY(x, y);
            }
        }
    }
}