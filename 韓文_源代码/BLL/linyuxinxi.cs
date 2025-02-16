using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class linyuxinxi
    {
        private readonly DAL.linyuxinxi dal = new DAL.linyuxinxi();

        public int CountByClass(string where)
        {
            return dal.CountByClass(where);
        }
        public int CountByClass(string where,Model.SubWeb sw)
        {
            return dal.CountByClass(where,sw);
        }
        public bool UpdateState(int P_Id, int state)
        {
            return dal.UpdateState(P_Id, state);
        }
        public bool UpdateState(int P_Id, int state,Model.SubWeb sw)
        {
            return dal.UpdateState(P_Id, state,sw);
        }
        public int GetMaxSortKey(string strWhere)
        {
            return dal.GetMaxSortKey(strWhere);
        }
        public int GetMaxSortKey(string strWhere,Model.SubWeb sw)
        {
            return dal.GetMaxSortKey(strWhere,sw);
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
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName)
        {
            Model.linyuxinxi model = new Model.linyuxinxi();
            model.title = ClassName;
            return dal.Exists(model);
        }
        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName,Model.SubWeb sw)
        {
            Model.linyuxinxi model = new Model.linyuxinxi();
            model.title = ClassName;
            return dal.Exists(model,sw);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.linyuxinxi model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.linyuxinxi model,Model.SubWeb sw)
        {
            return dal.Add(model,sw);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.linyuxinxi model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.linyuxinxi model,Model.SubWeb sw)
        {
            return dal.Update(model,sw);
        }
        public Model.linyuxinxi GetModel(int NC_Id)
        {
            return dal.GetModel(NC_Id);
        }
        public Model.linyuxinxi GetModel(int NC_Id,Model.SubWeb sw)
        {
            return dal.GetModel(NC_Id,sw);
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

        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            return dal.GetList(strWhere,sw);
        }
        public DataSet GetList_top(int num,string strWhere)
        {
            return dal.GetList_top(num,strWhere);
        }
        public DataSet GetList_top(int num, string strWhere,Model.SubWeb sw)
        {
            return dal.GetList_top(num, strWhere,sw);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList()
        {
            return dal.GetoutList();
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList(Model.SubWeb sw)
        {
            return dal.GetoutList(sw);
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count(string where)
        {
            return dal.Count(where);
        }
        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count(string where,Model.SubWeb sw)
        {
            return dal.Count(where,sw);
        }


    }
}
