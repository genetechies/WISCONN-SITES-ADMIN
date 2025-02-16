<%@ Page Language="C#" AutoEventWireup="true" CodeFile="japanese-houguan-translation-online-price.aspx.cs" Inherits="japanese_houguan_translation_online_price" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>后冠日文翻譯—公平實惠的翻譯價錢</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9"/>
	<meta name="description" content="我們相信，能夠設身處地為客戶著想才能走得更遠更久，所以后冠日文翻譯為客戶提供經濟實惠的價錢，為客戶節省金錢與時間。后冠以熱忱的服務態度隨時歡迎您的光臨。"/>
	<meta name="keywords" content="日文翻譯 價錢"/>
    <link href="css/ui.all.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-full.min.js"></script>
    <script type="text/javascript" src="js/jquery.mousewheel.min.js"></script>
    <script type="text/javascript" src="js/jquery.customscrollbar.min.js"></script>
    <script type="text/javascript" src="js/jquery.pagescroll2id.js"></script>
    <script type="text/javascript" src="js/jquery.stickyfloat.js"></script>
    <script type="text/javascript" src="js/scripts.js"></script>
    <link href="style.css" media="screen" rel="stylesheet" type="text/css"/>
    <link href="js/jquery.mCustomScrollbar.css" rel="stylesheet" type="text/css"/>
    <link rel="icon" href="images/HG.png" type="image/ico" />
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

