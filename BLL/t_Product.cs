/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:04
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
    /// ҵ���߼��� t_Product
    /// </summary>
    public class t_Product : BLHelper
    {
        private readonly ZSystem.DAL.t_Product dal = new ZSystem.DAL.t_Product();
      
        public t_Product()
            : base("t_Product_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZSystem.Model.t_Product model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZSystem.Model.t_Product model)
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
        public void Delete(Guid? KeyID)
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
        public bool Exists(Guid? KeyID)
        {
            return dal.Exists(KeyID);
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZSystem.Model.t_Product GetModel(Guid? KeyID)
        {
            ZSystem.Model.t_Product model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(KeyID);
            }
            else
            {
                string key = KeyID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (ZSystem.Model.t_Product)GetModelCache(key);
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
        public List<ZSystem.Model.t_Product> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<ZSystem.Model.t_Product> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    