<%@ Page Language="C#" AutoEventWireup="true" CodeFile="medical-translation-information-newsinfo.aspx.cs" Inherits="medical_translation_information_newsinfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠翻譯社—醫學翻譯的資料與訊息。</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1"/>
    <meta name="description" content=<%=description %> />
    <meta name="keywords" content=<%=keywords %> />   
    <!-- Stylesheets-->
    <link rel="stylesheet" href="css/reset.css" type="text/css" charset="utf-8" />
    <link rel="stylesheet" href="css/general.css" type="text/css" charset="utf-8" />
    <link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8" />
            <link rel="icon" href="images/HG.png" type="image/ico" />
	<!-- jQuery Libary -->
	<script src="js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <!-- Menu -->
    <link rel="stylesheet" type="text/css" href="css/superfish.css" media="screen" />
	<script src="js/hoverIntent.js" type="text/javascript" ></script>
	<script src="js/superfish.js" type="text/javascript"></script>
    <!-- Initialize javascript -->
    <script src="js/init.js" type="text/javascript"></script>
   <!--[if IE 6]>
    <script src="js/DD_belatedPNG_0.0.7a-min.js" type="text/javascript"></script>
    <script>
      /* EXAMPLE */
      DD_belatedPNG.fix('.ie6fix');

    </script>
    <![endif]--> 
    <!-- banner -->
<style type="text/css">
<!--
.content img {
overflow-clip-margin: content-box;
overflow: clip;
width: auto !important;
}
-->
</style>

</head>
<body>
<form id="form1" runat="server">
	<div id="container">
        <div id="top">
            <a href="medical-translation-index.aspx" title="醫學翻譯" ><img src="images/logo.png" alt="醫學翻譯" class="logo ie6fix" /></a> 
        </div> <!-- end top -->
        
        <div id="menu">
        	<ul class="sf-menu">
				<li><a href="medical-translation-index.aspx" title="首頁">首頁</a></li>
				<li><a href="medical-translation-about.html" title="關於我們">關於我們</a>
                        <ul>
								<li><a href="medical-translation-about-quality.html" title="品質管理">品質管理</a></li>
								<li><a href="medical-translation-about-professional.html" title="專業翻譯">專業翻譯</a></li>
						</ul>
                        </li>
						
			
				<li><a href="medical-translation-service.html" title="服務項目">服務項目</a>
               			 <ul>
								<li><a href="medical-translation-service-introduce.html" title="醫學翻譯介紹">醫學翻譯介紹</a></li>
								<li><a href="medical-translation-service-process.html" title="醫學翻譯流程">醫學翻譯流程</a></li>
                                <li><a href="medical-translation-service-advantage.html" title="醫學翻譯優勢">醫學翻譯優勢</a></li>
						</ul>
                        </li>
                <li><a href="medical-translation-OurTeam.aspx" title="醫學翻譯團隊">醫學翻譯團隊</a></li> 
                <li><a href="medical-translation-costomer.aspx" title="客戶實績">客戶實績</a></li>	       
				<li><a href="medical-translation-OnlinePrice.aspx" title="線上詢價">線上詢價</a></li>
                <li><a href="medical-translation-contact.html" title="聯繫我們">聯繫我們</a></li>
                
			</ul>
        </div> <!-- end menu -->
       
       <div id="banner" style="background-image:url(images/banner01.png);">
 <div style="background-image:url(images/index_focus_bg.png); float:left; z-index:999; height:30px; width:850px; margin-top:30px;">
 <h1 style="line-height:30px; color:#FFF; font-size:18px; text-align:right; padding-right:50px;">醫學翻譯資訊是后冠翻譯社多年經驗的累積，是寶貴的資產。</h1>
 </div>
       </div> <!-- banner -->
       
               
       <div id="content">
       
       <div id="secondaryContent">
            	<div class="secondaryContent_box"> <a href="medical-translation-about.html"><img src="images/our_services_news.png" alt="醫學翻譯" /></a>
                    <div class="secondaryContent_box_content">
                   	  <ul class="our_services">
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
                                     <li><a href="medical-translation-information.aspx?cid=<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                      <%} %>
                        </ul>
                </div>                 
                
            </div>
       		
            <div id="primaryContent">
            <div class="about_title">
            <div class="about_title_left"></div>
            <div class="about_right_font">翻譯<span>資訊</span></div>
            </div>
                
                <div class="about_body">
                
                <div class="in_body">

<div class="news">
<div class="news_title_in"><%=title %></div>
<div class="news_time">作者：<%=author%>  加入時間：<%=adddate %>  點擊次數：<%=clickcount%></div>
<div class="news_body content"><%=contentinfo %></div>


</div>


				</div>
				




				</div>

                
            </div> <!-- end primaryContent -->
            
             
		       
       </div> <!-- end content -->
              <div class="bottom_nav">
<a href="medical-translation-index.aspx" title="首頁">首頁</a>|<a href="medical-translation-about.html" title="關於我們">關於我們</a>|<a href="medical-translation-service.html" title="服務項目">服務項目</a>|<a href="medical-translation-mechanical.html" title="翻譯技術">翻譯技術</a>|<a href="medical-translation-costomer.aspx" title="客戶實績">客戶實績</a>|<a href="medical-translation-OurTeam.aspx" title="醫學翻譯團隊">醫學翻譯團隊</a>｜<a href="medical-translation-information.aspx" title="醫學翻譯資訊">醫學翻譯資訊</a>|<a href="medical-translation-link.aspx" title="友情連結">友情連結</a>|<a href="medical-translation-OnlinePrice.aspx" title="線上詢價">線上詢價</a>|<a href="medical-translation-contact.html" title="聯繫我們">聯繫我們</a>|<a href="sitemap/sitemap.xml" title="sitemap">sitemap</a>
        </div>
             
       <div id="footer">
      		<div class="fl"><p>Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.   Tel:(02)2568-3677 Fax:(02)2568-3702   台北市中山區新生北路二段129-2號7F     Inv:25125082</p></div>
       </div> <!-- end footer -->
        
	</div> <!-- end container -->
        </div>
    </form>
</body>
</html>

