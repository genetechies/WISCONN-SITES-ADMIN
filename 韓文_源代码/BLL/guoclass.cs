using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class guoclass
    {
        private readonly DAL.guoclass dal = new DAL.guoclass();
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
    }
}
