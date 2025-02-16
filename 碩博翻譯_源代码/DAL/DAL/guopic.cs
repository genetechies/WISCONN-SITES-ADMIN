using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class guopic
{
	public int Count(string where)
	{
		StringBuilder sql = new StringBuilder();
		if (string.IsNullOrEmpty(where))
		{
			sql.Append("Select count(1) from guopic");
		}
		else
		{
			sql.Append("select count(1) from guopic where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public DataSet GetoutList()
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select guopic.id as 編號,guopic.title as LOG圖片名稱,guopic.pic as LOG圖文件,guoclass.NC_ClassName as 服務項目類別  from guopic,guoclass  where guopic.guoclassid=guoclass.NC_Id  order by guopic.Sort desc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetListByClass(string strWhere, string orderby)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select *,(select NC_ClassName from guoclass where guoclass.NC_Id=guopic.guoclassid) as guojianame  FROM guopic ");
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

	public DataSet GetAll()
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Select *,(select NC_ClassName from guoclass where guoclass.NC_Id=guopic.guoclassid) as guojianame from guopic order by Sort");
		return DbHelperOledb.Query(sql.ToString());
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select max(id) as MaxKey  from guopic";
		if (!string.IsNullOrEmpty(strWhere))
		{
			sql = sql + " where " + strWhere;
		}
		int maxkey = 0;
		int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
		return maxkey;
	}

	public bool Exists(Model.guopic model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from guopic");
		sql.Append(" where title='" + model.title + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Add(Model.guopic model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into guopic(");
		sql.Append("title,Sort,guoclassid,pic)");
		sql.Append(" values (");
		sql.Append("@title,@Sort,@guoclassid,@pic)");
		OleDbParameter[] parameters = new OleDbParameter[4]
		{
			new OleDbParameter("@title", OleDbType.VarChar, 100),
			new OleDbParameter("@Sort", OleDbType.Integer, 4),
			new OleDbParameter("@guoclassid", OleDbType.Integer, 4),
			new OleDbParameter("@pic", OleDbType.VarChar, 100)
		};
		parameters[0].Value = model.title;
		parameters[1].Value = model.Sort;
		parameters[2].Value = model.guoclassid;
		parameters[3].Value = model.pic;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Update(Model.guopic model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update guopic Set ");
		sql.Append("title='" + model.title + "',");
		sql.Append("Sort=" + model.Sort + ",");
		sql.Append("guoclassid=" + model.guoclassid + ", ");
		sql.Append("pic='" + model.pic + "'");
		sql.Append((" where id=" + model.id) ?? "");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select id,title,Sort,guoclassid,pic ");
		strSql.Append(" from guopic ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by sort");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public Model.guopic GetModel(int nc_Id)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select id,title,Sort,guoclassid,pic from guopic ");
		strSql.Append(" where id=@nc_Id ");
		OleDbParameter[] parameters = new OleDbParameter[1]
		{
			new OleDbParameter("@nc_Id", OleDbType.Integer, 4)
		};
		parameters[0].Value = nc_Id;
		Model.guopic model = new Model.guopic();
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
			if (ds.Tables[0].Rows[0]["guoclassid"].ToString() != "")
			{
				model.guoclassid = int.Parse(ds.Tables[0].Rows[0]["guoclassid"].ToString());
			}
			model.pic = ds.Tables[0].Rows[0]["pic"].ToString();
			return model;
		}
		return null;
	}

	public bool Delete(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from guopic ");
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
