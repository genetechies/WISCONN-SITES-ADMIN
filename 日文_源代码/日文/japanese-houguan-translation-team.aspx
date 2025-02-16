<%@ Page Language="C#" AutoEventWireup="true" CodeFile="japanese-houguan-translation-team.aspx.cs" Inherits="japanese_houguan_translation_team" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠日文翻譯公司—專業日文翻譯團隊為您提供翻譯日文網站的服務</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9"/>
	<meta name="description" content="后冠日文翻譯公司的翻譯團隊來自五湖四海，都是經歷層層考驗才能進入翻譯社，他們不僅有深厚的日文翻譯功底，還有多年翻譯日文網站的經驗，是最專業、最準確、最負責的團隊。"/>
	<meta name="keywords" content="翻譯日文網站"/>
    <script type="text/javascript" src="js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-full.min.js"></script>
    <script type="text/javascript" src="js/jquery.mousewheel.min.js"></script>
    <script type="text/javascript" src="js/jquery.customscrollbar.min.js"></script>
    <script type="text/javascript" src="js/jquery.pagescroll2id.js"></script>
    <script type="text/javascript" src="js/jquery.stickyfloat.js"></script>
    <script type="text/javascript" src="js/scripts.js"></script>
    <link href="style.css" media="screen" rel="stylesheet" type="text/css"/>
    <link href="js/jquery.mCustomScrollbar.css" rel="stylesheet" type="text/css"/>
    <link rel="icon" href="images/HG.png" type="image/ico" />
</head>

<body class="page-front">
    <div class="header">
        <div class="wrap">
           <a class="logo" title="后冠日文翻譯公司" href="japanese-houguan-translation-index.aspx">后冠日文翻譯公司</a>
            <div id="menu">
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
            </div>
			</div>
        </div>
    </div>

    <div id="page" class="content-page">
        <div id="content">
			<div class="slide_main">
				 <div id="top-header-slider" class="section">
                        <div class="slide transition-1">
                            <img src="images/service_bg.png" width="1200" height="245" alt="日文翻譯"/>

                            <div class="text">
                                后冠日文翻譯公司相信，只有好的翻譯團隊才能締造優質的日文翻譯
                            </div>
                        </div>

                        
                        
                    </div>
			</div>
           <div class="wrap">
              
				
				<div class="content" style="margin-top:-23px;">
					<div class="cont-2">
						<div class="left_menu_top" style="height:650px">
							<div class="title">翻譯團隊 / 翻訳チーム</div>
							
							<div class="l-menu">
								<ul>
                                    <li style="display:none"></li>
                                    <%System.Data.DataSet dsleft = new DAL.TransTeam().GetAllTeamType();
                                      for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
                                      {
                                          string[] t = new String[2];
                                          if (dsleft.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim().Split('|').Length > 1)
                                          {
                                              t = dsleft.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim().Split('|');
                                          }
                                          else
                                          {
                                              t[0] = dsleft.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim();
                                              t[1] = "";
                                          }
                                          
                                         %>
                                     <li><a href="japanese-houguan-translation-team.aspx?gid=<%=dsleft.Tables[0].Rows[i]["NC_Id"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                      <%} %>
								
								</ul>
							</div>
						</div>
						<div class="left_menu_bottom"></div>
					</div>
					<div class="about-r">
						<div class="top"></div>
						<div class="con-1 clearfix">
							<div class="con-t-1 clearfix">
								<div class="c-inner clearfix">
									<span>日文翻譯團隊 / 日本語翻訳チーム</span>
								</div>
								<div class="c-l-l">
									<p style="line-height:24px;"> 翻翻譯師應該具備廣博的世界觀，同時具備專業領域的基礎知識。而后冠日文翻譯公司的翻譯師不僅了解日本的經濟政治文化，還具備優秀的日文專業知識及語言能力。</p>
									<p style="line-height:24px;margin-top:6px">此外，還有母語翻譯師加入后冠，讓我們的日文翻譯團隊更加強大，也能更加方便、更加專業的為客戶提供優質翻譯。</p>
								</div>
								<div class="c-l-r clearfix">
									<img src="images/incon-1.png" width="180" alt="日文翻譯"/>
								</div>
								
							</div>
						<div class="lines clearfix"></div>
						<div class="about-t-t" style="height:455px;">
							<ul class="sexc-l">
                                 <li style="display:none"></li>
                                <asp:Repeater ID="rep_english" runat="server">
                                    <ItemTemplate>
                                         <li style="width:33.33%">
									        <div class="imagsa"><img src="<%#Eval("imgpath").ToString().Trim().Equals("") ? "" : Eval("imgpath")%>" alt="日文翻譯"/></div>
									        <div class="sexc-l-l">姓名:<%#Eval("tname").ToString().Trim().Equals("") ? "" : Eval("tname")%></div>
									        <div class="sexc-l-l">性別:<%#Eval("avater").ToString().Trim().Equals("") ? "" : Eval("avater").ToString() == "0" ? "男" : "女"%></div>
									        <div class="sexc-l-l">簡介:</div>
									        <div class="sexc-l-l"><%#Eval("descript").ToString().Trim().Equals("") ? "" : Eval("descript")%></div>
								        </li>
                                    </ItemTemplate>
                                </asp:Repeater>								
							</ul>
						</div>
						</div>
					</div>
				</div>
			</div>
    </div>
</div>
    <div class="footer">
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
    </div>
</body>
</html>
