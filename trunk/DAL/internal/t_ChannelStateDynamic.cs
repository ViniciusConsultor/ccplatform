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
    /// 数据访问类 t_ChannelStateDynamic ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_ChannelStateDynamic : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_ChannelStateDynamic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_ChannelStateDynamic(");
            strSql.Append("iChID, sChState, iChType, sCaller, sDTMF, iTimeElapse)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_iChID, @in_sChState, @in_iChType, @in_sCaller, @in_sDTMF, @in_iTimeElapse)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID),
                dbHelper.CreateInDbParameter("@in_sChState", DbType.String, model.sChState),
                dbHelper.CreateInDbParameter("@in_iChType", DbType.Int32, model.iChType),
                dbHelper.CreateInDbParameter("@in_sCaller", DbType.String, model.sCaller),
                dbHelper.CreateInDbParameter("@in_sDTMF", DbType.String, model.sDTMF),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_ChannelStateDynamic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_ChannelStateDynamic SET ");
            strSql.Append("sChState=@in_sChState,");
            strSql.Append("iChType=@in_iChType,");
            strSql.Append("sCaller=@in_sCaller,");
            strSql.Append("sDTMF=@in_sDTMF,");
            strSql.Append("iTimeElapse=@in_iTimeElapse");
            strSql.Append(" WHERE iChID=@in_iChID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sChState", DbType.String, model.sChState),
                dbHelper.CreateInDbParameter("@in_iChType", DbType.Int32, model.iChType),
                dbHelper.CreateInDbParameter("@in_sCaller", DbType.String, model.sCaller),
                dbHelper.CreateInDbParameter("@in_sDTMF", DbType.String, model.sDTMF),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse),
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_ChannelStateDynamic");
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
            strSql.Append("SELECT COUNT(1) FROM t_ChannelStateDynamic");
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
            strSql.Append("SELECT * FROM t_ChannelStateDynamic");
            strSql.Append(" WHERE iChID=@in_iChID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_ChannelStateDynamic model, DbDataReader dr)
        {
            model.iChID = GetInt(dr["iChID"]);
            model.sChState = GetString(dr["sChState"]);
            model.iChType = GetInt(dr["iChType"]);
            model.sCaller = GetString(dr["sCaller"]);
            model.sDTMF = GetString(dr["sDTMF"]);
            model.iTimeElapse = GetInt(dr["iTimeElapse"]);
        }
    }
}