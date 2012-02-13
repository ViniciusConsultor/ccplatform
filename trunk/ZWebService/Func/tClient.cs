using System;
using System.Collections.Generic;
using System.Linq;
using ZSystem.Model;

namespace ZWebService.Func
{
    public class tClient
    {
        static ZSystem.BLL.t_Client bClient = new ZSystem.BLL.t_Client();
        static internal void Add(t_Client mClient, string OperatorID)
        {
            //if (!ValidUser(OperaterID))
            //{
                
            //}
            if (mClient==null)
                return;

            mClient.CreateUserID = OperatorID;
            mClient.LastUpdate = DateTime.Now;
            mClient.KeyID = "Client:" + DateTime.Now.Ticks.ToString();
            bClient.Add(mClient);

            string sName = Func.tSystemUser.GetName(OperatorID);
            Func.tLog.AddLog(string.Format("用户『0』添加了客户『1』", sName, mClient.sClientName), eLogType.信息);
        }

        static internal void Edit(t_Client mClient, string OperatorID)
        {
            mClient.LastUpdate = DateTime.Now;

            bClient.Update(mClient);

            string sSYSName = Func.tSystemUser.GetName(OperatorID);
            Func.tLog.AddLog(string.Format("用户『0』更新了客户『1』的资料", sSYSName, mClient.sClientName), eLogType.信息);
        }

        static internal void Del(t_Client mClient, string OperatorID)
        {
            mClient.IsEnable = false;
            mClient.LastUpdate = DateTime.Now;

            string sName = Func.tSystemUser.GetName(OperatorID);
            Func.tLog.AddLog(string.Format("用户『0』删除了客户『1』的资料", sName, mClient.sClientName), eLogType.信息);
        }

        static internal List<t_Client> GetList()
        {
            return bClient.GetList();
        }

        static internal List<t_Client> GetList(string sCreaterID)
        {
            if (string.IsNullOrEmpty(sCreaterID))
                return null;

            return bClient.GetList().Where(n => n.CreateUserID == sCreaterID).ToList();

        }

    }
}