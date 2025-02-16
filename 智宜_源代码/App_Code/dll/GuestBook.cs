using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ZeroStudio.DAL;

namespace ZeroStudio.BLL
{
    public class GuestBook
    {
        private readonly DAL.GuestBook dal = new ZeroStudio.DAL.GuestBook();
        public GuestBook()
        { }
        #region  成员方法
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
        /// 增加一条数据
        /// </summary>
        public void Add(ZeroStudio.Model.GuestBook model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(ZeroStudio.Model.GuestBook model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int G_Id)
        {

            dal.Delete(G_Id);
        }

        /// <summary>
        /// 得到一個对象实体
        /// </summary>
        public ZeroStudio.Model.GuestBook GetModel(int G_Id)
        {

            return dal.GetModel(G_Id);
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

        

        #endregion  成员方法
    }
}
