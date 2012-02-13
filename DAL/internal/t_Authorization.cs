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
    /// 数据访问类 t_Authorization ，此类请勿动，以方便表字段更改时重新生成覆盖
    /// </summary>
    public partial class t_Authorization : DALHelper
    {
        /// <summary>
        /// 为新增一条数据准备参数
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_Authorization model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_Authorization(");
            strSql.Append("UserID, iUserLevel)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_UserID, @in_iUserLevel)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, model.iUserLevel)};
        }
            
        /// <summary>
        /// 为更新一条数据准备参数
        /// </summary>
        //internal static void PrepareUpdateCommand(ZSystem.Model.t_Authorization model, out StringBuilder strSql, out DbParameter[] cmdParms)
        //{
        //    //strSql = new StringBuilder();
        //    //strSql.Append("UPDATE t_Authorization SET iUserLevel= ");");
        //    //strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
    
        //    //cmdParms = new DbParameter[]{
        //    //    dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
        //    //    dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, model.iUserLevel)};
        //}
            
        /// <summary>
        /// 为删除一条数据准备参数
        /// </summary>
        internal static void PrepareDeleteCommand(string UserID, int? iUserLevel, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_Authorization");
            strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, iUserLevel)};
        }
        
        /// <summary>
        /// 为查询是否存在一条数据准备参数
        /// </summary>
        internal static void PrepareExistCommand(string UserID, int? iUserLevel, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_Authorization");
            strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, iUserLevel)};
        }
        
        /// <summary>
        /// 为获取一条数据准备参数
        /// </summary>
        internal static void PrepareGetModelCommand(string UserID, int? iUserLevel, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_Authorization");
            strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, iUserLevel)};
        }
            
        /// <summary>
        /// 由一行数据得到一个实体
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_Authorization model, DbDataReader dr)
        {
            model.UserID = GetString(dr["UserID"]);
            model.iUserLevel = GetInt(dr["iUserLevel"]);
        }
    }
}