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
    /// ���ݷ����� t_SystemUser ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_SystemUser : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_SystemUser model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_SystemUser(");
            strSql.Append("KeyID, sUserName, sLoginName, sPassword, LastUpdate)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sUserName, @in_sLoginName, @in_sPassword, @in_LastUpdate)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sUserName", DbType.String, model.sUserName),
                dbHelper.CreateInDbParameter("@in_sLoginName", DbType.String, model.sLoginName),
                dbHelper.CreateInDbParameter("@in_sPassword", DbType.String, model.sPassword),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_SystemUser model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_SystemUser SET ");
            strSql.Append("sUserName=@in_sUserName,");
            strSql.Append("sLoginName=@in_sLoginName,");
            strSql.Append("sPassword=@in_sPassword,");
            strSql.Append("LastUpdate=@in_LastUpdate");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sUserName", DbType.String, model.sUserName),
                dbHelper.CreateInDbParameter("@in_sLoginName", DbType.String, model.sLoginName),
                dbHelper.CreateInDbParameter("@in_sPassword", DbType.String, model.sPassword),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_SystemUser");
            strSql.Append(" WHERE KeyID=@in_KeyID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(string sLoginName, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_SystemUser");
            strSql.Append(" WHERE sLoginName=@in_sLoginName");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sLoginName", DbType.String, sLoginName)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_SystemUser");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }

        internal static void PrepareGetModelCommand(string sLoginName,string sPassword, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_SystemUser");
            strSql.Append(" WHERE sLoginName=@in_sLoginName and sPassword=@in_sPassword");

            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sLoginName", DbType.String, sLoginName),
                dbHelper.CreateInDbParameter("@in_sPassword", DbType.String, sPassword)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_SystemUser model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.sUserName = GetString(dr["sUserName"]);
            model.sLoginName = GetString(dr["sLoginName"]);
            model.sPassword = GetString(dr["sPassword"]);
            model.LastUpdate = GetDateTime(dr["LastUpdate"]);
        }
    }
}