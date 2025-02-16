using System;
using System.IO;
using System.Web;
using System.Web.Security;
using DBUtility;

namespace Helper;

public class CommonFunction
{
	public string ReplaceStr(string SQLstr)
	{
		if (SQLstr == null || SQLstr == "")
		{
			return "";
		}
		SQLstr = SQLstr.Replace("'", "");
		return SQLstr;
	}

	public static string ReplaceStr2(string SQLstr)
	{
		if (SQLstr == null || SQLstr == "")
		{
			return "";
		}
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

	public string CharConvert(string str)
	{
		str = str.Replace(">", "&gt;");
		str = str.Replace("<", "&lt;");
		str = str.Replace(' '.ToString(), "&nbsp;");
		str = str.Replace('"'.ToString(), "&quot;");
		str = str.Replace('\''.ToString(), "'");
		str = str.Replace('\r'.ToString(), "");
		str = str.Replace('\n'.ToString(), "<br />");
		return str;
	}

	public string CharReConvert2(string str)
	{
		str = str.Replace("&gt;", ">");
		str = str.Replace("&lt;", "<");
		str = str.Replace("&nbsp;", ' '.ToString());
		str = str.Replace("&quot;", '"'.ToString());
		str = str.Replace("'", '\''.ToString());
		str = str.Replace("<br />", '\n'.ToString());
		return str;
	}

	public static bool DelFile(string _FileURL)
	{
		if (File.Exists(_FileURL))
		{
			try
			{
				File.Delete(_FileURL);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}

	public static string DateTimeRandomFileName()
	{
		string DT = DateTime.Now.ToString();
		DT = DT.Replace("-", "").Replace(" ", "").Replace(":", "");
		Random Ro = new Random();
		return DT + Ro.Next(1000000, 9999999);
	}

	public bool CheckFieldIfRepeat(string _Field, string _TableField, string _ColumnField)
	{
		string SQLstr_CheckNameIfRepeat = "SELECT COUNT(*) FROM [" + _TableField + "] WHERE [" + _ColumnField + "]='" + _Field + "'";
		int num = DataAccess.ExecuteCmd(SQLstr_CheckNameIfRepeat);
		if (num > 0)
		{
			return false;
		}
		return true;
	}

	public static string GetMD5string(string _str)
	{
		return FormsAuthentication.HashPasswordForStoringInConfigFile(_str, "MD5");
	}

	public string GetNextLetter(string _Letter)
	{
		string AlphabetStr = "@ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		int LetterIndex = AlphabetStr.IndexOf(_Letter);
		return AlphabetStr.Substring(LetterIndex + 1, 1);
	}

	public int GetLetterIndex(string _Letter)
	{
		string AlphabetStr = "@ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		return AlphabetStr.IndexOf(_Letter);
	}

	public string SubStr(string _Str, int num, string _DotStr)
	{
		if (_Str.Length > num)
		{
			_Str = _Str.Substring(0, num) + _DotStr;
			return _Str;
		}
		return _Str;
	}

	public static string getleft(string scatitle, int cid)
	{
		string rtn = "";
		if (scatitle.Trim().Length > cid)
		{
			return scatitle.Substring(0, cid) + "...";
		}
		return scatitle;
	}

	public static void IsAdmin()
	{
		if (HttpContext.Current.Session["Admin"] == null)
		{
			HttpContext.Current.Response.Write("<script type=\"text/javascript\">alert('超時...');top.window.location.href='/adminaspx/Default.aspx'</script>");
			HttpContext.Current.Response.End();
		}
	}
}
