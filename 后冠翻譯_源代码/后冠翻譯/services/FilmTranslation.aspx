<%@ Page Language="C#" AutoEventWireup="true"%>
<%@ Register Src="../top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../foot.ascx" TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="台灣后冠翻譯公司受到許多客戶推薦提供多國語言翻譯，以精確、迅速的宗旨為您服務，從翻譯、影片翻譯及製作，所有流程都能幫您服務，提供您連貫的一致性服務。"/>
<meta name="keywords" content="翻譯公司 推薦、翻譯公司 台灣" /> 
<meta name="copyright" content="翻譯公司"/>
<meta name="author" content="翻譯公司"/>
<meta name="classification" content="翻譯公司"/>
<meta name="robots" content="index,all"/>
<meta name="rating" content="general"/>
<meta name="webcrawlers" content="ALL"/> 
<meta name="spiders" content="ALL" />
<meta name="revisit-after" content="2 day"/>

<title>台灣后冠翻譯公司 - 客戶推薦的影片翻譯及製作</title>
<link href="../css/index.css" rel="stylesheet" type="text/css" />
<!--文字切換為英文腳本-->
<script type="text/javascript" language="javascript">
function changeMove(objid,value)
{ 
objid.innerHTML=value;

}
function changeLeve(objid,value)
{ 
objid.innerHTML=value;
}
</script>
</head>
<body>
<form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" />
<!--廣告位-->
<div class="ban"> <img src="../images/ban2.jpg" width="955" height="244" alt="翻譯公司 台灣"/></div>
<!--主要内容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="翻譯公司 推薦"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2 style="background:url(../images/hg_2_1.gif) left top no-repeat;">服務項目</h2>
   <ul>
      <li><a href="DocumentTranslation.aspx" onmousemove="changeMove(this,'Document Translation')" onmouseout="changeLeve(this,'筆譯服務')" >筆譯服務</a></li>
      <li><a href="Interpretation.aspx" onmousemove="changeMove(this,'Interpretation')" onmouseout="changeLeve(this,'口譯服務')">口譯服務</a></li>
      <li><a href="Proofreading.aspx" onmousemove="changeMove(this,'Proofreading')" onmouseout="changeLeve(this,'校稿潤稿')">校稿潤稿</a></li>
      <li><a href="MultilingualWebsite.aspx" onmousemove="changeMove(this,'Multilingual Website')" onmouseout="changeLeve(this,'網頁設計及翻譯')" >網頁設計及翻譯</a></li>
      <li><a href="FilmTranslation.aspx" onmousemove="changeMove(this,'Film Translation')" onmouseout="changeLeve(this,'影片翻譯及製作')" >影片翻譯及製作</a></li>
      <li><a href="Annualreporttranslation.aspx" onmousemove="changeMove(this,'Annual Report Translation')" onmouseout="changeLeve(this,'年報翻譯')" >年報翻譯</a></li>
      <li><a href="ESGtranslation.aspx" onmousemove="changeMove(this,'ESG Translation')" onmouseout="changeLeve(this,'ESG翻譯')" >ESG翻譯</a></li>

    </ul>
     <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
  </div>
  <div class="main_right">
    <div class="main_right_body2"> 
     <div id="top-title" class="font26px">影片翻譯及製作</div>
   		<p>台灣后冠翻譯公司擁有系統化、專業化、經驗豐富的影片後製，包含：電影、電視、教材、紀錄片、多語互動媒體檔案製作等，從翻譯到配音、剪接、編輯及上字幕，一連串進行準確而快速的後製，以為客戶佔領市場贏得了先機。
</p>
        <p>為了方便客戶在短時間內完成影音短片的製作需求，特別設立影音剪輯室受到客戶的推薦，提供多樣化的影音素材剪輯，配音 ( 多國語言 ) 、配樂 ( 版權 ) 、動畫 、網路影片轉檔上傳等網路影音後製作服務，只要 2 -3 天就能完成一部讓你意想不到的完美短片後製。</p>
                <p>后冠希望能為您提供最方便有品質的服務，我們不會劃地自限，而是朝全方位的翻譯公司而努力，任何有關翻譯的工作我們都有自信做到完美。</p>
        <br/>
                
    </div>
  </div>
</div>
<div style="clear:both"></div>
 <!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 推薦"/></div>
    <uc2:foot ID="foot1" runat="server" />
    </form></body>
</html>