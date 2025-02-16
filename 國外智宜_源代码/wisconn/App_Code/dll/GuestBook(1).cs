using System;
using System.Collections.Generic;
using System.Text;
using ZeroStudio.DBUtility;
using System.Data;
using System.Data.OleDb;

namespace ZeroStudio.DAL
{
    public class GuestBook
    {
        public GuestBook()
        { }
        #region  成员方法


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int G_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from GuestBook");
            strSql.Append(" where G_Id=" + G_Id + " ");
            return DbHelperOledb.Exists(strSql.ToString());
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from GuestBook");
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.GuestBook model)
        {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into GuestBook(G_Title,G_Username,G_Email,G_Content,G_Datetime) values(@G_Title,@G_Username,@G_Email,@G_Content,@G_Datetime)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_Title", model.G_Title);
                cmd.Parameters.AddWithValue("@G_Username", model.G_Username);
                cmd.Parameters.AddWithValue("@G_Email", model.G_Email);
                cmd.Parameters.AddWithValue("@G_Content", model.G_Content);
                cmd.Parameters.AddWithValue("@G_Datetime", model.G_Datetime);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.GuestBook model)
        {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update GuestBook set G_Title=@G_Title,G_Username=@G_Username,G_Email=@G_Email,G_Content=@G_Content where G_Id=@G_Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_Title", model.G_Title);
                cmd.Parameters.AddWithValue("@G_Username", model.G_Username);
                cmd.Parameters.AddWithValue("@G_Email", model.G_Email);
                cmd.Parameters.AddWithValue("@G_Content", model.G_Content);
                cmd.Parameters.AddWithValue("@G_Id", model.G_Id);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GuestBook ");
            strSql.Append(" where G_Id=" + G_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一個对象实体
        /// </summary>
        public ZeroStudio.Model.GuestBook GetModel(int G_Id)
        {
            Model.GuestBook model = null;
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from GuestBook where G_Id=@G_Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);
                OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read()) {
                    model = new ZeroStudio.Model.GuestBook();
                    model.G_Id = G_Id;
                    model.G_Title = sdr["G_Title"] == System.DBNull.Value ? "" : (string)sdr["G_Title"];
                    model.G_Username = sdr["G_Username"] == System.DBNull.Value ? "" : (string)sdr["G_Username"];
                    model.G_Email = sdr["G_Email"] == System.DBNull.Value ? "" : (string)sdr["G_Email"];
                    model.G_Content = sdr["G_Content"] == System.DBNull.Value ? "" : (string)sdr["G_Content"];
                    model.G_Datetime = (DateTime)sdr["G_Datetime"];
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
            strSql.Append("select G_Id,G_Title,G_Username,G_Email,G_Content,G_Datetime ");
            strSql.Append(" FROM GuestBook ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by G_ID desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法
    }
}
