using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ZSystem.Model;

namespace ZWebService
{
    /// <summary>
    /// Summary description for CCService
    /// </summary>
    [WebService(Namespace = "http://Zsystem.Info/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CCService : System.Web.Services.WebService
    {

        #region IVR
        [WebMethod(Description="添加IVR")]
        public void AddIVR(t_IVRControl mIVR,string OperatorID)
        {
            Func.tIVRControl.Add(mIVR, OperatorID);
        }

        [WebMethod(Description = "编辑IVR")]
        public void SetIVR(t_IVRControl mIVR, string OperatorID)
        {
            Func.tIVRControl.Update(mIVR, OperatorID);
        }

        [WebMethod(Description = "编辑IVR")]
        public t_IVRControl GetIVR(string KeyID)
        {
            return Func.tIVRControl.GetModel(KeyID);
        }

        [WebMethod(Description = "获取IVR清单")]
        public List<t_IVRControl> GetIVRList()
        {
            return Func.tIVRControl.GetList();
        }

        #endregion

        #region CHState

        [WebMethod(Description = "获取CH_STATE清单")]
        public List<t_ChannelStateStatic> GetCHStateStaticList()
        {
            return Func.tChannelStateStatic.GetList();
        }

        [WebMethod(Description = "更新CH_STATE")]
        public void SetCHStateStatic(t_ChannelStateStatic mChState)
        {
            Func.tChannelStateStatic.Update(mChState);
        }

        #endregion

        #region CHDynamic
        [WebMethod(Description = "获取CH_Dynamic清单")]
        public List<t_ChannelStateDynamic> GetCHStateDynamicList()
        {
            return Func.tChannelStateDynamic.GetList();
        }
        #endregion

        #region 呼入
        [WebMethod(Description = "获取呼入清单")]
        public List<t_ReceiveList> GetCallInList()
        {
            return Func.tReceiveList.GetList();
        }

        [WebMethod(Description = "更新呼入")]
        public void SetCallIn(t_ReceiveList mCallIn, string OperatorID)
        {
            Func.tReceiveList.Update(mCallIn, OperatorID);
        }
        #endregion

        #region 呼出
        [WebMethod(Description = "获取呼出清单")]
        public List<t_CallList> GetCallOutList()
        {
            return Func.tCallOut.GetList();
        }

        [WebMethod(Description = "添加呼出")]
        public void AddCallOut(t_CallList mCallOut,string OperatorID)
        {
            Func.tCallOut.Add(mCallOut, OperatorID);
        }

        #endregion
    }
}
