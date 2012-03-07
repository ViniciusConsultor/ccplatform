using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ZClient
{
    static class CommonFunc
    {
        internal static string DecryptTransString(string sValue)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.DecryptKey = DateTime.Now.ToString("yyyy-MM-dd");
            Mydes.InputString = sValue;
            Mydes.DesDecrypt();

            return Mydes.OutString;
        }

        internal static string EncryptTransString(string sValue)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.EncryptKey = DateTime.Now.ToString("yyyy-MM-dd");
            Mydes.InputString = sValue;
            Mydes.DesEncrypt();

            return Mydes.OutString;
        }

        static internal void LoadMsg(string sMsg)
        {
            MessageBox.Show(sMsg, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static internal void LoadMsg(string sMsg,MessageBoxIcon Icon)
        {
            MessageBox.Show(sMsg, "消息", MessageBoxButtons.OK, Icon);
        }

        internal static bool ValidUser(CommonEnum.eUserAuth userauth)
        {
            if ((int)userauth>=(int)GlobalData.UserAuth)
                return true;

            return false;
        }

        internal static void FormatDGVWithBg(DataGridView dGV)
        {
            // Set property values appropriate for read-only display and 
            // limited interactivity. 
            dGV.AllowUserToAddRows = false;
            dGV.AllowUserToDeleteRows = false;
            dGV.AllowUserToOrderColumns = false;
            dGV.ReadOnly = true;
            dGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dGV.MultiSelect = true;
            dGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dGV.AllowUserToResizeColumns = true;
            dGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dGV.AllowUserToResizeRows = false;
            dGV.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dGV.BackgroundColor = Color.LightCyan;
            dGV.EnableHeadersVisualStyles = false;

            // Set the selection background color for all the cells.
            dGV.DefaultCellStyle.SelectionBackColor = Color.White; // Color.LightGray;
            dGV.DefaultCellStyle.SelectionForeColor = Color.Black;
            dGV.DefaultCellStyle.Font = new Font("微软雅黑", 12, FontStyle.Regular);
            dGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;

            // Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
            // value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
            dGV.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty;
            dGV.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            dGV.RowHeadersWidth = 50;
            //dGV.RowHeadersVisible = true;
            dGV.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(0x85, 0xDC, 0xEF);
            //dGV.RowHeadersDefaultCellStyle.BackColor = Color.Black;

            // Set the background color for all rows and for alternating rows. 
            // The value for alternating rows overrides the value for all rows. 
            dGV.RowsDefaultCellStyle.BackColor = Color.FromArgb(0x57, 0xC3, 0xE9); //.FromName("#85DCEF");
            dGV.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0x85, 0xDC, 0xEF);//.FromName("#57C3E9");

            // Set the row and column header styles.
            dGV.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0x85, 0xDC, 0xEF);
            dGV.ColumnHeadersHeight = 55;
            dGV.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Set the Format property on the "Last Prepared" column to cause
            // the DateTime to be formatted as "Month, Year".
            //dGV.Columns("Last Prepared").DefaultCellStyle.Format = "y";
        }
    }
}
