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
    /// ���ݷ����� t_Operation ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_Operation : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_Operation model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_Operation(");
            strSql.Append("KeyID, ClientID, iStatus, iTotalPrice, CreateUser, Memo,IsEnable,LastUpdate)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_ClientID, @in_iStatus, @in_iTotalPrice, @in_CreateUser, @in_Memo,@in_IsEnable,@in_LastUpdate)");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_ClientID", DbType.String, model.ClientID),
                dbHelper.CreateInDbParameter("@in_iStatus", DbType.Int32, model.iStatus),
                dbHelper.CreateInDbParameter("@in_iTotalPrice", DbType.Double, model.iTotalPrice),
                dbHelper.CreateInDbParameter("@in_CreateUser", DbType.String, model.CreateUser),
                dbHelper.CreateInDbParameter("@in_Memo", DbType.String, model.Memo),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.String, model.LastUpdate)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_Operation model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_Operation SET ");
            strSql.Append("ClientID=@in_ClientID,");
            strSql.Append("iStatus=@in_iStatus,");
            strSql.Append("iTotalPrice=@in_iTotalPrice,");
            strSql.Append("CreateUser=@in_CreateUser,");
            strSql.Append("IsEnable=@in_IsEnable,");
            strSql.Append("LastUpdate=@in_LastUpdate,");
            strSql.Append("Memo=@in_Memo");
            strSql.Append(" WHERE KeyID=@in_KeyID");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ClientID", DbType.String, model.ClientID),
                dbHelper.CreateInDbParameter("@in_iStatus", DbType.Int32, model.iStatus),
                dbHelper.CreateInDbParameter("@in_iTotalPrice", DbType.Double, model.iTotalPrice),
                dbHelper.CreateInDbParameter("@in_CreateUser", DbType.String, model.CreateUser),
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
            strSql.Append("DELETE FROM t_Operation");
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
            strSql.Append("SELECT COUNT(1) FROM t_Operation");
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
            strSql.Append("SELECT * FROM t_Operation");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_Operation model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.ClientID = GetString(dr["ClientID"]);
            model.iStatus = GetInt(dr["iStatus"]);
            model.iTotalPrice = GetDouble(dr["iTotalPrice"]);
            model.CreateUser = GetString(dr["CreateUser"]);
            model.Memo = GetString(dr["Memo"]);
            model.IsEnable = GetBool(dr["IsEnable"]);
            model.LastUpdate = GetDateTime(dr["LastUpdate"]);
        }
    }
}