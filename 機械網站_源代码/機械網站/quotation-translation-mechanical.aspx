<%@ Page Language="C#" AutoEventWireup="true" CodeFile="quotation-translation-mechanical.aspx.cs" Inherits="quotation_translation_mechanical" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>優質科技英文翻譯公司是您最好的選擇！</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠特別提供線上詢價服務，客戶可以直接將需要翻譯的檔上傳，我們將在收到諮詢後儘快回復給您優質的英文科技翻譯公司將是您最好地選擇！"/>
<meta name="keywords" content="英文科技翻譯、科技翻譯公司"/>
<link rel="stylesheet" type="text/css" href="css/style_other.css" />
<link rel="stylesheet" type="text/css" href="css/style_other_cf.css" />
<link rel="stylesheet" type="text/css" href="css/prettyPhoto.css" media="screen" />
        <link rel="icon" href="images/HG.png" type="image/ico" />
<link type="text/css" rel="stylesheet" href="css/ui.all.css"/>
<script type="text/javascript" src="js/jquery-1.3.2.min.js"></script>
<script type="text/javascript" src="js/jquery-ui-1.5.2.packed.js"></script>
<script type="text/javascript" src="js/jquery.easing.1.1.1.js"></script>
<script type="text/javascript" src="js/jquery.cycle.all.min.js"></script>
<script type="text/javascript" src="js/jquery.validate.js"></script>
<script type="text/javascript" src="js/jquery.prettyPhoto.js"></script>
<script type="text/javascript" src="js/script.js"></script>
<script type="text/javascript" src="js/ui.core.js"></script>
<script type="text/javascript" src="js/ui.datepicker.js"></script>
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

    $("#upfile").live('change', function () {
        $("#filepath").val($("#upfile").val());
    });

    $("#uploadbutton").live('click', function () {
        $("#upfile").click();
    });

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
            <div id="logo"><a href="index-translation-mechanical.aspx" title="首頁"><img src="images/logo2.png" alt="英文科技翻譯" class="png" /></a></div>
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
			<div class="bannerfloat"><img src="images/quotation_banner.jpg" alt="科技翻譯公司"/></div>
			<div class="bannerTextArea">專業科技翻譯公司─后冠提供線上服務，給客戶便捷的聯繫方式。</div>
	    </div>
	    
	    <div class="content_con2">

	    <!-- left side content -->
	    <div class="content sub">
			<div class="contentTitle">
			 <img class="box_icon" src="images/box_icon.png" alt="科技翻譯公司"/>
             <h4>線上詢價</h4>
			</div>
			 <div class="contentarea">
			 		<ul>
						<li class="bigimgarea">
							<img src="images/about_big_box_top.jpg" alt="英文科技翻譯"/>
							<img src="images/quotation_pic1.jpg" alt="科技翻譯公司"  class="image portfolio preload" />
							<img src="images/about_big_box_bottom.jpg" alt="英文科技翻譯"/>
						</li>
						<li class="textarea">
								<div class="textcontent">想快速瞭解相關資訊嗎？請留下資訊，科技翻譯公司的專業客服人員將盡速與您聯繫！</div>
						</li>
					</ul>
			 </div>
			 <div class="contentarea">
					<ul id="quotationarea">
						<li class="quotation_left">
							<div class="box_top" ><img src="images/quotation_small_box_top.jpg" alt="科技翻譯公司"/></div>
							<div>聯絡人：</div>
							<div class="left_textarea" ><input type="text" name="llr" id="username" runat="server" class="left_text"></div>
							<div>聯絡電話：</div>
							<div class="left_textarea" ><input id="tel" runat="server" type="text" name="lldh" class="left_text"></div>
							<div>聯絡郵件：</div>
							<div class="left_textarea" ><input id="email" runat="server" name="llmail" class="left_text"></div>
							<div>*或是您可以立即撥打電話與客服人員聯繫，我們將提供您最優質的服務！</div>
							<div class="box_bottom"><img src="images/quotation_small_box_bottom.jpg" alt="英文科技翻譯"/></div>
						</li>
						<li class="quotation_right">
							<div class="box_top" ><img src="images/quotation_big_box_top.jpg" alt="科技翻譯公司"/></div>
							<div>服務項目</div>
							<div class="right_textarea">
								<asp:DropDownList ID="ddltranslationskill" runat="server" Width="180px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                    <asp:ListItem Value="1">口譯</asp:ListItem>
                                                    <asp:ListItem Value="2">筆譯</asp:ListItem>
                                                    <asp:ListItem Value="3">公證文書</asp:ListItem>
                                                    <asp:ListItem Value="2">網頁翻譯</asp:ListItem>
                                                    <asp:ListItem Value="3">軟體翻譯</asp:ListItem>
                                                </asp:DropDownList>
							</div>
							<ul>
								<li>原語言(從)</li><li>目標語言(翻譯成)</li>
							</ul>
							<ul class="right_textarea">
								<li><asp:DropDownList ID="ddllanguagefrom" runat="server" Width="120px">
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
                                                        </asp:DropDownList></li>
								<li><asp:DropDownList ID="ddllanguageto" runat="server" Width="93px">
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
                                                        </asp:DropDownList></li>
							</ul>
							<ul>
								<li>估計頁數或字數</li><li>是否需要排版</li>
							</ul>
							<ul class="right_textarea">
								<li><input id="translationamount" style=" width:60px;" runat="server" type="text" name="llr" size="25" /><asp:DropDownList ID="ddltranslationtype" runat="server" Width="50px">
                                                                <asp:ListItem Value="字">字</asp:ListItem>
                                                                <asp:ListItem Value="頁">頁</asp:ListItem>
                                                            </asp:DropDownList></li>
								<li>
									<asp:RadioButton ID="rty" runat="server" Checked="true" GroupName="rtypesetting" Text="是" /><asp:RadioButton ID="rtn" runat="server" GroupName="rtypesetting" Text="否" />
								</li>
							</ul>
							<ul>
								<li>是否需要二次校稿</li><li>是否需要潤稿</li>
							</ul>
							<ul class="right_textarea">
								<li>
									<asp:RadioButton ID="rpy" runat="server" Checked="true" GroupName="rproofreading"
                            Text="是" /><asp:RadioButton ID="rpn" runat="server" GroupName="rproofreading" Text="否" />
								</li>
								<li>
									<asp:RadioButton ID="rdy" runat="server" Checked="true"
                        GroupName="rdraft" Text="是" /><asp:RadioButton ID="rdn" runat="server" GroupName="rdraft"
                            Text="否" />
								</li>
							</ul>
							<ul>
								<li>交件時間</li><li>工作日</li>
							</ul>
							<ul class="right_textarea">
								<li><input type="text" id="posttime"  runat="server" name="posttime" class="right_text"/></li>
								<li><input type="text" id="updays" runat="server" class="right_text"/></li>
							</ul>
							<ul>專案注意事項</ul>
							<input  type="file" id="upfile"/>
							<ul class="right_textarea"><asp:TextBox ID="ttbNotes" style="width:416px;height:120px;border:1px solid #ccc;margin-left:6px;margin-top:5px;" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="483px"></asp:TextBox></ul>
							<ul class="right_textarea">
								<li>上傳相關文件資料：</li><li class="uploadbuttonarea"><asp:FileUpload ID="file1" runat="server" Width="106px" /></li>
							</ul>
							<ul class="upload_textarea">上傳檔案（限制檔案大小10 MB；格式：Office文件、圖片檔、pdf、rar、zip)</ul>

                            <ul class="upload_textarea" style="display:none;" runat="server" id="codetr">
                                <li>驗證碼：<input type="text" value="" runat="server" style=" width:50px;" id="txtCode" /></li>
                                <li><img alt="Unclear？Click to get" id="Img" title="Unclear？Click to get" src="Common/ValidateCode.aspx" onclick="javascript:this.src = 'Common/ValidateCode.aspx?' + Math.random();" style="border-width: 0px; vertical-align: bottom; cursor: pointer;" /></li>
                            </ul>
							<ul class="upload_textarea">
								<li class="uploadbuttonarea"><asp:Button ID="btnSubmit" runat="server"  class="quotationbutton" OnClick="btnSubmit_Click" OnClientClick="return verifyInput(this.form)" Text="確定送出"  /></li>
								<li class="uploadbuttonarea"><asp:Button ID="btnReset" runat="server"  class="quotationbutton" OnClick="btnReset_Click"  Text="重新填寫"  /></li>
							</ul>
							<div class="box_bottom"><img src="images/quotation_big_box_bottom.jpg" alt="英文科技翻譯"/></div>
						</li>
					</ul>
			 </div>
             </div>
            <!-- / left side content -->
            
            
            
            <!-- 
            
            	<ul>
							<li>TEL：   +886-2-2568-3677</li>
							<li>FAX：   +886-2-2568-3702</li>
							<li>E-mail：service@crowns.com.tw</li>
							<li>地址： 台北市中山區<br/>新生北路二段129-2號7F   Inv:25125082</li>
							<li>上班時間：<br/>星期一至星期五<br/>AM 9:00 ～ PM 6:00</li>
						</ul>
						<ul class="imgarea">
							<img src="images/about_box_top.jpg" alt=""/>
							<!--google地圖碼 
							<div class="googlemap">
							<iframe width="208" height="209" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com.tw/maps?f=q&amp;source=s_q&amp;hl=zh-TW&amp;geocode=&amp;q=%E8%87%BA%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;aq=&amp;sll=23.48575,119.49965&amp;sspn=6.60714,11.634521&amp;brcurrent=3,0x3442a93f510c7ba1:0x731637f5caca2004,0,0x3442ac6b61dbbd9d:0xc0c243da98cba64b&amp;ie=UTF8&amp;hq=&amp;hnear=104%E5%8F%B0%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;ll=25.060218,121.527948&amp;spn=0.006376,0.011362&amp;t=m&amp;z=14&amp;output=embed"></iframe>
							</div>
							<!-- /google地圖碼 
							<img src="images/about_box_bottom.jpg" alt=""/>
						</ul>
            
             -->
            
            
            <!-- side bar -->
            <div class="sidebar"><div class="sidebars1"><div class="sidebars2">
	    

		<!-- box -->	
			<div class="box small">
			<!-- sub link-->
				<ul id="sub_menu">
                     <li><a href="about-translation-mechanical.html" title="關於我們">關於我們</a></li>
                     <li><a href="service-translation-mechanical.html" title="服務項目">服務項目</a></li>
                     <li><a href="technique-translation-mechanical.html" title="翻譯技術">翻譯技術</a></li>
                     <li><a href="costumer-translation-mechanical.aspx" title="客戶實績">客戶實績</a></li>
                     <li><a href="ourteam-translation-mechanical.aspx" title="翻譯團隊">翻譯團隊</a></li>
                     <li><a href="quotation-translation-mechanical.aspx" class="active" title="線上詢價">線上詢價</a></li>
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
							<img src="images/about_box_top.jpg" alt="科技翻譯公司"/>
							<!--google地圖碼 -->
							<div class="googlemap">
							<iframe width="208" height="209" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com.tw/maps?f=q&amp;source=s_q&amp;hl=zh-TW&amp;geocode=&amp;q=%E8%87%BA%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;aq=&amp;sll=23.48575,119.49965&amp;sspn=6.60714,11.634521&amp;brcurrent=3,0x3442a93f510c7ba1:0x731637f5caca2004,0,0x3442ac6b61dbbd9d:0xc0c243da98cba64b&amp;ie=UTF8&amp;hq=&amp;hnear=104%E5%8F%B0%E5%8C%97%E5%B8%82%E4%B8%AD%E5%B1%B1%E5%8D%80%E6%96%B0%E7%94%9F%E5%8C%97%E8%B7%AF%E4%BA%8C%E6%AE%B5129-2%E8%99%9F&amp;ll=25.060218,121.527948&amp;spn=0.006376,0.011362&amp;t=m&amp;z=14&amp;output=embed"></iframe>
							</div>
							<!-- /google地圖碼 -->
							<img src="images/about_box_bottom.jpg" alt="英文科技翻譯"/>
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

