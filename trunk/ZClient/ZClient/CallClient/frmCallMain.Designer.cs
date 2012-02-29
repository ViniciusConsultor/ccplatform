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
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
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
            this.b_ClientAdd.Click += new System.EventHandler(this.b_ClientAdd_Click);
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
            // cb_Status
            // 
            this.cb_Status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Location = new System.Drawing.Point(651, 12);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(121, 27);
            this.cb_Status.TabIndex = 1;
            this.cb_Status.SelectedIndexChanged += new System.EventHandler(this.cb_Status_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "转接";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmCallMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_ClientAdd);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCallMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "坐席";
            this.Load += new System.EventHandler(this.frmCallMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_ClientAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.Button button2;
    }
}