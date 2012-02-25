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
        #region Initform
        private void frmClientAdd_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            ValidateUser();
        }

        private void ValidateUser()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Compent

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Func

        #endregion

    }
}
