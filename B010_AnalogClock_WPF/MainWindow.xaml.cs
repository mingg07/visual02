using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace B010_AnalogClock_WPF
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point center;  // 중심점
        private double radius;  // 반지름
        private int hourHand;  // 시침
        private int minHand;  // 분침
        private int secHand;  // 초침

        DispatcherTimer timer = new DispatcherTimer();  // 밀리초
        DispatcherTimer timer2 = new DispatcherTimer();  // 초

        public MainWindow()
        {
            InitializeComponent();
            aClockSetting();
            TimerSetting();
        }

        private void aClockSetting()
        {
            center = new Point(canvas1.Width / 2, canvas1.Height / 2);
            radius = canvas1.Width / 2;
            hourHand = (int)(radius * 0.45);
            minHand = (int)(radius * 0.55);
            secHand = (int)(radius * 0.65);
        }
        private void TimerSetting()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10); // 0.01초에 한 번씩
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void TimerSetting2()
        {
            timer2.Interval = new TimeSpan(0, 0, 0, 0, 0); // 1초에 한 번씩
            timer2.Tick += Timer2_Tick;
            timer2.Start();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            canvas1.Children.Clear();  // 현재화면 지우기
            DrawClockFace(); // 시계판 그리기
            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
            double radSec = c.Second * 6 * Math.PI / 180;
            DrawHands(radHr, radMin, radSec); // 바늘 그리기
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime c = DateTime.Now;

            canvas1.Children.Clear();  // 현재화면 지우기
            DrawClockFace(); // 시계판 그리기
            double radHr = (c.Hour % 12 + c.Minute / 60.0) * 30 * Math.PI / 180;
            double radMin = (c.Minute + c.Second / 60.0) * 6 * Math.PI / 180;
            double radSec = (c.Second + c.Millisecond / 1000.0) * 6 * Math.PI / 180;
            DrawHands(radHr, radMin, radSec); // 바늘 그리기
        }

        private void DrawClockFace()
        {
            aClock.Stroke = Brushes.Coral;
            aClock.StrokeThickness = 30;
            canvas1.Children.Add(aClock);
        }

        private void DrawHands(double radHr, double radMin, double radSec)
        {
            // 시침
            DrawLine(hourHand * Math.Sin(radHr), -hourHand * Math.Cos(radHr),
              0, 0, Brushes.Orange, 8, new Thickness(center.X, center.Y, 0, 0));
            // 분침
            DrawLine(minHand * Math.Sin(radMin), -minHand * Math.Cos(radMin),
              0, 0, Brushes.DarkSalmon, 6, new Thickness(center.X, center.Y, 0, 0));
            // 초침
            DrawLine(secHand * Math.Sin(radSec), -secHand * Math.Cos(radSec),
              0, 0, Brushes.OrangeRed, 3, new Thickness(center.X, center.Y, 0, 0));

            Ellipse core = new Ellipse();
            core.Margin = new Thickness(canvas1.Width / 2 - 10, canvas1.Height / 2 - 10, 0, 0);
            core.Stroke = Brushes.Coral;
            core.Fill = Brushes.White;
            core.Width = 20;
            core.Height = 20;
            canvas1.Children.Add(core);
        }

        private void DrawLine(double x1, double y1, int x2, int y2, SolidColorBrush color, int thick, Thickness margin)
        {
            Line line = new Line();
            line.X1 = x1; line.Y1 = y1; line.X2 = x2; line.Y2 = y2;
            line.Stroke = color;
            line.StrokeThickness = thick;
            line.Margin = margin;
            line.StrokeStartLineCap = PenLineCap.Round;
            canvas1.Children.Add(line);
        }

        // 디지털
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Window1 w = new Window1();
            w.Show();
            this.Hide();
        }

        // 아날로그
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        // 초 단위 표시
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            aClockSetting();
            TimerSetting2();
        }
        
        // 밀리초 단위 표시
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            timer2.Stop();
            aClockSetting();
            TimerSetting();
        }
    }
}
