<%@ Page Language="C#" AutoEventWireup="true" CodeFile="medical-translation-OurTeam.aspx.cs" Inherits="medical_translation_OurTeam" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠翻譯社—讓我們驕傲的醫學翻譯團隊，專業的英文、日文醫學翻譯服務</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1"/>
    <meta name="Description" content="翻譯團隊是后冠翻譯社的寶貴資源，我們的高水準譯文完全依賴於英文、日文醫學翻譯專業人才在幕後的努力，可以說后冠如今取得的所有成就都離不開他們的努力與堅持！"/>
    <meta name="keywords" content="醫學翻譯 英文,醫學翻譯 日文"/>    
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
            <a href="medical-translation-index.aspx" title="后冠醫學翻譯社" ><img src="images/logo.png" alt="醫學翻譯 英文" class="logo ie6fix" /></a> 
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
                <li><a href="medical-translation-OurTeam.aspx" class="current" title="醫學翻譯團隊">醫學翻譯團隊</a></li> 
                <li><a href="medical-translation-costomer.aspx" title="客戶實績">客戶實績</a></li>	       
				<li><a href="medical-translation-OnlinePrice.aspx" title="線上詢價">線上詢價</a></li>
                <li><a href="medical-translation-contact.html" title="聯繫我們">聯繫我們</a></li>
                
			</ul>
        </div> <!-- end menu -->
       
       <div id="banner" style="background-image:url(images/banner.png);">
 <div style="background-image:url(images/index_focus_bg.png); float:left; z-index:99; height:30px; width:850px; margin-top:30px;">
 <h1 style="line-height:30px; color:#FFF; font-size:18px; text-align:right; padding-right:50px;">成熟的醫學翻譯經驗與熱情的服務團隊是高品質翻譯的保證！</h1>
 </div>
       </div><!-- banner -->
       
               
       <div id="content">
       
           <form runat="server">
               
               <div id="secondaryContent">
                   <div class="secondaryContent_box"> <a href="medical-translation-about.html"><img src="images/OurTeam.png" alt="醫學翻譯 日文" /></a>
                       <div class="secondaryContent_box_content">
                           <ul class="our_services" >
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
                                   <li><a href="medical-translation-OurTeam.aspx?gid=<%=dsleft.Tables[0].Rows[i]["NC_Id"].ToString().Trim() %>" title="品質管理"><%=t[0].Trim()%></a></li>
                               <%} %>

                           </ul>
                       </div>
                   
                   </div>                 
                
               </div>

            <div id="primaryContent">
            <div class="about_title">
            <div class="about_title_left"></div>
            <div class="about_right_font">翻譯<span>團隊</span></div>
            </div>
                
                <div class="about_body">
                
                <!-- <h1>后冠翻譯社—讓我們驕傲的醫學翻譯團隊</h1>  -->
                <br />
                <div class="in_body">

后冠的醫學翻譯團隊成員來自全球不同的國家和地區，具有外語和醫學雙重背景，熟悉醫學、醫藥相關領域，專業的英文、日文醫學翻譯服務，是后冠翻譯品質與服務水準的有力保障。<br />

后冠的團隊都是嚴選人才，服務最周到，翻譯高品質。相信后冠，品質保證。

				</div>
				<div class="in_body">
                <asp:Repeater ID="rep_english" runat="server">
                    <ItemTemplate>
                         <div class="tuandui">
                            <div class="tuandui_img"><img src="<%#Eval("imgpath").ToString().Trim().Equals("") ? "" : Eval("imgpath")%>" alt="醫學翻譯 英文" width="90"/></div>
                            <div class="tuandui_body">姓名： <%#Eval("tname").ToString().Trim().Equals("") ? "" : Eval("tname")%> </div>
                            <div class="tuandui_body">性別： <%#Eval("avater").ToString().Trim().Equals("") ? "" : Eval("avater").ToString() == "0" ? "男" : "女"%> </div>
                            <div class="tuandui_body">自我介紹：
                            <%#Eval("descript").ToString().Trim().Equals("") ? "" : Eval("descript")%></div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

                <div id="AspNetPager1">
                <webdiyer:aspnetpager id="AspNetPager2" runat="server" PageSize="6" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager2_PageChanged"></webdiyer:aspnetpager>
                </div>


				</div>




				</div>

                
            </div> <!-- end primaryContent -->
            
           </form>
             
		       
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

