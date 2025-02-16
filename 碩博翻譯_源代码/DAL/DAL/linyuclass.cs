using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class linyuclass
{
	public DataSet GetAll()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select *,(select NC_ClassName from guoclass where guoclass.NC_Id=linyuclass.guoclassid) as guojianame from linyuclass order by Sort");
		return DbHelperOledb.Query(sql.ToString());
	}

	public bool Exists(Model.linyuclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from linyuclass");
		sql.Append(" where ClassName='" + model.ClassName + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public int Add(Model.linyuclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into linyuclass(");
		sql.Append("ClassName,Sort,guoclassid)");
		sql.Append(" values (");
		sql.Append("@ClassName,@Sort,@guoclassid)");
		OleDbParameter[] parameters = new OleDbParameter[3]
		{
			new OleDbParameter("@ClassName", OleDbType.VarChar, 100),
			new OleDbParameter("@Sort", OleDbType.Integer, 4),
			new OleDbParameter("@guoclassid", OleDbType.Integer, 4)
		};
		parameters[0].Value = model.ClassName;
		parameters[1].Value = model.Sort;
		parameters[2].Value = model.guoclassid;
		return Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
	}

	public bool Update(Model.linyuclass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update linyuclass Set ");
		sql.Append("ClassName='" + model.ClassName + "',");
		sql.Append("Sort=" + model.Sort + ",");
		sql.Append("guoclassid=" + model.guoclassid + " ");
		sql.Append((" where id=" + model.id) ?? "");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(id) as MaxKey  from linyuclass";
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
		strSql.Append("select id,ClassName,Sort ");
		strSql.Append(" from linyuclass ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by sort");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetList_top(int num, string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select top " + num + " id,ClassName,Sort ");
		strSql.Append(" from linyuclass ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by sort");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public Model.linyuclass GetModel(int nc_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select id,ClassName,Sort,guoclassid from linyuclass ");
		strSql.Append(" where id=@nc_Id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@nc_Id", OleDbType.Integer, 4)
		};
		parameters[0].Value = nc_Id;
		Model.linyuclass model = new Model.linyuclass();
		DataSet ds = DbHelperOledb.Query(strSql.ToString(), parameters);
		if (ds.Tables[0].Rows.Count > 0)
		{
			if (ds.Tables[0].Rows[0]["id"].ToString() != "")
			{
				model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
			}
			model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
			if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
			{
				model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
			}
			if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
			{
				model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
			}
			return model;
		}
		return null;
	}

	public Model.linyuclass GetModel_where(string where)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select id,ClassName,Sort,guoclassid from linyuclass where " + where);
		Model.linyuclass model = new Model.linyuclass();
		DataSet ds = DbHelperOledb.Query(strSql.ToString());
		if (ds.Tables[0].Rows.Count > 0)
		{
			if (ds.Tables[0].Rows[0]["id"].ToString() != "")
			{
				model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
			}
			model.ClassName = ds.Tables[0].Rows[0]["ClassName"].ToString();
			if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
			{
				model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
			}
			if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
			{
				model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
			}
			return model;
		}
		return null;
	}

	public bool Delete(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from linyuclass ");
		sql.Append(" where id=@NC_Id");
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
