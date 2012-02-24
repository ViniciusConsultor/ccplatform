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
    public partial class frmClientAdd : Form
    {
        public frmClientAdd()
        {
            InitializeComponent();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            WSCrm.t_Client mClient = new WSCrm.t_Client();
            mClient.CreateUserID = "";
            mClient.LastUpdate = DateTime.Now;
            mClient.sAddress = tb_Address.Text;
            mClient.sClientName = tb_Name.Text;
            mClient.sMobiPhone = tb_Mobi.Text;
            mClient.sTelPhone = tb_Phone.Text;
            mClient.IsEnable = true;

            try
            {
                Func.tClient.Add(mClient);
            }
            catch (Exception ex)
            {
                CommFunc.LoadMsg(ex.Message);
            }

            tb_Name.Focus();

            
        }
    }
}
