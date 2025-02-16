using System;
using System.Data;
using System.Collections.Generic;
using ZeroStudio.Model;

namespace ZeroStudio.BLL
{
    /// <summary>
    /// ҵ���߼���News ��ժҪ˵����
    /// </summary>
    public class News
    {
        private readonly ZeroStudio.DAL.News dal = new ZeroStudio.DAL.News();
        public News()
        { }
        #region  ��Ա����
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int N_Id)
        {
            return dal.Exists(N_Id);
        }


        public int Count(string where)
        {
            return dal.Count(where);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZeroStudio.Model.News model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZeroStudio.Model.News model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int N_Id)
        {

            dal.Delete(N_Id);
        }
        public void Delete(string where) {
            dal.Delete(where);
        }
        public void UpdateState(int N_Id, int state) {
            dal.UpdateState(N_Id, state);

        }
        public void UpdateHitNum(int N_Id, int num) {
            dal.UpdateHitNum(N_Id, num);
        }
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZeroStudio.Model.News GetModel(int N_Id)
        {

            return dal.GetModel(N_Id);
        }

        

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere,string orderby)
        {
            return dal.GetList(strWhere,orderby);
        }


        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("", "N_DateTime desc");
        }

        /// <summary>
        /// ���غ������������б�
        /// </summary>
        /// <param name="strWhere">��ѯSQL���</param>
        /// <returns></returns>
        public DataSet GetList_ClassName(string strWhere)
        {
            return dal.GetList_ClassName(strWhere);
        }


        public DataSet GetList_ClassName()
        {
            return dal.GetList_ClassName("");
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  ��Ա����
    }
}

