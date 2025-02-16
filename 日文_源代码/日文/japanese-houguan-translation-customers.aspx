<%@ Page Language="C#" AutoEventWireup="true" CodeFile="japanese-houguan-translation-customers.aspx.cs" Inherits="japanese_houguan_translation_customers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠日語翻譯（高雄、台南）—以實績見證實力</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9"/>
	<meta name="description" content="高雄和台南是台灣重要的中心城市，人流量大，日語翻譯的需求也極大。而后冠設立在此的日語翻譯社不斷壯大，一路走來以絕佳的實績讓廣大客戶見證后冠的翻譯實力"/>
	<meta name="keywords" content="日語翻譯 高雄、日語翻譯 台南"/>
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
                                后冠日語翻譯社（高雄、台南）成立多年，創造優秀的客戶實績
                            </div>
                        </div>

                        
                        
                    </div>
			</div>
           <div class="wrap">
              
				
				<div class="content" style="margin-top:-23px;">
					<div class="cont-2">
						<div class="left_menu_top" style="height:654px">
							<div class="title">客戶實績 / 翻訳実績</div>





							
							<div class="l-menu">
								<ul>
                                    <li style="display:none"></li>
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
                                     <li><a href="japanese-houguan-translation-customers.aspx?gid=<%=dsleft.Tables[0].Rows[i]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
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
									<span>客戶實績 / 翻訳実績</span>
								</div>
								<div class="c-l-l">
									我們堅持「客戶至上，打造優秀的翻譯服務」為公司存在的宗旨。后冠日語翻譯（高雄、台南）以雄厚的實力獲得客戶的一致好評。
								</div>
								<div class="c-l-r clearfix">
									<img src="images/incon-1.png" width="180" alt="日文翻譯"/>
								</div>
								
							</div>
						<div class="lines clearfix"></div>
						<div class="about-t-t">
						<table cellpadding="0" cellspacing="1" border="6" class="about-tab1">
                        <%
      string gid = "";
      if (Request.QueryString["gid"]!=null)
      {
          gid = "guoclassid=" + Request.QueryString["gid"].ToString();
      }
      System.Data.DataSet dslog = new BLL.guopic().GetList(gid);
                            for (int i = 0; i < dslog.Tables[0].Rows.Count; i++)
                            {
                                if (i%3==0)
                                {%>
                                <tr>
		<td width="33.333%">
			<div class="iii"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" />
			<div class="namss"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div></div>
		</td>

                                <%}
                                else if ((i + 1) % 3 == 0)
                                {%>                                    
		<td width="33.333%">
			<div class="iii"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" />
			<div class="namss"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div></div>
		</td></tr>
                                <% }
                                else {%>
                                   <td width="33.333%">
			<div class="iii"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" />
			<div class="namss"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div></div>
		</td>
                                <% } %>
                           <% }
                         %>

							<tr style="display:none"><td></td></tr>
						</table>
						</div>
						</div>
					</div>
				</div>
			</div>
</div>    </div>

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
