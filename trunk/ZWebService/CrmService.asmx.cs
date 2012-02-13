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
            if (true)
            {
                
            }
        }
        #endregion

    }
}
