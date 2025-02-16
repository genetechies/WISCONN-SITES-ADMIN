using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class PageClass
{
	public int Count(string where)
	{
		StringBuilder sql = new StringBuilder();
		if (string.IsNullOrEmpty(where))
		{
			sql.Append("Select count(1) from PageClass");
		}
		else
		{
			sql.Append("select count(1) from PageClass where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public bool Exists(Model.PageClass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from PageClass");
		sql.Append(" where ClassName='" + model.ClassName + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public DataSet GetAll()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select * from PageClass order by OrderID");
		return DbHelperOledb.Query(sql.ToString());
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(classid) as MaxKey  from PageClass";
		if (!string.IsNullOrEmpty(strWhere))
		{
			sql = sql + " where " + strWhere;
		}
		int maxkey = 0;
		int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
		return maxkey;
	}

	public DataSet GetListByClass(string strWhere, string orderby)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select *,(select ClassName from PageClass t2 where t2.classid=t1.ParentID) as parentclassname  FROM PageClass t1 ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		if (!string.IsNullOrEmpty(orderby))
		{
			strSql.Append(" order by " + orderby);
		}
		else
		{
			strSql.Append(" order by classid desc");
		}
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select classid,ClassName,OrderID,(select ClassName from PageClass t2 where t2.classid=t1.ParentID) as parentclassname FROM PageClass t1 ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by OrderID asc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetList_top(int num, string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select top " + num + " classid,ClassName FROM PageClass  ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by OrderID asc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public void UpdateState(int P_Id, int state)
	{
		string sql = "update PageClass set P_State=" + state + " where classid=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}

	public Model.PageClass GetModel(int P_ID)
	{
		Model.PageClass model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from PageClass where classid=@P_ID";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@P_ID", P_ID);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.PageClass();
				model.classid = P_ID;
				model.ClassName = ((sdr["ClassName"] == DBNull.Value) ? "" : ((string)sdr["ClassName"]));
				model.username = ((sdr["username"] == DBNull.Value) ? "" : ((string)sdr["username"]));
				model.ParentID = (int)sdr["ParentID"];
				model.OrderID = (int)sdr["OrderID"];
				model.C_show = Convert.ToBoolean(sdr["C_show"]);
				model.D_Content = ((sdr["D_Content"] == DBNull.Value) ? "" : ((string)sdr["D_Content"]));
				model.D_Keyword = ((sdr["D_Keyword"] == DBNull.Value) ? "" : ((string)sdr["D_Keyword"]));
				model.D_Description = ((sdr["D_Description"] == DBNull.Value) ? "" : ((string)sdr["D_Description"]));
				if (sdr["P_State"].ToString() != "")
				{
					model.P_State = Convert.ToInt32(sdr["P_State"].ToString());
				}
				if (sdr["addtime"].ToString() != "")
				{
					model.addtime = Convert.ToDateTime(sdr["addtime"].ToString());
				}
				if (sdr["D_Count"].ToString() != "")
				{
					model.D_Count = Convert.ToInt32(sdr["D_Count"].ToString());
				}
				model.Title = ((sdr["Title"] == DBNull.Value) ? "" : ((string)sdr["Title"]));
			}
			sdr.Close();
		}
		return model;
	}

	public void UpdaetSortKey(int P_Id, int sortkey)
	{
		string sql = "update PageClass set OrderID=" + sortkey + " where classid=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}

	public void Update_click(int id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("update PageClass set ");
		strSql.Append("D_Count=D_Count+1");
		strSql.Append(" where classid=@id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@id", OleDbType.Integer, 4)
		};
		parameters[0].Value = id;
		DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
	}

	public int CountByClass(string where)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from PageClass ");
		if (!string.IsNullOrEmpty(where))
		{
			sql.Append(" where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public void Add(Model.PageClass model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "insert into PageClass(ClassName,username,ParentID,OrderID,C_show,D_Content,D_Keyword,D_Description,P_State,Title) values(@ClassName,@username,@ParentID,@OrderID,@C_show,@D_Content,@D_Keyword,@D_Description,@P_State,@Title)";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
		cmd.Parameters.AddWithValue("@username", model.username);
		cmd.Parameters.AddWithValue("@ParentID", model.ParentID);
		cmd.Parameters.AddWithValue("@OrderID", model.OrderID);
		cmd.Parameters.AddWithValue("@C_show", model.C_show);
		cmd.Parameters.AddWithValue("@D_Content", model.D_Content);
		cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
		cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
		cmd.Parameters.AddWithValue("@P_State", model.P_State);
		cmd.Parameters.AddWithValue("@Title", model.Title);
		cmd.ExecuteNonQuery();
	}

	public void Update(Model.PageClass model)
	{
		using OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString);
		if (conn.State != ConnectionState.Open)
		{
			conn.Open();
		}
		string sql = "update PageClass set ClassName=@ClassName,username=@username,ParentID=@ParentID,C_show=@C_show,D_Content=@D_Content,D_Keyword=@D_Keyword,D_Description=@D_Description,Title=@Title where classid=@P_ID";
		OleDbCommand cmd = new OleDbCommand(sql, conn);
		cmd.Parameters.AddWithValue("@ClassName", model.ClassName);
		cmd.Parameters.AddWithValue("@username", model.username);
		cmd.Parameters.AddWithValue("@ParentID", model.ParentID);
		cmd.Parameters.AddWithValue("@C_show", model.C_show);
		cmd.Parameters.AddWithValue("@D_Content", model.D_Content);
		cmd.Parameters.AddWithValue("@D_Keyword", model.D_Keyword);
		cmd.Parameters.AddWithValue("@D_Description", model.D_Description);
		cmd.Parameters.AddWithValue("@Title", model.Title);
		cmd.Parameters.AddWithValue("@P_ID", model.classid);
		cmd.ExecuteNonQuery();
	}

	public bool AddSmall(Model.PageClass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into PageClass(");
		sql.Append("ClassName,OrderID,ParentID)");
		sql.Append(" values (");
		sql.Append("@ClassName,@OrderID,@ParentID)");
		OleDbParameter[] parameters = new OleDbParameter[3]
		{
			new OleDbParameter("@ClassName", OleDbType.VarChar, 50),
			new OleDbParameter("@OrderID", OleDbType.Integer, 4),
			new OleDbParameter("@ParentID", OleDbType.Integer, 4)
		};
		parameters[0].Value = model.ClassName;
		parameters[1].Value = model.OrderID;
		parameters[2].Value = model.ParentID;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool UpdateSmall(Model.PageClass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update PageClass Set ");
		sql.Append("ClassName='" + model.ClassName + "',");
		sql.Append("OrderID=" + model.OrderID + ", ");
		sql.Append("ParentID=" + model.ParentID + " ");
		sql.Append((" where classid=" + model.classid) ?? "");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Delete(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from PageClass ");
		sql.Append(" where classid=@NC_Id");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@NC_Id", OleDbType.Integer, 4)
		};
		parameters[0].Value = id;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}
}
