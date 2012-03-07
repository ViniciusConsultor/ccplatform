using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZClient.SysUser
{
    public partial class frmUserEdit : Form
    {
        public frmUserEdit()
        {
            InitializeComponent();
        }

        #region Property
        private bool _IsCancel = false;
        private WSMain.t_SystemUser _mUser = new WSMain.t_SystemUser();

        public WSMain.t_SystemUser mUser
        {
            get { return _mUser; }
            set { _mUser = value; }
        }

        public bool IsCancel
        {
            get { return _IsCancel; }
            set { _IsCancel = value; }
        }

        #endregion



        #region Component
        
        private void b_OK_Click(object sender, EventArgs e)
        {

        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            IsCancel = true;
            this.Close();
        }

        #endregion
    }
}
