<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ourteam-translation-mechanical.aspx.cs" Inherits="ourteam_translation_mechanical" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>優質英文翻譯、日文翻譯等操作手冊翻譯社的專業機械翻譯團隊</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="資深翻譯團隊是后冠的中堅力量，是我們翻譯工作的主力。后冠能成為優質的操作手冊翻譯社，都離不開這群資深英文、日文操作手冊翻譯團隊的努力與堅持！"/>
<meta name="keywords" content="操作手冊翻譯社,操作手冊 日文翻譯"/>
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

</head>
<body runat="server">
    <form  runat="server" id="form1">

<div id="container">
<!-- header -->
<div id="header">
    <!-- logo -->
            <div id="logo"><a href="index-translation-mechanical.aspx" title="首頁"><img src="images/logo2.png" alt="操作手冊 日文翻譯" class="png" /></a></div>
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
			<div class="bannerfloat"><img src="images/ourteam_banner.jpg" alt="操作手冊 日文翻譯 "/></div>
			<div class="bannerTextArea">優秀的英文、日文等操作手冊翻譯社團隊是后冠的驕傲，也是后冠高品質服務的保證！</div>
	    </div>
	    
	    <div class="content_con2">

	    <!-- left side content -->
	    <div class="content sub">
			<div class="contentTitle">
			 <img class="box_icon" src="images/box_icon.png" alt="操作手冊 英文翻譯"/>
             <h4>翻譯團隊</h4>
			</div>
			 <div class="contentarea">
			 		<ul>
						<li class="bigimgarea">
							<img src="images/about_big_box_top.jpg" alt="操作手冊 日文翻譯"/>
							<img src="images/ourteam_pic1.jpg" alt="操作手冊 日文翻譯"  class="image portfolio preload" />
							<img src="images/about_big_box_bottom.jpg" alt="操作手冊 日文翻譯"/>
						</li>
						<li class="textarea">
								<div class="textcontent">
								<p>后冠的機械翻譯團隊精英薈萃，擁有多語言如英文、日文等專業翻譯人才，他們在機械、操作手冊翻譯領域有著豐富的工作與翻譯經驗，是后冠翻譯品質與服務水準的有力保障，使后冠成為有口皆碑的操作手冊翻譯社。</p>
								<p>后冠承諾，我們的團隊是精英，我們的服務是周到，我們的翻譯是高品質。相信后冠，品質保證。</p>
								</div>
						</li>
					</ul>
			 </div>
			 <div class="contentarea">
					<div class="ourteamarea">
						<img src="images/ourteam_box_top.jpg" alt="操作手冊 英文翻譯" />
						<div class="ourteamtextarea">
                        <asp:Repeater ID="rep_english" runat="server">
                            <ItemTemplate>
                                 <div style=" border:1px solid #bfbfbf; width:240px; height:390px; margin:8px; float:left;">
                                    <img src="<%#Eval("imgpath").ToString().Trim().Equals("") ? "" : Eval("imgpath")%>" style=" margin-top:5px; width:198px; height:239px;" alt="操作手冊 英文翻譯"  class="image portfolio preload" />
                                    <div style=" margin:10px;">
                                    <h4>姓名:<%#Eval("tname").ToString().Trim().Equals("") ? "" : Eval("tname").ToString().Length > 6 ? Eval("tname").ToString().Substring(0, 6) : Eval("tname").ToString()%></h4>
							        <h4>性別:<%#Eval("avater").ToString().Trim().Equals("") ? "" : Eval("avater").ToString() == "0" ? "男" : "女"%></h4>
							        <h4>簡介:</h4>
							        <p style=" width:200px;"><%#Eval("descript").ToString().Trim().Equals("") ? "" : Eval("descript").ToString().Length > 45 ? Eval("descript").ToString().Substring(0, 45) : Eval("descript").ToString() %></p>
                                    </div>
                                </div>


                            </ItemTemplate>
                        </asp:Repeater>

                         									
						</div>
                        
						<img src="images/ourteam_box_bottom.jpg" alt="操作手冊 英文翻譯"/>
                        <div id="AspNetPager1">
<webdiyer:aspnetpager id="AspNetPager2" runat="server" AlwaysShow="false" PageSize="6" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager2_PageChanged"></webdiyer:aspnetpager>
</div>
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
                                         <li><a href="ourteam-translation-mechanical.aspx?gid=<%=dsleft.Tables[0].Rows[i]["NC_Id"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>                                     
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
							<img src="images/about_box_top.jpg" alt="操作手冊 英文翻譯"/>
							<!--google地图码 -->
							<div class="googlemap">
							<iframe width="208" height="209" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com.tw/maps?f=q&amp;source=s_q&amp;hl=zh-TW&amp;geocode=&amp;q=%E8%87%BA%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;aq=&amp;sll=23.48575,119.49965&amp;sspn=6.60714,11.634521&amp;brcurrent=3,0x3442a93f510c7ba1:0x731637f5caca2004,0,0x3442ac6b61dbbd9d:0xc0c243da98cba64b&amp;ie=UTF8&amp;hq=&amp;hnear=104%E5%8F%B0%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;ll=25.060218,121.527948&amp;spn=0.006376,0.011362&amp;t=m&amp;z=14&amp;output=embed"></iframe>
							</div>
							<!-- /google地图码 -->
							<img src="images/about_box_bottom.jpg" alt="操作手冊 英文翻譯"/>
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
    </form>
</body>
</html>
