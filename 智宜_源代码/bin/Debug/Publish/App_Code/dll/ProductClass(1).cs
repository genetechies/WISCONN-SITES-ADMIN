using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ZeroStudio.DBUtility;
using System.Data.OleDb;

namespace ZeroStudio.DAL
{
    public class ProductClass
    {
        protected  string zh = "";
        public ProductClass()
        { }
        public ProductClass(bool isZh)
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
        public bool Exists(int PC_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from ProductClass");
            strSql.Append(" where PC_Id"+zh+"=" + PC_Id + " ");
            return DbHelperOledb.Exists(strSql.ToString());
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.ProductClass model) {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "insert into ProductClass(PC_ClassName,PC_ClassName_En,PC_ImageUrl,PC_ParentID,PC_ParentID_Zh,PC_SortKey,description,keywords) values(@PC_ClassName,@PC_ClassName_En,@PC_ImageUrl,@PC_ParentID,@PC_ParentID_Zh,@PC_SortKey,@description,@keywords)";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PC_ClassName", model.PC_ClassName);
                cmd.Parameters.AddWithValue("@PC_ClassName_En", model.PC_ClassNameEn);
                cmd.Parameters.AddWithValue("@PC_ImageUrl", model.PC_ImageUrl);
                cmd.Parameters.AddWithValue("@PC_ParentID", model.PC_ParentID);
                cmd.Parameters.AddWithValue("@PC_ParentID_Zh", model.PC_ParentID_Zh);
                cmd.Parameters.AddWithValue("@PC_SortKey", model.PC_SortKey);
                cmd.Parameters.AddWithValue("@description", model.Description);
                cmd.Parameters.AddWithValue("@keywords", model.Keywords);
                cmd.ExecuteNonQuery();

            }
            DbHelperOledb.ExecuteSql("update ProductClass set pc_id_zh=pc_id where  (Pc_ID_Zh = 0) OR (Pc_ID_Zh IS NULL)");
            DbHelperOledb.ExecuteSql(@"update  ProductClass  b 
inner join ProductClass  a on a.pc_id = b.pc_parentId
set b.PC_ParentID_Zh = a.pc_id_zh
where(b.PC_ParentID_Zh = 0) OR(b.PC_ParentID_Zh IS NULL)
");
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.ProductClass model) {
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = @"update ProductClass set PC_ClassName=@PC_ClassName,PC_ClassName_En=@PC_ClassName_En,
PC_ImageUrl=@PC_ImageUrl,PC_ParentID=@PC_ParentID,PC_SortKey=@PC_SortKey,keywords=@keywords,description=@description,
PC_ParentID_Zh=@PC_ParentID_Zh,
PC_Id_Zh=@PC_Id_Zh
where PC_Id=@PC_Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PC_ClassName", model.PC_ClassName);
                cmd.Parameters.AddWithValue("@PC_ClassName_En", model.PC_ClassNameEn);
                cmd.Parameters.AddWithValue("@PC_ImageUrl", model.PC_ImageUrl);
                cmd.Parameters.AddWithValue("@PC_ParentID", model.PC_ParentID);
                cmd.Parameters.AddWithValue("@PC_SortKey", model.PC_SortKey);
                cmd.Parameters.AddWithValue("@keywords", model.Keywords);
                cmd.Parameters.AddWithValue("@description", model.Description);
                cmd.Parameters.AddWithValue("@PC_ParentID_Zh", model.PC_ParentID_Zh);
                cmd.Parameters.AddWithValue("@PC_Id_Zh", model.PC_Id_Zh);
                cmd.Parameters.AddWithValue("@PC_Id", model.PC_Id);
                cmd.ExecuteNonQuery();
            }
            DbHelperOledb.ExecuteSql(@"update  ProductClass  b 
inner join ProductClass  a on a.pc_id = b.pc_parentId
set b.PC_ParentID_Zh = a.pc_id_zh
where b.pc_id=" + model.PC_Id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int PC_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from ProductClass ");
            strSql.Append(" where PC_Id=" + PC_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }

