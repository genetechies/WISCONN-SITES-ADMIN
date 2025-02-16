using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtility;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Right
    {

        public bool Exists(string username, string pagename)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [Right]");
            strSql.Append(" where UserName='" + username + "' and PageName='" + pagename + "'");
            return DbHelperOledb.Exists(strSql.ToString());
        }
        public void Add(Model.Right model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into [Right](UserName,PageName,Rights) values(@UserName,@PageName,@Right)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserName", model.UserName);
                cmd.Parameters.AddWithValue("@PageName", model.PageName);
                cmd.Parameters.AddWithValue("@Right", model.Rights);
                cmd.ExecuteNonQuery();
            }
        }
        public void Update(Model.Right model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update [Right] set UserName=@UserName,PageName=@PageName,Rights=@Right where RightID=@RightID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserName", model.UserName);
                cmd.Parameters.AddWithValue("@PageName", model.PageName);
                cmd.Parameters.AddWithValue("@Right", model.Rights);
                cmd.Parameters.AddWithValue("@RightID", model.RightID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int RightID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Right] ");
            strSql.Append(" where RightID=" + RightID + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }
        //刪除子網站管理
        public void DeleteWhere(string UserName, int Rights)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [Right] ");
            strSql.Append(" where UserName='" + UserName + "' and Rights="+ Rights +" ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  FROM [Right]");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Right GetModel(int RightID)
        {
            Model.Right model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from [Right] where RightID=@RightID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@RightID", RightID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.Right();
                    model.RightID = RightID;
                    model.UserName = (string)sdr["UserName"];
                    model.PageName = sdr["PageName"] == System.DBNull.Value ? "" : (string)sdr["PageName"];
                    model.Rights = (int)sdr["Rights"];
                }
                sdr.Close();
            }
            return model;
        }

        public Model.Right GetModel(string username, string pagename)
        {
            Model.Right model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from [Right] where UserName=@UserName and PageName=@PageName";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@UserName", username);
                cmd.Parameters.AddWithValue("@PageName", pagename);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.Right();
                    model.RightID = (int)sdr["RightID"];
                    model.UserName = username;
                    model.PageName = pagename;
                    model.Rights = (int)sdr["Rights"];
                }
                sdr.Close();
            }
            return model;
        }
    }
}
