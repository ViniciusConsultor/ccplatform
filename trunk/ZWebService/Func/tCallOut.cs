using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    public class tCallOut
    {
        static ZSystem.BLL.t_CallList bCallList = new ZSystem.BLL.t_CallList();


        internal static List<t_CallList> GetList()
        {
            return bCallList.GetList();
        }

        internal static void Add(t_CallList mCallOut, string OperatorID)
        {
            if (mCallOut==null)
                return;

            mCallOut.KeyID = "CallOut:" + DateTime.Now.Ticks.ToString();
            mCallOut.CallDate = DateTime.Now;
            bCallList.Add(mCallOut);
        }
    }
}