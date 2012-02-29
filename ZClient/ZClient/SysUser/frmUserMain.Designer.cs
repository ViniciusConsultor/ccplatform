namespace ZClient.SysUser
{
    partial class frmUserMain
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
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.b_Search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.b_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(13, 72);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(767, 489);
            this.dgvMain.TabIndex = 0;
            // 
            // b_Search
            // 
            this.b_Search.Location = new System.Drawing.Point(176, 15);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(90, 35);
            this.b_Search.TabIndex = 1;
            this.b_Search.Text = "查询";
            this.b_Search.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(13, 15);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(120, 33);
            this.tb_Search.TabIndex = 2;
            // 
            // b_Add
            // 
            this.b_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Add.Location = new System.Drawing.Point(689, 14);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 35);
            this.b_Add.TabIndex = 3;
            this.b_Add.Text = "添加";
            this.b_Add.UseVisualStyleBackColor = true;
            // 
            // frmUserMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.b_Search);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmUserMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Button b_Search;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button b_Add;
    }
}