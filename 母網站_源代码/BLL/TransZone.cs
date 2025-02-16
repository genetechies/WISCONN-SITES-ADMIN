using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public partial class TransZone
    {
        private readonly DAL.TransZone dal = new DAL.TransZone();
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName)
        {
            Model.guoclass model = new Model.guoclass();
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
            Model.guoclass model = new Model.guoclass();
            model.ClassName = ClassName;
            return dal.Exists(model,sw);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int Add(Model.guoclass model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int Add(Model.guoclass model,Model.SubWeb sw)
        {
            return dal.Add(model,sw);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.guoclass model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.guoclass model,Model.SubWeb sw)
        {
            return dal.Update(model,sw);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return dal.Delete(id);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id,Model.SubWeb sw)
        {
            return dal.Delete(id,sw);
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            return dal.GetAll();
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll(Model.SubWeb sw)
        {
            return dal.GetAll(sw);
        }
        public int GetMaxSortKey(string strWhere)
        {
            return dal.GetMaxSortKey(strWhere);
        }
        public int GetMaxSortKey(string strWhere,Model.SubWeb sw)
        {
            return dal.GetMaxSortKey(strWhere,sw);
        }
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            return dal.GetList(strWhere,sw);
        }
        public Model.guoclass GetModel(int NC_Id)
        {
            return dal.GetModel(NC_Id);
        }
        public Model.guoclass GetModel(int NC_Id,Model.SubWeb sw)
        {
            return dal.GetModel(NC_Id,sw);
        }
        public Model.guoclass GetModel_where(string where)
        {
            return dal.GetModel_where(where);
        }
        public Model.guoclass GetModel_where(string where,Model.SubWeb sw)
        {
            return dal.GetModel_where(where,sw);
        }
        ////////////////////////////////////////////////////////////////以下 翻译领域内容

        public int CountNew(string where)
        {
            return dal.CountNew(where);
        }
        public int CountNew(string where,Model.SubWeb sw)
        {
            return dal.CountNew(where,sw);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByClassNew(string strWhere, string orderBy)
        {
            return dal.GetListByClassNew(strWhere, orderBy);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByClassNew(string strWhere, string orderBy,Model.SubWeb sw)
        {
            return dal.GetListByClassNew(strWhere, orderBy,sw);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListNew(string strWhere)
        {
            return dal.GetListNew(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListNew(string strWhere,Model.SubWeb sw)
        {
            return dal.GetListNew(strWhere,sw);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_topNew(int num, string strWhere)
        {
            return dal.GetList_topNew(num, strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList_topNew(int num, string strWhere,Model.SubWeb sw)
        {
            return dal.GetList_topNew(num, strWhere,sw);
        }
        public void UpdateStateNew(int P_Id, int state)
        {
            dal.UpdateStateNew(P_Id, state);
        }
        public void UpdateStateNew(int P_Id, int state,Model.SubWeb sw)
        {
            dal.UpdateStateNew(P_Id, state,sw);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModelNew(int P_ID)
        {

            return dal.GetModelNew(P_ID);
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.newsdata GetModelNew(int P_ID,Model.SubWeb sw)
        {

            return dal.GetModelNew(P_ID,sw);
        }
        public void UpdateSortKeyNew(int P_Id, int sortkey)
        {
            dal.UpdaetSortKeyNew(P_Id, sortkey);
        }
        public void UpdateSortKeyNew(int P_Id, int sortkey,Model.SubWeb sw)
        {
            dal.UpdaetSortKeyNew(P_Id, sortkey);
        }
        public int CountByClassNew(string where)
        {
            return dal.CountByClassNew(where);
        }
        public int CountByClassNew(string where,Model.SubWeb sw)
        {
            return dal.CountByClassNew(where,sw);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool AddNew(Model.newsdata model)
        {
            return dal.AddNew(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool AddNew(Model.newsdata model,Model.SubWeb sw)
        {
            return dal.AddNew(model,sw);
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
        public void UpdateNew(Model.newsdata model)
        {
            dal.UpdateNew(model);
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void UpdateNew(Model.newsdata model,Model.SubWeb sw)
        {
            dal.UpdateNew(model,sw);
        }
        public void Update_clickNew(int P_Id)
        {
            dal.Update_clickNew(P_Id);
        }
        public void Update_clickNew(int P_Id,Model.SubWeb sw)
        {
            dal.Update_clickNew(P_Id,sw);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteNew(int id)
        {
            return dal.DeleteNew(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteNew(int id,Model.SubWeb sw)
        {
            return dal.DeleteNew(id,sw);
        }
        public DataTable GetTop5CloseNews(string keys, string title)
        {
            return dal.GetTop5CloseNews(keys, title);
        }
        public DataTable GetTop5CloseNews(string keys, string title,Model.SubWeb sw)
        {
            return dal.GetTop5CloseNews(keys, title,sw);
        }
    }
}
