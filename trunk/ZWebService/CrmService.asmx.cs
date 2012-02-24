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
        public List<t_Client> GetClientListByCreator(string OperatorID,string CreaterID)
        {
            //TODO 检验OPid是否合法
            return Func.tClient.GetList(CreaterID);
        }

        #endregion

        #region Operation
        [WebMethod(Description = "添加业务")]
        public void AddOperation(t_Operation mOperation, string OperatorID)
        {
            Func.tOperation.Add(mOperation, OperatorID);
        }

        [WebMethod(Description = "编辑业务")]
        public void SetOperation(t_Operation mOperation, string OperatorID)
        {
            Func.tOperation.Edit(mOperation, OperatorID);
        }

        [WebMethod(Description = "删除业务")]
        public void DelOperation(t_Operation mOperation, string OperatorID)
        {
            Func.tOperation.Del(mOperation, OperatorID);
        }

        [WebMethod(Description = "获取业务列表")]
        public List<t_Operation> GetOperationListByClientID(string ClientID)
        {
            return Func.tOperation.GetListByClientID(ClientID);
        }

        [WebMethod(Description = "获取业务列表")]
        public List<t_Operation> GetOperationList()
        {
            return Func.tOperation.GetList();
        }

        [WebMethod(Description = "获取业务")]
        public t_Operation GetOperation(string KeyID)
        {
            return Func.tOperation.GetModel(KeyID);
        }

        #endregion

        #region OperationState
        [WebMethod(Description = "添加状态")]
        public void AddOperationState(t_OperationState mState,string OperatorID)
        {
            Func.tOperationState.Add(mState, OperatorID);
        }

        [WebMethod(Description = "删除状态")]
        public void DelOperationState(t_OperationState mState, string OperatorID)
        {
            Func.tOperationState.Del(mState,OperatorID);
        }

        [WebMethod(Description = "编辑状态")]
        public void SetOperationState(t_OperationState mState, string OperatorID)
        {
            Func.tOperationState.Update(mState, OperatorID);
        }
        #endregion

        #region Product
        [WebMethod(Description = "添加产品")]
        public void AddProduct(t_Product mProduct, string OperatorID)
        {
            Func.tProduct.Add(mProduct, OperatorID);
        }

        [WebMethod(Description = "编辑产品")]
        public void SetProduct(t_Product mProduct, string OperatorID)
        {
            Func.tProduct.Update(mProduct, OperatorID);
        }

        [WebMethod(Description = "删除产品")]
        public void DelProduct(t_Product mProduct, string OperatorID)
        {
            Func.tProduct.Del(mProduct, OperatorID);
        }

        [WebMethod(Description = "获取指定产品")]
        public t_Product GetProduct(string KeyID)
        {
            return Func.tProduct.GetModel(KeyID);
        }

        [WebMethod(Description = "获取指定产品")]
        public List<t_Product> GetProductList()
        {
            return Func.tProduct.GetList();
        }

        
        #endregion

        #region t_r_Op
        [WebMethod(Description = "添加订单产品关系")]
        public void AddtrOP(t_r_OperationProduct mOP, string OperatorID)
        {
            Func.trOperationProduct.Add(mOP, OperatorID);
        }

        [WebMethod(Description = "编辑订单产品关系")]
        public void SettrOP(t_r_OperationProduct mOP, string OperatorID)
        {
            Func.trOperationProduct.Update(mOP, OperatorID);
        }

        #endregion
    }
}
