/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.4.1.0 自动创建于 2012/2/11 15:11:27
* 
* 功能描述: 
* 
* 修改标识: 
* 修改描述: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace ZSystem.DAL
{
    /// <summary>
    /// 数据访问类 t_SysUserState
    /// </summary>
    public partial class t_SysUserState : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZSystem.Model.t_SysUserState model)
        {
            StringBuilder sbSql4t_SysUserState;
            DbParameter[] parms4t_SysUserState;
            PrepareAddCommand(model, out sbSql4t_SysUserState, out parms4t_SysUserState);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4t_SysUserState.ToString(), parms4t_SysUserState);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(ZSystem.Model.t_SysUserState model)
        {
            StringBuilder sbSql4t_SysUserState;
            DbParameter[] parms4t_SysUserState;
            PrepareUpdateCommand(model, out sbSql4t_SysUserState, out parms4t_SysUserState);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4t_SysUserState.ToString(), parms4t_SysUserState);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(string KeyID)
        {
            StringBuilder sbSql4t_SysUserState;
            DbParameter[] parms4t_SysUserState;
            PrepareDeleteCommand(KeyID, out sbSql4t_SysUserState, out parms4t_SysUserState);
            return dbHelper.ExecuteNonQuery(CommandType.Text, sbSql4t_SysUserState.ToString(), parms4t_SysUserState);
        }
        
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ZSystem.Model.t_SysUserState GetModel(string UserID)
        {
            StringBuilder sbSql4t_SysUserState;
            DbParameter[] parms4t_SysUserState;
            PrepareGetModelCommand(UserID, out sbSql4t_SysUserState, out parms4t_SysUserState);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4t_SysUserState.ToString(), parms4t_SysUserState))
            {
                if (dr.Read())
                {
                    return GetModel(dr);
                }
                return null;
            }
        }
        
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string KeyID)
        {
            StringBuilder sbSql4t_SysUserState;
            DbParameter[] parms4t_SysUserState;
            PrepareExistCommand(KeyID, out sbSql4t_SysUserState, out parms4t_SysUserState);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, sbSql4t_SysUserState.ToString(), parms4t_SysUserState);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM t_SysUserState", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        public List<ZSystem.Model.t_SysUserState> GetList()
        {
            StringBuilder sbSql4t_SysUserState = new StringBuilder("SELECT * FROM t_SysUserState");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, sbSql4t_SysUserState.ToString(), null))
            {
                List<ZSystem.Model.t_SysUserState> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<ZSystem.Model.t_SysUserState> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<ZSystem.Model.t_SysUserState> pl = new PageList<ZSystem.Model.t_SysUserState>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM t_SysUserState", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }
        
        #region -------- 私有方法 --------
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private ZSystem.Model.t_SysUserState GetModel(DbDataReader dr)
        {
            ZSystem.Model.t_SysUserState model = new ZSystem.Model.t_SysUserState();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// 由DbDataReader得到泛型数据列表
        /// </summary>
        private List<ZSystem.Model.t_SysUserState> GetList(DbDataReader dr)
        {
            List<ZSystem.Model.t_SysUserState> lst = new List<ZSystem.Model.t_SysUserState>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// 由DbDataReader得到分页泛型数据列表
        /// </summary>
        private List<ZSystem.Model.t_SysUserState> GetPageList(DbDataReader dr, int first, int count)
        {
            List<ZSystem.Model.t_SysUserState> lst = new List<ZSystem.Model.t_SysUserState>();
            
            for (int i = 0; i < first; i++)
            {
                if (!dr.Read())
                {
                    return lst;
                }
            }
            
            int resultsFetched = 0;
            while (resultsFetched < count && dr.Read())
            {
                lst.Add(GetModel(dr));
                resultsFetched++;
            }
            
            return lst;
        }
        #endregion
    }
}