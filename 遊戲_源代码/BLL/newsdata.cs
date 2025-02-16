using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class newsdata
    {
        private readonly DAL.newsdata dal = new DAL.newsdata();

        public int Count(string where)
        {
            return dal.Count(where);
        }

        ///// <summary>
        ///// 判断类名是否存在
        ///// </summary>
        ///// <param name="ClassName"></param>
        ///// <returns></returns>
        //public bool Exists(string ClassName)
        //{
        //    Model.newsdata model = new Model.newsdata();
        //    model.ClassName = ClassName;
        //    return dal.Exists(model);
        //}

        ///// <summary>
        ///// 得到所有数据列表
        ///// </summary>
        ///// <returns></returns>
        //public DataSet GetAll()
        //{
        //    return dal.GetAll();
        //}

        //public int GetMaxSortKey(string strWhere)
        //{
        //    return dal.GetMaxSortKey(strWhere);
        //}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByClass(string strWhere, string orderBy,Model.SubWeb sw)
        {
            return dal.GetListByClass(strWhere, orderBy,sw);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num, string strWhere)
        {
            return dal.GetList_top(num, strWhere);
        }

        public void UpdateState(int P_Id, int state,Model.SubWeb sw)
        {
            dal.UpdateState(P_Id, state,sw);
        }

        public DataTable GetTop5CloseNews(string keys, string title)
        {
            return dal.GetTop5CloseNews(keys, title);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModel(int P_ID,Model.SubWeb sw)
        {

            return dal.GetModel(P_ID,sw);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModel(int P_ID)
        {

            return dal.GetModel(P_ID);
        }
        public void UpdateSortKey(int P_Id, int sortkey)
        {
            dal.UpdaetSortKey(P_Id, sortkey);
        }

        public int CountByClass(string where)
        {
            return dal.CountByClass(where);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Model.newsdata model,Model.SubWeb web)
        {
           return dal.Add(model,web);
        }

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        ///// <param name="model"></param>
        //public bool AddSmall(Model.newsdata model)
        //{
        //    return dal.AddSmall(model);
        //}

        ///// <summary>
        ///// 修改一条数据
        ///// </summary>
        ///// <param name="model"></param>
        ///// <returns></returns>
        //public bool UpdateSmall(Model.newsdata model)
        //{
        //    return dal.UpdateSmall(model);
        //}

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.newsdata model,Model.SubWeb sw)
        {
            dal.Update(model,sw);
        }

        public void Update_click(int P_Id)
        {
            dal.Update_click(P_Id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id,Model.SubWeb sw)
        {
            return dal.Delete(id,sw);
        }
    }
}
