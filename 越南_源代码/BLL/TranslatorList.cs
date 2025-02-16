using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class TranslatorList
    {
        private readonly DAL.TranslatorList dal = new DAL.TranslatorList();

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.TranslatorList GetModel(int G_Id)
        {

            return dal.GetModel(G_Id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.TranslatorList model)
        {
            dal.Add(model);
        }


        public void UpdateIsFinish(int G_Id, int isfinish)
        {
            dal.UpdateIsFinish(G_Id, isfinish);
        }

        /// <summary>
        /// 返回留言条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return dal.Count();
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
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList()
        {
            return dal.GetoutList("");
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {

            dal.Delete(G_Id);
        }
    }
}
