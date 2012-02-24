using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ZClient.Func
{
    static class tClient
    {

        static WSCrm.CrmService CrmSrv = new WSCrm.CrmService();
        internal static void Add(WSCrm.t_Client mClient)
        {
            if (mClient==null)
                return;

            CrmSrv.AddClient(mClient, GlobalData.OperatorID);
        }
    }
}
