using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    public class tOperation
    {
        static ZSystem.BLL.t_Operation bOperation = new ZSystem.BLL.t_Operation();
        internal static void Add(t_Operation mOperation, string OperatorID)
        {
            if (mOperation==null)
                return;

            mOperation.CreateUser = OperatorID;
            mOperation.LastUpdate = DateTime.Now;
            mOperation.IsEnable = true;
            mOperation.KeyID = "OP:" + DateTime.Now.Ticks.ToString();

            bOperation.Add(mOperation);
            string sName = Func.tSystemUser.GetName(OperatorID);
            Func.tLog.AddLog(string.Format("『0』创建了一笔订单『1』", sName, mOperation.KeyID), eLogType.信息);

        }

        static internal void Edit(t_Operation mOperation, string OperatorID)
        {
            if (mOperation==null)
                return;

            mOperation.LastUpdate = DateTime.Now;
            bOperation.Update(mOperation);

            string sName = Func.tSystemUser.GetName(OperatorID);
            Func.tLog.AddLog(string.Format("『0』修改了一笔订单", sName, mOperation.KeyID), eLogType.信息);

        }

        static internal void Del(t_Operation mOperation, string OperatorID)
        {
            if (mOperation == null)
                return;

            mOperation.LastUpdate = DateTime.Now;
            mOperation.IsEnable = false;
            bOperation.Update(mOperation);

            string sName = Func.tSystemUser.GetName(OperatorID);
            Func.tLog.AddLog(string.Format("『0』删除了一笔订单", sName, mOperation.KeyID), eLogType.信息);
        }



        internal static List<t_Operation> GetList()
        {
            return bOperation.GetList();
        }

        internal static List<t_Operation> GetListByClientID(string ClientID)
        {
            return GetList().Where(n => n.ClientID == ClientID).ToList();
        }

        internal static t_Operation GetModel(string KeyID)
        {
            return bOperation.GetModel(KeyID);
        }
    }
}