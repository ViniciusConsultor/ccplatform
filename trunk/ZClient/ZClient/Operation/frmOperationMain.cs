using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZClient.Operation
{
    public partial class frmOperationMain : Form
    {
        public frmOperationMain()
        {
            InitializeComponent();
        }

        #region Property

        #endregion

        #region Init

        private void frmClientMain_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {

        }

        #endregion

        private void b_Add_Click(object sender, EventArgs e)
        {
            frmOperationAdd MyAdd = new frmOperationAdd();
            MyAdd.ShowDialog();
        }
    }
}
