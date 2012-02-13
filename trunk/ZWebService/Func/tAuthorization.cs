using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tAuthorization
    {
        static ZSystem.BLL.t_Authorization bAuth = new ZSystem.BLL.t_Authorization();
        static public List<t_Authorization> GetUserAuth(string UserID)
        {
            return bAuth.GetList(UserID);
        }

        internal static bool IsValidUser(string OperateUserID)
        {
            //TODO:先验证用户是否已登录
            //验证有无权限


            List<t_Authorization> Lauth = GetUserAuth(OperateUserID);
            //检验是否有管理员权限
            Lauth = Lauth.Where(n => n.iUserLevel <= 10).ToList();
            if (Lauth==null||Lauth.Count==0)
                return false;

            return true;

        }

        internal static void Add(t_Authorization mAuth, string OperateUserID)
        {
            bAuth.Add(mAuth);

            //TODO:日志记录
        }

        internal static void Del(t_Authorization mAuth)
        {
            bAuth.Delete(mAuth.UserID, mAuth.iUserLevel);

            //Todo:LOG
        }
    }
}