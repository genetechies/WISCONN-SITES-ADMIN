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
    public class linyuxinxi
    {

        public int CountByClass(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from linyuxinxi ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        public int CountByClass(string where,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from linyuxinxi ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()));
        }
        public bool UpdateState(int P_Id, int state)
        {
            string sql = "update linyuxinxi set hst=" + state + " where id=" + P_Id;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }
        public bool UpdateState(int P_Id, int state,Model.SubWeb sw)
        {
            string sql = "update linyuxinxi set hst=" + state + " where id=" + P_Id;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from linyuxinxi where "+where);
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count(string where,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from linyuxinxi where " + where);
            return Convert.ToInt32(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()));
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList()
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select linyuxinxi.id as 編號,linyuxinxi.title as 企業名稱,linyuclass.ClassName as 所屬洲類別,guoclass.NC_ClassName as 所屬國家  from linyuxinxi,linyuclass,guoclass  where linyuxinxi.linyuclassid=linyuclass.id and linyuclass.guoclassid=guoclass.NC_Id order by linyuxinxi.id desc");
            strSql.Append("select linyuxinxi.id as 編號,linyuxinxi.title as 企業名稱,linyuclass.ClassName as 所屬洲類別  from linyuxinxi,linyuclass  where linyuxinxi.linyuclassid=linyuclass.id  order by linyuxinxi.id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList(Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            //strSql.Append("select linyuxinxi.id as 編號,linyuxinxi.title as 企業名稱,linyuclass.ClassName as 所屬洲類別,guoclass.NC_ClassName as 所屬國家  from linyuxinxi,linyuclass,guoclass  where linyuxinxi.linyuclassid=linyuclass.id and linyuclass.guoclassid=guoclass.NC_Id order by linyuxinxi.id desc");
            strSql.Append("select linyuxinxi.id as 編號,linyuxinxi.title as 企業名稱,linyuclass.ClassName as 所屬洲類別  from linyuxinxi,linyuclass  where linyuxinxi.linyuclassid=linyuclass.id  order by linyuxinxi.id desc");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }
        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select count(id) as MaxKey  from linyuxinxi";
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
            string sql = "select count(id) as MaxKey  from linyuxinxi";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(new DbHelperOledbP(sw).ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname from linyuxinxi order by Sort");
            return DbHelperOledb.Query(sql.ToString());
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll(Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname from linyuxinxi order by Sort");
            return new DbHelperOledbP(sw).Query(sql.ToString());
        }

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.linyuxinxi model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from linyuxinxi");
            sql.Append(" where title='" + model.title + "'");
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
        public bool Exists(Model.linyuxinxi model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from linyuxinxi");
            sql.Append(" where title='" + model.title + "'");
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
        public bool Add(Model.linyuxinxi model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into linyuxinxi(");
            sql.Append("title,Sort,linyuclassid,C_show)");
            sql.Append(" values (");
            sql.Append("@title,@Sort,@linyuclassid,@C_show)");
            SqlParameter[] parameters = {
                new SqlParameter("@title",SqlDbType.NVarChar,100),
                new SqlParameter("@Sort",SqlDbType.Int,4),
                new SqlParameter("@linyuclassid",SqlDbType.Int,4),
                new SqlParameter("@C_show",SqlDbType.Int,4)
                                          
                                          };
            parameters[0].Value = model.title;
            parameters[1].Value = model.Sort;
            parameters[2].Value = model.linyuclassid;
            parameters[3].Value = model.C_show;

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
        public bool Add(Model.linyuxinxi model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into linyuxinxi(");
            sql.Append("title,Sort,linyuclassid,C_show)");
            sql.Append(" values (");
            sql.Append("@title,@Sort,@linyuclassid,@C_show)");
            SqlParameter[] parameters = {
                new SqlParameter("@title",SqlDbType.NVarChar,100),
                new SqlParameter("@Sort",SqlDbType.Int,4),
                new SqlParameter("@linyuclassid",SqlDbType.Int,4),
                new SqlParameter("@C_show",SqlDbType.Int,4)
                                          
                                          };
            parameters[0].Value = model.title;
            parameters[1].Value = model.Sort;
            parameters[2].Value = model.linyuclassid;
            parameters[3].Value = model.C_show;

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
        public bool Update(Model.linyuxinxi model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update linyuxinxi Set ");
            sql.Append("title=N'" + model.title + "',");
            sql.Append("Sort=" + model.Sort + ",");
            sql.Append("linyuclassid=" + model.linyuclassid + ", ");
            sql.Append("C_show=" + model.C_show + " ");
            sql.Append(" where id=" + model.id + "");

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
        public bool Update(Model.linyuxinxi model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update linyuxinxi Set ");
            sql.Append("title=N'" + model.title + "',");
            sql.Append("Sort=" + model.Sort + ",");
            sql.Append("linyuclassid=" + model.linyuclassid + ", ");
            sql.Append("C_show=" + model.C_show + " ");
            sql.Append(" where id=" + model.id + "");

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.linyuxinxi GetModel(int nc_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,title,Sort,linyuclassid,C_show from linyuxinxi ");
            strSql.Append(" where id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.linyuxinxi model = new Model.linyuxinxi();
            DataSet ds = DbHelperOledb.Query(strSql.ToString(),parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.title = ds.Tables[0].Rows[0]["title"].ToString();
                if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["linyuclassid"].ToString() != "")
                {
                    model.linyuclassid = int.Parse(ds.Tables[0].Rows[0]["linyuclassid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["C_show"].ToString() != "")
                {
                    model.C_show = int.Parse(ds.Tables[0].Rows[0]["C_show"].ToString());
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
        public Model.linyuxinxi GetModel(int nc_Id,Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,title,Sort,linyuclassid,C_show from linyuxinxi ");
            strSql.Append(" where id=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.linyuxinxi model = new Model.linyuxinxi();
            DataSet ds = new DbHelperOledbP(sw).Query(strSql.ToString(),parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                model.title = ds.Tables[0].Rows[0]["title"].ToString();
                if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
                {
                    model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["linyuclassid"].ToString() != "")
                {
                    model.linyuclassid = int.Parse(ds.Tables[0].Rows[0]["linyuclassid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["C_show"].ToString() != "")
                {
                    model.C_show = int.Parse(ds.Tables[0].Rows[0]["C_show"].ToString());
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
            sql.Append("delete from linyuxinxi ");
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
            sql.Append("delete from linyuxinxi ");
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

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname ");
            strSql.Append(" from linyuxinxi ");
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
            strSql.Append("select *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname ");
            strSql.Append(" from linyuxinxi ");
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
        public DataSet GetList_top(int num, string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top "+num+" *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname ");
            strSql.Append(" from linyuxinxi ");
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
            strSql.Append("select top " + num + " *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname ");
            strSql.Append(" from linyuxinxi ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }


    }
}
