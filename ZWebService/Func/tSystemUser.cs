using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;


namespace ZWebService.Func
{
    public class tSystemUser
    {
        static ZSystem.BLL.t_SystemUser bSystemUser = new ZSystem.BLL.t_SystemUser();
        internal static List<t_SystemUser> GetList()
        {
            return bSystemUser.GetList();
        }

        internal static t_SystemUser GetModel(string sKeyID)
        {
            return bSystemUser.GetModel(sKeyID);
        }

        internal static void AddUser(t_SystemUser mSystemUser)
        {
            if (mSystemUser == null)
                throw new ArgumentException("参数不能为空！");

            if (IsExist(mSystemUser.sLoginName))
                throw new ArgumentException("用户已存在！");

            mSystemUser.KeyID = "SYSUser" + DateTime.Now.Ticks.ToString();
            mSystemUser.sPassword = CommFunc.EncryptStorageSring(mSystemUser.sLoginName, mSystemUser.sPassword);
            mSystemUser.LastUpdate = DateTime.Now;
            bSystemUser.Add(mSystemUser);
        }

        private static bool IsExist(string sLoginName)
        {
            return bSystemUser.Exists(sLoginName);
        }

        /// <summary>
        /// 检查用户操作权限
        /// </summary>
        /// <param name="sUserID"></param>
        /// <returns></returns>
        internal static bool IsAuthUser(string sUserID)
        {
            List<t_Authorization> Lauth = Func.tAuthorization.GetUserAuth(sUserID);
            if (Lauth.Count==0)
                return false;

            Lauth = Lauth.Where(n => n.iUserLevel <= (int)eUserAuth.Admin).ToList();
            if (Lauth.Count>0)
                return true;

            return false;

        }

        /// <summary>
        /// 验证用户密码 (用日期作为传送加密，用loginName作为存储加密）
        /// </summary>
        /// <param name="sLoginName"></param>
        /// <param name="sPassword"></param>
        /// <returns></returns>
        internal static string ValidUser(string sLoginName, string sPassword)
        {

            sPassword = CommFunc.DecryptTransString(sPassword);
            if (string.IsNullOrEmpty(sPassword))
                return string.Empty;

            sPassword = CommFunc.EncryptStorageSring(sLoginName, sPassword);
            t_SystemUser mSysUser = bSystemUser.GetModel(sLoginName, sPassword);
            if (mSysUser == null)
                return string.Empty;

            if (!mSysUser.IsEnable)
                return string.Empty;

            t_SysUserState mState = new t_SysUserState();
            mState.UserID = mSysUser.KeyID;
            mState.iState = (int)eSysUserState.Login;
            tSysuserState.Add(mState);//变更用户状态

            return mSysUser.KeyID;
        }


        /// <summary>
        /// 检查用户是否存在
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
        internal static bool IsExistUser(string UserID)
        {
             t_SystemUser mUser= bSystemUser.GetModel(UserID);
             return mUser != null;
            
        }

        internal static string GetName(string OperatorID)
        {
            t_SystemUser mUser = bSystemUser.GetModel(OperatorID);
            if (mUser==null)
                return string.Empty;

            return mUser.sLoginName;
        }
    }
}