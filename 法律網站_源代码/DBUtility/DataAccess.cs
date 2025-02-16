using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace DBUtility
{
   /// <summary>
    /// 数据类
    /// </summary>
    public class DataAccess
    {
        private static OleDbConnection Conn = new OleDbConnection();
        private static OleDbCommand Cmd = new OleDbCommand();

        public DataAccess()
        {

        }

        /// <summary>
        /// 打开连接
        /// </summary>


        public static void Open()
        {
            if (Conn.State.Equals(ConnectionState.Closed))
            {
                Conn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source="
        + System.Web.HttpContext.Current.Server.MapPath(ConfigurationManager.ConnectionStrings["ConnStr"].ToString());
                Cmd.Connection = Conn;
                Conn.Open();
            }
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public static void Close()
        {
            if (Conn.State.Equals(ConnectionState.Open))
                Conn.Close();
            Conn.Dispose();
        }


        public static DataSet GetDataSet(string sql)
        {
            try
            {
                Open();
                OleDbDataAdapter Da = new OleDbDataAdapter(sql, Conn);
                DataSet Ds = new DataSet();
                Da.Fill(Ds);
                return Ds;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                Close();
            }
        }

        public static DataTable GetDataTable(string sql)
        {
            try
            {
                Open();
                OleDbDataAdapter Da = new OleDbDataAdapter(sql, Conn);
                DataTable Dt = new DataTable();
                Da.Fill(Dt);
                return Dt;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                Close();
            }
        }

        public static int ExecuteCmd(string sql)
        {
            try
            {
                Open();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;
                Cmd.ExecuteNonQuery();
                return 1;
            }
            catch
            {
                return -1;
            }
            finally
            {
                Close();
            }
        }

        /// <summary>
        /// 统计记录条数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int CountCmd(string sql)
        {
            try
            {
                Open();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = sql;
                return (int)Cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message, e);
            }
            finally
            {
                Close();
            }
        }
    }

        
}
