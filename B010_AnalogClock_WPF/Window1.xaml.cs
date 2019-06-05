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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace B010_AnalogClock_WPF
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();  // 밀리초
        DispatcherTimer timer2 = new DispatcherTimer();  // 초

        public Window1()
        {
            InitializeComponent();
            timerSetting();
            
        }

        private void timerSetting()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 10);   // 0.01초
            timer.Tick += T_Tick;
            timer.Start();
        }

        private void timerSetting2()
        {
            timer2.Interval = new TimeSpan(0, 0, 0, 0, 0);   // 1초
            timer2.Tick += T2_Tick;
            timer2.Start();
        }

        private void T2_Tick(object sender, EventArgs e)
        {
            string s = string.Format("{0}", DateTime.Now.ToString());
            dClock.Text = s;
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //dClock.Text = DateTime.Now.ToString() + DateTime.Now.Millisecond;
            string s = string.Format("{0}:{1,3:000}", DateTime.Now.ToString(), DateTime.Now.Millisecond);
            dClock.Text = s;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }


        // 디지털
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        // 아날로그
        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow wd = new MainWindow();
            wd.Show();
            this.Hide();
        }

        // 초 단위 표시
        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            timerSetting2();
        }

        // 밀리초 단위 표시
        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            timer2.Stop();
            timerSetting();
        }
    }
}
