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
    /// ���ݷ����� t_CallList ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_CallList : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
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
        /// Ϊ����һ������׼������
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
        /// Ϊɾ��һ������׼������
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
        /// Ϊ��ѯ�Ƿ����һ������׼������
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
        /// Ϊ��ȡһ������׼������
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
        /// ��һ�����ݵõ�һ��ʵ��
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