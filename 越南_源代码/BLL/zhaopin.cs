using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class zhaopin
    {
        private readonly DAL.zhaopin dal = new DAL.zhaopin();

        public int CountByClass(string where)
        {
            return dal.CountByClass(where);
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
        public DataSet GetListByClass(string strWhere, string orderBy)
        {
            return dal.GetListByClass(strWhere, orderBy);
        }

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
        /// 得到一个对象实体
        /// </summary>
        public Model.zhaopin GetModel(int P_ID)
        {

            return dal.GetModel(P_ID);
        }

        public void UpdateSortKey(int P_Id, int sortkey)
        {
            dal.UpdaetSortKey(P_Id, sortkey);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(Model.zhaopin model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.zhaopin model)
        {
            return dal.Update(model);
        }

    }
}
