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
    /// ���ݷ����� t_ChannelStateStatic ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_ChannelStateStatic : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_ChannelStateStatic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_ChannelStateStatic(");
            strSql.Append("iChID, iChtype, iChNum)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_iChID, @in_iChtype, @in_iChNum)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID),
                dbHelper.CreateInDbParameter("@in_iChtype", DbType.Int32, model.iChtype),
                dbHelper.CreateInDbParameter("@in_iChNum", DbType.Int32, model.iChNum)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareUpdateCommand(ZSystem.Model.t_ChannelStateStatic model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("UPDATE t_ChannelStateStatic SET ");
            strSql.Append("iChtype=@in_iChtype,");
            strSql.Append("iChNum=@in_iChNum");
            strSql.Append(" WHERE iChID=@in_iChID");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChtype", DbType.Int32, model.iChtype),
                dbHelper.CreateInDbParameter("@in_iChNum", DbType.Int32, model.iChNum),
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, model.iChID)};
        }
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(int? iChID, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_ChannelStateStatic");
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
            strSql.Append("SELECT COUNT(1) FROM t_ChannelStateStatic");
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
            strSql.Append("SELECT * FROM t_ChannelStateStatic");
            strSql.Append(" WHERE iChID=@in_iChID");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_iChID", DbType.Int32, iChID)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_ChannelStateStatic model, DbDataReader dr)
        {
            model.iChID = GetInt(dr["iChID"]);
            model.iChtype = GetInt(dr["iChtype"]);
            model.iChNum = GetInt(dr["iChNum"]);
        }
    }
}