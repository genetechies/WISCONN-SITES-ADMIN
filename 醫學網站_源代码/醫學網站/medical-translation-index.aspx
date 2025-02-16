<%@ Page Language="C#" AutoEventWireup="true" CodeFile="medical-translation-index.aspx.cs" Inherits="medical_translation_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>后冠醫學翻譯公司—醫學翻譯的首選！</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1"/>
    <meta name="Description" content="醫學翻譯對翻譯師能力要求較高，只懂得語言的翻譯師已難以應對日新月異的醫學翻譯市場需求，后冠醫學翻譯公司擁有多年從業經驗，擁有眾多精通商務、學術等多種醫學相關領域的優秀翻譯師，可以滿足客戶不同的需求。"/>
    <meta name="keywords" content="醫學翻譯,醫學翻譯公司,醫學翻譯社"/>    
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
    <script type="text/javascript">
        function IsPC() {
            var ie6 = ! -[1, ] && !window.XMLHttpRequest;

            if (/AppleWebKit.*mobile/i.test(navigator.userAgent) || (/MIDP|SymbianOS|NOKIA|SAMSUNG|LG|NEC|TCL|Alcatel|BIRD|DBTEL|Dopod|PHILIPS|HAIER|LENOVO|MOT-|Nokia|SonyEricsson|SIE-|Amoi|ZTE/.test(navigator.userAgent))) {
                if (window.location.href.indexOf("?mobile") < 0) {
                    try {
                        if (/Android|webOS|iPhone|iPod|BlackBerry/i.test(navigator.userAgent)) {
                            //window.location.href="手机页面";
                            this.window.location = '/APP/Home.aspx';
                        } else if (/iPad/i.test(navigator.userAgent)) {
                            //window.location.href="平板页面";
                            this.window.location = '/APP/Home.aspx';
                        }
                        else {
                            //window.location.href="其他移动端页面"
                            this.window.location = '/APP/Home.aspx';
                            
                        }
                    } catch (e) { }
                }
            }

        }
    </script>
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/jquery.SuperSlide.js"></script>

</head>
<body onload="IsPC();">

	<div id="container">
        <div id="top">
            <a href="medical-translation-index.aspx" title="醫學翻譯" ><img src="images/logo.png" alt="醫學翻譯" class="logo ie6fix" /></a>  
        </div> <!-- end top -->
        
        <div id="menu">
        	<ul class="sf-menu">
				<li><a href="medical-translation-index.aspx" class="current" title="首頁">首頁</a></li>
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
       <div style="clear:both"></div>
       <div id="banner">
       <div class="index_focus">
	
	<div class="bd">
		<ul>
			<li>
					<div class="index_focus_info">
						<h3>我們擁有最專業的醫學翻譯團隊，給您高水準的翻譯</h3>
						
					</div>
					<img src="images/banner.png"  alt="醫學翻譯公司"/>
		  </li>
			<li>
					<div class="index_focus_info">
						<h3>成熟、高效的服務流程，確保譯文能準確、及時地送達您的手中</h3>

					</div>
					<img src="images/banner01.png"  alt="醫學翻譯公司"/>
		  </li>
			<li>
					<div class="index_focus_info">
						<h3>醫學翻譯是后冠核心服務之一，專業、準確是我們給客戶的一貫承諾。</h3>
						
					</div>
					<img  src="images/banner02.png" alt="醫學翻譯公司"/>
		  </li>

		</ul>
	</div>
	
	<div class="slide_nav">
		<a href="javascript:;">●</a>
		<a href="javascript:;">●</a>
		<a href="javascript:;">●</a>
	</div>
	
</div>
 
       </div>
       
       <script type="text/javascript">
           $(document).ready(function () {

               $(".index_focus").hover(function () {
                   $(this).find(".index_focus_pre,.index_focus_next").stop(true, true).fadeTo("show", 1)
               }, function () {
                   $(this).find(".index_focus_pre,.index_focus_next").fadeOut()
               });

               $(".index_focus").slide({
                   titCell: ".slide_nav a ",
                   mainCell: ".bd ul",
                   delayTime: 500,
                   interTime: 3500,
                   prevCell: ".index_focus_pre",
                   nextCell: ".index_focus_next",
                   effect: "fold",
                   autoPlay: true,
                   trigger: "click",
                   startFun: function (i) {
                       $(".index_focus_info").eq(i).find("h3").css("display", "block").fadeTo(1000, 1);
                   }
               });

           });
