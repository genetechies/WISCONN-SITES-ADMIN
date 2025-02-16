using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ZeroStudio.BLL
{
    public class ProductClass
    {
        private  ZeroStudio.DAL.ProductClass dal = new ZeroStudio.DAL.ProductClass();
        public ProductClass()
        { }
        public ProductClass(bool isZh)
        {
            if (isZh)
            {
                dal = new ZeroStudio.DAL.ProductClass(isZh);
            }
        }
        #region  ��Ա����
        /// <summary>
        /// �Ƿ���ڸü�¼
        /// </summary>
        public bool Exists(int PC_Id)
        {
            return dal.Exists(PC_Id);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZeroStudio.Model.ProductClass model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Update(ZeroStudio.Model.ProductClass model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// ɾ��һ������
        /// </summary>
        public void Delete(int PC_Id)
        {

            dal.Delete(PC_Id);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public ZeroStudio.Model.ProductClass GetModel(int PC_Id)
        {

            return dal.GetModel(PC_Id);
        }
        public ZeroStudio.Model.ProductClass GetModel(string className) {
            return dal.GetModel(className);
        }
        public int GetMaxSortKey(string strWhere) {
            return dal.GetMaxSortKey(strWhere);
        }

        public void ExcuteSql(string sql) {
            dal.ExcuteSql(sql);
        }
       

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<ZeroStudio.Model.ProductClass> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<ZeroStudio.Model.ProductClass> DataTableToList(DataTable dt)
        {
            List<ZeroStudio.Model.ProductClass> modelList = new List<ZeroStudio.Model.ProductClass>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                ZeroStudio.Model.ProductClass model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new ZeroStudio.Model.ProductClass();
                    if (dt.Rows[n]["PC_Id"].ToString() != "")
                    {
                        model.PC_Id = int.Parse(dt.Rows[n]["PC_Id"].ToString());
                    }
                    if (dt.Rows[n]["PC_Id_Zh"].ToString() != "")
                    {
                        model.PC_Id_Zh = int.Parse(dt.Rows[n]["PC_Id_Zh"].ToString());
                    }
                    model.PC_ClassName = dt.Rows[n]["PC_ClassName"].ToString();
                    if (dt.Rows[n]["PC_ParentID"].ToString() != "")
                    {
                        model.PC_ParentID = int.Parse(dt.Rows[n]["PC_ParentID"].ToString());
                    }
                    if (dt.Rows[n]["PC_ParentID_Zh"].ToString() != "")
                    {
                        model.PC_ParentID_Zh = int.Parse(dt.Rows[n]["PC_ParentID_Zh"].ToString());
                    }
                    model.PC_ClassNameEn = dt.Rows[n]["PC_ClassName_En"].ToString();
                    model.PC_SortKey = int.Parse(dt.Rows[n]["PC_SortKey"].ToString());
                    model.PC_ImageUrl= dt.Rows[n]["PC_ImageUrl"].ToString();
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
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
