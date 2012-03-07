using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZClient.SysUser
{
    public partial class frmUserEdit : Form
    {
        public frmUserEdit()
        {
            InitializeComponent();
        }

        #region Property
        private bool _IsCancel = false;
        private WSMain.t_SystemUser _mUser = new WSMain.t_SystemUser();

        public WSMain.t_SystemUser mUser
        {
            get { return _mUser; }
            set { _mUser = value; }
        }

        public bool IsCancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }

        #endregion

        #region InitForm
        
        private void frmUserEdit_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            if (mUser==null)
            {
                this.Close();
                return;
            }

            tb_Name.Text = mUser.sUserName;
            tb_LoginName.Text = mUser.sLoginName;
            mUser.sPassword = string.Empty;
        }

        #endregion
        #region Component

        private void b_OK_Click(object sender, EventArgs e)
        {
            mUser.sLoginName = tb_LoginName.Text;
            mUser.sUserName = tb_Name.Text;
            mUser.sPassword = tb_Password.Text;

            try
            {
                if (!string.IsNullOrEmpty(mUser.sPassword))
                    mUser.sPassword = CommonFunc.EncryptTransString(mUser.sPassword);

                Func.tSysUser.Update(mUser);
                CommonFunc.LoadMsg("修改完成！");
                this.Close();
            }
            catch (Exception ex)
            {
                CommonFunc.LoadMsg(ex.Message);
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            IsCancel = true;
            this.Close();
        }

        #endregion

        
    }
}
