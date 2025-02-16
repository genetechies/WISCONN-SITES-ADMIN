using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using ZeroStudio.Model;

namespace ZeroStudio.Web
{
    public partial class Portfolio_en : System.Web.UI.Page
    {
        private BLL.NewsClass bclass = new ZeroStudio.BLL.NewsClass();
        private BLL.News bll = new ZeroStudio.BLL.News();

        ZeroStudio.BLL.ProductClass pbclass = new ZeroStudio.BLL.ProductClass(true);
        ZeroStudio.BLL.Product pbll = new ZeroStudio.BLL.Product();

        protected List<ProductClass> proClassList = new List<ProductClass>();

        protected string keywords = "connector supplier, FPC connector";
        protected string description = "The experience accumulated by WISCONN(connector supplier,connector manufacturer) is summarized in articles to share with you. It doesn’t only include the FPC connector products mentioned above, but also provide a platform for other connectors worldwide.";
        protected string title = "";
        protected Model.NewsClass classInfo;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataView dv = bclass.GetAll().Tables[0].DefaultView;

                newsClassList.DataSource = dv;
                newsClassList.DataBind();

                Repeater1.DataSource = dv;
                Repeater1.DataBind();

                proClassList = pbclass.GetModelList("");

                if (!string.IsNullOrEmpty(Request.QueryString["ClassID"]))
                {
                     classInfo = bclass.GetModel(Convert.ToInt32(Request.QueryString["ClassID"]));
                    if (classInfo != null)
                    {
                        keywords = classInfo.Keywords;
                        description = classInfo.Description;
                        title = classInfo.ClassName;

                        ltArtListTitle.Text = classInfo.ArtListTitle;
                        ltArtListDescription.Text = classInfo.ArtListDescription;
                    }
                    //for (int i = 0; i < newsClassList.Items.Count; i++)
                    //{
                    //    Label lblId = newsClassList.Items[i].FindControl("lblId") as Label;
                    //    HyperLink classhref = newsClassList.Items[i].FindControl("classhref") as HyperLink;
                    //    if (lblId != null && lblId.Text.Trim() == Request.QueryString["ClassID"])
                    //    {
                    //        if (classhref != null)
                    //        {
                    //            classhref.Attributes.Add("style", "text-decoration:underline");
                    //        }
                    //    }
                    //    if (classhref != null)
                    //    {
                    //        classhref.NavigateUrl = "Portfolio.aspx?ClassID=" + lblId.Text;
                    //    }
                    //}

                    //for (int i = 0; i < Repeater1.Items.Count; i++)
                    //{
                    //    Label lblId = Repeater1.Items[i].FindControl("lblId") as Label;
                    //    HyperLink classhref = Repeater1.Items[i].FindControl("classhref") as HyperLink;
                    //    if (lblId != null && lblId.Text.Trim() == Request.QueryString["ClassID"])
                    //    {
                    //        if (classhref != null)
                    //        {
                    //            classhref.Attributes.Add("style", "text-decoration:underline");
                    //        }
                    //    }
                    //    if (classhref != null)
                    //    {
                    //        classhref.NavigateUrl = "Portfolio.aspx?ClassID=" + lblId.Text;
                    //    }
                    //}
                    AspNetPager1.RecordCount = bll.Count("N_State=1 and N_ClassID=" + Request.QueryString["ClassID"]);
                }
                else
                {
                    //for (int i = 0; i < newsClassList.Items.Count; i++)
                    //{
                    //    Label lblId = newsClassList.Items[i].FindControl("lblId") as Label;
                    //    HyperLink classhref = newsClassList.Items[i].FindControl("classhref") as HyperLink;
                    //    if (classhref != null)
                    //    {
                    //        classhref.NavigateUrl = "Portfolio.aspx?ClassID=" + lblId.Text;
                    //    }
                    //}

                    //for (int i = 0; i < Repeater1.Items.Count; i++)
                    //{
                    //    Label lblId = Repeater1.Items[i].FindControl("lblId") as Label;
                    //    HyperLink classhref = Repeater1.Items[i].FindControl("classhref") as HyperLink;
                    //    if (classhref != null)
                    //    {
                    //        classhref.NavigateUrl = "Portfolio.aspx?ClassID=" + lblId.Text;
                    //    }
                    //}
                    AspNetPager1.RecordCount = bll.Count("N_State=1");

                }
                Bind();

            }
        }
        protected void Bind()
        {
            PagedDataSource pds = new PagedDataSource();
            pds.AllowPaging = true;
            pds.PageSize = AspNetPager1.PageSize;
            pds.CurrentPageIndex = AspNetPager1.CurrentPageIndex - 1;
            if (string.IsNullOrEmpty(Request.QueryString["ClassID"]))
            {
                pds.DataSource = bll.GetList("N_State=1", "N_DateTime desc,N_Id").Tables[0].DefaultView;
            }
            else
            {
                pds.DataSource = bll.GetList("N_State=1 and N_ClassID=" + Request.QueryString["ClassID"], "N_DateTime desc,N_Id").Tables[0].DefaultView;
            }
            newsList.DataSource = pds;
            newsList.DataBind();
        }
        protected void AspNetPager1_PageChanged(object sender, EventArgs e)
        {
            Bind();
        }
    }
}
