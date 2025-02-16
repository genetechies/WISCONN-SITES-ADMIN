using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class yingpin
{
	public Model.yingpin GetModel(int G_Id)
	{
		Model.yingpin model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from yingpin where id=@G_Id";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@G_Id", G_Id);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.yingpin();
				model.id = G_Id;
				model.zhiwei = ((sdr["zhiwei"] == DBNull.Value) ? "" : ((string)sdr["zhiwei"]));
				model.xingming = ((sdr["xingming"] == DBNull.Value) ? "" : ((string)sdr["xingming"]));
				model.minzu = ((sdr["minzu"] == DBNull.Value) ? "" : ((string)sdr["minzu"]));
				model.jiguan = ((sdr["jiguan"] == DBNull.Value) ? "" : ((string)sdr["jiguan"]));
				model.shenfenzheng = ((sdr["shenfenzheng"] == DBNull.Value) ? "" : ((string)sdr["shenfenzheng"]));
				model.yuanxiao = ((sdr["yuanxiao"] == DBNull.Value) ? "" : ((string)sdr["yuanxiao"]));
				model.zhuanye = ((sdr["zhuanye"] == DBNull.Value) ? "" : ((string)sdr["zhuanye"]));
				model.xingbie = ((sdr["xingbie"] == DBNull.Value) ? "" : ((string)sdr["xingbie"]));
				model.nianling = ((sdr["nianling"] == DBNull.Value) ? "" : ((string)sdr["nianling"]));
				model.hunyin = ((sdr["hunyin"] == DBNull.Value) ? "" : ((string)sdr["hunyin"]));
				model.nianxian = ((sdr["nianxian"] == DBNull.Value) ? "" : ((string)sdr["nianxian"]));
				model.xueli = ((sdr["xueli"] == DBNull.Value) ? "" : ((string)sdr["xueli"]));
				model.whworknow = ((sdr["whworknow"] == DBNull.Value) ? "" : ((string)sdr["whworknow"]));
				model.yingpin1 = ((sdr["yingpin1"] == DBNull.Value) ? "" : ((string)sdr["yingpin1"]));
				model.yingpin2 = ((sdr["yingpin2"] == DBNull.Value) ? "" : ((string)sdr["yingpin2"]));
				model.hopemony = ((sdr["hopemony"] == DBNull.Value) ? "" : ((string)sdr["hopemony"]));
				model.diaopei = ((sdr["diaopei"] == DBNull.Value) ? "" : ((string)sdr["diaopei"]));
				model.dianhua = ((sdr["dianhua"] == DBNull.Value) ? "" : ((string)sdr["dianhua"]));
				model.email = ((sdr["email"] == DBNull.Value) ? "" : ((string)sdr["email"]));
				model.workjingli = ((sdr["workjingli"] == DBNull.Value) ? "" : ((string)sdr["workjingli"]));
				model.jiaoyujingli = ((sdr["jiaoyujingli"] == DBNull.Value) ? "" : ((string)sdr["jiaoyujingli"]));
				model.content = ((sdr["content"] == DBNull.Value) ? "" : ((string)sdr["content"]));
				if (sdr["time"].ToString().Trim() != "")
				{
					model.time = Convert.ToDateTime(sdr["time"].ToString().Trim());
				}
				model.shengao = ((sdr["shengao"] == DBNull.Value) ? "" : ((string)sdr["shengao"]));
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
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "update yingpin set state=@state where id=@G_Id";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@state", isfinish);
		cmd.Parameters.AddWithValue("@G_Id", G_Id);
		cmd.ExecuteNonQuery();
	}

	public int Count()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from yingpin");
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

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

	public void Delete(int G_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("delete from yingpin ");
		strSql.Append(" where id=" + G_Id + " ");
		DbHelperOledb.ExecuteSql(strSql.ToString());
	}
}
