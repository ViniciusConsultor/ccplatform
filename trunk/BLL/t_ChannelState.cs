/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:03
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace ZSystem.BLL
{
    /// <summary>
    /// ҵ���߼��� t_ChannelState
    /// </summary>
    public class t_ChannelState : BLHelper
    {
        private readonly ZSystem.DAL.t_ChannelState dal = new ZSystem.DAL.t_ChannelState();
      
        public t_ChannelState()
            : base("t_ChannelState_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZSystem.Model.t_ChannelState model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZSystem.Model.t_ChannelState model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.iChID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int? iChID)
        {
            int count = dal.Delete(iChID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(iChID.ToString());
            }
        }      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? iChID)
        {
            return dal.Exists(iChID);
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZSystem.Model.t_ChannelState GetModel(int? iChID)
        {
            ZSystem.Model.t_ChannelState model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(iChID);
            }
            else
            {
                string key = iChID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (ZSystem.Model.t_ChannelState)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(iChID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<ZSystem.Model.t_ChannelState> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<ZSystem.Model.t_ChannelState> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    