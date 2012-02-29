/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.4.1.0 �Զ������� 2012/2/11 15:06:23
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
    /// ҵ���߼��� t_Log
    /// </summary>
    public class t_Log : BLHelper
    {
        private readonly ZSystem.DAL.t_Log dal = new ZSystem.DAL.t_Log();
      
        public t_Log()
            : base("t_Log_")
        { }
      
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZSystem.Model.t_Log model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZSystem.Model.t_Log model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.ID);
            }
        }
      
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(string ID)
        {
            int count = dal.Delete(ID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(ID.ToString());
            }
        }      
      
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(string ID)
        {
            bool bln = dal.Exists(ID);
            return bln;
        }
      
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZSystem.Model.t_Log GetModel(string ID)
        {
            ZSystem.Model.t_Log model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(ID);
            }
            else
            {
                string key = ID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (ZSystem.Model.t_Log)GetModelCache(key);
                }
                else
                {
                    model = dal.GetModel(ID);
                    TryAddModelCache(key, model, null, Cache.NoAbsoluteExpiration, Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Normal, null);
                }
            }
            return model;
        }
        
        /// <summary>
        /// ��÷��������б�
        /// </summary>
        public List<ZSystem.Model.t_Log> GetList()
        {
            List<ZSystem.Model.t_Log> lst = dal.GetList();
            return lst;
        }
      
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<ZSystem.Model.t_Log> GetPageList(PageInfo pi)
        {
            PageList<ZSystem.Model.t_Log> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    