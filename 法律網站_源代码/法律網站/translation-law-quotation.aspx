<%@ Page Language="C#" AutoEventWireup="true" CodeFile="translation-law-quotation.aspx.cs" Inherits="translation_law_quotation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>線上諮詢人員讓您迅速瞭解各類合約翻譯的價格行情！</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1,maximum-scale=1"/>
<meta name="Description" content="后冠翻譯社特別提供線上詢價服務，客戶可以直接將需要翻譯的檔上傳，選擇相應的服務專案。或者聯繫客服人員瞭解合約翻譯的行情與價格！"/>
<meta name="keywords" content="合約翻譯 價格,合約翻譯 行情"/>    
<!-- Stylesheets-->
<link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8" />
<link rel="stylesheet" href="css/flexy-menu.css" type="text/css" charset="utf-8" />
<link rel="stylesheet" href="css/style_banner.css" type="text/css" charset="utf-8" />
        <link rel="icon" href="images/HG.png" type="image/ico" />

<!-- banner-js!-->
<script type="text/javascript" src="js/jquery.min.js"></script>
<script type="text/javascript" src="js/jquery.SuperSlide.js"></script>
<script type="text/javascript" src="js/banner_nav.js"></script>
<script type="text/javascript" src="bootstrap/js/bootstrap.min.js"></script>
<script type="text/javascript" src="js/theme20.js"></script>
<script type="text/javascript" src="js/jquery.prettyPhoto.js"></script>
<script type="text/javascript" src="js/jquery.flexslider-min.js"></script>

<script src="js/layerslider/jQuery/jquery-transit-modified.js" type="text/javascript"></script>
<script src="js/layerslider/js/layerslider.transitions.js" type="text/javascript"></script>
<script src="js/layerslider/js/layerslider.kreaturamedia.jquery.js" type="text/javascript"></script>
<script type="text/javascript" src="js/ui.datepicker.js"></script>
<link href="css/jquery-ui.css" rel="stylesheet"/>
<script type="text/javascript" src="css/jquery-ui.js"></script>
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
-->
</style></head>
<body>
<form runat="server" id="form1">
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
            		<a href="translation-law-index.aspx"><img src="images/logo.png" alt="合約翻譯 價格" height="103" width="150" /></a>
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
                <li class="active"><a href="translation-law-quotation.aspx" title="線上詢價">線上詢價</a></li>
                <li><a href="translation-law-contact.html" title="聯繫我們">聯繫我們</a></li>
            </ul>
            <!--Navigation Menu End-->
            
        </div>
         <!--Logo and Main Menu End-->
        
<div class="container">
        	
            <!--All Content Start-->
            <div class="content-wrapper">

<div class="banner" style="background-image:url(images/banner-05.png);">
<div style="float:left; z-index:999px; height:auto; overflow:hidden; width:980px; margin-top:200px;">
<h1 style="line-height:60px; color:#FFF; font-size:36px; text-align:left; padding-left:100px;">后冠法律翻譯社提供給客戶<br />

合約翻譯經濟實惠的價格與行情！
</h1>
</div>
</div>
<!-- banner -->    

                        
	<!--Site Slogan Start-->
	<div class="site-slogan-wrapper">
	<div class="site-slogan">
	
        <div class="nav-add">
        <div class="nav-add-left">
        <div class="nav-add-left-top">線上  詢價 </div>
        <div class="nav-add-left-bottom">線上諮詢人員讓您迅速瞭解各類合約翻譯的價格行情！</div>
        </div>
        <div class="nav-add-right">首頁 / <span>線上  詢價 </span></div>
        </div>
    
	</div>
	</div>
	<!--Site Slogan End-->
 
 	<div class="stripe service-panel">



<div style="width:900px; height:30px; line-height:30px;  margin:40px auto 20px auto; display:block;">
<div style="width:380px; height:15px; border-bottom:1px #cccccc solid; float:left; display:block;"></div>
<div style="width:120px; height:30px; line-height:30px; text-align:center; font-size:16px; color:#7a7a7a; display:block; float:left;">線上詢價</div>
<div style="width:380px; height:15px; border-bottom:1px #cccccc solid; float:left; display:block;"></div>
</div>
<div style="color:#f68a5e; margin:auto; text-align:center; line-height:40px; font-size:16px;">想快速瞭解合約翻譯的行情或是價格嗎？請留下資料，客服人員將盡速與您聯繫！</div>

