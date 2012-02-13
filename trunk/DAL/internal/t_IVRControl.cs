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
    /// 数据访问类 t_IVRControl ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_IVRControl : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_IVRControl model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_IVRControl(");
            strSql.Append("KeyID, sFileName, iKeyNum, SubID, sIVRName, IsEnable, BeginDate, EndDate, LastUpdate)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sFileName, @in_iKeyNum, @in_SubID, @in_sIVRName, @in_IsEnable, @in_BeginDate, @in_EndDate, @in_LastUpdate)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sFileName", DbType.String, model.sFileName),
                dbHelper.CreateInDbParameter("@in_iKeyNum", DbType.Int32, model.iKeyNum),
                dbHelper.CreateInDbParameter("@in_SubID", DbType.String, model.SubID),
                dbHelper.CreateInDbParameter("@in_sIVRName", DbType.String, model.sIVRName),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_BeginDate", DbType.DateTime, model.BeginDate),
                dbHelper.CreateInDbParameter("@in_EndDate", DbType.DateTime, model.EndDate),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_IVRControl model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_IVRControl SET ");
            strSql.Append("sFileName=@in_sFileName,");
            strSql.Append("iKeyNum=@in_iKeyNum,");
            strSql.Append("SubID=@in_SubID,");
            strSql.Append("sIVRName=@in_sIVRName,");
            strSql.Append("IsEnable=@in_IsEnable,");
            strSql.Append("BeginDate=@in_BeginDate,");
            strSql.Append("EndDate=@in_EndDate,");
            strSql.Append("LastUpdate=@in_LastUpdate");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sFileName", DbType.String, model.sFileName),
                dbHelper.CreateInDbParameter("@in_iKeyNum", DbType.Int32, model.iKeyNum),
                dbHelper.CreateInDbParameter("@in_SubID", DbType.String, model.SubID),
                dbHelper.CreateInDbParameter("@in_sIVRName", DbType.String, model.sIVRName),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_BeginDate", DbType.DateTime, model.BeginDate),
                dbHelper.CreateInDbParameter("@in_EndDate", DbType.DateTime, model.EndDate),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_IVRControl");
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
            strSql.Append("SELECT COUNT(1) FROM t_IVRControl");
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
            strSql.Append("SELECT * FROM t_IVRControl");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_IVRControl model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.sFileName = GetString(dr["sFileName"]);
            model.iKeyNum = GetInt(dr["iKeyNum"]);
            model.SubID = GetString(dr["SubID"]);
            model.sIVRName = GetString(dr["sIVRName"]);
            model.IsEnable = GetBool(dr["IsEnable"]);
            model.BeginDate = GetDateTime(dr["BeginDate"]);
            model.EndDate = GetDateTime(dr["EndDate"]);
            model.LastUpdate = GetDateTime(dr["LastUpdate"]);
        }
    }
}