using System;
using System.Configuration;

namespace ZeroStudio.DBUtility
{
    public class PubConstant
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationSettings.AppSettings["ConnectionString"];
            }
        }
    }
}
