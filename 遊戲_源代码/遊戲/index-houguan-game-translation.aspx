<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index-houguan-game-translation.aspx.cs" Inherits="index_houguan_game_translation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html xmlns="http://www.w3.org/1999/xhtml">
	<head>

		<meta content="text/html;charset=utf-8" http-equiv="content-type" />
		<meta name="description" content="隨著網路的發展，越來越多人喜歡上網路遊戲，讓不同地域的人都能夠接觸、喜歡你的遊戲，就是遊戲翻譯的最終目的。后冠遊戲翻譯公司提供您最高的遊戲翻譯品質，讓您的遊戲吸引更多玩家。" />
		<meta name="keywords" content="遊戲翻譯,遊戲翻譯公司,遊戲翻譯社" />
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
		<link rel="icon" href="images/HG.png" type="image/ico" />
		<link rel="stylesheet" href="css/style.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/styles/fonts.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/styles/retina.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700"  type="text/css"/>
		<link rel="stylesheet" href="css/styles/jquery.prettyPhoto.css" type="text/css" media="screen" />
		<link rel="stylesheet" type="text/css" href="styleChanger/changer.css" />
		<link rel="stylesheet" type="text/css" href="styleChanger/colorpicker/colorpicker.css" />
		<style id="cFontStyleWColor1" type="text/css">
			a, .tab.lpr .tabs li a, .tab.lpr .tabs_tab strong, .sitemap > li ul > li ul li > a, .cms_archive li a, .post .entry-div .cmsms_post_info .published, #comments .comment-body .published, .project ul.project_details li div {color:rgba(255, 255, 255, .4);}
		</style>
		<style id="cFontStyleWColor2" type="text/css">
			.widget_portfolio_link, .portfolio_inner .entry-title a, .tour li a, .skill_item_colored_wrap > span span, .sitemap > li > a, .sitemap > li ul > li > a, ul.p_filter li a:hover, ul.p_filter li.current a, .post .entry-div .entry-title a:hover, .post .cmsms_more, .entry .project_navi span a, .related_posts_content .one_half p a, .tog, .tabs li a, #navigation li li.current_page_item > a, #navigation li li:hover > a:hover, #navigation ul li:hover > a {color:#fff4c1;}
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
		<script src="js/rollphotos.js" type="text/javascript"></script>
		
     <script type="text/javascript">
         $(document).ready(function () {

             $("#team").imgscroll({
                 speed: 40,
                 amount: 0,
                 width: 1,
                 dir: "left"
             });

             $("#client").imgscroll({
                 speed: 40,
                 amount: 0,
                 width: 1,
                 dir: "left"
             });

         });
    </script>
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
		<!--[if lt IE 9]>
			<link rel="stylesheet" href="css/styles/ie.css" type="text/css" />
			<link rel="stylesheet" href="css/styles/ie_css3.css" type="text/css" media="screen" />
		<![endif]-->
		<title>后冠翻譯公司—給您最好的遊戲翻譯</title>
	</head>
<body onload="IsPC();">
    <form id="form1" runat="server">
    <div id="page">
		<h1 style="height:0px;overflow:hidden">&nbsp;</h1>
			<a href="#" id="slide_top"></a>