<body class="page-front">
<form runat="server" id="form1">
    <div class="header">
        <div class="wrap">
            <a class="logo" title="后冠日文翻譯公司" href="japanese-houguan-translation-index.aspx">后冠日文翻譯公司</a>
            <div id="menu">
				<div class="menu-inner">
                <ul class="level-0">
                    <li><a href="japanese-houguan-translation-index.aspx" title="首頁"><b>首頁</b><br/><span>ホーム</span></a></li>
                    <li><a href="japanese-houguan-translation-about.html" title="關於我們"><b>關於我們</b><br/><span>會社概要</span></a></li>
                    <li><a href="japanese-houguan-translation-service.html" title="服務項目"><b>服務項目</b><br/><span>サービス內容</span></a></li>
                    <li><a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言"><b>翻譯語言</b><br/><span>翻訳対応言語</span></a></li>
                    <li><a href="japanese-houguan-translation-online-price.aspx" title="線上詢價"><b>線上詢價</b><br/><span>翻訳料金</span></a></li>
                    <li class="current"><a href="japanese-houguan-translation-faq-problem.html" title="常見問題"><b>常見問題</b><br/><span>よくあるご質問</span></a></li>
					<li><a href="japanese-houguan-translation-contact.html" title="聯繫我們"><b>聯繫我們</b><br/><span>お問い合わせ</span></a></li>
                </ul>
            </div>
			</div>
        </div>
    </div>

    <div id="page" class="content-page">
        <div id="content">
			<div class="slide_main">
				 <div id="top-header-slider" class="section">
                        <div class="slide transition-1">
                            <img src="images/service_bg.png" width="1200" height="245" alt="日文翻譯"/>

                            <div class="text">
                                后冠日文翻譯社提供線上詢價，給客戶經濟實惠的翻譯價錢
                            </div>
                        </div>

                        
                        
                    </div>
			</div>
           <div class="wrap">
              
				
				<div class="content" style="margin-top:-23px;">
					<div class="serv-2">
						<div class="left_menu_top" style="height:556px;">

							<div class="title">線上詢價 / 翻訳料金</div>
							
							<div class="l-menu">
								<ul>
                                    <li><a href="japanese-houguan-translation-about.html" title="關於我們">關於我們 / 會社概要</a></li>
									<li><a href="japanese-houguan-translation-service.html" title="服務項目">服務項目 / サービス內容</a></li>
									<li><a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言">翻譯語言 / 翻訳対応言語</a></li>
									<li><a href="japanese-houguan-translation-customers.aspx" title="客戶實績">客戶實績 / 翻訳実績</a></li>
									<li><a href="japanese-houguan-translation-team.aspx" title="翻譯團隊">翻譯團隊 / 日本語翻訳チーム</a></li>
									
									<li><a href="japanese-houguan-translation-informations.aspx" title="翻譯資訊">翻譯資訊 / 日本語翻訳情報</a></li>
									<li><a href="japanese-houguan-translation-faq-problem.html" title="常見問題">常見問題 / よくあるご質問</a></li>
									
									<li><a href="japanese-houguan-translation-contact.html" title="聯繫我們">聯繫我們 / お問い合わせ</a></li>
						
								
								</ul>
							</div>
						</div>
						<div class="left_menu_bottom"></div>
					</div>
					<div class="about-r">
						<div class="top"></div>
						<div class="con-1 clearfix">
							<div class="con-t-1 clearfix">
								<div class="c-inner clearfix">
									<span>線上詢價 / 翻訳料金</span>
								</div>
								<div class="c-l-l" style="width:100%;">
									如果客戶對我們的日文翻譯服務或翻譯價錢有任何問題，都可以留下資訊，我們會及時與您聯繫！
								</div>
								
								
							</div>
						<div class="lines clearfix"></div>
						<div class="service-t-t">
							<form action="" method="post" name="myform">
							<div class="sev-l-1">
								<div class="label">聯絡人</div>
								<input type="text" id="username" runat="server" name="llr" class="input-1"/>
								<div class="label la">聯絡電話</div>
								<input id="tel" runat="server" type="text" name="phone" class="input-1"/>
								<div class="label la">聯絡郵件</div>
								<input id="email" runat="server" type="text" name="email" class="input-1"/>
								<div class="notice-l">
									*或是您可以立即撥打電話與客服人員聯繫，我們將提供您最優質的服務！
								</div>
							</div>
							<div class="sev-r-1">
								<table class="sev-s-l" cellpadding="0" cellspacing="0" border="0">
                                    <tr>
										<td>服務項目</td>
										<td width="50">&nbsp;</td>
										<td><asp:DropDownList ID="ddltranslationskill" runat="server" Width="180px" Height="35px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                    <asp:ListItem Value="1">口譯</asp:ListItem>
                                                    <asp:ListItem Value="2">筆譯</asp:ListItem>
                                                    <asp:ListItem Value="3">公證文書</asp:ListItem>
                                                    <asp:ListItem Value="2">網頁翻譯</asp:ListItem>
                                                    <asp:ListItem Value="3">軟體翻譯</asp:ListItem>
                                                </asp:DropDownList></td>
									</tr>
									<tr>
										<td>原語言(從)</td>
										<td width="50">&nbsp;</td>
										<td>目標語言(翻譯成)</td>
									</tr>
									<tr>
										<td><asp:DropDownList ID="ddllanguagefrom" runat="server" Width="120px" Height="35px">
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
										<td width="50">&nbsp;</td>
										<td><asp:DropDownList ID="ddllanguageto" runat="server" Width="120px" Height="35px">
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
										<td>估計頁數或字數</td>
										<td width="50">&nbsp;</td>
										<td>希望交件時間</td>
									</tr>
									<tr>
										<td><input id="translationamount" style=" width:60px;" runat="server" type="text" class="input-1"/>&nbsp;&nbsp;<asp:DropDownList ID="ddltranslationtype" runat="server" Width="50px" Height="35px">
                                                                <asp:ListItem Value="字">字</asp:ListItem>
                                                                <asp:ListItem Value="頁">頁</asp:ListItem>
                                                            </asp:DropDownList></td>
										<td width="50">&nbsp;</td>
										<td><input name="posttime" runat="server" type="text" id="posttime" class="input-1"/></td>
									</tr>
								</table>
								<table class="sev-s-2" cellpadding="0" cellspacing="0" border="0">
									<tr>
										<td>工作日</td>
										<td>
											<input id="updays" runat="server" class="input-1" type="text" />
										</td>
										<td width="50">&nbsp;</td>
										<td>是否需要排版</td>
										<td><asp:RadioButton ID="rty" runat="server" Checked="true" GroupName="rtypesetting" Text="是" /><asp:RadioButton ID="rtn" runat="server" GroupName="rtypesetting" Text="否" /></td>
									</tr>
									<tr>
										<td>是否需要潤稿</td>
										<td><asp:RadioButton ID="rdy" runat="server" Checked="true"
                        GroupName="rdraft" Text="是" /><asp:RadioButton ID="rdn" runat="server" GroupName="rdraft"
                            Text="否" /></td>
										<td width="50">&nbsp;</td>
										<td>是否需要二次校稿</td>
										<td><asp:RadioButton ID="rpy" runat="server" Checked="true" GroupName="rproofreading"
                            Text="是" /><asp:RadioButton ID="rpn" runat="server" GroupName="rproofreading" Text="否" /></td>
									</tr>
									
								</table>
								<table class="sev-s-3" cellpadding="0" cellspacing="0" border="0">
									<tr>
										<td colspan="5" class="noborder">專案注意事項</td>
									</tr>
									<tr>
										<td colspan="5" class="noborder">
                                        <asp:TextBox ID="ttbNotes" class="input-2" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="450px"></asp:TextBox>											
										</td>
									</tr>
									<tr>
										<td class="noborder">上傳相關文件資料：</td>
										<td colspan="2" class="noborder">
											<asp:FileUpload ID="file1" runat="server" Width="106px" />
										</td>
										<td class="noborder"></td>
										<td class="noborder"></td>
									</tr>
									<tr>
										<td colspan="5" class="noborder">
											（限制檔案大小10 MB；格式：Office文件、圖片檔、pdf、rar、zip)
										</td>
									</tr>
                                    <tr style="display:none;" runat="server" id="codetr">
										<td class="noborder" style="width:80px;">驗證碼：</td>
										<td colspan="2" class="noborder">
											<input type="text" value="" runat="server" style=" width:50px;" id="txtCode" />
										</td>
										<td class="noborder"><img alt="Unclear？Click to get" id="Img" title="Unclear？Click to get" src="Common/ValidateCode.aspx" onclick="javascript:this.src = 'Common/ValidateCode.aspx?' + Math.random();" style="border-width: 0px; vertical-align: bottom; cursor: pointer;" /></td>
										<td class="noborder"></td>
									</tr>
									<tr>
										<td class="noborder"></td>
										<td class="noborder"></td>
										<td class="noborder"><asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" OnClientClick="return verifyInput(this.form)" class="submit-3" Text="確定送出"/>&nbsp;&nbsp;&nbsp;&nbsp;</td>
										<td colspan="2" class="noborder">
											
											<asp:Button ID="btnReset" runat="server" Text="重新填寫"  class="reset-3" />
										</td>
									</tr>
								</table>
							</div>
							</form>
						</div>
						</div>
					</div>
				</div>
			</div>
    </div>
