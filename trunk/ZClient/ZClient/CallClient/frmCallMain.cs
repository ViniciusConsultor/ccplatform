using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient.CallClient
{
    public partial class frmCallMain : Form
    {
        public frmCallMain()
        {
            InitializeComponent();
        }

        #region InitForm
        
        private void frmCallMain_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        private void InitForm()
        {
            BuildState();
        }

        private void BuildState()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add((int)WSMain.eSysUserState.Online, "在线");
            dic.Add((int)WSMain.eSysUserState.Leave, "离开");

            cb_Status.DataSource = dic.ToList();
            cb_Status.ValueMember = "Key";
            cb_Status.DisplayMember = "Value";

            
        }
        #endregion

        #region Component
        private void b_ClientAdd_Click(object sender, EventArgs e)
        {
            Client.frmClientAdd MyClientAdd = new Client.frmClientAdd();
            MyClientAdd.MdiParent = this.Owner;
            MyClientAdd.ShowDialog();
        }

        #endregion

        private void cb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Status.SelectedValue is KeyValuePair<int,string>)
            {
                return;
            }

            WSMain.eSysUserState Userstate = (WSMain.eSysUserState)Enum.Parse(typeof(WSMain.eSysUserState), cb_Status.SelectedValue.ToString());
            if (Userstate != GlobalData.UserState)
            {
                GlobalData.UserState = Userstate;
                Func.tSysUserState.Add(Userstate);
            }    
            
        }
        
    }
}
