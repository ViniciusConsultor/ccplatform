namespace ZClient.Product
{
    partial class frmProductEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.tb_Discount = new System.Windows.Forms.TextBox();
            this.tb_Price = new System.Windows.Forms.TextBox();
            this.tb_ProductNum = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_OK
            // 
            this.b_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_OK.Location = new System.Drawing.Point(389, 402);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 35);
            this.b_OK.TabIndex = 0;
            this.b_OK.TabStop = false;
            this.b_OK.Text = "确定";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_Cancel.Location = new System.Drawing.Point(522, 402);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 35);
            this.b_Cancel.TabIndex = 1;
            this.b_Cancel.TabStop = false;
            this.b_Cancel.Text = "取消";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // dtp_End
            // 
            this.dtp_End.Location = new System.Drawing.Point(287, 282);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(159, 29);
            this.dtp_End.TabIndex = 5;
            // 
            // dtp_Start
            // 
            this.dtp_Start.Location = new System.Drawing.Point(287, 231);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(159, 29);
            this.dtp_Start.TabIndex = 4;
            // 
            // tb_Memo
            // 
            this.tb_Memo.Location = new System.Drawing.Point(287, 333);
            this.tb_Memo.Multiline = true;
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(193, 61);
            this.tb_Memo.TabIndex = 6;
            // 
            // tb_Discount
            // 
            this.tb_Discount.Location = new System.Drawing.Point(287, 180);
            this.tb_Discount.Name = "tb_Discount";
            this.tb_Discount.Size = new System.Drawing.Size(120, 29);
            this.tb_Discount.TabIndex = 3;
            // 
            // tb_Price
            // 
            this.tb_Price.Location = new System.Drawing.Point(287, 129);
            this.tb_Price.Name = "tb_Price";
            this.tb_Price.Size = new System.Drawing.Size(120, 29);
            this.tb_Price.TabIndex = 2;
            // 
            // tb_ProductNum
            // 
            this.tb_ProductNum.Location = new System.Drawing.Point(287, 78);
            this.tb_ProductNum.Name = "tb_ProductNum";
            this.tb_ProductNum.Size = new System.Drawing.Size(120, 29);
            this.tb_ProductNum.TabIndex = 1;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(287, 27);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(120, 29);
            this.tb_Name.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "备注:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "启用时间:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "启用时间:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "折扣:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "价格:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(152, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "产品编号:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "名称:";
            // 
            // frmProductEdit
            // 
            this.AcceptButton = this.b_OK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.b_Cancel;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.tb_Discount);
            this.Controls.Add(this.tb_Price);
            this.Controls.Add(this.tb_ProductNum);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_OK);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加";
            this.Load += new System.EventHandler(this.frmEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.TextBox tb_Memo;
        private System.Windows.Forms.TextBox tb_Discount;
        private System.Windows.Forms.TextBox tb_Price;
        private System.Windows.Forms.TextBox tb_ProductNum;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}