</div>
    <div class="footer">
        <div class="wrap">
			<p class="bottom-menu">
				<a href="japanese-houguan-translation-index.aspx" title="首頁">首頁</a>|
				<a href="japanese-houguan-translation-about.html" title="關於我們">關於我們</a>|
				<a href="japanese-houguan-translation-service.html" title="服務項目">服務項目</a>|
				<a href="japanese-houguan-translation-online-price.aspx" title="線上詢價">線上詢價</a>|
				<a href="japanese-houguan-translation-customers.aspx" title="客戶實績">客戶實績</a>|
				<a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言">翻譯語言</a>|
				<a href="japanese-houguan-translation-team.aspx" title="翻譯團隊">翻譯團隊</a>|
				<a href="japanese-houguan-translation-informations.aspx" title="翻譯資訊">翻譯資訊</a>|
				<a href="japanese-houguan-translation-faq-problem.html" title="常見問題">常見問題</a>|
				<a href="japanese-houguan-translation-contact.html" title="聯絡我們">聯絡我們</a>|
				<a href="japanese-houguan-translation-link.aspx" title="友情連結">友情連結</a>|<a href="sitemap/sitemap.xml" title="sitemap">sitemap</a>
			</p>
			<p class="l">Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.</p>
            <p class="r">Tel:(02)2568-3677     Fax:(02)2568-3702     台北市中山區新生北路二段129-2號7F   Inv:25125082</p>
            
        </div>
    </div>
<script type="text/javascript">
<!--
    function upfile() {
        $('<input type="file" name="upfile"/>').appendTo($('body'));
        $('input[name="upfile"]').click();
    }
    -->
</script>
</form>
</body>
</html>

