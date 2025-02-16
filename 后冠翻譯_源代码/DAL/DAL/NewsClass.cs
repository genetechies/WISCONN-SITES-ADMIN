using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class NewsClass
{
	public bool Exists(Model.NewsClass model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(*) from NewsClass");
		sql.Append(" where ClassName='" + model.ClassName + "'");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public int GetMaxSortKey(string strWhere)
	{
		string sql = "select count(classid) as MaxKey  from NewsClass";
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
		strSql.Append("select classid,ClassName,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname, NC_ArtList_Title, NC_ArtList_Description FROM NewsClass t1 ");
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
		strSql.Append("select top " + num + " classid,ClassName,OrderID,(select ClassName from NewsClass t2 where t2.classid=t1.ParentID) as parentclassname, NC_ArtList_Title, NC_ArtList_Description FROM NewsClass t1  ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by OrderID asc");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public Model.NewsClass GetModel(int P_ID)
	{
		Model.NewsClass model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from NewsClass where classid=@P_ID";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@P_ID", P_ID);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.NewsClass();
				model.classid = P_ID;
				model.ClassName = ((sdr["ClassName"] == DBNull.Value) ? "" : ((string)sdr["ClassName"]));
				model.OrderID = (int)sdr["OrderID"];
				model.Keyword = ((sdr["D_Keyword"] == DBNull.Value) ? "" : ((string)sdr["D_Keyword"]));
				model.Desciption = ((sdr["D_Description"] == DBNull.Value) ? "" : ((string)sdr["D_Description"]));
                model.ArtListTitle = ((sdr["NC_ArtList_Title"] == DBNull.Value) ? "" : ((string)sdr["NC_ArtList_Title"]));
                model.ArtListDescription = ((sdr["NC_ArtList_Description"] == DBNull.Value) ? "" : ((string)sdr["NC_ArtList_Description"]));
            }
			sdr.Close();
		}
		return model;
	}

	public bool AddSmall(Model.NewsClass model)
    {
        StringBuilder sql = new StringBuilder();
		sql.Append("insert into NewsClass(");
		sql.Append("ClassName,OrderID,ParentID,D_Keyword,D_Description,NC_ArtList_Title,NC_ArtList_Description)");
		sql.Append(" values (");
		sql.Append("@ClassName,@OrderID,@ParentID,@Keyword,@Description,@NC_ArtList_Title,@NC_ArtList_Description)");
		OleDbParameter[] parameters = new OleDbParameter[7]
		{
			new OleDbParameter("@ClassName", OleDbType.VarChar, 50),
			new OleDbParameter("@OrderID", OleDbType.Integer, 4),
			new OleDbParameter("@ParentID", OleDbType.Integer, 4),
			new OleDbParameter("@Keyword", OleDbType.VarChar, 500),
			new OleDbParameter("@Description", OleDbType.VarChar, 500),
            new OleDbParameter("@NC_ArtList_Title", OleDbType.VarChar, 500),
            new OleDbParameter("@NC_ArtList_Description", OleDbType.VarChar, 500)
        };
		parameters[0].Value = model.ClassName;
		parameters[1].Value = model.OrderID;
		parameters[2].Value = model.ParentID;
		parameters[3].Value = model.Keyword;
		parameters[4].Value = model.Desciption;
        parameters[5].Value = model.ArtListTitle;
        parameters[6].Value = model.ArtListDescription;
        int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool UpdateSmall(Model.NewsClass model)
    {
        StringBuilder sql = new StringBuilder();
		sql.Append("Update NewsClass Set ");
		sql.Append("ClassName='" + model.ClassName + "',");
		sql.Append("OrderID=" + model.OrderID + ", ");
		sql.Append("D_Keyword='" + model.Keyword + "',");
		sql.Append("D_Description='" + model.Desciption + "',");
        sql.Append("NC_ArtList_Title='" + model.ArtListTitle + "', ");
        sql.Append("NC_ArtList_Description='" + model.ArtListDescription + "' ");
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
		sql.Append("delete from NewsClass ");
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
