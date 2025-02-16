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
    public class linyuclass
    {

        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select *,(select NC_ClassName from guoclass where guoclass.NC_Id=linyuclass.guoclassid) as guojianame from linyuclass order by Sort");
            return DbHelperOledb.Query(sql.ToString());
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll(Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select *,(select NC_ClassName from guoclass where guoclass.NC_Id=linyuclass.guoclassid) as guojianame from linyuclass order by Sort");
            return new DbHelperOledbP(sw).Query(sql.ToString());
        }
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.linyuclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from linyuclass");
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
        public bool Exists(Model.linyuclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from linyuclass");
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



        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int Add(Model.linyuclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into linyuclass(");
            sql.Append("ClassName,Sort,guoclassid)");
            sql.Append(" values (");
            sql.Append("@ClassName,@Sort,@guoclassid)");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,100),
                new SqlParameter("@Sort",SqlDbType.Int,4),
                new SqlParameter("@guoclassid",SqlDbType.Int,4),
                                          
                                          };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.Sort;
            parameters[2].Value = model.guoclassid;

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
        public int Add(Model.linyuclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into linyuclass(");
            sql.Append("ClassName,Sort,guoclassid)");
            sql.Append(" values (");
            sql.Append("@ClassName,@Sort,@guoclassid)");
            SqlParameter[] parameters = {
                new SqlParameter("@ClassName",SqlDbType.NVarChar,100),
                new SqlParameter("@Sort",SqlDbType.Int,4),
                new SqlParameter("@guoclassid",SqlDbType.Int,4),
                                          
                                          };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.Sort;
            parameters[2].Value = model.guoclassid;

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
        public bool Update(Model.linyuclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update linyuclass Set ");
            sql.Append("ClassName=N'" + model.ClassName + "',");
            sql.Append("Sort=" + model.Sort + ",");
            sql.Append("guoclassid=" + model.guoclassid + " ");
            sql.Append(" where id=" + model.id + "");

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString()));
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
        public bool Update(Model.linyuclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update linyuclass Set ");
            sql.Append("ClassName=N'" + model.ClassName + "',");
            sql.Append("Sort=" + model.Sort + ",");
            sql.Append("guoclassid=" + model.guoclassid + " ");
            sql.Append(" where id=" + model.id + "");

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }
        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(id) as MaxKey  from linyuclass";
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
            string sql = "select count(id) as MaxKey  from linyuclass";
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
            strSql.Append("select id,ClassName,Sort ");
            strSql.Append(" from linyuclass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort");
            return DbHelperOledb.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ClassName,Sort ");
            strSql.Append(" from linyuclass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num,string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top "+num+" id,ClassName,Sort ");
            strSql.Append(" from linyuclass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort");
            return DbHelperOledb.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num, string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " id,ClassName,Sort ");
            strSql.Append(" from linyuclass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.linyuclass GetModel(int nc_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ClassName,Sort,guoclassid from linyuclass ");
            strSql.Append(" where id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.linyuclass model = new Model.linyuclass();
            DataSet ds = DbHelperOledb.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
                {
                    model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
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
        public Model.linyuclass GetModel(int nc_Id,Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ClassName,Sort,guoclassid from linyuclass ");
            strSql.Append(" where id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.linyuclass model = new Model.linyuclass();
            DataSet ds = new DbHelperOledbP(sw).Query(strSql.ToString(),parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
                {
                    model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
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
        public Model.linyuclass GetModel_where(string where)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ClassName,Sort,guoclassid from linyuclass where "+where);

            Model.linyuclass model = new Model.linyuclass();
            DataSet ds = DbHelperOledb.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
                {
                    model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
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
        public Model.linyuclass GetModel_where(string where,Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,ClassName,Sort,guoclassid from linyuclass where " + where);

            Model.linyuclass model = new Model.linyuclass();
            DataSet ds =new  DbHelperOledbP(sw).Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
                if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
                {
                    model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from linyuclass ");
            sql.Append(" where id=@NC_Id");
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
            sql.Append("delete from linyuclass ");
            sql.Append(" where id=@NC_Id");
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
