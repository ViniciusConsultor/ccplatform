using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient.Client
{
    public partial class frmClientAdd : Form
    {
        public frmClientAdd()
        {
            InitializeComponent();
        }
        #region Proerty
        private bool _IsCancel = false;

        public bool IsCancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }
        #endregion

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
            return CommonFunc.ValidUser(CommonEnum.eUserAuth.User);
        }
        #endregion

        #region Compent
        
        private void b_Cancel_Click(object sender, EventArgs e)
        {
            IsCancel = true;
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            WSCrm.t_Client mClient = new WSCrm.t_Client();
            mClient.CreateUserID = GlobalData.OperatorID;
            mClient.LastUpdate = DateTime.Now;
            mClient.sAddress = tb_Address.Text;
            mClient.sClientName = tb_Name.Text;
            mClient.sMobiPhone = tb_Mobi.Text;
            mClient.sTelPhone = tb_Phone.Text;
            mClient.Memo = tb_Memo.Text;
            mClient.IsEnable = true;

            try
            {
                Func.tClient.Add(mClient);
                CommonFunc.LoadMsg(mClient.sClientName + "添加成功");
                ClearView();
            }
            catch (Exception ex)
            {
                CommonFunc.LoadMsg(ex.Message);
            }

            tb_Name.Focus();
        }

        private void ClearView()
        {
            tb_Address.Text = string.Empty;
            tb_Name.Text = string.Empty;
            tb_Mobi.Text = string.Empty;
            tb_Phone.Text = string.Empty;
            tb_Memo.Text = string.Empty;
        }
        #endregion

        #region Func

        #endregion

    }
}
