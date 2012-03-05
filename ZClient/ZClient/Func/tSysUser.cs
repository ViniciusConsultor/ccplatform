using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZClient.Func
{
    static class tSysUser
    {
        static WSMain.MainService MainSrv = new WSMain.MainService();
        internal static void Add(WSMain.t_SystemUser mUser)
        {
            MainSrv.AddSystemUser(mUser, GlobalData.OperatorID);
        }

        internal static string ValidateUser(string sLoginName, string sPassword)
        {
            DESEncryptor Mydes = new DESEncryptor();
            Mydes.EncryptKey = DateTime.Now.ToString("yyyy-MM-dd");
            Mydes.InputString = sPassword;
            Mydes.DesEncrypt();

            sPassword = Mydes.OutString;
            return MainSrv.ValidUser(sLoginName, sPassword);
        }
    }
}
