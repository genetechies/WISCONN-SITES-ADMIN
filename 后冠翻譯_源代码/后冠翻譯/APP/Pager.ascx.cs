using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class APP_Pager : System.Web.UI.UserControl
{
    public int RecordCount { get; set; }

    public int PageSize { get; set; }

    public int PageCount { get; private set; }

    public int CurPage { get; set; }
    
    public EventHandler PageChanged { get; set; }

    protected void Page_Load(object sender, EventArgs e)
    {
        PageCount = RecordCount / PageSize;
        if (RecordCount % PageSize != 0)
            PageCount++;

        var list = new List<PageButton>();
        for (int i = 0; i < PageCount; i++)
        {
            var PageButton = new PageButton()
            {
                ID = i.ToString(),
                Text = (i + 1).ToString(),
                Style = i == CurPage ? "active" : ""
            };
            list.Add(PageButton);
        }

        rep.DataSource = list;
        rep.DataBind();
    }

    public void LinkButton_Click(object sender, EventArgs e)
    {
        CurPage = Int32.Parse((sender as LinkButton).ToolTip);
        if (PageChanged != null)
            PageChanged.Invoke(sender, e);
        
        var list = new List<PageButton>();
        for (int i = 0; i < PageCount; i++)
        {
            var PageButton = new PageButton()
            {
                ID = i.ToString(),
                Text = (i + 1).ToString(),
                Style = i == CurPage ? "active" : ""
            };
            list.Add(PageButton);
        }

        rep.DataSource = list;
        rep.DataBind();
    }

    public class PageButton
    {
        public string Text { get; set; }

        public string ID { get; set; }

        public string Style { get; set; }
    }
}
