using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class XunJia
    {
        private readonly DAL.XunJia dal = new DAL.XunJia();

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int G_Id)
        {
            return dal.Exists(G_Id);
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
        /// 增加一条数据
        /// </summary>
        public void Add(Model.XunJia model)
        {
            dal.Add(model);
        }

        ///// <summary>
        ///// 更新一条数据
        ///// </summary>
        //public void Update(Model.GuestBook model)
        //{
        //    dal.Update(model);
        //}


        public void UpdateIsFinish(int G_Id, int isfinish)
        {
            dal.UpdateIsFinish(G_Id, isfinish);
        }


        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {

            dal.Delete(G_Id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.XunJia GetModel(int G_Id)
        {

            return dal.GetModel(G_Id);
        }

        /// <summary>
        /// 统计一小时内同一ip提交次数
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public int GetCountByIP(string ip)
        {
            return dal.GetCountByIP(ip);
        }
        
    }
}
