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
using Helper;
using DBUtility;
using FredCK.FCKeditorV2;

namespace Web.Admin.News {
    public partial class Edit : System.Web.UI.Page {
        BLL.newsdata bll = new BLL.newsdata();

        protected void Page_Load(object sender, EventArgs e)
        {
            Model.newsdata model = new Model.newsdata();

            int SwID = Convert.ToInt32(Request.QueryString["SwId"]);
            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);
            model = bll.GetModel(Convert.ToInt32(Request.QueryString["P_id"]), web);
            if (!IsPostBack)
            {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Update))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }


                this.cbxWeb.DataSource = new CbxSubweb().CbxTableAuthority();
                this.cbxWeb.DataTextField = "SWName";//绑定的字段名  
                this.cbxWeb.DataValueField = "SWID";//绑定的值
                this.cbxWeb.DataBind();

                cbxWeb.SelectedValue = SwID.ToString();
                cbxWeb.Enabled = false;
                BindClass();

                txtTitle.Text = model.D_Title;
                ddlCategory.SelectedValue = model.D_ClassID.ToString();
                txtAuthor.Text = model.D_Editor;
                txtKeyword.Text = model.D_Keyword;
                txtDescription.Text = model.D_Description;
                //CKEditor1.Text = model.D_Content;
                txtEditorContents.Text = model.D_Content;
                tb_AddTime.Text = model.D_Time.ToString("yyyy-MM-dd");
            }
        }

        private void BindClass()
        {
            BLL.NewsClass bll = new BLL.NewsClass();
            ArrayList list = new ArrayList();
            ddlCategory.Items.Clear();
            int selectCount = 0;
            if (this.cbxWeb.SelectedItem != null)
            {
                if (!(this.cbxWeb.Items[0].Selected && cbxWeb.Items[0].Value == "0")) //no all website
                {
                    for (int i = 0; i < this.cbxWeb.Items.Count; i++)
                    {
                        if (this.cbxWeb.Items[i].Selected)
                        {
                            DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
                            for (int j = 0; j < dv.Count; j++)
                            {
                                if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["ClassName"].ToString())))
                                {
                                    ListItem item = new ListItem();
                                    item.Text = dv[j]["ClassName"].ToString();
                                    item.Value = dv[j]["ClassID"].ToString();
                                    this.ddlCategory.Items.Add(item);
                                }
                                else
                                {
                                    if (!list.Contains(new ListItem(dv[j]["ClassName"].ToString(), "")))
                                    {
                                        for (int k = 0; k < 2; k++)
                                        {
                                            ListItem item = new ListItem();
                                            item.Text = dv[j]["ClassName"].ToString();
                                            item.Value = dv[j]["ClassID"].ToString();
                                            list.Add(item);
                                        }
                                    }
                                    else
                                    {
                                        ListItem item = new ListItem();
                                        item.Text = dv[j]["ClassName"].ToString();
                                        item.Value = dv[j]["ClassID"].ToString();
                                        list.Add(item);
                                    }
                                }
                            }
                            selectCount++;
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < this.cbxWeb.Items.Count; i++)
                    {

                        DataView dv = bll.GetList("", new BLL.SubWeb().GetModel(Convert.ToInt32(this.cbxWeb.Items[i].Value))).Tables[0].DefaultView;
                        for (int j = 0; j < dv.Count; j++)
                        {
                            if (!this.ddlCategory.Items.Contains(new ListItem(dv[j]["ClassName"].ToString())))
                            {
                                ListItem item = new ListItem();
                                item.Text = dv[j]["ClassName"].ToString();
                                item.Value = dv[j]["ClassID"].ToString();
                                this.ddlCategory.Items.Add(item);
                            }
                            else
                            {
                                if (!list.Contains(new ListItem(dv[j]["ClassName"].ToString())))
                                {
                                    for (int k = 0; k < 2; k++)
                                    {
                                        ListItem item = new ListItem();
                                        item.Text = dv[j]["ClassName"].ToString();
                                        item.Value = dv[j]["ClassID"].ToString();
                                        list.Add(item);
                                    }
                                }
                                else
                                {
                                    ListItem item = new ListItem();
                                    item.Text = dv[j]["ClassName"].ToString();
                                    item.Value = dv[j]["ClassID"].ToString();
                                    list.Add(item);
                                }
                            }
                        }

                    }
                }
            }
            //计算重复
            if (selectCount == 0)
            {
                int listCount = 1;
                this.ddlCategory.Items.Clear();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].ToString() == list[j].ToString())
                        {
                            listCount++;
                        }
                    }
                    if (listCount == cbxWeb.Items.Count - 1)
                    {
                        this.ddlCategory.Items.Add(list[i] as ListItem);
                    }
                    listCount = 1;
                }
            }
            else if (selectCount > 1)
            {
                int listCount = 1;
                this.ddlCategory.Items.Clear();
                for (int i = 0; i < list.Count - 1; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {
                        if (list[i].ToString() == list[j].ToString())
                        {
                            listCount++;
                        }
                    }
                    if (listCount == selectCount)
                    {
                        this.ddlCategory.Items.Add(list[i] as ListItem);
                    }
                    listCount = 1;
                }
            }

            //add kong
            ddlCategory.Items.Insert(0, new ListItem("", ""));

        }
        protected void Sub_Click(object sender, EventArgs e) {
            Helper.CommonFunction.IsAdmin();

            int SwID = Convert.ToInt32(Request.QueryString["SwId"]);
            Model.SubWeb web = new BLL.SubWeb().GetModel(SwID);


            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Update)) {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Model.newsdata model = new Model.newsdata();
            model.D_ID = Convert.ToInt32(Request.QueryString["P_id"]);
            model.D_Title = txtTitle.Text;
            model.D_ClassID = Convert.ToInt32(ddlCategory.SelectedValue);
            model.D_Editor = txtAuthor.Text.Trim();
            model.D_Keyword = txtKeyword.Text;
            model.D_Description = txtDescription.Text;
            //model.D_Content = CKEditor1.Text;
            model.D_Content = txtEditorContents.Text;
            try
            {
                model.D_Time = Convert.ToDateTime(tb_AddTime.Text);
            }
            catch
            {
                model.D_Time = DateTime.Now;
            }
            bll.Update(model,web);
            Response.Redirect("NewsManage.aspx");
        }

        protected void btnInAricle_Click(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string strKey = txtKeyword.Text.Trim().ToString().Replace("，", ",");
            string strContent = "";
            //if (this.CKEditor1.Text.IndexOf("<hr />") != -1)
            //{
            //    strContent = this.CKEditor1.Text.Substring(0, this.CKEditor1.Text.IndexOf("<hr />"));
            //}
            //else
            //{
            //    strContent = this.CKEditor1.Text;
            //}
            if (this.txtEditorContents.Text.IndexOf("<hr />") != -1)
            {
                strContent = this.txtEditorContents.Text.Substring(0, this.txtEditorContents.Text.IndexOf("<hr />"));
            }
            else
            {
                strContent = this.txtEditorContents.Text;
            }
            string fristContent = "";
            string lastContent = "";
            string centerContent = "";
            if (strKey != "")
            {
                if (strKey.Contains(","))
                {
                    string[] keys = strKey.Split(',');
                    for (int i = 0; i < keys.Length; i++)
                    {
                        if (keys[i] != "")
                        {
                            string fristbrContent = strContent.Substring(0, strContent.IndexOf("<br />"));
                            if (fristbrContent.IndexOf(keys[i]) != -1)
                                fristContent = fristbrContent.Substring(0, fristbrContent.IndexOf(keys[i]) + keys[i].Length).Replace(keys[i], "<a href='http://translation.crowns.com.tw/'>" + keys[i] + "</a>") + fristbrContent.Substring(fristbrContent.IndexOf(keys[i]) + keys[i].Length);
                            else
                                fristContent = fristbrContent;
                            if (strContent.LastIndexOf("<br />") != strContent.IndexOf("<br />"))
                            {
                                string centerbrContent = strContent.Substring(strContent.IndexOf("<br />"), strContent.LastIndexOf("<br />") - strContent.IndexOf("<br />"));
                                if (centerbrContent.IndexOf(keys[i]) != -1)
                                    centerContent = centerbrContent.Substring(0, centerbrContent.IndexOf(keys[i]) + keys[i].Length).Replace(keys[i], "<a href='http://translation.crowns.com.tw/'>" + keys[i] + "</a>") + centerbrContent.Substring(centerbrContent.IndexOf(keys[i]) + keys[i].Length);
                                else
                                    centerContent = centerbrContent;
                            }

                            string lastbrContent = strContent.Substring(strContent.LastIndexOf("<br />"));
                            if (lastbrContent.IndexOf(keys[i]) != -1)
                                lastContent = lastbrContent.Substring(0, lastbrContent.IndexOf(keys[i]) + keys[i].Length).Replace(keys[i], "<a href='http://translation.crowns.com.tw/'>" + keys[i] + "</a>") + lastbrContent.Substring(lastbrContent.IndexOf(keys[i]) + keys[i].Length);
                            else
                                lastContent = lastbrContent;

                            strContent = strContent.Replace(strContent.Substring(0, strContent.IndexOf("<br />")), fristContent);
                            if (strContent.LastIndexOf("<br />") != strContent.IndexOf("<br />"))
                            {
                                strContent = strContent.Replace(strContent.Substring(strContent.IndexOf("<br />"), strContent.LastIndexOf("<br />") - strContent.IndexOf("<br />")), centerContent);
                            }
                            strContent = strContent.Replace(strContent.Substring(strContent.LastIndexOf("<br />")), lastContent);
                        }
                    }
                }
                else
                {
                    if (strKey != "")
                    {
                        string fristbrContent = strContent;
                        if (strContent.IndexOf("<br />") > -1) fristbrContent = fristbrContent.Substring(0, strContent.IndexOf("<br />"));
                        if (fristbrContent.IndexOf(strKey) != -1)
                            fristContent = fristbrContent.Substring(0, fristbrContent.IndexOf(strKey) + strKey.Length).Replace(strKey, "<a href='http://translation.crowns.com.tw/'>" + strKey + "</a>") + fristbrContent.Substring(fristbrContent.IndexOf(strKey) + strKey.Length);
                        else
                            fristContent = fristbrContent;

                        if (strContent.LastIndexOf("<br />") != strContent.IndexOf("<br />"))
                        {
                            string centerbrContent = strContent.Substring(strContent.IndexOf("<br />"), strContent.LastIndexOf("<br />") - strContent.IndexOf("<br />"));
                            if (centerbrContent.IndexOf(strKey) != -1)
                                centerContent = centerbrContent.Substring(0, centerbrContent.IndexOf(strKey) + strKey.Length).Replace(strKey, "<a href='http://translation.crowns.com.tw/'>" + strKey + "</a>") + centerbrContent.Substring(centerbrContent.IndexOf(strKey) + strKey.Length);
                            else
                                centerContent = centerbrContent;
                        }
                        string lastbrContent = strContent;
                        if (lastbrContent.Contains("<br />")) lastbrContent = lastbrContent.Substring(strContent.LastIndexOf("<br />"));
                        if (lastbrContent.IndexOf(strKey) != -1)
                            lastContent = lastbrContent.Substring(0, lastbrContent.IndexOf(strKey) + strKey.Length).Replace(strKey, "<a href='http://translation.crowns.com.tw/'>" + strKey + "</a>") + lastbrContent.Substring(lastbrContent.IndexOf(strKey) + strKey.Length);
                        else
                            lastContent = lastbrContent;

                        strContent = (strContent.Contains("<br />") ? strContent.Replace(strContent.Substring(0, strContent.IndexOf("<br />")), fristContent) : fristbrContent);
                        if (strContent.LastIndexOf("<br />") != strContent.IndexOf("<br />"))
                        {
                            strContent = strContent.Replace(strContent.Substring(strContent.IndexOf("<br />"), strContent.LastIndexOf("<br />") - strContent.IndexOf("<br />")), centerContent);
                        }

                        strContent = strContent.Replace((strContent.Contains("<br />") ? strContent.Substring(strContent.LastIndexOf("<br />")) : strContent), lastContent);
                    }
                }
            }
            //if (this.CKEditor1.Text.IndexOf("<hr />") != -1)
            //{
            //    strContent += CKEditor1.Text.Substring(CKEditor1.Text.IndexOf("<hr />"));
            //}
            //CKEditor1.Text = strContent;
            if (this.txtEditorContents.Text.IndexOf("<hr />") != -1)
            {
                strContent += txtEditorContents.Text.Substring(txtEditorContents.Text.IndexOf("<hr />"));
            }
            txtEditorContents.Text = strContent;
        }
        protected void btnCloseAricle_Click(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }
            string strContent = "";
            //if (this.CKEditor1.Text.IndexOf("<hr />") != -1)
            //{
            //    strContent = this.CKEditor1.Text.Substring(0, this.CKEditor1.Text.IndexOf("<hr />"));
            //}
            //else
            //{
            //    strContent = this.CKEditor1.Text;
            //}
            if (this.txtEditorContents.Text.IndexOf("<hr />") != -1)
            {
                strContent = this.txtEditorContents.Text.Substring(0, this.txtEditorContents.Text.IndexOf("<hr />"));
            }
            else
            {
                strContent = this.txtEditorContents.Text;
            }
            string strKey = txtKeyword.Text.Trim().ToString().Replace("，", ",");
            DataTable table = null;
            string lastKeys = "";
            string StrWhere = "";
            if (strKey != "")
            {
                if (strKey.Contains(","))
                {
                    string[] keys = strKey.Split(',');
                    for (int i = 0; i < keys.Length; i++)
                    {
                        lastKeys += keys[i] + ",";
                    }
                    if (lastKeys.LastIndexOf(",") != -1)
                        lastKeys = lastKeys.Substring(0, lastKeys.LastIndexOf(",")).ToString();


                    string[] keywords = lastKeys.Split(',');
                    StrWhere = "(";
                    for (int i = 0; i < keywords.Length; i++)
                    {
                        StrWhere += " D_Title like '%" + keywords[i] + "%' or";
                    }
                    StrWhere = StrWhere.Substring(0, StrWhere.LastIndexOf("or")).ToString() + ")";
                    string title = (!String.IsNullOrEmpty(this.txtTitle.Text) ? "" : txtTitle.Text.Trim().ToString().Replace("'", ""));
                    table = bll.GetTop5CloseNews(StrWhere, title);
                    strContent += "<hr /> <br />  ※ 后冠翻譯社推薦相關文章閱讀： <br />";
                    for (int i = 0; i < 5 && i < table.Rows.Count; i++)
                    {
                        strContent += "<a href='http://translation.crowns.com.tw/translation/newlist-" + table.Rows[i]["D_Id"].ToString() + ".aspx'>" + table.Rows[i]["D_Title"].ToString() + "</a> <br />";
                    }
                }
                else
                {
                    StrWhere = " D_Title like '%" + strKey + "%'";
                    string title = (!String.IsNullOrEmpty(this.txtTitle.Text) ? "" : txtTitle.Text.Trim().ToString().Replace("'", ""));
                    table = bll.GetTop5CloseNews(StrWhere, title);
                    strContent += "<hr /> <br /> ※ 后冠翻譯社推薦相關文章閱讀： <br />";
                    for (int i = 0; i < 5 && table != null && i < table.Rows.Count; i++)
                    {
                        strContent += "<a href='http://translation.crowns.com.tw/translation/newlist-" + table.Rows[i]["D_Id"].ToString() + ".aspx'>" + table.Rows[i]["D_Title"].ToString() + "</a> <br />";
                    }
                }
            }
            if (strContent.EndsWith("<br />"))
            {
                strContent = strContent.Substring(0, strContent.LastIndexOf("<br />")).ToString();
            }
            //CKEditor1.Text = strContent;
            txtEditorContents.Text = strContent;
        }

        protected void cbxWeb_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindClass();
        }
}
}