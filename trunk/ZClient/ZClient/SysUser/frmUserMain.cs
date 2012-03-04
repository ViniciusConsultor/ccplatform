using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZClient.SysUser
{
    public partial class frmUserMain : Form
    {
        public frmUserMain()
        {
            InitializeComponent();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            frmUserAdd frmAdd = new frmUserAdd();
            frmAdd.ShowDialog();
        }
    }
}
