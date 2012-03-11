using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZClient.Func
{
    class tProduct
    {
        static WSCrm.CrmService CrmSrv = new WSCrm.CrmService();
        internal static void Add(WSCrm.t_Product mProduct)
        {
            if (mProduct == null)
                return;

            CrmSrv.AddProduct(mProduct, GlobalData.OperatorID);
        }

        internal static List<WSCrm.t_Product> GetList()
        {
            return CrmSrv.GetProductList(GlobalData.OperatorID).ToList();
        }


        internal static WSCrm.t_Product GetModel(string KeyID)
        {
            return CrmSrv.GetProduct(KeyID, GlobalData.OperatorID);
        }

        internal static void Update(WSCrm.t_Product mProduct)
        {
            CrmSrv.SetProduct(mProduct, GlobalData.OperatorID);
        }

        internal static void Del(WSCrm.t_Product mProduct)
        {
            CrmSrv.DelProduct(mProduct, GlobalData.OperatorID);
        }
    }
}
