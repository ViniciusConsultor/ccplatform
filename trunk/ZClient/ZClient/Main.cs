using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin MyLogin = new frmLogin();
            MyLogin.ShowDialog();
        }

        private void hl_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void 座席ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallClient.frmCallMain MyCall = new CallClient.frmCallMain();
            MyCall.MdiParent = this;
            
            MyCall.Show();
            MyCall.WindowState = FormWindowState.Maximized;
        }
    }
}
