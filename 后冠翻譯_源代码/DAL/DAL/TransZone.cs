using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class TransZone
{
	public bool Exists(Model.guoclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from TranszoneType");
		sql.Append(" where NC_ClassName='" + model.ClassName + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public int Add(Model.guoclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into TranszoneType(");
		sql.Append("NC_ClassName,NC_Sort,D_Keyword,D_Description)");
		sql.Append(" values (");
		sql.Append("@NC_ClassName,@NC_Sort,@D_Keyword,@D_Description)");
		OleDbParameter[] parameters = new OleDbParameter[4]
		{
			new OleDbParameter("@NC_ClassName", OleDbType.VarChar, 50),
			new OleDbParameter("@NC_Sort", OleDbType.Integer, 4),
			new OleDbParameter("@D_Keyword", OleDbType.VarChar, 500),
			new OleDbParameter("@D_Description", OleDbType.VarChar, 500)
		};
		parameters[0].Value = model.ClassName;
		parameters[1].Value = model.Sort;
		parameters[2].Value = model.Keywords;
		parameters[3].Value = model.Description;
		return Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
	}

	public bool Update(Model.guoclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update TranszoneType Set ");
		sql.Append("NC_ClassName='" + model.ClassName + "',");
		sql.Append("NC_Sort=" + model.Sort + ", ");
		sql.Append("D_Keyword='" + model.Keywords + "',");
		sql.Append("D_Description='" + model.Description + "'");
		sql.Append((" where NC_Id=" + model.Id) ?? "");
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
		sql.Append("delete from TranszoneType ");
		sql.Append(" where NC_Id=@NC_Id");
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

	public DataSet GetAll()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select * from TranszoneType order by NC_Sort");
		return DbHelperOledb.Query(sql.ToString());
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(nc_Id) as MaxKey  from TranszoneType";
		if (!string.IsNullOrEmpty(strWhere))
		{
			sql = sql + " where " + strWhere;
		}
		int maxkey = 0;
		int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
		return maxkey;
	}

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select * from TranszoneType");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by nc_Sort");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public Model.guoclass GetModel(int nc_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select nc_Id,nc_ClassName,nc_Sort,D_Keyword,D_Description from TranszoneType ");
		strSql.Append(" where nc_Id=@nc_Id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@nc_Id", OleDbType.Integer, 4)
		};
		parameters[0].Value = nc_Id;
		Model.guoclass model = new Model.guoclass();
		DataSet ds = DbHelperOledb.Query(strSql.ToString(), parameters);
		if (ds.Tables[0].Rows.Count > 0)
		{
			if (ds.Tables[0].Rows[0]["nc_Id"].ToString() != "")
			{
				model.Id = int.Parse(ds.Tables[0].Rows[0]["nc_Id"].ToString());
			}
			model.ClassName = ds.Tables[0].Rows[0]["nc_ClassName"].ToString();
			if (ds.Tables[0].Rows[0]["nc_Sort"].ToString() != "")
			{
				model.Sort = int.Parse(ds.Tables[0].Rows[0]["nc_Sort"].ToString());
			}
			model.Keywords = ds.Tables[0].Rows[0]["D_Keyword"].ToString();
			model.Description = ds.Tables[0].Rows[0]["D_Description"].ToString();
			return model;
		}
		return null;
	}

	public Model.guoclass GetModel_where(string where)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select nc_Id,nc_ClassName,nc_Sort,D_Keyword,D_Description from TranszoneType where " + where);
		Model.guoclass model = new Model.guoclass();
		DataSet ds = DbHelperOledb.Query(strSql.ToString());
		if (ds.Tables[0].Rows.Count > 0)
		{
			if (ds.Tables[0].Rows[0]["nc_Id"].ToString() != "")
			{
				model.Id = int.Parse(ds.Tables[0].Rows[0]["nc_Id"].ToString());
			}
			model.ClassName = ds.Tables[0].Rows[0]["nc_ClassName"].ToString();
			if (ds.Tables[0].Rows[0]["nc_Sort"].ToString() != "")
			{
				model.Sort = int.Parse(ds.Tables[0].Rows[0]["nc_Sort"].ToString());
			}
			model.Keywords = ds.Tables[0].Rows[0]["D_Keyword"].ToString();
			model.Description = ds.Tables[0].Rows[0]["D_Description"].ToString();
			return model;
		}
		return null;
	}

	public int CountNew(string where)
	{
		StringBuilder sql = new StringBuilder();
		if (string.IsNullOrEmpty(where))
		{
			sql.Append("Select count(1) from TransZone");
		}
		else
		{
			sql.Append("select count(1) from TransZone where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public bool ExistsNew(Model.newsdata model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from TransZone");
		sql.Append(" where D_Title='" + model.D_Title + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public DataSet GetAllNew()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select * from TransZone order by D_ID");
		return DbHelperOledb.Query(sql.ToString());
	}

	public int GetMaxSortKeyNew(string strWhere)
	{
		string sql = "select count(D_ID) as MaxKey  from TransZone";
		if (!string.IsNullOrEmpty(strWhere))
		{
			sql = sql + " where " + strWhere;
		}
		int maxkey = 0;
		int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
		return maxkey;
	}

	public DataSet GetListByClassNew(string strWhere, string orderby)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select *,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName  FROM TransZone t1 ");
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

	public DataSet GetListNew(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select D_ID,D_Title,OrderID,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName FROM TransZone t1 ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by OrderID");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetList_topNew(int num, string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select top " + num + " D_ID,D_Title,OrderID,(select NC_ClassName from TranszoneType t2 where t2.NC_ID=t1.D_ClassID) as ClassName FROM TransZone t1  ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by D_ID desc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public void UpdateStateNew(int P_Id, int state)
	{
		string sql = "update TransZone set D_Recycle=" + state + " where D_ID=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}

	public Model.newsdata GetModelNew(int P_ID)
	{
		Model.newsdata model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from TransZone where D_ID=@P_ID";
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

	public void UpdaetSortKeyNew(int P_Id, int sortkey)
	{
		string sql = "update TransZone set OrderID=" + sortkey + " where D_ID=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}

	public int CountByClassNew(string where)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from TransZone ");
		if (!string.IsNullOrEmpty(where))
		{
			sql.Append(" where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public bool AddNew(Model.newsdata model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into TransZone(");
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

	public bool UpdateNew(Model.newsdata model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update TransZone Set ");
		sql.Append("D_ClassID=" + model.D_ClassID + ",");
		sql.Append("D_Title='" + model.D_Title + "', ");
		sql.Append("D_Editor='" + model.D_Editor + "', ");
		sql.Append("D_Keyword='" + model.D_Keyword + "',");
		sql.Append("D_Description='" + model.D_Description + "', ");
		sql.Append("D_Content='" + model.D_Content + "' ");
		sql.Append((" where D_ID=" + model.D_ID) ?? "");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public void Update_clickNew(int id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("update TransZone set ");
		strSql.Append("D_Count=D_Count+1");
		strSql.Append(" where D_ID=@id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@id", OleDbType.Integer, 4)
		};
		parameters[0].Value = id;
		DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
	}

	public bool DeleteNew(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from TransZone ");
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

	public DataTable GetTop5CloseNews(string keys, string title)
	{
		string sql = "select top 5 * from TransZone where ";
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
}
