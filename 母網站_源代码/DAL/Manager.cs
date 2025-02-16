﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DBUtility;
using System.Data.SqlClient;

namespace DAL
{
    public class Manager
    {
        public Manager()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.Manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Manager(");
            strSql.Append("M_AdminName,M_Password)");
            strSql.Append(" values (");
            strSql.Append("@AdminName,@Password)");
            SqlParameter[] parameters = {
					new SqlParameter("@AdminName", SqlDbType.NVarChar,50),
					new SqlParameter("@Password", SqlDbType.NVarChar,50)};
            parameters[0].Value = model.AdminName;
            parameters[1].Value = model.Password;
            DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// 查询管理员名是否存在
        /// </summary>
        /// <param name="model">要判断的目标对象</param>
        /// <returns>存在返回true，否则返回false</returns>
        public bool Exists(Model.Manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select count(*) from Manager where ");
            strSql.Append("M_AdminName='" + model.AdminName + "'");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(strSql.ToString()));
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
        /// 根据用户名和密码判断管理员是否存在
        /// </summary>
        /// <param name="adminname">用户名</param>
        /// <param name="password">密码</param>
        /// <returns>存在返回true，否则返回false</returns>
        public bool Exists(string adminname, string password)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select count(*) from Manager where ");
            sql.Append("M_AdminName='" + adminname + "' ");
            sql.Append("and M_Password='" + password + "'");
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
        public Model.Manager GetModel(int m_id)
        {
            Model.Manager model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from Manager where M_id=@M_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@M_id", m_id);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.Manager();
                    model.id = m_id;
                    model.AdminName = sdr["M_AdminName"].ToString();
                    model.Password = sdr["M_Password"].ToString();
                }
                sdr.Close();
            }
            return model;
        }
        /// <summary>
        /// 返回管理员列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select * from Manager");
            return DbHelperOledb.Query(sql.ToString());
        }

        /// <summary>
        /// 判断管理员是否只有一个
        /// </summary>
        /// <returns></returns>
        public bool CountIsOne()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select count(*) from Manager");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
            if (i == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 根据条件删除
        /// </summary>
        /// <param name="M_ID">要删除对象的ID</param>
        /// <returns></returns>
        public bool Delete(int M_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from Manager where M_ID=");
            sql.Append(M_ID);
            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 根据管理员名修改管理员密码
        /// </summary>
        /// <param name="model">要修改的实体</param>
        /// <returns></returns>
        public bool Update(Model.Manager model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update Manager set ");
            sql.Append("M_Password=N'" + model.Password + "'");
            sql.Append(" where M_AdminName='" + model.AdminName + "'");

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }
    }
}
