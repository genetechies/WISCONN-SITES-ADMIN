<%@ Page Language="C#" AutoEventWireup="true" CodeFile="translation-law-information-Detailed.aspx.cs" Inherits="translation_law_information_Detailed" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title><%=Title %></title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1"/>
<meta name="description" content=<%=description %> />
<meta name="keywords" content=<%=keywords %> /> 
<!-- Stylesheets-->
<link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8" />
<link rel="stylesheet" href="css/flexy-menu.css" type="text/css" charset="utf-8" />
<link rel="stylesheet" href="css/style_banner.css" type="text/css" charset="utf-8" />
        <link rel="icon" href="images/HG.png" type="image/ico" />

<!-- banner-js!-->
<script type="text/javascript" src="js/jquery.js"></script>
<script type="text/javascript" src="js/jquery.SuperSlide.js"></script>
<script type="text/javascript" src="js/banner_nav.js"></script>

<!--Flexy Menu Script-->
<script type="text/javascript" src="js/flexy-menu.js"></script>
<!--LayerSlider Script-->
<!--Custom-->
<script type="text/javascript" src="js/custom.js"></script>

<style type="text/css">
<!--
td {
	padding-left:10px; font-size:14px;
}
input{line-height:25px;}
select{line-height:25px; height:25px;}
.content img {
overflow-clip-margin: content-box;
overflow: clip;
width: auto !important;
}
-->
</style></head>
<body>

<div class="top-header">
    	<div class="wrapper topwrap">
            
            <!--Social Media Icons-->
            <ul class="top-socialmedia">
            	<li>
                	<a href="translation-law-index.aspx" title="首頁">首頁</a>
                </li>
                <li>
                	<a href="translation-law-service-technique.html" title="翻譯技術">翻譯技術</a>
                </li>
                <li>
                	<a href="translation-law-link.aspx" title="友情連結">友情連結</a>
                </li>
                </ul>
            <!--End-->
            
        </div>
    </div>
    <!--Top Header End-->

	    
    <div class="wrapper">
    	
        <!--Logo and Main Menu Start-->
        <div class="header-section">
        
        	<!--Logo Start-->
            <div class="logo">
            	<div class="logo-wrapper">
            		<a href="translation-law-index.aspx"><img src="images/logo.png" alt="logo" height="103" width="150" /></a>
                </div>
            </div>
            <!--End-->
        	
            <!--Navigation Menu Start-->
            <ul class="flexy-menu">
                <li><a href="translation-law-index.aspx" title="首頁">首頁</a></li>
                <li><a href="translation-law-about.html" title="關於我們">關於我們</a></li>
                <li><a href="translation-law-service.html" title="服務項目">服務項目</a><div class="menu-space"></div>
                	<ul>
                        <li><a href="translation-law-service-introduce.html" title="法律翻譯介紹">法律翻譯介紹</a></li>
                        <li><a href="translation-law-service-process.html" title="法律翻譯流程">法律翻譯流程</a></li>
                        <li><a href="translation-law-service-advantage.html" title="法律翻譯優勢">法律翻譯優勢</a></li>
                	</ul>
                </li>
                <li><a href="translation-law-service-technique.html" title="翻譯技術">翻譯技術</a></li>
                <li><a href="translation-law-team.aspx" title="法律翻譯團隊">法律翻譯團隊</a></li>
                       
                <li><a href="translation-law-customer.aspx" title="客戶實績">客戶實績</a></li>
                <li><a href="translation-law-quotation.aspx" title="線上詢價">線上詢價</a></li>
                <li><a href="translation-law-contact.html" title="聯繫我們">聯繫我們</a></li>
            </ul>
            <!--Navigation Menu End-->
            
        </div>
         <!--Logo and Main Menu End-->
        
<div class="container">
        	
            <!--All Content Start-->
            <div class="content-wrapper">

<div class="banner" style="background-image:url(images/banner-06.png);">
<div style="float:left; z-index:999px; height:auto; overflow:hidden; width:980px; margin-top:160px;">
<h1 style="line-height:60px; color:#000; font-size:36px; text-align:right; padding-right:100px;">法律翻譯資訊是后冠法律翻譯社多年經驗的累積，<br />

提供法律合約中翻英、英翻中等相關翻譯資訊。
</h1>
</div>
</div>
<!-- banner -->    

                        
	<!--Site Slogan Start-->
	<div class="site-slogan-wrapper">
	<div class="site-slogan">
	
        <div class="nav-add">
        <div class="nav-add-left">
        <div class="nav-add-left-top">法律翻譯  資訊</div>
        <div class="nav-add-left-bottom">法律翻譯的相關資訊─法律合約中翻英、法律合約英翻中、其他語言翻譯</div>
        </div>
        <div class="nav-add-right">首頁 / <span>法律翻譯  資訊 </span></div>
        </div>
    
	</div>
	</div>
	<!--Site Slogan End-->
 
 	<div class="stripe service-panel">

