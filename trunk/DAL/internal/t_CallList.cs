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
    /// 数据访问类 t_CallList ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_CallList : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_CallList model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_CallList(");
            strSql.Append("KeyID, sCallNum, iTimeElapse, iCallUserCH, UserID, ClientID, Memo)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sCallNum, @in_iTimeElapse, @in_iCallUserCH, @in_UserID, @in_ClientID, @in_Memo)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sCallNum", DbType.String, model.sCallNum),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse),
                dbHelper.CreateInDbParameter("@in_iCallUserCH", DbType.Int32, model.iCallUserCH),
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_ClientID", DbType.String, model.ClientID),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_CallList model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_CallList SET ");
            strSql.Append("sCallNum=@in_sCallNum,");
            strSql.Append("iTimeElapse=@in_iTimeElapse,");
            strSql.Append("iCallUserCH=@in_iCallUserCH,");
            strSql.Append("UserID=@in_UserID,");
            strSql.Append("ClientID=@in_ClientID,");
            strSql.Append("Memo=@in_Memo");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sCallNum", DbType.String, model.sCallNum),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse),
                dbHelper.CreateInDbParameter("@in_iCallUserCH", DbType.Int32, model.iCallUserCH),
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_ClientID", DbType.String, model.ClientID),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_CallList");
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
            strSql.Append("SELECT COUNT(1) FROM t_CallList");
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
            strSql.Append("SELECT * FROM t_CallList");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_CallList model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.sCallNum = GetString(dr["sCallNum"]);
            model.iTimeElapse = GetInt(dr["iTimeElapse"]);
            model.iCallUserCH = GetInt(dr["iCallUserCH"]);
            model.UserID = GetString(dr["UserID"]);
            model.ClientID = GetString(dr["ClientID"]);
            model.Memo = GetString(dr["Memo"]);
        }
    }
}