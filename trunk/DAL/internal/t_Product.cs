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
    /// 数据访问类 t_Product ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_Product : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_Product model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_Product(");
            strSql.Append("KeyID, sProductName, iPrice, Memo, iDiscount, IsEnable, Begindate, Enddate, LastUpdate)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sProductName, @in_iPrice, @in_Memo, @in_iDiscount, @in_IsEnable, @in_Begindate, @in_Enddate, @in_LastUpdate)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.Guid, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sProductName", DbType.String, model.sProductName),
                dbHelper.CreateInDbParameter("@in_iPrice", DbType.Double, model.iPrice),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_iDiscount", DbType.Int32, model.iDiscount),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_Begindate", DbType.DateTime, model.Begindate),
                dbHelper.CreateInDbParameter("@in_Enddate", DbType.DateTime, model.Enddate),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_Product model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_Product SET ");
            strSql.Append("sProductName=@in_sProductName,");
            strSql.Append("iPrice=@in_iPrice,");
            strSql.Append("Memo=@in_Memo,");
            strSql.Append("iDiscount=@in_iDiscount,");
            strSql.Append("IsEnable=@in_IsEnable,");
            strSql.Append("Begindate=@in_Begindate,");
            strSql.Append("Enddate=@in_Enddate,");
            strSql.Append("LastUpdate=@in_LastUpdate");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sProductName", DbType.String, model.sProductName),
                dbHelper.CreateInDbParameter("@in_iPrice", DbType.Double, model.iPrice),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_iDiscount", DbType.Int32, model.iDiscount),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_Begindate", DbType.DateTime, model.Begindate),
                dbHelper.CreateInDbParameter("@in_Enddate", DbType.DateTime, model.Enddate),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.Guid, model.KeyID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(Guid? KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_Product");
            strSql.Append(" WHERE KeyID=@in_KeyID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.Guid, KeyID)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(Guid? KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_Product");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.Guid, KeyID)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(Guid? KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_Product");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.Guid, KeyID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_Product model, DbDataReader dr)
        {
            model.KeyID = GetGuid(dr["KeyID"]);
            model.sProductName = GetString(dr["sProductName"]);
            model.iPrice = GetDouble(dr["iPrice"]);
            model.Memo = GetString(dr["Memo"]);
            model.iDiscount = GetInt(dr["iDiscount"]);
            model.IsEnable = GetBool(dr["IsEnable"]);
            model.Begindate = GetDateTime(dr["Begindate"]);
            model.Enddate = GetDateTime(dr["Enddate"]);
            model.LastUpdate = GetDateTime(dr["LastUpdate"]);
        }
    }
}