<!-- __________________________________________________ Start div -->

	<div id="header">
				<div class="header_inner">
					<a class="logo"  href="index-houguan-game-translation.aspx"><span style="display:inline-block;position:relative;width:100%;">
                       <font style="color:#FFF;position:absolute;left:78px;top:34px;">遊戲翻譯是一項有趣的工作，需要翻譯人員有一顆會玩且懂翻譯的心！</font>
                        </span>
                    </a>

					<a class="resp_navigation" href="javascript:void(0);"><span></span></a>
					<div style="text-align:center">
							<ul id="navigation">
							<li class="current_page_item" style="margin-top:24px;"><a href="index-houguan-game-translation.aspx" title="首頁"><span style="background-color:#fa2b31;">首頁</span></a></li>
							<li class="drop" style="margin-top:80px;"><a href="about-houguan-game-translation.html" title="關於我們"><span style="background-color:#eb6621;">關於我們</span></a>
								<ul>
									<li><a href="about-quality-houguan-game-translation.html" title="母語翻譯"><span>品質管理</span></a>
										
									</li>
									<li><a href="about-native-houguan-game-translation.html" title="母語翻譯"><span>母語翻譯</span></a></li>
									
								</ul>
							</li>
							<li class="drop" style="margin-top:15px;"><a href="service-houguan-game-translation.html" title="服務項目"><span style="background-color:#f5a615;">服務項目</span></a>
								<ul>
									<li><a href="service-houguan-game-translation.html" title="遊戲翻譯介紹"><span>遊戲翻譯介紹</span></a>
										
									</li>
									<li><a href="service-process-houguan-game-translation.html" title="遊戲翻譯流程"><span>遊戲翻譯流程</span></a>
									
									</li>
									<li><a href="service-advantage-houguan-game-translation.html" title="遊戲翻譯優勢"><span>遊戲翻譯優勢</span></a>
									</li>
								</ul>
							</li>
						
							<li style="margin-top:72px;"><a href="onlineprice-houguan-game-translation.aspx" title="線上詢價"><span style="background-color:#00c481;">線上詢價</span></a></li>
		                    <li style="margin-top:22px;"><a title="聯繫我們" href="contact-houguan-game-translation.html"><span style="background-color:#94c516;">聯繫我們</span></a></li>
								
							
						</ul>
					</div>
					<div class="cl"></div>
				</div>
			</div>
<!-- __________________________________________________ Finish div -->

			<div class="container">
<!-- __________________________________________________ Start Top -->

				<div id="top">
				<h1 style="height:0px;overflow:hidden">&nbsp;</h1>
					<div class="top_inner">
						<ul id="slider" class="responsiveSlider">
							<li>
								<img src="images/img/bg_r-1.jpg"  alt="遊戲翻譯公司" title="遊戲翻譯"/>
								<div class="slider-text1-1">后冠翻譯社給妳最好的遊戲翻譯</div>
								<div class="slider-text1-2">隨著網路的發展，越來越多的人喜歡上網路遊戲，讓不同地域的人都能接、喜歡這款遊戲，就是遊戲翻譯的最終目地。我們會以最高的遊戲翻譯品質替您的遊戲吸引更多的玩家。</div>
							</li>
							<li>
								<img src="images/img/bg_r-2.jpg"  alt="遊戲翻譯" title="遊戲翻譯"/>
								<div class="slider-text2-1">遊戲是新時代的精神產物</div>
								<div class="slider-text2-2">遊戲是新時代發展的產物，是人們的精神享受之一。遊戲玩家能夠從中放鬆精神，擺脫現實生活中的壓力。好的遊戲需要大家一起分享，而后冠翻譯社則為遊戲全球化做出了翻譯貢獻。</div>
							</li>
							<li>
								<img src="images/img/bg_r-3.jpg"  alt="遊戲翻譯公司" title="遊戲翻譯" />
								<div class="slider-text3-1">后冠翻譯社和遊戲的淵源</div>
								<div class="slider-text3-2">后冠翻譯社在遊戲翻譯領域擁有自己的成就和客戶群，客戶對后冠的長期支持，使后冠漸漸成為遊戲翻譯領域的領軍者，相信不久的將來后冠的足跡能夠遍布全球。</div>
							</li>
							<!--<li data-video="http://vimeo.com/15949725">
								<img src="images/img/bg_r-4.jpg" alt="遊戲翻譯" />
							</li>-->
						</ul>
					</div>
				</div>
<!-- __________________________________________________ Finish Top -->				
				
<!-- __________________________________________________ Start Middle -->
			
				<div id="middle"><h1 style="height:0px;overflow:hidden">&nbsp;</h1>
					<div class="middle_inner">
