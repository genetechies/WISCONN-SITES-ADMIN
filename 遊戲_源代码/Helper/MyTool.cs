using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Helper
{
    public class MyTool
    {
        #region 正则验证
        /// <summary>
        /// 验证是否为电话号码
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidTel(string strIn)
        {
            return Regex.IsMatch(strIn, @"(\d+-)?(\d{4}-?\d{7}|\d{3}-?\d{8}|^\d{7,8})(-\d+)?");
        }

        /// <summary>
        /// 验证是否为手机号码
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidMobile(string strIn)
        {
            return Regex.IsMatch(strIn, @"^1[3,8]\d{9}$");
        }

        /// <summary>
        /// 验证年月日
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>

        public static bool IsValidDate(string strIn)
        {
            return Regex.IsMatch(strIn, @"^(\d{4})(\/|-)(\d{1,2})\2(\d{1,2})$");
        }

        /// <summary>
        /// 验证时间格式带年月日
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>

        public static bool IsValidDateTime(string strIn)
        {
            return Regex.IsMatch(strIn, @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d$");
        }

        /// <summary>
        /// 验证后缀名 gif|jpg
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>

        public static bool IsValidPostfix(string strIn)
        {
            return Regex.IsMatch(strIn, @"\.(?i:gif|jpg)$");
        }

        /// <summary>
        /// 上传文件格式验证 doc|docx|txt|xls|jpg|jpeg|tiff|png|gif|pdf|zip|rar
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>

        public static bool CheckFileType(string strIn)
        {
            return Regex.IsMatch(strIn, @"\.(?i:doc|docx|txt|xls|jpg|jpeg|tiff|png|gif|pdf|zip|rar)$");
        }

        public static bool CheckUserName(string strIn)
        {
            if (strIn.IndexOf('*')>0)
            {
                return false;
            }
            else if (strIn.IndexOf('/') > 0)
            {
                return false;
            }
            else if (strIn.IndexOf('!') > 0)
            {
                return false;
            }
            else if (strIn.IndexOf('&') > 0)
            {
                return false;
            }
            else if (strIn.IndexOf('@') > 0)
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// 长度是否在 slength，llength  之间
        /// </summary>
        /// <param name="strIn"></param>
        /// <param name="slength"></param>
        /// <param name="llength"></param>
        /// <returns></returns>
        public static bool IsValidByte(string strIn, int slength, int llength)
        {
            return Regex.IsMatch(strIn, @"^[a-z]{" + slength.ToString() + "," + llength.ToString() + "}$");
        }

        /// <summary>
        /// 验证IP
        /// </summary>
        /// <param name="strIn"></param>
        /// <returns></returns>
        public static bool IsValidIp(string strIn)
        {
            return Regex.IsMatch(strIn, @"^(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])$");
        }

        /// <summary>
        /// 判断是否为有效Email地址
        /// </summary>
        /// <param name="inputEmail"></param>
        /// <returns></returns>
        public static bool isEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        /// <summary>
        /// 过滤字符(值留下 数字 字母 汉字)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string removeCode(string s)
        {
            if (s != null && s.Length > 0)
            {
                StringBuilder sb = new StringBuilder();
                char[] ol = s.ToCharArray();
                foreach (char c in ol)
                {
                    if (char.IsLetter(c) || char.IsNumber(c))
                        sb.Append(c);
                }
                return sb.ToString();
            }
            return "";
        }

        public static string ParseTags(string HTML)
        {
            return System.Text.RegularExpressions.Regex.Replace(HTML, "<[^>]*>", "");
        }

        public static void alertback(string mdg)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('" + mdg + "');history.go(-1);</script>");
            HttpContext.Current.Response.End();
        }
        public static void alert(string mdg)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('" + mdg + "')</script>");
        }
        public static void topalert(string mdg, string url)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('" + mdg + "');top.window.location.href='" + url + "'</script>");
            HttpContext.Current.Response.End();
        }
        public static void alert(string mdg, string url)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('" + mdg + "');window.location.href='" + url + "'</script>");
            HttpContext.Current.Response.End();
        }

        public static void alert_toparent(string mdg, string url)
        {
            HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('" + mdg + "');parent.opener.location.href='" + url + "';parent.close();</script>");
        }

        public static void ResponseEnd(string msg)
        {
            HttpContext.Current.Response.Write(msg);
            HttpContext.Current.Response.End();
        }

        public static bool IsNumeric(string str)   //验证是否是整数
        {
            if (str == null || str.Length == 0)
                return false;
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            byte[] bytestr = ascii.GetBytes(str);
            foreach (byte c in bytestr)
            {
                if (c < 48 || c > 57)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool IsDigital(string str)   //验证是否是数字
        {
            if (str == null || str.Length == 0)
                return false;
            string strRegex = @"^[0-9]\d*[.]?\d*$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 返回页码
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static int PageNum(string str)
        {
            if (IsNumeric(System.Web.HttpContext.Current.Request.QueryString[str]))
                return Convert.ToInt32(System.Web.HttpContext.Current.Request.QueryString[str]);
            else
                return 1;
        }

        public static string CutTitle(string str, int len)
        {
            int intLen = str.Length;
            int start = 0;
            int end = intLen;
            int single = 0;
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (Convert.ToInt32(chars[i]) > 255)
                    start += 2;
                else
                {
                    start += 1;
                    single++;
                }
                if (start >= len)
                {

                    if (end % 2 == 0)
                    {
                        if (single % 2 == 0)
                            end = i + 1;
                        else
                            end = i;
                    }
                    else
                        end = i + 1;
                    break;
                }
            }
            string temp = str.Substring(0, end);
            if (str.Length > end)
                return temp + "..";
            else
                return temp;
        }

        public static string StripHTML(string strHtml)  //去掉html格式
        {
            string[] aryReg = { @"<script[^>]*?>.*?</script>", @"<(\/\s*)?!?((\w+:)?\w+)(\w+(\s*=?\s*(([""'])(\\[""'tbnr]|[^\7])*?\7|\w+)|.{0})|\s)*?(\/\s*)?>", @"([\r\n])[\s]+", @"&(quot|#34);", @"&(amp|#38);", @"&(lt|#60);", @"&(gt|#62);", @"&(nbsp|#160);", @"&(iexcl|#161);", @"&(cent|#162);", @"&(pound|#163);", @"&(copy|#169);", @"&#(\d+);", @"<!--.*\n", @"-->" };
            //string [] aryRep = {"", "","","\"", "&", "<",">"," ","\xa1",//chr(161),"\xa2",//chr(162),"\xa3",//chr(163),"\xa9",//chr(169),"", "\r\n", "" }; 
            string[] aryRep = { "", "", "", "\"", "&", "<", ">", " ", "\xa1", "\xa2", "\xa3", "\xa9", "", "\r\n", "" };
            string newReg = aryReg[0];
            string strOutput = strHtml;
            for (int i = 0; i < aryReg.Length; i++)
            {
                Regex regex = new Regex(aryReg[i], RegexOptions.IgnoreCase);
                strOutput = regex.Replace(strOutput, aryRep[i]);
            }
            strOutput.Replace("<", "");
            strOutput.Replace(">", "");
            strOutput.Replace("\r\n", "");
            return strOutput;
        }

        public static string StripSpecialSymbol(string str){
            string[] arySymbol = { @"*", @"/", @"#", @"@", @"%", @" ", @"<", @">", @"\", @":", @"?", @"|" };
            string strout = str;
            for (int i = 0; i < arySymbol.Length; i++)
            {                
                strout = strout.Replace(arySymbol[i], "");
            }
            
            return strout;
        }
    }
}