</script>
 <!-- banner -->
       
       <div id="latest_news">
       
       	<div class="latest_news_left">翻譯資訊</div> <!-- end latest_news_left -->
        <div class="latest_news_right">
        <marquee direction="left" align="bottom" height="25" width="100%" onmouseout="this.start()" onmouseover="this.stop()" scrollamount="2" scrolldelay="1">
        	<ul>
            

           	<%--<li><a href="medical-translation-information-newsinfo.aspx" title="期刊翻譯公司如何站穩腳步">期刊翻譯公司如何站穩腳步<span class="latest_news_date"> - 2015-07-08</span></a></li>
              <li><a href="medical-translation-information-newsinfo.aspx" title="讓您更加了解學術期刊論文翻譯流程步驟腳步">讓您更加了解學術期刊論文翻譯流程步驟腳步<span class="latest_news_date"> - 2015-07-08</span></a></li>--%>


              <% BLL.newsdata newdll = new BLL.newsdata();
                 System.Data.DataSet dt = newdll.GetList_top(3, "D_Recycle=0");
                 if (dt.Tables[0].Rows.Count>0)
                 {
                     for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
               {


                   string title = dt.Tables[0].Rows[i]["D_Title"].ToString().Length < 11 ? dt.Tables[0].Rows[i]["D_Title"].ToString() : dt.Tables[0].Rows[i]["D_Title"].ToString().Substring(0, 10) + "...";              
                   %>
                   <li><a href="medical-translation-information-newsinfo.aspx?id=<%=dt.Tables[0].Rows[i]["D_Id"].ToString().Trim() %>" title="<%= dt.Tables[0].Rows[i]["D_Title"].ToString().Trim() %>"><%= title %><span class="latest_news_date"><%= dt.Tables[0].Rows[i]["D_Time"].ToString().Trim() %></span></a></li>
                   
                   <%
               };
                 }
               
                %>

             
            </ul>
           </marquee>
        </div> <!-- end latest_news_right -->
       
       </div> <!-- end latest_news --> 
               
       <div id="content">
       
       		<div class="column_front column_margin">
            	<p class="column_headline">關於我們</p>
                <p class="column_headline_description">ABOUT US</p>
                <img src="images/column_image_1.png" alt="醫學翻譯" class="column_image" />
                <p>
                	后冠翻譯社是醫學翻譯行業的佼佼者，擁有專業的水準與忠實的客戶群。我們以專業、源源不斷的創新力，立足台灣。
                </p>
                <a href="medical-translation-about.html" class="ie6fix read_more"></a>
            </div> <!-- end column_front -->
            
            <div class="column_front column_margin">
            	<p class="column_headline ">服務項目</p>
                <p class="column_headline_description">OUR SERVICES</p>
                <img src="images/column_image_2.png" alt="醫學翻譯" class="column_image" />
                <p>
                	隨著科學的進步、世界的發展，國際間的醫學交流往來愈加密切。因應客戶需求，我們可以為您提供客製化服務。
                </p>
                <a href="medical-translation-service.html" class="ie6fix read_more"></a>
            </div> <!-- end column_front -->
            
            <div class="column_front">
            	<p class="column_headline">聯繫我們</p>
                <p class="column_headline_description">CONTACT US</p>
                <img src="images/column_image_3.png" alt="醫學翻譯" class="column_image" />
                <p>
                	點選線上詢價，客服人員將盡速與您聯絡。后冠醫學翻譯公司提供快捷的聯繫方式，盡力為客戶提供方便的服務。
                </p>
                <a href="medical-translation-contact.html" class="ie6fix read_more"></a>
            </div> <!-- end column_front -->
       
       </div> <!-- end content -->
       
       <!--#include file="newspages/downindex.html" -->
       
              <div class="bottom_nav">
<a href="medical-translation-index.aspx" title="首頁">首頁</a>|<a href="medical-translation-about.html" title="關於我們">關於我們</a>|<a href="medical-translation-service.html" title="服務項目">服務項目</a>|<a href="medical-translation-mechanical.html" title="翻譯技術">翻譯技術</a>|<a href="medical-translation-costomer.aspx" title="客戶實績">客戶實績</a>|<a href="medical-translation-OurTeam.aspx" title="醫學翻譯團隊">醫學翻譯團隊</a>｜<a href="medical-translation-information.aspx" title="醫學翻譯資訊">醫學翻譯資訊</a>|<a href="medical-translation-link.aspx" title="友情連結">友情連結</a>|<a href="medical-translation-OnlinePrice.aspx" title="線上詢價">線上詢價</a>|<a href="medical-translation-contact.html" title="聯繫我們">聯繫我們</a>|<a href="sitemap/sitemap.xml" title="sitemap">sitemap</a>
        </div>
              
       <div id="footer">
      		<div class="fl"><p>Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.   Tel:(02)2568-3677 Fax:(02)2568-3702   台北市中山區新生北路二段129-2號7F     Inv:25125082</p></div>
       </div> <!-- end footer -->
        
	</div> <!-- end container -->
    
</body>
</html>

