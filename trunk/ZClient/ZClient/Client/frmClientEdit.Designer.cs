namespace ZClient.Client
{
    partial class frmClientEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_Mobi = new System.Windows.Forms.TextBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Memo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_OK
            // 
            this.b_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_OK.Location = new System.Drawing.Point(381, 370);
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
            this.b_Cancel.Location = new System.Drawing.Point(514, 370);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 35);
            this.b_Cancel.TabIndex = 1;
            this.b_Cancel.TabStop = false;
            this.b_Cancel.Text = "取消";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "名称:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "地址:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "手机:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "固话:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(305, 51);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(120, 29);
            this.tb_Name.TabIndex = 0;
            // 
            // tb_Address
            // 
            this.tb_Address.Location = new System.Drawing.Point(305, 115);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(120, 29);
            this.tb_Address.TabIndex = 1;
            // 
            // tb_Mobi
            // 
            this.tb_Mobi.Location = new System.Drawing.Point(305, 179);
            this.tb_Mobi.Name = "tb_Mobi";
            this.tb_Mobi.Size = new System.Drawing.Size(120, 29);
            this.tb_Mobi.TabIndex = 2;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(305, 243);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(120, 29);
            this.tb_Phone.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "备注:";
            // 
            // tb_Memo
            // 
            this.tb_Memo.Location = new System.Drawing.Point(305, 307);
            this.tb_Memo.Name = "tb_Memo";
            this.tb_Memo.Size = new System.Drawing.Size(120, 29);
            this.tb_Memo.TabIndex = 4;
            // 
            // frmClientEdit
            // 
            this.AcceptButton = this.b_OK;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.b_Cancel;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.tb_Memo);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_Mobi);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_OK);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.frmClientAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Address;
        private System.Windows.Forms.TextBox tb_Mobi;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Memo;
    }
}