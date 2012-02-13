/*******************************************************************************
* ������ʶ: Copyright (C) 2007-2012 Socansoft.com ��Ȩ����
* ��������: SocanCode���������� V6.2.1.0 �Զ������� 2012-02-09 09:07:01
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
    /// ���ݷ����� t_ChannelStateStatic
    /// </summary>
    public partial class t_ChannelStateStatic : DALHelper
    {
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(ZSystem.Model.t_ChannelStateStatic model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareAddCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// ����һ������
        /// </summary>
        public int Update(ZSystem.Model.t_ChannelStateStatic model)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareUpdateCommand(model, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public int Delete(int? iChID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareDeleteCommand(iChID, out strSql, out cmdParms);
            return dbHelper.ExecuteNonQuery(CommandType.Text, strSql.ToString(), cmdParms);
        }
        
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZSystem.Model.t_ChannelStateStatic GetModel(int? iChID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareGetModelCommand(iChID, out strSql, out cmdParms);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), cmdParms))
            {
                if (dr.Read())
                {
                    return GetModel(dr);
                }
                return null;
            }
        }
        
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int? iChID)
        {
            StringBuilder strSql;
            DbParameter[] cmdParms;
            PrepareExistCommand(iChID, out strSql, out cmdParms);
            object obj = dbHelper.ExecuteScalar(CommandType.Text, strSql.ToString(), cmdParms);
            return int.Parse(obj.ToString()) > 0;
        }
        
        /// <summary>
        /// ��ȡ����
        /// </summary>
        public int GetCount()
        {
            object obj = dbHelper.ExecuteScalar(CommandType.Text, "SELECT count(*) FROM t_ChannelStateStatic", null);
            return int.Parse(obj.ToString());
        }
        
        /// <summary>
        /// ��ȡ���������б�
        /// </summary>
        public List<ZSystem.Model.t_ChannelStateStatic> GetList()
        {
            StringBuilder strSql = new StringBuilder("SELECT * FROM t_ChannelStateStatic");
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, strSql.ToString(), null))
            {
                List<ZSystem.Model.t_ChannelStateStatic> lst = GetList(dr);
                return lst;
            }
        }
        
        /// <summary>
        /// ��ҳ��ȡ���������б�
        /// </summary>
        public PageList<ZSystem.Model.t_ChannelStateStatic> GetPageList(PageInfo pi)
        {
            pi.RecordCount = GetCount();
            pi.Compute();
            
            PageList<ZSystem.Model.t_ChannelStateStatic> pl = new PageList<ZSystem.Model.t_ChannelStateStatic>(pi);
            using (DbDataReader dr = dbHelper.ExecuteReader(CommandType.Text, "SELECT * FROM t_ChannelStateStatic", null))
            {
                pl.List = GetPageList(dr, pi.FirstIndex, pi.PageSize);
            }
            return pl;
        }
        
        #region -------- ˽�з��� --------
        /// <summary>
        /// ��һ�����ݵõ�һ��ʵ��
        /// </summary>
        private ZSystem.Model.t_ChannelStateStatic GetModel(DbDataReader dr)
        {
            ZSystem.Model.t_ChannelStateStatic model = new ZSystem.Model.t_ChannelStateStatic();
            PrepareModel(model, dr);
            return model;
        }
        
        /// <summary>
        /// ��DbDataReader�õ����������б�
        /// </summary>
        private List<ZSystem.Model.t_ChannelStateStatic> GetList(DbDataReader dr)
        {
            List<ZSystem.Model.t_ChannelStateStatic> lst = new List<ZSystem.Model.t_ChannelStateStatic>();
            while (dr.Read())
            {
                lst.Add(GetModel(dr));
            }
            return lst;
        }
      
        /// <summary>
        /// ��DbDataReader�õ���ҳ���������б�
        /// </summary>
        private List<ZSystem.Model.t_ChannelStateStatic> GetPageList(DbDataReader dr, int first, int count)
        {
            List<ZSystem.Model.t_ChannelStateStatic> lst = new List<ZSystem.Model.t_ChannelStateStatic>();
            
            for (int i = 0; i < first; i++)
            {
                if (!dr.Read())
                {
                    return lst;
                }
            }
            
            int resultsFetched = 0;
            while (resultsFetched < count && dr.Read())
            {
                lst.Add(GetModel(dr));
                resultsFetched++;
            }
            
            return lst;
        }
        #endregion
    }
}