using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using ZeroStudio.DBUtility;

namespace ZeroStudio.DAL
{
    public class NewsClass
    {
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="Classname"></param>
        /// <returns></returns>
        public bool Exists(Model.NewsClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("select count(*) from NewsClass");
            sql.Append(" where NC_ClassName='" + model.ClassName + "'");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.NewsClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into NewsClass(");
            sql.Append("NC_ClassName,NC_Sort,description,keywords,NC_ArtList_Title,NC_ArtList_Description)");
            sql.Append(" values (");
            sql.Append("@NC_ClassName,@NC_Sort,@description,@keywords,@NC_ArtList_Title,@NC_ArtList_Description)");
            OleDbParameter[] parameters = {
                new OleDbParameter("@NC_ClassName",OleDbType.VarChar,50),
                new OleDbParameter("@NC_Sort",OleDbType.Integer,4),
                new OleDbParameter("@description",OleDbType.VarChar),
                new OleDbParameter("@keywords",OleDbType.VarChar),
                new OleDbParameter("@NC_ArtList_Title",OleDbType.VarChar),
                new OleDbParameter("@NC_ArtList_Description",OleDbType.VarChar),
                                          };
            parameters[0].Value = model.ClassName;
            parameters[1].Value = model.Sort;
            parameters[2].Value = model.Description;
            parameters[3].Value = model.Keywords;
            parameters[4].Value = model.ArtListTitle;
            parameters[5].Value = model.ArtListDescription;


            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(),parameters));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.NewsClass model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update NewsClass Set ");
            sql.Append("NC_ClassName='" + model.ClassName + "',");
            sql.Append("NC_Sort=" + model.Sort + " ,");
            sql.Append("description='" + model.Description + "', ");
            sql.Append("keywords='" + model.Keywords + "', ");
            sql.Append("NC_ArtList_Title='" + model.ArtListTitle + "', ");
            sql.Append("NC_ArtList_Description='" + model.ArtListDescription + "' ");
            sql.Append(" where NC_Id="+ model.Id +"");

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from NewsClass ");
            sql.Append(" where NC_Id=@NC_Id");
            OleDbParameter[] parameters ={
                new OleDbParameter("@NC_Id",OleDbType.Integer,4)};
            parameters[0].Value = id;

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString(),parameters));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select * from NewsClass order by NC_Sort");
            return DbHelperOledb.Query(sql.ToString());
        }

        /// <summary>
        /// 得到一個对象实体
        /// </summary>
        public Model.NewsClass GetModel(int nc_Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select nc_Id,nc_ClassName,nc_Sort,keywords,description,NC_ArtList_Title,NC_ArtList_Description from NewsClass ");
            strSql.Append(" where nc_Id=@nc_Id ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@nc_Id", OleDbType.Integer,4)};
            parameters[0].Value = nc_Id;

            Model.NewsClass model = new Model.NewsClass();
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
                model.Keywords = ds.Tables[0].Rows[0]["Keywords"].ToString();

                model.Description = ds.Tables[0].Rows[0]["Description"].ToString();

                model.ArtListTitle = ds.Tables[0].Rows[0]["NC_ArtList_Title"].ToString();

                model.ArtListDescription = ds.Tables[0].Rows[0]["NC_ArtList_Description"].ToString();

                return model;
            }
            else
            {
                return null;
            }
        }
    }
}
