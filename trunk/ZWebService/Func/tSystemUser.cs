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

            VerfyUser(mSystemUser);
            mSystemUser.sLoginName = mSystemUser.sLoginName.ToLower();

            if (IsExist(mSystemUser.sLoginName))
                throw new ArgumentException("用户已存在！");

            mSystemUser.KeyID = "SYSUser:" + DateTime.Now.Ticks.ToString();
            mSystemUser.sPassword = CommFunc.EncryptStorageSring(mSystemUser.sLoginName, mSystemUser.sPassword);
            mSystemUser.LastUpdate = DateTime.Now;
            mSystemUser.IsEnable = true;

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
            sLoginName = sLoginName.ToLower();
            sPassword = CommFunc.DecryptTransString(sPassword);
            if (string.IsNullOrEmpty(sPassword))
            {
                Func.tLog.AddLog("密码传输解密无效！" + DateTime.Now.ToShortDateString(), eLogType.警告);
                return string.Empty;
            }

            sPassword = CommFunc.EncryptStorageSring(sLoginName, sPassword);
            t_SystemUser mSysUser = bSystemUser.GetModel(sLoginName, sPassword);
            if (mSysUser == null)
            {
                
                return string.Empty;
            }

            if (!mSysUser.IsEnable)
            {
                Func.tLog.AddLog(mSysUser.sLoginName + "未启用！", eLogType.警告);
                return string.Empty;
            }

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

        internal static void EnableUser(string sUserID, string OperatorID,bool IsEnable)
        {
            if (!IsAuthUser(OperatorID))
                throw new ArgumentException("用户权限不足！");

            t_SystemUser mUser = bSystemUser.GetModel(sUserID);
            if (mUser==null)
                return;

            if (mUser.sLoginName.Equals("admin"))
                throw new ArgumentException("Admin账户不能被禁用！");

            mUser.IsEnable = IsEnable;
            mUser.LastUpdate = DateTime.Now;

            bSystemUser.Update(mUser);

            Func.tLog.AddLog(string.Format("用户『{0}』被{1}", mUser.sLoginName, IsEnable ? "启用" : "禁用"), eLogType.信息);
            
        }

        internal static void Update(t_SystemUser mUser, string OperatorID)
        {
            if (!IsAuthUser(OperatorID))
                throw new ArgumentException("用户权限不足！");

            bool IsChangePassword = true;
            if (string.IsNullOrEmpty(mUser.sPassword))
            {
                IsChangePassword = false;
                mUser.sPassword = "-1";
            }

            VerfyUser(mUser);

            t_SystemUser mOld = bSystemUser.GetModel(mUser.KeyID);
            mUser.sLoginName = mUser.sLoginName.ToLower();//登录名转换为小写
            
            if (mOld.sLoginName!=mUser.sLoginName)
            {
                if (mUser.sLoginName.Equals("admin"))
                    throw new ArgumentException("不能修改admin账户登录名称！");
                if (IsExist(mUser.sLoginName))
                    throw new ArgumentException("登录名已存在！");
                mOld.sLoginName = mUser.sLoginName;
            }

            mOld.sUserName = mUser.sUserName;
            if (IsChangePassword)
            {
                mOld.sPassword = CommFunc.DecryptTransString(mUser.sPassword);
                mOld.sPassword = CommFunc.EncryptStorageSring(mOld.sLoginName, mOld.sPassword);    
            }
            mOld.LastUpdate = DateTime.Now;

            bSystemUser.Update(mOld);
            
        }

        /// <summary>
        /// 验证USER是否合法
        /// </summary>
        /// <param name="mUser"></param>
        private static void VerfyUser(t_SystemUser mUser)
        {
            if (string.IsNullOrEmpty(mUser.sLoginName))
                throw new ArgumentException("登录名不能为空！");

            if (string.IsNullOrEmpty(mUser.sUserName))
                throw new ArgumentException("用户名不能为空！");

            if (string.IsNullOrEmpty(mUser.sPassword))
                throw new ArgumentException("密码不能为空！");

        }
    }
}