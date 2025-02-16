using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DBUtility;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// 黑名单IP
    /// </summary>
    public class Dal_DisableIP
    {
        private string Mcon = ConfigurationManager.AppSettings["MConnectionString"];
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int D_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + Mcon + ".dbo.DisableIP");
            strSql.Append(" where D_Id=" + D_Id + " ");
            return DbHelperOledb.Exists(strSql.ToString());
        }

        public bool Exists(string ipAddress)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + Mcon + ".dbo.DisableIP");
            strSql.Append(" where IPAddress='" + ipAddress + "' ");
            return DbHelperOledb.Exists(strSql.ToString());
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from " + Mcon + ".dbo.DisableIP");
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model_DisableIP model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into " + Mcon + ".dbo.DisableIP(IPAddress,AddDate) values(@IPAddress,@AddDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IPAddress", model.IPAddress);
                cmd.Parameters.AddWithValue("@AddDate", model.AddDate);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int D_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + Mcon + ".dbo.DisableIP ");
            strSql.Append(" where D_Id=" + D_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Model_DisableIP GetModel(int D_Id)
        {
            Model.Model_DisableIP model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from " + Mcon + ".dbo.DisableIP where id=@D_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@D_Id", D_Id);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model_DisableIP();
                    model.D_Id = D_Id;
                    model.IPAddress = sdr["IPAddress"] == System.DBNull.Value ? "" : (string)sdr["IPAddress"];

                    if (sdr["AddDate"].ToString().Trim() != "")
                    {
                        model.AddDate = Convert.ToDateTime(sdr["AddDate"].ToString());
                    }
                }
                sdr.Close();
            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM " + Mcon + ".dbo.DisableIP ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by D_Id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }
    }
}
