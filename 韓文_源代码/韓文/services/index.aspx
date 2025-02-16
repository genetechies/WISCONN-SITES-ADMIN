<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="services_index" %>

<%@ Register Src="../top.ascx" TagName="top" TagPrefix="uc1" %>
<%@ Register Src="../foot.ascx" TagName="foot" TagPrefix="uc2" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>
        后冠翻譯社 - 各項翻譯服務項目</title>
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
        <img src="../images/ban2.jpg" width="955" height="244" alt="翻譯公司 - 翻譯社最佳推薦" /></div>
    <!--主要内容-->
    <div class="main">
    <div><img src="../images/page-top.gif" alt="韓文翻譯"/></div>
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
                              <li><a href="DocumentTranslation.aspx" >Document Translation</a></li>
                              <li><a href="Interpretation.aspx">Interpretation</a></li>
                              <li><a href="Proofreading.aspx">Proofreading</a></li>
                              <li><a href="MultilingualWebsite.aspx">MultilingualWebsite</a></li><!-- MultilingualWebsite & Production-->
                              <li><a href="FilmTranslation.aspx">FilmTranslation&amp;Production</a></li>
                        </ul><h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
                    </div>
               
                    <div class="main_right">
                     
                        <div class="main_right_body2">
                        <div id="top-title" class="font26px">Service Items</div>
                            <p>
        Our language services provide translation into the Simplified Chinese and Traditional Chinese from over 30 languages: Chinese, English, Japanese, Korean, French, German, Italian, Russian, Vietnamese, Thai, Spanish, Portuguese, Arabic, etc. Moreover, we also provide diversified service items, including translation, interpretation, webpage translation, audio/video translation, typesetting, typing by listening, recording &amp; dubbing, multilingual website service and other related translation services.</p>
                <p>
       <img alt="翻譯社 - 小標圖" src="../images/da03.gif" title="翻譯社 - 翻譯社小標圖" />	Translation:
                <br/>Each professional translator is equipped with strong professional quality with at least five years of translation experience and strictly guarantees the accuracy of terminology. We have established long term cooperation with government units and enterprises and have won high praise for our translation quality.
                </p>
                <p>
       <img alt="翻譯社 - 小標圖" src="../images/da03.gif" title="翻譯社 - 翻譯社小標圖" />	Interpreting:
                <br/>Our interpreters are national first-grade interpreters, foreign exports, overseas returnees and postgraduates and doctors. The services cover simultaneous interpretation, consecutive interpretation, whispering interpretation, liaison interpretation and business negotiation as well as interpretation equipment lease, venue organization, etc.
                </p>
                <p>*For the interpretation equipment lease and venue organization, the services are only available locally in China and Taiwan.</p>
                <p>
       <img alt="翻譯社 - 小標圖" src="../images/da03.gif" title="翻譯社 - 翻譯社小標圖" />	Proofreading:
                <br/>Translator plays a critical role in the translation process. For proofreaders, they just modify the words, grammar, sentence patterns but not retranslate the text. Of course, proofreading also plays an important role in the translation process. They can make the translation more precise, more fluent and more authentic.
                </p>
                <p>
       <img alt="翻譯社 - 小標圖" src="../images/da03.gif" title="翻譯社 - 翻譯社小標圖" />	Website translation:
                <br/>In the website, high-quality expression is a necessary in the Chinese and foreign languages translation, cross-cultural communication ability and technology also play a vital role. HouGuan Translation combines graceful and smooth translation with cross-cultural communication ability together to make your website more competitive.
                </p>
                <p>
       <img alt="翻譯社 - 小標圖" src="../images/da03.gif" title="翻譯社 - 翻譯社小標圖" />	Audio / Video translation:
                <br/>We have developed a systematic, professional and experienced way in the post production of films, television shows, teaching material, documentaries, and multilingual interactive media archives. Our services range from translation to dubbing, editing, and subtitling. We provide a series of accurate and fast services in post production in order to maintain the market advantages for our customers.
                </p>
                  <p>
       <img alt="翻譯社 - 小標圖" src="../images/da03.gif" title="翻譯社 - 翻譯社小標圖" />	Typesetting:
                <br/>We provide service of typing documents (written materials) and voice (dialogue, voiceover), and flexibly adjust the layout according to your requirements. Professional typewriters and software layout designers can provide you the most precise quality in set time.
                </p>
                        </div>
                     
                    </div>
   
    </div>
    <div style="clear:both"></div>
    <!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="韓文翻譯"/></div>
    <uc2:foot ID="foot1" runat="server" />
    </form>
</body>
</html>
