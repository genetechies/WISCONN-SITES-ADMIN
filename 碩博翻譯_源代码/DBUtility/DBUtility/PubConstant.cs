using System.Configuration;
using System.Web;

namespace DBUtility;

public class PubConstant
{
	public static string ConnectionString => "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + HttpContext.Current.Server.MapPath(ConfigurationManager.ConnectionStrings["ConnStr"].ToString());
}
