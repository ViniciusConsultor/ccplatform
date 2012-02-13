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
    /// ���ݷ����� t_IVRControl ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_IVRControl : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_IVRControl model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_IVRControl(");
            strSql.Append("KeyID, sFileName, iKeyNum, SubID, sIVRName, IsEnable, BeginDate, EndDate, LastUpdate)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_KeyID, @in_sFileName, @in_iKeyNum, @in_SubID, @in_sIVRName, @in_IsEnable, @in_BeginDate, @in_EndDate, @in_LastUpdate)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID),
                dbHelper.CreateInDbParameter("@in_sFileName", DbType.String, model.sFileName),
                dbHelper.CreateInDbParameter("@in_iKeyNum", DbType.Int32, model.iKeyNum),
                dbHelper.CreateInDbParameter("@in_SubID", DbType.String, model.SubID),
                dbHelper.CreateInDbParameter("@in_sIVRName", DbType.String, model.sIVRName),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_BeginDate", DbType.DateTime, model.BeginDate),
                dbHelper.CreateInDbParameter("@in_EndDate", DbType.DateTime, model.EndDate),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_IVRControl model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_IVRControl SET ");
            strSql.Append("sFileName=@in_sFileName,");
            strSql.Append("iKeyNum=@in_iKeyNum,");
            strSql.Append("SubID=@in_SubID,");
            strSql.Append("sIVRName=@in_sIVRName,");
            strSql.Append("IsEnable=@in_IsEnable,");
            strSql.Append("BeginDate=@in_BeginDate,");
            strSql.Append("EndDate=@in_EndDate,");
            strSql.Append("LastUpdate=@in_LastUpdate");
            strSql.Append(" WHERE KeyID=@in_KeyID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sFileName", DbType.String, model.sFileName),
                dbHelper.CreateInDbParameter("@in_iKeyNum", DbType.Int32, model.iKeyNum),
                dbHelper.CreateInDbParameter("@in_SubID", DbType.String, model.SubID),
                dbHelper.CreateInDbParameter("@in_sIVRName", DbType.String, model.sIVRName),
                dbHelper.CreateInDbParameter("@in_IsEnable", DbType.Boolean, model.IsEnable),
                dbHelper.CreateInDbParameter("@in_BeginDate", DbType.DateTime, model.BeginDate),
                dbHelper.CreateInDbParameter("@in_EndDate", DbType.DateTime, model.EndDate),
                dbHelper.CreateInDbParameter("@in_LastUpdate", DbType.DateTime, model.LastUpdate),
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, model.KeyID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(string KeyID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_IVRControl");
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
            strSql.Append("SELECT COUNT(1) FROM t_IVRControl");
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
            strSql.Append("SELECT * FROM t_IVRControl");
            strSql.Append(" WHERE KeyID=@in_KeyID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_KeyID", DbType.String, KeyID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_IVRControl model, DbDataReader dr)
        {
            model.KeyID = GetString(dr["KeyID"]);
            model.sFileName = GetString(dr["sFileName"]);
            model.iKeyNum = GetInt(dr["iKeyNum"]);
            model.SubID = GetString(dr["SubID"]);
            model.sIVRName = GetString(dr["sIVRName"]);
            model.IsEnable = GetBool(dr["IsEnable"]);
            model.BeginDate = GetDateTime(dr["BeginDate"]);
            model.EndDate = GetDateTime(dr["EndDate"]);
            model.LastUpdate = GetDateTime(dr["LastUpdate"]);
        }
    }
}