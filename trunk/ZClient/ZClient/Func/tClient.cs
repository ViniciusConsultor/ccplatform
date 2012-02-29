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

            if (string.IsNullOrEmpty(mClient.sClientName))
                throw new ArgumentException("客户名称不能为空！", "名称");

            if (string.IsNullOrEmpty(mClient.sMobiPhone) && string.IsNullOrEmpty(mClient.sMobiPhone))
                throw new ArgumentException("电话不能为空！", "电话");

            CrmSrv.AddClient(mClient, GlobalData.OperatorID);
        }

        internal static List<WSCrm.t_Client> GetUserList()
        {
            return CrmSrv.GetClientList(GlobalData.OperatorID).ToList();
        }

        internal static List<WSCrm.t_Client> GetUserList(string CreatorID)
        {
            return CrmSrv.GetClientListByCreator(GlobalData.OperatorID, CreatorID).ToList();
        }

        internal static WSCrm.t_Client GetModel(string ClientID)
        {
            return CrmSrv.GetClient(ClientID, GlobalData.OperatorID);
        }

        internal static void Update(WSCrm.t_Client mClient)
        {
            CrmSrv.SetClient(mClient, GlobalData.OperatorID);
        }
    }
}
