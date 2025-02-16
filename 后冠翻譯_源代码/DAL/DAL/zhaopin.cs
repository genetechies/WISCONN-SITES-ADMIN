using System;
using System.Data;
using System.Data.OleDb;
using System.Text;
using DBUtility;
using Model;

namespace DAL;

public class zhaopin
{
	public bool Update(Model.zhaopin model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("Update zhaopin Set ");
		sql.Append("gangwei='" + model.gangwei + "',");
		sql.Append("xueli='" + model.xueli + "', ");
		sql.Append("renshu='" + model.renshu + "', ");
		sql.Append("didian='" + model.didian + "', ");
		sql.Append("daiyu='" + model.daiyu + "', ");
		sql.Append("qixian='" + model.qixian + "', ");
		sql.Append("yaoqiu='" + model.yaoqiu + "' ");
		sql.Append((" where id=" + model.id) ?? "");
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public bool Add(Model.zhaopin model)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("insert into zhaopin(");
		sql.Append("gangwei,xueli,renshu,didian,daiyu,qixian,yaoqiu,sort)");
		sql.Append(" values (");
		sql.Append("@gangwei,@xueli,@renshu,@didian,@daiyu,@qixian,@yaoqiu,@sort)");
		OleDbParameter[] parameters = new OleDbParameter[8]
		{
			new OleDbParameter("@gangwei", OleDbType.VarChar, 255),
			new OleDbParameter("@xueli", OleDbType.VarChar, 100),
			new OleDbParameter("@renshu", OleDbType.VarChar, 50),
			new OleDbParameter("@didian", OleDbType.VarChar, 100),
			new OleDbParameter("@daiyu", OleDbType.VarChar, 100),
			new OleDbParameter("@qixian", OleDbType.VarChar, 100),
			new OleDbParameter("@yaoqiu", OleDbType.LongVarChar),
			new OleDbParameter("@sort", OleDbType.Integer, 4)
		};
		parameters[0].Value = model.gangwei;
		parameters[1].Value = model.xueli;
		parameters[2].Value = model.renshu;
		parameters[3].Value = model.didian;
		parameters[4].Value = model.daiyu;
		parameters[5].Value = model.qixian;
		parameters[6].Value = model.yaoqiu;
		parameters[7].Value = model.sort;
		int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(), parameters));
		if (i > 0)
		{
			return true;
		}
		return false;
	}

	public int CountByClass(string where)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("select count(1) from zhaopin ");
		if (!string.IsNullOrEmpty(where))
		{
			sql.Append(" where " + where);
		}
		return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
	}

	public DataSet GetList(string strWhere)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select * ");
		strSql.Append(" FROM zhaopin ");
		if (strWhere.Trim() != "")
		{
			strSql.Append(" where " + strWhere);
		}
		strSql.Append(" order by OrderID");
		return DbHelperOledb.Query(strSql.ToString());
	}

	public DataSet GetListByClass(string strWhere, string orderby)
	{
		StringBuilder strSql = new StringBuilder();
		strSql.Append("select *  FROM zhaopin ");
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

	public bool Delete(int id)
	{
		StringBuilder sql = new StringBuilder();
		sql.Append("delete from zhaopin ");
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

	public Model.zhaopin GetModel(int P_ID)
	{
		Model.zhaopin model = null;
		using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
		{
			if (conn.State != ConnectionState.Open)
			{
				conn.Open();
			}
			string sql = "select * from zhaopin where id=@P_ID";
			OleDbCommand cmd = new OleDbCommand(sql, conn);
			cmd.Parameters.AddWithValue("@P_ID", P_ID);
			OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
			if (sdr.Read())
			{
				model = new Model.zhaopin();
				model.id = P_ID;
				model.gangwei = ((sdr["gangwei"] == DBNull.Value) ? "" : ((string)sdr["gangwei"]));
				model.xueli = ((sdr["xueli"] == DBNull.Value) ? "" : ((string)sdr["xueli"]));
				model.renshu = ((sdr["renshu"] == DBNull.Value) ? "" : ((string)sdr["renshu"]));
				model.didian = ((sdr["didian"] == DBNull.Value) ? "" : ((string)sdr["didian"]));
				model.daiyu = ((sdr["daiyu"] == DBNull.Value) ? "" : ((string)sdr["daiyu"]));
				model.qixian = ((sdr["qixian"] == DBNull.Value) ? "" : ((string)sdr["qixian"]));
				model.yaoqiu = ((sdr["yaoqiu"] == DBNull.Value) ? "" : ((string)sdr["yaoqiu"]));
				if (sdr["time"].ToString().Trim() != "")
				{
					model.time = Convert.ToDateTime(sdr["time"].ToString());
				}
				if (sdr["sort"].ToString().Trim() != "")
				{
					model.sort = Convert.ToInt32(sdr["sort"].ToString());
				}
			}
			sdr.Close();
		}
		return model;
	}

	public void UpdaetSortKey(int P_Id, int sortkey)
	{
		string sql = "update zhaopin set sort=" + sortkey + " where id=" + P_Id;
		DbHelperOledb.ExecuteSql(sql);
	}
}
