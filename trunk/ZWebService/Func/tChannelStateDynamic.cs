using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    public class tChannelStateDynamic
    {
        static ZSystem.BLL.t_ChannelStateDynamic bDynamic = new ZSystem.BLL.t_ChannelStateDynamic();

        internal static List<t_ChannelStateDynamic> GetList()
        {
            return bDynamic.GetList();
        }
    }
}