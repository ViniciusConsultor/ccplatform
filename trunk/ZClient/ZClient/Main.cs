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
            if (MyLogin.IsCancel)
            {
                this.Close();
            }
        }

        private void hl_Exit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        
        #region Menu
        
        private void 座席ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallClient.frmCallMain MyCall = (CallClient.frmCallMain)GetFrm(typeof(CallClient.frmCallMain));
            MyCall.MdiParent = this;

            MyCall.Show();
            MyCall.BringToFront();
            MyCall.WindowState = FormWindowState.Maximized;
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.frmClientMain MyClientMain = (Client.frmClientMain)GetFrm(typeof(Client.frmClientMain));
            MyClientMain.MdiParent = this;

            MyClientMain.Show();
            MyClientMain.BringToFront();
            MyClientMain.WindowState = FormWindowState.Maximized;
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SysUser.frmUserMain MySysUser = (SysUser.frmUserMain)GetFrm(typeof(SysUser.frmUserMain));
            MySysUser.MdiParent = this;

            MySysUser.Show();
            MySysUser.BringToFront();
            MySysUser.WindowState = FormWindowState.Maximized;
        }

        private void 订单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operation.frmOperationMain MyOpMain = (Operation.frmOperationMain)GetFrm(typeof(Operation.frmOperationMain));
            MyOpMain.MdiParent = this;

            MyOpMain.Show();
            MyOpMain.BringToFront();
            MyOpMain.WindowState = FormWindowState.Maximized;
        }

        private void 产品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product.frmProductMain MyMain = (Product.frmProductMain)GetFrm(typeof(Product.frmProductMain));
            MyMain.MdiParent = this;

            MyMain.Show();
            MyMain.BringToFront();
            MyMain.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region Func
        private object GetFrm(Type frmType)
        {
            foreach (var item in MdiChildren)
            {
                if (item.GetType() == frmType)
                    return item;
            }

            return frmType.Assembly.CreateInstance(frmType.FullName);
        }
        #endregion

        

        

        
    }
}
