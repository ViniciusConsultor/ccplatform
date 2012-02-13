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
using System.Data;
using System.Data.Common;
using System.Text;

namespace ZSystem.DAL
{
    /// <summary>
    /// 数据访问类 t_ChannelStateStatic ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_ChannelStateStatic : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_ChannelStateStatic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_ChannelStateStatic(");
            strSql.Append("iChID, iChtype, iChNum)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_iChID, @in_iChtype, @in_iChNum)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID),
                dbHelper.CreateInDbParameter("@in_iChtype", DbType.Int32, model.iChtype),
                dbHelper.CreateInDbParameter("@in_iChNum", DbType.Int32, model.iChNum)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_ChannelStateStatic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_ChannelStateStatic SET ");
            strSql.Append("iChtype=@in_iChtype,");
            strSql.Append("iChNum=@in_iChNum");
            strSql.Append(" WHERE iChID=@in_iChID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChtype", DbType.Int32, model.iChtype),
                dbHelper.CreateInDbParameter("@in_iChNum", DbType.Int32, model.iChNum),
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_ChannelStateStatic");
            strSql.Append(" WHERE iChID=@in_iChID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_ChannelStateStatic");
            strSql.Append(" WHERE iChID=@in_iChID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_ChannelStateStatic");
            strSql.Append(" WHERE iChID=@in_iChID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_ChannelStateStatic model, DbDataReader dr)
        {
            model.iChID = GetInt(dr["iChID"]);
            model.iChtype = GetInt(dr["iChtype"]);
            model.iChNum = GetInt(dr["iChNum"]);
        }
    }
}