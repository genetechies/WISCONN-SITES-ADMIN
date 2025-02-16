using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtility;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class XunJia
    {

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int G_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from XunJia");
            strSql.Append(" where id=" + G_Id + " ");
            return DbHelperOledb.Exists(strSql.ToString());
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from XunJia");
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.XunJia model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into XunJia(LinksName,LinksTel,LinksEmail,SerPro,OrgLanguage,ToLanguage,TxtCount,TxtSCount,ispaiban,ercijiaogao,rungao,JiaojianTime,gongzuori,zhuyicontent,Annex,addTime,ip,Finish) values(@LinksName,@LinksTel,@LinksEmail,@SerPro,@OrgLanguage,@ToLanguage,@TxtCount,@TxtSCount,@ispaiban,@ercijiaogao,@rungao,@JiaojianTime,@gongzuori,@zhuyicontent,@Annex,@addTime,@ip,@Finish)";
                //string sql = "insert into XunJia(LinksName,LinksTel,LinksEmail,SerPro,OrgLanguage,ToLanguage,TxtCount,TxtSCount,ispaiban,ercijiaogao,rungao,JiaojianTime,gongzuori,zhuyicontent,Annex,addTime) values(@LinksName,@LinksTel,@LinksEmail,@SerPro,@OrgLanguage,@ToLanguage,@TxtCount,@TxtSCount,@ispaiban,@ercijiaogao,@rungao,@JiaojianTime,@gongzuori,@zhuyicontent,@Annex,@addTime)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@LinksName", model.LinksName);
                cmd.Parameters.AddWithValue("@LinksTel", model.LinksTel);
                cmd.Parameters.AddWithValue("@LinksEmail", model.LinksEmail);
                cmd.Parameters.AddWithValue("@SerPro", model.SerPro);
                cmd.Parameters.AddWithValue("@OrgLanguage", model.OrgLanguage);
                cmd.Parameters.AddWithValue("@ToLanguage", model.ToLanguage);
                cmd.Parameters.AddWithValue("@TxtCount", model.TxtCount);
                cmd.Parameters.AddWithValue("@TxtSCount", model.TxtSCount);
                cmd.Parameters.AddWithValue("@ispaiban", model.ispaiban);
                cmd.Parameters.AddWithValue("@ercijiaogao", model.ercijiaogao);
                cmd.Parameters.AddWithValue("@rungao", model.rungao);
                cmd.Parameters.AddWithValue("@JiaojianTime", model.JiaojianTime);
                cmd.Parameters.AddWithValue("@gongzuori", model.gongzuori.ToString());
                cmd.Parameters.AddWithValue("@zhuyicontent", model.zhuyicontent);
                cmd.Parameters.AddWithValue("@Annex", model.Annex);
                cmd.Parameters.AddWithValue("@addTime", model.addTime);
                cmd.Parameters.AddWithValue("@ip", model.ip);
                cmd.Parameters.AddWithValue("@Finish", model.Finish);
                cmd.ExecuteNonQuery();
            }
        }

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        ///// <param name="model"></param>
        //public bool Add(Model.XunJia model)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("insert into XunJia(");
        //    sql.Append("LinksName,LinksTel,LinksEmail,SerPro,OrgLanguage,ToLanguage,TxtCount,TxtSCount,ispaiban,ercijiaogao,rungao,JiaojianTime,gongzuori,zhuyicontent,Annex,addTime,ip,Finish)");
        //    sql.Append(" values (");
        //    sql.Append("@LinksName,@LinksTel,@LinksEmail,@SerPro,@OrgLanguage,@ToLanguage,@TxtCount,@TxtSCount,@ispaiban,@ercijiaogao,@rungao,@JiaojianTime,@gongzuori,@zhuyicontent,@Annex,@addTime,@ip,@Finish)");
        //    OleDbParameter[] parameters = {
        //        new OleDbParameter("@LinksName",OleDbType.VarChar,50),
        //        new OleDbParameter("@LinksTel",OleDbType.VarChar,50),
        //        new OleDbParameter("@LinksEmail",OleDbType.VarChar,100),
        //        new OleDbParameter("@SerPro",OleDbType.VarChar,50),
        //        new OleDbParameter("@OrgLanguage",OleDbType.VarChar,50),
        //        new OleDbParameter("@ToLanguage",OleDbType.Integer,50),
        //        new OleDbParameter("@TxtCount",OleDbType.Integer,4),
        //        new OleDbParameter("@TxtSCount",OleDbType.VarChar,50),
        //        new OleDbParameter("@ispaiban",OleDbType.Integer,4),
        //        new OleDbParameter("@ercijiaogao",OleDbType.Integer,4),
        //        new OleDbParameter("@rungao",OleDbType.Integer,4),
        //        new OleDbParameter("@JiaojianTime",OleDbType.DBDate),
        //        new OleDbParameter("@gongzuori",OleDbType.VarChar,50),
        //        new OleDbParameter("@zhuyicontent",OleDbType.LongVarChar),
        //        new OleDbParameter("@Annex",OleDbType.VarChar,200),
        //        new OleDbParameter("@addTime",OleDbType.DBTimeStamp),
        //        new OleDbParameter("@ip",OleDbType.VarChar,50),
        //        new OleDbParameter("@Finish",OleDbType.Integer,4)
                                          
        //                                  };
        //    parameters[0].Value = model.LinksName;
        //    parameters[1].Value = model.LinksTel;
        //    parameters[2].Value = model.LinksEmail;
        //    parameters[3].Value = model.SerPro;
        //    parameters[4].Value = model.OrgLanguage;
        //    parameters[5].Value = model.ToLanguage;
        //    parameters[6].Value = model.TxtCount;
        //    parameters[7].Value = model.TxtSCount;
        //    parameters[8].Value = model.ispaiban;
        //    parameters[9].Value = model.ercijiaogao;
        //    parameters[10].Value = model.rungao;
        //    parameters[11].Value = model.JiaojianTime;
        //    parameters[12].Value = model.gongzuori;
        //    parameters[13].Value = model.zhuyicontent;
        //    parameters[14].Value = model.Annex;
        //    parameters[15].Value = model.addTime;
        //    parameters[16].Value = model.ip;
        //    parameters[17].Value = model.Finish;

        //    int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
        //    if (i > 0)
        //        return true;
        //    else
        //        return false;
        //}

        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public void Update(Model.XunJia model)
        //{
        //    using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
        //    {
        //        if (conn.State != ConnectionState.Open)
        //            conn.Open();
        //        string sql = "update XunJia set LinksName=@LinksName,LinksTel=@LinksTel,LinksEmail=@LinksEmail,SerPro=@SerPro,OrgLanguage=@OrgLanguage,ToLanguage=@ToLanguage,TxtCount=@TxtCount,TxtSCount=@TxtSCount,ispaiban=@ispaiban,ercijiaogao=@ercijiaogao,rungao=@rungao,JiaojianTime=@JiaojianTime,gongzuori=@gongzuori,zhuyicontent=@zhuyicontent,Annex=@Annex,addTime=@addTime,ip=@ip,Finish=@Finish where G_Id=@G_Id";
        //        OleDbCommand cmd = new OleDbCommand(sql, conn);
        //        cmd.Parameters.AddWithValue("@G_Title", model.LinksName);
        //        cmd.Parameters.AddWithValue("@G_Username", model.LinksTel);
        //        cmd.Parameters.AddWithValue("@G_CompanyName", model.LinksEmail);
        //        cmd.Parameters.AddWithValue("@G_Telphone", model.SerPro);
        //        cmd.Parameters.AddWithValue("@G_Email", model.G_Email);
        //        cmd.Parameters.AddWithValue("@G_Website", model.G_Website);
        //        cmd.Parameters.AddWithValue("@G_Address", model.G_Address);
        //        cmd.Parameters.AddWithValue("@G_Content", model.G_Content);
        //        cmd.Parameters.AddWithValue("@G_Items", model.G_Items);
        //        cmd.Parameters.AddWithValue("@G_Charge", model.G_Charge);
        //        cmd.Parameters.AddWithValue("@G_Runtime", model.G_Runtime);
        //        cmd.Parameters.AddWithValue("@G_ModName", model.G_ModName);
        //        cmd.Parameters.AddWithValue("@G_Modtime", model.G_Modtime);
        //        cmd.Parameters.AddWithValue("@G_IsFinish", model.G_IsFinish);
        //        cmd.Parameters.AddWithValue("@G_Id", model.G_Id);

        //        cmd.ExecuteNonQuery();
        //    }
        //}


        public void UpdateIsFinish(int G_Id, int isfinish)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update XunJia set Finish=@G_IsFinish where id=@G_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_IsFinish", isfinish);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);

                cmd.ExecuteNonQuery();
            }
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from XunJia ");
            strSql.Append(" where id=" + G_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.XunJia GetModel(int G_Id)
        {
            Model.XunJia model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from XunJia where id=@G_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.XunJia();
                    model.id = G_Id;
                    model.LinksName = sdr["LinksName"] == System.DBNull.Value ? "" : (string)sdr["LinksName"];
                    model.LinksTel = sdr["LinksTel"] == System.DBNull.Value ? "" : (string)sdr["LinksTel"];
                    model.LinksEmail = sdr["LinksEmail"] == System.DBNull.Value ? "" : (string)sdr["LinksEmail"];
                    model.SerPro = sdr["SerPro"] == System.DBNull.Value ? "" : (string)sdr["SerPro"];
                    model.OrgLanguage = sdr["OrgLanguage"] == System.DBNull.Value ? "" : (string)sdr["OrgLanguage"];
                    model.ToLanguage = sdr["ToLanguage"] == System.DBNull.Value ? "" : (string)sdr["ToLanguage"];
                    if (sdr["TxtCount"].ToString().Trim() != "")
                    {
                        model.TxtCount = Convert.ToInt32(sdr["TxtCount"].ToString().Trim());
                    }
                    else
                    {
                        model.TxtCount = 0;
                    }
                    model.TxtSCount = sdr["TxtSCount"] == System.DBNull.Value ? "" : (string)sdr["TxtSCount"];
                    if (sdr["ispaiban"].ToString().Trim() != "")
                    {
                        model.ispaiban = Convert.ToInt32(sdr["ispaiban"].ToString().Trim());
                    }
                    else
                    {
                        model.ispaiban = 0;
                    }

                    if (sdr["ercijiaogao"].ToString().Trim() != "")
                    {
                        model.ercijiaogao = Convert.ToInt32(sdr["ercijiaogao"].ToString().Trim());
                    }
                    else
                    {
                        model.ercijiaogao = 0;
                    }

                    if (sdr["rungao"].ToString().Trim() != "")
                    {
                        model.rungao = Convert.ToInt32(sdr["rungao"].ToString().Trim());
                    }
                    else
                    {
                        model.rungao = 0;
                    }

                    if (sdr["JiaojianTime"].ToString().Trim() != "")
                    {
                        model.JiaojianTime = Convert.ToDateTime(sdr["JiaojianTime"].ToString().Trim());
                    }

                    model.gongzuori = sdr["gongzuori"] == System.DBNull.Value ? "" : (string)sdr["gongzuori"];
                    model.zhuyicontent = sdr["zhuyicontent"] == System.DBNull.Value ? "" : (string)sdr["zhuyicontent"];

                    
                    model.Annex = sdr["Annex"] == System.DBNull.Value ? "" : (string)sdr["Annex"];
                    model.addTime = (DateTime)sdr["addTime"];
                    model.ip = sdr["ip"] == System.DBNull.Value ? "" : (string)sdr["ip"];
                    if (sdr["Finish"].ToString().Trim() != "")
                    {
                        model.Finish = Convert.ToInt32(sdr["Finish"].ToString().Trim());
                    }
                    else
                    {
                        model.Finish = 0;
                    }
                }
                sdr.Close();
            }
            return model;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM XunJia ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 统计一小时内同一ip提交次数
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public int GetCountByIP(string ip) {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from crownsmother.dbo.XunJia");
            strSql.Append(" where ip='" + ip + "' and Datediff(n,addtime,getdate())<60 ");
            int count = Convert.ToInt32(DbHelperOledb.ExecuteScalar(strSql.ToString()));
            return count;
        }

    }
}
