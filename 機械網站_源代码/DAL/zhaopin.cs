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
    public class zhaopin
    {

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.zhaopin model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update zhaopin Set ");
            sql.Append("gangwei=N'" + model.gangwei + "',");
            sql.Append("xueli=N'" + model.xueli + "', ");
            sql.Append("renshu=N'" + model.renshu + "', ");
            sql.Append("didian=N'" + model.didian + "', ");
            sql.Append("daiyu=N'" + model.daiyu + "', ");
            sql.Append("qixian=N'" + model.qixian + "', ");
            sql.Append("yaoqiu=N'" + model.yaoqiu + "' ");
            sql.Append(" where id=" + model.id + "");

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.zhaopin model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into zhaopin(");
            sql.Append("gangwei,xueli,renshu,didian,daiyu,qixian,yaoqiu,sort)");
            sql.Append(" values (");
            sql.Append("@gangwei,@xueli,@renshu,@didian,@daiyu,@qixian,@yaoqiu,@sort)");
            SqlParameter[] parameters = {
                new SqlParameter("@gangwei",SqlDbType.NVarChar,255),
                new SqlParameter("@xueli",SqlDbType.NVarChar,100),
                new SqlParameter("@renshu",SqlDbType.NVarChar,50),
                new SqlParameter("@didian",SqlDbType.NVarChar,100),
                new SqlParameter("@daiyu",SqlDbType.NVarChar,100),
                new SqlParameter("@qixian",SqlDbType.NVarChar,100),
                new SqlParameter("@yaoqiu",SqlDbType.NVarChar),
                new SqlParameter("@sort",SqlDbType.Int,4)
                };
            parameters[0].Value = model.gangwei;
            parameters[1].Value = model.xueli;
            parameters[2].Value = model.renshu;
            parameters[3].Value = model.didian;
            parameters[4].Value = model.daiyu;
            parameters[5].Value = model.qixian;
            parameters[6].Value = model.yaoqiu;
            parameters[7].Value = model.sort;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
            if (i > 0)
                return true;
            else
                return false;
        }

        public int CountByClass(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from zhaopin ");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM zhaopin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by OrderID");
            return DbHelperOledb.Query(strSql.ToString());
        }

        public DataSet GetListByClass(string strWhere, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select *  FROM zhaopin ");
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
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from zhaopin ");
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
        /// 得到一个对象实体
        /// </summary>
        public Model.zhaopin GetModel(int P_ID)
        {
            Model.zhaopin model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from zhaopin where id=@P_ID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.zhaopin();
                    model.id = P_ID;
                    model.gangwei = sdr["gangwei"] == System.DBNull.Value ? "" : (string)sdr["gangwei"]; ;
                    model.xueli = sdr["xueli"] == System.DBNull.Value ? "" : (string)sdr["xueli"];
                    model.renshu = sdr["renshu"] == System.DBNull.Value ? "" : (string)sdr["renshu"];
                    model.didian = sdr["didian"] == System.DBNull.Value ? "" : (string)sdr["didian"];
                    model.daiyu = sdr["daiyu"] == System.DBNull.Value ? "" : (string)sdr["daiyu"];
                    model.qixian = sdr["qixian"] == System.DBNull.Value ? "" : (string)sdr["qixian"];
                    model.yaoqiu = sdr["yaoqiu"] == System.DBNull.Value ? "" : (string)sdr["yaoqiu"];

                    if (sdr["time"].ToString().Trim() != "")
                    {
                        model.time = Convert.ToDateTime(sdr["time"].ToString());
                    }

                    if (sdr["sort"].ToString().Trim() != "")
                    {
                        model.sort = Convert.ToInt32(sdr["sort"].ToString());
                    }
                }
                sdr.Close();
            }
            return model;

        }


        public void UpdaetSortKey(int P_Id, int sortkey)
        {
            string sql = "update zhaopin set sort=" + sortkey + " where id=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
        }



    }
}
