using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class NewsClass
    {

        private readonly DAL.NewsClass dal = new DAL.NewsClass();

        //public int Count(string where)
        //{
        //    return dal.Count(where);
        //}

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName)
        {
            Model.NewsClass model = new Model.NewsClass();
            model.ClassName = ClassName;
            return dal.Exists(model);
        }
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName,Model.SubWeb sw)
        {
            Model.NewsClass model = new Model.NewsClass();
            model.ClassName = ClassName;
            return dal.Exists(model,sw);
        }
        ///// <summary>
        ///// 得到所有数据列表
        ///// </summary>
        ///// <returns></returns>
        //public DataSet GetAll()
        //{
        //    return dal.GetAll();
        //}

        public int GetMaxSortKey(string strWhere)
        {
            return dal.GetMaxSortKey(strWhere);
        }
        public int GetMaxSortKey(string strWhere,Model.SubWeb sw)
        {
            return dal.GetMaxSortKey(strWhere,sw);
        }
        ///// <summary>
        ///// 获得数据列表
        ///// </summary>
        //public DataSet GetListByClass(string strWhere, string orderBy)
        //{
        //    return dal.GetListByClass(strWhere, orderBy);
        //}

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
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            return dal.GetList(strWhere,sw);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num, string strWhere)
        {
            return dal.GetList_top(num, strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_top(int num, string strWhere, Model.SubWeb sw)
        {
            return dal.GetList_top(num, strWhere, sw);
        }
        //public void UpdateState(int P_Id, int state)
        //{
        //    dal.UpdateState(P_Id, state);
        //}

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.NewsClass GetModel(int P_ID)
        {

            return dal.GetModel(P_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.NewsClass GetModel(int P_ID,Model.SubWeb sw)
        {

            return dal.GetModel(P_ID,sw);
        }
        //public void UpdateSortKey(int P_Id, int sortkey)
        //{
        //    dal.UpdaetSortKey(P_Id, sortkey);
        //}

        //public int CountByClass(string where)
        //{
        //    return dal.CountByClass(where);
        //}

        ///// <summary>
        ///// 增加一条数据
        ///// </summary>
        //public void Add(Model.NewsClass model)
        //{
        //    dal.Add(model);
        //}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool AddSmall(Model.NewsClass model)
        {
            return dal.AddSmall(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool AddSmall(Model.NewsClass model,Model.SubWeb sw)
        {
            return dal.AddSmall(model,sw);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSmall(Model.NewsClass model)
        {
            return dal.UpdateSmall(model);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateSmall(Model.NewsClass model,Model.SubWeb sw)
        {
            return dal.UpdateSmall(model,sw);
        }
        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public void Update(Model.NewsClass model)
        //{
        //    dal.Update(model);
        //}

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return dal.Delete(id);
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
