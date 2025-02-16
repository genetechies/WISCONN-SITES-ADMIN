<%@ Page Language="C#" AutoEventWireup="true" CodeFile="information-houguan-game-translation.aspx.cs" Inherits="information_houguan_game_translation" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta content="text/html;charset=utf-8" http-equiv="content-type" />
    <meta name="description" content="遊戲資訊是我們瞭解遊戲市場最好的方式，也是我們不斷完善自我的資本，是客戶最推薦的遊戲翻譯公司。" />
    <meta name="keywords" content="遊戲翻譯,遊戲翻譯 推薦" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
    <link rel="icon" href="images/HG.png" type="image/ico" />
    <link rel="stylesheet" href="css/style.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="css/styles/fonts.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="css/styles/retina.css" type="text/css" media="screen" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700" type="text/css" />
    <link rel="stylesheet" href="css/styles/jquery.prettyPhoto.css" type="text/css" media="screen" />
    <link rel="stylesheet" type="text/css" href="styleChanger/changer.css" />
    <link rel="stylesheet" type="text/css" href="styleChanger/colorpicker/colorpicker.css" />
    <style id="cFontStyleWColor1" type="text/css">
        a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-header .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {
            color: rgba(255, 255, 255, .4);
        }
    </style>
    <style id="cFontStyleWColor2" type="text/css">
        .widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-header .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {
            color: #fff4c1;
        }
    </style>
    <style id="cFontStyleWColor3" type="text/css">
        .cmsms_content_slider_parent ul.cmsms_slides_nav li a:hover, .cmsms_content_slider_parent ul.cmsms_slides_nav li.active a, #slide_top, .resp_navigation, .cmsms_comments:hover {
            background-color: #fff4c1;
        }
    </style>
    <style id="cFontStyleWColor4" type="text/css">
        input[type="text"]:focus, textarea:focus, select:focus, option, .post .cmsms_tags li a:hover:before, .related_posts_content a img {
            border-color: #fff4c1;
        }
    </style>
    <style id="cFontStyleWColor5" type="text/css">
        .pricingtable .price, .color2 {
            color: #f5a615;
        }
    </style>
    <style id="cFontStyleWColor6" type="text/css">
        span.dropcap2, .comment-reply-link, .button, .button_medium, .button_large, .cmsmsLike:hover, .cmsmsLike.active, .cmsms_plus_inner, a:hover span.image_rollover, .p_sort .button:hover, a.p_cat_filter:hover, .cmsms_post_img {
            background-color: #f5a615;
        }
    </style>
    <style id="cFontStyleWColor7" type="text/css">
        code {
            border-top-color: #f5a615;
        }
    </style>
    <style id="cFontStyleWColor8" type="text/css">
        body {
            background-color: #ffffff;
        }
    </style>
    <script src="js/modernizr.custom.all.js" type="text/javascript"></script>
    <script src="js/respond.js" type="text/javascript"></script>
    <script src="js/jquery.min.js" type="text/javascript"></script>
    <script src="js/jquery.easing.js" type="text/javascript"></script>
    <!--[if lt IE 9]>
			<link rel="stylesheet" href="css/styles/ie.css" type="text/css" />
			<link rel="stylesheet" href="css/styles/ie_css3.css" type="text/css" media="screen" />
		<![endif]-->
    <title>后冠翻譯—客戶最推薦的遊戲翻譯社</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- __________________________________________________ Start Page -->

        <div id="page">
            <a href="#" id="slide_top"></a>
            <!-- __________________________________________________ Start Header -->

            <div id="header">
                <div class="header_inner">

                    <a class="logo" href="index-houguan-game-translation.aspx"><span style="display: inline-block; position: relative; width: 100%;">
                        <font style="color: #FFF; position: absolute; left: 78px; top: 34px;">提供給客戶最新、最詳盡的遊戲資訊，是我們貼心服務的展現也是客戶最推薦的遊戲翻譯社。</font>
                    </span>
                    </a>
                    <a class="resp_navigation" href="javascript:void(0);"><span></span></a>
                    <div style="text-align: center">
                        <ul id="navigation">
                            <li class="current_page_item" style="margin-top: 24px;"><a href="index-houguan-game-translation.aspx" title="首頁"><span style="background-color: #fa2b31;">首頁</span></a></li>
                            <li class="drop" style="margin-top: 80px;"><a href="about-houguan-game-translation.html" title="關於我們"><span style="background-color: #eb6621;">關於我們</span></a>
                                <ul>
                                    <li><a href="about-quality-houguan-game-translation.html" title="品質管理"><span>品質管理</span></a>

                                    </li>
                                    <li><a href="about-native-houguan-game-translation.html" title="母語翻譯"><span>母語翻譯</span></a></li>

                                </ul>
                            </li>
                            <li class="drop" style="margin-top: 15px;"><a href="service-houguan-game-translation.html" title="服務項目"><span style="background-color: #f5a615;">服務項目</span></a>
                                <ul>
                                    <li><a href="service-houguan-game-translation.html" title="遊戲翻譯介紹"><span>遊戲翻譯介紹</span></a>

                                    </li>
                                    <li><a href="service-process-houguan-game-translation.html" title="遊戲翻譯流程"><span>遊戲翻譯流程</span></a>

                                    </li>
                                    <li><a href="service-advantage-houguan-game-translation.html" title="遊戲翻譯優勢"><span>遊戲翻譯優勢</span></a>
                                    </li>
                                </ul>
                            </li>

                            <li style="margin-top: 72px;"><a href="onlineprice-houguan-game-translation.aspx" title="線上詢價"><span style="background-color: #00c481;">線上詢價</span></a></li>
                            <li style="margin-top: 22px;"><a href="contact-houguan-game-translation.html" title="聯繫我們"><span style="background-color: #94c516;">聯繫我們</span></a></li>


                        </ul>
                    </div>
                    <div class="cl"></div>
                </div>
            </div>
            <!-- __________________________________________________ Finish Header -->


            <!-- __________________________________________________ Start Middle -->

            <!--<div class="wrap_cont_nav">
				<div class="cont_nav">
					<a href="translationinformation.html">遊戲翻譯資訊</a>
				</div>
			</div>-->
            <div class="wrap_headline">
                <div class="headline">
                    <h2>遊戲翻譯資訊</h2>
                </div>
            </div>
            <div class="container">
                <div id="middle">
                    <div class="middle_inner">
                        <!-- __________________________________________________ Start Content -->

                        <div id="middle_content">
                            <div class="entry">
                                <div class="one_third">

                                    <div class="comment-body">
                                        <h1>遊戲翻譯資訊</h1>

                                        <ul>
                                            <li style="display: none"></li>

                                            <%System.Data.DataSet dsleft = new DAL.NewsClass().GetList(" ParentID=1 ");
                                                for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
                                                {

                                                    string[] t = new String[2];
                                                    if (dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
                                                    {
                                                        t = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|');
                                                    }
                                                    else
                                                    {
                                                        t[0] = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim();
                                                        t[1] = "";
                                                    }

                                            %>

                                            <li><a href="information-houguan-game-translation.aspx?cid=<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                            <%} %>
                                        </ul>

                                    </div>
                                    <div class="comment-body">
                                        <div class="left-bg1">
                                            <br />
                                            <h2>免費試譯</h2>
                                            <span>我們提供免費的試譯服務，讓您確認品質，並挑選喜愛的風格</span>
                                        </div>
                                        <div class="left-bg2">
                                            <br />
                                            <h2>專業優惠方案</h2>
                                            <span>遊戲翻譯案件的字數較多時，我們提供優惠方案，讓您物超所值</span>
                                        </div>
                                    </div>
                                    <div class="comment-body">
                                        <h1>聯繫我們</h1>
                                        <div class="tel">02-2568-3677</div>

                                        <div class="retstyle">
                                            <a href="../onlineprice-houguan-game-translation.aspx" title="我要線上詢價" class="button"><span>我要線上詢價</span></a>
                                            <a href="../contact-houguan-game-translation.html" title="聯繫我們" class="button"><span>聯繫我們</span></a>

                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class="two_third">
                                <div class="new-content" style="padding-left: 10px;">
                                    <div style="font-size: 15px;">
                                        后冠翻譯不斷在進步，這來自於客戶及翻譯人員之間的溝通，並透過后冠翻譯團隊不斷努力產生的成果。我們提供遊戲資訊，並珍惜您和我們分享的遊戲成果。文章歡迎自由轉載，並請附上出處(需加上超連結連回我們的官網喔)：
文章來源 ：后冠翻譯社 http://translation.crowns.com.tw/。
                                    </div>
                                    <div><asp:Literal ID="ltArtListTitle" runat="server"></asp:Literal></div>
                                    <div><asp:Literal ID="ltArtListDescription" runat="server"></asp:Literal></div>
                                    <div class="news">
                                        <asp:Repeater ID="newrp" runat="server">
                                            <ItemTemplate>
                                                <span class="title"><a href="detailed-houguan-game-translation.aspx?id=<%# Eval("D_Id") %>" title="<%# Eval("D_Title")%>"><%# Eval("D_Title")%></a></span><span class="date"><%# Eval("D_Time", "{0:yyyy-MM-dd}")%></span>
                                                <p><%# Eval("D_Description")%><a class="containue" href="detailed-houguan-game-translation.aspx?id=<%# Eval("D_Id") %>" title="繼續閱讀">繼續閱讀</a></p>

                                                <div class="separation"></div>

                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </div>
                                    <div id="AspNetPager1">
                                        <webdiyer:AspNetPager ID="AspNetPager2" runat="server" AlwaysShow="false" FirstPageText="首頁" LastPageText="尾頁"
                                            NextPageText="下一頁" PrevPageText="上一頁" OnPageChanged="AspNetPager2_PageChanged">
                                        </webdiyer:AspNetPager>
                                    </div>

                                </div>



                            </div>


                        </div>

                        <!-- __________________________________________________ Finish Content -->

                    </div>
                </div>
                <!-- __________________________________________________ Finish Middle -->


                <!-- __________________________________________________ Start Bottom -->


            </div>
        </div>
        <!-- __________________________________________________ Finish Page -->


        <!-- __________________________________________________ Start Footer -->
        <div id="footer">
            <div class="footer_menu">
                <ul class="socialmenu_list">
                    <li><a href="index-houguan-game-translation.aspx" class="link_tooltip" title="首頁">首頁</a><span>|</span></li>
                    <li><a href="about-houguan-game-translation.html" class="link_tooltip" title="關於我們">關於我們</a><span>|</span></li>
                    <li><a href="service-houguan-game-translation.html" class="link_tooltip" title="服務項目">服務項目</a><span>|</span></li>
                    <li><a href="team-houguan-game-translation.aspx" class="link_tooltip" title="翻譯團隊">翻譯團隊</a><span>|</span></li>
                     <li><a href="customer-houguan-game-translation.aspx" class="link_tooltip" title="客戶實績">客戶實績</a><span>|</span></li>  
                    <li><a href="information-houguan-game-translation.aspx" class="link_tooltip" title="翻譯資訊">翻譯資訊</a><span>|</span></li>
                    <li><a href="service-technique-houguan-game-translation.html" class="link_tooltip" title="翻譯技術">翻譯技術</a><span>|</span></li>
                    <li><a href="link-houguan-game-translation.aspx" class="link_tooltip" title="友情連結">友情連結</a><span>|</span></li>
                    <li><a href="onlineprice-houguan-game-translation.aspx" class="link_tooltip" title="線上詢價">線上詢價</a><span>|</span></li>
                    <li><a href="contact-houguan-game-translation.html" class="link_tooltip" title="聯繫我們">聯繫我們</a><span>|</span></li><li><a href="sitemap/sitemap.xml" class="link_tooltip" title="sitemap">sitemap</a></li>

                </ul>



            </div>
            <div class="footer_menu">Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.&nbsp;&nbsp;&nbsp;Tel:(02)2568-3677     Fax:(02)2568-3702&nbsp;&nbsp;&nbsp;台北市中山區新生北路二段129-2號7F &nbsp;&nbsp;&nbsp; Inv:25125082</div>

        </div>
        <!-- __________________________________________________ Finish Footer -->
        <script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>
        <script src="js/jquery.script.js" type="text/javascript"></script>
        <script src="js/jquery.validationEngine.js" type="text/javascript"></script>
        <script src="js/jquery.validationEngine-lang.js" type="text/javascript"></script>
        <script src="js/jquery.jtweetsanywhere.js" type="text/javascript"></script>
        <script src="js/jquery.cmsmsResponsiveSlider.min.js" type="text/javascript"></script>
        <script type="text/javascript">
            jQuery(document).ready(function () {
                jQuery('#slider').cmsmsResponsiveSlider({
                    animationSpeed: 500,
                    animationEffect: 'fadeSlide',
                    animationEasing: 'easeInOutExpo',
                    pauseTime: 7000,
                    activeSlide: 1,
                    buttonControls: false,
                    touchControls: true,
                    pauseOnHover: false,
                    showCaptions: true,
                    arrowNavigation: true,
                    arrowNavigationHover: false,
                    slidesNavigation: true,
                    slidesNavigationHover: false,
                    showTimer: false,
                    timerHover: false
                });
            });
        </script>
    </form>
</body>
</html>
