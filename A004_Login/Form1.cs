using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A004
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label1 = txtID.Text;
            string label2 = txtPass.Text;
            if (label1 == "admin" && label2 == "0616")
            {
                lblResult.Text = "성공";
            }
            else
                lblResult.Text = "실패";
        }
    }
}
