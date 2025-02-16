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
    public class NewsClass
    {
        ///// <summary>
        ///// 返回记录总数
        ///// </summary>
        //public int Count(string where)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    if (string.IsNullOrEmpty(where))
        //    {
        //        sql.Append("Select count(1) from NewsClass");
        //    }
        //    else
        //    {
        //        sql.Append("select count(1) from NewsClass where " + where);
        //    }
        //    return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        //}

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.NewsClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from NewsClass");
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
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.NewsClass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from NewsClass");
            sql.Append(" where ClassName='" + model.ClassName + "'");
            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ///// <summary>
        ///// 得到所有数据列表
        ///// </summary>
        ///// <returns></returns>
        //public DataSet GetAll()
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("Select * from NewsClass order by OrderID");
        //    return DbHelperOledb.Query(sql.ToString());
        //}

        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(classid) as MaxKey  from NewsClass";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        public int GetMaxSortKey(string strWhere,Model.SubWeb sw)
        {
            string sql = "select count(classid) as MaxKey  from NewsClass";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        //public DataSet GetListByClass(string strWhere, string orderby)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select *,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname  FROM NewsClass t1 ");
        //    if (strWhere.Trim() != "")
        //    {
        //        strSql.Append(" where " + strWhere);
        //    }
        //    if (!string.IsNullOrEmpty(orderby))
        //    {
        //        strSql.Append(" order by " + orderby);
        //    }
        //    else
        //    {
        //        strSql.Append(" order by classid desc");
        //    }
        //    return DbHelperOledb.Query(strSql.ToString());
        //}


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ClassId,ClassName,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname, NC_ArtList_Title, NC_ArtList_Description FROM NewsClass t1 ");
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
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select classid,ClassName,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname, NC_ArtList_Title, NC_ArtList_Description FROM NewsClass t1 ");

            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by OrderID");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " classid,ClassName,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname, NC_ArtList_Title, NC_ArtList_Description FROM NewsClass t1  ");
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
        public DataSet GetList_top(int num, string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " classid,ClassName,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname, NC_ArtList_Title, NC_ArtList_Description FROM NewsClass t1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by OrderID asc");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }

        //public void UpdateState(int P_Id, int state)
        //{
        //    string sql = "update NewsClass set P_State=" + state + " where classid=" + P_Id;
        //    DbHelperOledb.ExecuteSql(sql);

        //}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.NewsClass GetModel(int P_ID)
        {
            Model.NewsClass model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from NewsClass where classid=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.NewsClass();
                    model.classid = P_ID;
                    model.ClassName = sdr["ClassName"] == System.DBNull.Value ? "" : (string)sdr["ClassName"];
                    model.OrderID = (int)sdr["OrderID"];
                    model.Keywords = ((sdr["Keywords"] == DBNull.Value) ? "" : ((string)sdr["Keywords"]));
                    model.Description = ((sdr["Description"] == DBNull.Value) ? "" : ((string)sdr["Description"]));
                    model.ArtListTitle = ((sdr["NC_ArtList_Title"] == DBNull.Value) ? "" : ((string)sdr["NC_ArtList_Title"]));
                    model.ArtListDescription = ((sdr["NC_ArtList_Description"] == DBNull.Value) ? "" : ((string)sdr["NC_ArtList_Description"]));
                }
                sdr.Close();
            }
            return model;

        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.NewsClass GetModel(int P_ID,Model.SubWeb sw)
        {
            Model.NewsClass model = null;
            using (SqlConnection conn = new SqlConnection(new PubConstant().GetString(sw)))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from NewsClass where classid=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.NewsClass();
                    model.classid = P_ID;
                    model.ClassName = sdr["ClassName"] == System.DBNull.Value ? "" : (string)sdr["ClassName"];
                    model.OrderID = (int)sdr["OrderID"];
                    model.Keywords = ((sdr["Keywords"] == DBNull.Value) ? "" : ((string)sdr["Keywords"]));
                    model.Description = ((sdr["Description"] == DBNull.Value) ? "" : ((string)sdr["Description"]));
                    model.ArtListTitle = ((sdr["NC_ArtList_Title"] == DBNull.Value) ? "" : ((string)sdr["NC_ArtList_Title"]));
                    model.ArtListDescription = ((sdr["NC_ArtList_Description"] == DBNull.Value) ? "" : ((string)sdr["NC_ArtList_Description"]));
                }
                sdr.Close();
            }
            return model;

        }
        //public void UpdaetSortKey(int P_Id, int sortkey)
        //{
        //    string sql = "update NewsClass set OrderID=" + sortkey + " where classid=" + P_Id;
        //    DbHelperOledb.ExecuteSql(sql);
        //}

        //public int CountByClass(string where)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("select count(1) from NewsClass ");
        //    if (!string.IsNullOrEmpty(where))
        //    {
        //        sql.Append(" where " + where);
        //    }
        //    return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        //}

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        //public void Add(Model.NewsClass model)
        //{
        //    using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        string sql = "insert into NewsClass(ClassName,username,ParentID,OrderID,C_show,D_Content,D_Keyword,D_Description,P_State) " +
        //            "values(@ClassName,@username,@ParentID,@OrderID,@C_show,@D_Content,@D_Keyword,@D_Description,@P_State)";
        //        SqlCommand cmd = new SqlCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
        //        cmd.Parameters.AddWithValue("@username", model.username);
        //        cmd.Parameters.AddWithValue("@ParentID", model.ParentID);
        //        cmd.Parameters.AddWithValue("@OrderID", model.OrderID);
        //        cmd.Parameters.AddWithValue("@C_show", model.C_show);
        //        cmd.Parameters.AddWithValue("@D_Content", model.D_Content);
        //        cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
        //        cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
        //        cmd.Parameters.AddWithValue("@P_State", model.P_State);
        //        cmd.ExecuteNonQuery();
        //    }


        //}


        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public void Update(Model.NewsClass model)
        //{
        //    using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        string sql = "update NewsClass set ClassName=@ClassName,username=@username,ParentID=@ParentID,C_show=@C_show,D_Content=@D_Content,D_Keyword=@D_Keyword,D_Description=@D_Description where classid=@P_ID";
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

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool AddSmall(Model.NewsClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into NewsClass(");
            sql.Append("ClassName,OrderID,ParentID,Keywords,Description,NC_ArtList_Title,NC_ArtList_Description)");
            sql.Append(" values (");
            sql.Append("@ClassName,@OrderID,@ParentID,@Keyword,@Description,@NC_ArtList_Title,@NC_ArtList_Description)");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@OrderID",SqlDbType.Int,4),
                new SqlParameter("@ParentID",SqlDbType.Int,4),
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 500),
                new SqlParameter("@Description", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Title", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Description", SqlDbType.NVarChar, 500)
            };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.OrderID;
            parameters[2].Value = model.ParentID;
            parameters[3].Value = model.Keywords;
            parameters[4].Value = model.Description;
            parameters[5].Value = model.ArtListTitle;
            parameters[6].Value = model.ArtListDescription;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool AddSmall(Model.NewsClass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into NewsClass(");
            sql.Append("ClassName,OrderID,ParentID,Keywords,Description,NC_ArtList_Title,NC_ArtList_Description)");
            sql.Append(" values (");
            sql.Append("@ClassName,@OrderID,@ParentID,@Keyword,@Description,@NC_ArtList_Title,@NC_ArtList_Description)");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@OrderID",SqlDbType.Int,4),
                new SqlParameter("@ParentID",SqlDbType.Int,4),
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 500),
                new SqlParameter("@Description", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Title", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Description", SqlDbType.NVarChar, 500)
            };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.OrderID;
            parameters[2].Value = model.ParentID;
            parameters[3].Value = model.Keywords;
            parameters[4].Value = model.Description;
            parameters[5].Value = model.ArtListTitle;
            parameters[6].Value = model.ArtListDescription;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(), parameters));
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
        public bool UpdateSmall(Model.NewsClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update NewsClass Set ");
            sql.Append("ClassName=@ClassName,");
            sql.Append("OrderID=@OrderID, ");
            sql.Append("Keywords=@Keyword,");
            sql.Append("Description=@Description,");
            sql.Append("NC_ArtList_Title=@NC_ArtList_Title, ");
            sql.Append("NC_ArtList_Description=@NC_ArtList_Description ");
            sql.Append(" where classid=@classid");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@OrderID",SqlDbType.Int,4),
                new SqlParameter("@classid",SqlDbType.Int,4),
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 500),
                new SqlParameter("@Description", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Title", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Description", SqlDbType.NVarChar, 500)
            };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.OrderID;
            parameters[2].Value = model.classid;
            parameters[3].Value = model.Keywords;
            parameters[4].Value = model.Description;
            parameters[5].Value = model.ArtListTitle;
            parameters[6].Value = model.ArtListDescription;
            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
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
        public bool UpdateSmall(Model.NewsClass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update NewsClass Set ");
            sql.Append("ClassName=@ClassName,");
            sql.Append("OrderID=@OrderID, ");
            sql.Append("Keywords=@Keyword,");
            sql.Append("Description=@Description,");
            sql.Append("NC_ArtList_Title=@NC_ArtList_Title, ");
            sql.Append("NC_ArtList_Description=@NC_ArtList_Description ");
            sql.Append(" where classid=@classid");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@OrderID",SqlDbType.Int,4),
                new SqlParameter("@classid",SqlDbType.Int,4),
                new SqlParameter("@Keyword", SqlDbType.NVarChar, 500),
                new SqlParameter("@Description", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Title", SqlDbType.NVarChar, 500),
                new SqlParameter("@NC_ArtList_Description", SqlDbType.NVarChar, 500)
            };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.OrderID;
            parameters[2].Value = model.classid;
            parameters[3].Value = model.Keywords;
            parameters[4].Value = model.Description;
            parameters[5].Value = model.ArtListTitle;
            parameters[6].Value = model.ArtListDescription;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(),parameters));
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
        //    strSql.Append("delete from NewsClass ");
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
            sql.Append("delete from NewsClass ");
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
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from NewsClass ");
            sql.Append(" where classid=@NC_Id");
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
