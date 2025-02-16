<%@ Page Language="C#" AutoEventWireup="true" CodeFile="information-detail-translation-mechanical.aspx.cs" Inherits="information_detail_translation_mechanical" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>機械翻譯、英文科技論文寫作相關資訊</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content=<%=description %> />
<meta name="keywords" content=<%=keywords %> />
<link rel="stylesheet" type="text/css" href="css/style_other.css" />
<link rel="stylesheet" type="text/css" href="css/style_other_cf.css" />
<link rel="stylesheet" type="text/css" href="css/prettyPhoto.css" media="screen" />
        <link rel="icon" href="images/HG.png" type="image/ico" />
<script type="text/javascript" src="js/jquery-1.3.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.5.2.packed.js"></script>
<script type="text/javascript" src="js/jquery.easing.1.1.1.js"></script>
<script type="text/javascript" src="js/jquery.cycle.all.min.js"></script>
<script type="text/javascript" src="js/jquery.validate.js"></script>
<script type="text/javascript" src="js/jquery.prettyPhoto.js"></script>
<script type="text/javascript" src="js/script.js"></script>

<!--[if IE 6]>
<link rel="stylesheet" type="text/css" href="css/ie6.css" />
<script type='text/javascript' src='js/dd_belated_png.js'></script>
<script>DD_belatedPNG.fix('.png,#numbers a,.first_ul');</script>
<![endif]-->
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
<div id="container">
<!-- header -->
<div id="header">
    <!-- logo -->
            <div id="logo"><a href="index-translation-mechanical.aspx" title="首頁"><img src="images/logo2.png" alt="機械翻譯" class="png" /></a></div>
    <!-- /logo -->

    <!-- header right -->
            <div id="header_right">
		<!-- navigation -->
			<div id="navigation">
				<div id="dropdown_menu" class="navigation">
                                    <ul class="navigation">
                                            <li><a href="index-translation-mechanical.aspx" title="首頁">&nbsp;&nbsp;首頁&nbsp;&nbsp;</a></li>
                                            <li><a href="about-translation-mechanical.html" title="關於我們">關於我們</a></li>
                                            <li><a href="service-translation-mechanical.html" title="服務項目">服務項目</a></li>
                                            <li><a href="technique-translation-mechanical.html" title="翻譯語言">翻譯語言</a></li>
                                            <li><a href="quotation-translation-mechanical.aspx" title="線上詢價">線上詢價</a></li>
											<li><a href="contact-translation-mechanical.html" title="聯繫我們">聯繫我們</a></li>
                                    </ul>
				</div>
			</div>
		<!-- / navigation  -->
            </div>
    <!-- /header right -->
</div>
<!-- /header -->


