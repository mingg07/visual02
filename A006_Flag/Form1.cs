using System;
using System.Drawing;
using System.Windows.Forms;

namespace A006_Calc
{
    public partial class Form1 : Form
    {
        private bool flag = false;   // 디폴트가 false
        private char op;   // what is default of char in c#
        private double savedValue;   // 디폴트는 0

        public Form1()
        {
            InitializeComponent();
        }

        //savedValue와 현재 txtResult의 값을 op에 따라 계산한다
        private void btnEqual_Click(object sender, EventArgs e)
        {
            double v = double.Parse(txtResult.Text);
            double r;  // 계산 결과

            switch (op)
            {
                case '+':
                    r = savedValue + v;
                    break;
                case '-':
                    r = savedValue - v;
                    break;
                case '*':
                    r = savedValue * v;
                    break;
                case '/':
                    r = savedValue / v;
                    break;
                default:
                    return;
            }
            txtResult.Text = r.ToString();
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains(".") == false)
            {
                txtResult.Text += ".";
            }
        }

        private void Number_Click(object sender, EventArgs e)
        {
            //Button btn = (Button) sender;
            Button btn = sender as Button;
            String no = btn.Text;    //숫자를 가져와서 Number로 문자 처리

            if (txtResult.Text == "0" || flag == true)
            {
                txtResult.Text = no;
                flag = false;
            }
            else
            {
                txtResult.Text += no;
            }
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            // 지금 현재 txtResult에 있는 값을 나중에 계산하기 위해 저장해둔다
            savedValue = double.Parse(txtResult.Text);

            flag = true;  // flag는 연산자가 클릭되면 바뀜

            Button btn = sender as Button;

            if (btn.Text == "+")
                op = '+';
            else if (btn.Text == "-")
                op = '-';
            else if (btn.Text == "×")
                op = '*';
            else if (btn.Text == "÷")
                op = '/';
        }

        private void btn_Hover(object sender, EventArgs e)
        {          
            btn4.BackColor = Color.Orange;

        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            btn4.BackColor = Color.White;
        }
    }
}