/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.4.1.0 �Զ������� 2012/2/11 15:11:27
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
    /// ҵ���߼��� t_SysUserState
    /// </summary>
    public class t_SysUserState : BLHelper
    {
        private readonly ZSystem.DAL.t_SysUserState dal = new ZSystem.DAL.t_SysUserState();
      
        public t_SysUserState()
            : base("t_SysUserState_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZSystem.Model.t_SysUserState model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZSystem.Model.t_SysUserState model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.KeyID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(string KeyID)
        {
            int count = dal.Delete(KeyID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(KeyID.ToString());
            }
        }      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(string KeyID)
        {
            bool bln = dal.Exists(KeyID);
            return bln;
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZSystem.Model.t_SysUserState GetModel(string KeyID)
        {
            ZSystem.Model.t_SysUserState model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(KeyID);
            }
            else
            {
                string key = KeyID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (ZSystem.Model.t_SysUserState)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(KeyID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<ZSystem.Model.t_SysUserState> GetList()
        {
            List<ZSystem.Model.t_SysUserState> lst = dal.GetList();
            return lst;
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<ZSystem.Model.t_SysUserState> GetPageList(PageInfo pi)
        {
            PageList<ZSystem.Model.t_SysUserState> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    