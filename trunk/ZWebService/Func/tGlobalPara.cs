using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tGlobalPara
    {
        static ZSystem.BLL.t_GlobalPara bGlobal = new ZSystem.BLL.t_GlobalPara();
        static internal bool IsValidUser(string UserID)
        {
            if (string.IsNullOrEmpty(UserID))
                return false;

            List<t_Authorization> LAuth = tAuthorization.GetUserAuth(UserID);
            if (LAuth.Count==0)
                return false;

            LAuth = LAuth.Where(n => n.iUserLevel <= (int)eUserAuth.Admin).ToList();
            if (LAuth.Count>0)
                return true;

            return false;
        }

        internal static void Update(t_GlobalPara mGlobal)
        {
            bGlobal.Update(mGlobal);
        }

        internal static string GetValue(int iKey)
        {
            t_GlobalPara mGlobal = bGlobal.GetModel(iKey);
            if (mGlobal==null)
            {
                throw new ArgumentException("无效参数！");
            }

            return mGlobal.sValue;
        }
    }
}