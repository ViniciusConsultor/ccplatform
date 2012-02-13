/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-09 09:07:03
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
    /// 业务逻辑类 t_GlobalPara
    /// </summary>
    public class t_GlobalPara : BLHelper
    {
        private readonly ZSystem.DAL.t_GlobalPara dal = new ZSystem.DAL.t_GlobalPara();
      
        public t_GlobalPara()
            : base("t_GlobalPara_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZSystem.Model.t_GlobalPara model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZSystem.Model.t_GlobalPara model)
        {
            int count = dal.Update(model);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(model.KeyID);
            }
        }
      
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int? KeyID)
        {
            int count = dal.Delete(KeyID);
            if (EnableCache && count > 0)
            {
                RemoveModelCache(KeyID.ToString());
            }
        }      
      
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? KeyID)
        {
            return dal.Exists(KeyID);
        }
      
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ZSystem.Model.t_GlobalPara GetModel(int? KeyID)
        {
            ZSystem.Model.t_GlobalPara model = null;
            if (!EnableCache)
            {
                model = dal.GetModel(KeyID);
            }
            else
            {
                string key = KeyID.ToString();
                if (GetModelCache(key) != null)
                {
                    model = (ZSystem.Model.t_GlobalPara)GetModelCache(key);
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
        /// 获得泛型数据列表
        /// </summary>
        public List<ZSystem.Model.t_GlobalPara> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<ZSystem.Model.t_GlobalPara> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    