/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-09 09:07:01
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
    /// 数据访问类 t_GlobalPara
    /// </summary>
    public partial class t_GlobalPara : DALHelper
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(ZSystem.Model.t_GlobalPara model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareAddCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public int Update(ZSystem.Model.t_GlobalPara model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareUpdateCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public int Delete(int? KeyID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareDeleteCommand(KeyID, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public ZSystem.Model.t_GlobalPara GetModel(int? KeyID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(KeyID, out strSql, out cmdParms);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
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
        public bool Exists(int? KeyID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareExistCommand(KeyID, out strSql, out cmdParms);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// 获取数量
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM t_GlobalPara", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// 获取泛型数据列表
        /// </summary>
        public List<ZSystem.Model.t_GlobalPara> GetList()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM t_GlobalPara");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<ZSystem.Model.t_GlobalPara> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// 分页获取泛型数据列表
        /// </summary>
        public PageList<ZSystem.Model.t_GlobalPara> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<ZSystem.Model.t_GlobalPara> pl = new PageList<ZSystem.Model.t_GlobalPara>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM t_GlobalPara", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }
        
        #region -------- 私有方法 --------
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        private ZSystem.Model.t_GlobalPara GetModel(DbDataReader dr)
        {
            ZSystem.Model.t_GlobalPara model = new ZSystem.Model.t_GlobalPara();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// 由DbDataReader得到泛型数据列表
        /// </summary>
        private List<ZSystem.Model.t_GlobalPara> GetList(DbDataReader dr)
        {
            List<ZSystem.Model.t_GlobalPara> lst = new List<ZSystem.Model.t_GlobalPara>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// 由DbDataReader得到分页泛型数据列表
        /// </summary>
        private List<ZSystem.Model.t_GlobalPara> GetPageList(DbDataReader dr, int first, int count)
        {
            List<ZSystem.Model.t_GlobalPara> lst = new List<ZSystem.Model.t_GlobalPara>();
            
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