using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace B005_ECGPPG
{
    public partial class Form1 : Form
    {
        Timer myTimer = new Timer();

        public Form1()   // 생성자 메서드
        {
            InitializeComponent();
            chart1.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            this.Text = "ECG / PPG";

            EcgRead();   // 메서드는 모두 대문자로 시작(멤버함수)
            PpgRead();

            myTimer.Interval = 10; // 0.01초
            myTimer.Tick += MyTimer_Tick;
        }

        int cursorX = 0;   // 현재 그래프에 표시되는 데이터의 시작점
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            if ((cursorX + 500) <= ecgCount)
                chart1.ChartAreas["Draw"].AxisX.ScaleView.Zoom(cursorX, cursorX + 500);
            else
                myTimer.Stop();
            cursorX += 2;
        }

        private void Form1_Load(object sender, EventArgs e)   // 이벤트 메서드
        {
              
        }

        private void ChartSetting()
        {
            chart1.ChartAreas.Clear();
            chart1.Series.Clear();

            chart1.ChartAreas.Add("Draw");
            chart1.ChartAreas["Draw"].BackColor = Color.Black;
            chart1.ChartAreas["Draw"].AxisX.Minimum = 0;
            chart1.ChartAreas["Draw"].AxisX.Maximum = ecgCount;
            chart1.ChartAreas["Draw"].AxisX.Interval = 50;
            chart1.ChartAreas["Draw"].AxisX.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisX.LineDashStyle = ChartDashStyle.Dash;

            chart1.ChartAreas["Draw"].AxisY.Minimum = -3;
            chart1.ChartAreas["Draw"].AxisY.Maximum = 5;
            chart1.ChartAreas["Draw"].AxisY.Interval = 0.5;
            chart1.ChartAreas["Draw"].AxisY.MajorGrid.LineColor = Color.Gray;
            chart1.ChartAreas["Draw"].AxisY.LineDashStyle = ChartDashStyle.Dash;

            chart1.Series.Add("ECG");
            chart1.Series["ECG"].ChartType = SeriesChartType.Line;
            chart1.Series["ECG"].Color = Color.LightGreen;
            chart1.Series["ECG"].BorderWidth = 2;
            chart1.Series["ECG"].LegendText = "ECG";

            chart1.Series.Add("PPG");
            chart1.Series["PPG"].ChartType = SeriesChartType.Line;
            chart1.Series["PPG"].Color = Color.HotPink;
            chart1.Series["PPG"].BorderWidth = 2;
            chart1.Series["PPG"].LegendText = "PPG";
        }

        double[] ecg = new double[50000];   // 필드는 모두 소문자로 시작(멤버변수)
        double[] ppg = new double[50000];
        int ecgCount;
        int ppgCount;

        private void PpgRead()
        {
            string fileName = "../../Data/ppg.txt";
            string[] lines = File.ReadAllLines(fileName);

            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < lines.Length; i++)   // for문
            {
                ppg[i] = double.Parse(lines[i]);
                if (ppg[i] > max)
                    max = ppg[i];
                if (ppg[i] < min)
                    min = ppg[i];
            }
            ppgCount = lines.Length;

            string s = string.Format("PPG : Count = {0}, Min = {1}, Max = {2}", ppgCount, min, max);
            MessageBox.Show(s);
        }


        
        private void EcgRead()   // 메서드
        {
            string fileName = "../../Data/ecg.txt";
            string[] lines = File.ReadAllLines(fileName);

            //// 개수를 잘 모르면 foreach 사용!
            //int i = 0;
            //foreach (var line in lines)   // foreach문
            //{
            //    ecg[i] = double.Parse(line);
            //    i++;
            //}

            // ecg의 최대값, 최소값 찾기
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < lines.Length; i++)   // for문
            {
                ecg[i] = double.Parse(lines[i]) +3;
                if (ecg[i] > max)
                    max = ecg[i];
                if (ecg[i] < min)
                    min = ecg[i];
            }
            ecgCount = lines.Length;

            string s = string.Format("ECG : Count = {0}, Min = {1}, Max = {2}", ecgCount, min, max);
            MessageBox.Show(s);

            //MessageBox.Show("ECG : Count = " + ecgCount + ", Min = " + min + ",Max = " + max);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ChartSetting();

            foreach (var v in ecg)
                chart1.Series["ECG"].Points.Add(v);

            foreach (var v in ppg)
                chart1.Series["PPG"].Points.Add(v);
        }

        private void autoScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Start();         
        }

        private void viewAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myTimer.Stop();
            chart1.ChartAreas["Draw"].AxisX.ScaleView.Zoom(0, ecgCount);
        }

        bool autoScrollFlag = false;   // 멤버 변수는 초기화 안 해도 됨 메서드 안에 있을 때만 초기화 해 줘야 함.

        private void chart1_Click(object sender, EventArgs e)
        {
            if (autoScrollFlag == false)
            {
                myTimer.Start();
                autoScrollFlag = true;
            }
            else
            {
                myTimer.Stop();
                autoScrollFlag = false;
            }
        }
    }
}