<div id="container1">
<div id="container2">
<div id="container3">    
    <div class="page_curv_top png"></div>
    <div class="content_con png">
	    <div class="sub_header">
			<div class="bannerfloat"><img src="images/information_banner.jpg" alt="機械翻譯"/></div>
			<div class="bannerTextArea">機械翻譯、英文科技論文寫作資訊─后冠翻譯社多年經驗的累積。</div>
	    </div>
	    
	    <div class="content_con2">

	    <!-- left side content -->
	    <div class="content sub">
			<div class="contentTitle">
			 <img class="box_icon" src="images/box_icon.png" alt="機械翻譯"/>
             <h4><a  href="information-translation-mechanical.aspx" title="翻譯資訊">翻譯資訊</a>>>國內遊戲翻譯現狀</h4>
			</div>
			 <div class="information2area">
			 	<div><h1><%=title %></h1></div>
				<div><h2>作者：<%=author%></h2><h3>加入時間：<%=adddate %></h3><h3>點擊次數：<%=clickcount%> 次</h3></div>
				<div class="content">
					<%=contentinfo %>
				</div>
				<div id="detailaddLine">
					<%-- <p>※ 后冠翻譯社推薦相關文章閱讀： </p>
					<%=SimilarNews %>
					<ul><a href="information-detail-translation-mechanical.aspx?id=">國內遊戲翻譯現狀</a></ul>--%>
					<p class="addarea">最專業的翻譯社</p>
					<p>后冠機械翻譯社：https://www.machinery-translationservices.com</p>
					<p>連絡電話：(02)2568-3677客服信箱：service@crowns.com.tw</p>
					<p class="addarea">上一篇：<%=NextNews%></p>
					<p>下一篇：<%=LastNews %></p>
					<p class="addarea">我們會不斷的提供最新的翻譯資訊，各篇文章也歡迎轉載(若為同業需簽定轉載同意書)，轉載時請您記得在文章結尾附上出處與官方超連結。附上出處的方式如下： 文章來源 ：后冠機械翻譯社 （https://www.machinery-translationservices.com）</a></p>
				</div>
				
			 </div>
             </div>
            <!-- / left side content -->
            
            <!-- side bar -->
            <div class="sidebar"><div class="sidebars1"><div class="sidebars2">
	    

		<!-- box -->	
			<div class="box small">
			<!-- sub link-->
				<ul id="sub_menu">
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
                                     <li><a href="information-translation-mechanical.aspx?cid=<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                      <%} %>
				</ul>			
			<!-- /sub link-->
			</div>
		<!-- box -->	
	        
		
		<!-- box -->
                        <div class="box small">
			    <!-- box title-->
                            <ul id="sub_menu1">
                            <li><a href="contact-translation-mechanical.html"  title="聯繫我們">聯繫我們</a></li>
                             </ul>	
                            <!-- text-->
			    <!-- box image-->
			    		<ul>
							<li>TEL：   +886-2-2568-3677</li>
							<li>FAX：   +886-2-2568-3702</li>
							<li>E-mail：service@crowns.com.tw</li>
							<li>地址： 台北市中山區<br/>新生北路二段129-2號7F   Inv:25125082</li>
							<li>上班時間：<br/>星期一至星期五<br/>AM 9:00 ～ PM 6:00</li>
						</ul>
						<div class="imgarea">
							<img src="images/about_box_top.jpg" alt="機械翻譯"/>
							<!--google地图码 -->
							<div class="googlemap">
							<iframe width="208" height="209" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com.tw/maps?f=q&amp;source=s_q&amp;hl=zh-TW&amp;geocode=&amp;q=%E8%87%BA%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;aq=&amp;sll=23.48575,119.49965&amp;sspn=6.60714,11.634521&amp;brcurrent=3,0x3442a93f510c7ba1:0x731637f5caca2004,0,0x3442ac6b61dbbd9d:0xc0c243da98cba64b&amp;ie=UTF8&amp;hq=&amp;hnear=104%E5%8F%B0%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;ll=25.060218,121.527948&amp;spn=0.006376,0.011362&amp;t=m&amp;z=14&amp;output=embed"></iframe>
							</div>
							<!-- /google地图码 -->
							<img src="images/about_box_bottom.jpg" alt="機械翻譯"/>
						</div>
                        </div>
                <!-- /box -->
		
	    
                
                
            </div></div></div>
            <div class="clear"></div>
            <!-- / side bar -->            

        </div>
    
    
</div>
</div>
</div>                                          
</div>
<!-- footer -->
<div id="footer">
            <div class="footer_con"> <div class="footer_con2">
                <!-- copyright text -->
                <div class="part1">
                        Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved
                </div>

                             
                <!-- links -->
                <div class="part3"> 
                         <a  href="index-translation-mechanical.aspx" title="首頁">首頁</a> | <a  href="about-translation-mechanical.html" title="關於我們">關於我們</a> | <a  href="service-translation-mechanical.html" title="服務項目">服務項目</a> | <a  href="quotation-translation-mechanical.aspx" title="線上詢價">線上詢價</a> | <a  href="costumer-translation-mechanical.aspx" title="客戶實績">客戶實績</a> | <a  href="technique-translation-mechanical.html" title="翻譯技術">翻譯技術</a> | <a  href="ourteam-translation-mechanical.aspx" title="翻譯團隊">翻譯團隊</a> | <a  href="information-translation-mechanical.aspx" title="翻譯資訊">翻譯資訊</a> | <a  href="contact-translation-mechanical.html" title="聯絡我們">聯絡我們</a> | <a  href="link-translation-mechanical.aspx" title="友情連結">友情連結</a>| <a  href="sitemap/sitemap.xml" title="sitemap">sitemap</a>
                </div>
				
				<!-- contact -->
				
				<div class="part4">
					<h4>Tel:(02)2568-3677 Fax:(02)2568-3702 台北市中山區新生北路二段129-2號7F   Inv:25125082</h4>
				</div>
           </div></div>
	</div>
<!-- /footer -->
</div>
</body>
</html>
