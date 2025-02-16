using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
using ZeroStudio.DBUtility;


namespace ZeroStudio.Helper
{
    /// <summary>
    /// Function 的摘要说明
    /// </summary>
    public class CommonFunction
    {
        public CommonFunction()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #region "'"字符过滤函数
        public string ReplaceStr(string SQLstr)
        {
            if (SQLstr == null || SQLstr == "")
            {
                return "";
            }
            else
            {
                SQLstr = SQLstr.Replace("'", "");
                return SQLstr;
            }
        }
        #endregion

        #region 字符串过滤函数
        public static string ReplaceStr2(string SQLstr)
        {
            if (SQLstr == null || SQLstr == "")
            {
                return "";
            }
            else
            {
                SQLstr = SQLstr.Replace(";", "");
                SQLstr = SQLstr.Replace("'", "");
                SQLstr = SQLstr.Replace("&", "");
                SQLstr = SQLstr.Replace("%20", "");
                SQLstr = SQLstr.Replace("--", "");
                SQLstr = SQLstr.Replace("==", "");
                SQLstr = SQLstr.Replace("<", "");
                SQLstr = SQLstr.Replace(">", "");
                SQLstr = SQLstr.Replace("%", "");
                SQLstr = SQLstr.Replace("+", "");
                SQLstr = SQLstr.Replace("-", "");
                SQLstr = SQLstr.Replace("=", "");
                SQLstr = SQLstr.Replace(",", "");
                return SQLstr;
            }

        }
        #endregion

        #region TextBox字符转换函数
        public string CharConvert(string str)
        {
            str = str.Replace(">", "&gt;");
            str = str.Replace("<", "&lt;");
            char ch;
            ch = (char)32;
            str = str.Replace(ch.ToString(), "&nbsp;");
            ch = (char)34;
            str = str.Replace(ch.ToString(), "&quot;");
            ch = (char)39;
            str = str.Replace(ch.ToString(), "'");
            ch = (char)13;
            str = str.Replace(ch.ToString(), "");
            ch = (char)10;
            str = str.Replace(ch.ToString(), "<br />");
            return str;
        }
        #endregion

        #region Textbox字符反转换函数
        public string CharReConvert2(string str)
        {
            str = str.Replace("&gt;", ">");
            str = str.Replace("&lt;", "<");
            char ch;
            ch = (char)32;
            str = str.Replace("&nbsp;", ch.ToString());
            ch = (char)34;
            str = str.Replace("&quot;", ch.ToString());
            ch = (char)39;
            str = str.Replace("'", ch.ToString());
            ch = (char)10;
            str = str.Replace("<br />", ch.ToString());
            return str;
        }
        #endregion

        #region 檔案删除函数
        public static bool DelFile(string _FileURL)
        {
            if (File.Exists(_FileURL))
            {
                try
                {
                    File.Delete(_FileURL);
                    return true;
                }
                catch (System.Exception e)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        #endregion

        #region 随机檔案名生成函数
        /// <summary>
        /// 由系统当前LongDateTime时间后面追加7位随即数字组成
        /// </summary>
        /// <returns></returns>
        public static string DateTimeRandomFileName()
        {
            string DT = DateTime.Now.ToString();
            DT = DT.Replace("-", "").Replace(" ", "").Replace(":", "");
            Random Ro = new Random();
            string str = DT + Ro.Next(1000000, 9999999);
            return str;
        }
        #endregion

        #region 判断字段是否重复函数
        public bool CheckFieldIfRepeat(string _Field, string _TableField, string _ColumnField)
        {
            string SQLstr_CheckNameIfRepeat = "SELECT COUNT(*) FROM [" + _TableField + "] WHERE [" + _ColumnField + "]='" + _Field + "'";
            int num = DataAccess.ExecuteCmd(SQLstr_CheckNameIfRepeat);
            if (num > 0)
            {
                //如果此用户名已存在则返回false
                return false;
            }
            else
            {
                //如果此用户名不存在则返回true
                return true;
            }
        }
        #endregion

        #region MD5转换函数
        public static string GetMD5string(string _str)
        {
            string str = FormsAuthentication.HashPasswordForStoringInConfigFile(_str, "MD5");
            return str;
        }
        #endregion


        #region 获得字母表下一個字母函数
        public string GetNextLetter(string _Letter)
        {
            string AlphabetStr = "@ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int LetterIndex = AlphabetStr.IndexOf(_Letter);
            string NextLetter = AlphabetStr.Substring(LetterIndex + 1, 1);
            return NextLetter;
        }
        #endregion

        #region 获得改大写字母索引函数
        public int GetLetterIndex(string _Letter)
        {
            string AlphabetStr = "@ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int Index = AlphabetStr.IndexOf(_Letter);
            return Index;
        }
        #endregion


        #region 字符串截断函数
        public string SubStr(string _Str, int num, string _DotStr)
        {
            if (_Str.Length > num)
            {
                _Str = _Str.Substring(0, num) + _DotStr;
                return _Str;
            }
            else
            {
                return _Str;
            }
        }
        #endregion

        #region 字符截断
        /// <summary>
        /// 字符截断
        /// </summary>
        /// <param name="scatitle"></param>
        /// <param name="cid"></param>
        /// <returns></returns>
        public static string getleft(string scatitle, int cid)
        {
            string rtn = "";
            if (scatitle.Trim().Length > cid)
            {
                rtn = scatitle.Substring(0, cid) + "...";
            }
            else
            {
                rtn = scatitle;
            }
            return rtn;
        }
        #endregion

        #region 判断是否登陆
        /// <summary>
        /// 判断管理员
        /// </summary>
        public static void IsAdmin()
        {
            //if (HttpContext.Current.Session["Admin"] == null)
            //{
            //    HttpContext.Current.Response.Redirect("~/admin/Default.aspx");
            //}
        }

        #endregion
    }
}