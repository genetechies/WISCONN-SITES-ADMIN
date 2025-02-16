using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DBUtility;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class TranslatorList
    {

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TranslatorList model)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                //string sql = "insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,Language,MasterLanguage,Experience,Seniority,TranslationAmount,Mark,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,Creator,CreateDate,state) " +
                //    "values(@UserName,@Age,@Sex,@Country,@WorkType,@TopGraduation,@IsLearning,@Language,@MasterLanguage,@Experience,@Seniority,@TranslationAmount,@Mark,@TransLationSkill,@SoftwareSkill,@TEL,@Email,@QQ,@MSN,@Creator,@CreateDate,@state)";

                //string sql = "insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,Language) " +
                //    "values(@UserName,@Age,@Sex,@Country,@WorkType,@TopGraduation,@IsLearning,@Language)";


                //string sql1 = "insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,Language,MasterLanguage,Experience,Seniority,TranslationAmount,Mark,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,Creator,CreateDate,state) " +
                //    "values('" + model.UserName + "','" + model.Age + "','" + model.Sex + "','" + model.Country + "','" + model.WorkType + "','" + model.TopGraduation + "','" + model.IsLearning + "','" + model.Language + "','" + model.MasterLanguage + "','" + model.Experience + "','" + model.Seniority + "','" + model.TranslationAmount + "','" + model.Mark + "','" + model.TransLationSkill + "','" + model.SoftwareSkill + "','" + model.TEL + "','" + model.Email + "','" + model.QQ + "','" + model.MSN + "','" + model.Creator + "','" + model.CreateDate + "'," + model.state + ")";


                //OleDbCommand cmd = new OleDbCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@UserName", model.UserName);
                //cmd.Parameters.AddWithValue("@Age", model.Age);
                //cmd.Parameters.AddWithValue("@Sex", model.Sex);
                //cmd.Parameters.AddWithValue("@Country", model.Country);
                //cmd.Parameters.AddWithValue("@WorkType", model.WorkType);
                //cmd.Parameters.AddWithValue("@TopGraduation", model.TopGraduation);
                //cmd.Parameters.AddWithValue("@IsLearning", model.IsLearning);
                //cmd.Parameters.AddWithValue("@Language", model.Language);
                //cmd.Parameters.AddWithValue("@MasterLanguage", model.MasterLanguage);
                //cmd.Parameters.AddWithValue("@Experience", model.Experience);
                //cmd.Parameters.AddWithValue("@Seniority", model.Seniority);
                //cmd.Parameters.AddWithValue("@TranslationAmount", model.TranslationAmount);
                //cmd.Parameters.AddWithValue("@Mark", model.Mark);
                //cmd.Parameters.AddWithValue("@TransLationSkill", model.TransLationSkill);
                //cmd.Parameters.AddWithValue("@SoftwareSkill", model.SoftwareSkill);
                //cmd.Parameters.AddWithValue("@TEL", model.TEL);
                //cmd.Parameters.AddWithValue("@Email", model.Email);
                //cmd.Parameters.AddWithValue("@QQ", model.QQ);
                //cmd.Parameters.AddWithValue("@MSN", model.MSN);
                //cmd.Parameters.AddWithValue("@Creator", model.Creator);
                //cmd.Parameters.AddWithValue("@CreateDate", model.CreateDate);
                //cmd.Parameters.AddWithValue("@state", model.state);
                //cmd.ExecuteNonQuery();

                string sql1 = "insert into TranslatorList(UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,[Language],MasterLanguage,Experience,Seniority,TranslationAmount,Mark,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,Creator,CreateDate,state) " +
                    "values('" + model.UserName + "','" + model.Age + "','" + model.Sex + "','" + model.Country + "','" + model.WorkType + "','" + model.TopGraduation + "','" + model.IsLearning + "','" + model.Language + "','" + model.MasterLanguage + "','" + model.Experience + "','" + model.Seniority + "','" + model.TranslationAmount + "','" + model.Mark + "','" + model.TransLationSkill + "','" + model.SoftwareSkill + "','" + model.TEL + "','" + model.Email + "','" + model.QQ + "','" + model.MSN + "','" + model.Creator + "','" + model.CreateDate + "'," + model.state + ")";


                DbHelperOledb.ExecuteSql(sql1.ToString());
            }


        }

        ///// <summary>
        ///// 添加一个
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public void Add(Model.TranslatorList model)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("insert into TranslatorList(");
        //    strSql.Append("UserName,Age,Sex,Country,WorkType,TopGraduation,IsLearning,Language,MasterLanguage,Experience,Seniority,TranslationAmount,TransLationSkill,SoftwareSkill,TEL,Email,QQ,MSN,CreateDate,state)");
        //    strSql.Append(" values (");
        //    strSql.Append("@UserName,@Age,@Sex,@Country,@WorkType,@TopGraduation,@IsLearning,@Language,@MasterLanguage,@Experience,@Seniority,@TranslationAmount,@TransLationSkill,@SoftwareSkill,@TEL,@Email,@QQ,@MSN,@CreateDate,@state)");
        //    OleDbParameter[] parameters = {
        //            new OleDbParameter("@UserName", OleDbType.VarChar,100),
        //            new OleDbParameter("@Age", OleDbType.VarChar,50),
        //            new OleDbParameter("@Sex", OleDbType.VarChar,50),
        //            new OleDbParameter("@Country", OleDbType.VarChar,50),
        //            new OleDbParameter("@WorkType",  OleDbType.VarChar,100),
        //            new OleDbParameter("@TopGraduation",  OleDbType.VarChar,50),
        //            new OleDbParameter("@IsLearning",  OleDbType.VarChar,50),
        //            new OleDbParameter("@Language", OleDbType.VarChar,200),
        //            new OleDbParameter("@MasterLanguage",  OleDbType.VarChar,50),
        //            new OleDbParameter("@Experience",  OleDbType.VarChar,100),
        //            new OleDbParameter("@Seniority",  OleDbType.VarChar,250),
        //            new OleDbParameter("@TranslationAmount",  OleDbType.VarChar,50),
        //            //new OleDbParameter("@Mark",  OleDbType.VarChar,200),
        //            new OleDbParameter("@TransLationSkill",  OleDbType.VarChar,255),
        //            new OleDbParameter("@SoftwareSkill",  OleDbType.VarChar,250),
        //            new OleDbParameter("@TEL",  OleDbType.VarChar,50),
        //            new OleDbParameter("@Email",  OleDbType.VarChar,50),
        //            new OleDbParameter("@QQ",  OleDbType.VarChar,50),
        //            new OleDbParameter("@MSN",  OleDbType.VarChar,50),
        //            //new OleDbParameter("@Creator",  OleDbType.VarChar,50),
        //            new OleDbParameter("@CreateDate",  OleDbType.VarChar,50),
        //            new OleDbParameter("@state",  OleDbType.Integer,4)
        //            };
        //    parameters[0].Value = model.UserName;
        //    parameters[1].Value = model.Age;
        //    parameters[2].Value = model.Sex;
        //    parameters[3].Value = model.Country;
        //    parameters[4].Value = model.WorkType;
        //    parameters[5].Value = model.TopGraduation;
        //    parameters[6].Value = model.IsLearning;
        //    parameters[7].Value = model.Language;
        //    parameters[8].Value = model.MasterLanguage;
        //    parameters[9].Value = model.Experience;
        //    parameters[10].Value = model.Seniority;
        //    parameters[11].Value = model.TranslationAmount;
        //    //parameters[12].Value = model.Mark;
        //    parameters[12].Value = model.TransLationSkill;
        //    parameters[13].Value = model.SoftwareSkill;
        //    parameters[14].Value = model.TEL;
        //    parameters[15].Value = model.Email;
        //    parameters[16].Value = model.QQ;
        //    parameters[17].Value = model.MSN;
        //    //parameters[19].Value = model.Creator;
        //    parameters[18].Value = model.CreateDate;
        //    parameters[19].Value = model.state;


        //    object obj = DbHelperOledb.GetSingle(strSql.ToString(), parameters);
        //    //if (obj == null)
        //    //{
        //    //    return 0;
        //    //}
        //    //else
        //    //{
        //    //    return Convert.ToInt32(obj);
        //    //}
        //}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TranslatorList GetModel(int G_Id)
        {
            Model.TranslatorList model = null;
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "select * from TranslatorList where ID=@G_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);
                SqlDataReader sdr = cmd.ExecuteReader(CommandBehavior.SingleResult);
                if (sdr.Read())
                {
                    model = new Model.TranslatorList();
                    model.ID = G_Id;
                    model.UserName = sdr["UserName"] == System.DBNull.Value ? "" : (string)sdr["UserName"];
                    model.Age = sdr["Age"] == System.DBNull.Value ? "" : (string)sdr["Age"];
                    model.Sex = sdr["Sex"] == System.DBNull.Value ? "" : (string)sdr["Sex"];
                    model.Country = sdr["Country"] == System.DBNull.Value ? "" : (string)sdr["Country"];
                    model.WorkType = sdr["WorkType"] == System.DBNull.Value ? "" : (string)sdr["WorkType"];
                    model.TopGraduation = sdr["TopGraduation"] == System.DBNull.Value ? "" : (string)sdr["TopGraduation"];
                    model.IsLearning = sdr["IsLearning"] == System.DBNull.Value ? "" : (string)sdr["IsLearning"];
                    model.Language = sdr["Language"] == System.DBNull.Value ? "" : (string)sdr["Language"];
                    model.MasterLanguage = sdr["MasterLanguage"] == System.DBNull.Value ? "" : (string)sdr["MasterLanguage"];
                    model.Experience = sdr["Experience"] == System.DBNull.Value ? "" : (string)sdr["Experience"];
                    model.Seniority = sdr["Seniority"] == System.DBNull.Value ? "" : (string)sdr["Seniority"];
                    model.TranslationAmount = sdr["TranslationAmount"] == System.DBNull.Value ? "" : (string)sdr["TranslationAmount"];
                    model.Mark = sdr["Mark"] == System.DBNull.Value ? "" : (string)sdr["Mark"];
                    model.TransLationSkill = sdr["TransLationSkill"] == System.DBNull.Value ? "" : (string)sdr["TransLationSkill"];
                    model.SoftwareSkill = sdr["SoftwareSkill"] == System.DBNull.Value ? "" : (string)sdr["SoftwareSkill"];
                    model.TEL = sdr["TEL"] == System.DBNull.Value ? "" : (string)sdr["TEL"];
                    model.Email = sdr["Email"] == System.DBNull.Value ? "" : (string)sdr["Email"];
                    model.QQ = sdr["QQ"] == System.DBNull.Value ? "" : (string)sdr["QQ"];
                    model.MSN = sdr["MSN"] == System.DBNull.Value ? "" : (string)sdr["MSN"];
                    model.Creator = sdr["Creator"] == System.DBNull.Value ? "" : (string)sdr["Creator"];
                    model.CreateDate = sdr["CreateDate"] == System.DBNull.Value ? "" : (string)sdr["CreateDate"];


                    if (sdr["state"].ToString().Trim() != "")
                    {
                        model.state = Convert.ToInt32(sdr["state"].ToString().Trim());
                    }
                    else
                    {
                        model.state = 0;
                    }

                }
                sdr.Close();
            }
            return model;
        }

        public void UpdateIsFinish(int G_Id, int isfinish)
        {
            using (SqlConnection conn = new SqlConnection(PubConstant.ConnectionString))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                string sql = "update TranslatorList set state=@state where id=@G_Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@state", isfinish);
                cmd.Parameters.AddWithValue("@G_Id", G_Id);

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
            sql.Append("select count(1) from TranslatorList");
            return Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM TranslatorList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID as 編號,UserName as 姓名,Age as 年齡,Sex as 性別,TopGraduation as 最高學歷,CreateDate as 應聘時間,WorkType as 工作別,IsLearning as 是否在學,MasterLanguage as 主要語言,Seniority as 翻譯年資,TranslationAmount as 翻譯量,[Language] as 第二外語,TransLationSkill as 翻譯專長,SoftwareSkill as 專長軟件,TEL as 電話,Email,QQ,MSN,Experience as 翻譯經歷 ");
            strSql.Append(" FROM TranslatorList ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by id desc");
            return DbHelperOledb.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TranslatorList ");
            strSql.Append(" where id=" + G_Id + " ");
            DbHelperOledb.ExecuteSql(strSql.ToString());
        }
    }
}
