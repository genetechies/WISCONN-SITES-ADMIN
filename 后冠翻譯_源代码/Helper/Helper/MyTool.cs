using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace Helper;

public class MyTool
{
	public static bool IsValidTel(string strIn)
	{
		return Regex.IsMatch(strIn, "(\\d+-)?(\\d{4}-?\\d{7}|\\d{3}-?\\d{8}|^\\d{7,8})(-\\d+)?");
	}

	public static bool IsValidMobile(string strIn)
	{
		return Regex.IsMatch(strIn, "^1[3,8]\\d{9}$");
	}

	public static bool IsValidDate(string strIn)
	{
		return Regex.IsMatch(strIn, "^(\\d{4})(\\/|-)(\\d{1,2})\\2(\\d{1,2})$");
	}

	public static bool IsValidDateTime(string strIn)
	{
		return Regex.IsMatch(strIn, "^((((1[6-9]|[2-9]\\d)\\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\\d|3[01]))|(((1[6-9]|[2-9]\\d)\\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\\d|30))|(((1[6-9]|[2-9]\\d)\\d{2})-0?2-(0?[1-9]|1\\d|2[0-8]))|(((1[6-9]|[2-9]\\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\\d):[0-5]?\\d:[0-5]?\\d$");
	}

	public static bool IsValidPostfix(string strIn)
	{
		return Regex.IsMatch(strIn, "\\.(?i:gif|jpg)$");
	}

	public static bool IsValidByte(string strIn, int slength, int llength)
	{
		return Regex.IsMatch(strIn, "^[a-z]{" + slength + "," + llength + "}$");
	}

	public static bool IsValidIp(string strIn)
	{
		return Regex.IsMatch(strIn, "^(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])\\.(\\d{1,2}|1\\d\\d|2[0-4]\\d|25[0-5])$");
	}

	public static bool isEmail(string inputEmail)
	{
		string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$";
		Regex re = new Regex(strRegex);
		if (re.IsMatch(inputEmail))
		{
			return true;
		}
		return false;
	}

	public static string removeCode(string s)
	{
		if (s != null && s.Length > 0)
		{
			StringBuilder sb = new StringBuilder();
			char[] ol = s.ToCharArray();
			char[] array = ol;
			foreach (char c in array)
			{
				if (char.IsLetter(c) || char.IsNumber(c))
				{
					sb.Append(c);
				}
			}
			return sb.ToString();
		}
		return "";
	}

	public static string ParseTags(string HTML)
	{
		return Regex.Replace(HTML, "<[^>]*>", "");
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

	public static bool IsNumeric(string str)
	{
		if (str == null || str.Length == 0)
		{
			return false;
		}
		ASCIIEncoding ascii = new ASCIIEncoding();
		byte[] bytestr = ascii.GetBytes(str);
		byte[] array = bytestr;
		foreach (byte c in array)
		{
			if (c < 48 || c > 57)
			{
				return false;
			}
		}
		return true;
	}

	public static bool IsDigital(string str)
	{
		if (str == null || str.Length == 0)
		{
			return false;
		}
		string strRegex = "^[0-9]\\d*[.]?\\d*$";
		Regex re = new Regex(strRegex);
		if (re.IsMatch(str))
		{
			return true;
		}
		return false;
	}

	public static int PageNum(string str)
	{
		if (IsNumeric(HttpContext.Current.Request.QueryString[str]))
		{
			return Convert.ToInt32(HttpContext.Current.Request.QueryString[str]);
		}
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
			{
				start += 2;
			}
			else
			{
				start++;
				single++;
			}
			if (start >= len)
			{
				end = ((end % 2 != 0) ? (i + 1) : ((single % 2 != 0) ? i : (i + 1)));
				break;
			}
		}
		string temp = str.Substring(0, end);
		if (str.Length > end)
		{
			return temp + "..";
		}
		return temp;
	}

	public static string StripHTML(string strHtml)
	{
		string[] aryReg = new string[15]
		{
			"<script[^>]*?>.*?</script>", "<(\\/\\s*)?!?((\\w+:)?\\w+)(\\w+(\\s*=?\\s*(([\"'])(\\\\[\"'tbnr]|[^\\7])*?\\7|\\w+)|.{0})|\\s)*?(\\/\\s*)?>", "([\\r\\n])[\\s]+", "&(quot|#34);", "&(amp|#38);", "&(lt|#60);", "&(gt|#62);", "&(nbsp|#160);", "&(iexcl|#161);", "&(cent|#162);",
			"&(pound|#163);", "&(copy|#169);", "&#(\\d+);", "<!--.*\\n", "-->"
		};
		string[] aryRep = new string[15]
		{
			"", "", "", "\"", "&", "<", ">", " ", "¡", "¢",
			"£", "©", "", "\r\n", ""
		};
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
}
