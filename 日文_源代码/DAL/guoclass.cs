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
    public class guoclass
    {

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from guoclass");
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
        public bool Exists(Model.guoclass model, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from guoclass");
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
            sql.Append("insert into guoclass(");
            sql.Append("NC_ClassName,NC_Sort)");
            sql.Append(" values (");
            sql.Append("@NC_ClassName,@NC_Sort)");
            SqlParameter[] parameters = {
                new SqlParameter("@NC_ClassName", SqlDbType.NVarChar,50),
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
        public int Add(Model.guoclass model, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into guoclass(");
            sql.Append("NC_ClassName,NC_Sort)");
            sql.Append(" values (");
            sql.Append("@NC_ClassName,@NC_Sort)");
            SqlParameter[] parameters = {
                new SqlParameter("@NC_ClassName", SqlDbType.NVarChar,50),
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
            sql.Append("Update guoclass Set ");
            sql.Append("NC_ClassName='" + model.ClassName + "',");
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
        public bool Update(Model.guoclass model, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update guoclass Set ");
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
            sql.Append("delete from guoclass ");
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
        public bool Delete(int id, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from guoclass ");
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
            sql.Append("Select * from guoclass order by NC_Sort");
            return DbHelperOledb.Query(sql.ToString());
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll(Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from guoclass order by NC_Sort");
            return new DbHelperOledbP(sw).Query(sql.ToString());
        }
        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(nc_Id) as MaxKey  from guoclass";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        public int GetMaxSortKey(string strWhere, Model.SubWeb sw)
        {
            string sql = "select count(nc_Id) as MaxKey  from guoclass";
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
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort ");
            strSql.Append(" from guoclass ");
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
        public DataSet GetList(string strWhere, Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort ");
            strSql.Append(" from guoclass ");
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
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from guoclass ");
            strSql.Append(" where nc_Id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.guoclass model = new Model.guoclass();
            DataSet ds = DbHelperOledb.Query(strSql.ToString(),parameters);
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
        public Model.guoclass GetModel(int nc_Id, Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from guoclass ");
            strSql.Append(" where nc_Id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.guoclass model = new Model.guoclass();
            DataSet ds = new DbHelperOledbP(sw).Query(strSql.ToString(),parameters);
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
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from guoclass where " + where);


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
        public Model.guoclass GetModel_where(string where, Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from guoclass where " + where);


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
    }
}
