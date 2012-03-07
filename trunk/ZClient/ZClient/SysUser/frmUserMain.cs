using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ZClient.SysUser
{
    public partial class frmUserMain : Form
    {
        public frmUserMain()
        {
            InitializeComponent();
        }

        #region Property
        List<WSMain.t_SystemUser> _LUser = new List<WSMain.t_SystemUser>();

        public List<WSMain.t_SystemUser> LUser
        {
            get { return _LUser; }
            set { _LUser = value; }
        }

        #endregion

        #region InitForm
        private void frmUserMain_Load(object sender, EventArgs e)
        {
            bgInit.RunWorkerAsync();
        }

        private void InitForm()
        {
            _LUser = Func.tSysUser.GetList();
            if (LUser==null || LUser.Count==0)
            {
                DispNone();
            }
            else
                dgvMain.DataSource = LUser;

            FormatDgv();
        }

        private void FormatDgv()
        {
            if (dgvMain.Columns.Contains("KeyID"))
                dgvMain.Columns["KeyID"].Visible = false;

            if (dgvMain.Columns.Contains("sPassword"))
                dgvMain.Columns["sPassword"].Visible = false;

            if (dgvMain.Columns.Contains("LastUpdate"))
                dgvMain.Columns["LastUpdate"].Visible = false;


            if (dgvMain.Columns.Contains("sUserName"))
            {
                dgvMain.Columns["sUserName"].HeaderText = "用户名";
            }
            if (dgvMain.Columns.Contains("sLoginName"))
            {
                dgvMain.Columns["sLoginName"].HeaderText = "登录名";
            }

            if (dgvMain.Columns.Contains("IsEnable"))
            {
                dgvMain.Columns["IsEnable"].HeaderText = "是否启用";
            }

            if (!dgvMain.Columns.Contains("编辑"))
            {
                DataGridViewLinkColumn dlc = new DataGridViewLinkColumn();
                dlc.HeaderText = "编辑";
                dlc.Name = "编辑";

                dgvMain.Columns.Add(dlc);
            }

            //if (!dgvMain.Columns.Contains("禁用"))
            //{
            //    DataGridViewLinkColumn dlc = new DataGridViewLinkColumn();
            //    dlc.HeaderText = "禁用";
            //    dlc.Name = "禁用";

            //    dgvMain.Columns.Add(dlc);
            //}

            if (dgvMain.Columns.Contains("编辑"))
            {
                for (int i = 0; i < dgvMain.RowCount; i++)
                {
                    dgvMain.Rows[i].Cells["编辑"].Value = "编辑";
                    //dgvMain.Rows[i].Cells["禁用"].Value = "禁用";
                }
            }

            CommonFunc.FormatDGVWithBg(dgvMain);
        }

        private void DispNone()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("数据");
            DataRow drNew = dt.NewRow();
            drNew[0] = "尚未添加数据";
            dt.Rows.Add(drNew);

            dgvMain.DataSource = dt;
        }

        private void bgInit_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgInit_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            InitForm();
        }

        #endregion

        
        #region Component
        private void b_Add_Click(object sender, EventArgs e)
        {
            frmUserAdd frmAdd = new frmUserAdd();
            frmAdd.ShowDialog();
            bgInit.RunWorkerAsync();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<0)
                return;

            string UserID = Convert.ToString(dgvMain.Rows[e.RowIndex].Cells["KeyID"].Value);
            if (string.IsNullOrEmpty(UserID))
                return;

            WSMain.t_SystemUser mUser = LUser.Where(n => n.KeyID.Equals(UserID)).ToList()[0];

            if (dgvMain.Columns[e.ColumnIndex].HeaderText.Equals("编辑"))
            {
                frmUserEdit UserEdit = new frmUserEdit();
                UserEdit.mUser = mUser;
                UserEdit.ShowDialog();
                if (!UserEdit.IsCancel)
                    bgInit.RunWorkerAsync();

                
            }
            if (dgvMain.Columns[e.ColumnIndex].HeaderText.Equals("是否启用"))
            {
                string sContent = string.Format("是否要{0}账户:『{1}』?", mUser.IsEnable ? "禁用" : "启用", mUser.sLoginName);

                System.Windows.Forms.DialogResult result = MessageBox.Show(sContent, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==System.Windows.Forms.DialogResult.Yes)
                {
                    if (mUser.IsEnable)
                        Func.tSysUser.DisableUser(UserID);    
                    else
                        Func.tSysUser.EnableUser(UserID);

                    bgInit.RunWorkerAsync();
                }
            }
        }
        #endregion

        
        
    }
}
