using System;
using System.Data;
using System.Collections.Generic;
using ZeroStudio.Model;

namespace ZeroStudio.BLL
{
    /// <summary>
    /// 业务逻辑类News 的摘要说明。
    /// </summary>
    public class News
    {
        private readonly ZeroStudio.DAL.News dal = new ZeroStudio.DAL.News();
        public News()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int N_Id)
        {
            return dal.Exists(N_Id);
        }


        public int Count(string where)
        {
            return dal.Count(where);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.News model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.News model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int N_Id)
        {

            dal.Delete(N_Id);
        }
        public void Delete(string where) {
            dal.Delete(where);
        }
        public void UpdateState(int N_Id, int state) {
            dal.UpdateState(N_Id, state);

        }
        public void UpdateHitNum(int N_Id, int num) {
            dal.UpdateHitNum(N_Id, num);
        }
        /// <summary>
        /// 得到一個对象实体
        /// </summary>
        public ZeroStudio.Model.News GetModel(int N_Id)
        {

            return dal.GetModel(N_Id);
        }

        

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,string orderby)
        {
            return dal.GetList(strWhere,orderby);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("", "N_DateTime desc");
        }

        /// <summary>
        /// 返回含类名的新闻列表
        /// </summary>
        /// <param name="strWhere">查询SQL语句</param>
        /// <returns></returns>
        public DataSet GetList_ClassName(string strWhere)
        {
            return dal.GetList_ClassName(strWhere);
        }


        public DataSet GetList_ClassName()
        {
            return dal.GetList_ClassName("");
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法
    }
}

