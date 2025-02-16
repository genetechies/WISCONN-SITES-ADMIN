using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class TransTeam
    {
        private readonly DAL.TransTeam dal = new DAL.TransTeam();

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool ExistsTeamType(string ClassName)
        {
            Model.guoclass model = new Model.guoclass();
            model.ClassName = ClassName;
            return dal.ExistsTeamType(model);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int AddTeamType(Model.guoclass model)
        {
            return dal.AddTeamType(model);
        }
        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public int AddTeamType(Model.guoclass model,Model.SubWeb sw)
        {
            return dal.AddTeamType(model,sw);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateTeamType(Model.guoclass model)
        {
            return dal.UpdateTeamType(model);
        }
        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool UpdateTeamType(Model.guoclass model,Model.SubWeb sw)
        {
            return dal.UpdateTeamType(model,sw);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteTeamType(int id)
        {
            return dal.DeleteTeamType(id);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteTeamType(int id,Model.SubWeb sw)
        {
            return dal.DeleteTeamType(id,sw);
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllTeamType()
        {
            return dal.GetAllTeamType();
        }
        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllTeamType(Model.SubWeb sw)
        {
            return dal.GetAllTeamType(sw);
        }
        public int GetMaxSortKeyTeamType(string strWhere)
        {
            return dal.GetMaxSortKeyTeamType(strWhere);
        }
        public DataSet GetListTeamType(string strWhere)
        {
            return dal.GetListTeamType(strWhere);
        }
        public DataSet GetListTeamType(string strWhere,Model.SubWeb sw)
        {
            return dal.GetListTeamType(strWhere,sw);
        }
        public Model.guoclass GetModelTeamType(int NC_Id)
        {
            return dal.GetModelTeamType(NC_Id);
        }
        public Model.guoclass GetModelTeamType(int NC_Id,Model.SubWeb sw)
        {
            return dal.GetModelTeamType(NC_Id,sw);
        }
        public Model.guoclass GetModel_whereTeamType(string where)
        {
            return dal.GetModel_whereTeamType(where);
        }

        ////////////////////////////////////以下团队

        public int Count(string where)
        {
            return dal.Count(where);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetoutList()
        {
            return dal.GetoutList();
        }




        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListByClass(string strWhere, string orderBy, Model.SubWeb sw)
        {
            return dal.GetListByClass(strWhere, orderBy, sw);
        }

        /// <summary>
        /// 得到所有数据列表
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        {
            return dal.GetAll();
        }


        public int GetMaxSortKey(string strWhere)
        {
            return dal.GetMaxSortKey(strWhere);
        }

        /// <summary>
        /// 判断类名是否存在
        /// </summary>
        /// <param name="ClassName"></param>
        /// <returns></returns>
        public bool Exists(string ClassName)
        {
            Model.TransTeam model = new Model.TransTeam();
            model.tname = ClassName;
            return dal.Exists(model);
        }



        /// <summary>
        /// 增加一条数据
        /// </summary>
        /// <param name="model"></param>
        public bool Add(Model.TransTeam model, Model.SubWeb sw)
        {
            return dal.Add(model, sw);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Update(Model.TransTeam model, Model.SubWeb sw)
        {
            return dal.Update(model, sw);
        }

        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        public DataSet GetList(string strWhere,Model.SubWeb sw)
        {
            return dal.GetList(strWhere,sw);
        }
        public Model.TransTeam GetModel(int NC_Id, Model.SubWeb sw)
        {
            return dal.GetModel(NC_Id, sw);
        }

        /// <summary>
        /// 修改一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id, Model.SubWeb sw)
        {
            return dal.Delete(id, sw);
        }


        public void UpdaetSortKey(int P_Id, int sortkey)
        {
            dal.UpdaetSortKey(P_Id, sortkey);
        }
    }
}
