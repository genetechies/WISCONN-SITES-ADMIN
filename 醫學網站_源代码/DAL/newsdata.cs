using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtility;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace DAL
{
    public class newsdata
    {
        /// <summary>
        /// 返回记录总数
        /// </summary>
        public int Count(string where)
        {
            StringBuilder sql = new StringBuilder();
            if (string.IsNullOrEmpty(where))
            {
                sql.Append("Select count(1) from newsdata");
            }
            else
            {
                sql.Append("select count(1) from newsdata where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.newsdata model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from newsdata");
            sql.Append(" where D_Title='" + model.D_Title + "'");
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
            sql.Append("Select * from newsdata order by D_ID");
            return DbHelperOledb.Query(sql.ToString());
        }

        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(D_ID) as MaxKey  from newsdata";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }

        public DataSet GetListByClass(string strWhere, string orderby,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select ClassName from NewsClass t2 where t2.ClassID=t1.D_ClassID) as ClassName  FROM newsdata t1 ");
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
                strSql.Append(" order by D_ID desc");
            }
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select D_ID,D_Title,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.D_ClassID) as ClassName FROM newsdata t1 ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by OrderID");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " D_ID,D_Title,D_Time,D_Description,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.D_ClassID) as ClassName FROM newsdata t1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by D_ID desc");
            return DbHelperOledb.Query(strSql.ToString());
        }


        public void UpdateState(int P_Id, int state,Model.SubWeb sw)
        {
            string sql = "update newsdata set D_Recycle=" + state + " where D_ID=" + P_Id;
            new DbHelperOledbP(sw).ExecuteSql(sql);

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModel(int P_ID,Model.SubWeb sw)
        {
            Model.newsdata model = null;
            using (SqlConnection conn = new SqlConnection(new PubConstant().GetString(sw)))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from newsdata where D_ID=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.newsdata();
                    if (sdr["D_ID"].ToString() != "")
                    {
                        model.D_ID = Convert.ToInt32(sdr["D_ID"].ToString());
                    }

                    if (sdr["D_ClassID"].ToString() != "")
                    {
                        model.D_ClassID = Convert.ToInt32(sdr["D_ClassID"].ToString());
                    }

                    model.D_Title = sdr["D_Title"] == System.DBNull.Value ? "" : (string)sdr["D_Title"];

                    if (sdr["D_Time"].ToString() != "")
                    {
                        model.D_Time = Convert.ToDateTime(sdr["D_Time"].ToString());
                    }

                    model.D_Author = sdr["D_Author"] == System.DBNull.Value ? "" : (string)sdr["D_Author"];
                    model.D_Source = sdr["D_Source"] == System.DBNull.Value ? "" : (string)sdr["D_Source"];
                    model.D_Content = sdr["D_Content"] == System.DBNull.Value ? "" : (string)sdr["D_Content"];
                    model.D_Picture = sdr["D_Picture"] == System.DBNull.Value ? "" : (string)sdr["D_Picture"];
                    model.D_Editor = sdr["D_Editor"] == System.DBNull.Value ? "" : (string)sdr["D_Editor"];
                    model.D_OriginalFileName = sdr["D_OriginalFileName"] == System.DBNull.Value ? "" : (string)sdr["D_OriginalFileName"];
                    model.D_SaveFileName = sdr["D_SaveFileName"] == System.DBNull.Value ? "" : (string)sdr["D_SaveFileName"];
                    model.D_SavePathFileName = sdr["D_SavePathFileName"] == System.DBNull.Value ? "" : (string)sdr["D_SavePathFileName"];
                    if (sdr["D_Num"].ToString() != "")
                    {
                        model.D_Num = Convert.ToInt32(sdr["D_Num"].ToString());
                    }

                    if (sdr["D_Count"].ToString() != "")
                    {
                        model.D_Count = Convert.ToInt32(sdr["D_Count"].ToString());
                    }

                    if (sdr["D_Recycle"].ToString() != "")
                    {
                        model.D_Recycle = Convert.ToInt32(sdr["D_Recycle"].ToString());
                    }

                    if (sdr["D_RecycleTime"].ToString() != "")
                    {
                        model.D_RecycleTime = Convert.ToDateTime(sdr["D_RecycleTime"].ToString());
                    }

                    model.D_Description = sdr["D_Description"] == System.DBNull.Value ? "" : (string)sdr["D_Description"];

                    model.D_Keyword = sdr["D_Keyword"] == System.DBNull.Value ? "" : (string)sdr["D_Keyword"];

                    if (sdr["OrderID"].ToString() != "")
                    {
                        model.OrderID = Convert.ToInt32(sdr["OrderID"].ToString());
                    }
                }
                sdr.Close();
            }
            return model;

        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModel(int P_ID)
        {
            Model.newsdata model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from newsdata where D_ID=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.newsdata();
                    if (sdr["D_ID"].ToString() != "")
                    {
                        model.D_ID = Convert.ToInt32(sdr["D_ID"].ToString());
                    }

                    if (sdr["D_ClassID"].ToString() != "")
                    {
                        model.D_ClassID = Convert.ToInt32(sdr["D_ClassID"].ToString());
                    }

                    model.D_Title = sdr["D_Title"] == System.DBNull.Value ? "" : (string)sdr["D_Title"];

                    if (sdr["D_Time"].ToString() != "")
                    {
                        model.D_Time = Convert.ToDateTime(sdr["D_Time"].ToString());
                    }

                    model.D_Author = sdr["D_Author"] == System.DBNull.Value ? "" : (string)sdr["D_Author"];
                    model.D_Source = sdr["D_Source"] == System.DBNull.Value ? "" : (string)sdr["D_Source"];
                    model.D_Content = sdr["D_Content"] == System.DBNull.Value ? "" : (string)sdr["D_Content"];
                    model.D_Picture = sdr["D_Picture"] == System.DBNull.Value ? "" : (string)sdr["D_Picture"];
                    model.D_Editor = sdr["D_Editor"] == System.DBNull.Value ? "" : (string)sdr["D_Editor"];
                    model.D_OriginalFileName = sdr["D_OriginalFileName"] == System.DBNull.Value ? "" : (string)sdr["D_OriginalFileName"];
                    model.D_SaveFileName = sdr["D_SaveFileName"] == System.DBNull.Value ? "" : (string)sdr["D_SaveFileName"];
                    model.D_SavePathFileName = sdr["D_SavePathFileName"] == System.DBNull.Value ? "" : (string)sdr["D_SavePathFileName"];
                    if (sdr["D_Num"].ToString() != "")
                    {
                        model.D_Num = Convert.ToInt32(sdr["D_Num"].ToString());
                    }

                    if (sdr["D_Count"].ToString() != "")
                    {
                        model.D_Count = Convert.ToInt32(sdr["D_Count"].ToString());
                    }

                    if (sdr["D_Recycle"].ToString() != "")
                    {
                        model.D_Recycle = Convert.ToInt32(sdr["D_Recycle"].ToString());
                    }

                    if (sdr["D_RecycleTime"].ToString() != "")
                    {
                        model.D_RecycleTime = Convert.ToDateTime(sdr["D_RecycleTime"].ToString());
                    }

                    model.D_Description = sdr["D_Description"] == System.DBNull.Value ? "" : (string)sdr["D_Description"];

                    model.D_Keyword = sdr["D_Keyword"] == System.DBNull.Value ? "" : (string)sdr["D_Keyword"];

                    if (sdr["OrderID"].ToString() != "")
                    {
                        model.OrderID = Convert.ToInt32(sdr["OrderID"].ToString());
                    }


                }
                sdr.Close();
            }
            return model;

        }
        public DataTable GetTop5CloseNews(string keys, string title)
        {
            string sql = "select top 5 * from newsdata where ";
            if (keys != "")
            {
                sql += keys;
            }
            if (title != "")
            {
                sql += " and D_Title <> '" + title + "'";
            }
            sql += " order by OrderID desc";
            DataTable dt = DbHelperOledb.GetDataTable(sql.ToString());
            return dt;
        }

        public void UpdaetSortKey(int P_Id, int sortkey)
        {
            string sql = "update newsdata set OrderID=" + sortkey + " where D_ID=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
        }

        public int CountByClass(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from newsdata ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        //public void Add(Model.newsdata model)
        //{
        //    using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        //string sql = "insert into newsdata(D_ClassID,D_Title,D_Time,D_Editor,D_Recycle,D_Description,D_Keyword,OrderID) " +
        //        //    "values(@D_ClassID,@D_Title,@D_Time,@D_Editor,@D_Recycle,@D_Description,@D_Keyword,@OrderID)";

        //        string sql = "insert into newsdata(D_ClassID,D_Title,D_Time,D_Editor,D_Recycle,D_Description,D_Keyword,OrderID) " +
        //            "values("+model.D_ClassID+",'"+model.D_Title+"','"+model.D_Time+"','"+model.D_Editor+"',"+model.D_Recycle+",'"+model.D_Description+"','"+ model.D_Keyword+"',"+model.OrderID+")";

        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        //cmd.Parameters.AddWithValue("@D_ClassID", model.D_ClassID);
        //        //cmd.Parameters.AddWithValue("@D_Title", model.D_Title);
        //        //cmd.Parameters.AddWithValue("@D_Time",model.D_Time);
        //        //cmd.Parameters.AddWithValue("@D_Editor", model.D_Editor);
        //        //cmd.Parameters.AddWithValue("@D_Recycle", model.D_Recycle);
        //        //cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
        //        //cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
        //        //cmd.Parameters.AddWithValue("@OrderID", model.OrderID);
        //        cmd.ExecuteNonQuery();
        //    }


        //}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.newsdata model,Model.SubWeb web)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into newsdata(");
            sql.Append("D_ClassID,D_Title,D_Time,D_Editor,D_Recycle,D_Description,D_Keyword,OrderID,D_Content)");
            sql.Append(" values (");
            sql.Append("@D_ClassID,@D_Title,@D_Time,@D_Editor,@D_Recycle,@D_Description,@D_Keyword,@OrderID,@D_Content)");
            SqlParameter[] parameters = {
                new SqlParameter("@D_ClassID",SqlDbType.Int,4),
                new SqlParameter("@D_Title",SqlDbType.NVarChar,200),
                new SqlParameter("@D_Time",SqlDbType.DateTime),
                new SqlParameter("@D_Editor",SqlDbType.NVarChar,50),
                new SqlParameter("@D_Recycle",SqlDbType.Int,4),
                new SqlParameter("@D_Description",SqlDbType.NVarChar),
                new SqlParameter("@D_Keyword",SqlDbType.NVarChar),
                new SqlParameter("@OrderID",SqlDbType.Int,4),
                new SqlParameter("@D_Content",SqlDbType.NVarChar)
                                          
                                          };
            parameters[0].Value = model.D_ClassID;
            parameters[1].Value = model.D_Title;
            parameters[2].Value = model.D_Time;
            parameters[3].Value = model.D_Editor;
            parameters[4].Value = model.D_Recycle;
            parameters[5].Value = model.D_Description;
            parameters[6].Value = model.D_Keyword;
            parameters[7].Value = model.OrderID;
            parameters[8].Value = model.D_Content;


            int i = Convert.ToInt32(new DbHelperOledbP(web).ExecuteSql(sql.ToString(), parameters));
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
        public bool Update(Model.newsdata model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update newsdata Set");
            sql.Append(" D_ClassID=@D_ClassID,D_Title=@D_Title,D_Editor=@D_Editor,D_Description=@D_Description,D_Keyword=@D_Keyword,D_Content=@D_Content");
            sql.Append(" where D_ID=@D_ID");            
            SqlParameter[] parameters = {
                new SqlParameter("@D_ClassID",SqlDbType.Int,4),
                new SqlParameter("@D_Title",SqlDbType.NVarChar,200),
                new SqlParameter("@D_Editor",SqlDbType.NVarChar,50),
                new SqlParameter("@D_Description",SqlDbType.NVarChar),
                new SqlParameter("@D_Keyword",SqlDbType.NVarChar),
                new SqlParameter("@D_Content",SqlDbType.NVarChar),
                new SqlParameter("@D_Id",SqlDbType.Int,4)
                                        };
            parameters[0].Value = model.D_ClassID;
            parameters[1].Value = model.D_Title;
            parameters[2].Value = model.D_Editor;
            parameters[3].Value = model.D_Description;
            parameters[4].Value = model.D_Keyword;            
            parameters[5].Value = model.D_Content;
            parameters[6].Value = model.D_ID;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改点击次数
        /// </summary>
        /// <param name="id"></param>
        public void Update_click(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update newsdata set ");
            strSql.Append("D_Count=D_Count+1");
            strSql.Append(" where D_ID=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
                                        
                                        };
            parameters[0].Value = id;
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }


        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public void Update(Model.newsdata model)
        //{
        //    using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        string sql = "update newsdata set ClassName=@ClassName,username=@username,ParentID=@ParentID,C_show=@C_show,D_Content=@D_Content,D_Keyword=@D_Keyword,D_Description=@D_Description where classid=@P_ID";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
        //        cmd.Parameters.AddWithValue("@username", model.username);
        //        cmd.Parameters.AddWithValue("@ParentID", model.ParentID);
        //        cmd.Parameters.AddWithValue("@C_show", model.C_show);
        //        cmd.Parameters.AddWithValue("@D_Content", model.D_Content);
        //        cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
        //        cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
        //        cmd.Parameters.AddWithValue("@P_ID", model.classid);
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        ///// <param name="model"></param>
        //public bool AddSmall(Model.newsdata model)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("insert into newsdata(");
        //    sql.Append("ClassName,OrderID)");
        //    sql.Append(" values (");
        //    sql.Append("@ClassName,@OrderID)");
        //    SqlParameter[] parameters = {
        //        new SqlParameter("@ClassName",SqlDbType.VarChar,50),
        //        new SqlParameter("@OrderID",SqlDbType.Integer,4)};
        //    parameters[0].Value = model.ClassName;
        //    parameters[1].Value = model.OrderID;

        //    int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
        //    if (i > 0)
        //        return true;
        //    else
        //        return false;
        //}

        ///// <summary>
        ///// 修改一条数据
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool UpdateSmall(Model.newsdata model)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("Update newsdata Set ");
        //    sql.Append("ClassName='" + model.ClassName + "',");
        //    sql.Append("OrderID=" + model.OrderID + " ");
        //    sql.Append(" where classid=" + model.classid + "");

        //    int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
        //    if (i > 0)
        //        return true;
        //    else
        //        return false;
        //}

        ///// <summary>
        ///// 删除一条数据
        ///// </summary>
        //public void Delete(int P_ID)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("delete from newsdata ");
        //    strSql.Append(" where classid=" + P_ID + " ");
        //    DbHelperOledb.ExecuteSql(strSql.ToString());
        //}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from newsdata ");
            sql.Append(" where D_ID=@NC_Id");
            SqlParameter[] parameters ={
                new SqlParameter("@NC_Id",SqlDbType.Int,4)};
            parameters[0].Value = id;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}
