using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ZeroStudio.BLL
{
    public class Product
    {
        private readonly ZeroStudio.DAL.Product dal = new ZeroStudio.DAL.Product();
        public Product()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int P_ID)
        {
            return dal.Exists(P_ID);
        }

        /// <summary>
        /// 返回记录条数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return dal.Count();
        }

        public int Count(string where) {
            return dal.Count(where);
        }
        public int CountByClass(string where) {
            return dal.CountByClass(where);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.Product model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.Product model)
        {
            dal.Update(model);
        }
        public void UpdateState(int P_Id, int state) {
            dal.UpdateState(P_Id, state);
        }
        public void UpdateSortKey(int P_Id, int sortkey) {
            dal.UpdaetSortKey(P_Id, sortkey);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int P_ID)
        {

            dal.Delete(P_ID);
        }

        /// <summary>
        /// 得到一個对象实体
        /// </summary>
        public ZeroStudio.Model.Product GetModel(int P_ID)
        {

            return dal.GetModel(P_ID);
        }

        public ZeroStudio.Model.Product GetModel(string code) {

            return dal.GetModel(code);
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere,string orderby)
        {
            return dal.GetList(strWhere,orderby);
        }

        /// <summary>
        /// 获得符合查询条件的前Num记录
        /// </summary>
        /// <param name="num">要查询的条数</param>
        /// <param name="strWhere">查询条件</param>
        /// <returns></returns>
        public DataSet GetList(int num,string strWhere,string orderBy)
        {
            return dal.GetList(num,strWhere,orderBy);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("", "[Product].P_ParentID,[Product].PC_Id");
        }
        public DataSet GetListByClass(string strWhere, string orderBy) {
            return dal.GetListByClass(strWhere, orderBy);
        }
        public int GetMaxSortKey(string strWhere) {
            return dal.GetMaxSortKey(strWhere);
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
