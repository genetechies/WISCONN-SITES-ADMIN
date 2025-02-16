using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class Houguan_IT_translation_index : System.Web.UI.Page
{
    protected DataTable dtClass;
    protected DataTable TranerTable;
    protected DataTable ServiceTable;
    protected void Page_Load(object sender, EventArgs e)
    {
        dtClass = new DAL.NewsClass().GetList_top(6, " ParentID=1 ").Tables[0];
        TranerTable = new TransTeam().GetList("").Tables[0];
        ServiceTable = new guopic().GetList("").Tables[0];
    }
}