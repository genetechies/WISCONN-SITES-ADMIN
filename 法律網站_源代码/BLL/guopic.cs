using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class guopic
    {
        private readonly DAL.guopic dal = new DAL.guopic();

        public int Count(string where)
        {
            return dal.Count(where);
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
        public DataSet GetListByClass(string strWhere, string orderBy)
        {
            return dal.GetListByClass(strWhere, orderBy);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByClass(string strWhere, string orderBy,Model.SubWeb sw)
        {
            return dal.GetListByClass(strWhere, orderBy,sw);
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            return dal.GetAll();
        }


        public int GetMaxSortKey(string strWhere)
        {
            return dal.GetMaxSortKey(strWhere);
        }

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName)
        {
            Model.guopic model = new Model.guopic();
            model.title = ClassName;
            return dal.Exists(model);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.guopic model)
        {
            return dal.Add(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.guopic model,Model.SubWeb sw)
        {
            return dal.Add(model,sw);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.guopic model)
        {
            return dal.Update(model);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.guopic model,Model.SubWeb sw)
        {
            return dal.Update(model,sw);
        }
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        public Model.guopic GetModel(int NC_Id)
        {
            return dal.GetModel(NC_Id);
        }
        public Model.guopic GetModel(int NC_Id,Model.SubWeb sw)
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



    }
}
