using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient.SysUser
{
    public partial class frmUserAdd : Form
    {
        public frmUserAdd()
        {
            InitializeComponent();
        }
        #region Initform
        private void frmClientAdd_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            if (!ValidateUser())
            {
                this.Close();
            }
        }

        private bool ValidateUser()
        {
            return CommonFunc.ValidUser(CommonEnum.eUserAuth.Admin);
        }
        #endregion

        #region Compent

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            WSMain.t_SystemUser mUser=new WSMain.t_SystemUser();
            mUser.sLoginName = tb_LoginName.Text;
            mUser.sPassword = tb_Password.Text;
            mUser.sUserName = tb_Name.Text;
            try
            {
                Func.tSysUser.Add(mUser);
                ClearInput();
                CommonFunc.LoadMsg(mUser.sUserName + "添加成功");
            }
            catch (Exception ex)
            {

                CommonFunc.LoadMsg(ex.Message);
            }
            
        }

        #endregion

        #region Func

        private void ClearInput()
        {
            tb_Name.Text = string.Empty;
            tb_LoginName.Text = string.Empty;
            tb_Password.Text = string.Empty;
        }
        #endregion

    }
}
