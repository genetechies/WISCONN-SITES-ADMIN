<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houguan-korean-onlineprice.aspx.cs" Inherits="houguan_korean_onlineprice" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
	<head id="Head1" runat="server">
		<meta content="text/html;charset=utf-8" http-equiv="content-type" />
		<meta name="description" content="后冠韓文翻譯社成立於台灣台北，目前設立的據點遍佈全球各地，包括香港、加拿大、澳門、新加坡、美國等地，從事全球翻譯服務，為全球客戶提供各類翻譯幫助，及提供最合理的翻譯價位。" />
		<meta name="keywords" content="韓文翻譯 價位" />
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1" />
		<link rel="shortcut icon" href="images/HG.png" type="image/x-icon" />
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
		<title>后冠韓文翻譯社—立足台北，跨足世界 ，提供最合理的韓文翻譯價位</title>
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
                $("#posttime").datepicker({ changeMonth: true, changeYear: true, dateFormat: 'yy-mm-dd', showOtherMonths: true,
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
					<h1>線上詢價</h1>
				</div>
			</div>
			<div class="container">			
				<div id="middle">
					<div class="middle_inner">
<!-- __________________________________________________ Start Content -->

						<div class="content_wrap sidebar_left">
							<div id="content" class="fr">
								<div class="entry">
									<h1>后冠韓文翻譯能夠提供簡單快捷的線上詢價方式，方便客戶瞭解韓文翻譯的價位</h1>
									<div class="main_right">
    <div class="main_right_body"> 
    <form action="#" name="myform">

        <table style="border:none;padding:0px;margin:0px;width:680px">
        <tbody><tr>
                <td colspan="1" style="width: 32px; height: 20px;vertical-align:top">
                </td>
                <td colspan="5" style="width:730px;height: 20px;vertical-align:top">
                    &nbsp;<span class="font04" style="display: inline">此系統可以讓您的檔傳至我們的客服人員手中，請填好下列資料，並夾帶檔案，后冠收到後會迅速為您服務！<br/>
                    </span></td>
            </tr>
            <tr>
                <td colspan="1" style="width: 32px; height: 20px" >
                </td>
                <td colspan="5" style="width:730px;height: 20px">
                    
                    <span class="font04" style="display:inline; padding-left:10px;">基本資料</span></td>
            </tr>
            <tr>
                <td style="width: 32px;height:20px;" >
                </td>
                <td style="width: 120px;height:20px;">
                    <span class="font03" style="display: inline;padding-left: 20px;">聯絡人</span></td>
                <td class="font03" colspan="4" style="width:565px;">
                    <span class="font02">
                        <input type="text" name="username"  id="username" runat="server" value="" size="30"> *</span></td>
            </tr>
            <tr>
                <td style="width: 32px;height:20px;" >
                </td>
                <td style="width: 120px;height:20px;">
                    <span class="font03" style="display: inline;padding-left: 20px;">聯絡電話</span></td>
                <td class="font03" colspan="4"  style="width:565px;">
                    <span class="font02">
                        <input id="tel" runat="server" type="text" name="llr" value="" size="30">
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px; height: 22px;" >
                </td>
                <td  style="width: 213px; height: 22px;">
                    <span class="font03" style="display: inline;padding-left: 20px;">聯絡郵件</span></td>
                <td class="font03" colspan="4" style="height: 22px;width:565px;">
                    <span class="font02">
                        <input id="email" runat="server" type="text" name="llr" value="" size="30"> *</span></td>
            </tr>
            <tr>
                <td colspan="1" style="width: 32px; height: 20px;vertical-align:top">
                </td>
                <td colspan="5" style="width:730px;height: 20px;vertical-align:top;">
                    <br/>
                    <span class="font04" style="display: inline">以下請盡量提供以利給予您準確的報價：</span></td>
            </tr>
            <tr>
                <td style="width: 32px;height:20px;" >
                </td>
                <td style="width: 120px;height:20px;">
                    <span class="font03" style="display: inline;padding-left: 20px;">服務項目</span></td>
                <td class="font03" colspan="4" style="width:565px;">
                    <span class="font02">
                        <asp:DropDownList ID="ddltranslationskill" runat="server" style=" width:180px;">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                    <asp:ListItem Value="1">口譯</asp:ListItem>
                                                    <asp:ListItem Value="2">筆譯</asp:ListItem>
                                                    <asp:ListItem Value="3">公證文書</asp:ListItem>
                                                    <asp:ListItem Value="2">網頁翻譯</asp:ListItem>
                                                    <asp:ListItem Value="3">軟體翻譯</asp:ListItem>
                                                </asp:DropDownList>
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px;height:20px;">
                </td>
                <td style="width: 150px;height:20px;">
                    <span class="font03" style="padding-left: 20px;">原始語種(從)</span></td>
                <td style="width: 164px;height:20px;">
                    <span class="font02">
                    <asp:DropDownList ID="ddllanguagefrom" runat="server" style="width:93px;">
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

                    </span>
                </td>
                <td class="style1" style="height:20px;">
                </td>
                <td style="width: 140px;height:20px;">
                    <span class="font03" style="padding-left: 20px;">目地語言(翻譯成)</span></td>
                <td style="height:20px;">
                    &nbsp;<span class="font02"><asp:DropDownList ID="ddllanguageto" runat="server" Width="95px">
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
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px;height:20px;">
                </td>
                <td style="width: 120px;height:20px;">
                    <span class="font03" style="padding-left: 20px;">估計頁數或字數</span></td>
                <td style="width: 190px;height:20px;">
                    <span class="font02">
                        <input id="translationamount" runat="server" type="text" name="llr" value="" size="12">
<asp:DropDownList ID="ddltranslationtype" runat="server" Width="60px">
                                                                <asp:ListItem Value="字">字</asp:ListItem>
                                                                <asp:ListItem Value="頁">頁</asp:ListItem>
                                                            </asp:DropDownList>
                    &nbsp;*</span></td>
                <td class="style1" style="height:20px;">
                </td>
                <td style="width: 109px;height:20px;">
                    <span class="font03" style="padding-left: 20px;">是否需要排版</span></td>
                <td style="height:20px;">
                    &nbsp;<span class="font02"><asp:RadioButton ID="rty" runat="server" Checked="true" GroupName="rtypesetting" Text="" />&nbsp;&nbsp;是<asp:RadioButton ID="rtn" runat="server" GroupName="rtypesetting" Text="" />&nbsp;&nbsp;否
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px;height:20px;">
                </td>
                <td  style="width: 120px;height:20px;">
                    <span class="font03" style="padding-left: 20px;">是否需要二次校稿</span></td>
                <td  style="height:20px;">
                    &nbsp;<span class="font02"><asp:RadioButton ID="rpy" runat="server" Checked="true" GroupName="rproofreading"
                            Text="" />&nbsp;&nbsp;是<asp:RadioButton ID="rpn" runat="server" GroupName="rproofreading" Text="" />&nbsp;&nbsp;否
                    </span>
                </td>
                <td class="style1" style="height:20px">
                </td>
                <td style="width: 109px;height:20px;">
                    <span class="font03" style="padding-left: 20px;">是否需要潤稿</span></td>
                <td style="height:20px;">
                    &nbsp;<span class="font02"><asp:RadioButton ID="rdy" runat="server" Checked="true"
                        GroupName="rdraft" Text="" />&nbsp;&nbsp;是<asp:RadioButton ID="rdn" runat="server" GroupName="rdraft"
                            Text="" />&nbsp;&nbsp;否
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px; height: 20px;">
                </td>
                <td style="width: 213px; height: 20px;">
                    <span class="font03" style="padding-left: 20px;">交件時間</span></td>
                <td style="width: 164px; height: 20px;">
                    <span class="font02">
                        <input name="posttime" runat="server" type="text" id="posttime"/>
         *</span></td>
                <td class="style2">
                </td>
                <td style="width: 109px; height: 20px;">
                    <span class="font03" style="padding-left: 20px;">工作日</span></td>
                <td style="height: 20px">
                    &nbsp;<span class="font02"><input id="updays" runat="server" type="text" name="llr" size="10">
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px">
                </td>
                <td style="width: 120px">
                    <span class="font03" style="display: inline;padding-left: 20px;">專案注意事項</span></td>
                <td class="font03" colspan="4" style="width:565px"> 
                    <span class="font02">
                        <asp:TextBox ID="ttbNotes" style="width:516px;height:120px;border:1px solid #ccc;margin-left:6px;margin-top:5px;" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="483px"></asp:TextBox>
                    </span>
                </td>
            </tr>
            <tr>
                <td colspan="1" style="width:40px; height:20px;" >
                </td>
                <td colspan="5" style="width:730px; height:20px;">
                    <br/>
                    <span class="font04" style="display: inline">上傳相關文件資料：</span> <span class="font03" style="display: inline">上傳檔案（限制檔案大小10 MB；格式：Office文件、圖片檔、pdf、rar、zip)</span></td>
            </tr>
            <tr>
                <td  colspan="1" style="text-align:center;width: 32px; height: 22px; margin-top:5px;">
                </td>
                <td colspan="5" style="height: 22px; margin-top:5px;">
                    <span class="font02">
                        <asp:FileUpload ID="file1" runat="server" Width="606px" />
                    </span>
                </td>
            </tr>

            <tr>
                <td  colspan="1" style="text-align:center;width: 32px; height: 22px; margin-top:5px;">
                </td>
                <td colspan="5" style="height: 22px; margin-top:5px;">
                   <div style="display:none;" runat="server" id="codetr">													
                        <label>驗證碼</label><input type="text" value="" runat="server" style=" width:50px;" id="txtCode" />
                        <img alt="Unclear？Click to get" id="Img" title="Unclear？Click to get" src="Common/ValidateCode.aspx" onclick="javascript:this.src = 'Common/ValidateCode.aspx?' + Math.random();" style="border-width: 0px; vertical-align: bottom; cursor: pointer;"/>                                                                        
					</div>
                </td>
            </tr>

            <tr>
                <td colspan="1" style="width: 32px; height: 24px;text-align:center;">
                </td>
                <td colspan="5" style="height: 24px;text-align:center;">
                    <span class="font02">
                        <asp:LinkButton ID="btnSubmit" class="button" OnClick="btnSubmit_Click" OnClientClick="return verifyInput(this.form)" runat="server">確定送出</asp:LinkButton>&nbsp;&nbsp;<asp:LinkButton ID="btnReset" class="button" OnClick="btnReset_Click" runat="server">重新填寫</asp:LinkButton>
                    </span>
                </td>
            </tr>
        </tbody></table>
    </form>
<br/><br/><br/>
    </div>
  </div>
								</div>
							</div>
<!-- __________________________________________________ Finish Content -->		

<!-- __________________________________________________ Start Sidebar -->
					
							<div id="sidebar" class="fl">
								<div class="one_first">
									<div class="widget widget_custom_latest_popular_recent_entries">
										<h2 class="widgettitle"><img src="images/L-001.png" width="30" alt="韓文翻譯" height="27"/>后冠韓文翻譯社</h2>
										<div class="tab lpr">
											
											<div class="tab_content">
												<div class="tabs_tab" style="display: block;">
													<ul>
														<li><a href="houguan-korean-index.aspx" title="首頁 홈페이지">首頁 홈페이지</a></li>
                                                        <li><a href="houguan-korean-about.html" title="公司簡介 회사소개">公司簡介 회사소개</a></li>
                                                        <li><a href="houguan-korean-service.html" title="服務項目 서비스 분야">服務項目 서비스 분야</a></li>
                                                        <li><a href="#" title="翻譯語言 번역언어">翻譯語言 번역언어</a></li>
                                                        <li><a href="houguan-korean-onlineprice.aspx" title="線上詢價 온라인 견적">線上詢價 온라인 견적</a></li>
                                                        <li><a href="houguan-korean-contact.html" title="聯繫我們 연락방식">聯繫我們 연락방식</a></li>
                                                        <li><a href="houguan-korean-information.aspx" title="翻譯資訊 번역정보">翻譯資訊 번역정보</a></li>
													</ul>
												</div>
											</div>
										</div>
									</div>
								</div>
								<div class="one_first">
									<div class="widget widget_custom_flickr_entries">
										<h2 class="widgettitle"><img src="images/L-001.png" alt="韓文翻譯" width="30" height="27"/>公司資訊</h2>
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
				<span>Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.        Tel:(02)2568-3677     Fax:(02)2568-3702      
台北市中山區新生北路二段129-2號7F    Inv:25125082</span>
			</div>
		</div>
<!-- __________________________________________________ Finish Footer -->


    </form>
</body>
</html>

