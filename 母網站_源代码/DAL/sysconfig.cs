using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using DBUtility;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class sysconfig
    {
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.sysconfig model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update sysconfig set sys_Title=@sys_Title,searchkey=@searchkey,sys_description=@sys_description where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sys_Title", model.sys_Title);
                cmd.Parameters.AddWithValue("@searchkey", model.searchkey);
                cmd.Parameters.AddWithValue("@sys_description", model.sys_description);
                cmd.Parameters.AddWithValue("@id", model.id);
                cmd.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.sysconfig GetModel(int id)
        {
            Model.sysconfig model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from sysconfig where id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.sysconfig();
                    model.id = id;
                    model.sys_Title = sdr["sys_Title"] == System.DBNull.Value ? "" : (string)sdr["sys_Title"];
                    model.searchkey = sdr["searchkey"] == System.DBNull.Value ? "" : (string)sdr["searchkey"];
                    model.sys_description = sdr["sys_description"] == System.DBNull.Value ? "" : (string)sdr["sys_description"];
                    
                }
                sdr.Close();
            }
            return model;

        }

    }
}
