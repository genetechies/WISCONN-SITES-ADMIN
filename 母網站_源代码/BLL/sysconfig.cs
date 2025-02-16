using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class sysconfig
    {

        private readonly DAL.sysconfig dal = new DAL.sysconfig();
        public sysconfig()
        { }
        #region  成员方法
       

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(Model.sysconfig model)
        {
            dal.Update(model);
        }
       
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.sysconfig GetModel(int id)
        {

            return dal.GetModel(id);
        }

        

        #endregion  成员方法

    }
}
