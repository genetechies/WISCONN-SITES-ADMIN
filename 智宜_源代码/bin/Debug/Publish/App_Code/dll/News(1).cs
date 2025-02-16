using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ZeroStudio.DBUtility;

namespace ZeroStudio.DAL
{
    public class News
    {
        public News()
        { }
        #region  成员方法


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int N_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from News");
            strSql.Append(" where N_Id=" + N_Id + " ");
            return DbHelperOledb.Exists(strSql.ToString());
        }

        /// <summary>
        /// 返回记录总数
        /// </summary>
        public int Count(string where)
        {
            StringBuilder sql = new StringBuilder();
            if (string.IsNullOrEmpty(where)) {
                sql.Append("Select count(1) from News");
            } else {
                sql.Append("select count(1) from News where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.News model)
        {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into News(N_Title,N_ClassID,N_Content,N_DateTime,N_Author,N_Source,N_Keyword,N_Description,N_HitNum,N_State,N_Input,N_IsShow,N_Product) " +
                    "values(@N_Title,@N_ClassID,@N_Content,@N_DateTime,@N_Author,@N_Source,@N_Keyword,@N_Description,@N_HitNum,@N_State,@N_Input,@N_IsShow,@N_Product)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@N_Title", model.N_title);
                cmd.Parameters.AddWithValue("@N_ClassID", model.N_ClassID);
                cmd.Parameters.AddWithValue("@N_Content", model.N_Content);
                cmd.Parameters.AddWithValue("@N_DateTime", model.N_DateTime);
                cmd.Parameters.AddWithValue("@N_Author", model.N_Author);
                cmd.Parameters.AddWithValue("@N_Source", model.N_Source);
                cmd.Parameters.AddWithValue("@N_Keyword", model.N_Keyword);
                cmd.Parameters.AddWithValue("@N_Description", model.N_Description);
                cmd.Parameters.AddWithValue("@N_HitNum", model.N_HitNum);
                cmd.Parameters.AddWithValue("@N_State", model.N_State);
                cmd.Parameters.AddWithValue("@N_Input", model.N_Input);
                cmd.Parameters.AddWithValue("@N_IsShow", model.N_IsShow);
                cmd.Parameters.AddWithValue("@N_Product", model.N_Product);
                cmd.ExecuteNonQuery();
            }

        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.News model)
        {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update News set N_Title=@N_Title,N_ClassID=@N_ClassID,N_Content=@N_Content,N_Author=@N_Author,N_Source=@N_Source,N_Keyword=@N_Keyword,N_Description=@N_Description,N_HitNum=@N_HitNum,N_State=@N_State,N_Input=@N_Input,N_IsShow=@N_IsShow,N_Product=@N_Product where N_Id=@N_Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@N_Title", model.N_title);
                cmd.Parameters.AddWithValue("@N_ClassID", model.N_ClassID);
                cmd.Parameters.AddWithValue("@N_Content", model.N_Content);
                cmd.Parameters.AddWithValue("@N_Author", model.N_Author);
                cmd.Parameters.AddWithValue("@N_Source", model.N_Source);
                cmd.Parameters.AddWithValue("@N_Keyword", model.N_Keyword);
                cmd.Parameters.AddWithValue("@N_Description", model.N_Description);
                cmd.Parameters.AddWithValue("@N_HitNum", model.N_HitNum);
                cmd.Parameters.AddWithValue("@N_State", model.N_State);
                cmd.Parameters.AddWithValue("@N_Input", model.N_Input);
                cmd.Parameters.AddWithValue("@N_IsShow", model.N_IsShow);
                cmd.Parameters.AddWithValue("@N_Product", model.N_Product);
                cmd.Parameters.AddWithValue("@N_Id", model.N_Id);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int N_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from News ");
            strSql.Append(" where N_Id=" + N_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }
        public void Delete(string where) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from News ");
            if (!string.IsNullOrEmpty(where)) {
                strSql.Append(" where " + where + " ");
                DbHelperOledb.ExecuteSql(strSql.ToString());
            }
        }
        public void UpdateState(int N_Id,int state) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update News set N_State=" + state);
            strSql.Append(" where N_Id=" + N_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());

        }
        public void UpdateHitNum(int N_Id, int num) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update News set N_HitNum=N_HitNum+" + num);
            strSql.Append(" where N_Id=" + N_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }
        /// <summary>
        /// 得到一個对象实体
        /// </summary>
        public ZeroStudio.Model.News GetModel(int N_Id)
        {
            Model.News model = null;
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from News where N_Id=@N_Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@N_Id", N_Id);
                OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read()) {
                    model = new ZeroStudio.Model.News();
                    model.N_Id = N_Id;
                    model.N_title = sdr["N_Title"] == System.DBNull.Value ? "" : (string)sdr["N_Title"];
                    model.N_ClassID = (int)sdr["N_ClassID"];
                    model.N_Content = sdr["N_Content"] == System.DBNull.Value ? "" : (string)sdr["N_Content"];
                    model.N_DateTime = (DateTime)sdr["N_DateTime"];
                    model.N_Author = sdr["N_Author"] == System.DBNull.Value ? "" : (string)sdr["N_Author"];
                    model.N_Source = sdr["N_Source"] == System.DBNull.Value ? "" : (string)sdr["N_Source"];
                    model.N_Keyword = sdr["N_Keyword"] == System.DBNull.Value ? "" : (string)sdr["N_Keyword"];
                    model.N_Description = sdr["N_Description"] == System.DBNull.Value ? "" : (string)sdr["N_Description"];
                    model.N_HitNum = (int)sdr["N_HitNum"];
                    model.N_Input = sdr["N_Input"] == System.DBNull.Value ? "" : (string)sdr["N_Input"];
                    model.N_State = (int)sdr["N_State"];
                    model.N_IsShow = (int)sdr["N_IsShow"];
                    model.N_Product = sdr["N_Product"] == System.DBNull.Value ? "" : (string)sdr["N_Product"];
                }
                sdr.Close();
            }
            return model;

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string orderby) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM News ");
            if (strWhere.Trim() != "") {
                strSql.Append(" where " + strWhere);
            }
            if (!string.IsNullOrEmpty(orderby)) {
                strSql.Append(" order by " + orderby);
            } else {
                strSql.Append(" order by N_Id");
            }
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 返回含类名的数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataSet GetList_ClassName(string strWhere)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select [News].*,[NewsClass].NC_Classname ");
            sql.Append(" from [News] inner join [NewsClass] ");
            sql.Append(" on [News].N_ClassID=[NewsClass].NC_Id ");
            if (strWhere.Trim() != "")
            {
                sql.Append(" where " + strWhere);
            }
            sql.Append(" order by [News].N_id desc");
            return DbHelperOledb.Query(sql.ToString());
        }

        /*
        */

        #endregion  成员方法
    }
}
