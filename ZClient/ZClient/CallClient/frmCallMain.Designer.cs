namespace ZClient.CallClient
{
    partial class frmCallMain
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
            this.b_ClientAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_ClientAdd
            // 
            this.b_ClientAdd.Location = new System.Drawing.Point(36, 33);
            this.b_ClientAdd.Name = "b_ClientAdd";
            this.b_ClientAdd.Size = new System.Drawing.Size(75, 30);
            this.b_ClientAdd.TabIndex = 0;
            this.b_ClientAdd.Text = "添加客户";
            this.b_ClientAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加订单";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCallMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_ClientAdd);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCallMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "坐席";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_ClientAdd;
        private System.Windows.Forms.Button button1;
    }
}