<table width="100%" border="0" cellspacing="0" cellpadding="0" style="background:#000">
  <tr>
    <td height="40" colspan="4" align="center" style="font-size:14px; color:#FFF;background:url(images/onpir-title-bg.png)">基本資料</td>
    </tr>
  <tr>
    <td width="21%" height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">連絡人</td>
    <td height="40" colspan="3" style="border-bottom:1px #333 solid;"><label>
      <input name="textfield" type="text" id="username" runat="server" size="30" />
    </label></td>
    </tr>
  <tr>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">聯絡電話 </td>
    <td height="40" colspan="3" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><input name="textfield2" type="text" id="tel" runat="server" size="30" /></td>
    </tr>
  <tr>
    <td height="40" bgcolor="#efefef">聯絡郵件</td>
    <td height="40" colspan="3" bgcolor="#ffffff"><input name="textfield3" type="text" id="email" runat="server" size="30" /></td>
    </tr>
  <tr>
    <td height="40" colspan="4" align="center" bgcolor="#71bfc4" style="font-size:14px; color:#FFF;">以下請盡量提供以利給予您準確的報價</td>
    </tr>
  <tr>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">服務項目</td>
    <td height="40" colspan="3" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><label>
      <asp:DropDownList ID="ddltranslationskill" runat="server" Width="180px">
                                                    <asp:ListItem Value="0">請選擇</asp:ListItem>
                                                    <asp:ListItem Value="1">口譯</asp:ListItem>
                                                    <asp:ListItem Value="2">筆譯</asp:ListItem>
                                                    <asp:ListItem Value="3">公證文書</asp:ListItem>
                                                    <asp:ListItem Value="2">網頁翻譯</asp:ListItem>
                                                    <asp:ListItem Value="3">軟體翻譯</asp:ListItem>
                                                </asp:DropDownList>
    </label></td>
    </tr>
  <tr>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">原始語種(從)</td>
    <td width="29%" height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;">
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
                                                        </asp:DropDownList></td>
    <td width="20%" height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">目地語言(翻譯成)</td>
    <td width="30%" height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><asp:DropDownList ID="ddllanguageto" runat="server" Width="93px">
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
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">估計頁數或字數</td>
    <td height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><input name="textfield4" type="text" id="translationamount" runat="server" size="5" />
      <asp:DropDownList ID="ddltranslationtype" runat="server" Width="50px">
                                                                <asp:ListItem Value="字">字</asp:ListItem>
                                                                <asp:ListItem Value="頁">頁</asp:ListItem>
                                                            </asp:DropDownList></td>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">是否需要排版</td>
    <td height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><label>
      <asp:RadioButton ID="rty" runat="server" Checked="true" GroupName="rtypesetting" Text="是" /><asp:RadioButton ID="rtn" runat="server" GroupName="rtypesetting" Text="否" />
    </label></td>
  </tr>
  <tr>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">是否需要二次校稿</td>
    <td height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><asp:RadioButton ID="rpy" runat="server" Checked="true" GroupName="rproofreading"
                            Text="是" /><asp:RadioButton ID="rpn" runat="server" GroupName="rproofreading" Text="否" /></td>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">是否需要潤稿</td>
    <td height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><asp:RadioButton ID="rdy" runat="server" Checked="true"
                        GroupName="rdraft" Text="是" /><asp:RadioButton ID="rdn" runat="server" GroupName="rdraft"
                            Text="否" /></td>
  </tr>
  <tr>

    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">交件時間</td>
    <td height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><input name="posttime" runat="server" type="text" id="posttime" size="10" /></td>
    <td height="40" bgcolor="#efefef" style="border-bottom:1px #333 solid;">工作日</td>
    <td height="40" bgcolor="#ffffff" style="border-bottom:1px #333 solid;"><input name="textfield6" type="text" id="updays" runat="server" size="10" /></td>
  </tr>
  <tr>
    <td height="40" bgcolor="#efefef">專案注意事項</td>
    <td height="100" colspan="3" bgcolor="#ffffff"><label>
      <asp:TextBox ID="ttbNotes" style="width:616px;height:120px;border:1px solid #ccc;margin-left:6px;margin-top:5px;" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="483px"></asp:TextBox>
    </label></td>
    </tr>
  <tr>
    <td height="40" colspan="4" align="center" bgcolor="#71bfc4" style="font-size:14px; color:#FFF;">上傳相關文件資料</td>
    </tr>
  <tr>
    <td height="40" colspan="4" style="color:#71bfc4; font-size:14px;">上傳檔案（限制檔案大小10MB；格式：Office文件丶圖片檔丶pdf丶rar丶zip)</td>
    </tr>
  <tr>
    <td height="40" colspan="4"><form action="" id="form2" name="form1" enctype="multipart/form-data" method="post">
      <label>
        <asp:FileUpload ID="file1" runat="server" Width="606px" />
      </label>
    </form></td>
    </tr>
  <tr>

    <td height="40" colspan="4" style="color:#71bfc4; font-size:14px;display:none;" runat="server" id="codetr">
        <div>													
                <label>驗證碼</label><input type="text" value="" runat="server" style=" width:50px;" id="txtCode" />
                <img alt="合約翻譯 行情" id="Img" title="Unclear？Click to get" src="Common/ValidateCode.aspx" onclick="javascript:this.src = 'Common/ValidateCode.aspx?' + Math.random();" style="border-width: 0px; vertical-align: bottom; cursor: pointer;" />                                                                        
		    </div>
    </td>
    </tr>
    <tr>
    <td height="40" colspan="4" align="center">
    <div style="width:100%; height:auto; text-align:center">
    <asp:Button ID="btnSubmit" Text="確定送出" style=" background-image:url(images/cx.png); height:30px; width:68px; border:0px; color:#FFF;"  runat="server" OnClick="btnSubmit_Click" OnClientClick="return verifyInput(this.form)" />        
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnReset" Text="重新填寫" style=" background-image:url(images/fs.png); height:30px; width:68px; border:0px; color:#002f4a" runat="server" OnClick="btnReset_Click"  />
    </div>
      </td>
    </tr>
</table>

<div style="color:#f68a5e; margin:20px  auto 20px auto; text-align:center; line-height:20px; font-size:16px;">或是您可以立即撥打電話與客服人員聯繫，我們將提供您最優質的服務！</div>

	</div>
 
 
 

	</div>
    
    
    
	</div>  
    
                <div class="wrapper">
                    <div class="footer-content">

                      <div class="footer-top">
                            
                            <!--Footer About Us-->
                            <div class="footer-about">
                                <div><img src="images/ar.png" alt="合約翻譯 價格" /></div>
                                
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
    
</form>
    <script type="text/javascript" src="js/custom.js"></script>
</body>
</html>

