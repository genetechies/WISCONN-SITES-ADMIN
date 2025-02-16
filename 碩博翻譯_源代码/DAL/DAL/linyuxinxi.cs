using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class linyuxinxi
{
	public int CountByClass(string where)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from linyuxinxi ");
		if (!string.IsNullOrEmpty(where))
		{
			sql.Append(" where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public bool UpdateState(int P_Id, int state)
	{
		string sql = "update linyuxinxi set hst=" + state + " where id=" + P_Id;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public int Count(string where)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from linyuxinxi where " + where);
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public DataSet GetoutList()
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select linyuxinxi.id as 編號,linyuxinxi.title as 企業名稱,linyuclass.ClassName as 所屬洲類別  from linyuxinxi,linyuclass  where linyuxinxi.linyuclassid=linyuclass.id  order by linyuxinxi.id desc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(id) as MaxKey  from linyuxinxi";
		if (!string.IsNullOrEmpty(strWhere))
		{
			sql = sql + " where " + strWhere;
		}
		int maxkey = 0;
		int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
		return maxkey;
	}

	public DataSet GetAll()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname from linyuxinxi order by Sort");
		return DbHelperOledb.Query(sql.ToString());
	}

	public bool Exists(Model.linyuxinxi model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from linyuxinxi");
		sql.Append(" where title='" + model.title + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Add(Model.linyuxinxi model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into linyuxinxi(");
		sql.Append("title,Sort,linyuclassid,C_show)");
		sql.Append(" values (");
		sql.Append("@title,@Sort,@linyuclassid,@C_show)");
		OleDbParameter[] parameters = new OleDbParameter[4]
		{
			new OleDbParameter("@title", OleDbType.VarChar, 100),
			new OleDbParameter("@Sort", OleDbType.Integer, 4),
			new OleDbParameter("@linyuclassid", OleDbType.Integer, 4),
			new OleDbParameter("@C_show", OleDbType.Integer, 4)
		};
		parameters[0].Value = model.title;
		parameters[1].Value = model.Sort;
		parameters[2].Value = model.linyuclassid;
		parameters[3].Value = model.C_show;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Update(Model.linyuxinxi model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update linyuxinxi Set ");
		sql.Append("title='" + model.title + "',");
		sql.Append("Sort=" + model.Sort + ",");
		sql.Append("linyuclassid=" + model.linyuclassid + ", ");
		sql.Append("C_show=" + model.C_show + " ");
		sql.Append((" where id=" + model.id) ?? "");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public Model.linyuxinxi GetModel(int nc_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select id,title,Sort,linyuclassid,C_show from linyuxinxi ");
		strSql.Append(" where id=@nc_Id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@nc_Id", OleDbType.Integer, 4)
		};
		parameters[0].Value = nc_Id;
		Model.linyuxinxi model = new Model.linyuxinxi();
		DataSet ds = DbHelperOledb.Query(strSql.ToString(), parameters);
		if (ds.Tables[0].Rows.Count > 0)
		{
			if (ds.Tables[0].Rows[0]["id"].ToString() != "")
			{
				model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
			}
			model.title = ds.Tables[0].Rows[0]["title"].ToString();
			if (ds.Tables[0].Rows[0]["Sort"].ToString() != "")
			{
				model.Sort = int.Parse(ds.Tables[0].Rows[0]["Sort"].ToString());
			}
			if (ds.Tables[0].Rows[0]["linyuclassid"].ToString() != "")
			{
				model.linyuclassid = int.Parse(ds.Tables[0].Rows[0]["linyuclassid"].ToString());
			}
			if (ds.Tables[0].Rows[0]["C_show"].ToString() != "")
			{
				model.C_show = int.Parse(ds.Tables[0].Rows[0]["C_show"].ToString());
			}
			return model;
		}
		return null;
	}

	public bool Delete(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from linyuxinxi ");
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

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname ");
		strSql.Append(" from linyuxinxi ");
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
		strSql.Append("select top " + num + " *,(select ClassName from linyuclass where linyuclass.id=linyuxinxi.linyuclassid) as linyuclassname ");
		strSql.Append(" from linyuxinxi ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by sort");
		return DbHelperOledb.Query(strSql.ToString());
	}
}
