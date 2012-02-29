using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZClient.Func
{
    static class tSysUserState
    {
        static WSMain.MainService MainSrv = new WSMain.MainService();


        internal static void Add(WSMain.eSysUserState Userstate)
        {
            MainSrv.SetUserState(GlobalData.OperatorID, Userstate);
        }
    }
}
