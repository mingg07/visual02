using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtNo1.Text == "" || txtNo2.Text=="")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요.");
                return;
            }
            //숫자1에서 숫자를 가져온다.
            double label1 = double.Parse(txtNo1.Text);

            //숫자2에서 숫자를 가져온다.
            double label2 = double.Parse(txtNo2.Text);

            //계산을 한다.
            lblResult.Text = "(*) 결과";

            double result = 0;
            //결과창에 보여준다.
            result = label1 * label2;
            txtResult.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요.");
                return;
            }
            //숫자1에서 숫자를 가져온다.
            double label1 = double.Parse(txtNo1.Text);

            //숫자2에서 숫자를 가져온다.
            double label2 = double.Parse(txtNo2.Text);

            //계산을 한다.
            lblResult.Text = "(/) 결과";

            double result = 0;
            //결과창에 보여준다.
            result = label1 / label2;
            txtResult.Text = result.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요.");
                return;
            }
            //숫자1에서 숫자를 가져온다.
            double label1 = double.Parse(txtNo1.Text);

            //숫자2에서 숫자를 가져온다.
            double label2 = double.Parse(txtNo2.Text);

            //계산을 한다.
            lblResult.Text = "(+) 결과";

            double result = 0;
            //결과창에 보여준다.
            result = label1+label2;
            txtResult.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtNo1.Text == "" || txtNo2.Text == "")
            {
                MessageBox.Show("숫자 두 개를 다 입력하세요.");
                return;
            }
            //숫자1에서 숫자를 가져온다.
            double label1 = double.Parse(txtNo1.Text);

            //숫자2에서 숫자를 가져온다.
            double label2 = double.Parse(txtNo2.Text);

            //계산을 한다.
            lblResult.Text = "(-) 결과";

            double result = 0;
            //결과창에 보여준다.
            result = label1 - label2;
            txtResult.Text = result.ToString();
        }

        private void txtNo1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
