using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZClient
{
    static class GlobalData
    {
        static private string _OperatorID = string.Empty;
        static private CommonEnum.eUserAuth _UserAuth = CommonEnum.eUserAuth.Admin;

        internal static CommonEnum.eUserAuth UserAuth
        {
            get { return GlobalData._UserAuth; }
        }

        public static string OperatorID
        {
            get { return GlobalData._OperatorID; }
            set { GlobalData._OperatorID = value; }
        }

    }
}
