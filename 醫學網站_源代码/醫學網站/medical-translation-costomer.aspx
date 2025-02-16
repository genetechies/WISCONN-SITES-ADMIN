<%@ Page Language="C#" AutoEventWireup="true" CodeFile="medical-translation-costomer.aspx.cs" Inherits="medical_translation_costomer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠翻譯社—我們的客戶來自全世界，最頂尖的醫療器材翻譯、醫學翻譯公司！</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1"/>
    <meta name="Description" content="經過多年的不懈努力，后冠醫藥翻譯社已經擁有忠實的客戶群，眾多醫學翻譯、醫療器材翻譯案例昭示了我們在此領域的努力，不斷有新客戶變成我們的老客戶，客戶的肯定，是我們不斷前進的動力！"/>
    <meta name="keywords" content="醫療器材翻譯,醫藥翻譯"/>    
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

</head>
<body>

	<div id="container">
        <div id="top">
            <a href="medical-translation-index.aspx" title="醫療器材翻譯" ><img src="images/logo.png" alt="醫療器材翻譯" class="logo ie6fix" /></a> 
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
                <li><a href="medical-translation-costomer.aspx" class="current" title="客戶實績">客戶實績</a></li>       
				<li><a href="medical-translation-OnlinePrice.aspx" title="線上詢價">線上詢價</a></li>
                <li><a href="medical-translation-contact.html" title="聯繫我們">聯繫我們</a></li>
                	
			</ul>
        </div> <!-- end menu -->
       
       <div id="banner" style="background-image:url(images/about_banner.png);">
 <div style="background-image:url(images/index_focus_bg.png); float:left; z-index:999; height:30px; width:850px; margin-top:30px;">
 <h1 style="line-height:30px; color:#FFF; font-size:18px; text-align:right; padding-right:50px;">成熟的醫學翻譯經驗與熱情的服務團隊是高品質翻譯的保證！</h1>
 </div>
       </div><!-- banner -->
       
               
       <div id="content">
       
       <div id="secondaryContent">
            	<div class="secondaryContent_box"> <a href="medical-translation-about.html"><img src="images/our_services4.png" alt="醫藥翻譯" /></a>
                    <div class="secondaryContent_box_content">
                   	  <ul class="our_services">

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
                                     <li><a href="medical-translation-costomer.aspx?gid=<%=dsleft.Tables[0].Rows[i]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                      <%} %>

                        </ul>
                    </div>
                </div>                 
                
            </div>
       		
            <div id="primaryContent">
            <div class="about_title">
            <div class="about_title_left"></div>
            <div class="about_right_font">客戶<span>實績</span></div>
            </div>
                
                <div class="about_body">
                
                <!-- <h1>后冠翻譯最真實的客戶實績</h1>  -->
                <br />
                <div class="in_body">

后冠翻譯一直注重和每一位客戶的對話，盡力完成最好的翻譯服務。無論是解惑還是服務，后冠醫學翻譯都秉持著耐心細緻的服務態度努力搭建和客戶間的信賴橋梁，以期尋求長期的合作，達到相互共贏的目的，追求最大的利益。


				</div>
				<div class="in_body">
                <%
      string gid = "";
      if (Request.QueryString["gid"]!=null)
      {
          gid = "guoclassid=" + Request.QueryString["gid"].ToString();
      }
      System.Data.DataSet dslog = new BLL.guopic().GetList(gid);
                            for (int i = 0; i < dslog.Tables[0].Rows.Count; i++)
                            {%>

                                <div class="costomer"><div class="costomer_img"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>"  /></div><div class="costomer_name"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div></div>

                           <% }
                         %>


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
    
</body>
</html>

