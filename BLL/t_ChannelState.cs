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
    /// 业务逻辑类 t_ChannelState
    /// </summary>
    public class t_ChannelState : BLHelper
    {
        private readonly ZSystem.DAL.t_ChannelState dal = new ZSystem.DAL.t_ChannelState();
      
        public t_ChannelState()
            : base("t_ChannelState_")
        { }
      
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZSystem.Model.t_ChannelState model)
        {
            dal.Add(model);
        }
        
        /// <summary>
        /// 更新一条数据
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
        /// 删除一条数据
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
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int? iChID)
        {
            return dal.Exists(iChID);
        }
      
        /// <summary>
        /// 得到一个对象实体
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
        /// 获得泛型数据列表
        /// </summary>
        public List<ZSystem.Model.t_ChannelState> GetList()
        {
            return dal.GetList();
        }
      
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<ZSystem.Model.t_ChannelState> GetPageList(PageInfo pi)
        {
            return dal.GetPageList(pi);
        }
    }
}
    