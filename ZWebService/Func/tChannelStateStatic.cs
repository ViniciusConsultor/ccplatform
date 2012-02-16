using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    public class tChannelStateStatic
    {
        static ZSystem.BLL.t_ChannelStateStatic bState = new ZSystem.BLL.t_ChannelStateStatic();

        internal static List<t_ChannelStateStatic> GetList()
        {
            return bState.GetList();
        }

        internal static t_ChannelStateStatic GetModel(int iChID)
        {
            return bState.GetModel(iChID);
        }

        internal static void Update(t_ChannelStateStatic mChState)
        {
            if (bState==null)
                return;

            bState.Update(mChState);
        }
    }
}