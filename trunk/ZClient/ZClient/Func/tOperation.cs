using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZClient.Func
{
    class tOperation
    {
        static WSCrm.CrmService CrmSrv = new WSCrm.CrmService();
        internal static void Add(WSCrm.t_Operation mOperation)
        {
            if (mOperation == null)
                return;



            CrmSrv.AddOperation(mOperation, GlobalData.OperatorID);
        }

        internal static List<WSCrm.t_Operation> GetUserList()
        {
            return CrmSrv.GetOperationList(GlobalData.OperatorID).ToList();
        }


        internal static WSCrm.t_Operation GetModel(string KeyID)
        {
            return CrmSrv.GetOperation(KeyID, GlobalData.OperatorID);
        }

        internal static void Update(WSCrm.t_Operation mOperation)
        {
            CrmSrv.SetOperation(mOperation, GlobalData.OperatorID);
        }
    }
}
