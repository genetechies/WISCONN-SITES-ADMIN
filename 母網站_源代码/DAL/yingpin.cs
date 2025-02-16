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
    public class yingpin
    {

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.yingpin GetModel(int G_Id)
        {
            Model.yingpin model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from yingpin where id=@G_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.yingpin();
                    model.id = G_Id;
                    model.zhiwei = sdr["zhiwei"] == System.DBNull.Value ? "" : (string)sdr["zhiwei"];
                    model.xingming = sdr["xingming"] == System.DBNull.Value ? "" : (string)sdr["xingming"];
                    model.minzu = sdr["minzu"] == System.DBNull.Value ? "" : (string)sdr["minzu"];
                    model.jiguan = sdr["jiguan"] == System.DBNull.Value ? "" : (string)sdr["jiguan"];
                    model.shenfenzheng = sdr["shenfenzheng"] == System.DBNull.Value ? "" : (string)sdr["shenfenzheng"];
                    model.yuanxiao = sdr["yuanxiao"] == System.DBNull.Value ? "" : (string)sdr["yuanxiao"];
                    model.zhuanye = sdr["zhuanye"] == System.DBNull.Value ? "" : (string)sdr["zhuanye"];
                    model.xingbie = sdr["xingbie"] == System.DBNull.Value ? "" : (string)sdr["xingbie"];
                    model.nianling = sdr["nianling"] == System.DBNull.Value ? "" : (string)sdr["nianling"];
                    model.hunyin = sdr["hunyin"] == System.DBNull.Value ? "" : (string)sdr["hunyin"];
                    model.nianxian = sdr["nianxian"] == System.DBNull.Value ? "" : (string)sdr["nianxian"];
                    model.xueli = sdr["xueli"] == System.DBNull.Value ? "" : (string)sdr["xueli"];
                    model.whworknow = sdr["whworknow"] == System.DBNull.Value ? "" : (string)sdr["whworknow"];
                    model.yingpin1 = sdr["yingpin1"] == System.DBNull.Value ? "" : (string)sdr["yingpin1"];
                    model.yingpin2 = sdr["yingpin2"] == System.DBNull.Value ? "" : (string)sdr["yingpin2"];
                    model.hopemony = sdr["hopemony"] == System.DBNull.Value ? "" : (string)sdr["hopemony"];
                    model.diaopei = sdr["diaopei"] == System.DBNull.Value ? "" : (string)sdr["diaopei"];
                    model.dianhua = sdr["dianhua"] == System.DBNull.Value ? "" : (string)sdr["dianhua"];
                    model.email = sdr["email"] == System.DBNull.Value ? "" : (string)sdr["email"];
                    model.workjingli = sdr["workjingli"] == System.DBNull.Value ? "" : (string)sdr["workjingli"];
                    model.jiaoyujingli = sdr["jiaoyujingli"] == System.DBNull.Value ? "" : (string)sdr["jiaoyujingli"];
                    model.content = sdr["content"] == System.DBNull.Value ? "" : (string)sdr["content"];
                    if (sdr["time"].ToString().Trim() != "")
                    {
                        model.time = Convert.ToDateTime(sdr["time"].ToString().Trim());
                    }
                    model.shengao = sdr["shengao"] == System.DBNull.Value ? "" : (string)sdr["shengao"];



                    if (sdr["state"].ToString().Trim() != "")
                    {
                        model.state = Convert.ToInt32(sdr["state"].ToString().Trim());
                    }
                    else
                    {
                        model.state = 0;
                    }
                    
                }
                sdr.Close();
            }
            return model;
        }

        public void UpdateIsFinish(int G_Id, int isfinish)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update yingpin set state=@state where id=@G_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@state", isfinish);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);

                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from yingpin");
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM yingpin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id as 編號,zhiwei as 應徵職務,xingming as 姓名,jiguan as 第二外語,shenfenzheng as 身份證號碼,yuanxiao as 畢業學校,zhuanye as 第一外語,xingbie as 性別,nianling as 年齡,hunyin as 婚姻狀況,nianxian as 工作年限,xueli as 學歷,whworknow as 現工作地點,yingpin1 as 備選職位一,yingpin2 as 備選職位二,hopemony as 希望的薪金,diaopei as 是否願意出差,dianhua as 聯繫電話,email as 電子信箱,workjingli as 工作經歷,jiaoyujingli as 教育經歷,content as 詳細備註,time as 應聘時間 ");
            strSql.Append(" FROM yingpin ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from yingpin ");
            strSql.Append(" where id=" + G_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }


    }
}