        public int GetMaxSortKey(string strWhere) {
            string sql = "select max(PC_SortKey) as MaxKey  from ProductClass";
            if (!string.IsNullOrEmpty(strWhere)) {
                sql = sql + " where " + strWhere;
            }
            int maxkey = 0;
            int.TryParse(DbHelperOledb.ExecuteScalar(sql.ToString()), out maxkey);
            return maxkey;
        }

        public void ExcuteSql(string sql) {
            DbHelperOledb.ExecuteSql(sql);
        }
        /// <summary>
        /// 得到一?对象实体
        /// </summary>
        public ZeroStudio.Model.ProductClass GetModel(int PC_Id)
        {
            Model.ProductClass model = null;
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from ProductClass where PC_Id" + zh + "=@PC_Id";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PC_Id", PC_Id);
                OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read()) {
                    model = new ZeroStudio.Model.ProductClass();
                    model.PC_Id = PC_Id;
                    model.PC_ClassName = sdr["PC_ClassName"] == System.DBNull.Value ? "" : (string)sdr["PC_ClassName"];
                    model.PC_ClassNameEn = sdr["PC_ClassName_En"] == System.DBNull.Value ? "" : (string)sdr["PC_ClassName_En"];
                    model.PC_ImageUrl = sdr["PC_ImageUrl"] == System.DBNull.Value ? "" : (string)sdr["PC_ImageUrl"];
                    model.PC_ParentID = (int)sdr["PC_ParentID"+ zh];
                    model.PC_ParentID_Zh = (int)sdr["PC_ParentID_Zh"];
                    model.PC_Id_Zh = (int)sdr["PC_Id_Zh"];
                    model.PC_SortKey = (int)sdr["PC_SortKey"];
                    model.Description = sdr["Description"] == System.DBNull.Value ? "" : (string)sdr["Description"];
                    model.Keywords = sdr["Keywords"] == System.DBNull.Value ? "" : (string)sdr["Keywords"];
                }
                sdr.Close();
            }
            return model;
        }
        public ZeroStudio.Model.ProductClass GetModel(string className) {
            Model.ProductClass model = null;
            using (OleDbConnection conn = new OleDbConnection(PubConstant.ConnectionString)) {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from ProductClass where PC_ClassName=@PC_ClassName";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                cmd.Parameters.AddWithValue("@PC_ClassName", className);
                OleDbDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read()) {
                    model = new ZeroStudio.Model.ProductClass();
                    model.PC_Id = (int)sdr["PC_Id" + zh];
                    model.PC_ParentID_Zh = (int)sdr["PC_ParentID_Zh"];
                    model.PC_Id_Zh = (int)sdr["PC_Id_Zh"];
                    model.PC_ClassName = className;
                    model.PC_ClassNameEn = sdr["PC_ClassName_En"] == System.DBNull.Value ? "" : (string)sdr["PC_ClassName_En"];
                    model.PC_ImageUrl = sdr["PC_ImageUrl"] == System.DBNull.Value ? "" : (string)sdr["PC_ImageUrl"];
                    model.PC_ParentID = (int)sdr["PC_ParentID" + zh];
                    model.PC_SortKey = (int)sdr["PC_SortKey"];
                    model.Description = sdr["Description"] == System.DBNull.Value ? "" : (string)sdr["Description"];
                    model.Keywords = sdr["Keywords"] == System.DBNull.Value ? "" : (string)sdr["Keywords"];
                }
                sdr.Close();
            }
            return model;
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PC_Id"+ zh + " as PC_Id,PC_Id_Zh ,PC_ClassName,PC_ClassName_En,PC_ImageUrl,PC_ParentID_Zh,PC_ParentID"+ zh + " as  PC_ParentID,PC_SortKey ");
            //strSql.Append("select PC_Id"+ zh + " as PC_Id,PC_ClassName,PC_ClassName_En,PC_ImageUrl,PC_ParentID"+ zh + " as PC_ParentID,PC_SortKey ");
            strSql.Append(" FROM ProductClass ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by PC_SortKey");
//throw new Exception(strSql.ToString());
            return DbHelperOledb.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法
    }
}
