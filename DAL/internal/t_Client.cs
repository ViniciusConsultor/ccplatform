/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:03
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
    /// ���ݷ����� t_Client ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_Client : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_Client model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_Client(");
            strSql.Append("KeyID, sClientName, sAddress, sMobiPhone, sTelPhone, CreateUserID, Memo,IsEnable,LastUpdate)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sClientName, @in_sAddress, @in_sMobiPhone, @in_sTelPhone, @in_CreateUserID, @in_Memo,@in_IsEnable,@In_LastUpdate)");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sClientName", DbType.String, model.sClientName),
                dbHelper.CreateInDbParameter("@in_sAddress", DbType.String, model.sAddress),
                dbHelper.CreateInDbParameter("@in_sMobiPhone", DbType.String, model.sMobiPhone),
                dbHelper.CreateInDbParameter("@in_sTelPhone", DbType.String, model.sTelPhone),
                dbHelper.CreateInDbParameter("@in_CreateUserID", DbType.String, model.CreateUserID),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.String, model.LastUpdate)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_Client model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_Client SET ");
            strSql.Append("sClientName=@in_sClientName,");
            strSql.Append("sAddress=@in_sAddress,");
            strSql.Append("sMobiPhone=@in_sMobiPhone,");
            strSql.Append("sTelPhone=@in_sTelPhone,");
            strSql.Append("CreateUserID=@in_CreateUserID,");
            strSql.Append("IsEnable=@in_IsEnable,");
            strSql.Append("LastUpdate=@in_LastUpdate,");
            strSql.Append("Memo=@in_Memo");
            strSql.Append(" WHERE KeyID=@in_KeyID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sClientName", DbType.String, model.sClientName),
                dbHelper.CreateInDbParameter("@in_sAddress", DbType.String, model.sAddress),
                dbHelper.CreateInDbParameter("@in_sMobiPhone", DbType.String, model.sMobiPhone),
                dbHelper.CreateInDbParameter("@in_sTelPhone", DbType.String, model.sTelPhone),
                dbHelper.CreateInDbParameter("@in_CreateUserID", DbType.String, model.CreateUserID),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.String, model.LastUpdate)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_Client");
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
            strSql.Append("SELECT COUNT(1) FROM t_Client");
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
            strSql.Append("SELECT * FROM t_Client");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_Client model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.sClientName = GetString(dr["sClientName"]);
            model.sAddress = GetString(dr["sAddress"]);
            model.sMobiPhone = GetString(dr["sMobiPhone"]);
            model.sTelPhone = GetString(dr["sTelPhone"]);
            model.CreateUserID = GetString(dr["CreateUserID"]);
            model.Memo = GetString(dr["Memo"]);
            model.IsEnable = GetBool(dr["IsEnable"]);
            model.LastUpdate = GetDateTime(dr["LastUpdate"]);
        }
    }
}