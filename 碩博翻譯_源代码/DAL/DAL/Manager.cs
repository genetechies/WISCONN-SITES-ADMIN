using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class Manager
{
	public void Add(Model.Manager model)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("insert into Manager(");
		strSql.Append("M_AdminName,M_Password)");
		strSql.Append(" values (");
		strSql.Append("@AdminName,@Password)");
		OleDbParameter[] parameters = new OleDbParameter[2]
		{
			new OleDbParameter("@AdminName", OleDbType.VarChar, 50),
			new OleDbParameter("@Password", OleDbType.VarChar, 50)
		};
		parameters[0].Value = model.AdminName;
		parameters[1].Value = model.Password;
		DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
	}

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
		return false;
	}

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
		return false;
	}

	public Model.Manager GetModel(int m_id)
	{
		Model.Manager model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from Manager where M_id=@M_id";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@M_id", m_id);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
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

	public DataSet GetAll()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select * from Manager");
		return DbHelperOledb.Query(sql.ToString());
	}

	public bool CountIsOne()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select count(*) from Manager");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i == 1)
		{
			return true;
		}
		return false;
	}

	public bool Delete(int M_ID)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from Manager where M_ID=");
		sql.Append(M_ID);
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Update(Model.Manager model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update Manager set ");
		sql.Append("M_Password='" + model.Password + "'");
		sql.Append(" where M_AdminName='" + model.AdminName + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}
}
