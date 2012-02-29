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
    public partial class frmClientEdit : Form
    {
        public frmClientEdit()
        {
            InitializeComponent();
        }
        
        #region Property
        string _ClientID = string.Empty;
        private WSCrm.t_Client mClient = new WSCrm.t_Client();
        public string ClientID
        {
            get { return _ClientID; }
            set { _ClientID = value; }
        }

        

        #endregion

        #region Initform
        private void frmClientAdd_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            mClient = Func.tClient.GetModel(ClientID);
            if (mClient==null)
            {
                this.Close();
                return;
            }
            if (!ValidateUser())
            {
                this.Close();
                return;
            }

            tb_Address.Text = mClient.sAddress;
            tb_Memo.Text = mClient.Memo;
            tb_Mobi.Text = mClient.sMobiPhone;
            tb_Name.Text = mClient.sClientName;
            tb_Phone.Text = mClient.sTelPhone;
        }

        private bool ValidateUser()
        {
            if (CommonFunc.ValidUser(CommonEnum.eUserAuth.Admin))
                return true;
            else
            {
               return mClient.CreateUserID.Equals(GlobalData.OperatorID);
            }
            
        }
        #endregion

        #region Compent

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            mClient.sClientName = tb_Name.Text;
            mClient.sMobiPhone = tb_Mobi.Text;
            mClient.sTelPhone = tb_Phone.Text;
            mClient.Memo = tb_Memo.Text;
            mClient.sAddress = tb_Address.Text;
            try
            {
                Func.tClient.Update(mClient);
                CommonFunc.LoadMsg("修改成功！");
                this.Close();
            }
            catch (Exception ex)
            {
                CommonFunc.LoadMsg(ex.Message);
                
            }
            

        }
        #endregion

        #region Func

        #endregion

    }
}
