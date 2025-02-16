using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class link : System.Web.UI.Page
{
    protected DataTable dtClass;
    protected void Page_Load(object sender, EventArgs e)
    {
        Friendly_bll bll = new Friendly_bll();
        dtClass =  bll.GetList(" F_location in (1,3,4,6)").Tables[0];
    }
}