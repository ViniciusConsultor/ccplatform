/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.4.1.0 �Զ������� 2012/2/11 15:06:23
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
    /// ���ݷ����� t_Log ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_Log : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_Log model, out StringBuilder sbSql4t_Log, out DbParameter[] parms4t_Log)
        {
            sbSql4t_Log = new StringBuilder();
            sbSql4t_Log.Append("INSERT INTO t_Log(");
            sbSql4t_Log.Append("ID, sContent, sType, LogTime)");
            sbSql4t_Log.Append(" VALUES (");
            sbSql4t_Log.Append("@in_ID, @in_sContent, @in_sType, @in_LogTime)");
    
            parms4t_Log = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ID", DbType.String, model.ID),
                dbHelper.CreateInDbParameter("@in_sContent", DbType.String, model.sContent),
                dbHelper.CreateInDbParameter("@in_sType", DbType.String, model.sType),
                dbHelper.CreateInDbParameter("@in_LogTime", DbType.DateTime, model.LogTime)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_Log model, out StringBuilder sbSql4t_Log, out DbParameter[] parms4t_Log)
        {
            sbSql4t_Log = new StringBuilder();
            sbSql4t_Log.Append("UPDATE t_Log SET ");
            sbSql4t_Log.Append("sContent=@in_sContent,");
            sbSql4t_Log.Append("sType=@in_sType,");
            sbSql4t_Log.Append("LogTime=@in_LogTime");
            sbSql4t_Log.Append(" WHERE ID=@in_ID");
    
            parms4t_Log = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sContent", DbType.String, model.sContent),
                dbHelper.CreateInDbParameter("@in_sType", DbType.String, model.sType),
                dbHelper.CreateInDbParameter("@in_LogTime", DbType.DateTime, model.LogTime),
                dbHelper.CreateInDbParameter("@in_ID", DbType.String, model.ID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(string ID, out StringBuilder sbSql4t_Log, out DbParameter[] parms4t_Log)
        {
            sbSql4t_Log = new StringBuilder();
            sbSql4t_Log.Append("DELETE FROM t_Log");
            sbSql4t_Log.Append(" WHERE ID=@in_ID");
      
            parms4t_Log = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ID", DbType.String, ID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(string ID, out StringBuilder sbSql4t_Log, out DbParameter[] parms4t_Log)
        {
            sbSql4t_Log = new StringBuilder();
            sbSql4t_Log.Append("SELECT COUNT(1) FROM t_Log");
            sbSql4t_Log.Append(" WHERE ID=@in_ID");
          
            parms4t_Log = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ID", DbType.String, ID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string ID, out StringBuilder sbSql4t_Log, out DbParameter[] parms4t_Log)
        {
            sbSql4t_Log = new StringBuilder();
            sbSql4t_Log.Append("SELECT * FROM t_Log");
            sbSql4t_Log.Append(" WHERE ID=@in_ID");
          
            parms4t_Log = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_ID", DbType.String, ID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_Log model, DbDataReader dr)
        {
            model.ID = GetString(dr["ID"]);
            model.sContent = GetString(dr["sContent"]);
            model.sType = GetString(dr["sType"]);
            model.LogTime = GetDateTime(dr["LogTime"]);
        }
    }
}