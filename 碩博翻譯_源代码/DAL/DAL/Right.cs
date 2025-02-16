using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class Right
{
	public bool Exists(string username, string pagename)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select count(1) from [Right]");
		strSql.Append(" where UserName='" + username + "' and PageName='" + pagename + "'");
		return DbHelperOledb.Exists(strSql.ToString());
	}

	public void Add(Model.Right model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "insert into [Right](UserName,PageName,Rights) values(@UserName,@PageName,@Right)";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@UserName", model.UserName);
		cmd.Parameters.AddWithValue("@PageName", model.PageName);
		cmd.Parameters.AddWithValue("@Right", model.Rights);
		cmd.ExecuteNonQuery();
	}

	public void Update(Model.Right model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "update [Right] set UserName=@UserName,PageName=@PageName,Rights=@Right where RightID=@RightID";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@UserName", model.UserName);
		cmd.Parameters.AddWithValue("@PageName", model.PageName);
		cmd.Parameters.AddWithValue("@Right", model.Rights);
		cmd.Parameters.AddWithValue("@RightID", model.RightID);
		cmd.ExecuteNonQuery();
	}

	public void Delete(int RightID)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("delete from [Right] ");
		strSql.Append(" where RightID=" + RightID + " ");
		DbHelperOledb.ExecuteSql(strSql.ToString());
	}

	public Model.Right GetModel(int RightID)
	{
		Model.Right model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from [Right] where RightID=@RightID";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@RightID", RightID);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.Right();
				model.RightID = RightID;
				model.UserName = (string)sdr["UserName"];
				model.PageName = ((sdr["PageName"] == DBNull.Value) ? "" : ((string)sdr["PageName"]));
				model.Rights = (int)sdr["Rights"];
			}
			sdr.Close();
		}
		return model;
	}

	public Model.Right GetModel(string username, string pagename)
	{
		Model.Right model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from [Right] where UserName=@UserName and PageName=@PageName";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@UserName", username);
			cmd.Parameters.AddWithValue("@PageName", pagename);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.Right();
				model.RightID = (int)sdr["RightID"];
				model.UserName = username;
				model.PageName = pagename;
				model.Rights = (int)sdr["Rights"];
			}
			sdr.Close();
		}
		return model;
	}
}
