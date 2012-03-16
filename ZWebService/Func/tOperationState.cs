using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    static public class tOperationState
    {
        static ZSystem.BLL.t_OperationState bState = new ZSystem.BLL.t_OperationState();
        internal static void Add(t_OperationState mState, string OperatorID)
        {
            string sName = Func.tSystemUser.GetName(OperatorID);
            if (string.IsNullOrEmpty(sName))
                return;

            //todo:验证权限
            bState.Add(mState);
            Func.tLog.AddLog(string.Format("『0』添加了业务状态『1』", sName, mState.sStatusName), eLogType.信息);
        }

        internal static void Del(t_OperationState mState, string OperatorID)
        {

            mState.iIndex = 0 - mState.iIndex;
            bState.Update(mState);
        }

        internal static void Update(t_OperationState mState, string OperatorID)
        {
            bState.Update(mState);
        }

        internal static List<t_OperationState> GetList(string OperatorID)
        {
            return bState.GetList();
        }
    }
}