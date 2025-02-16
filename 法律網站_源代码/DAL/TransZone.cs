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
    public partial class TransZone
    {


        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from TranszoneType");
            sql.Append(" where NC_ClassName='" + model.ClassName + "'");
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
        public bool Exists(Model.guoclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from TranszoneType");
            sql.Append(" where NC_ClassName='" + model.ClassName + "'");
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

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int Add(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TranszoneType(");
            sql.Append("NC_ClassName,NC_Sort)");
            sql.Append(" values (");
            sql.Append("@NC_ClassName,@NC_Sort)");
            SqlParameter[] parameters = {
                new SqlParameter("@NC_ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@NC_Sort",SqlDbType.Int,4)};
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.Sort;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));

            return i;
            //if (i > 0)
            //    return true;
            //else
            //    return false;
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int Add(Model.guoclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TranszoneType(");
            sql.Append("NC_ClassName,NC_Sort)");
            sql.Append(" values (");
            sql.Append("@NC_ClassName,@NC_Sort)");
            SqlParameter[] parameters = {
                new SqlParameter("@NC_ClassName",SqlDbType.NVarChar,50),
                new SqlParameter("@NC_Sort",SqlDbType.Int,4)};
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.Sort;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(), parameters));

            return i;
            //if (i > 0)
            //    return true;
            //else
            //    return false;
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TranszoneType Set ");
            sql.Append("NC_ClassName=N'" + model.ClassName + "',");
            sql.Append("NC_Sort=" + model.Sort + " ");
            sql.Append(" where NC_Id=" + model.Id + "");

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
        public bool Update(Model.guoclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TranszoneType Set ");
            sql.Append("NC_ClassName=N'" + model.ClassName + "',");
            sql.Append("NC_Sort=" + model.Sort + " ");
            sql.Append(" where NC_Id=" + model.Id + "");

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString()));
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
        public bool Delete(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TranszoneType ");
            sql.Append(" where NC_Id=@NC_Id");
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
            sql.Append("delete from TranszoneType ");
            sql.Append(" where NC_Id=@NC_Id");
            SqlParameter[] parameters ={
                new SqlParameter("@NC_Id",SqlDbType.Int,4)};
            parameters[0].Value = id;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TranszoneType order by NC_Sort");
            return DbHelperOledb.Query(sql.ToString());
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll(Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TranszoneType order by NC_Sort");
            return new DbHelperOledbP(sw).Query(sql.ToString());
        }
        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(nc_Id) as MaxKey  from TranszoneType";
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
            string sql = "select count(nc_Id) as MaxKey  from TranszoneType";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TranszoneType");           
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by nc_Sort");
            return DbHelperOledb.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TranszoneType");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by nc_Sort");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.guoclass GetModel(int nc_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TranszoneType ");
            strSql.Append(" where nc_Id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.guoclass model = new Model.guoclass();
            DataSet ds = DbHelperOledb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["nc_Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["nc_Id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["nc_ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["nc_Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["nc_Sort"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.guoclass GetModel(int nc_Id,Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TranszoneType ");
            strSql.Append(" where nc_Id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.guoclass model = new Model.guoclass();
            DataSet ds = new DbHelperOledbP(sw).Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["nc_Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["nc_Id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["nc_ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["nc_Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["nc_Sort"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.guoclass GetModel_where(string where)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TranszoneType where " + where);


            Model.guoclass model = new Model.guoclass();
            DataSet ds = DbHelperOledb.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["nc_Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["nc_Id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["nc_ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["nc_Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["nc_Sort"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.guoclass GetModel_where(string where,Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TranszoneType where " + where);


            Model.guoclass model = new Model.guoclass();
            DataSet ds = new DbHelperOledbP(sw).Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["nc_Id"].ToString() != "")
                {
                    model.Id = int.Parse(ds.Tables[0].Rows[0]["nc_Id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["nc_ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["nc_Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["nc_Sort"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        //////////////////////////////以下 翻译领域内容

        /// <summary>
        /// 返回记录总数
        /// </summary>
        public int CountNew(string where)
        {
            StringBuilder sql = new StringBuilder();
            if (string.IsNullOrEmpty(where))
            {
                sql.Append("Select count(1) from TransZone");
            }
            else
            {
                sql.Append("select count(1) from TransZone where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        /// <summary>
        /// 返回记录总数
        /// </summary>
        public int CountNew(string where,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            if (string.IsNullOrEmpty(where))
            {
                sql.Append("Select count(1) from TransZone");
            }
            else
            {
                sql.Append("select count(1) from TransZone where " + where);
            }
            return Convert.ToInt32(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()));
        }
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool ExistsNew(Model.newsdata model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from TransZone");
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
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool ExistsNew(Model.newsdata model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from TransZone");
            sql.Append(" where D_Title='" + model.D_Title + "'");
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
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllNew()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TransZone order by D_ID");
            return DbHelperOledb.Query(sql.ToString());
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllNew(Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TransZone order by D_ID");
            return new DbHelperOledbP(sw).Query(sql.ToString());
        }
        public int GetMaxSortKeyNew(string strWhere)
        {
            string sql = "select count(D_ID) as MaxKey  from TransZone";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        public int GetMaxSortKeyNew(string strWhere,Model.SubWeb sw)
        {
            string sql = "select count(D_ID) as MaxKey  from TransZone";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }

        public DataSet GetListByClassNew(string strWhere, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName  FROM TransZone t1 ");
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
            return DbHelperOledb.Query(strSql.ToString());
        }
        public DataSet GetListByClassNew(string strWhere, string orderby,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName  FROM TransZone t1 ");
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
        public DataSet GetListNew(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName FROM TransZone t1 ");
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
        public DataSet GetListNew(string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select D_ID,D_Title,OrderID,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName FROM TransZone t1 ");
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
        public DataSet GetList_topNew(int num, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " D_ID,D_Title,OrderID,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName FROM TransZone t1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by D_ID desc");
            return DbHelperOledb.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_topNew(int num, string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " D_ID,D_Title,OrderID,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName FROM TransZone t1  ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by D_ID desc");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }

        public void UpdateStateNew(int P_Id, int state)
        {
            string sql = "update TransZone set D_Recycle=" + state + " where D_ID=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);

        }
        public void UpdateStateNew(int P_Id, int state,Model.SubWeb sw)
        {
            string sql = "update TransZone set D_Recycle=" + state + " where D_ID=" + P_Id;
            new DbHelperOledbP(sw).ExecuteSql(sql);

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModelNew(int P_ID)
        {
            Model.newsdata model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from TransZone where D_ID=@P_ID";
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
        public Model.newsdata GetModelNew(int P_ID,Model.SubWeb sw)
        {
            Model.newsdata model = null;
            using (SqlConnection conn = new SqlConnection(new PubConstant().GetString(sw)))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from TransZone where D_ID=@P_ID";
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
        public void UpdaetSortKeyNew(int P_Id, int sortkey)
        {
            string sql = "update TransZone set OrderID=" + sortkey + " where D_ID=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
        }
        public void UpdaetSortKeyNew(int P_Id, int sortkey,Model.SubWeb sw)
        {
            string sql = "update TransZone set OrderID=" + sortkey + " where D_ID=" + P_Id;
            new DbHelperOledbP(sw).ExecuteSql(sql);
        }

        public int CountByClassNew(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from TransZone ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        public int CountByClassNew(string where,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from TransZone ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()));
        }

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        //public void Add(Model.newsdata model)
        //{
        //    using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        //string sql = "insert into newsdata(D_ClassID,D_Title,D_Time,D_Editor,D_Recycle,D_Description,D_Keyword,OrderID) " +
        //        //    "values(@D_ClassID,@D_Title,@D_Time,@D_Editor,@D_Recycle,@D_Description,@D_Keyword,@OrderID)";

        //        string sql = "insert into newsdata(D_ClassID,D_Title,D_Time,D_Editor,D_Recycle,D_Description,D_Keyword,OrderID) " +
        //            "values("+model.D_ClassID+",'"+model.D_Title+"','"+model.D_Time+"','"+model.D_Editor+"',"+model.D_Recycle+",'"+model.D_Description+"','"+ model.D_Keyword+"',"+model.OrderID+")";

        //        OleDbCommand cmd = new OleDbCommand(sql, conn);
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
        public bool AddNew(Model.newsdata model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TransZone(");
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
        public bool AddNew(Model.newsdata model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TransZone(");
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
        public bool UpdateNew(Model.newsdata model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TransZone Set ");
            sql.Append("D_ClassID=" + model.D_ClassID + ",");
            sql.Append("D_Title='" + model.D_Title + "', ");
            sql.Append("D_Editor='" + model.D_Editor + "', ");
            sql.Append("D_Keyword='" + model.D_Keyword + "',");
            sql.Append("D_Description='" + model.D_Description + "', ");
            sql.Append("D_Content='" + model.D_Content + "' ");
            sql.Append(" where D_ID=" + model.D_ID + "");

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
        public bool UpdateNew(Model.newsdata model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TransZone Set ");
            sql.Append("D_ClassID=" + model.D_ClassID + ",");
            sql.Append("D_Title='" + model.D_Title + "', ");
            sql.Append("D_Editor='" + model.D_Editor + "', ");
            sql.Append("D_Keyword='" + model.D_Keyword + "',");
            sql.Append("D_Description='" + model.D_Description + "', ");
            sql.Append("D_Content='" + model.D_Content + "' ");
            sql.Append(" where D_ID=" + model.D_ID + "");

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改点击次数
        /// </summary>
        /// <param name="id"></param>
        public void Update_clickNew(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TransZone set ");
            strSql.Append("D_Count=D_Count+1");
            strSql.Append(" where D_ID=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
                                        
                                        };
            parameters[0].Value = id;
            DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
        }
        /// <summary>
        /// 修改点击次数
        /// </summary>
        /// <param name="id"></param>
        public void Update_clickNew(int id,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update TransZone set ");
            strSql.Append("D_Count=D_Count+1");
            strSql.Append(" where D_ID=@id ");

            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
                                        
                                        };
            parameters[0].Value = id;
            new DbHelperOledbP(sw).ExecuteSql(strSql.ToString(), parameters);
        }

        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public void Update(Model.newsdata model)
        //{
        //    using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        string sql = "update newsdata set ClassName=@ClassName,username=@username,ParentID=@ParentID,C_show=@C_show,D_Content=@D_Content,D_Keyword=@D_Keyword,D_Description=@D_Description where classid=@P_ID";
        //        OleDbCommand cmd = new OleDbCommand(sql, conn);
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
        //    OleDbParameter[] parameters = {
        //        new OleDbParameter("@ClassName",OleDbType.VarChar,50),
        //        new OleDbParameter("@OrderID",OleDbType.Integer,4)};
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
        public bool DeleteNew(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TransZone ");
            sql.Append(" where D_ID=@NC_Id");
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
        public bool DeleteNew(int id,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TransZone ");
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

        public DataTable GetTop5CloseNews(string keys, string title)
        {
            string sql = "select top 5 * from TransZone where ";
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
        public DataTable GetTop5CloseNews(string keys, string title,Model.SubWeb sw)
        {
            string sql = "select top 5 * from TransZone where ";
            if (keys != "")
            {
                sql += keys;
            }
            if (title != "")
            {
                sql += " and D_Title <> '" + title + "'";
            }
            sql += " order by OrderID desc";
            DataTable dt =new  DbHelperOledbP(sw).GetDataTable(sql.ToString());
            return dt;
        }
    }
}
