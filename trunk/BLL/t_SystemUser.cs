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
    /// ҵ���߼��� t_SystemUser
    /// </summary>
    public class t_SystemUser : BLHelper
    {
        private readonly ZSystem.DAL.t_SystemUser dal = new ZSystem.DAL.t_SystemUser();
      
        public t_SystemUser()
            : base("t_SystemUser_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZSystem.Model.t_SystemUser model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZSystem.Model.t_SystemUser model)
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
        public bool Exists(string sLoginName)
        {
            return dal.Exists(sLoginName);
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZSystem.Model.t_SystemUser GetModel(string KeyID)
        {
            ZSystem.Model.t_SystemUser model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(KeyID);
            }
            else
            {
                string key = KeyID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (ZSystem.Model.t_SystemUser)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(KeyID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }

        public Model.t_SystemUser GetModel(string sLoginName, string sPassword)
        {
            return dal.GetModel(sLoginName, sPassword);
        }

        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<ZSystem.Model.t_SystemUser> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<ZSystem.Model.t_SystemUser> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }

        
    }
}
    