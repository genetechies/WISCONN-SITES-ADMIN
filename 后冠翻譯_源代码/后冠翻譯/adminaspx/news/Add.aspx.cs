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



namespace Web.Admin.News
{
    public partial class Add : System.Web.UI.Page
    {
        BLL.newsdata bll = new BLL.newsdata();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Helper.CommonFunction.IsAdmin();
                if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Insert))
                {
                    //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');history.go(-1);", true);
                    //return;
                    MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
                }

                txtAuthor.Text = Session["Admin"].ToString();
                tb_AddTime.Text = DateTime.Now.ToString("yyyy-MM-dd");
                BindClass();
            }
        }



        private void BindClass()
        {
            BLL.NewsClass bll = new BLL.NewsClass();
            DataView dv = bll.GetList("").Tables[0].DefaultView;
            for (int i = 0; i < dv.Count; i++)
            {
                ddlCategory.Items.Add(new ListItem(dv[i]["ClassName"].ToString(), dv[i]["classid"].ToString()));
            }
        }
        protected void Sub_Click(object sender, EventArgs e)
        {
            Helper.CommonFunction.IsAdmin();
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Insert))
            {
                //ClientScript.RegisterStartupScript(GetType(), "noright", "alert('對不起,您無權限操作該項功能,請聯系系統管理員!');", true);
                //return;
                MyTool.alertback("對不起,您無權限操作該項功能,請聯系系統管理員!");
            }

            Model.newsdata model = new Model.newsdata();


            model.D_Title = txtTitle.Text;
            model.D_ClassID = Convert.ToInt32(ddlCategory.SelectedValue);
            try
            {
                model.D_Time = Convert.ToDateTime(tb_AddTime.Text);
            }
            catch
            {
                model.D_Time = DateTime.Now;
            }
            model.D_Editor = txtAuthor.Text.Trim();
            model.D_Keyword = txtKeyword.Text;
            model.D_Description = txtDescription.Text;
            //model.D_Content = FCKeditor1.Value;
            model.D_Content = txtEditorContents.Text;
            model.D_Recycle = 0;
            model.OrderID = 0;

            try
            {
                bll.Add(model);
                Response.Redirect("Manage.aspx");
            }
            catch (Exception ex)
            {
                string str = ex.Message;
                throw;
            }
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
            //if (this.FCKeditor1.Value.IndexOf("<hr />") != -1)
            //{
            //    strContent = this.FCKeditor1.Value.Substring(0, this.FCKeditor1.Value.IndexOf("<hr />"));
            //}
            //else
            //{
            //    strContent = this.FCKeditor1.Value;
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
                                fristContent = fristbrContent.Substring(0, fristbrContent.IndexOf(keys[i]) + keys[i].Length).Replace(keys[i], "<a href='http://www.houguan-translation-services.com/'>" + keys[i] + "</a>") + fristbrContent.Substring(fristbrContent.IndexOf(keys[i]) + keys[i].Length);
                            else
                                fristContent = fristbrContent;
                            if (strContent.LastIndexOf("<br />") != strContent.IndexOf("<br />"))
                            {
                                string centerbrContent = strContent.Substring(strContent.IndexOf("<br />"), strContent.LastIndexOf("<br />") - strContent.IndexOf("<br />"));
                                if (centerbrContent.IndexOf(keys[i]) != -1)
                                    centerContent = centerbrContent.Substring(0, centerbrContent.IndexOf(keys[i]) + keys[i].Length).Replace(keys[i], "<a href='http://www.houguan-translation-services.com/'>" + keys[i] + "</a>") + centerbrContent.Substring(centerbrContent.IndexOf(keys[i]) + keys[i].Length);
                                else
                                    centerContent = centerbrContent;
                            }

                            string lastbrContent = strContent.Substring(strContent.LastIndexOf("<br />"));
                            if (lastbrContent.IndexOf(keys[i]) != -1)
                                lastContent = lastbrContent.Substring(0, lastbrContent.IndexOf(keys[i]) + keys[i].Length).Replace(keys[i], "<a href='http://www.houguan-translation-services.com/'>" + keys[i] + "</a>") + lastbrContent.Substring(lastbrContent.IndexOf(keys[i]) + keys[i].Length);
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
                            fristContent = fristbrContent.Substring(0, fristbrContent.IndexOf(strKey) + strKey.Length).Replace(strKey, "<a href='http://www.houguan-translation-services.com/'>" + strKey + "</a>") + fristbrContent.Substring(fristbrContent.IndexOf(strKey) + strKey.Length);
                        else
                            fristContent = fristbrContent;

                        if (strContent.LastIndexOf("<br />") != strContent.IndexOf("<br />"))
                        {
                            string centerbrContent = strContent.Substring(strContent.IndexOf("<br />"), strContent.LastIndexOf("<br />") - strContent.IndexOf("<br />"));
                            if (centerbrContent.IndexOf(strKey) != -1)
                                centerContent = centerbrContent.Substring(0, centerbrContent.IndexOf(strKey) + strKey.Length).Replace(strKey, "<a href='http://www.houguan-translation-services.com/'>" + strKey + "</a>") + centerbrContent.Substring(centerbrContent.IndexOf(strKey) + strKey.Length);
                            else
                                centerContent = centerbrContent;
                        }
                        string lastbrContent = strContent;
                        if (lastbrContent.Contains("<br />")) lastbrContent = lastbrContent.Substring(strContent.LastIndexOf("<br />"));
                        if (lastbrContent.IndexOf(strKey) != -1)
                            lastContent = lastbrContent.Substring(0, lastbrContent.IndexOf(strKey) + strKey.Length).Replace(strKey, "<a href='http://www.houguan-translation-services.com/'>" + strKey + "</a>") + lastbrContent.Substring(lastbrContent.IndexOf(strKey) + strKey.Length);
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
            //if (this.FCKeditor1.Value.IndexOf("<hr />") != -1)
            //{
            //    strContent += FCKeditor1.Value.Substring(FCKeditor1.Value.IndexOf("<hr />"));
            //}
            //FCKeditor1.Value = strContent;
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
            //if (this.FCKeditor1.Value.IndexOf("<hr />") != -1)
            //{
            //    strContent = this.FCKeditor1.Value.Substring(0, this.FCKeditor1.Value.IndexOf("<hr />"));
            //}
            //else
            //{
            //    strContent = this.FCKeditor1.Value;
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
                    strContent += "<hr /> <br />  ※ 后冠翻譯公司推薦相關文章閱讀： <br />";
                    for (int i = 0; i < 5 && i < table.Rows.Count; i++)
                    {
                        strContent += "<a href='http://www.houguan-translation-services.com/translation/newsinfo-" + table.Rows[i]["D_Id"].ToString() + ".aspx'>" + table.Rows[i]["D_Title"].ToString() + "</a> <br />";
                    }
                }
                else
                {
                    StrWhere = " D_Title like '%" + strKey + "%'";
                    string title = (!String.IsNullOrEmpty(this.txtTitle.Text) ? "" : txtTitle.Text.Trim().ToString().Replace("'", ""));
                    table = bll.GetTop5CloseNews(StrWhere, title);
                    strContent += "<hr /> <br /> ※ 后冠翻譯公司推薦相關文章閱讀： <br />";
                    for (int i = 0; i < 5 && table != null && i < table.Rows.Count; i++)
                    {
                        strContent += "<a href='http://www.houguan-translation-services.com/translation/newsinfo-" + table.Rows[i]["D_Id"].ToString() + ".aspx'>" + table.Rows[i]["D_Title"].ToString() + "</a> <br />";
                    }
                }
            }
            if (strContent.EndsWith("<br />"))
            {
                strContent = strContent.Substring(0, strContent.LastIndexOf("<br />")).ToString();
            }
            //FCKeditor1.Value = strContent;
            txtEditorContents.Text = strContent;
        }
    }
}