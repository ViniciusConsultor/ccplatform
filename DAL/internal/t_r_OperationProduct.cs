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
    /// 数据访问类 t_r_OperationProduct ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_r_OperationProduct : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_r_OperationProduct model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_r_OperationProduct(");
            strSql.Append("KeyID, OperationID, ProductID, iPrice, iDiscount, iCurrentPrice)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_OperationID, @in_ProductID, @in_iPrice, @in_iDiscount, @in_iCurrentPrice)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_OperationID", DbType.String, model.OperationID),
                dbHelper.CreateInDbParameter("@in_ProductID", DbType.String, model.ProductID),
                dbHelper.CreateInDbParameter("@in_iPrice", DbType.Double, model.iPrice),
                dbHelper.CreateInDbParameter("@in_iDiscount", DbType.Int32, model.iDiscount),
                dbHelper.CreateInDbParameter("@in_iCurrentPrice", DbType.Double, model.iCurrentPrice)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_r_OperationProduct model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_r_OperationProduct SET ");
            strSql.Append("OperationID=@in_OperationID,");
            strSql.Append("ProductID=@in_ProductID,");
            strSql.Append("iPrice=@in_iPrice,");
            strSql.Append("iDiscount=@in_iDiscount,");
            strSql.Append("iCurrentPrice=@in_iCurrentPrice");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_OperationID", DbType.String, model.OperationID),
                dbHelper.CreateInDbParameter("@in_ProductID", DbType.String, model.ProductID),
                dbHelper.CreateInDbParameter("@in_iPrice", DbType.Double, model.iPrice),
                dbHelper.CreateInDbParameter("@in_iDiscount", DbType.Int32, model.iDiscount),
                dbHelper.CreateInDbParameter("@in_iCurrentPrice", DbType.Double, model.iCurrentPrice),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_r_OperationProduct");
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
            strSql.Append("SELECT COUNT(1) FROM t_r_OperationProduct");
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
            strSql.Append("SELECT * FROM t_r_OperationProduct");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_r_OperationProduct model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.OperationID = GetString(dr["OperationID"]);
            model.ProductID = GetString(dr["ProductID"]);
            model.iPrice = GetDouble(dr["iPrice"]);
            model.iDiscount = GetInt(dr["iDiscount"]);
            model.iCurrentPrice = GetDouble(dr["iCurrentPrice"]);
        }
    }
}