using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Helper;

public class MessageBox
{
	public static void Show(Page page, string msg)
	{
		page.RegisterStartupScript("message", "<script language='javascript' defer>alert('" + msg.ToString() + "');</script>");
	}

	public static void ShowConfirm(WebControl Control, string msg)
	{
		Control.Attributes.Add("onclick", "return confirm('" + msg + "');");
	}

	public static void ShowAndRedirect(Page page, string msg, string url)
	{
		StringBuilder Builder = new StringBuilder();
		Builder.Append("<script language='javascript' defer>");
		Builder.AppendFormat("alert('{0}');", msg);
		Builder.AppendFormat("top.location.href='{0}'", url);
		Builder.Append("</script>");
		page.RegisterStartupScript("message", Builder.ToString());
	}

	public static void ResponseScript(Page page, string script)
	{
		page.RegisterStartupScript("message", "<script language='javascript' defer>" + script + "</script>");
	}
}
