using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Manager
    {
        private readonly DAL.Manager dal = new DAL.Manager();

        public Manager() { }

        /// <summary>
        /// 添加管理员
        /// </summary>
        /// <param name="model"></param>
        public void Add(Model.Manager model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 根据用户名和密码判断管理员是否存在
        /// </summary>
        /// <param name="adminame">管理员名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool Exists(string adminame, string password)
        {
            Model.Manager model = new Model.Manager();
            model.AdminName = adminame;
            model.Password = password;
            return dal.Exists(model.AdminName, model.Password);
        }

        /// <summary>
        /// 判断管理员名是否存在
        /// </summary>
        /// <param name="adminname">根据用户名</param>
        /// <returns></returns>
        public bool Exists(string adminname)
        {
            Model.Manager m = new Model.Manager();
            m.AdminName = adminname;
            return dal.Exists(m);
        }
        public Model.Manager GetModel(int m_id)
        {
            return dal.GetModel(m_id);
        }
        /// <summary>
        /// 返回管理员列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            return dal.GetAll();
        }

        /// <summary>
        /// 返回管理员是否只有一个
        /// </summary>
        /// <returns></returns>
        public bool CountIsOne()
        {
            return dal.CountIsOne();
        }

        /// <summary>
        /// 删除管理员
        /// </summary>
        /// <param name="M_ID">Id</param>
        /// <returns></returns>
        public bool Delete(int M_ID)
        {
            return dal.Delete(M_ID);
        }



        public bool Update(Model.Manager model)
        {
            return dal.Update(model);
        }
    }
}
