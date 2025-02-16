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
        #region  ��Ա����
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int P_ID)
        {
            return dal.Exists(P_ID);
        }

        /// <summary>
        /// ���ؼ�¼����
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
        /// ����һ������
        /// </summary>
        public void Add(ZeroStudio.Model.Product model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
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
        /// ɾ��һ������
        /// </summary>
        public void Delete(int P_ID)
        {

            dal.Delete(P_ID);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZeroStudio.Model.Product GetModel(int P_ID)
        {

            return dal.GetModel(P_ID);
        }

        public ZeroStudio.Model.Product GetModel(string code) {

            return dal.GetModel(code);
        }


        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere,string orderby)
        {
            return dal.GetList(strWhere,orderby);
        }

        /// <summary>
        /// ��÷��ϲ�ѯ������ǰNum��¼
        /// </summary>
        /// <param name="num">Ҫ��ѯ������</param>
        /// <param name="strWhere">��ѯ����</param>
        /// <returns></returns>
        public DataSet GetList(int num,string strWhere,string orderBy)
        {
            return dal.GetList(num,strWhere,orderBy);
        }

        /// <summary>
        /// ��������б�
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
        /// ��������б�
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  ��Ա����
    }
}
