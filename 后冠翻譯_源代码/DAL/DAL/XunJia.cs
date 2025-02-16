using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class XunJia
{
	public bool Exists(int G_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select count(1) from XunJia");
		strSql.Append(" where id=" + G_Id + " ");
		return DbHelperOledb.Exists(strSql.ToString());
	}

	public int Count()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from XunJia");
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public void Add(Model.XunJia model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "insert into XunJia (LinksName,LinksTel,LinksEmail,SerPro,OrgLanguage,ToLanguage,TxtCount,TxtSCount,ispaiban,ercijiaogao,rungao,JiaojianTime,gongzuori,zhuyicontent,Annex,addTime,ip, Finish,[Note]) values (@LinksName,@LinksTel,@LinksEmail,@SerPro,@OrgLanguage,@ToLanguage,@TxtCount,@TxtSCount,@ispaiban,@ercijiaogao,@rungao,@JiaojianTime,@gongzuori,@zhuyicontent,@Annex,@addTime,@ip,@Finish,@Note)";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
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
		cmd.Parameters.AddWithValue("@gongzuori", model.gongzuori);
		cmd.Parameters.AddWithValue("@zhuyicontent", model.zhuyicontent);
		cmd.Parameters.AddWithValue("@Annex", model.Annex);
		cmd.Parameters.AddWithValue("@addTime", model.addTime);
		cmd.Parameters.AddWithValue("@ip", model.ip);
		cmd.Parameters.AddWithValue("@Finish", model.Finish);
		cmd.Parameters.AddWithValue("@Note", model.Note);
		cmd.ExecuteNonQuery();
	}

	public void UpdateIsFinish(int G_Id, int isfinish)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "update XunJia set Finish=@G_IsFinish where id=@G_Id";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@G_IsFinish", isfinish);
		cmd.Parameters.AddWithValue("@G_Id", G_Id);
		cmd.ExecuteNonQuery();
	}

	public void Delete(int G_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("delete from XunJia ");
		strSql.Append(" where id=" + G_Id + " ");
		DbHelperOledb.ExecuteSql(strSql.ToString());
	}

	public Model.XunJia GetModel(int G_Id)
	{
		Model.XunJia model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from XunJia where id=@G_Id";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@G_Id", G_Id);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.XunJia();
				model.id = G_Id;
				model.LinksName = ((sdr["LinksName"] == DBNull.Value) ? "" : ((string)sdr["LinksName"]));
				model.LinksTel = ((sdr["LinksTel"] == DBNull.Value) ? "" : ((string)sdr["LinksTel"]));
				model.LinksEmail = ((sdr["LinksEmail"] == DBNull.Value) ? "" : ((string)sdr["LinksEmail"]));
				model.SerPro = ((sdr["SerPro"] == DBNull.Value) ? "" : ((string)sdr["SerPro"]));
				model.OrgLanguage = ((sdr["OrgLanguage"] == DBNull.Value) ? "" : ((string)sdr["OrgLanguage"]));
				model.ToLanguage = ((sdr["ToLanguage"] == DBNull.Value) ? "" : ((string)sdr["ToLanguage"]));
				if (sdr["TxtCount"].ToString().Trim() != "")
				{
					model.TxtCount = Convert.ToInt32(sdr["TxtCount"].ToString().Trim());
				}
				else
				{
					model.TxtCount = 0;
				}
				model.TxtSCount = ((sdr["TxtSCount"] == DBNull.Value) ? "" : ((string)sdr["TxtSCount"]));
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
				model.gongzuori = ((sdr["gongzuori"] == DBNull.Value) ? "" : ((string)sdr["gongzuori"]));
				model.zhuyicontent = ((sdr["zhuyicontent"] == DBNull.Value) ? "" : ((string)sdr["zhuyicontent"]));
				model.Annex = ((sdr["Annex"] == DBNull.Value) ? "" : ((string)sdr["Annex"]));
				model.addTime = (DateTime)sdr["addTime"];
				model.ip = ((sdr["ip"] == DBNull.Value) ? "" : ((string)sdr["ip"]));
				if (sdr["Finish"].ToString().Trim() != "")
				{
					model.Finish = Convert.ToInt32(sdr["Finish"].ToString().Trim());
				}
				else
				{
					model.Finish = 0;
				}
				model.Note = ((sdr["Note"] == DBNull.Value) ? "" : ((string)sdr["Note"]));
			}
			sdr.Close();
		}
		return model;
	}

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
}
