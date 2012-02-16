namespace ZClient
{
    partial class Main
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.座席ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hl_Exit = new System.Windows.Forms.LinkLabel();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.座席ToolStripMenuItem,
            this.管理ToolStripMenuItem,
            this.报表ToolStripMenuItem,
            this.日志ToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1016, 25);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 719);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1016, 22);
            this.ssMain.TabIndex = 1;
            this.ssMain.Text = "statusStrip1";
            // 
            // 座席ToolStripMenuItem
            // 
            this.座席ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.座席ToolStripMenuItem.Name = "座席ToolStripMenuItem";
            this.座席ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.座席ToolStripMenuItem.Text = "座席";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.管理ToolStripMenuItem.Text = "管理";
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // 日志ToolStripMenuItem
            // 
            this.日志ToolStripMenuItem.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.日志ToolStripMenuItem.Name = "日志ToolStripMenuItem";
            this.日志ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.日志ToolStripMenuItem.Text = "日志";
            // 
            // hl_Exit
            // 
            this.hl_Exit.AutoSize = true;
            this.hl_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.hl_Exit.Location = new System.Drawing.Point(974, 0);
            this.hl_Exit.Name = "hl_Exit";
            this.hl_Exit.Size = new System.Drawing.Size(42, 22);
            this.hl_Exit.TabIndex = 2;
            this.hl_Exit.TabStop = true;
            this.hl_Exit.Text = "退出";
            this.hl_Exit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hl_Exit_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.hl_Exit);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.msMain;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zsystem";
            this.Load += new System.EventHandler(this.Main_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem 座席ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.LinkLabel hl_Exit;
    }
}

