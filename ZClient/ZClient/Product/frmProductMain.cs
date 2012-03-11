using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ZClient.Product
{
    public partial class frmProductMain : Form
    {
        public frmProductMain()
        {
            InitializeComponent();
        }

        #region Property
        private List<WSCrm.t_Product> _LProduct = new List<WSCrm.t_Product>();
        private string SearchTxt = string.Empty;
        public List<WSCrm.t_Product> LProduct
        {
            get { return _LProduct; }
            set { _LProduct = value; }
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

            GetData();

        }

        private void InitDgv()
        {
            dgvMain.DataSource = LProduct;
            FormatGridView();
        }

        private void FormatGridView()
        {
            if (dgvMain.Columns.Contains("KeyID"))
                dgvMain.Columns["KeyID"].Visible = false;

            if (dgvMain.Columns.Contains("EndDate"))
                dgvMain.Columns["EndDate"].Visible = false;

            if (dgvMain.Columns.Contains("LastUpdate"))
                dgvMain.Columns["LastUpdate"].Visible = false;

            if (dgvMain.Columns.Contains("sProductName"))
            {
                dgvMain.Columns["sProductName"].HeaderText = "名称";
                dgvMain.Columns["sProductName"].DisplayIndex = 1;
            }

            if (dgvMain.Columns.Contains("sProductNum"))
            {
                dgvMain.Columns["sProductNum"].HeaderText = "编号";
                dgvMain.Columns["sProductNum"].DisplayIndex = 2;
            }

            if (dgvMain.Columns.Contains("iPrice"))
            {
                dgvMain.Columns["iPrice"].HeaderText = "价格";
                dgvMain.Columns["iPrice"].DisplayIndex = 3;
            }

            if (dgvMain.Columns.Contains("iDiscount"))
            {
                dgvMain.Columns["iDiscount"].HeaderText = "折扣";
                dgvMain.Columns["iDiscount"].DisplayIndex = 4;
            }

            if (dgvMain.Columns.Contains("BeginDate"))
            {
                dgvMain.Columns["BeginDate"].HeaderText = "启用日";
                dgvMain.Columns["BeginDate"].DefaultCellStyle.Format = "yy年MM月dd日";
                dgvMain.Columns["BeginDate"].DisplayIndex = 5;
            }


            if (dgvMain.Columns.Contains("IsEnable"))
            {
                dgvMain.Columns["IsEnable"].HeaderText = "是否启用";
                dgvMain.Columns["IsEnable"].DisplayIndex = 6;
            }

            if (dgvMain.Columns.Contains("Memo"))
            {
                dgvMain.Columns["Memo"].HeaderText = "备注";
                dgvMain.Columns["Memo"].DisplayIndex = 7;
            }

            if (!dgvMain.Columns.Contains("编辑"))
            {
                DataGridViewLinkColumn Lc = new DataGridViewLinkColumn();
                Lc.HeaderText = "编辑";
                Lc.Name = "编辑";
                if (dgvMain.ColumnCount > 7)
                    Lc.DisplayIndex = 8;


                dgvMain.Columns.Add(Lc);
            }

            for (int i = 0; i < dgvMain.RowCount; i++)
            {
                dgvMain.Rows[i].Cells["编辑"].Value = "编辑";
                dgvMain["IsEnable", i] = new DataGridViewCheckBoxCell();
            }


            CommonFunc.FormatDGVWithBg(dgvMain);
        }

        private void GetData()
        {
            switch (GlobalData.UserAuth)
            {
                case CommonEnum.eUserAuth.Admin:
                    LProduct = Func.tProduct.GetList();
                    break;
                case CommonEnum.eUserAuth.User:
                    LProduct = Func.tProduct.GetList();
                    break;
            }
            if (!string.IsNullOrEmpty(SearchTxt))
            {
                LProduct = LProduct.Where(n => n.sProductName.IndexOf(SearchTxt) > -1 || n.sProductNum.IndexOf(SearchTxt) > -1).ToList();
            }

        }

        private bool ValidUser()
        {
            return CommonFunc.ValidUser(CommonEnum.eUserAuth.User);
        }

        #endregion

        #region Component

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
            Product.frmProductAdd MyAdd = new frmProductAdd();
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

                Product.frmProductEdit MyEdit = new frmProductEdit();
                MyEdit.KeyID = KeyID;
                MyEdit.ShowDialog();
                bgLoad.RunWorkerAsync();
            }
        }
        #endregion
    }
}
