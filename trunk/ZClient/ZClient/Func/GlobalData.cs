using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZClient
{
    static class GlobalData
    {
        static private string _OperatorID = string.Empty;

        public static string OperatorID
        {
            get { return GlobalData._OperatorID; }
            set { GlobalData._OperatorID = value; }
        }
    }
}
