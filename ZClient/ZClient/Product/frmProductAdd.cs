using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient.Product
{
    public partial class frmProductAdd : Form
    {
        public frmProductAdd()
        {
            InitializeComponent();
        }

        #region Property
        bool _IsCancel = false;

        public bool IsCancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }
        #endregion

        #region Initform
        private void frmAdd_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            if (!ValidateUser())
            {
                this.Close();
            }
            dtp_End.Value = DateTime.Now.AddYears(10);
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
            WSCrm.t_Product mProduct = new WSCrm.t_Product();
            mProduct.Begindate = dtp_Start.Value;
            mProduct.Enddate = dtp_End.Value;
            mProduct.iDiscount = int.Parse(tb_Discount.Text);
            mProduct.iPrice = double.Parse(tb_Price.Text);
            mProduct.IsEnable = true;
            mProduct.KeyID = Guid.NewGuid();
            mProduct.LastUpdate = DateTime.Now;
            mProduct.Memo = tb_Memo.Text;
            mProduct.sProductName = tb_Name.Text;
            mProduct.sProductNum = tb_ProductNum.Text;

            try
            {
                Func.tProduct.Add(mProduct);
                CommonFunc.LoadMsg("添加成功！");
                ClearInput();
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
            tb_Memo.Text = string.Empty;
            //tb_Discount.Text = string.Empty;
            tb_Price.Text = string.Empty;
        }
        #endregion

    }
}
