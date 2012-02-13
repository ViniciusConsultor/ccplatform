/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:02
* 
* ��������: 
* 
* �޸ı�ʶ: 
* �޸�����: 
*******************************************************************************/

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace ZSystem.DAL
{
    /// <summary>
    /// ���ݷ����� t_r_OperationProduct ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_r_OperationProduct : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
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
        /// Ϊ����һ������׼������
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
        /// Ϊɾ��һ������׼������
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
        /// Ϊ��ѯ�Ƿ����һ������׼������
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
        /// Ϊ��ȡһ������׼������
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
        /// ��һ�����ݵõ�һ��ʵ��
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