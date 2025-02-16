using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DBUtility
{
    public class PubConstant
    {
        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
                //string _connectionString = ConfigurationManager.ConnectionStrings["ConnStr"].ToString();
                return _connectionString;
            }
        }

         //<summary>
         //得到web.config里配置项的数据库连接字符串。
         //</summary>
         //<param name="configName"></param>
         //<returns></returns>
        public static string GetConnectionString(string configName)
        {
            string connectionString = ConfigurationManager.AppSettings[configName];
            return connectionString;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sw"></param>
        /// <returns></returns>
        public string GetString(Model.SubWeb sw)
        { 
        return "server="+sw.SWDBService+";database="+sw.SWDBName+";uid="+sw.SWDBUser+";pwd="+sw.SWDBUserPwd+ ";Connection Timeout=2";
        }

    }
}
