using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBUtility;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DAL
{
    public class PageClass
    {

        /// <summary>
        /// 返回记录总数
        /// </summary>
        public int Count(string where)
        {
            StringBuilder sql = new StringBuilder();
            if (string.IsNullOrEmpty(where))
            {
                sql.Append("Select count(1) from PageClass");
            }
            else
            {
                sql.Append("select count(1) from PageClass where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.PageClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from PageClass");
            sql.Append(" where ClassName='" + model.ClassName + "'");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from PageClass order by OrderID");
            return DbHelperOledb.Query(sql.ToString());
        }

        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(classid) as MaxKey  from PageClass";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }

        public DataSet GetListByClass(string strWhere, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select ClassName from PageClass t2 where t2.classid=t1.ParentID) as parentclassname  FROM PageClass t1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            if (!string.IsNullOrEmpty(orderby))
            {
                strSql.Append(" order by " + orderby);
            }
            else
            {
                strSql.Append(" order by classid desc");
            }
            return DbHelperOledb.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select classid,ClassName,OrderID,(select ClassName from PageClass t2 where t2.classid=t1.ParentID) as parentclassname FROM PageClass t1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by OrderID asc");
            return DbHelperOledb.Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num,string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top "+num+" classid,ClassName FROM PageClass  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by OrderID asc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        public void UpdateState(int P_Id, int state)
        {
            string sql = "update PageClass set P_State=" + state + " where classid=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
            
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.PageClass GetModel(int P_ID)
        {
            Model.PageClass model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from PageClass where classid=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.PageClass();
                    model.classid = P_ID;
                    model.ClassName = sdr["ClassName"] == System.DBNull.Value ? "" : (string)sdr["ClassName"];
                    model.username = sdr["username"] == System.DBNull.Value ? "" : (string)sdr["username"];
                    model.ParentID = (int)sdr["ParentID"];
                    model.OrderID = (int)sdr["OrderID"];
                    model.C_show = Convert.ToBoolean(sdr["C_show"]);

                    model.D_Content = sdr["D_Content"] == System.DBNull.Value ? "" : (string)sdr["D_Content"];
                    model.D_Keyword = sdr["D_Keyword"] == System.DBNull.Value ? "" : (string)sdr["D_Keyword"];
                    model.D_Description = sdr["D_Description"] == System.DBNull.Value ? "" : (string)sdr["D_Description"];

                    if (sdr["P_State"].ToString() != "")
                    {
                        model.P_State =Convert.ToInt32(sdr["P_State"].ToString());
                    }

                    if (sdr["addtime"].ToString() != "")
                    {
                        model.addtime = Convert.ToDateTime(sdr["addtime"].ToString());
                    }

                    if (sdr["D_Count"].ToString() != "")
                    {
                        model.D_Count = Convert.ToInt32(sdr["D_Count"].ToString());
                    }

                    model.Title = sdr["Title"] == System.DBNull.Value ? "" : (string)sdr["Title"];
                }
                sdr.Close();
            }
            return model;

        }

        public void UpdaetSortKey(int P_Id, int sortkey)
        {
            string sql = "update PageClass set OrderID=" + sortkey + " where classid=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
        }

        /// <summary>
        /// 修改点击次数
        /// </summary>
        /// <param name="id"></param>
        public void Update_click(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PageClass set ");
            strSql.Append("D_Count=D_Count+1");
            strSql.Append(" where classid=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
                                        
                                        };
            parameters[0].Value = id;
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }

        public int CountByClass(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from PageClass ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.PageClass model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into PageClass(ClassName,username,ParentID,OrderID,C_show,D_Content,D_Keyword,D_Description,P_State,Title) " +
                    "values(@ClassName,@username,@ParentID,@OrderID,@C_show,@D_Content,@D_Keyword,@D_Description,@P_State,@Title)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
                cmd.Parameters.AddWithValue("@username", model.username);
                cmd.Parameters.AddWithValue("@ParentID", model.ParentID);
                cmd.Parameters.AddWithValue("@OrderID", model.OrderID);
                cmd.Parameters.AddWithValue("@C_show", model.C_show);
                cmd.Parameters.AddWithValue("@D_Content", model.D_Content);
                cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
                cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
                cmd.Parameters.AddWithValue("@P_State", model.P_State);
                cmd.Parameters.AddWithValue("@Title", model.Title);
                cmd.ExecuteNonQuery();
            }

            
        }


        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.PageClass model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update PageClass set ClassName=@ClassName,username=@username,ParentID=@ParentID,C_show=@C_show,D_Content=@D_Content,D_Keyword=@D_Keyword,D_Description=@D_Description,Title=@Title where classid=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
                cmd.Parameters.AddWithValue("@username", model.username);
                cmd.Parameters.AddWithValue("@ParentID", model.ParentID);
                cmd.Parameters.AddWithValue("@C_show", model.C_show);
                cmd.Parameters.AddWithValue("@D_Content", model.D_Content);
                cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
                cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
                cmd.Parameters.AddWithValue("@Title", model.Title);
                cmd.Parameters.AddWithValue("@P_ID", model.classid);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool AddSmall(Model.PageClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into PageClass(");
            sql.Append("ClassName,OrderID,ParentID)");
            sql.Append(" values (");
            sql.Append("@ClassName,@OrderID,@ParentID)");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@OrderID",SqlDbType.Int,4),
                new SqlParameter("@ParentID",SqlDbType.Int,4)
                                          };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.OrderID;
            parameters[2].Value = model.ParentID;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSmall(Model.PageClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update PageClass Set ");
            sql.Append("ClassName=N'" + model.ClassName + "',");
            sql.Append("OrderID=" + model.OrderID + ", ");
            sql.Append("ParentID=" + model.ParentID + " ");
            sql.Append(" where classid=" + model.classid + "");

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        ///// <summary>
        ///// 删除一条数据
        ///// </summary>
        //public void Delete(int P_ID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("delete from PageClass ");
        //    strSql.Append(" where classid=" + P_ID + " ");
        //    DbHelperOledb.ExecuteSql(strSql.ToString());
        //}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from PageClass ");
            sql.Append(" where classid=@NC_Id");
            SqlParameter[] parameters ={
                new SqlParameter("@NC_Id",SqlDbType.Int,4)};
            parameters[0].Value = id;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }


    }
}
