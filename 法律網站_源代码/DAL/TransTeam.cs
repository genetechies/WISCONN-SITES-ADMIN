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
    public class TransTeam
    {


        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool ExistsTeamType(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from TransteamType");
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
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int AddTeamType(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TransteamType(");
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
        public int AddTeamType(Model.guoclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TransteamType(");
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
        public bool UpdateTeamType(Model.guoclass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TransteamType Set ");
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
        public bool UpdateTeamType(Model.guoclass model,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TransteamType Set ");
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
        public bool DeleteTeamType(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TransteamType ");
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
        public bool DeleteTeamType(int id,Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TransteamType ");
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
        public DataSet GetAllTeamType()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TransteamType order by NC_Sort");
            return DbHelperOledb.Query(sql.ToString());
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllTeamType(Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TransteamType order by NC_Sort");
            return new DbHelperOledbP(sw).Query(sql.ToString());
        }
        public int GetMaxSortKeyTeamType(string strWhere)
        {
            string sql = "select count(nc_Id) as MaxKey  from TransteamType";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListTeamType(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TransteamType");
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
        public DataSet GetListTeamType(string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TransteamType");
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
        public Model.guoclass GetModelTeamType(int nc_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TransteamType ");
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
        public Model.guoclass GetModelTeamType(int nc_Id,Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TransteamType ");
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
        public Model.guoclass GetModel_whereTeamType(string where)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort from TransteamType where " + where);


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

        /////////////////////////////////以下翻译团队
        /// <summary>
        /// 返回记录总数
        /// </summary>
        public int Count(string where)
        {
            StringBuilder sql = new StringBuilder();
            if (string.IsNullOrEmpty(where))
            {
                sql.Append("Select count(1) from TransTeam");
            }
            else
            {
                sql.Append("select count(1) from TransTeam where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList()
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select TransTeam.tid as 編號,TransTeam.tname as LOG圖片名稱,TransTeam.imgpath as LOG圖文件,home  from TransTeam  order by TransTeam.sort desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        public DataSet GetListByClass(string strWhere, string orderby, Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *,(select NC_ClassName from TransteamType t2 where t2.NC_ID=TransTeam.typeid) as NC_ClassName  FROM TransTeam ");
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
                strSql.Append(" order by sort desc");
            }
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }

        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from TransTeam order by sort");
            return DbHelperOledb.Query(sql.ToString());
        }

        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select max(tid) as MaxKey from TransTeam ";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.TransTeam model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from TransTeam");
            sql.Append(" where tname='" + model.tname + "'");
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
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.TransTeam model, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into TransTeam(");
            sql.Append("tname,sort,imgpath,typeid,home,xueli,descript)");
            sql.Append(" values (");
            sql.Append("@tname,@sort,@imgpath,@typeid,@home,@xueli,@descript)");
            SqlParameter[] parameters = {
                new SqlParameter("@tname", model.tname),
                new SqlParameter("@sort",model.sort),
                new SqlParameter("@imgpath",model.imgpath), new SqlParameter("@typeid",model.typeid),
                new SqlParameter("@home",model.home), new SqlParameter("@xueli",model.xueli), new SqlParameter("@descript",model.descript)                                          
             };

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
        public bool Update(Model.TransTeam model, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update TransTeam Set ");
            sql.Append("tname=N'" + model.tname + "',");
            sql.Append("sort=" + model.sort + ",");
            sql.Append("avater=" + model.avater + ", "); sql.Append("typeid=" + model.typeid + ", ");
            sql.Append("imgpath=N'" + model.imgpath + "',xueli=N'" + model.xueli + "',home=N'" + model.home + "',descript=N'" + model.descript + "'");
            sql.Append(" where tid=" + model.tid);

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString()));
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
            strSql.Append("select * ");
            strSql.Append(" from TransTeam ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort desc ");
            return DbHelperOledb.Query(strSql.ToString());
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" from TransTeam ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by sort desc ");
            return new DbHelperOledbP(sw).Query(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TransTeam GetModel(int nc_Id, Model.SubWeb sw)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from TransTeam ");
            strSql.Append(" where tid=@nc_Id ");
            SqlParameter[] parameters = {
					new SqlParameter("@nc_Id", SqlDbType.Int,4)};
            parameters[0].Value = nc_Id;

            Model.TransTeam model = new Model.TransTeam();
            DataSet ds = new DbHelperOledbP(sw).Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["tid"].ToString() != "")
                {
                    model.tid = int.Parse(ds.Tables[0].Rows[0]["tid"].ToString());
                }
                model.tname = ds.Tables[0].Rows[0]["tname"].ToString();
                if (ds.Tables[0].Rows[0]["sort"].ToString() != "")
                {
                    model.sort = int.Parse(ds.Tables[0].Rows[0]["sort"].ToString());
                }
                if (ds.Tables[0].Rows[0]["avater"].ToString() != "")
                {
                    model.avater = int.Parse(ds.Tables[0].Rows[0]["avater"].ToString());
                }
                if (ds.Tables[0].Rows[0]["typeid"].ToString() != "")
                {
                    model.typeid = int.Parse(ds.Tables[0].Rows[0]["typeid"].ToString());
                }
                model.imgpath = ds.Tables[0].Rows[0]["imgpath"].ToString();
                model.home = ds.Tables[0].Rows[0]["home"].ToString();
                model.xueli = ds.Tables[0].Rows[0]["xueli"].ToString();
                model.descript = ds.Tables[0].Rows[0]["descript"].ToString();

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
        public bool Delete(int id, Model.SubWeb sw)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from TransTeam ");
            sql.Append(" where tid=@NC_Id");
            SqlParameter[] parameters ={
                new SqlParameter("@NC_Id",SqlDbType.Int,4)};
            parameters[0].Value = id;

            int i = Convert.ToInt32(new DbHelperOledbP(sw).ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }


        public void UpdaetSortKey(int P_Id, int sortkey)
        {
            string sql = "update TransTeam set sort=" + sortkey + " where tid=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
        }

    }
}
