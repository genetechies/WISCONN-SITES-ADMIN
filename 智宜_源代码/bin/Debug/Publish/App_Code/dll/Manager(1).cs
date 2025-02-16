using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using ZeroStudio.Model;
using ZeroStudio.DBUtility;
using System.Data;

namespace ZeroStudio.DAL
{
    public class Manager
    {
        public Manager()
        { }

        /// <summary>
        /// ����һ������
        /// </summary>
        public void Add(ZeroStudio.Model.Manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into Manager(");
            strSql.Append("M_AdminName,M_Password)");
            strSql.Append(" values (");
            strSql.Append("@AdminName,@Password)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@AdminName", OleDbType.VarChar,50),
					new OleDbParameter("@Password", OleDbType.VarChar,50)};
            parameters[0].Value = model.AdminName;
            parameters[1].Value = model.Password;
            DbHelperOledb.ExecuteSql(strSql.ToString(), parameters);
        }

        /// <summary>
        /// ��ѯ����Ա���Ƿ����
        /// </summary>
        /// <param name="model">Ҫ�жϵ�Ŀ�����</param>
        /// <returns>���ڷ���true�����򷵻�false</returns>
        public bool Exists(Model.Manager model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("Select count(*) from Manager where ");
            strSql.Append("M_AdminName='"+ model.AdminName +"'");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(strSql.ToString()));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// �����û����������жϹ���Ա�Ƿ����
        /// </summary>
        /// <param name="adminname">�û���</param>
        /// <param name="password">����</param>
        /// <returns>���ڷ���true�����򷵻�false</returns>
        public bool Exists(string adminname, string password)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select count(*) from Manager where ");
            sql.Append("M_AdminName='"+ adminname +"' ");
            sql.Append("and M_Password='"+ password +"'");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// ���ع���Ա�б�
        /// </summary>
        /// <returns></returns>
        public DataSet GetAll()
        { 
            StringBuilder sql=new StringBuilder();
            sql.Append("select * from Manager");
            return DbHelperOledb.Query(sql.ToString());
        }

        /// <summary>
        /// �жϹ���Ա�Ƿ�ֻ��һ��
        /// </summary>
        /// <returns></returns>
        public bool CountIsOne()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Select count(*) from Manager");
            int i = Convert.ToInt32(DbHelperOledb.ExecuteScalar(sql.ToString()));
            if (i == 1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// ��������ɾ��
        /// </summary>
        /// <param name="M_ID">Ҫɾ�������ID</param>
        /// <returns></returns>
        public bool Delete(int M_ID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("delete from Manager where M_ID=");
            sql.Append(M_ID);
            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// ���ݹ���Ա���޸Ĺ���Ա����
        /// </summary>
        /// <param name="model">Ҫ�޸ĵ�ʵ��</param>
        /// <returns></returns>
        public bool Update(Model.Manager model)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("Update Manager set ");
            sql.Append("M_Password='" + model.Password + "'");
            sql.Append(" where M_AdminName='"+ model.AdminName +"'");

            int i = Convert.ToInt32(DbHelperOledb.ExecuteSql(sql.ToString()));
            if (i > 0)
                return true;
            else
                return false;
        }
    }

}
