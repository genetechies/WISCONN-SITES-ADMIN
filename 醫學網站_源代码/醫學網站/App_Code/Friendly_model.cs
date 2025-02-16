using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Firendly_model
/// </summary>
public class Friendly_model
{
    public Friendly_model()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    private int _f_id;
    private string _f_name;
    private string _f_url;
    private int _f_location;
    private string _f_author;
    private DateTime _f_option;
    private int _f_sortkey;

    public int F_Id
    {
        set { _f_id = value; }
        get { return _f_id; }
    }
    public string F_Name
    {
        set { _f_name = value; }
        get { return _f_name; }
    }
    public string F_Url
    {
        set { _f_url = value; }
        get { return _f_url; }
    }

    public int F_Location
    {
        set { _f_location = value; }
        get { return _f_location; }
    }
    public string F_Author
    {
        set { _f_author = value; }
        get { return _f_author; }
    }
    public DateTime F_Option
    {
        set { _f_option = value; }
        get { return _f_option; }
    }
    public int F_SortKey
    {
        set { _f_sortkey = value; }
        get { return _f_sortkey; }
    }
}