<span style="font-size:14px; text-align:center; display:block; line-height:28px; margin-bottom:40px;">后冠翻譯不斷精進，希望與您分享我們的成果，讓更多人瞭解！文章歡迎自由轉載(若為同業需簽定轉載同意書)，並請附上出處與官方超連結： <br />

文章來源 ：<span style="color:#f68a5e">后冠法律翻譯社 （https://www.legal-translationservices.com/）</span>

 
</span>


<div class="case">

<div class="c_bg">
<ul class="c_list"> 
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

                                     <li><a href="translation-law-information.aspx?cid=<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>

                                      <%} %>
        </ul>
</div>
<div style="height:auto; overflow:hidden; float:left; width:598px; ">
<div class="index_v_list-title">
<ul class="index_v_list_name"> 
<li style="text-align:center;"><%=title %></li>
<li style="color:#999; font-size:12px; text-align:center;">作者：<%=author%> 　　加入時間：<%=adddate %> 　　點擊次數：<%=clickcount%> 次</li>
<li style="color:#999; font-size:12px;">
<div class="content">
<%=contentinfo %>
</div>
</li>
</ul>
</div>


</div>

</div>



	</div>
 
 
 

	</div>
    
    
    
	</div>  
    
                <div class="wrapper">
                    <div class="footer-content">

                      <div class="footer-top">
                            
                            <!--Footer About Us-->
                            <div class="footer-about">
                                <div><img src="images/ar.png" alt="logo" /></div>
                                
                            </div>
                            <!--Footer About Us End-->
                            
                            <!--Footer Contact-->
                        <div class="footer-contact">
                                <h2 class="footer-title">聯絡資訊</h2>
                                <div class="footer-details">
                                    <ul>
                                        <li>
                                            <div class="contact-list">
                                                <span>台北市中山區新生北路二段129-2號7F</span>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="contact-list email">
                                                <span>Email :  service@crowns.com.tw</span>
                                            </div>
                                        </li>
                                        <li>
                                            <div class="contact-list phone">
                                                <span>TEL :  +886-2-2568-3677<br />
													  FAX :  +886-2-2568-3702</span>
                                            </div>
                                        </li>
                                    </ul>
                                </div>
                          </div>
                                <div class="footer-contact">
                                <h2 class="footer-title">&nbsp;</h2>
                                <div class="footer-details">
                                    <ul>
                                        <li>
                                      <div class="contact-list time">
                                                <span>服務時間：9:00-18:00 星期一~星期五</span>
                                            </div>
                                        </li>
                                        <li>
                                      <div class="contact-list www">
                                                <span>官網：https://www.legal-translationservices.com/</span>
                                            </div>
                                        </li>
                                       
                                    </ul>
                                </div>
                          </div>
                            
                        </div>
                        
                        <!--Footer Bottom Start-->
                        <div class="footer-bottom">
                            <div>
                                <ul>
                                    <li><a href="translation-law-index.aspx" title="首頁">首頁</a></li>
                                    <li><a href="translation-law-about.html" title="關於我們">關於我們</a></li>
                                    <li><a href="translation-law-service.html" title="服務項目">服務項目</a></li>
                                    <li><a href="translation-law-quotation.aspx" title="線上詢價">線上詢價</a></li>
                                    <li><a href="translation-law-customer.aspx" title="客戶實績">客戶實績</a></li>
                                    <li><a href="translation-law-service-technique.html" title="翻譯技術">翻譯技術</a></li>
                                    <li><a href="translation-law-team.aspx" title="翻譯團隊">翻譯團隊</a></li>
                                    <li><a href="translation-law-contact.html" title="聯繫我們">聯繫我們</a></li>
                                    <li><a href="translation-law-information.aspx" title="翻譯資訊">翻譯資訊</a></li>
                                    <li><a href="translation-law-link.aspx" title="友情連結">友情連結</a></li><li><a href="sitemap/sitemap.xml" title="sitemap">sitemap</a></li>
                                </ul>
                            </div>
                            
                        </div>
                        <div class="footer-copy">
                        Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved. Inv:25125082 
                        </div>
                        <!--Footer Bottom End-->
                        
                    </div>
                </div>
                
                
        </div>
    

</body>
</html>
