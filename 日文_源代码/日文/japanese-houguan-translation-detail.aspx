<%@ Page Language="C#" AutoEventWireup="true" CodeFile="japanese-houguan-translation-detail.aspx.cs" Inherits="japanese_houguan_translation_detail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠日語翻譯社—最快捷的翻譯資訊，最合理的翻譯價位</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9"/>
	<meta name="description" content=<%=description %> />
	<meta name="keywords" content=<%=keywords %> />
    <script type="text/javascript" src="js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-full.min.js"></script>
    <script type="text/javascript" src="js/jquery.mousewheel.min.js"></script>
    <script type="text/javascript" src="js/jquery.customscrollbar.min.js"></script>
    <script type="text/javascript" src="js/jquery.pagescroll2id.js"></script>
    <script type="text/javascript" src="js/jquery.stickyfloat.js"></script>
    <script type="text/javascript" src="js/scripts.js"></script>
    <link href="style.css" media="screen" rel="stylesheet" type="text/css">
    <link href="js/jquery.mCustomScrollbar.css" rel="stylesheet" type="text/css">
    <link rel="icon" href="images/HG.png" type="image/ico" />
	<style type="text/css">
		.infossss{
			list-style:none;
		}
		.boxall{
			padding: 6px 0px 6px 0px;
			font-size:14px;
			color:#000000;
			float:left;
			width:100%;
			text-align:left;
			border-bottom:1px solid #98927b;
		}
		.boxallinner{
			padding: 0px 0px 0px 0px;
			font-size:13px;
			color:#000000;
			width:100%;
			font-size:13px;
			text-align:left;
			padding:12px;
			text-indent:20px;

		}
		.grid_2,.grid_9{
			display:inline;
			float: left;
			position: relative;
			
		}
		.grid_2 {
			width:14.667%;
		}
		.grid_9 {
			width:73.0%;
		}		
		.ttsssdsd{
			height:32px;
			line-height:32px;
			padding-left:12px;
		}
		.ttsssdsd a{
			text-decoration:none;
		}
		.topin{
			text-align:center;
			font-size:14px;
			color:#000;
		}
		.prev-info{
			margin-top:20px;
			padding-left:12px;
			color:#000;
		}
		.prev-info a{
			text-decoration:none;
		}
		.next-info{
			padding-left:12px;
			color:#000;
		}
		.next-info a{
			text-decoration:none;
		}
		.content img {
			overflow-clip-margin: content-box;
			overflow: clip;
			width: auto !important;
		}
	</style>
</head>

<body class="page-front">
<form runat="server">
    <header class="header">
        <div class="wrap">
            <a class="logo" title="后冠日文翻譯公司" href="japanese-houguan-translation-index.aspx">后冠日文翻譯公司</a>
            <nav id="menu">
				<div class="menu-inner">
                <ul class="level-0">
                    <li><a href="japanese-houguan-translation-index.aspx" title="首頁"><b>首頁</b><br/><span>ホーム</span></a></li>
                    <li><a href="japanese-houguan-translation-about.html" title="關於我們"><b>關於我們</b><br/><span>会社概要</span></a></li>
                    <li><a href="japanese-houguan-translation-service.html" title="服務項目"><b>服務項目</b><br/><span>サービス内容</span></a></li>
                    <li><a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言"><b>翻譯語言</b><br/><span>翻訳対応言語</span></a></li>
                    <li><a href="japanese-houguan-translation-online-price.aspx" title="線上詢價"><b>線上詢價</b><br/><span>翻訳料金</span></a></li>
                    <li><a href="japanese-houguan-translation-faq-problem.html" title="常見問題"><b>常見問題</b><br/><span>よくあるご質問</span></a></li>
					<li><a href="japanese-houguan-translation-contact.html" title="聯繫我們"><b>聯繫我們</b><br/><span>お問い合わせ</span></a></li>
                </ul>
            </nav>
			</div>
        </div>
    </header>

    <div id="page" class="content-page">
        <div id="content">
			<div class="slide_main">
				 <section id="top-header-slider" class="section">
                        <div class="slide transition-1">
                            <img src="images/service_bg.png" width="1200" height="245" alt="日文翻譯">

                            <div class="text">
                                后冠日語翻譯社為客戶提供快捷的翻譯資訊、至高的翻譯品質和合理的翻譯價位
                            </div>
                        </div>

                        
                        
                    </section>
			</div>
           <div class="wrap">
              
				
				<div class="content" style="margin-top:-23px;">
					<div class="cont-2">
						<div class="left_menu_top" style="height:650px;">
							<div class="title">翻譯資訊 / 翻訳情報</div>
							
							<div class="l-menu">
								<ul>									
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
                                     <li><a href="japanese-houguan-translation-informations.aspx?cid=<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                      <%} %>
								
								</ul>
							</div>
						</div>
						<div class="left_menu_bottom"></div>
					</div>
					<div class="about-r">
						<div class="top"></div>
						<div class="con-1 clearfix" style="height:740px;background:#ECE1CD url(images/401.png) no-repeat -56px 0px;">
							<div class="con-t-1 clearfix">
								
						<div class="about-t-t" style="padding-top:24px;">
							<div class="topin"><span style="font-weight:bold"><%=title %></span><br/><span style="font-size:13px"><%=adddate %></span></div>
							<div class="boxallinner content">
								 <%=contentinfo %>
							</div>
							<div class="prev-info">上一篇：<%=NextNews%></div>
							<div class="next-info">上一篇：<%=LastNews %></div>
						</div>
					</div>
				</div>
			</div>
		</div>
    </div>

    <footer class="footer">
        <div class="wrap">
			<p class="bottom-menu">
				<a href="japanese-houguan-translation-index.aspx" title="首頁">首頁</a>|
				<a href="japanese-houguan-translation-about.html" title="關於我們">關於我們</a>|
				<a href="japanese-houguan-translation-service.html" title="服務項目">服務項目</a>|
				<a href="japanese-houguan-translation-online-price.aspx" title="線上詢價">線上詢價</a>|
				<a href="japanese-houguan-translation-customers.aspx" title="客戶實績">客戶實績</a>|
				<a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言">翻譯語言</a>|
				<a href="japanese-houguan-translation-team.aspx" title="翻譯團隊">翻譯團隊</a>|
				<a href="japanese-houguan-translation-informations.aspx" title="翻譯資訊">翻譯資訊</a>|
				<a href="japanese-houguan-translation-faq-problem.html" title="常見問題">常見問題</a>|
				<a href="japanese-houguan-translation-contact.html" title="聯絡我們">聯絡我們</a>|
				<a href="japanese-houguan-translation-link.aspx" title="友情連結">友情連結</a>|<a href="sitemap/sitemap.xml" title="sitemap">sitemap</a>
			</p>
			<p class="l">Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.</p>
            <p class="r">Tel:(02)2568-3677     Fax:(02)2568-3702     台北市中山區新生北路二段129-2號7F   Inv:25125082</p>
            
        </div>
    </footer>
</body>
</form>
</html>
