using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient.Operation
{
    public partial class frmOperationAdd : Form
    {
        public frmOperationAdd()
        {
            InitializeComponent();
        }

        #region Property
        List<WSCrm.t_Client> _Lclient = new List<WSCrm.t_Client>();
        List<WSCrm.t_OperationState> Lopstate = new List<WSCrm.t_OperationState>();

        public List<WSCrm.t_Client> Lclient
        {
            get { return _Lclient; }
            set { _Lclient = value; }
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
                
            }
            WSCrm.CrmService MyCrm = new WSCrm.CrmService();
            Lclient = new List<WSCrm.t_Client>(MyCrm.GetClientList(GlobalData.OperatorID));
            //Lopstate=new List<WSCrm.t_OperationState>()
            AutoStringName();


        }

        private bool ValidateUser()
        {
            return true;
        }
        #endregion

        #region Compent

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            try
            {
                string sClientName = tb_Name.Text;
                if (string.IsNullOrEmpty(sClientName))
                    throw new ArgumentException("请输入用户！");

                WSCrm.t_Client mClient = Lclient.Where(n => n.sClientName.Equals(sClientName)).First();
                if (mClient==null)
                    throw new ArgumentException("用户不存在请添加！");

                WSCrm.t_Operation mOperation = new WSCrm.t_Operation();
                mOperation.ClientID = mClient.KeyID;
                mOperation.CreateUser = GlobalData.OperatorID;
                mOperation.IsEnable = true;
                mOperation.iStatus = (int)cb_Status.SelectedValue;
                mOperation.iTotalPrice = 0;
                mOperation.LastUpdate = DateTime.Now;
                mOperation.Memo = tb_Memo.Text;
                
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        #endregion


        private void AutoStringName()
        {

            if (Lclient==null|| Lclient.Count==0)
                return;

            AutoCompleteStringCollection myStrs = new AutoCompleteStringCollection();
            
            foreach (var item in Lclient)
                myStrs.Add(item.sClientName);

            tb_Name.AutoCompleteCustomSource = myStrs;
            tb_Name.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tb_Name.AutoCompleteMode = AutoCompleteMode.Suggest;
        }

        private void tb_Name_Leave(object sender, EventArgs e)
        {
            if (tb_Name.Text!=null)
            {
                
            }
        }


        #region Func

        #endregion

    }
}
