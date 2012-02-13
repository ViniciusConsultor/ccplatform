using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoardTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_LoadDrv_Click(object sender, EventArgs e)
        {

            int iResult = DJDBDK.Tc08a32.LoadDRV();

            int iValidCh = DJDBDK.Tc08a32.CheckValidCh();
            List<int> LchType = new List<int>();
            for (int i = 0; i < iValidCh; i++)
            {
                int iType = DJDBDK.Tc08a32.CheckChType(i);
                LchType.Add(iType);
            }
            iResult = DJDBDK.Tc08a32.EnableCard(iValidCh, 1024 * iValidCh);

            DJDBDK.Tc08a32.DisableCard();
            DJDBDK.Tc08a32.FreeDRV();
        }

    }
}
