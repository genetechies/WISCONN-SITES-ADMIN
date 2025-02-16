<%@ Page Language="C#" AutoEventWireup="true" CodeFile="customer-houguan-game-translation.aspx.cs" Inherits="customer_houguan_game_translation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta content="text/html;charset=utf-8" http-equiv="content-type" />
    <meta name="description" content="遊戲的玩家是我們的第二客戶，也是非常重要的服務對象之一。讓他們滿足是我們最大的榮幸，而他們的評價更是鞭策我們的動力。這些寶貴的意見都會成為我們不斷提高翻譯品質的動力和保障。" />
    <meta name="keywords" content="遊戲翻譯" />
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
    <title>后冠翻譯社—遊戲客戶的評價</title>
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
                        <font style="color: #FFF; position: absolute; left: 78px; top: 34px;">玩家是整個遊戲中最終使用者，所以他們的評價相當具有參考價值。</font>
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
					<a href="customerlist.html">遊戲客戶實績</a>
				</div>
			</div>-->
            <div class="wrap_headline">
                <div class="headline">
                    <h2>遊戲客戶實績</h2>
                </div>
            </div>
            <div class="container">
                <div id="middle">
                    <div class="middle_inner">
                        <!-- __________________________________________________ Start Content -->

                        <div id="middle_content">
                            <div class="entry">
                                <div class="one_third">

                                    <div class="tab_content comment-body">
                                        <div class="tabs_tab" style="display: block;">

                                            <h2>遊戲翻譯資訊</h2>
                                            <ul>
                                                <li style="display: none"></li>
                                                <%System.Data.DataSet dsleft = new DAL.guoclass().GetList("");
                                                    for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
                                                    {
                                                        string[] t = new String[2];
                                                        if (dsleft.Tables[0].Rows[i]["nc_classname"].ToString().Trim().Split('|').Length > 1)
                                                        {
                                                            t = dsleft.Tables[0].Rows[i]["nc_classname"].ToString().Trim().Split('|');
                                                        }
                                                        else
                                                        {
                                                            t[0] = dsleft.Tables[0].Rows[i]["nc_classname"].ToString().Trim();
                                                            t[1] = "";
                                                        }

                                                %>
                                                <li class="li1">
                                                    <a href="customer-houguan-game-translation.aspx?gid=<%=dsleft.Tables[0].Rows[i]["nc_id"].ToString().Trim() %>">
                                                        <span style="color: white">
                                                            <%=t[0].Trim()%>
                                                        </span>
                                                    </a>

                                                </li>
                                                <%} %>
                                            </ul>
                                        </div>
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
                                            <!--<a href="../onlineprice-houguan-game-translation.aspx"><img src="../images/online.png" width="230"/></a><div class="breakline"></div>
                                          <a href="../contact-houguan-game-translation.html"><img src="../images/rel.png" width="230"/></a>-->
                                        </div>

                                    </div>
                                </div>
                                <div class="two_third">

                                    <h3 style="font-weight: 400;">后冠翻譯社已經在業界樹立了良好的形象，擁有口碑。相信后冠、喜歡后冠，這是我們最大的榮幸，特別是得到行家的肯定，更是我們長久以來的努力所得到的最好的回報。
                                    </h3>


                                    <div class="logolist">

                                        <%
                                            string gid = "";
                                            if (Request.QueryString["gid"] != null)
                                            {
                                                gid = "guoclassid=" + Request.QueryString["gid"].ToString();
                                            }
                                            System.Data.DataSet dslog = new BLL.guopic().GetList(gid);
                                            for (int i = 0; i < dslog.Tables[0].Rows.Count; i++)
                                            {%>

                                        <div class="picbox">
                                            <img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" width="120" height="60" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" title="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" />
                                            <h3><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></h3>
                                        </div>

                                        <% }
                                        %>
                                        <%--       <div class="picbox"><img src="uploadfile/201212112124326.jpg" width="120" height="60" alt="Microchip Technology Inc" title="遊戲翻譯"/>
         <h3>Microchip Technology Inc</h3></div>--%>
                                    </div>
                                    <div class="h12"></div>

 


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
