using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tSysuserState
    {
        static ZSystem.BLL.t_SysUserState bSysstate = new ZSystem.BLL.t_SysUserState();
        static public void Add(t_SysUserState mState)
        {
            if (mState==null)
            {
                return;
            }

            mState.KeyID = "State:" + DateTime.Now.Ticks.ToString();
            mState.LastDate = DateTime.Now;
            bSysstate.Add(mState);

            eSysUserState UserState = (eSysUserState)Enum.Parse(typeof(eSysUserState), mState.iState.ToString());

            string sState = string.Empty;
            switch (UserState)
            {
                case eSysUserState.OffLine:
                    sState = "离线";
                    break;
                case eSysUserState.Online:
                    sState = "在线";
                    break;
                case eSysUserState.Leave:
                    sState = "离开";
                    break;
                case eSysUserState.Login:
                    sState = "登录";
                    break;
                case eSysUserState.Logoff:
                    sState = "退出";
                    break;
            }

            string sContent = string.Format("用户“{0}”{1}", tSystemUser.GetModel(mState.UserID).sLoginName, sState);
            tLog.AddLog(sContent, eLogType.信息);
        }

        internal static void Set(string UserID, eSysUserState UserState)
        {
            if (!tSystemUser.IsExistUser(UserID))
                throw new ArgumentException("用户不存在！");


            t_SysUserState mState = new t_SysUserState();
            mState.UserID = UserID;
            mState.iState = (int)UserState;
            Add(mState);
        }

        internal static eSysUserState GetModel(string UserID, string OperatorID)
        {

            t_SysUserState mState = bSysstate.GetModel(UserID);
            if (mState==null)
                return eSysUserState.OffLine;


            eSysUserState Userstate = (eSysUserState)Enum.Parse(typeof(eSysUserState), mState.iState.ToString());
            return Userstate;

        }
    }
}