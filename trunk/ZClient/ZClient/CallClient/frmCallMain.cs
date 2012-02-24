using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient.CallClient
{
    public partial class frmCallMain : Form
    {
        public frmCallMain()
        {
            InitializeComponent();
        }

        private void b_ClientAdd_Click(object sender, EventArgs e)
        {
            Client.frmClientAdd MyClientAdd = new Client.frmClientAdd();
            MyClientAdd.MdiParent = this.Owner;
            MyClientAdd.ShowDialog();
        }
    }
}
