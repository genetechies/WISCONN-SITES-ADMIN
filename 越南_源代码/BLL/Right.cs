using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Right
    {

        private readonly DAL.Right dal = new DAL.Right();

        public bool Exists(string username, string pagename)
        {
            return dal.Exists(username, pagename);
        }
        public void Add(Model.Right model)
        {
            dal.Add(model);
        }
        public void Update(Model.Right model)
        {
            dal.Update(model);
        }

        public void Delete(int RightID)
        {
            dal.Delete(RightID);
        }

        //刪除子網站管理
        public void DeleteWeb(string UserName1,int Rights1)
        {
            dal.DeleteWhere(UserName1,Rights1);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Model.Right GetModel(int RightID)
        {
            return dal.GetModel(RightID);
        }

        public Model.Right GetModel(string username, string pagename)
        {
            return dal.GetModel(username, pagename);
        }
    }
}
