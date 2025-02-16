<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="services_index" %>

<%@ Register Src="../top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../foot.ascx" TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="description" content="后冠翻譯公司提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。 "/>
    <meta name="keywords" content="英文 校稿,翻譯公司" /> 

    <title>
        后冠翻譯公司 - 各項英文、日文翻譯等服務項目</title>
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
    <!--導航-->
    <!--廣告位-->
    <div class="ban">
        <img src="../images/ban2.jpg" width="955" height="244" alt="翻譯公司 日文" /></div>
    <!--主要内容-->
    <div class="main">
    <div><img src="../images/page-top.gif" alt="翻譯公司 英文"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
       
                    <div class="main_left">
                        <h2 style="background: url(../images/hg_2_1.gif) left top no-repeat;">
                            服務項目</h2>
                         <h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2>
                        <ul>
                            <%--<%System.Data.DataSet dsleft = new DAL.PageClass().GetList(" ParentID=2 ");
                              for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
                              {
                                  string[] t = new string[2];
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
                            <li><a href="/services/index-<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>.aspx"
                                onmousemove="changeMove(this,'<%=t[1].Trim() %>')" onmouseout="changeLeve(this,'<%=t[0].Trim() %>')">
                                <%=t[0].Trim()%></a></li>
                            <%} %>--%>
                            <li><a href="DocumentTranslation.aspx" onmousemove="changeMove(this,'Document Translation')" onmouseout="changeLeve(this,'筆譯服務')" >筆譯服務</a></li>
                          <li><a href="Interpretation.aspx" onmousemove="changeMove(this,'Interpretation')" onmouseout="changeLeve(this,'口譯服務')">口譯服務</a></li>
                          <li><a href="Proofreading.aspx" onmousemove="changeMove(this,'Proofreading')" onmouseout="changeLeve(this,'校稿潤稿')">校稿潤稿</a></li>
                          <li><a href="MultilingualWebsite.aspx" onmousemove="changeMove(this,'Multilingual Website')" onmouseout="changeLeve(this,'網頁設計及翻譯')" >網頁設計及翻譯</a></li>
                          <li><a href="FilmTranslation.aspx" onmousemove="changeMove(this,'Film Translation')" onmouseout="changeLeve(this,'影片翻譯及製作')" >影片翻譯及製作</a></li>
      <li><a href="Annualreporttranslation.aspx" onmousemove="changeMove(this,'Annual Report Translation')" onmouseout="changeLeve(this,'年報翻譯')" >年報翻譯</a></li>
      <li><a href="ESGtranslation.aspx" onmousemove="changeMove(this,'ESG Translation')" onmouseout="changeLeve(this,'ESG翻譯')" >ESG翻譯</a></li>


                        </ul><h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
                    </div>
               
                    <div class="main_right">
                     
                        <div class="main_right_body2">
                        <div id="top-title" class="font26px">服務項目</div>
                            <p>
        后冠翻譯公司提供30多種的各國語言翻譯包含：中、英、日、韓、法、德、義、俄、越南、泰國、西班牙、葡萄牙、阿拉伯等語系及多元化的服務項目，包括筆譯、口譯、網頁翻譯、影視翻譯、打字排版、聽打逐字稿、錄音配音、網站多語化等相關翻譯技術。</p>
                <p>
       <img alt="翻譯公司 英文" src="../images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />	筆譯服務：
                <br/>每位資深翻譯師均具備高度專業素養，至少擁有五年以上的翻譯經驗，並嚴格要求專業術語和專有名詞的正確性。敝社和許多政府單位以及公司企業，長期合作以來，翻譯品質獲得相當高的好評。
                </p>
                <p>
       <img alt="翻譯公司 日文" src="../images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />	口譯服務：
                <br/>后冠的口譯員由全國各地國家級審譯、外籍專家、留學歸國人員及各大研究所碩士及博士組成，提供的服務包括：同步、逐步、耳語、隨行口譯和商務洽談及口譯設備機器承租、場地配置安排等服務。
                </p>
                <p>
       <img alt="翻譯公司 英文" src="../images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />	校稿潤稿：
                <br/>翻譯師的翻譯是最重要的一環，再好的校對與潤稿都只是對於文章的修飾增色，並不會更動文本本身，但校對潤稿自有其重要性，可將文章更推至精準、順暢，使文章在不同語言間都展現原有風采！
                </p>
                <p>
       <img alt="翻譯公司 日文" src="../images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />	網頁翻譯：
                <br/>網站的中文翻譯或外文翻譯需要高水準的語文表達，跨文化溝通的能力與技巧更是不可或缺，后冠翻譯能融合優雅流暢的譯文，與跨文化的溝通能力，使您的網站更具競爭力。
                </p>
                <p>
       <img alt="翻譯公司 英文" src="../images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />	影視翻譯：
                <br/>系統化、專業化、經驗豐富的軟體後製，包含：電影、電視、教材、紀錄片、多語互動媒體檔案製作等，從翻譯到配音、剪接、編輯及上字幕，一連串進行準確而快速的後製，以為客戶佔領市場贏得了先機。
                </p>
                  <p>
       <img alt="翻譯公司 日文" src="../images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />	打字排版： 
                <br/>各國語言文件（書寫稿）和聲音（對話記錄、語音旁白）打字，並能依造您的需求格式，彈性調整版面設計。專業的打字人員、軟體排版，要求「品質、速度」兼顧，為您提供最精確的品質。
                </p>
                        </div>
                     
                    </div>
   
    </div>
    <div style="clear:both"></div>
    <!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 日文"/></div>
    <uc2:foot ID="foot1" runat="server" />
    </form>
</body>
</html>
