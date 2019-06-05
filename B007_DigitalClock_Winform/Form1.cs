using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B007_DigitalClock_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            Timer t = new Timer();
            t.Interval = 10; // 0.01초
            t.Tick += T_Tick;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            string s = string.Format("{0}:{1,3:000}", DateTime.Now.ToString(), DateTime.Now.Millisecond);
            label1.Text = s;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
