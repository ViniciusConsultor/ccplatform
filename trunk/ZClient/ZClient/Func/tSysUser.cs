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
            sPassword = CommonFunc.EncryptTransString(sPassword);
            return MainSrv.ValidUser(sLoginName, sPassword);
        }

        internal static List<WSMain.t_SystemUser> GetList()
        {
            return MainSrv.GetSystemUserList().ToList();
        }

        internal static void DisableUser(string UserID)
        {
            MainSrv.DisableSystemUser(UserID, GlobalData.OperatorID);
        }

        internal static void EnableUser(string UserID)
        {
            MainSrv.EnableSystemUser(UserID, GlobalData.OperatorID);
        }


        internal static void Update(WSMain.t_SystemUser mUser)
        {
            MainSrv.SetSystemUser(mUser, GlobalData.OperatorID);
        }
    }
}
