using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A016_UnitConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //인치, 센티미터, 야드, 피트를 변환하는,,
        private void btnChange_Click(object sender, EventArgs e)
        {
            double lblIN = double.Parse(txtIN.Text);
            if (txtCM.Text !="")
            {
                txtIN.Text = (double.Parse(txtCM.Text) * 0.3937).ToString("0.000");
                txtYD.Text = (double.Parse(txtCM.Text) * 0.0109).ToString("0.000");
                txtFT.Text = (double.Parse(txtCM.Text) * 0.0328).ToString("0.000");
            }
            if (txtIN.Text != "")
            {
                txtCM.Text = (double.Parse(txtIN.Text) * 2.54).ToString("0.000");
                txtYD.Text = (double.Parse(txtIN.Text) * 0.0278).ToString("0.000");
                txtFT.Text = (double.Parse(txtIN.Text) * 0.0833).ToString("0.000");
            }
            if (txtYD.Text != "")
            {
                txtCM.Text = (double.Parse(txtYD.Text) * 91.438).ToString("0.000");
                txtIN.Text = (double.Parse(txtYD.Text) * 36).ToString("0.000");
                txtFT.Text = (double.Parse(txtYD.Text) * 3).ToString("0.000");
            }
            if (txtFT.Text != "")
            {
                txtCM.Text = (double.Parse(txtFT.Text) * 30.48).ToString("0.000");
                txtIN.Text = (double.Parse(txtFT.Text) * 12).ToString("0.000");
                txtYD.Text = (double.Parse(txtFT.Text) * 0.333).ToString("0.000");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCM.Text = "";
            txtIN.Text = "";
            txtYD.Text = "";
            txtFT.Text = "";
        }
    }
}
