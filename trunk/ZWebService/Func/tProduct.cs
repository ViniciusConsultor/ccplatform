using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tProduct
    {
        static ZSystem.BLL.t_Product bProduct = new ZSystem.BLL.t_Product();

        internal static void Add(t_Product mProduct, string OperatorID)
        {
            if (mProduct==null)
                return;

            mProduct.KeyID = Guid.NewGuid();
            mProduct.LastUpdate = DateTime.Now;
            
            bProduct.Add(mProduct);

            //todo: 增加LOG
        }

        internal static void Update(t_Product mProduct, string OperatorID)
        {
            if (mProduct==null)
                return;

            bProduct.Update(mProduct);
        }

        internal static void Del(t_Product mProduct, string OperatorID)
        {
            if (mProduct==null)
            {
                return;
            }
            mProduct.IsEnable = false;

            bProduct.Update(mProduct);
        }

        internal static t_Product GetModel(string KeyID)
        {
            Guid gukey = new Guid(KeyID);
            return bProduct.GetModel(gukey);
        }

        internal static List<t_Product> GetList()
        {
            return bProduct.GetList();
        }
    }
}