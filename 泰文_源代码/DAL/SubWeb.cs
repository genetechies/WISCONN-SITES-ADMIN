using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;
namespace DAL
{
	/// <summary>
	/// 数据访问类:SubWeb
	/// </summary>
	public partial class SubWeb
	{
		public SubWeb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("SWID", "SubWeb"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SWID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SubWeb");
			strSql.Append(" where SWID=@SWID");
			SqlParameter[] parameters = {
					new SqlParameter("@SWID", SqlDbType.Int,4)
};
			parameters[0].Value = SWID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Model.SubWeb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SubWeb(");
			strSql.Append("SWName,SWDomainName,SWDBService,SWDBName,SWDBID,SWDBUser,SWDBUserPwd)");
			strSql.Append(" values (");
			strSql.Append("@SWName,@SWDomainName,@SWDBService,@SWDBName,@SWDBID,@SWDBUser,@SWDBUserPwd)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@SWName", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDomainName", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBService", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBName", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBID", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBUser", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBUserPwd", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.SWName;
			parameters[1].Value = model.SWDomainName;
			parameters[2].Value = model.SWDBService;
			parameters[3].Value = model.SWDBName;
			parameters[4].Value = model.SWDBID;
			parameters[5].Value = model.SWDBUser;
			parameters[6].Value = model.SWDBUserPwd;
            object obj = DbHelperSQL.GetSingle(strSql.ToString(), parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.SubWeb model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SubWeb set ");
			strSql.Append("SWName=@SWName,");
			strSql.Append("SWDomainName=@SWDomainName,");
			strSql.Append("SWDBService=@SWDBService,");
			strSql.Append("SWDBName=@SWDBName,");
			strSql.Append("SWDBID=@SWDBID,");
			strSql.Append("SWDBUser=@SWDBUser,");
			strSql.Append("SWDBUserPwd=@SWDBUserPwd");
			strSql.Append(" where SWID=@SWID");
			SqlParameter[] parameters = {
					new SqlParameter("@SWName", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDomainName", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBService", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBName", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBID", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBUser", SqlDbType.NVarChar,100),
					new SqlParameter("@SWDBUserPwd", SqlDbType.NVarChar,100),
					new SqlParameter("@SWID", SqlDbType.Int,4)};
			parameters[0].Value = model.SWName;
			parameters[1].Value = model.SWDomainName;
			parameters[2].Value = model.SWDBService;
			parameters[3].Value = model.SWDBName;
			parameters[4].Value = model.SWDBID;
			parameters[5].Value = model.SWDBUser;
			parameters[6].Value = model.SWDBUserPwd;
			parameters[7].Value = model.SWID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SWID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SubWeb ");
			strSql.Append(" where SWID=@SWID");
			SqlParameter[] parameters = {
					new SqlParameter("@SWID", SqlDbType.Int,4)
};
			parameters[0].Value = SWID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string SWIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SubWeb ");
			strSql.Append(" where SWID in ("+SWIDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.SubWeb GetModel(int SWID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 SWID,SWName,SWDomainName,SWDBService,SWDBName,SWDBID,SWDBUser,SWDBUserPwd from SubWeb ");
			strSql.Append(" where SWID=@SWID");
			SqlParameter[] parameters = {
					new SqlParameter("@SWID", SqlDbType.Int,4)
};
			parameters[0].Value = SWID;

			Model.SubWeb model=new Model.SubWeb();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["SWID"]!=null && ds.Tables[0].Rows[0]["SWID"].ToString()!="")
				{
					model.SWID=int.Parse(ds.Tables[0].Rows[0]["SWID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["SWName"]!=null && ds.Tables[0].Rows[0]["SWName"].ToString()!="")
				{
					model.SWName=ds.Tables[0].Rows[0]["SWName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SWDomainName"]!=null && ds.Tables[0].Rows[0]["SWDomainName"].ToString()!="")
				{
					model.SWDomainName=ds.Tables[0].Rows[0]["SWDomainName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SWDBService"]!=null && ds.Tables[0].Rows[0]["SWDBService"].ToString()!="")
				{
					model.SWDBService=ds.Tables[0].Rows[0]["SWDBService"].ToString();
                    
                    //model.SWDBService = "211.21.127.6";
				}
				if(ds.Tables[0].Rows[0]["SWDBName"]!=null && ds.Tables[0].Rows[0]["SWDBName"].ToString()!="")
				{
					model.SWDBName=ds.Tables[0].Rows[0]["SWDBName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SWDBID"]!=null && ds.Tables[0].Rows[0]["SWDBID"].ToString()!="")
				{
					model.SWDBID=ds.Tables[0].Rows[0]["SWDBID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SWDBUser"]!=null && ds.Tables[0].Rows[0]["SWDBUser"].ToString()!="")
				{
					model.SWDBUser=ds.Tables[0].Rows[0]["SWDBUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["SWDBUserPwd"]!=null && ds.Tables[0].Rows[0]["SWDBUserPwd"].ToString()!="")
				{
					model.SWDBUserPwd=ds.Tables[0].Rows[0]["SWDBUserPwd"].ToString();
				}
				return model;
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SWID,SWName,SWDomainName,SWDBService,SWDBName,SWDBID,SWDBUser,SWDBUserPwd ");
			strSql.Append(" FROM SubWeb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

        /// <summary>
        /// 添加子网站数据库
        /// </summary>
        public DataSet SubWebDatabase(string DatabaseName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("create database "+ DatabaseName +" ");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 删除数据库表
        /// </summary>
        public DataSet SubWebDelTable(string DatabaseName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("use " + DatabaseName + "  ");
            strSql.Append("drop table sysconfig ");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 复制数据库表到新表
        /// </summary>
        public DataSet SubWebCopyTable(string DatabaseName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("use " + DatabaseName + "  ");
            strSql.Append("select * into sysconfig from crownsmother.dbo.sysconfig");
            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 刪除子网站数据库
        /// </summary>
        public DataSet SubWebDelDatabase(string DatabaseName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("drop database " + DatabaseName + " ");

            return DbHelperSQL.Query(strSql.ToString());
        }

        /// <summary>
        /// 复制数据库表
        /// </summary>
        public void SubWebTable(string DatabaseName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("exec CreateDatabase '" + DatabaseName + "' ");

            DbHelperSQL.Query(strSql.ToString());
        }


		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" SWID,SWName,SWDomainName,SWDBService,SWDBName,SWDBID,SWDBUser,SWDBUserPwd ");
			strSql.Append(" FROM SubWeb ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "SubWeb";
			parameters[1].Value = "SWID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

