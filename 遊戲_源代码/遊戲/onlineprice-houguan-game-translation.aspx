<%@ Page Language="C#" AutoEventWireup="true" CodeFile="onlineprice-houguan-game-translation.aspx.cs" Inherits="onlineprice_houguan_game_translation" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head>
		<meta content="text/html;charset=utf-8" http-equiv="content-type" />
		<meta name="description" content="線上諮詢遊戲翻譯的價格，不僅讓專員快速地服務，並能能夠讓客戶儘早知道具體的遊戲翻譯價格及價錢，且讓翻譯人員快速完成客戶交予的工作。" />
		<meta name="keywords" content="遊戲翻譯 價格,遊戲翻譯 價錢" />
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
		<link rel="icon" href="images/HG.png" type="image/ico" />
		<link rel="stylesheet" href="css/style.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/styles/fonts.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="css/styles/retina.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700"  type="text/css"/>
		<link rel="stylesheet" href="css/styles/jquery.prettyPhoto.css" type="text/css" media="screen" />
		<link rel="stylesheet" type="text/css" href="styleChanger/changer.css" />
		<link rel="stylesheet" type="text/css" href="styleChanger/colorpicker/colorpicker.css" />
        <link href="css/ui.theme.css" rel="stylesheet" type="text/css" />
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
			body {background-color:#ffffff;}
		</style>
		<script src="js/modernizr.custom.all.js" type="text/javascript"></script>
		<script src="js/respond.js" type="text/javascript"></script>
		<script src="js/jquery.min.js" type="text/javascript"></script>
		<script src="js/jquery.easing.js" type="text/javascript"></script>
		<!--[if lt IE 9]>
			<link rel="stylesheet" href="css/styles/ie.css" type="text/css" />
			<link rel="stylesheet" href="css/styles/ie_css3.css" type="text/css" media="screen" />
		<![endif]-->
		<title>后冠翻譯社—線上諮詢遊戲翻譯的優惠價格及價錢</title>	

        <script src="js/jquery.prettyPhoto.js" type="text/javascript"></script>
		<script src="js/jquery.script.js" type="text/javascript"></script>
		<script src="js/jquery.validationEngine.js" type="text/javascript"></script>
		<script src="js/jquery.validationEngine-lang.js" type="text/javascript"></script>
		<script src="js/jquery.jtweetsanywhere.js" type="text/javascript"></script>
		<script src="js/jquery.cmsmsResponsiveSlider.min.js" type="text/javascript"></script>
        <script type="text/javascript" src="js/ui.datepicker.js"></script>
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
        <script type="text/javascript">
            $(function () {
                $("#posttime").datepicker({
                    changeMonth: true, changeYear: true, dateFormat: 'yy-mm-dd', showOtherMonths: true,
                    onSelect: function (date) {
                        var d = new Date()
                        var vYear = d.getFullYear();
                        var vMon = d.getMonth() + 1;
                        var vDay = d.getDate();
                        var sDate = vYear + "-" + (vMon > 10 ? "0" + vMon : vMon) + "-" + (vDay > 10 ? vDay : "0" + vDay);
                        var iDay = DateDiff(date.toString(), sDate) + 1;

                        $("#updays").attr("value", iDay);
                    }
                });
            });

            function DateDiff(sDate1, sDate2) { //sDate1和sDate2是2002-12-18格式 
                var aDate, oDate1, oDate2, iDays;
                aDate = sDate1.split("-");
                oDate1 = new Date(aDate[1] + '-' + aDate[2] + '-' + aDate[0]);
                aDate = sDate2.split("-");
                oDate2 = new Date(aDate[1] + '-' + aDate[2] + '-' + aDate[0]);
                iDays = parseInt((oDate1 - oDate2) / 1000 / 60 / 60 / 24);
                return iDays;
            }

            function verifyInput(form) {
                if (form.username.value.length == 0) {
                    alert("請輸入聯絡人");
                    form.username.focus();
                    form.username.select();
                    return false;
                }
                else if (form.tel.value.length == 0) {
                    alert("請輸入聯絡電話!");
                    form.tel.focus();
                    form.tel.select();
                    return false;
                }
                else if (form.email.value.length == 0) {
                    alert("請輸入聯絡郵箱");
                    form.email.focus();
                    form.email.select();
                    return false;
                }
                return true;
            }

            var ImgArr1 = new Array();
            var ImgArr2 = new Array();
            ImgArr1[0] = "images/left_centerbu011.gif";
            ImgArr1[1] = "images/left_centerbu021.gif";

            ImgArr2[0] = "images/left_centerbu012.gif";
            ImgArr2[1] = "images/left_centerbu022.gif";

            function overChangeImg(o, vInt) {
                o.src = ImgArr2[vInt];
            }
            function outChangeImg(o, vInt) {
                o.src = ImgArr1[vInt];
            }

    </script>
	</head>
<body>
    <form id="form1" runat="server">
    <!-- __________________________________________________ Start Page -->

		<div id="page">
			<a href="#" id="slide_top"></a>
<!-- __________________________________________________ Start Header -->

<div id="header">
				<div class="header_inner">
		
                    <a class="logo"  href="index-houguan-game-translation.aspx"><span style="display:inline-block;position:relative;width:100%;">
                       <font style="color:#FFF;position:absolute;left:78px;top:34px;">線上諮詢價格─為客戶提供最便利的詢價途徑</font>
                        </span>
                    </a>
					<a class="resp_navigation" href="javascript:void(0);"><span></span></a>
					<div style="text-align:center">
							<ul id="navigation">
							<li class="current_page_item" style="margin-top:24px;"><a href="index-houguan-game-translation.aspx" title="首頁"><span style="background-color:#fa2b31;">首頁</span></a></li>
							<li class="drop" style="margin-top:80px;"><a href="about-houguan-game-translation.html" title="關於我們"><span style="background-color:#eb6621;">關於我們</span></a>
								<ul>
									<li><a href="about-quality-houguan-game-translation.html" title="品質管理"><span>品質管理</span></a>
										
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
		                    <li style="margin-top:22px;"><a href="contact-houguan-game-translation.html" title="聯繫我們"><span style="background-color:#94c516;">聯繫我們</span></a></li>
								
							
						</ul>
					</div>
					<div class="cl"></div>
				</div>
			</div>
<!-- __________________________________________________ Finish Header -->


<!-- __________________________________________________ Start Middle -->

			<!--<div class="wrap_cont_nav">
				<div class="cont_nav">
					<a href="../onlineprice-houguan-game-translation.aspx">線上詢價</a>
				</div>
			</div>-->
			<div class="wrap_headline">
				<div class="headline">
					<h2>線上詢價</h2>
				</div>
			</div>
			<div class="container">			
				<div id="middle">
					<div class="middle_inner">
<!-- __________________________________________________ Start Content -->

						<div id="middle_content">
							<div class="entry">
								<div class="one_third">

									
									  <div class="comment-body">
								 <div class="left-bg1"><br/>
								          <h2>免費試譯</h2>
								          <span>我們提供免費的試譯服務，讓您確認品質，並挑選喜愛的風格</span>
								       </div>
								       <div class="left-bg2"><br/>
								          <h2>專業優惠方案</h2>
								          <span>遊戲翻譯案件的字數較多時，我們提供優惠方案，讓您物超所值</span>
								       </div>
                                     </div>
                                   <div class="comment-body">
                                        <h1>聯繫我們</h1>
                                        <div class="tel">02-2568-3677</div>
                                       
                                         <div class="retstyle">
                                         <a href="../onlineprice-houguan-game-translation.aspx"  title="我要線上詢價" class="button"><span>我要線上詢價</span></a>
                                          <a href="../contact-houguan-game-translation.html"  title="聯繫我們" class="button"><span>聯繫我們</span></a>
                                        <!--<a href="../onlineprice-houguan-game-translation.aspx"><img src="../images/online.png" width="230"/></a><div class="breakline"></div>
                                          <a href="../contact/index-houguan-game-translation.aspx"><img src="../images/rel.png" width="230"/></a>-->
                                        </div>
                                     
								</div>
								</div></div>
								<div class="two_third">
										 
                                          
                                        <form action="#" name="myform">
											<h2>如果您想儘快獲得高品質、高效率、合理價位的翻譯服務，請聯繫我們吧！</h2>
<table style="width:100%;border:0px">
  <tr>
    <td colspan="2"><label for="username">聯絡人:&nbsp;&nbsp;&nbsp;&nbsp;</label><input type="text" name="llr" id="username" runat="server" value="" size="22" /></td>

  </tr>
  <tr>
    <td colspan="2"><label for="tel">聯絡電話:</label><input id="tel" runat="server" type="text" name="llr" value="" size="22" /></td>
 
  </tr>
  <tr>
    <td colspan="2"><label for="email">聯絡郵件:</label><input id="email" runat="server" type="text" name="llr" value="" size="22" /></td>

  </tr>
  <tr>
    <td colspan="2"><label for="email">服務專案:</label><asp:DropDownList ID="ddltranslationskill" runat="server" Width="60%">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                    <asp:ListItem Value="1">口譯</asp:ListItem>
                                                    <asp:ListItem Value="2">筆譯</asp:ListItem>
                                                    <asp:ListItem Value="3">公證文書</asp:ListItem>
                                                    <asp:ListItem Value="2">網頁翻譯</asp:ListItem>
                                                    <asp:ListItem Value="3">軟體翻譯</asp:ListItem>
                                                </asp:DropDownList></td>

  </tr>
  <tr>
    <td><label>原語言(從):</label>
    <asp:DropDownList ID="ddllanguagefrom" runat="server" Width="120px">
                                                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                            <asp:ListItem>英文</asp:ListItem>
                                                            <asp:ListItem>日文</asp:ListItem>
                                                            <asp:ListItem>繁中</asp:ListItem>
                                                            <asp:ListItem>簡中</asp:ListItem>
                                                            <asp:ListItem>韓文</asp:ListItem>
                                                            <asp:ListItem>菲文</asp:ListItem>
                                                            <asp:ListItem>德文</asp:ListItem>
                                                            <asp:ListItem>西文</asp:ListItem>
                                                            <asp:ListItem>法文</asp:ListItem>
                                                            <asp:ListItem>俄文</asp:ListItem>
                                                            <asp:ListItem>義文</asp:ListItem>
                                                            <asp:ListItem>葡文</asp:ListItem>
                                                            <asp:ListItem>荷文</asp:ListItem>
                                                            <asp:ListItem>波蘭</asp:ListItem>
                                                            <asp:ListItem>阿拉文</asp:ListItem>
                                                            <asp:ListItem>越文</asp:ListItem>
                                                            <asp:ListItem>泰文</asp:ListItem>
                                                            <asp:ListItem>馬來文</asp:ListItem>
                                                            <asp:ListItem>印尼文</asp:ListItem>
                                                            <asp:ListItem>其它</asp:ListItem>
                                                        </asp:DropDownList>
    </td>
    <td><label>目標語言(翻譯成):</label><asp:DropDownList ID="ddllanguageto" runat="server" Width="120px">
                                                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                            <asp:ListItem>英文</asp:ListItem>
                                                            <asp:ListItem>日文</asp:ListItem>
                                                            <asp:ListItem>繁中</asp:ListItem>
                                                            <asp:ListItem>簡中</asp:ListItem>
                                                            <asp:ListItem>韓文</asp:ListItem>
                                                            <asp:ListItem>菲文</asp:ListItem>
                                                            <asp:ListItem>德文</asp:ListItem>
                                                            <asp:ListItem>西文</asp:ListItem>
                                                            <asp:ListItem>法文</asp:ListItem>
                                                            <asp:ListItem>俄文</asp:ListItem>
                                                            <asp:ListItem>義文</asp:ListItem>
                                                            <asp:ListItem>葡文</asp:ListItem>
                                                            <asp:ListItem>荷文</asp:ListItem>
                                                            <asp:ListItem>波蘭</asp:ListItem>
                                                            <asp:ListItem>阿拉文</asp:ListItem>
                                                            <asp:ListItem>越文</asp:ListItem>
                                                            <asp:ListItem>泰文</asp:ListItem>
                                                            <asp:ListItem>馬來文</asp:ListItem>
                                                            <asp:ListItem>印尼文</asp:ListItem>
                                                            <asp:ListItem>其它</asp:ListItem>
                                                        </asp:DropDownList></td>
  </tr>
  <tr>
    <td><label for="translationamount">估計頁數或字數:</label><input id="translationamount" runat="server" type="text" name="llr" value="" style="width:120px" />
    <asp:DropDownList ID="ddltranslationtype" runat="server" Width="50px">
                                                                <asp:ListItem Value="字">字</asp:ListItem>
                                                                <asp:ListItem Value="頁">頁</asp:ListItem>
                                                            </asp:DropDownList></td>
    <td><div><label>是否需要排版:</label><asp:RadioButton ID="rty" runat="server" Checked="true" GroupName="rtypesetting" Text="" />&nbsp;&nbsp;是<asp:RadioButton ID="rtn" runat="server" GroupName="rtypesetting" Text="" />&nbsp;&nbsp;否</div></td>
  </tr>
  <tr>
    <td><label for="rpy">是否需要二次校稿:</label><asp:RadioButton ID="rpy" runat="server" Checked="true" GroupName="rproofreading"
                            Text="" />&nbsp;&nbsp;是<asp:RadioButton ID="rpn" runat="server" GroupName="rproofreading" Text="" />&nbsp;&nbsp;否</td>
    <td><label for="rpn">是否需要潤稿</label><asp:RadioButton ID="rdy" runat="server" Checked="true"
                        GroupName="rdraft" Text="" />&nbsp;&nbsp;是<asp:RadioButton ID="rdn" runat="server" GroupName="rdraft"
                            Text="" />&nbsp;&nbsp;否</td>
  </tr>
  <tr>
    <td><label for="posttime">希望交件時間:</label><input name="posttime" runat="server" type="text" id="posttime" size="10" /></td>
    <td><label for="updays"> 希望工作日:</label><input id="updays" runat="server" type="text" name="llr" size="10" /></td>
  </tr>
  <tr>
    <td colspan="2"><label>專案注意事項:</label><asp:TextBox ID="ttbNotes" style="width:616px;height:120px;border:1px solid #ccc;margin-left:6px;margin-top:5px;" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="483px"></asp:TextBox></td>
 
  </tr>
  <tr>
    <td colspan="2">上傳相關文件資料： 上傳檔案（限制檔案大小10 MB；格式：Office文件、圖片檔、pdf、
(rar、zip)</td>
   
  </tr>
  <tr>
    <td colspan="2"><asp:FileUpload ID="file1" runat="server" Width="606px" /></td>
 
  </tr>
  <tr>
    <td colspan="2"  style="display:none;" runat="server" id="codetr" ><div>													
                                                    <label>驗證碼</label><input type="text" value="" runat="server" style=" width:50px;" id="txtCode" />
                                                    <img alt="遊戲翻譯  價錢" id="Img" title="Unclear？Click to get" src="Common/ValidateCode.aspx" onclick="javascript:this.src = 'Common/ValidateCode.aspx?' + Math.random();" style="border-width: 0px; vertical-align: bottom; cursor: pointer;" />                                                                        
												</div></td>
 
  </tr>
  <tr>
    <td>&nbsp;</td>
    <td><asp:LinkButton ID="btnSubmit" class="button" OnClick="btnSubmit_Click" OnClientClick="return verifyInput(this.form)" runat="server">確定送出</asp:LinkButton>&nbsp;&nbsp;<asp:LinkButton ID="btnReset" class="button" OnClick="btnReset_Click" runat="server">重新填寫</asp:LinkButton></td>
  </tr>
</table>
</form>
                                 
								</div>
								
								
						</div>

<!-- __________________________________________________ Finish Content -->		

					</div>
				</div>
<!-- __________________________________________________ Finish Middle -->


<!-- __________________________________________________ Start Bottom -->


			</div>
		</div>
<!-- __________________________________________________ Finish Page -->


<!-- __________________________________________________ Start Footer -->
	<div id="footer">
           <div class="footer_menu">
                <ul class="socialmenu_list">
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
<!-- __________________________________________________ Finish Footer -->

		
    </form>
</body>
</html>