<!-- __________________________________________________ Start Top Sidebar -->

						<div id="top_sidebar"><h1 style="height:0px;overflow:hidden">&nbsp;</h1>
							<div class="one_first">
								<div class="widget widget_text">
									<div class="textwidget">
										<div class="post_type_shortcode">
											<h2 class="cms_title">
												相關資訊
										
											</h2>
											<script type="text/javascript">
											    jQuery(document).ready(function () {
											        jQuery('.post_type_list').cmsmsResponsiveContentSlider({
											            sliderWidth: '100%',
											            sliderHeight: 'auto',
											            animationSpeed: 500,
											            animationEffect: 'slide',
											            animationEasing: 'easeInOutExpo',
											            pauseTime: 0,
											            activeSlide: 1,
											            touchControls: true,
											            pauseOnHover: false,
											            arrowNavigation: false,
											            slidesNavigation: false
											        });
											    });
											</script>
											<ul class="post_type_list portfolio_container responsiveContentSlider">
												<li class="latest_item">
													<div class="portfolio hentry one_fourth">		
														<div class="portfolio_inner">
															<div>
																<a href="about-houguan-game-translation.html" class="preloader  class1"><img src="images/img/fproject_4_1.jpg" alt="遊戲翻譯公司" class="fullwidth" /></a>
															</div>
															<div class="entry-div">
																<h3 class="entry-title"><a href="about-houguan-game-translation.html" title="關於我們">關於我們</a></h3>
															</div>
															<div class="entry-meta">
																<ul class="cmsms_category">
																	<li>后冠翻譯社是一個……<a href="about-houguan-game-translation.html" title="更多資訊">更多資訊</a></li>
																	
																	
																</ul>
															</div>
															<div class="entry-content"></div>
														</div>
													</div>
													<div class="portfolio hentry one_fourth">
														<div class="portfolio_inner">
															<div>
																<a href="service-houguan-game-translation.html" class="preloader  class2"><img src="images/img/fproject_4_2.jpg"  alt="遊戲翻譯公司" title="遊戲翻譯" class="fullwidth" /></a>
															</div>
															<div class="entry-div">
																<h3 class="entry-title"><a href="service-houguan-game-translation.html" title="服務項目">服務項目</a></h3>
															</div>
															<div class="entry-meta">
																<ul class="cmsms_category">
																	<li>在遊戲翻譯服務中……<a href="service-houguan-game-translation.html" title="更多資訊">更多資訊</a></li>
																	
																</ul>
															</div>
															<div class="entry-content"></div>
														</div>
													</div>
													<div class="portfolio hentry one_fourth">
														<div class="portfolio_inner">
															<div>
																<a href="onlineprice-houguan-game-translation.aspx" class="preloader  class3"><img src="images/img/fproject_4_3.jpg"  alt="遊戲翻譯公司" title="遊戲翻譯" class="fullwidth" /></a>
															</div>
															<div class="entry-div">
																<h3 class="entry-title"><a href="onlineprice-houguan-game-translation.aspx" title="線上詢價">線上詢價</a></h3>
															</div>
															<div class="entry-meta">
																<ul class="cmsms_category">
																	<li>線上詢價不僅讓……<a href="onlineprice-houguan-game-translation.aspx" title="更多資訊">更多資訊</a></li>
																	
																</ul>
															</div>
															<div class="entry-content"></div>
														</div>
													</div>
													<div class="portfolio hentry one_fourth">
														<div class="portfolio_inner">
															<div>
																<a href="contact-houguan-game-translation.html" class="preloader  class4"><img src="images/img/fproject_4_4.jpg"  alt="遊戲翻譯" title="遊戲翻譯" class="fullwidth" /></a>
															</div>
															<div class="entry-div">
																<h3 class="entry-title"><a href="contact-houguan-game-translation.html" title="聯繫我們">聯繫我們</a></h3>
															</div>
															<div class="entry-meta">
																<ul class="cmsms_category">
																	<li>我們一直在努力完善……<a href="contact-houguan-game-translation.html" title="更多資訊">更多資訊</a></li>
																	
																</ul>
															</div>
															<div class="entry-content"></div>
														</div>
													</div>
												</li>
												
											</ul>
										</div>
									</div>
								</div>
							</div>
						</div>
<!-- __________________________________________________ Finish Top Sidebar -->

