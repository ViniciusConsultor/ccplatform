using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tIVRControl
    {
        static ZSystem.BLL.t_IVRControl bIVR = new ZSystem.BLL.t_IVRControl();

        internal static void Add(t_IVRControl mIVR, string OperatorID)
        {
            if (mIVR==null)
                return;

            mIVR.KeyID = "IVR:" + DateTime.Now.Ticks.ToString();
            mIVR.LastUpdate = DateTime.Now;
            
            bIVR.Add(mIVR);
        }

        internal static void Update(t_IVRControl mIVR, string OperatorID)
        {
            if (mIVR==null)
                return;

            bIVR.Update(mIVR);
        }

        internal static t_IVRControl GetModel(string KeyID)
        {
            return bIVR.GetModel(KeyID);
        }

        internal static List<t_IVRControl> GetList()
        {
            return bIVR.GetList();
        }
    }
}