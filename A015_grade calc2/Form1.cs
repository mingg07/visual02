using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A013_grade_calc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double GetScore(string text)
        {
            if (text == "A+") return 4.5;
            else if (text == "A0") return 4.0;
            else if (text == "B+") return 3.5;
            else if (text == "B0") return 3.0;
            else if (text == "C+") return 2.5;
            else if (text == "C0") return 2.0;
            else if (text == "D+") return 1.5;
            else if (text == "D0") return 1.0;
            else return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "2";
            txt2.Text = "3";
            txt3.Text = "3";
            txt4.Text = "3";
            txt5.Text = "3";
            txt6.Text = "1";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TextBox[] txts = { txt1, txt2, txt3, txt4, txt5, txt6 };
            TextBox[] gds = { txtGd1, txtGd2, txtGd3, txtGd4, txtGd5, txtGd6 };

            int totalCredits = 0;
            double totalScore = 0;

            for (int i = 0; i < 6; i++)
            {
                int credit = int.Parse(txts[i].Text);
                string text = gds[i].Text;
                double score = GetScore(text);
                totalCredits += credit;              //중요
                totalScore += credit * score;        //중요
            }
            txtMean.Text = (totalScore / totalCredits).ToString("0.00");
        }
    }
}
