/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.4.1.0 自动创建于 2012/2/11 15:06:23
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;

namespace ZSystem.BLL
{
    /// <summary>
    /// 业务逻辑类 t_Log
    /// </summary>
    public class t_Log : BLHelper
    {
        private readonly ZSystem.DAL.t_Log dal = new ZSystem.DAL.t_Log();
      
        public t_Log()
            : base("t_Log_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZSystem.Model.t_Log model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
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
        /// 删除一条数据
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ID)
        {
            bool bln = dal.Exists(ID);
            return bln;
        }
      
        /// <summary>
        /// 得到一个对象实体
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
        /// 获得泛型数据列表
        /// </summary>
        public List<ZSystem.Model.t_Log> GetList()
        {
            List<ZSystem.Model.t_Log> lst = dal.GetList();
            return lst;
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<ZSystem.Model.t_Log> GetPageList(PageInfo pi)
        {
            PageList<ZSystem.Model.t_Log> pl = dal.GetPageList(pi);
            return pl;
        }
    }
}
    