using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using Model;
using System.Data.SqlClient;
namespace BLL
{
	/// <summary>
	/// SubWeb
	/// </summary>
	public partial class SubWeb
	{
		private readonly DAL.SubWeb dal=new DAL.SubWeb();
		public SubWeb()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int SWID)
		{
			return dal.Exists(SWID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Model.SubWeb model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Model.SubWeb model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int SWID)
		{
			
			return dal.Delete(SWID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string SWIDlist )
		{
			return dal.DeleteList(SWIDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Model.SubWeb GetModel(int SWID)
		{
			
			return dal.GetModel(SWID);
		}


		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}

        /// <summary>
        /// 创建数据库
        /// </summary>
        public DataSet SubWebDatabase(string DatabaseName)
        {
            return dal.SubWebDatabase(DatabaseName);
        }

        /// <summary>
        /// 删除表
        /// </summary>
        public DataSet SubWebDelTable(string DatabaseName)
        {
            return dal.SubWebDelTable(DatabaseName);
        }

        /// <summary>
        /// 复制表
        /// </summary>
        public DataSet SubWebCopyTable(string DatabaseName)
        {
            return dal.SubWebCopyTable(DatabaseName);
        }

        /// <summary>
        /// 刪除数据库
        /// </summary>
        public DataSet SubWebDelDatabase(string DatabaseName)
        {
            return dal.SubWebDelDatabase(DatabaseName);
        }
        /// <summary>
        /// 复制数据库
        /// </summary>
        public void SubWebTable(string DatabaseName)
        {
            dal.SubWebTable(DatabaseName);
        }

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.SubWeb> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Model.SubWeb> DataTableToList(DataTable dt)
		{
			List<Model.SubWeb> modelList = new List<Model.SubWeb>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Model.SubWeb model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Model.SubWeb();
					if(dt.Rows[n]["SWID"]!=null && dt.Rows[n]["SWID"].ToString()!="")
					{
						model.SWID=int.Parse(dt.Rows[n]["SWID"].ToString());
					}
					if(dt.Rows[n]["SWName"]!=null && dt.Rows[n]["SWName"].ToString()!="")
					{
					model.SWName=dt.Rows[n]["SWName"].ToString();
					}
					if(dt.Rows[n]["SWDomainName"]!=null && dt.Rows[n]["SWDomainName"].ToString()!="")
					{
					model.SWDomainName=dt.Rows[n]["SWDomainName"].ToString();
					}
					if(dt.Rows[n]["SWDBService"]!=null && dt.Rows[n]["SWDBService"].ToString()!="")
					{
					model.SWDBService=dt.Rows[n]["SWDBService"].ToString();
                        //model.SWDBService = "211.21.127.6";
					}
					if(dt.Rows[n]["SWDBName"]!=null && dt.Rows[n]["SWDBName"].ToString()!="")
					{
					model.SWDBName=dt.Rows[n]["SWDBName"].ToString();
					}
					if(dt.Rows[n]["SWDBID"]!=null && dt.Rows[n]["SWDBID"].ToString()!="")
					{
					model.SWDBID=dt.Rows[n]["SWDBID"].ToString();
					}
					if(dt.Rows[n]["SWDBUser"]!=null && dt.Rows[n]["SWDBUser"].ToString()!="")
					{
					model.SWDBUser=dt.Rows[n]["SWDBUser"].ToString();
					}
					if(dt.Rows[n]["SWDBUserPwd"]!=null && dt.Rows[n]["SWDBUserPwd"].ToString()!="")
					{
					model.SWDBUserPwd=dt.Rows[n]["SWDBUserPwd"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

