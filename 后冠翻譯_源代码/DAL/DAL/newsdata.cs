using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class newsdata
{
	public int Count(string where)
	{
		StringBuilder sql = new StringBuilder();
		if (string.IsNullOrEmpty(where))
		{
			sql.Append("Select count(1) from newsdata");
		}
		else
		{
			sql.Append("select count(1) from newsdata where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public bool Exists(Model.newsdata model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from newsdata");
		sql.Append(" where D_Title='" + model.D_Title + "'");
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
		sql.Append("Select * from newsdata order by D_ID");
		return DbHelperOledb.Query(sql.ToString());
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(D_ID) as MaxKey  from newsdata";
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
		strSql.Append("select *,(select ClassName from NewsClass t2 where t2.ClassID=t1.D_ClassID) as ClassName  FROM newsdata t1 ");
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
			strSql.Append(" order by D_ID desc");
		}
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select D_ID,D_Title,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.D_ClassID) as ClassName FROM newsdata t1 ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by OrderID");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetList_top(int num, string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select top " + num + " D_ID,D_Title,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.D_ClassID) as ClassName FROM newsdata t1  ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by D_ID desc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public void UpdateState(int P_Id, int state)
	{
		string sql = "update newsdata set D_Recycle=" + state + " where D_ID=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}

	public Model.newsdata GetModel(int P_ID)
	{
		Model.newsdata model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from newsdata where D_ID=@P_ID";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@P_ID", P_ID);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.newsdata();
				if (sdr["D_ID"].ToString() != "")
				{
					model.D_ID = Convert.ToInt32(sdr["D_ID"].ToString());
				}
				if (sdr["D_ClassID"].ToString() != "")
				{
					model.D_ClassID = Convert.ToInt32(sdr["D_ClassID"].ToString());
				}
				model.D_Title = ((sdr["D_Title"] == DBNull.Value) ? "" : ((string)sdr["D_Title"]));
				if (sdr["D_Time"].ToString() != "")
				{
					model.D_Time = Convert.ToDateTime(sdr["D_Time"].ToString());
				}
				model.D_Author = ((sdr["D_Author"] == DBNull.Value) ? "" : ((string)sdr["D_Author"]));
				model.D_Source = ((sdr["D_Source"] == DBNull.Value) ? "" : ((string)sdr["D_Source"]));
				model.D_Content = ((sdr["D_Content"] == DBNull.Value) ? "" : ((string)sdr["D_Content"]));
				model.D_Picture = ((sdr["D_Picture"] == DBNull.Value) ? "" : ((string)sdr["D_Picture"]));
				model.D_Editor = ((sdr["D_Editor"] == DBNull.Value) ? "" : ((string)sdr["D_Editor"]));
				model.D_OriginalFileName = ((sdr["D_OriginalFileName"] == DBNull.Value) ? "" : ((string)sdr["D_OriginalFileName"]));
				model.D_SaveFileName = ((sdr["D_SaveFileName"] == DBNull.Value) ? "" : ((string)sdr["D_SaveFileName"]));
				model.D_SavePathFileName = ((sdr["D_SavePathFileName"] == DBNull.Value) ? "" : ((string)sdr["D_SavePathFileName"]));
				if (sdr["D_Num"].ToString() != "")
				{
					model.D_Num = Convert.ToInt32(sdr["D_Num"].ToString());
				}
				if (sdr["D_Count"].ToString() != "")
				{
					model.D_Count = Convert.ToInt32(sdr["D_Count"].ToString());
				}
				if (sdr["D_Recycle"].ToString() != "")
				{
					model.D_Recycle = Convert.ToInt32(sdr["D_Recycle"].ToString());
				}
				if (sdr["D_RecycleTime"].ToString() != "")
				{
					model.D_RecycleTime = Convert.ToDateTime(sdr["D_RecycleTime"].ToString());
				}
				model.D_Description = ((sdr["D_Description"] == DBNull.Value) ? "" : ((string)sdr["D_Description"]));
				model.D_Keyword = ((sdr["D_Keyword"] == DBNull.Value) ? "" : ((string)sdr["D_Keyword"]));
				if (sdr["OrderID"].ToString() != "")
				{
					model.OrderID = Convert.ToInt32(sdr["OrderID"].ToString());
				}
			}
			sdr.Close();
		}
		return model;
	}

	public DataTable GetTop5CloseNews(string keys, string title)
	{
		string sql = "select top 5 * from newsdata where ";
		if (keys != "")
		{
			sql += keys;
		}
		if (title != "")
		{
			sql = sql + " and D_Title <> '" + title + "'";
		}
		sql += " order by OrderID desc";
		return DbHelperOledb.GetDataTable(sql.ToString());
	}

	public void UpdaetSortKey(int P_Id, int sortkey)
	{
		string sql = "update newsdata set OrderID=" + sortkey + " where D_ID=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}

	public int CountByClass(string where)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from newsdata ");
		if (!string.IsNullOrEmpty(where))
		{
			sql.Append(" where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public bool Add(Model.newsdata model)
    {
        StringBuilder sql = new StringBuilder();
		sql.Append("insert into newsdata(");
		sql.Append("D_ClassID,D_Title,D_Time,D_Editor,D_Recycle,D_Description,D_Keyword,OrderID,D_Content)");
		sql.Append(" values (");
		sql.Append("@D_ClassID,@D_Title,@D_Time,@D_Editor,@D_Recycle,@D_Description,@D_Keyword,@OrderID,@D_Content)");
		OleDbParameter[] parameters = new OleDbParameter[9]
		{
			new OleDbParameter("@D_ClassID", OleDbType.Integer, 4),
			new OleDbParameter("@D_Title", OleDbType.VarChar, 200),
			new OleDbParameter("@D_Time", OleDbType.Date),
			new OleDbParameter("@D_Editor", OleDbType.VarChar, 50),
			new OleDbParameter("@D_Recycle", OleDbType.Integer, 4),
			new OleDbParameter("@D_Description", OleDbType.LongVarChar),
			new OleDbParameter("@D_Keyword", OleDbType.LongVarChar),
			new OleDbParameter("@OrderID", OleDbType.Integer, 4),
			new OleDbParameter("@D_Content", OleDbType.LongVarChar)
		};
		parameters[0].Value = model.D_ClassID;
		parameters[1].Value = model.D_Title;
		parameters[2].Value = model.D_Time;
		parameters[3].Value = model.D_Editor;
		parameters[4].Value = model.D_Recycle;
		parameters[5].Value = model.D_Description;
		parameters[6].Value = model.D_Keyword;
		parameters[7].Value = model.OrderID;
		parameters[8].Value = model.D_Content;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Update(Model.newsdata model)
    {
        StringBuilder sql = new StringBuilder();
		sql.Append("Update newsdata Set ");
		sql.Append("D_ClassID=@D_ClassID,");
		sql.Append("D_Title=@D_Title, ");
		sql.Append("D_Editor=@D_Editor, ");
		sql.Append("D_Keyword=@D_Keyword,");
		sql.Append("D_Description=@D_Description, ");
		sql.Append("D_Content=@D_Content ");
		sql.Append(" where D_ID=@D_ID ");
		OleDbParameter[] parameters = new OleDbParameter[7]
		{
			new OleDbParameter("@D_ClassID", OleDbType.Integer, 4),
			new OleDbParameter("@D_Title", OleDbType.VarChar, 200),
			new OleDbParameter("@D_Editor", OleDbType.VarChar, 50),
			new OleDbParameter("@D_Keyword", OleDbType.LongVarChar),
			new OleDbParameter("@D_Description", OleDbType.LongVarChar),
			new OleDbParameter("@D_Content", OleDbType.LongVarChar),
			new OleDbParameter("@D_ID", OleDbType.Integer, 4)
		};
		parameters[0].Value = model.D_ClassID;
		parameters[1].Value = model.D_Title;
		parameters[2].Value = model.D_Editor;
		parameters[3].Value = model.D_Keyword;
		parameters[4].Value = model.D_Description;
		parameters[5].Value = model.D_Content;
		parameters[6].Value = model.D_ID;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public void Update_click(int id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("update newsdata set ");
		strSql.Append("D_Count=D_Count+1");
		strSql.Append(" where D_ID=@id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@id", OleDbType.Integer, 4)
		};
		parameters[0].Value = id;
		DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
	}

	public bool Delete(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from newsdata ");
		sql.Append(" where D_ID=@NC_Id");
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
