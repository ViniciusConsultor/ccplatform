using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using ZSystem.Model;

namespace ZWebService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://Zsystem.Info/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class MainService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetServerVersion()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        #region Global
        [WebMethod(Description="设置全局参数")]
        public void SetGlobalPara(ZSystem.Model.t_GlobalPara mGlobal,string UserID)
        {
            if (mGlobal==null||string.IsNullOrEmpty(UserID) )
            {
                throw new ArgumentException("参数无效！");
            }

            if (!Func.tGlobalPara.IsValidUser(UserID))
                throw new UnauthorizedAccessException("用户权限不足");

            Func.tGlobalPara.Update(mGlobal);
           
        }

        [WebMethod(Description = "获取全局参数")]
        public string GetGlobalPara(int iKeyID)
        {
            return Func.tGlobalPara.GetValue(iKeyID);
        }
        #endregion

        #region SystemUser
        [WebMethod(Description = "获取用户列表")]
        public List<ZSystem.Model.t_SystemUser> GetSystemUserList()
        {
            return Func.tSystemUser.GetList();
        }

        [WebMethod(Description = "获取指定用户")]
        public ZSystem.Model.t_SystemUser GetSystemUser(string sKeyID)
        {
            return Func.tSystemUser.GetModel(sKeyID);
        }

        [WebMethod(Description = "添加新用户")]
        public void AddSystemUser(t_SystemUser mSystemUser,string sUserID)
        {
            if (!Func.tSystemUser.IsAuthUser(sUserID))
                throw new ArgumentException("用户权限不足！");

            Func.tSystemUser.AddUser(mSystemUser);
        }

        [WebMethod(Description = "禁用用户")]
        public void AddSystemUser(string sUserID,string OperatorID)
        {
            Func.tSystemUser.EnableUser(sUserID, OperatorID, false);
        }

        [WebMethod(Description = "启用用户")]
        public void AddSystemUser(string sUserID, string OperatorID)
        {
            Func.tSystemUser.EnableUser(sUserID, OperatorID, true);
        }

        [WebMethod(Description = "更新用户信息")]
        public void SetSystemUser(t_SystemUser mUser, string OperatorID)
        {
            Func.tSystemUser.Update(mUser, OperatorID);
        }



        /// <summary>
        /// 验证用户是否存在
        /// </summary>
        /// <param name="sLoginName"></param>
        /// <param name="sPassword"></param>
        /// <returns>返回用户KEYID</returns>
        [WebMethod(Description = "验证用户")]
        public string ValidUser(string sLoginName, string sPassword)
        {
            if (string.IsNullOrEmpty(sLoginName)||string.IsNullOrEmpty(sPassword))
                return null;

            return Func.tSystemUser.ValidUser(sLoginName, sPassword);
        }

        #endregion

        #region Auth
        [WebMethod(Description="获取用户权限")]
        public List<t_Authorization>GetUserAuthList(string UserID)
        {
            return Func.tAuthorization.GetUserAuth(UserID);
        }

        [WebMethod(Description = "设置用户权限")]
        public void SetUserAuth(string OperateUserID, t_Authorization mAuth)
        {
            if (!Func.tAuthorization.IsValidUser(OperateUserID))
                throw new ArgumentException("用户权限不足！");

            Func.tAuthorization.Add(mAuth, OperateUserID);
        }

        [WebMethod(Description = "撤销用户权限")]
        public void DelUserAuth(string OperateUserID, t_Authorization mAuth)
        {
            if (!Func.tAuthorization.IsValidUser(OperateUserID))
                throw new ArgumentException("用户权限不足！");

            Func.tAuthorization.Del(mAuth);
        }

        #endregion

        #region SysUserState
        [WebMethod(Description = "变更用户状态")]
        public void SetUserState(string UserID,eSysUserState UserState)
        {
            switch (UserState)
            {
                case eSysUserState.Login:
                    throw new ArgumentException("操作非法！");
                    break;
            }

            Func.tSysuserState.Set(UserID, UserState);
        }

        [WebMethod(Description = "获取用户最后状态")]
        public eSysUserState GetUserState(string UserID,string OperatorID)
        {
            return Func.tSysuserState.GetModel(UserID, OperatorID);
        }

        #endregion

    }
}