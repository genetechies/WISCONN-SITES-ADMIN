<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="payment_index" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="description" content="后冠翻譯公司提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。 "/>
    <meta name="keywords" content="英文 校稿,翻譯公司" /> 

    <title><%=moarticle.Title%></title>
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
<%----%>
</head>
<body>
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" />
    <!--廣告位-->
<div class="ban"> <img src="../images/ban7.jpg" width="955" height="244" alt="翻譯公司 台北"/></div>
<!--主要内容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="翻譯公司 台北"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2 style="background:url(../images/hg_9_1.gif) left top no-repeat;">服務項目</h2>
    <h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2>
    <ul>
      <li><a href="index.aspx" onmousemove="changeMove(this,'Contact Message')" onmouseout="changeLeve(this,'聯絡資訊')" >聯絡資訊</a></li>
      <li><a href="mailto:service@crowns.com.tw" onmousemove="changeMove(this,'E-mail')" onmouseout="changeLeve(this,'服務信箱')">服務信箱</a></li>
     
    </ul>
    <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
  </div>
  <div class="main_right">
    <div class="main_right_body2"> 
    <div id="top-title" class="font26px">聯絡我們</div>
 <%=moarticle.D_Content %>
    </div>
  </div>
    
</div>
<div style="clear:both">&nbsp;</div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 台北"/></div>
<uc2:foot ID="foot1" runat="server" />
    </form>
</body>
</html>
