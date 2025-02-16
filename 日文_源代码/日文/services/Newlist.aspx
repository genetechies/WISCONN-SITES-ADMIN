<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Newlist.aspx.cs" Inherits="center010" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠翻譯社提供30多種的各國語言翻譯包含：中、英、日、韓、法、德、義、俄、越南、泰國、西班牙、葡萄牙、阿拉伯等語系及多元化的服務項目，包括筆譯、口譯、網頁翻譯、影視翻譯、公證文書、打字排版、聽打逐字稿、錄音配音、網站多語化等相關翻譯技術。 "/>
<meta name="keywords" content="后冠翻譯社,英文翻譯,日文翻譯,韓文翻譯,論文翻譯" /> 
<meta name="copyright" content="后冠翻譯社"/>
<meta name="author" content="后冠翻譯社"/>
<meta name="classification" content="翻譯社"/>
<meta name="robots" content="index,all"/>
<meta name="rating" content="general"/>
<meta name="webcrawlers" content="ALL"/> 
<meta name="spiders" content="ALL" />
<meta name="revisit-after" content="2 day"/>

<title><%=ClassName %></title>
<link href="../css/index.css" rel="stylesheet" type="text/css" />
<!--文字切換為英文腳本-->
<script type="text/javascript" language="javascript" >
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
    
    <img src="../images/ban2.jpg" width="955" height="244" alt="翻譯公司 - 翻譯社最佳推薦"/></div>
<!--主要内容-->
<div class="main">
  <div><img src="../images/page-top.gif"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
   <h2 style="background:url(../images/hg_2_8.gif) left top no-repeat;">翻譯資訊</h2>
   <h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2>
    <ul>
    <%System.Data.DataSet dsleft = new DAL.NewsClass().GetList(" ParentID=1 ");
      for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
      {

          string[] t = new String[2];
          if (dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
          {
              t = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|');
          }
          else
          {
              t[0] = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim();
              t[1] = "";
          }

         %>
     <li><a href="/services/newlist-<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>.aspx" onmousemove="changeMove(this,'<%=t[1].Trim() %>')" onmouseout="changeLeve(this,'<%=t[0].Trim() %>')" ><%=t[0].Trim()%></a></li>
      <%} %>
     
    </ul> <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
    
  </div>
  <div class="main_right">
    <div class="main_right_body2">
     <div id="top-title" class="font26px">服務項目</div>
     <span> 后冠翻譯不斷精進，希望與您分享我們的成果，讓更多人瞭解！文章歡迎自由轉載，並請附上出處：文章來源 ：后冠翻譯社 （http://translation.crowns.com.tw/）
 </span><br/>
<img alt="日文翻譯" src="../images/t_18_1.jpg" />&nbsp;&nbsp;<a href="../rss/rss.aspx" style="padding-top:5px;"><img alt="Rss" src="../images/rss_bu.gif" style="border:0;" /></a>
 <asp:Repeater ID="newrp" runat="server" >
 <ItemTemplate>       
<table width="600" cellspacing="0" cellpadding="0" border="0" style="margin-top:10px;">
<tbody>
<tr>
<td height="26" style="width:81%;">
<a href="newsinfo-<%#Eval("D_ID") %>.aspx">
<b><%# Eval("D_Title")%></b>
</a>
</td>
<td style="width:19%;"><%# Eval("D_Time", "{0:yyyy-MM-dd}")%></td>
</tr>
<tr style="border-bottom:#333333 1px dotted;">
<td colspan="2"><%# Eval("D_Description")%></td>
</tr>
</tbody>
</table>
</ItemTemplate>
    </asp:Repeater>
<table width="600" cellspacing="0" cellpadding="0" border="0" style="margin-top:10px;">
<tbody>
<tr>
<td align="center" colspan="2" style="height:10px;">
<div id="AspNetPager1">
<webdiyer:aspnetpager id="AspNetPager2" runat="server" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager2_PageChanged"></webdiyer:aspnetpager>
</div>
</td>
</tr>
</tbody>
</table>
                        
                                
   </div>
  </div>
</div>
<div style="clear:both"></div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif"/></div>
<uc2:foot ID="foot1" runat="server" />
    </form>


</body>
</html>

