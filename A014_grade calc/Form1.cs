using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A013_grade_calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double average;
            double sum = 0;
            double grade1= 0, grade2 = 0, grade3 = 0, grade4 = 0, grade5 = 0, grade6 = 0;
            double total = double.Parse(txt1.Text) + double.Parse(txt2.Text) + double.Parse(txt3.Text)
                + double.Parse(txt4.Text) + double.Parse(txt5.Text) + double.Parse(txt6.Text);

            if (txtGd1.Text == "A+")
                grade1 = 4.5 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "A0")
                grade1 = 4.0 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "B+")
                grade1 = 3.5 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "B0")
                grade1 = 3.0 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "C+")
                grade1 = 2.5 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "C0")
                grade1 = 2.0 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "D+")
                grade1 = 1.5 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "D0")
                grade1 = 1.0 * double.Parse(txt1.Text);
            else if (txtGd1.Text == "F")
                grade1 = 0 * double.Parse(txt1.Text);

            if (txtGd2.Text == "A+")
                grade2 = 4.5 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "A0")
                grade2 = 4.0 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "B+")
                grade2 = 3.5 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "B0")
                grade2 = 3.0 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "C+")
                grade2 = 2.5 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "C0")
                grade2 = 2.0 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "D+")
                grade2 = 1.5 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "D0")
                grade2 = 1.0 * double.Parse(txt2.Text);
            else if (txtGd2.Text == "F")
                grade2 = 0 * double.Parse(txt2.Text);

            if (txtGd3.Text == "A+")
                grade3 = 4.5 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "A0")
                grade3 = 4.0 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "B+")
                grade3 = 3.5 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "B0")
                grade3 = 3.0 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "C+")
                grade3 = 2.5 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "C0")
                grade3 = 2.0 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "D+")
                grade3 = 1.5 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "D0")
                grade3 = 1.0 * double.Parse(txt3.Text);
            else if (txtGd3.Text == "F")
                grade3 = 0 * double.Parse(txt3.Text);

            if (txtGd4.Text == "A+")
                grade4 = 4.5 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "A0")
                grade4 = 4.0 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "B+")
                grade4 = 3.5 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "B0")
                grade4 = 3.0 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "C+")
                grade4 = 2.5 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "C0")
                grade4 = 2.0 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "D+")
                grade4 = 1.5 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "D0")
                grade4 = 1.0 * double.Parse(txt4.Text);
            else if (txtGd4.Text == "F")
                grade4 = 0 * double.Parse(txt4.Text);

            if (txtGd5.Text == "A+")
                grade5 = 4.5 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "A0")
                grade5 = 4.0 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "B+")
                grade5 = 3.5 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "B0")
                grade5 = 3.0 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "C+")
                grade5 = 2.5 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "C0")
                grade5 = 2.0 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "D+")
                grade5 = 1.5 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "D0")
                grade5 = 1.0 * double.Parse(txt5.Text);
            else if (txtGd5.Text == "F")
                grade5 = 0 * double.Parse(txt5.Text);

            if (txtGd6.Text == "A+")
                grade6 = 4.5 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "A0")
                grade6 = 4.0 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "B+")
                grade6 = 3.5 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "B0")
                grade6 = 3.0 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "C+")
                grade6 = 2.5 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "C0")
                grade6= 2.0 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "D+")
                grade6 = 1.5 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "D0")
                grade6 = 1.0 * double.Parse(txt6.Text);
            else if (txtGd6.Text == "F")
                grade6 = 0 * double.Parse(txt6.Text);

            sum = grade1 + grade2 + grade3 + grade4 + grade5 + grade6;
            average = sum / total;
            txtMean.Text = average.ToString("0.00");
        }
    }
}