<!-- __________________________________________________ Start Content -->

 
						<div id="middle_content"><h1 style="height:0px;overflow:hidden">&nbsp;</h1>
							<div class="entry">
								<div class="one_third">
									<h2>翻譯資訊</h2>
									
                                        <div class="comment-body">
                                          
                                            <ul class="comment-content"><li style="display:none"></li>
                                            <asp:Repeater ID="rpt_nlist" runat="server">
                                            <ItemTemplate>
                                                <li style="margin:5px 0;"><a href="detailed-houguan-game-translation.aspx?id=<%# Eval("D_Id") %>" title="<%# Eval("D_Title") %>"><%# Eval("D_Title").ToString().Length < 12 ? Eval("D_Title") : Eval("D_Title").ToString().Substring(0, 11) + "..."%></a></li>
                                            </ItemTemplate>
                                            </asp:Repeater>
                                               <%--<li style="margin:5x 0;"><a href="" title="翻譯資訊">翻譯資訊翻譯資訊翻譯資訊翻譯</a></li>--%>
                                            </ul>
                                            <a href="information-houguan-game-translation.aspx" style="float:right;font-size:13px;" class="cmsms-edit fl"><b>MORE</b></a>
                                            <div style="clear:both;height:0px;line-height:0px;"></div>
                                        </div>
                                   
                                       
                                            
                                            
                                    
								</div>
								<div class="one_third_two">
									
								<div id="comments">
									<h2>翻譯團隊</h2>
									<ol class="commentlist">
										<li>
											<div class="comment-body">
														
												<div class="comment-content">
										<div id="team">
                            <ul><li style="display:none"></li>
                                <asp:Repeater ID="rpt_list" runat="server">
                                <ItemTemplate>
                                    <li>
                                    <a href="javascript:void(0)" title="<%#Eval("tname").ToString().Trim().Equals("") ? "" : Eval("tname")%>"><img src="<%#Eval("imgpath").ToString().Trim().Equals("") ? "" : Eval("imgpath")%>" style="width:100px;height:100px;" alt="遊戲翻譯公司"/></a>
                                    <span><%#Eval("tname").ToString().Trim().Equals("") ? "" : Eval("tname")%></span>
                                </li>
                                </ItemTemplate>
                                </asp:Repeater>
                                
                                <%--<li>
                                    <a href="#" title="遊戲翻譯"><img src="uploadfile/20132114749202.jpg" style="width:100px;height:100px;"  alt="遊戲翻譯" title="遊戲翻譯" /></a>
                                    <span>團隊</span>
                                </li>--%>
                            </ul>
                        </div>

														</div>
														
														
													</div>
												
												</li>
											
											</ol>
								         
											

										                                                            </div>
                                                                                               
                                                            	                               
								                                                            </div>

								
							</div>
						</div>
<!-- __________________________________________________ Finish Content -->
                       <div id="div_content"><h1 style="height:0px;overflow:hidden">&nbsp;</h1>
							<div class="entry">
								<div>









									<h1>友情連結</h1>
                                    <div class="comment-body">
                                          
                                   <div id="link_list_box"><div>

<div style="width:872px; margin:0 auto;">
<!--#include file="newspages/downindex.html"-->
</div>
</div>

</div><script type="text/javascript">
<!--
          var baseRows = 3;
          function showOrHidden(obj, height) {
              if (obj.clientHeight < height) {
                  obj.style.height = (parseInt(obj.style.height.replace("px", "") || obj.clientHeight) + 1) + "px";
                  if (obj.clientHeight >= height) return;
              } else {
                  obj.style.height = (parseInt(obj.style.height.replace("px", "") || obj.clientHeight) - 1) + "px";
                  if (obj.clientHeight <= height) return;
              }
              setTimeout(function () { showOrHidden(obj, height); }, 5);
          }
          function setHiddenLink() {
              var ele = document.getElementById("link_list_box").children, di = null, baseHeight = 0;
              for (var i = 0; i < ele.length; i++) {
                  di = ele[i].children[ele[i].children.length - 1]; baseHeight = 0;
                  if (di.children[0].rows.length <= baseRows) break;
                  baseHeight = di.children[0].rows[baseRows].cells[0].offsetTop - 1;
                  if (baseHeight <= 0) { window.setTimeout(setHiddenLink, 5); return; }
                  di.style.overflow = "hidden"; di.style.height = baseHeight + "px";
                  var clickEvent = (function (di, bh) {
                      return function () {
                          if (di.scrollHeight > di.clientHeight) showOrHidden(di, di.scrollHeight);
                          else showOrHidden(di, bh);
                      };
                  })(di, baseHeight);
                  if (di.addEventListener) {
                      di.addEventListener("click", clickEvent, false);
                  } else if (di.attachEvent) {
                      di.attachEvent("onclick", clickEvent);
                  } else di.onclick = clickEvent;
              }
          }
          setHiddenLink("link_index");
         --> 
