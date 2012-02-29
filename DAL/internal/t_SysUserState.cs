/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.4.1.0 �Զ������� 2012/2/11 15:11:27
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
    /// ���ݷ����� t_SysUserState ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_SysUserState : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_SysUserState model, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("INSERT INTO t_SysUserState(");
            sbSql4t_SysUserState.Append("KeyID, UserID, iState, LastDate)");
            sbSql4t_SysUserState.Append(" VALUES (");
            sbSql4t_SysUserState.Append("@in_KeyID, @in_UserID, @in_iState, @in_LastDate)");
    
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_iState", DbType.Int32, model.iState),
                dbHelper.CreateInDbParameter("@in_LastDate", DbType.DateTime, model.LastDate)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_SysUserState model, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("UPDATE t_SysUserState SET ");
            sbSql4t_SysUserState.Append("UserID=@in_UserID,");
            sbSql4t_SysUserState.Append("iState=@in_iState,");
            sbSql4t_SysUserState.Append("LastDate=@in_LastDate");
            sbSql4t_SysUserState.Append(" WHERE KeyID=@in_KeyID");
    
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_iState", DbType.Int32, model.iState),
                dbHelper.CreateInDbParameter("@in_LastDate", DbType.DateTime, model.LastDate),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("DELETE FROM t_SysUserState");
            sbSql4t_SysUserState.Append(" WHERE KeyID=@in_KeyID");
      
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(string KeyID, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("SELECT COUNT(1) FROM t_SysUserState");
            sbSql4t_SysUserState.Append(" WHERE KeyID=@in_KeyID");
          
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string UserID, out StringBuilder sbSql4t_SysUserState, out DbParameter[] parms4t_SysUserState)
        {
            sbSql4t_SysUserState = new StringBuilder();
            sbSql4t_SysUserState.Append("SELECT top 1 * FROM t_SysUserState");
            sbSql4t_SysUserState.Append(" WHERE UserID=@in_UserID ORDER BY LastDate desc");
          
            parms4t_SysUserState = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_SysUserState model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.UserID = GetString(dr["UserID"]);
            model.iState = GetInt(dr["iState"]);
            model.LastDate = GetDateTime(dr["LastDate"]);
        }
    }
}