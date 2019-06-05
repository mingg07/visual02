namespace A016_UnitConverter
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
            this.lblIN = new System.Windows.Forms.Label();
            this.txtIN = new System.Windows.Forms.TextBox();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.lblCM = new System.Windows.Forms.Label();
            this.txtYD = new System.Windows.Forms.TextBox();
            this.lblYD = new System.Windows.Forms.Label();
            this.txtFT = new System.Windows.Forms.TextBox();
            this.lblFT = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(111, 110);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(29, 12);
            this.lblIN.TabIndex = 0;
            this.lblIN.Text = "인치";
            // 
            // txtIN
            // 
            this.txtIN.Location = new System.Drawing.Point(239, 107);
            this.txtIN.Name = "txtIN";
            this.txtIN.Size = new System.Drawing.Size(100, 21);
            this.txtIN.TabIndex = 1;
            // 
            // txtCM
            // 
            this.txtCM.Location = new System.Drawing.Point(239, 164);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(100, 21);
            this.txtCM.TabIndex = 3;
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Location = new System.Drawing.Point(111, 167);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(53, 12);
            this.lblCM.TabIndex = 2;
            this.lblCM.Text = "센티미터";
            // 
            // txtYD
            // 
            this.txtYD.Location = new System.Drawing.Point(239, 216);
            this.txtYD.Name = "txtYD";
            this.txtYD.Size = new System.Drawing.Size(100, 21);
            this.txtYD.TabIndex = 5;
            // 
            // lblYD
            // 
            this.lblYD.AutoSize = true;
            this.lblYD.Location = new System.Drawing.Point(111, 219);
            this.lblYD.Name = "lblYD";
            this.lblYD.Size = new System.Drawing.Size(29, 12);
            this.lblYD.TabIndex = 4;
            this.lblYD.Text = "야드";
            // 
            // txtFT
            // 
            this.txtFT.Location = new System.Drawing.Point(239, 268);
            this.txtFT.Name = "txtFT";
            this.txtFT.Size = new System.Drawing.Size(100, 21);
            this.txtFT.TabIndex = 7;
            // 
            // lblFT
            // 
            this.lblFT.AutoSize = true;
            this.lblFT.Location = new System.Drawing.Point(111, 271);
            this.lblFT.Name = "lblFT";
            this.lblFT.Size = new System.Drawing.Size(29, 12);
            this.lblFT.TabIndex = 6;
            this.lblFT.Text = "피트";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(127, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(249, 333);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "변환";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 443);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtFT);
            this.Controls.Add(this.lblFT);
            this.Controls.Add(this.txtYD);
            this.Controls.Add(this.lblYD);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.lblCM);
            this.Controls.Add(this.txtIN);
            this.Controls.Add(this.lblIN);
            this.Name = "Form1";
            this.Text = "단위변환기 by 최민지";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.TextBox txtIN;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.TextBox txtYD;
        private System.Windows.Forms.Label lblYD;
        private System.Windows.Forms.TextBox txtFT;
        private System.Windows.Forms.Label lblFT;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChange;
    }
}

