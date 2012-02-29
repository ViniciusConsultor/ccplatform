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
    /// 数据访问类 t_SysUserState ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_SysUserState : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_SysUserState model, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("INSERT INTO t_SysUserState(");
            sbSql4t_SysUserState.Append("KeyID, UserID, iState, LastDate)");
            sbSql4t_SysUserState.Append(" VALUES (");
            sbSql4t_SysUserState.Append("@in_KeyID, @in_UserID, @in_iState, @in_LastDate)");
    
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_iState", DbType.Int32, model.iState),
                dbHelper.CreateInDbParameter("@in_LastDate", DbType.DateTime, model.LastDate)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_SysUserState model, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("UPDATE t_SysUserState SET ");
            sbSql4t_SysUserState.Append("UserID=@in_UserID,");
            sbSql4t_SysUserState.Append("iState=@in_iState,");
            sbSql4t_SysUserState.Append("LastDate=@in_LastDate");
            sbSql4t_SysUserState.Append(" WHERE KeyID=@in_KeyID");
    
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_iState", DbType.Int32, model.iState),
                dbHelper.CreateInDbParameter("@in_LastDate", DbType.DateTime, model.LastDate),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("DELETE FROM t_SysUserState");
            sbSql4t_SysUserState.Append(" WHERE KeyID=@in_KeyID");
      
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(string KeyID, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("SELECT COUNT(1) FROM t_SysUserState");
            sbSql4t_SysUserState.Append(" WHERE KeyID=@in_KeyID");
          
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(string UserID, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("SELECT top 1 * FROM t_SysUserState");
            sbSql4t_SysUserState.Append(" WHERE UserID=@in_UserID ORDER BY LastDate desc");
          
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_SysUserState model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.UserID = GetString(dr["UserID"]);
            model.iState = GetInt(dr["iState"]);
            model.LastDate = GetDateTime(dr["LastDate"]);
        }
    }
}