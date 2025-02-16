using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZeroStudio.Model;


public partial class ProClass : System.Web.UI.UserControl
{
    ZeroStudio.BLL.ProductClass bclass = new ZeroStudio.BLL.ProductClass();
    ZeroStudio.BLL.Product bll = new ZeroStudio.BLL.Product();

    protected List<ProductClass> proClassList = new List<ProductClass>();

    protected void Page_Load(object sender, EventArgs e)
    {

        proClassList = bclass.GetModelList("");
    }
}
