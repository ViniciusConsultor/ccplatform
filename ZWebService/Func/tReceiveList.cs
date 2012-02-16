using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    public class tReceiveList
    {
        static ZSystem.BLL.t_ReceiveList bReceiveList = new ZSystem.BLL.t_ReceiveList();


        internal static List<t_ReceiveList> GetList()
        {
            return bReceiveList.GetList();
        }

        internal static void Update(t_ReceiveList mCallIn, string OperatorID)
        {
            if (mCallIn==null)
                return;

            bReceiveList.Update(mCallIn);
        }
    }
}