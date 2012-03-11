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
    public partial class frmProductEdit : Form
    {
        public frmProductEdit()
        {
            InitializeComponent();
        }

        #region Property
        bool _IsCancel = false;
        string _KeyID = string.Empty;
        WSCrm.t_Product mProduct = new WSCrm.t_Product();
        public string KeyID
        {
            get { return _KeyID; }
            set { _KeyID = value; }
        }

        public bool IsCancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }
        #endregion

        #region Initform
        private void frmEdit_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            if (!ValidateUser())
            {
                this.Close();
            }
            mProduct = Func.tProduct.GetModel(KeyID);
            if (mProduct==null)
                return;

            tb_Name.Text = mProduct.sProductName;
            tb_Price.Text = mProduct.iPrice.ToString();
            tb_Memo.Text = mProduct.Memo;
            tb_ProductNum.Text = mProduct.sProductNum;
            tb_Discount.Text = mProduct.iDiscount.ToString();
            dtp_Start.Value = mProduct.Begindate.Value;
            dtp_End.Value = mProduct.Enddate.Value;

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
            mProduct.Begindate = dtp_Start.Value;
            mProduct.Enddate = dtp_End.Value;
            mProduct.iDiscount = int.Parse(tb_Discount.Text);
            mProduct.iPrice = double.Parse(tb_Price.Text);
            mProduct.IsEnable = true;
            mProduct.LastUpdate = DateTime.Now;
            mProduct.Memo = tb_Memo.Text;
            mProduct.sProductName = tb_Name.Text;
            mProduct.sProductNum = tb_ProductNum.Text;

            try
            {
                Func.tProduct.Update(mProduct);
                CommonFunc.LoadMsg("修改完成！");
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
