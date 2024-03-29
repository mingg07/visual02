﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace A021_DataBase
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = null;
        OleDbCommand comm = null;
        OleDbDataReader reader = null;

//        string connString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Students.accdb;
//        Persist Security Info=False;";
        string connString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = string connString = @Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ../../Students.accdb;
        Persist Security Info=False;";
        public Form1()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void DisplayStudents()
        {
            ConnectionOpen();

            // 명령어 작성 : 모든 레코드를 가져와라(dba)
            // 명령어는 SQL로 만든다
            string sql = "SELECT * FROM StudentTable";
            comm = new OleDbCommand(sql, conn);

            ReadAndAddToListBox();
            ConnectionClose();
        }

        private void ConnectionClose()
        {
            conn.Close();
            conn = null;
        }

        // Reader에서 DB의 값을 읽어와서 ListBox에 표시
        private void ReadAndAddToListBox()
        {
            // 명령어를 실행
            reader = comm.ExecuteReader();

            // DB에서 읽어오는 여러 개의 레코드
            while (reader.Read())    // reader가 그 결과를 가지고 있음.
            {
                string x = "";
                x += reader["ID"] + "\t";
                x += reader["SId"] + "\t";
                x += reader["SName"] + "\t";
                x += reader["Phone"] + "\t";
                listBox1.Items.Add(x);
            }
            reader.Close();
        }

        // DB의 connection을 열어주는 메서드
        private void ConnectionOpen()
        {
            if (conn == null)
            {
                conn = new OleDbConnection(connString);
                conn.Open();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;

            if (lb.SelectedItem == null)
                return;

            string[] s = lb.SelectedItem.ToString().Split('\t');
            txtID.Text = s[0];
            txtSId.Text = s[1];
            txtSName.Text = s[2];
            txtPhone.Text = s[3];
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "" || txtSName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("학번, 이름, 전화번호는 반드시 입력해야 합니다.","추가 에러");
                return;
            }
            ConnectionOpen();
            string sql = string.Format("INSERT INTO StudentTable(SId, SName, Phone) Values({0}, '{1}', '{2}')", txtSId.Text, txtSName.Text, txtPhone.Text);
            MessageBox.Show(sql);   // text용

            comm = new OleDbCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1)   //  삽입(추가)하는 명령.. 추가된 것이 하나라 바뀐게 하나라서 리턴을 1 
                MessageBox.Show("추가 성공!");
            ConnectionClose();

            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "" && txtSName.Text == "" && txtPhone.Text == "")
            {
                MessageBox.Show("학번, 이름, 전화번호 중 하나를 입력해야 합니다.", "검색 에러");
                return;
            }

            ConnectionOpen();

            string sql = "";
            if (txtSId.Text != "")
                sql = string.Format("SELECT * FROM StudentTable WHERE SId={0}", txtSId.Text);   // *은 모든 필드
            else if (txtSName.Text != "")
                sql = string.Format("SELECT * FROM StudentTable WHERE SName='{0}'", txtSName.Text);
            else if (txtPhone.Text != "")
                sql = string.Format("SELECT * FROM StudentTable WHERE Phone='{0}'", txtPhone.Text);
            comm = new OleDbCommand(sql, conn);
            listBox1.Items.Clear();
            ReadAndAddToListBox();
            ConnectionClose();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "" || txtSName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("삭제할 레코드를 선택해야 합니다.", "삭제 에러");
                return;
            }
            ConnectionOpen();
            string sql = string.Format("DELETE FROM StudentTable WHERE ID={0}", txtID.Text);
            MessageBox.Show(sql);   // text용

            comm = new OleDbCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1)   //  삽입(추가)하는 명령.. 추가된 것이 하나라 바뀐게 하나라서 리턴을 1 
                MessageBox.Show("삭제 성공!");
            ConnectionClose();

            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtSId.Text == "")
            {
                MessageBox.Show("수정할 레코드를 먼저 선택해야 합니다.", "수정 에러");
                return;
            }
            ConnectionOpen();
            string sql = string.Format("UPDATE StudentTable SET SID={0}, " +
                "SName='{1}', Phone='{2}' WHERE ID={3}",
                txtSId.Text, txtSName.Text, txtPhone.Text, txtID.Text);
            MessageBox.Show(sql);   // text용

            comm = new OleDbCommand(sql, conn);
            if (comm.ExecuteNonQuery() == 1)   //  삽입(추가)하는 명령.. 추가된 것이 하나라 바뀐게 하나라서 리턴을 1 
                MessageBox.Show("수정 성공!");
            ConnectionClose();

            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DisplayStudents();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtSId.Text = "";
            txtSName.Text = "";
            txtPhone.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}