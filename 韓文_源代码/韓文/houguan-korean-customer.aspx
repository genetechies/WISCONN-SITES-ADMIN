<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houguan-korean-customer.aspx.cs" Inherits="houguan_korean_customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta content="text/html;charset=utf-8" http-equiv="content-type" />
		<meta name="description" content="后冠韓文翻譯憑藉優秀的翻譯品質和合理的翻譯價格，成功積累了一批又一批的舊客戶。我們以多年的客戶實績，以及超越行業的翻譯水準向廣大客戶展現了一個不一樣的韓文翻譯公司。后冠希望，能夠借此做受客戶推薦的韓文翻譯公司。" />
		<meta name="keywords" content="韓文翻譯 推薦、韓文翻譯 價格" />
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
		<link rel="shortcut icon" href="images/HG.png" type="image/x-icon" />
		<link rel="stylesheet" href="css/style.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/styles/fonts.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/styles/retina.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700"  type="text/css"/>
		<link rel="stylesheet" href="css/styles/jquery.prettyPhoto.css" type="text/css" media="screen" />
		<link rel="stylesheet" type="text/css" href="styleChanger/changer.css" />
		<link rel="stylesheet" type="text/css" href="styleChanger/colorpicker/colorpicker.css" />
		<style id="cFontStyleWColor1" type="text/css">
			a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-header .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {color:rgba(255, 255, 255, .4);}
		</style>
		<style id="cFontStyleWColor2" type="text/css">
			.widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-header .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {color:#fff4c1;}
		</style>
		<style id="cFontStyleWColor3" type="text/css">
			.cmsms_content_slider_parent ul.cmsms_slides_nav li a:hover, .cmsms_content_slider_parent ul.cmsms_slides_nav li.active a, #slide_top, .resp_navigation, .cmsms_comments:hover {background-color:#fff4c1;}
		</style>
		<style id="cFontStyleWColor4" type="text/css">
			input[type="text"]:focus, textarea:focus, select:focus, option, .post .cmsms_tags li a:hover:before, .related_posts_content a img {border-color:#fff4c1;}
		</style>
		<style id="cFontStyleWColor5" type="text/css">
			.pricingtable .price, .color2 {color:#f5a615;}
		</style>
		<style id="cFontStyleWColor6" type="text/css">
			span.dropcap2, .comment-reply-link, .button, .button_medium, .button_large, .cmsmsLike:hover, .cmsmsLike.active, .cmsms_plus_inner, a:hover span.image_rollover, .p_sort .button:hover, a.p_cat_filter:hover, .cmsms_post_img {background-color:#f5a615;}
		</style>
		<style id="cFontStyleWColor7" type="text/css">
			code {border-top-color:#f5a615;}
		</style>
		<style id="cFontStyleWColor8" type="text/css">
			body {background-color:#37261f;}
		</style>
		<script src="js/modernizr.custom.all.js" type="text/javascript"></script>
		<script src="js/respond.js" type="text/javascript"></script>
		<script src="js/jquery.min.js" type="text/javascript"></script>
		<script src="js/jquery.easing.js" type="text/javascript"></script>
		<!--[if lt IE 9]>
			<link rel="stylesheet" href="css/styles/ie.css" type="text/css" />
			<link rel="stylesheet" href="css/styles/ie_css3.css" type="text/css" media="screen" />
		<![endif]-->
		<title>后冠韓文翻譯—用價格和實績做最好的推薦</title>
	</head>
<body>
    <form id="form1" runat="server">
    
<!-- __________________________________________________ Start Page -->

		<div id="page">
			<a href="#" id="slide_top"></a>
<!-- __________________________________________________ Start Header -->

			<div id="header">
				<div class="header_inner">
					<a class="logo" href="houguan-korean-index.aspx" title="韓文翻譯公司"><img src="images/logo.png" width="211" alt="韓文翻譯" /></a>
                    <span style="position: absolute;left:33%; top:250px;color:#A6ABB1;">后冠韓文翻譯公司為廣大客戶提供可靠專業的翻譯,切實細心的服務</span>
					<div style="text-align:center">
						<ul id="navigation">
							<li class="current_page_item" style="margin-top:24px;"><a href="houguan-korean-index.aspx" title="首頁 홈페이지"><span style="background-color:#fa2b31;">首頁 홈페이지</span></a></li>
							<li class="drop" style="margin-top:80px;"><a href="houguan-korean-about.html" title="公司簡介 회사소개"><span style="background-color:#eb6621;">公司簡介 회사소개</span></a></li>
							<li class="drop" style="margin-top:15px;"><a href="houguan-korean-service-type.html"><span style="background-color:#f5a615;">服務項目 서비스 분야</span></a>
								<ul>
									<li><a href="houguan-korean-service-type.html" title="翻譯類型 통번역 분야"><span>翻譯類型 통번역 분야</span></a></li>
									<li><a href="houguan-korean-service-quality.html" title="品質流程 품질보장"><span>品質流程 품질보장</span></a></li>
									<li><a href="houguan-korean-service-contract.html" title="保密合約 비밀계약"><span>保密合約 비밀계약</span></a></li>
								</ul>
							</li>
							<li class="drop" style="margin-top:72px;"><a href="houguan-korean-language-chinese.html"><span style="background-color:#94c516;">翻譯語言 번역언어</span></a>
								<ul>
									<li><a href="houguan-korean-language-chinese.html" title="中韓互譯 중한 통,번역"><span>中韓互譯 중한 통,번역</span></a></li>
									<li><a href="houguan-korean-language-english.html" title="英韓互譯 영한 통,번역"><span>英韓互譯 영한 통,번역</span></a></li>
									<li><a href="houguan-korean-language.html" title="其他語言 기타 언어"><span>其他語言 기타 언어</span></a></li>
								</ul>
							</li>
							<li style="margin-top:22px;"><a href="houguan-korean-onlineprice.aspx" title="線上詢價"><span style="background-color:#00c481;">線上詢價 온라인 견적</span></a></li>
                            <li class="drop" style="margin-top:80px;"><a href="houguan-korean-contact.html" title="聯繫我們 연락방식"><span style="background-color:#eb6621;">聯繫我們 연락방식</span></a></li>
                            <li class="current_page_item" style="margin-top:24px;"><a href="houguan-korean-knowledge.html" title="韓文小知識 한국 지식"><span style="background-color:#fa2b31;">韓文小知識 한국 지식</span></a></li>
						</ul>
					</div>
					<div class="cl"></div>
				</div>
			</div>
<!-- __________________________________________________ Finish Header -->


<!-- __________________________________________________ Start Middle -->

			
			<div class="wrap_headline">
				<div class="headline">
					<h1>客戶實績</h1>
				</div>
			</div>
			<div class="container">			
				<div id="middle">
					<div class="middle_inner">
<!-- __________________________________________________ Start Content -->

						<div class="content_wrap sidebar_left">
							<div id="content" class="fr">
								<div class="entry">
									<h1>后冠韓文翻譯堅持提供經濟實惠的價格做廣受客戶推薦的翻譯社</h1>
                                    <p>市場是無限的，客源是無窮的。后冠韓文翻譯公司希望能夠憑藉傲人的客戶實績，爭取更多客戶的青睞與推薦！</p>
									<div id="middle_content">
                                        <div class="entry">
                                             <div class="ourtrem">
                                                 <ul class="ourtrem-ul">
                                                      <%
                                                    string gid = "";
                                                    if (Request.QueryString["gid"] != null)
                                                    {
                                                        gid = "guoclassid=" + Request.QueryString["gid"].ToString();
                                                    }
                                                    System.Data.DataSet dslog = new BLL.guopic().GetList(gid);
                                                for (int i = 0; i < dslog.Tables[0].Rows.Count; i++)
                                                {%>
                                                     <li style="width:160px;background:transparent;height:130px;">
                                                          <div class="img" style="width:150px;height:72px;"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" class="fullwidth" /></div>
                                                           <p class="tit" style="color:#EEE;background:transparent;"><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %></p>
            
                                                     </li>
                                                      
                                               <% }
                                             %>

                                                    
                                                </ul>
                                            </div>
                                            
                                                   
                                        </div>
                                    </div>
								</div>
							</div>
<!-- __________________________________________________ Finish Content -->		

<!-- __________________________________________________ Start Sidebar -->
					
							<div id="sidebar" class="fl">
								<div class="one_first">
									<div class="widget widget_custom_latest_popular_recent_entries">
										<h2 class="widgettitle"><img src="images/L-001.png" width="30" height="27" alt="韓文翻譯"/>后冠韓文翻譯社</h2>
										<div class="tab lpr">
											
											<div class="tab_content">
												<div class="tabs_tab" style="display: block;">
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
                                                         <li class="li1"><a href="houguan-korean-customer.aspx?gid=<%=dsleft.Tables[0].Rows[i]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                                          <%} %>
														
													</ul>
												</div>
											</div>
										</div>
									</div>
								</div>
								<div class="one_first">
									<div class="widget widget_custom_flickr_entries">
										<h2 class="widgettitle"><img src="images/L-001.png" width="30" height="27" alt="韓文翻譯"/>公司資訊</h2>
                                        <p style="line-height:22px;">電話：+886-2-2568-3677<br/>
傳真：+886-2-2568-3702<br/>
地址：台北市新生北路二段129-2號7F<br/>
翻譯服務信箱：<a ref="service@crowns.com.tw">service@crowns.com.tw</a><br/>后冠文化總公司：<a href="https://www.houguan-translation-services.com">https://www.houguan-translation-services.com</a><br/>
時間：週一至週五AM 9:00- PM 6:00</p>
										<script type="text/javascript">
										<!--
										    jQuery(document).ready(function () {
										        jQuery('#flickr_images').jflickrfeed({
										            limit: 6,
										            qstrings: {
										                id: '49053047@N04'
										            },
										            itemTemplate: '<li><a href="{{image_b}}"><img src="{{image_s}}" alt="{{title}}" /></a></li>'
										        });
										    });
										    -->
										</script>
									</div>
								</div>
							</div>
<!-- __________________________________________________ Finish Sidebar -->	

						</div>
					</div>
				</div>
<!-- __________________________________________________ Finish Middle -->



			</div>
		</div>
<!-- __________________________________________________ Finish Page -->


<!-- __________________________________________________ Start Footer -->

		<div id="footer">
			<div class="footer_inner">
            <ul class="social_list">
					<li><a href="houguan-korean-index.aspx" title="首頁">首頁　|</a></li>
					<li><a href="houguan-korean-about.html" title="公司簡介">公司簡介　|</a></li>
					<li><a href="houguan-korean-service.html" title="服務項目">服務項目　|</a></li>
					<li><a href="#" title="翻譯語言">翻譯語言　|</a></li>
					<li><a href="houguan-korean-onlineprice.aspx" title="線上詢價">線上詢價　|</a></li>
                    <li><a href="houguan-korean-contact.html" title="聯繫我們">聯繫我們　|</a></li>
                    <li><a href="houguan-korean-customer.aspx" title="客戶實績">客戶實績　|</a></li>
                    <li><a href="houguan-korean-payment.html" title="付款方式">付款方式　|</a></li>
                    <li><a href="houguan-korean-ourteam.aspx" title="翻譯團隊">翻譯團隊　|</a></li>
                    <li><a href="houguan-korean-information.aspx" title="翻譯資訊">翻譯資訊　|</a></li>
                    <li><a href="houguan-korean-knowledge.html" title="韓文小知識">韓文小知識 |</a></li> <li><a href="sitemap/sitemap.xml" title="sitemap">sitemap</a></li>
				</ul>
				<span>Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.        Tel:(02)2568-3677     Fax:(02)2568-3702      
台北市中山區新生北路二段129-2號7F    Inv:25125082</span>
			</div>
		</div>
<!-- __________________________________________________ Finish Footer -->

		<script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>
		<script src="js/jquery.script.js" type="text/javascript"></script>
		<script src="js/jquery.validationEngine.js" type="text/javascript"></script>
		<script src="js/jquery.validationEngine-lang.js" type="text/javascript"></script>
		<script src="js/jquery.jtweetsanywhere.js" type="text/javascript"></script>
		<script src="js/jquery.flickrfeed.min.js" type="text/javascript"></script>
		<script type="text/javascript" src="styleChanger/colorpicker/colorpicker.js"></script>
		<script type="text/javascript" src="styleChanger/changer.js"></script>
    </form>
</body>
</html>
