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
    public partial class frmLogin : Form
    {

        #region Property
        private bool _IsCancel = false;

        public bool IsCancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }

        #endregion
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsCancel = true;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string sPassword = tb_Password.Text;
            string sLoginName = tb_UserName.Text;

            if (string.IsNullOrEmpty(sLoginName))
            {
                CommonFunc.LoadMsg("请输入用户名");
                return;
            }

            if (string.IsNullOrEmpty(sPassword))
            {
                CommonFunc.LoadMsg("请输入密码");
                return;
            }

            string sID = Func.tSysUser.ValidateUser(sLoginName.ToLower(), sPassword);
            if (string.IsNullOrEmpty(sID))
            {
                CommonFunc.LoadMsg("用户名密码错误！");
                return;
            }

            GlobalData.OperatorID = sID;
            this.Close();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            tb_UserName.Text = "Admin";
            tb_Password.Text = "123";
        }
    }
}
