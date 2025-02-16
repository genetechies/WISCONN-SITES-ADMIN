using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.OleDb;
using DBUtility;
using System.Text;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Friendly_dal
/// </summary>
public class Friendly_dal
{
    public Friendly_dal()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public void Add(Friendly_model model,Model.SubWeb sw)
    {
        using (SqlConnection conn = new SqlConnection(new PubConstant().GetString(sw)))
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = "insert into Friendly(F_Name,F_Url,F_Location,F_Author,F_OptionTime,F_SortKey) values(@F_Name,@F_Url,@F_Location,@F_Author,@F_OptionTime,@F_SortKey)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@F_Name", model.F_Name);
            cmd.Parameters.AddWithValue("@F_Url", model.F_Url);
            cmd.Parameters.AddWithValue("@F_Location", model.F_Location);
            cmd.Parameters.AddWithValue("@F_Author", model.F_Author);
            cmd.Parameters.AddWithValue("@F_OptionTime", model.F_Option);
            if (model.F_SortKey == 0)
            {
                cmd.Parameters.AddWithValue("@F_SortKey", MaxSort() + 1);
            }
            else
            {
                cmd.Parameters.AddWithValue("@F_SortKey", model.F_SortKey);
            }
            cmd.ExecuteNonQuery();
        }
    }



    /// <summary>
    /// 返回留言条数
    /// </summary>
    /// <returns></returns>
    public int Count()
    {
        StringBuilder sql = new StringBuilder();
        sql.Append("select count(1) from Friendly");
        return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public int MaxSort()
    {
        StringBuilder sql = new StringBuilder();
        sql.Append("select max(F_SortKey) from Friendly");
        return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()) == "" ? "0" : DbHelperOledb.ExecuteScalar(sql.ToString()));
    }

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList(string strWhere,Model.SubWeb sw)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("select * ");
        strSql.Append(" FROM Friendly ");
        if (strWhere.Trim() != "")
        {
            strSql.Append(" where " + strWhere);
        }
        strSql.Append(" order by F_Id DESC,F_SortKey asc");
        return new DbHelperOledbP(sw).Query(strSql.ToString());
    }

    /// <summary>
    /// 刪除一条数据
    /// </summary>
    /// <param name="strWhere"></param>
    /// <returns></returns>
    public void Delete(string strWhere,Model.SubWeb sw)
    {
        StringBuilder strSql = new StringBuilder();
        strSql.Append("delete From Friendly ");
        strSql.Append(" where F_Id = " + strWhere);
        new DbHelperOledbP(sw).ExecuteSql(strSql.ToString());
    }

    /// <summary>
    /// 更新一条数据
    /// </summary>
    public void Update(Friendly_model model,Model.SubWeb sw)
    {
        using (SqlConnection conn = new SqlConnection(new PubConstant().GetString(sw)))
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = "update Friendly set F_Name=@F_Name,F_Url=@F_Url,F_Location=@F_Location,F_Author=@F_Author,F_OptionTime=@F_OptionTime where F_Id=@F_Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@F_Name", model.F_Name);
            cmd.Parameters.AddWithValue("@F_Url", model.F_Url);
            cmd.Parameters.AddWithValue("@F_Location", model.F_Location);
            cmd.Parameters.AddWithValue("@F_Author", model.F_Author);
            cmd.Parameters.AddWithValue("@F_OptionTime", model.F_Option);
            cmd.Parameters.AddWithValue("@F_Id", model.F_Id);

            cmd.ExecuteNonQuery();
        }
    }

    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public Friendly_model GetModel(int F_Id,Model.SubWeb sw)
    {
        Friendly_model model = null;
        using (SqlConnection conn = new SqlConnection(new PubConstant().GetString(sw)))
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = "select * from Friendly where F_Id=@F_Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@F_Id", F_Id);
            SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
            if (sdr.Read())
            {
                model = new Friendly_model();
                model.F_Id = F_Id;
                model.F_Name = sdr["F_Name"] == System.DBNull.Value ? "" : (string)sdr["F_Name"];
                model.F_Url = sdr["F_Url"] == System.DBNull.Value ? "" : (string)sdr["F_Url"];
                model.F_Location = (int)sdr["F_Location"];
                model.F_Author = sdr["F_Author"] == System.DBNull.Value ? "" : (string)sdr["F_Author"];
                model.F_Option = (DateTime)sdr["F_OptionTime"];
                model.F_SortKey = sdr["F_SortKey"] == System.DBNull.Value ? 0 : (int)sdr["F_SortKey"];
            }
            sdr.Close();
        }
        return model;
    }

    /// <summary>
    /// 更新排序號
    /// </summary>
    /// <param name="F_Id"></param>
    /// <param name="sort"></param>
    public void UpdateSortKey(int F_Id, int sort)
    {
        using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            string sql = "update Friendly set F_SortKey=@F_SortKey where F_Id=@F_Id";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@F_SortKey", sort);
            cmd.Parameters.AddWithValue("@F_Id", F_Id);

            cmd.ExecuteNonQuery();
        }
    }
}
