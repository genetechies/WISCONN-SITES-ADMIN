using System;
using System.Data;
using System.Data.OleDb;
using DBUtility;
using Model;

namespace DAL;

public class sysconfig
{
	public void Update(Model.sysconfig model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "update sysconfig set sys_Title=@sys_Title,searchkey=@searchkey,sys_description=@sys_description where id=@id";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@sys_Title", model.sys_Title);
		cmd.Parameters.AddWithValue("@searchkey", model.searchkey);
		cmd.Parameters.AddWithValue("@sys_description", model.sys_description);
		cmd.Parameters.AddWithValue("@id", model.id);
		cmd.ExecuteNonQuery();
	}

	public Model.sysconfig GetModel(int id)
	{
		Model.sysconfig model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from sysconfig where id=@id";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@id", id);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.sysconfig();
				model.id = id;
				model.sys_Title = ((sdr["sys_Title"] == DBNull.Value) ? "" : ((string)sdr["sys_Title"]));
				model.searchkey = ((sdr["searchkey"] == DBNull.Value) ? "" : ((string)sdr["searchkey"]));
				model.sys_description = ((sdr["sys_description"] == DBNull.Value) ? "" : ((string)sdr["sys_description"]));
			}
			sdr.Close();
		}
		return model;
	}
}
