using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ZClient.Client
{
    public partial class frmClientMain : Form
    {
        public frmClientMain()
        {
            InitializeComponent();
        }

        #region Property
        private List<WSCrm.t_Client> _Lclient = new List<WSCrm.t_Client>();
        private string SearchTxt = string.Empty;
        public List<WSCrm.t_Client> Lclient
        {
            get { return _Lclient; }
            set { _Lclient = value; }
        }
        #endregion

        #region Init

        private void frmClientMain_Load(object sender, EventArgs e)
        {
            bgLoad.RunWorkerAsync();
        }

        private void InitForm()
        {
            if (!ValidUser())
                this.Close();

            GetClientData();
            
        }

        private void InitDgv()
        {

            dgvMain.DataSource = Lclient;
            FormatGridView();
        }

        private void FormatGridView()
        {
            if (dgvMain.Columns.Contains("KeyID"))
                dgvMain.Columns["KeyID"].Visible = false;

            if (dgvMain.Columns.Contains("LastUpdate"))
                dgvMain.Columns["LastUpdate"].Visible = false;

            if (dgvMain.Columns.Contains("sClientName"))
            {
                dgvMain.Columns["sClientName"].HeaderText = "名称";
                dgvMain.Columns["sClientName"].DisplayIndex = 1;
            }

            if (dgvMain.Columns.Contains("sAddress"))
            {
                dgvMain.Columns["sAddress"].HeaderText = "地址";
                dgvMain.Columns["sAddress"].DisplayIndex = 2;
            }
            if (dgvMain.Columns.Contains("sMobiPhone"))
            {
                dgvMain.Columns["sMobiPhone"].HeaderText = "手机";
                dgvMain.Columns["sMobiPhone"].DisplayIndex = 3;
            }

            if (dgvMain.Columns.Contains("sTelPhone"))
            {
                dgvMain.Columns["sTelPhone"].HeaderText = "电话";
                dgvMain.Columns["sTelPhone"].DisplayIndex = 4;
            }

            if (dgvMain.Columns.Contains("CreateUserID"))
            {
                dgvMain.Columns["CreateUserID"].HeaderText = "创建";
                dgvMain.Columns["CreateUserID"].DisplayIndex = 5;
            }

            if (dgvMain.Columns.Contains("IsEnable"))
            {
                dgvMain.Columns["IsEnable"].Visible = false;

            }
            if (!dgvMain.Columns.Contains("启用"))
            {
                dgvMain.Columns.Add("启用", "启用");
                if (dgvMain.ColumnCount>5)
                    dgvMain.Columns["启用"].DisplayIndex = 6;    
                
            }

            if (dgvMain.Columns.Contains("Memo"))
            {
                dgvMain.Columns["Memo"].HeaderText = "备注";
                if (dgvMain.ColumnCount>6)
                    dgvMain.Columns["Memo"].DisplayIndex = 7;    
                
            }

            if (!dgvMain.Columns.Contains("编辑"))
            {
                DataGridViewLinkColumn Lc = new DataGridViewLinkColumn();
                Lc.HeaderText = "编辑";
                Lc.Name = "编辑";
                if (dgvMain.ColumnCount>7)
                    Lc.DisplayIndex = 8;    
                

                dgvMain.Columns.Add(Lc);
            }

            for (int i = 0; i < dgvMain.RowCount; i++)
            {
                dgvMain.Rows[i].Cells["启用"].Value = (bool)dgvMain.Rows[i].Cells["IsEnable"].Value ? "是" : "否";
                dgvMain.Rows[i].Cells["编辑"].Value = "编辑";
                
            }


            CommonFunc.FormatDGVWithBg(dgvMain);
        }

        private void GetClientData()
        {
            switch (GlobalData.UserAuth)
            {
                case CommonEnum.eUserAuth.Admin:
                    Lclient = Func.tClient.GetUserList();
                    break;
                case CommonEnum.eUserAuth.User:
                    Lclient = Func.tClient.GetUserList(GlobalData.OperatorID);
                    break;
            }
            if (!string.IsNullOrEmpty(SearchTxt))
            {
                Lclient = Lclient.Where(n => n.sClientName.IndexOf(SearchTxt) > -1 || n.sAddress.IndexOf(SearchTxt) > -1 || n.sMobiPhone.IndexOf(SearchTxt) > -1).ToList();
            }
            
        }

        private bool ValidUser()
        {
            return CommonFunc.ValidUser(CommonEnum.eUserAuth.User);
        }

        #endregion

        #region Component
        private void dgvMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bgLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            InitForm();
        }

        private void bgLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitDgv();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            Client.frmClientAdd MyAdd = new frmClientAdd();
            MyAdd.ShowDialog();
            //if (MyAdd.IsCancel)
            //    return;

            bgLoad.RunWorkerAsync();
        }

        private void b_Search_Click(object sender, EventArgs e)
        {
            SearchTxt = tb_Search.Text;
            bgLoad.RunWorkerAsync();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.Columns[e.ColumnIndex].Name.Equals("编辑") && e.RowIndex >= 0)
            {
                string KeyID = Convert.ToString(dgvMain.Rows[e.RowIndex].Cells["KeyID"].Value);
                if (string.IsNullOrEmpty(KeyID))
                    return;

                Client.frmClientEdit MyEdit = new frmClientEdit();
                MyEdit.ClientID = KeyID;
                MyEdit.ShowDialog();
                bgLoad.RunWorkerAsync();
            }
        }
        #endregion

    }
}
