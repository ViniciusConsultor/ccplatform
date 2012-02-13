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
using System.Configuration;
using System.Web;
using DBUtility;

namespace ZSystem.DAL
{
    public class DALHelper
    {
        #region WinForm��ʹ���ⲿ�ִ��룬��ע������Ĵ��룬�ϲ���ô˷����Ը����Ӳ���
        //public static DBHelper dbHelper;
        //public static void SetHelper(DBHelper.DatabaseTypes type, string connectionString)
        //{
        //    dbHelper = new DBHelper(type, connectionString);
        //} 
        #endregion

        #region WebForm��ʹ���ⲿ�ִ��룬��ע������Ĵ��룬WebConfig�������ö�Ӧ�����ݿ�����
        protected static DBHelper dbHelper = GetHelper("Zsystem");

        /// <summary>
        /// ��Web.config�Ӷ�ȡ���ݿ�������Լ����ݿ�����
        /// </summary>
        private static DBHelper GetHelper(string connectionStringName)
        {
            DBHelper dbHelper = new DBHelper();

            // ��Web.config�ж�ȡ���ݿ�����
            string providerName = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ProviderName;
            switch (providerName)
            {
                case "System.Data.OracleClient":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.Oracle;
                    break;
                case "MySql.Data.MySqlClient":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.MySql;
                    break;
                case "System.Data.OleDb":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.OleDb;
                    break;
                case "System.Data.SQLite":
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.SQLite;
                    break;
                case "System.Data.SqlClient":
                default:
                    dbHelper.DatabaseType = DBHelper.DatabaseTypes.Sql;
                    break;
            }

            // ��Web.config�ж�ȡ���ݿ�����
            dbHelper.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings[connectionStringName].ConnectionString;

            return dbHelper;
        } 
        #endregion

        #region ��Objectȡֵ
        /// <summary>
        /// ȡ��Int16ֵ
        /// </summary>
        public static Int16? GetInt16(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                short result;
                if (Int16.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��UInt16ֵ
        /// </summary>
        public static UInt16? GetUInt16(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                ushort result;
                if (UInt16.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��Intֵ
        /// </summary>
        public static int? GetInt(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                int result;
                if (int.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��UIntֵ
        /// </summary>
        public static uint? GetUInt(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                uint result;
                if (uint.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��UInt64ֵ
        /// </summary>
        public static ulong? GetULong(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                ulong result;
                if (ulong.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��byteֵ
        /// </summary>
        public static byte? GetByte(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                byte result;
                if (byte.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��sbyteֵ
        /// </summary>
        public static sbyte? GetSByte(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                sbyte result;
                if (sbyte.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ���Longֵ
        /// </summary>
        public static long? GetLong(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                long result;
                if (long.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��Decimalֵ
        /// </summary>
        public static decimal? GetDecimal(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                decimal result;
                if (decimal.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��floatֵ
        /// </summary>
        public static float? GetFloat(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                float result;
                if (float.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null; ;
            }
        }

        /// <summary>
        /// ȡ��doubleֵ
        /// </summary>
        public static double? GetDouble(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                double result;
                if (double.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��Guidֵ
        /// </summary>
        public static Guid? GetGuid(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                try
                {
                    Guid result = new Guid(obj.ToString());
                    return result;
                }
                catch
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��DateTimeֵ
        /// </summary>
        public static DateTime? GetDateTime(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                DateTime result;
                if (DateTime.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��boolֵ
        /// </summary>
        public static bool? GetBool(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                bool result;
                if (bool.TryParse(obj.ToString(), out result))
                    return result;
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��byte[]
        /// </summary>
        public static byte[] GetBinary(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                return (byte[])obj;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// ȡ��stringֵ
        /// </summary>
        public static string GetString(object obj)
        {
            if (obj != null && obj != DBNull.Value)
            {
                return obj.ToString();
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}