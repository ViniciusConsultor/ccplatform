/*******************************************************************************
* 创建标识: Copyright (C) 2007-2012 Socansoft.com 版权所有
* 创建描述: SocanCode代码生成器 V6.2.1.0 自动创建于 2012-02-09 09:07:02
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
    /// 数据访问类 t_ReceiveList ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_ReceiveList : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_ReceiveList model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_ReceiveList(");
            strSql.Append("KeyID, sCallerID, ClientID, SysUserID, iTimeElapse, ReceiveDate, Memo)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sCallerID, @in_ClientID, @in_SysUserID, @in_iTimeElapse, @in_ReceiveDate, @in_Memo)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sCallerID", DbType.String, model.sCallerID),
                dbHelper.CreateInDbParameter("@in_ClientID", DbType.String, model.ClientID),
                dbHelper.CreateInDbParameter("@in_SysUserID", DbType.String, model.SysUserID),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse),
                dbHelper.CreateInDbParameter("@in_ReceiveDate", DbType.DateTime, model.ReceiveDate),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_ReceiveList model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_ReceiveList SET ");
            strSql.Append("sCallerID=@in_sCallerID,");
            strSql.Append("ClientID=@in_ClientID,");
            strSql.Append("SysUserID=@in_SysUserID,");
            strSql.Append("iTimeElapse=@in_iTimeElapse,");
            strSql.Append("ReceiveDate=@in_ReceiveDate,");
            strSql.Append("Memo=@in_Memo");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sCallerID", DbType.String, model.sCallerID),
                dbHelper.CreateInDbParameter("@in_ClientID", DbType.String, model.ClientID),
                dbHelper.CreateInDbParameter("@in_SysUserID", DbType.String, model.SysUserID),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse),
                dbHelper.CreateInDbParameter("@in_ReceiveDate", DbType.DateTime, model.ReceiveDate),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_ReceiveList");
            strSql.Append(" WHERE KeyID=@in_KeyID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_ReceiveList");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_ReceiveList");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_ReceiveList model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.sCallerID = GetString(dr["sCallerID"]);
            model.ClientID = GetString(dr["ClientID"]);
            model.SysUserID = GetString(dr["SysUserID"]);
            model.iTimeElapse = GetInt(dr["iTimeElapse"]);
            model.ReceiveDate = GetDateTime(dr["ReceiveDate"]);
            model.Memo = GetString(dr["Memo"]);
        }
    }
}