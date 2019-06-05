namespace A013_grade_calc
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblGd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txtGd1 = new System.Windows.Forms.TextBox();
            this.txtGd2 = new System.Windows.Forms.TextBox();
            this.txtGd3 = new System.Windows.Forms.TextBox();
            this.txtGd4 = new System.Windows.Forms.TextBox();
            this.txtGd5 = new System.Windows.Forms.TextBox();
            this.txtGd6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblName.Location = new System.Drawing.Point(85, 109);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "과목명";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNo.Location = new System.Drawing.Point(250, 109);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(37, 19);
            this.lblNo.TabIndex = 1;
            this.lblNo.Text = "학점";
            // 
            // lblGd
            // 
            this.lblGd.AutoSize = true;
            this.lblGd.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblGd.Location = new System.Drawing.Point(378, 109);
            this.lblGd.Name = "lblGd";
            this.lblGd.Size = new System.Drawing.Size(37, 19);
            this.lblGd.TabIndex = 2;
            this.lblGd.Text = "성적";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(73, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "인체의 구조와 기능1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(73, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "일반수학1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(73, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "디지털공학및실험";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(73, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "자료구조";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(73, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "비주얼프로그래밍";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(73, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "기업가정신";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt1.Location = new System.Drawing.Point(221, 166);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 26);
            this.txt1.TabIndex = 9;
            this.txt1.Text = "2";
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt2.Location = new System.Drawing.Point(221, 209);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 26);
            this.txt2.TabIndex = 10;
            this.txt2.Text = "3";
            this.txt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt3.Location = new System.Drawing.Point(221, 254);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 26);
            this.txt3.TabIndex = 11;
            this.txt3.Text = "3";
            this.txt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt4
            // 
            this.txt4.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt4.Location = new System.Drawing.Point(221, 294);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 26);
            this.txt4.TabIndex = 12;
            this.txt4.Text = "3";
            this.txt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt5
            // 
            this.txt5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt5.Location = new System.Drawing.Point(221, 331);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 26);
            this.txt5.TabIndex = 13;
            this.txt5.Text = "3";
            this.txt5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt6
            // 
            this.txt6.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt6.Location = new System.Drawing.Point(221, 369);
            this.txt6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 26);
            this.txt6.TabIndex = 14;
            this.txt6.Text = "1";
            this.txt6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGd1
            // 
            this.txtGd1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGd1.Location = new System.Drawing.Point(348, 166);
            this.txtGd1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGd1.Name = "txtGd1";
            this.txtGd1.Size = new System.Drawing.Size(100, 26);
            this.txtGd1.TabIndex = 15;
            this.txtGd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGd2
            // 
            this.txtGd2.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGd2.Location = new System.Drawing.Point(348, 209);
            this.txtGd2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGd2.Name = "txtGd2";
            this.txtGd2.Size = new System.Drawing.Size(100, 26);
            this.txtGd2.TabIndex = 16;
            this.txtGd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGd3
            // 
            this.txtGd3.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGd3.Location = new System.Drawing.Point(348, 254);
            this.txtGd3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGd3.Name = "txtGd3";
            this.txtGd3.Size = new System.Drawing.Size(100, 26);
            this.txtGd3.TabIndex = 17;
            this.txtGd3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGd4
            // 
            this.txtGd4.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGd4.Location = new System.Drawing.Point(348, 290);
            this.txtGd4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGd4.Name = "txtGd4";
            this.txtGd4.Size = new System.Drawing.Size(100, 26);
            this.txtGd4.TabIndex = 18;
            this.txtGd4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGd5
            // 
            this.txtGd5.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGd5.Location = new System.Drawing.Point(348, 331);
            this.txtGd5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGd5.Name = "txtGd5";
            this.txtGd5.Size = new System.Drawing.Size(100, 26);
            this.txtGd5.TabIndex = 19;
            this.txtGd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGd6
            // 
            this.txtGd6.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtGd6.Location = new System.Drawing.Point(348, 369);
            this.txtGd6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGd6.Name = "txtGd6";
            this.txtGd6.Size = new System.Drawing.Size(100, 26);
            this.txtGd6.TabIndex = 20;
            this.txtGd6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(234, 436);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "평균평점";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMean
            // 
            this.txtMean.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtMean.Location = new System.Drawing.Point(348, 438);
            this.txtMean.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(100, 26);
            this.txtMean.TabIndex = 22;
            this.txtMean.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 534);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGd6);
            this.Controls.Add(this.txtGd5);
            this.Controls.Add(this.txtGd4);
            this.Controls.Add(this.txtGd3);
            this.Controls.Add(this.txtGd2);
            this.Controls.Add(this.txtGd1);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGd);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("휴먼편지체", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "190325 최민지 성적계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblGd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txtGd1;
        private System.Windows.Forms.TextBox txtGd2;
        private System.Windows.Forms.TextBox txtGd3;
        private System.Windows.Forms.TextBox txtGd4;
        private System.Windows.Forms.TextBox txtGd5;
        private System.Windows.Forms.TextBox txtGd6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtMean;
    }
}

