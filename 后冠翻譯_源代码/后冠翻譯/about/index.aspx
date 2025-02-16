<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="about_index" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="description" content="后冠翻譯公司提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。 "/>
    <meta name="keywords" content="英文 校稿,翻譯公司" />     

    <title>后冠翻譯公司 - 台北后冠對於翻譯的執著</title>
    <link href="../css/index.css" rel="stylesheet" type="text/css" />
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
<div class="ban"> 
    
    <img src="../images/banner2.jpg" alt="翻譯公司 台北"/></div>
<!--主要内容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="翻譯公司 台北"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2>翻譯公司</h2><h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2><ul>
<%--    <%System.Data.DataSet dsleft = new DAL.PageClass().GetList(" ParentID=1 ");
      for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
      {
          string[] t = new String[2];
          if (dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
          {
              t = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|');
          }
          else
          {
              t[1] = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim();
              t[0] = "";
          }
         %>
     <li><a href="/about/index-<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>.aspx" onmousemove="changeMove(this,'<%=t[1].Trim() %>')" onmouseout="changeLeve(this,'<%=t[0].Trim() %>')" ><%=t[0].Trim()%></a></li>
      <%} %>--%>
      
      <li><a href="index.aspx" onmousemove="changeMove(this,'About Us')" onmouseout="changeLeve(this,'關於后冠')" >關於后冠</a></li>
      <li><a href="Mission.aspx" onmousemove="changeMove(this,'Mission')" onmouseout="changeLeve(this,'翻譯理念')">翻譯理念</a></li>
      <li><a href="ProjectWorkflow.aspx" onmousemove="changeMove(this,'Projest Workflow')" onmouseout="changeLeve(this,'報價流程')" >報價流程</a></li>
      <li><a href="QualityControl.aspx" onmousemove="changeMove(this,'Quality Control')" onmouseout="changeLeve(this,'品質控管')">品質控管</a></li>
      <li><a href="ConfidentialContract.aspx" onmousemove="changeMove(this,'Confidential Contract ')" onmouseout="changeLeve(this,'保密合約')" >保密合約</a></li>
      
    </ul><h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
  </div>
  <div class="main_right12">
  <div class="right-border12">
    <div class="main_right_body212">
         <div id="top-title" class="font26px">關於后冠</div>
          <div style="padding-bottom:12px;padding-left:18px;width:600px;">我們是跨足兩岸三地的台北翻譯公司，是由台灣和大陸通過國家級考試翻譯師、海外華人及翻譯碩士/博士學位相關學科著名大學老師所組成的專業翻譯團隊，從事全球翻譯服務。<br /><br />

    我們可以翻譯下列語言：英語、日語、韓語、法語、德語、意大利語、俄語、越南語、泰國語、西班牙語、葡萄牙語、阿拉伯語、繁體中文、簡體中文等。<br /><br />

    我們多樣化的翻譯服務，包括文件翻譯、口譯、論文翻譯、網頁翻譯、影片翻譯、資料翻譯、履歷翻譯、打字、排版、錄音和相關的網站/網頁本地化翻譯。<br /><br />

    如果您的公司有任何翻譯需求，我們提供了一個簡短的試譯服務，使您可以評估的翻譯品質，我們嚴格審查每一份文件，並經驗豐富的管理有效地計畫管理整個翻譯過程，經由管理和校對檢查的準確性，以達到卓越的品質翻譯。
</div>
<table width="600" border="1" cellpadding="3" style="border-collapse:collapse;border:1px solid #3ca5ba; margin-left:16px;margin-top:12px;">
  <tr>
    <td width="296" scope="row" style="background-color:#3ca5ba;color:#fff; text-align:center">后冠基本資訊</td>
    <td width="300" style="background-color:#3ca5ba;color:#fff; text-align:center">翻譯服務</td>
  </tr>
  <tr>
<td height="300" valign="top" scope="row" style="border:1px solid #3ca5ba">
<ul style="list-style-type:none; margin:0px; padding:0px; width:296px">
<li style="line-height:26px;">后冠統一編號：25125082</li>
<li style="line-height:26px;">翻譯專業領域：30個以上</li>
<li style="line-height:26px;">后冠翻譯語言：40國以上</li>
<li style="line-height:26px;">后冠專職職翻譯師人數：30位以上</li>
<li style="line-height:26px;">后冠國內長期合作公司數 ：100家以上</li>
<li style="line-height:26px;">后冠國外長期合作公司數 ：150家以上</li>
<li style="line-height:26px;">后冠長期合作翻譯師數 ：150位以上</li>
<li style="line-height:26px;">后冠長期合作母語翻譯師數 ：200位以上</li>
<li>后冠辦公據點 ：台北、香港、廣州、加拿大、澳洲</li>
</ul>
</td>
<td valign="top" style="border:1px solid #3ca5ba">
<ul style="list-style-type:none; margin:0px; padding:0px; width:300px">
<li style="line-height:26px;">翻譯語言：中文、英文、日文、韓文、粵語、泰文、印尼文、越南文、葡萄牙文、西班牙文、法文、 德文、義大利文、希臘文、捷克文、波蘭文、羅馬尼亞文、匈牙利文……等。</li>
<li style="line-height:12px;">&nbsp;</li>
<li style="line-height:26px;">文件翻譯類型：各式使用手冊、技術文件、母語潤稿、公司行號內外部文件、網站翻譯、 商業書信、法律合約、醫學文件、書籍影帶、母語潤飾、會議報告、網頁翻譯、碩博士論文、一般書籍、一般信件……等。</li>
<li style="line-height:12px;">&nbsp;</li>
<li style="line-height:26px;">口譯翻譯類型 ：隨行翻譯、逐步翻譯、同步翻譯、展場翻譯 </li>
</ul>
</td>
</tr>
</table>
     

    </div>
    </div>
  </div>
</div>
<div style="clear:both"></div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 台北"/></div>
    <uc2:foot ID="foot1" runat="server" />
    </form>
</body>
</html>