</script>
                                       
                                      <div class="cl"></div>
                                        </div>
								
								</div>
								
								
							</div>
						</div>
					</div>
				</div>
<!-- __________________________________________________ Finish Middle -->


<!-- __________________________________________________ Start Bottom -->

					
<!-- __________________________________________________ Finish Bottom -->

			</div>
		</div>
<!-- __________________________________________________ Finish Page -->


<!-- __________________________________________________ Start div -->
                     
		<div id="footer">
           <div  class="footer_menu">
               <ul>
                   <li><a href="index-houguan-game-translation.aspx" class="link_tooltip" title="首頁">首頁</a><span>|</span></li>
                   <li><a href="about-houguan-game-translation.html" class="link_tooltip" title="關於我們">關於我們</a><span>|</span></li>
                   <li><a href="service-houguan-game-translation.html" class="link_tooltip" title="服務項目">服務項目</a><span>|</span></li>
                   <li><a href="team-houguan-game-translation.aspx" class="link_tooltip" title="翻譯團隊">翻譯團隊</a><span>|</span></li>
                    <li><a href="customer-houguan-game-translation.aspx" class="link_tooltip" title="客戶實績">客戶實績</a><span>|</span></li>  
                   <li><a href="information-houguan-game-translation.aspx" class="link_tooltip" title="翻譯資訊">翻譯資訊</a><span>|</span></li>
                   <li><a href="service-technique-houguan-game-translation.html" class="link_tooltip" title="翻譯技術">翻譯技術</a><span>|</span></li>
                     <li><a href="link-houguan-game-translation.aspx" class="link_tooltip" title="友情連結">友情連結</a><span>|</span></li>
                   <li><a href="onlineprice-houguan-game-translation.aspx" class="link_tooltip" title="線上詢價">線上詢價</a><span>|</span></li>
                   <li><a href="contact-houguan-game-translation.html" class="link_tooltip" title="聯繫我們">聯繫我們</a><span>|</span></li><li><a href="sitemap/sitemap.xml" class="link_tooltip" title="sitemap">sitemap</a></li>
                 




                </ul>
            
          </div>
           
            <div class="footer_menu">Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.&nbsp;&nbsp;&nbsp;Tel:(02)2568-3677     Fax:(02)2568-3702&nbsp;&nbsp;&nbsp;台北市中山區新生北路二段129-2號7F &nbsp;&nbsp;&nbsp; Inv:25125082</div>
			
		</div>

        <script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>
		<script src="js/jquery.script.js" type="text/javascript"></script>
		<script src="js/jquery.validationEngine.js" type="text/javascript"></script>
		<script src="js/jquery.validationEngine-lang.js" type="text/javascript"></script>
		<script src="js/jquery.jtweetsanywhere.js" type="text/javascript"></script>
		<script src="js/jquery.cmsmsResponsiveSlider.min.js" type="text/javascript"></script>
		<script type="text/javascript">
		    jQuery(document).ready(function () {
		        jQuery('#slider').cmsmsResponsiveSlider({
		            animationSpeed: 500,
		            animationEffect: 'fadeSlide',
		            animationEasing: 'easeInOutExpo',
		            pauseTime: 7000,
		            activeSlide: 1,
		            buttonControls: false,
		            touchControls: true,
		            pauseOnHover: false,
		            showCaptions: true,
		            arrowNavigation: true,
		            arrowNavigationHover: false,
		            slidesNavigation: true,
		            slidesNavigationHover: false,
		            showTimer: false,
		            timerHover: false
		        });
		    });
		</script>
    </form>
</body>
</html>
