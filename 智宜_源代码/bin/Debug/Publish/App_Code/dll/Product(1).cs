using System;
using System.Collections.Generic;
using System.Text;
using ZeroStudio.DBUtility;
using System.Data;
using System.Data.OleDb;

namespace ZeroStudio.DAL
{
    public class Product
    {
        protected string zh = "";

        public Product() { }

        public Product(bool isZh)
        {
            if (isZh)
            {
                zh = "_Zh";
            }
        }
        #region  成员方法


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int P_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from Product");
            strSql.Append(" where P_ID" + zh + "=" + P_ID + " ");
            return DbHelperOledb.Exists(strSql.ToString());
        }

        /// <summary>
        /// 返回记录条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from product");
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        /// <summary>
        /// 返回记录条数
        /// </summary>
        /// <returns></returns>
        public int Count(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from product");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        public int CountByClass(string where)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(1) from product inner join ProductClass on product.P_ClassID" + zh + "=ProductClass.PC_Id" + zh + "");
            if (!string.IsNullOrEmpty(where))
            {
                sql.Append(" where " + where);
            }
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.Product model)
        {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into Product(P_Name,P_Name_En,P_Code,P_Model,P_Spec,P_Stock,P_Identity,P_Evinr,P_ClassID,P_ClassID_Zh,P_ParentID,P_PhotoUrl,P_Doc,P_Uptime,P_State,Description,Keywords) " +
                    "values(@P_Name,@P_Name_En,@P_Code,@P_Model,@P_Spec,@P_Stock,@P_Identity,@P_Evinr,@P_ClassID,@P_ClassID_Zh,@P_ParentID,@P_PhotoUrl,@P_Doc,@P_Uptime,@P_State,@description,@keywords,@UpKey,@DownKey)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_Name", model.P_Name);
                cmd.Parameters.AddWithValue("@P_Name_En", model.P_Name_En);
                cmd.Parameters.AddWithValue("@P_Code", model.P_Code);
                cmd.Parameters.AddWithValue("@P_Model", model.P_Model);
                cmd.Parameters.AddWithValue("@P_Spec", model.P_Spec);
                cmd.Parameters.AddWithValue("@P_Stock", model.P_Stock);
                cmd.Parameters.AddWithValue("@P_Identity", model.P_Identity);
                cmd.Parameters.AddWithValue("@P_Evinr", model.P_Evinr);
                cmd.Parameters.AddWithValue("@P_ClassID", model.P_ClassID);
                cmd.Parameters.AddWithValue("@P_ClassID_Zh", model.P_ClassID_Zh);
                cmd.Parameters.AddWithValue("@P_ParentID", model.P_ParentID);
                cmd.Parameters.AddWithValue("@P_PhotoUrl", model.P_PhotoUrl);
                cmd.Parameters.AddWithValue("@P_Doc", model.P_Doc);
                cmd.Parameters.AddWithValue("@P_Uptime", model.P_Uptime);
                cmd.Parameters.AddWithValue("@P_State", model.P_State);
                cmd.Parameters.AddWithValue("@description", model.Description);
                cmd.Parameters.AddWithValue("@keywords", model.Keywords);
                cmd.Parameters.AddWithValue("@UpKey", model.UpKey);
                cmd.Parameters.AddWithValue("@DownKey", model.DownKey);
                cmd.ExecuteNonQuery();
            }
            DbHelperOledb.ExecuteSql("update product set p_id_zh=p_id where  (P_ID_Zh = 0) OR (P_ID_Zh IS NULL)");
            DbHelperOledb.ExecuteSql(@"update  product  b 
inner join ProductClass  a on a.pc_id = b.P_ClassID
set b.P_ClassID_Zh = a.pc_id_zh
where(b.P_ClassID_Zh = 0) OR (b.P_ClassID_Zh IS NULL)
");
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.Product model)
        {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update Product set P_Name=@P_Name,P_Name_En=@P_Name_En,P_Code=@P_Code,P_Model=@P_Model,P_Spec=@P_Spec,P_Stock=@P_Stock,P_Identity=@P_Identity,P_Evinr=@P_Evinr,P_ClassID=@P_ClassID,P_ClassID_Zh=@P_ClassID_Zh,P_ParentID=@P_ParentID,P_PhotoUrl=@P_PhotoUrl,P_Doc=@P_Doc,P_State=@P_State,Keywords=@keywords,Description=@description,UpKey=@UpKey,DownKey=@DownKey where P_ID" + zh + "=@P_ID";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_Name", model.P_Name);
                cmd.Parameters.AddWithValue("@P_Name_En", model.P_Name_En);
                cmd.Parameters.AddWithValue("@P_Code", model.P_Code);
                cmd.Parameters.AddWithValue("@P_Model", model.P_Model);
                cmd.Parameters.AddWithValue("@P_Spec", model.P_Spec);
                cmd.Parameters.AddWithValue("@P_Stock", model.P_Stock);
                cmd.Parameters.AddWithValue("@P_Identity", model.P_Identity);
                cmd.Parameters.AddWithValue("@P_Evinr", model.P_Evinr);
                cmd.Parameters.AddWithValue("@P_ClassID", model.P_ClassID);
                cmd.Parameters.AddWithValue("@P_ClassID_Zh", model.P_ClassID_Zh);
                cmd.Parameters.AddWithValue("@P_ParentID", model.P_ParentID);
                cmd.Parameters.AddWithValue("@P_PhotoUrl", model.P_PhotoUrl);
                cmd.Parameters.AddWithValue("@P_Doc", model.P_Doc);
                cmd.Parameters.AddWithValue("@P_State", model.P_State);
                cmd.Parameters.AddWithValue("@keywords", model.Keywords);
                cmd.Parameters.AddWithValue("@description", model.Description);
                cmd.Parameters.AddWithValue("@UpKey", model.UpKey);
                cmd.Parameters.AddWithValue("@DownKey", model.DownKey);
                cmd.Parameters.AddWithValue("@P_ID", model.P_ID);
                cmd.ExecuteNonQuery();
            }
            DbHelperOledb.ExecuteSql(@"update  product  b 
inner join ProductClass  a on a.pc_id = b.P_ClassID
set b.P_ClassID_Zh = a.pc_id_zh
where  b.P_ID" + zh + "=" + model.P_ID);
        }

        public void UpdaetSortKey(int P_Id, int sortkey)
        {
            List<string> sql = new List<string>();
            ZeroStudio.Model.Product model = GetModel(P_Id);
            if (sortkey < model.P_ParentID) //数值减少
            {
                DbHelperOledb.ExecuteSql("update Product set P_ParentID=P_ParentID+1 where  P_ParentID >=" + sortkey + " and P_ParentID<=" + model.P_ParentID + " and P_ClassId=" + model.P_ClassID + " and P_ParentID<P_ParentID+1");
            }
            else //输值增大
            {
                DbHelperOledb.ExecuteSql("update Product set P_ParentID=P_ParentID-1 where  P_ParentID <=" + sortkey + " and P_ParentID>=" + model.P_ParentID + " and P_ClassId=" + model.P_ClassID + " and P_ParentID>P_ParentID-1");
            }

            DbHelperOledb.ExecuteSql("update Product set P_ParentID=" + sortkey + " where P_Id=" + P_Id);

        }
        public void UpdateState(int P_Id, int state)
        {
            string sql = "update Product set P_State=" + state + " where P_Id=" + P_Id;
            DbHelperOledb.ExecuteSql(sql);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int P_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from Product ");
            strSql.Append(" where P_ID=" + P_ID + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一?对象实体
        /// </summary>
        public ZeroStudio.Model.Product GetModel(int P_ID)
        {
            Model.Product model = null;
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from Product where P_ID" + zh + "=@P_ID";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_ID", P_ID);
                OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new ZeroStudio.Model.Product();
                    model.P_ID = P_ID;
                    model.P_Name = sdr["P_Name"] == System.DBNull.Value ? "" : (string)sdr["P_Name"];
                    model.P_Name_En = sdr["P_Name_En"] == System.DBNull.Value ? "" : (string)sdr["P_Name_En"];
                    model.P_Code = sdr["P_Code"] == System.DBNull.Value ? "" : (string)sdr["P_Code"];
                    model.P_Model = sdr["P_Model"] == System.DBNull.Value ? "" : (string)sdr["P_Model"];
                    model.P_Spec = sdr["P_Spec"] == System.DBNull.Value ? "" : (string)sdr["P_Spec"];
                    model.P_Stock = sdr["P_Stock"] == System.DBNull.Value ? "" : (string)sdr["P_Stock"];
                    model.P_Identity = sdr["P_Identity"] == System.DBNull.Value ? "" : (string)sdr["P_Identity"];
                    model.P_Evinr = sdr["P_Evinr"] == System.DBNull.Value ? "" : (string)sdr["P_Evinr"];
                    model.P_ClassID = (int)sdr["P_ClassID" + zh + ""];
                    model.P_ClassID_Zh = (int)sdr["P_ClassID_Zh"];
                    model.P_ParentID = (int)sdr["P_ParentID"];
                    model.P_PhotoUrl = sdr["P_PhotoUrl"] == System.DBNull.Value ? "" : (string)sdr["P_PhotoUrl"];
                    model.P_Doc = sdr["P_Doc"] == System.DBNull.Value ? "" : (string)sdr["P_Doc"];
                    model.P_Uptime = (DateTime)sdr["P_Uptime"];
                    model.P_State = sdr["P_State"] == System.DBNull.Value ? 0 : (int)sdr["P_State"];
                    model.Description = sdr["Description"] == System.DBNull.Value ? "" : (string)sdr["Description"];
                    model.Keywords = sdr["Keywords"] == System.DBNull.Value ? "" : (string)sdr["Keywords"];
                    try
                    {
                        model.UpKey = sdr["UpKey"] == System.DBNull.Value ? "" : (string)sdr["UpKey"];
                        model.DownKey = sdr["DownKey"] == System.DBNull.Value ? "" : (string)sdr["DownKey"];
                    }
                    catch { }
                }
                sdr.Close();
            }
            return model;

        }

        public ZeroStudio.Model.Product GetModel(string code)
        {
            Model.Product model = null;
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from Product where P_Code=@P_Code";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@P_Code", code);
                OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new ZeroStudio.Model.Product();
                    model.P_ID = (int)sdr["P_Id" + zh];
                    model.P_Name = sdr["P_Name"] == System.DBNull.Value ? "" : (string)sdr["P_Name"];
                    model.P_Name_En = sdr["P_Name_En"] == System.DBNull.Value ? "" : (string)sdr["P_Name_En"];
                    model.P_Code = code;
                    model.P_Model = sdr["P_Model"] == System.DBNull.Value ? "" : (string)sdr["P_Model"];
                    model.P_Spec = sdr["P_Spec"] == System.DBNull.Value ? "" : (string)sdr["P_Spec"];
                    model.P_Stock = sdr["P_Stock"] == System.DBNull.Value ? "" : (string)sdr["P_Stock"];
                    model.P_Identity = sdr["P_Identity"] == System.DBNull.Value ? "" : (string)sdr["P_Identity"];
                    model.P_Evinr = sdr["P_Evinr"] == System.DBNull.Value ? "" : (string)sdr["P_Evinr"];
                    model.P_ClassID = (int)sdr["P_ClassID" + zh + ""];
                    model.P_ClassID_Zh = (int)sdr["P_ClassID_Zh"];
                    model.P_ParentID = (int)sdr["P_ParentID"];
                    model.P_PhotoUrl = sdr["P_PhotoUrl"] == System.DBNull.Value ? "" : (string)sdr["P_PhotoUrl"];
                    model.P_Doc = sdr["P_Doc"] == System.DBNull.Value ? "" : (string)sdr["P_Doc"];
                    model.P_Uptime = (DateTime)sdr["P_Uptime"];
                    model.P_State = sdr["P_State"] == System.DBNull.Value ? 0 : (int)sdr["P_State"];
                    model.Keywords = sdr["Keywords"] == System.DBNull.Value ? "" : (string)sdr["Keywords"];
                    model.Description = sdr["Description"] == System.DBNull.Value ? "" : (string)sdr["Description"];
                    try
                    {
                        model.UpKey = sdr["UpKey"] == System.DBNull.Value ? "" : (string)sdr["UpKey"];
                        model.DownKey = sdr["DownKey"] == System.DBNull.Value ? "" : (string)sdr["DownKey"];
                    }
                    catch { }

                }
                sdr.Close();
            }
            return model;

        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Product].*,[ProductClass].PC_ClassName,[ProductClass].PC_ClassName_En ");
            strSql.Append(" FROM [Product] inner join [ProductClass] ");
            strSql.Append(" on [Product].P_ClassID" + zh + "=[ProductClass].PC_ID" + zh + "");
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
                strSql.Append(" order by P_ParentID,PC_Id");
            }

            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得符合查询条件的前Num记录
        /// </summary>
        /// <param name="num">要查询的条数</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public DataSet GetList(int num, string strWhere, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top " + num + " [Product].*,[ProductClass].PC_ClassName ");
            strSql.Append(" FROM [Product] inner join [ProductClass] ");
            strSql.Append(" on [Product].P_ClassID" + zh + "=[ProductClass].PC_ID" + zh + "");
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
                strSql.Append(" order by P_ParentID,PC_Id");
            }
            return DbHelperOledb.Query(strSql.ToString());
        }
        /*
        */
        public DataSet GetListByClass(string strWhere, string orderby)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [Product].*,[ProductClass].PC_ClassName ");
            strSql.Append(" FROM [Product] inner join [ProductClass] ");
            strSql.Append(" on [Product].P_ClassID" + zh + "=[ProductClass].PC_ID" + zh + "");
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
                strSql.Append(" order by P_ClassID" + zh + ", P_ParentID desc,PC_Id");
            }
            return DbHelperOledb.Query(strSql.ToString());
        }
        public int GetMaxSortKey(string strWhere)
        {
            string sql = "select max(P_ParentID) as MaxKey  from Product";
            if (!string.IsNullOrEmpty(strWhere))
            {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }

        #endregion  成员方法
    }
}