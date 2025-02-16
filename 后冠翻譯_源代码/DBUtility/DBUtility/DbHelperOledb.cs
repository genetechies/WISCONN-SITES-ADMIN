using System;
using System.Collections;
using System.Data;
using System.Data.OleDb;

namespace DBUtility;

public abstract class DbHelperOledb
{
	public static string connectionString = PubConstant.ConnectionString;

	public DbHelperOledb()
	{
	}

	public static bool Exists(string strSql)
	{
		object obj = GetSingle(strSql);
		if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value) || int.Parse(obj.ToString()) == 0)
		{
			return false;
		}
		return true;
	}

	public static int ExecuteSql(string SQLString)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		try
		{
			connection.Open();
			return cmd.ExecuteNonQuery();
		}
		catch (OleDbException E)
		{
			connection.Close();
			throw new Exception(E.Message);
		}
	}

	public static int ExecuteSqlAlertTable(string SQLString, string connectionString)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		try
		{
			connection.Open();
			return cmd.ExecuteNonQuery();
		}
		catch (OleDbException E)
		{
			connection.Close();
			throw new Exception(E.Message);
		}
	}

	public static string ExecuteScalar(string SQLString)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		try
		{
			connection.Open();
			return cmd.ExecuteScalar().ToString();
		}
		catch (OleDbException E)
		{
			connection.Close();
			throw new Exception(E.Message);
		}
	}

	public static string GetMaxStringID(string FieldName, string TableName)
	{
		string strsql = "select max(" + FieldName + ") from " + TableName;
		object obj = GetSingle(strsql);
		if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
		{
			return "1";
		}
		return obj.ToString();
	}

	public static void ExecuteSqlTran(ArrayList SQLStringList)
	{
		using OleDbConnection conn = new OleDbConnection(connectionString);
		conn.Open();
		OleDbCommand cmd = new OleDbCommand();
		cmd.Connection = conn;
		OleDbTransaction tx = (cmd.Transaction = conn.BeginTransaction());
		try
		{
			for (int n = 0; n < SQLStringList.Count; n++)
			{
				string strsql = SQLStringList[n].ToString();
				if (strsql.Trim().Length > 1)
				{
					cmd.CommandText = strsql;
					cmd.ExecuteNonQuery();
				}
			}
			tx.Commit();
		}
		catch (OleDbException E)
		{
			tx.Rollback();
			throw new Exception(E.Message);
		}
	}

	public static int ExecuteSql(string SQLString, string content)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		OleDbParameter myParameter = new OleDbParameter("@content", OleDbType.Variant);
		myParameter.Value = content;
		cmd.Parameters.Add(myParameter);
		try
		{
			connection.Open();
			return cmd.ExecuteNonQuery();
		}
		catch (OleDbException E)
		{
			throw new Exception(E.Message);
		}
		finally
		{
			cmd.Dispose();
			connection.Close();
		}
	}

	public static int ExecuteScalar(string SQLString, string content)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		OleDbParameter myParameter = new OleDbParameter("@content", OleDbType.Variant);
		myParameter.Value = content;
		cmd.Parameters.Add(myParameter);
		try
		{
			connection.Open();
			return int.Parse(cmd.ExecuteScalar().ToString());
		}
		catch (OleDbException E)
		{
			throw new Exception(E.Message);
		}
		finally
		{
			cmd.Dispose();
			connection.Close();
		}
	}

	public static int ExecuteSqlInsertImg(string strSQL, byte[] fs)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		OleDbCommand cmd = new OleDbCommand(strSQL, connection);
		OleDbParameter myParameter = new OleDbParameter("@fs", OleDbType.Binary);
		myParameter.Value = fs;
		cmd.Parameters.Add(myParameter);
		try
		{
			connection.Open();
			return cmd.ExecuteNonQuery();
		}
		catch (OleDbException E)
		{
			throw new Exception(E.Message);
		}
		finally
		{
			cmd.Dispose();
			connection.Close();
		}
	}

	public static object GetSingle(string SQLString)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		try
		{
			connection.Open();
			object obj = cmd.ExecuteScalar();
			if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
			{
				return null;
			}
			return obj;
		}
		catch (OleDbException e)
		{
			connection.Close();
			throw new Exception(e.Message);
		}
	}

	public static OleDbDataReader ExecuteReader(string strSQL)
	{
		OleDbConnection connection = new OleDbConnection(connectionString);
		OleDbCommand cmd = new OleDbCommand(strSQL, connection);
		try
		{
			connection.Open();
			return cmd.ExecuteReader();
		}
		catch (OleDbException e)
		{
			throw new Exception(e.Message);
		}
	}

	public static DataSet Query(string SQLString)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		DataSet ds = new DataSet();
		try
		{
			connection.Open();
			OleDbDataAdapter command = new OleDbDataAdapter(SQLString, connection);
			command.Fill(ds, "ds");
		}
		catch (OleDbException ex)
		{
			//throw new Exception(ex.Message);
		}
		return ds;
	}

	public static DataSet GetDataSet(string SQLString)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		DataSet ds = new DataSet();
		try
		{
			connection.Open();
			OleDbDataAdapter command = new OleDbDataAdapter(SQLString, connection);
			command.Fill(ds, "ds");
		}
		catch (OleDbException ex)
		{
			throw new Exception(ex.Message);
		}
		return ds;
	}

	public static DataTable GetDataTable(string sql)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		try
		{
			connection.Open();
			OleDbDataAdapter Da = new OleDbDataAdapter(sql, connection);
			DataTable Dt = new DataTable();
			Da.Fill(Dt);
			return Dt;
		}
		catch (Exception e)
		{
			throw new Exception(e.Message, e);
		}
	}

	public static int GetMainKey(string SQLString, string FieldName, string TableName)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand(SQLString, connection);
		try
		{
			connection.Open();
			cmd.ExecuteNonQuery();
			return int.Parse(GetMaxStringID(FieldName, TableName));
		}
		catch (OleDbException E)
		{
			connection.Close();
			throw new Exception(E.Message);
		}
	}

	public static int ExecuteSql(string SQLString, params OleDbParameter[] cmdParms)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand();
		try
		{
			if (cmdParms != null)
			{
				foreach (OleDbParameter p in cmdParms)
				{
					if (p.Value == null)
					{
						p.Value = DBNull.Value;
					}
					else if (p.Value.ToString() == "0001-1-1 0:00:00")
					{
						p.Value = DateTime.Now.AddYears(-100);
					}
				}
			}
			PrepareCommand(cmd, connection, null, SQLString, cmdParms);
			int rows = cmd.ExecuteNonQuery();
			cmd.Parameters.Clear();
			return rows;
		}
		catch (OleDbException E)
		{
			throw new Exception(E.Message);
		}
		catch (Exception ee)
		{
			throw new Exception(ee.Message);
		}
	}

	public static int ExecuteScalar(string SQLString, params OleDbParameter[] cmdParms)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand();
		try
		{
			if (cmdParms != null)
			{
				foreach (OleDbParameter p in cmdParms)
				{
					if (p.Value == null)
					{
						p.Value = DBNull.Value;
					}
					else if (p.Value.ToString() == "0001-1-1 0:00:00")
					{
						p.Value = DateTime.Now.AddYears(-100);
					}
				}
			}
			PrepareCommand(cmd, connection, null, SQLString, cmdParms);
			int rows = int.Parse(cmd.ExecuteScalar().ToString());
			cmd.Parameters.Clear();
			return rows;
		}
		catch (OleDbException E)
		{
			throw new Exception(E.Message);
		}
		catch (Exception ee)
		{
			throw new Exception(ee.Message);
		}
	}

	public static void ExecuteSqlTran(Hashtable SQLStringList)
	{
		using OleDbConnection conn = new OleDbConnection(connectionString);
		conn.Open();
		using OleDbTransaction trans = conn.BeginTransaction();
		OleDbCommand cmd = new OleDbCommand();
		try
		{
			foreach (DictionaryEntry myDE in SQLStringList)
			{
				string cmdText = myDE.Key.ToString();
				OleDbParameter[] cmdParms = (OleDbParameter[])myDE.Value;
				PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
				int val = cmd.ExecuteNonQuery();
				cmd.Parameters.Clear();
			}
			trans.Commit();
		}
		catch (OleDbException E)
		{
			trans.Rollback();
			throw new Exception(E.Message);
		}
	}

	public static object GetSingle(string SQLString, params OleDbParameter[] cmdParms)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		using OleDbCommand cmd = new OleDbCommand();
		try
		{
			PrepareCommand(cmd, connection, null, SQLString, cmdParms);
			object obj = cmd.ExecuteScalar();
			cmd.Parameters.Clear();
			if (object.Equals(obj, null) || object.Equals(obj, DBNull.Value))
			{
				return null;
			}
			return obj;
		}
		catch (OleDbException e)
		{
			throw new Exception(e.Message);
		}
	}

	public static OleDbDataReader ExecuteReader(string SQLString, params OleDbParameter[] cmdParms)
	{
		OleDbConnection connection = new OleDbConnection(connectionString);
		OleDbCommand cmd = new OleDbCommand();
		try
		{
			PrepareCommand(cmd, connection, null, SQLString, cmdParms);
			OleDbDataReader myReader = cmd.ExecuteReader();
			cmd.Parameters.Clear();
			return myReader;
		}
		catch (OleDbException e)
		{
			throw new Exception(e.Message);
		}
	}

	public static DataSet Query(string SQLString, params OleDbParameter[] cmdParms)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		OleDbCommand cmd = new OleDbCommand();
		PrepareCommand(cmd, connection, null, SQLString, cmdParms);
		using OleDbDataAdapter da = new OleDbDataAdapter(cmd);
		DataSet ds = new DataSet();
		try
		{
			da.Fill(ds, "ds");
			cmd.Parameters.Clear();
		}
		catch (OleDbException ex)
		{
			throw new Exception(ex.Message);
		}
		return ds;
	}

	private static void PrepareCommand(OleDbCommand cmd, OleDbConnection conn, OleDbTransaction trans, string cmdText, OleDbParameter[] cmdParms)
	{
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		cmd.Connection = conn;
		cmd.CommandText = cmdText;
		if (trans != null)
		{
			cmd.Transaction = trans;
		}
		cmd.CommandType = CommandType.Text;
		if (cmdParms != null)
		{
			foreach (OleDbParameter parm in cmdParms)
			{
				cmd.Parameters.Add(parm);
			}
		}
	}

	public static OleDbDataReader RunProcedure(string storedProcName, IDataParameter[] parameters)
	{
		OleDbConnection connection = new OleDbConnection(connectionString);
		connection.Open();
		OleDbCommand command = BuildQueryCommand(connection, storedProcName, parameters);
		command.CommandType = CommandType.StoredProcedure;
		return command.ExecuteReader();
	}

	private static OleDbCommand BuildQueryCommand(OleDbConnection connection, string storedProcName, IDataParameter[] parameters)
	{
		OleDbCommand command = new OleDbCommand(storedProcName, connection);
		command.CommandType = CommandType.StoredProcedure;
		for (int i = 0; i < parameters.Length; i++)
		{
			OleDbParameter parameter = (OleDbParameter)parameters[i];
			command.Parameters.Add(parameter);
		}
		return command;
	}

	public static int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
	{
		using OleDbConnection connection = new OleDbConnection(connectionString);
		connection.Open();
		OleDbCommand command = BuildIntCommand(connection, storedProcName, parameters);
		rowsAffected = command.ExecuteNonQuery();
		return (int)command.Parameters["ReturnValue"].Value;
	}

	private static OleDbCommand BuildIntCommand(OleDbConnection connection, string storedProcName, IDataParameter[] parameters)
	{
		OleDbCommand command = BuildQueryCommand(connection, storedProcName, parameters);
		command.Parameters.Add(new OleDbParameter("ReturnValue", OleDbType.Integer, 4, ParameterDirection.ReturnValue, isNullable: false, 0, 0, string.Empty, DataRowVersion.Default, null));
		return command;
	}
}
