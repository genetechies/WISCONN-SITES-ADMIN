using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ZeroStudio.BLL
{
    public class NewsClass
    {
        private readonly DAL.NewsClass dal = new DAL.NewsClass();

        public NewsClass() { }

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
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.NewsClass model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.NewsClass model)
        {
            return dal.Update(model);
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
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            return dal.GetAll();
        }

        public Model.NewsClass GetModel(int NC_Id)
        {
            return dal.GetModel(NC_Id);
        }
    }
}
