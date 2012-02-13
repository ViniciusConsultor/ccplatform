using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ZSystem.Model;

namespace ZWebService
{
    /// <summary>
    /// CrmService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://Zsystem.Info/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消对下行的注释。
    // [System.Web.Script.Services.ScriptService]
    public class CrmService : System.Web.Services.WebService
    {
        #region Client
        [WebMethod(Description = "添加新的客户资料")]
        public void AddClient(t_Client mClient, string OperatorID)
        {
            if (mClient==null)
                return;

            Func.tClient.Add(mClient, OperatorID);
        }

        [WebMethod(Description = "更新客户资料")]
        public void SetClient(t_Client mClient, string OperatorID)
        {
            if (mClient == null)
                return;

            Func.tClient.Edit(mClient, OperatorID);
        }

        [WebMethod(Description = ("删除客户"))]
        public void DelClient(t_Client mClient, string OperatorID)
        {
            if (mClient==null)
                return;

            Func.tClient.Del(mClient, OperatorID);
        }

        [WebMethod(Description = ("获取客户列表"))]
        public List<t_Client> GetClientList(string OperatorID)
        {
            //TODO 检验OPid是否合法
            return Func.tClient.GetList();
        }

        [WebMethod(Description = ("指定创建人客户列表"))]
        public List<t_Client> GetClientList(string OperatorID,string CreaterID)
        {
            //TODO 检验OPid是否合法
            return Func.tClient.GetList(CreaterID);
        }

        #endregion

    }
}
