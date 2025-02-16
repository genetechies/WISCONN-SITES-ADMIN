using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class guoclass
{
	public bool Exists(Model.guoclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from guoclass");
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
		sql.Append("insert into guoclass(");
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
		sql.Append("Update guoclass Set ");
		sql.Append("NC_ClassName='" + model.ClassName + "',");
		sql.Append("NC_Sort=" + model.Sort + ",");
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
		sql.Append("delete from guoclass ");
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
		sql.Append("Select * from guoclass order by NC_Sort");
		return DbHelperOledb.Query(sql.ToString());
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(nc_Id) as MaxKey  from guoclass";
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
		strSql.Append("select nc_Id,nc_ClassName,nc_Sort ");
		strSql.Append(" from guoclass ");
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
		strSql.Append("select nc_Id,nc_ClassName,nc_Sort,D_Keyword,D_Description from guoclass ");
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
		strSql.Append("select nc_Id,nc_ClassName,nc_Sort from guoclass where " + where);
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
			return model;
		}
		return null;
	}
}
