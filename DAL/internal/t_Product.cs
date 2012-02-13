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
    /// ���ݷ����� t_Product ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_Product : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
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
        /// Ϊ����һ������׼������
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
        /// Ϊɾ��һ������׼������
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
        /// Ϊ��ѯ�Ƿ����һ������׼������
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
        /// Ϊ��ȡһ������׼������
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
        /// ��һ�����ݵõ�һ��ʵ��
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