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

namespace Web.Admin
{
    public partial class Left : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null || Session["Admin"].ToString() != "admin")
            {
                //thrid.Style.Add("display", "none");
                thrid.Visible = false;
            }
            
            #region 基本信息
            int Five = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "webset", RightStatus.Update))
            {
                webset.Style.Add("display", "none");
                Five += 1;
            }
            if (Five == 1)
            {
                five.Style.Add("display", "none");
            }
            #endregion
            #region 翻譯資訊管理
            int Eight = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Select))
            {
                news.Style.Add("display", "none");
                Eight += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Insert))
            {
                newsInsert.Style.Add("display", "none");
                Eight += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Select) && !Utils.IsRight(Session["Admin"].ToString(), "articleclass", RightStatus.Insert))
            {
                articleclass.Style.Add("display", "none");
                Eight += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Select) && !Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Update))
            {
                newsrover.Style.Add("display", "none");
                Eight += 1;
            }
            if (Eight == 4)
            {
                eight.Style.Add("display", "none");
            }
            #endregion
            #region 翻譯領域管理
            //int Nine = 0;
            //if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Select))
            //{
            //    NewsManage.Style.Add("display", "none");
            //    Nine += 1;
            //}
            //if (!Utils.IsRight(Session["Admin"].ToString(), "news", RightStatus.Insert))
            //{
            //    ElseNewsInsert.Style.Add("display", "none");
            //    Nine += 1;
            //}
            //if (!Utils.IsRight(Session["Admin"].ToString(), "transzonetype", RightStatus.Select))
            //{
            //    transzonetype.Style.Add("display", "none");
            //    Nine += 1;
            //}
            //if (!Utils.IsRight(Session["Admin"].ToString(), "newsrover", RightStatus.Select))
            //{
            //    ElseNewsover.Style.Add("display", "none");
            //    Nine += 1;
            //}
            //if (Nine == 4)
            //{
            //    nine.Style.Add("display", "none");
            //}
            #endregion
            #region 翻譯團隊管理
            int One = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Insert))
            {
                guopic1.Style.Add("display", "none");
                One += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "team", RightStatus.Insert))
            {
                team1.Style.Add("display", "none");
                One += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "teamtype", RightStatus.Select))
            {
                transzonetype1.Style.Add("display", "none");
                One += 1;
            }
            if (One == 3)
            {
                one.Style.Add("display", "none");
            }
            #endregion
            #region 客戶實績
            int second = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "guoclass", RightStatus.Select))
            {
                guoclass.Style.Add("display", "none");
                second += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "linyuclass", RightStatus.Select))
            {
                linyuclass.Style.Add("display", "none");
                second += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Select) && !Utils.IsRight(Session["Admin"].ToString(), "guopic", RightStatus.Insert))
            {
                guopic.Style.Add("display", "none");
                second += 1;
            }
            //if (!Utils.IsRight(Session["Admin"].ToString(), "pluppic", RightStatus.Select))
            //{
            //    pluppic.Style.Add("display", "none");
            //    second += 1;
            //}
            //if (!Utils.IsRight(Session["Admin"].ToString(), "outlogo", RightStatus.Select))
            //{
            //    outlogo.Style.Add("display", "none");
            //    second += 1;
            //}
            //if (!Utils.IsRight(Session["Admin"].ToString(), "logodr", RightStatus.Insert))
            //{
            //    logodr.Style.Add("display", "none");
            //    second += 1;
            //}
            if (!Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Update) && !Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Select) && !Utils.IsRight(Session["Admin"].ToString(), "linyuxinxi", RightStatus.Insert))
            {
                linyuxinxi.Style.Add("display", "none");
                second += 1;
            }
            //if (!Utils.IsRight(Session["Admin"].ToString(), "outlyxx", RightStatus.Select))
            //{
            //    outlyxx.Style.Add("display", "none");
            //    second += 1;
            //}
            //if (!Utils.IsRight(Session["Admin"].ToString(), "exceldr", RightStatus.Select) && !Utils.IsRight(Session["Admin"].ToString(), "exceldr", RightStatus.Insert))
            //{
            //    exceldr.Style.Add("display", "none");
            //    second += 1;
            //}
            if (!Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Select) && !Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Delete) && !Utils.IsRight(Session["Admin"].ToString(), "lyxxrover", RightStatus.Update))
            {
                lyxxrover.Style.Add("display", "none");
                second += 1;
            }
            if (second == 5)
            {
                secondstyle.Style.Add("display", "none");
            }
            #endregion
            #region 線上咨詢
            int Four = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "guest", RightStatus.Select))
            {
                guest1.Style.Add("display", "none");
                Four += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "guestemail", RightStatus.Select))
            {
                guestemail1.Style.Add("display", "none");
                Four += 1;
            }
            if (Four == 2)
            {
                four.Style.Add("display", "none");
            }
            #endregion
            #region 人才招募
            int Six = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "yingpin", RightStatus.Select))
            {
                yingpin1.Style.Add("display", "none");
                Six += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "outjianli", RightStatus.Select))
            {
                outjianli1.Style.Add("display", "none");
                Six += 1;
            }
            if (Six == 2)
            {
                six.Style.Add("display", "none");
            }
            #endregion
            #region 友好連結及合作夥伴
            int Seven = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Insert))
            {
                friendlyInsert.Style.Add("display", "none");
                Seven += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Select))
            {
                friendlyManage.Style.Add("display", "none");
                Seven += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendlyupdown", RightStatus.Insert    ))
            {
                friendlyupdown.Style.Add("display", "none");
                Seven += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendlyupdown", RightStatus.Delete))
            {
                friendlyupdown1.Style.Add("display", "none");
                Seven += 1;
            }


            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Insert))
            {
                friendly1.Style.Add("display", "none");
                Seven += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "friendly", RightStatus.Select))
            {
                friendly2.Style.Add("display", "none");
                Seven += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "partnersupdown", RightStatus.Insert))
            {
                friendly3.Style.Add("display", "none");
                Seven += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "partnersupdown", RightStatus.Delete))
            {
                friendly4.Style.Add("display", "none");
                Seven += 1;
            }
            if (Seven == 8)
            {
                seven.Style.Add("display", "none");
            }
            #endregion

            #region 子網站管理
            int Ten = 0;
            if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Insert))
            {
                WebSubInsert.Style.Add("display", "none");
                Ten += 1;
            }
            if (!Utils.IsRight(Session["Admin"].ToString(), "subweb", RightStatus.Select))
            {
                WebSubManage.Style.Add("display", "none");
                Ten += 1;
            }
            if (Ten == 2)
            {
                ten.Style.Add("display", "none");
            }
            #endregion
        }

        protected void Quit_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
        }
    }
}
