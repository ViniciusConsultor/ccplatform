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
    /// ���ݷ����� t_Authorization ���������𶯣��Է�����ֶθ���ʱ�������ɸ���
    /// </summary>
    public partial class t_Authorization : DALHelper
    {
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        internal static void PrepareAddCommand(ZSystem.Model.t_Authorization model, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("INSERT INTO t_Authorization(");
            strSql.Append("UserID, iUserLevel)");
            strSql.Append(" VALUES (");
            strSql.Append("@in_UserID, @in_iUserLevel)");
    
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, model.iUserLevel)};
        }
            
        /// <summary>
        /// Ϊ����һ������׼������
        /// </summary>
        //internal static void PrepareUpdateCommand(ZSystem.Model.t_Authorization model, out StringBuilder strSql, out DbParameter[] cmdParms)
        //{
        //    //strSql = new StringBuilder();
        //    //strSql.Append("UPDATE t_Authorization SET iUserLevel= ");");
        //    //strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
    
        //    //cmdParms = new DbParameter[]{
        //    //    dbHelper.CreateInDbParameter("@in_UserID", DbType.String, model.UserID),
        //    //    dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, model.iUserLevel)};
        //}
            
        /// <summary>
        /// Ϊɾ��һ������׼������
        /// </summary>
        internal static void PrepareDeleteCommand(string UserID, int? iUserLevel, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("DELETE FROM t_Authorization");
            strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
      
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, iUserLevel)};
        }
        
        /// <summary>
        /// Ϊ��ѯ�Ƿ����һ������׼������
        /// </summary>
        internal static void PrepareExistCommand(string UserID, int? iUserLevel, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT COUNT(1) FROM t_Authorization");
            strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, iUserLevel)};
        }
        
        /// <summary>
        /// Ϊ��ȡһ������׼������
        /// </summary>
        internal static void PrepareGetModelCommand(string UserID, int? iUserLevel, out StringBuilder strSql, out DbParameter[] cmdParms)
        {
            strSql = new StringBuilder();
            strSql.Append("SELECT * FROM t_Authorization");
            strSql.Append(" WHERE UserID=@in_UserID AND iUserLevel=@in_iUserLevel");
          
            cmdParms = new DbParameter[]{
                dbHelper.CreateInDbParameter("@in_UserID", DbType.String, UserID),
                dbHelper.CreateInDbParameter("@in_iUserLevel", DbType.Int32, iUserLevel)};
        }
            
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        internal static void PrepareModel(ZSystem.Model.t_Authorization model, DbDataReader dr)
        {
            model.UserID = GetString(dr["UserID"]);
            model.iUserLevel = GetInt(dr["iUserLevel"]);
        }
    }
}