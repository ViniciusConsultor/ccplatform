using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class trOperationProduct
    {
        static ZSystem.BLL.t_r_OperationProduct bOP = new ZSystem.BLL.t_r_OperationProduct();

        internal static void Add(t_r_OperationProduct mOP, string OperatorID)
        {
            if (mOP==null)
            {
                return;
            }
            mOP.OperationID = OperatorID;
            mOP.KeyID = "trOP:" + DateTime.Now.Ticks.ToString();

            bOP.Add(mOP);
        }


        internal static void Update(t_r_OperationProduct mOP, string OperatorID)
        {
            if (mOP == null)
            {
                return;
            }

            bOP.Update(mOP);
        }
    }
}