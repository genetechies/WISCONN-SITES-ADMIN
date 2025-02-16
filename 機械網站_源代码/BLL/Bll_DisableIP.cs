using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class Bll_DisableIP
    {
        Dal_DisableIP dal = new Dal_DisableIP();
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int D_Id)
        {
            return dal.Exists(D_Id);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string ipAddress)
        {
            return dal.Exists(ipAddress);
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
        public void Add(Model_DisableIP model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int D_Id)
        {
            dal.Delete(D_Id);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model_DisableIP GetModel(int D_Id)
        {

            return dal.GetModel(D_Id);
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
    }
}
