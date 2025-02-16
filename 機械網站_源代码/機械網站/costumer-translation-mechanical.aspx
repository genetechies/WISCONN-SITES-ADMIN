<%@ Page Language="C#" AutoEventWireup="true" CodeFile="costumer-translation-mechanical.aspx.cs" Inherits="costumer_translation_mechanical" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>我們的客戶遍佈全世界─專業優質手冊翻譯的工業翻譯社</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠工業翻譯的專業與熱情為我們贏得忠實的客戶群，在與客戶的合作交流中，我們逐步完善自身，增強實力，不斷有新客戶變成我們的老客戶，讓后冠更進一步，成為更加專業優秀的手冊翻譯社！"/>
<meta name="keywords" content="工業翻譯,手冊翻譯"/>
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
<body>
<form runat="server" id="form1">
<div id="container">
<!-- header -->
<div id="header">
    <!-- logo -->
            <div id="logo"><a href="index-translation-mechanical.aspx" title="首頁"><img src="images/logo2.png" alt="工業翻譯社" class="png" /></a></div>
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
			<div class="bannerfloat"><img src="images/costumer_banner.jpg" alt="工業翻譯 "/></div>
			<div class="bannerTextArea">有了客戶的支持與鼓勵才能成就優質的工業翻譯社。</div>
	    </div>
	    
	    <div class="content_con2">

	    <!-- left side content -->
	    <div class="content sub">
			<div class="contentTitle">
			 <img class="box_icon" src="images/box_icon.png" alt="手冊翻譯"/>
             <h4>客戶實績</h4>
			</div>
			 <div class="contentarea">
			 		<ul>
						<li class="bigimgarea">
							<img src="images/about_big_box_top.jpg" alt="工業翻譯"/>
							<img src="images/costumer_pic1.jpg" alt="工業翻譯"  class="image portfolio preload"/>
							<img src="images/about_big_box_bottom.jpg" alt="工業翻譯"/>
						</li>
						<li class="textarea">
								<div class="textcontent">后冠翻譯以獨具特色的機械翻譯服務贏得眾多客戶口碑，遍佈全球的客戶群體是我們專業的有力證明。擁有他們的支持，我們堅信后冠會越來越好，后冠仍不斷努力，成為更加專業優秀的工業翻譯社！</div>
						</li>
					</ul>
			 </div>
			 <div class="contentarea">
					<div class="ourteamarea">
						<img src="images/ourteam_box_top.jpg" alt="手冊翻譯" />
						<div class="ourteamtextarea">
                            <%
      string gid = "";
      if (Request.QueryString["gid"]!=null)
      {
          gid = "guoclassid=" + Request.QueryString["gid"].ToString();
      }
      System.Data.DataSet dslog = new BLL.guopic().GetList(gid);
                            for (int i = 0; i < dslog.Tables[0].Rows.Count; i++)
                            {
                                if (i%4==0)
                                {%>
                                <ul style="padding:0px">
		                        <li class="costumerlogo">
                                    <div class="costumeraera">
								        <div class="costumer_logoarea"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" class="costumer_logo"/></div>
								        <div class="costumer_logotext"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div>
							        </div>
		                        </li>

                                <%}
                                else if ((i + 1) % 4 == 0)
                                {%>                                    
		<li class="costumerlogo">
                                    <div class="costumeraera">
								        <div class="costumer_logoarea"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" class="costumer_logo"/></div>
								        <div class="costumer_logotext"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div>
							        </div>
		                        </li></ul>
                                <% }
                                else {%>
                                    <li class="costumerlogo">
                                    <div class="costumeraera">
								        <div class="costumer_logoarea"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" class="costumer_logo" /></div>
								        <div class="costumer_logotext"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></div>
							        </div>
		                        </li>
                                <% } %>
                           <% }
                         %>

							<%--<ul>
								<li class="costumerlogo">
									<div class="costumeraera">
										<ul class="costumer_logoarea"><img src="images/customer_logo.jpg" class="costumer_logo"/></ul>
										<ul class="costumer_logotext">Microchip Technology</ul>
									</div>
								</li>
								<li class="costumerlogo">
									<div class="costumeraera">
										<ul class="costumer_logoarea"><img src="images/customer_logo.jpg" class="costumer_logo"/></ul>
										<ul class="costumer_logotext">Microchip Technology</ul>
									</div>
								</li>
								<li class="costumerlogo">
									<div class="costumeraera">
										<ul class="costumer_logoarea"><img src="images/customer_logo.jpg" class="costumer_logo"/></ul>
										<ul class="costumer_logotext">Microchip Technology</ul>
									</div>
								</li>
								<li class="costumerlogo">
									<div class="costumeraera">
										<ul class="costumer_logoarea"><img src="images/customer_logo.jpg" class="costumer_logo"/></ul>
										<ul class="costumer_logotext">Microchip Technology</ul>
									</div>
								</li>
							</ul>--%>
						</div>
						<img src="images/ourteam_box_bottom.jpg" alt="手冊翻譯"/>
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
                                         <li><a href="costumer-translation-mechanical.aspx?gid=<%=dsleft.Tables[0].Rows[i]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>                                     
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
							<img src="images/about_box_top.jpg" alt=""/>
							<!--google地图码 -->
							<div class="googlemap">
							<iframe width="208" height="209" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com.tw/maps?f=q&amp;source=s_q&amp;hl=zh-TW&amp;geocode=&amp;q=%E8%87%BA%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;aq=&amp;sll=23.48575,119.49965&amp;sspn=6.60714,11.634521&amp;brcurrent=3,0x3442a93f510c7ba1:0x731637f5caca2004,0,0x3442ac6b61dbbd9d:0xc0c243da98cba64b&amp;ie=UTF8&amp;hq=&amp;hnear=104%E5%8F%B0%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;ll=25.060218,121.527948&amp;spn=0.006376,0.011362&amp;t=m&amp;z=14&amp;output=embed"></iframe>
							</div>
							<!-- /google地图码 -->
							<img src="images/about_box_bottom.jpg" alt=""/>
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
