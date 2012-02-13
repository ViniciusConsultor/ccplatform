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
    /// ���ݷ����� t_ChannelStateDynamic ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_ChannelStateDynamic : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_ChannelStateDynamic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_ChannelStateDynamic(");
            strSql.Append("iChID, sChState, iChType, sCaller, sDTMF, iTimeElapse)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_iChID, @in_sChState, @in_iChType, @in_sCaller, @in_sDTMF, @in_iTimeElapse)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID),
                dbHelper.CreateInDbParameter("@in_sChState", DbType.String, model.sChState),
                dbHelper.CreateInDbParameter("@in_iChType", DbType.Int32, model.iChType),
                dbHelper.CreateInDbParameter("@in_sCaller", DbType.String, model.sCaller),
                dbHelper.CreateInDbParameter("@in_sDTMF", DbType.String, model.sDTMF),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_ChannelStateDynamic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_ChannelStateDynamic SET ");
            strSql.Append("sChState=@in_sChState,");
            strSql.Append("iChType=@in_iChType,");
            strSql.Append("sCaller=@in_sCaller,");
            strSql.Append("sDTMF=@in_sDTMF,");
            strSql.Append("iTimeElapse=@in_iTimeElapse");
            strSql.Append(" WHERE iChID=@in_iChID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_sChState", DbType.String, model.sChState),
                dbHelper.CreateInDbParameter("@in_iChType", DbType.Int32, model.iChType),
                dbHelper.CreateInDbParameter("@in_sCaller", DbType.String, model.sCaller),
                dbHelper.CreateInDbParameter("@in_sDTMF", DbType.String, model.sDTMF),
                dbHelper.CreateInDbParameter("@in_iTimeElapse", DbType.Int32, model.iTimeElapse),
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_ChannelStateDynamic");
            strSql.Append(" WHERE iChID=@in_iChID");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_ChannelStateDynamic");
            strSql.Append(" WHERE iChID=@in_iChID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_ChannelStateDynamic");
            strSql.Append(" WHERE iChID=@in_iChID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_ChannelStateDynamic model, DbDataReader dr)
        {
            model.iChID = GetInt(dr["iChID"]);
            model.sChState = GetString(dr["sChState"]);
            model.iChType = GetInt(dr["iChType"]);
            model.sCaller = GetString(dr["sCaller"]);
            model.sDTMF = GetString(dr["sDTMF"]);
            model.iTimeElapse = GetInt(dr["iTimeElapse"]);
        }
    }
}