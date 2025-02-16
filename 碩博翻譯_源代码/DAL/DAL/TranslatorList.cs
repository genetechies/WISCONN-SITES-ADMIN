using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class TranslatorList
{
	public void Add(Model.TranslatorList model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql1 = "insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language],MasterLanguage,Experience,Seniority,TranslationAmount,Mark,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,Creator,CreateDate,state) values('" + model.UserName + "','" + model.Age + "','" + model.Sex + "','" + model.Country + "','" + model.WorkType + "','" + model.TopGraduation + "','" + model.IsLearning + "','" + model.Language + "','" + model.MasterLanguage + "','" + model.Experience + "','" + model.Seniority + "','" + model.TranslationAmount + "','" + model.Mark + "','" + model.TransLationSkill + "','" + model.SoftwareSkill + "','" + model.TEL + "','" + model.Email + "','" + model.QQ + "','" + model.MSN + "','" + model.Creator + "','" + model.CreateDate + "'," + model.state + ")";
		DbHelperOledb.ExecuteSql(sql1.ToString());
	}

	public Model.TranslatorList GetModel(int G_Id)
	{
		Model.TranslatorList model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from TranslatorList where ID=@G_Id";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@G_Id", G_Id);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.TranslatorList();
				model.ID = G_Id;
				model.UserName = ((sdr["UserName"] == DBNull.Value) ? "" : ((string)sdr["UserName"]));
				model.Age = ((sdr["Age"] == DBNull.Value) ? "" : ((string)sdr["Age"]));
				model.Sex = ((sdr["Sex"] == DBNull.Value) ? "" : ((string)sdr["Sex"]));
				model.Country = ((sdr["Country"] == DBNull.Value) ? "" : ((string)sdr["Country"]));
				model.WorkType = ((sdr["WorkType"] == DBNull.Value) ? "" : ((string)sdr["WorkType"]));
				model.TopGraduation = ((sdr["TopGraduation"] == DBNull.Value) ? "" : ((string)sdr["TopGraduation"]));
				model.IsLearning = ((sdr["IsLearning"] == DBNull.Value) ? "" : ((string)sdr["IsLearning"]));
				model.Language = ((sdr["Language"] == DBNull.Value) ? "" : ((string)sdr["Language"]));
				model.MasterLanguage = ((sdr["MasterLanguage"] == DBNull.Value) ? "" : ((string)sdr["MasterLanguage"]));
				model.Experience = ((sdr["Experience"] == DBNull.Value) ? "" : ((string)sdr["Experience"]));
				model.Seniority = ((sdr["Seniority"] == DBNull.Value) ? "" : ((string)sdr["Seniority"]));
				model.TranslationAmount = ((sdr["TranslationAmount"] == DBNull.Value) ? "" : ((string)sdr["TranslationAmount"]));
				model.Mark = ((sdr["Mark"] == DBNull.Value) ? "" : ((string)sdr["Mark"]));
				model.TransLationSkill = ((sdr["TransLationSkill"] == DBNull.Value) ? "" : ((string)sdr["TransLationSkill"]));
				model.SoftwareSkill = ((sdr["SoftwareSkill"] == DBNull.Value) ? "" : ((string)sdr["SoftwareSkill"]));
				model.TEL = ((sdr["TEL"] == DBNull.Value) ? "" : ((string)sdr["TEL"]));
				model.Email = ((sdr["Email"] == DBNull.Value) ? "" : ((string)sdr["Email"]));
				model.QQ = ((sdr["QQ"] == DBNull.Value) ? "" : ((string)sdr["QQ"]));
				model.MSN = ((sdr["MSN"] == DBNull.Value) ? "" : ((string)sdr["MSN"]));
				model.Creator = ((sdr["Creator"] == DBNull.Value) ? "" : ((string)sdr["Creator"]));
				model.CreateDate = ((sdr["CreateDate"] == DBNull.Value) ? "" : ((string)sdr["CreateDate"]));
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
		string sql = "update TranslatorList set state=@state where id=@G_Id";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@state", isfinish);
		cmd.Parameters.AddWithValue("@G_Id", G_Id);
		cmd.ExecuteNonQuery();
	}

	public int Count()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from TranslatorList");
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select * ");
		strSql.Append(" FROM TranslatorList ");
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
		strSql.Append("select ID as 編號,UserName as 姓名,Age as 年齡,Sex as 性別,TopGraduation as 最高學歷,CreateDate as 應聘時間,WorkType as 工作別,IsLearning as 是否在學,MasterLanguage as 主要語言,Seniority as 翻譯年資,TranslationAmount as 翻譯量,[Language] as 第二外語,TransLationSkill as 翻譯專長,SoftwareSkill as 專長軟件,TEL as 電話,Email,QQ,MSN,Experience as 翻譯經歷 ");
		strSql.Append(" FROM TranslatorList ");
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
		strSql.Append("delete from TranslatorList ");
		strSql.Append(" where id=" + G_Id + " ");
		DbHelperOledb.ExecuteSql(strSql.ToString());
	}
}
