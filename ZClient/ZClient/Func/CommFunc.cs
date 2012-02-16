using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZClient
{
    static class CommFunc
    {
        static internal void LoadMsg(string sMsg)
        {
            MessageBox.Show(sMsg, "消息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        static internal void LoadMsg(string sMsg,MessageBoxIcon Icon)
        {
            MessageBox.Show(sMsg, "消息", MessageBoxButtons.OK, Icon);
        }
    }
}
