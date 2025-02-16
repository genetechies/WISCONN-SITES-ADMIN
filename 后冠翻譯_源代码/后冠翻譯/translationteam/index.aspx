<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="translationteam_index" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠翻譯公司提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。 "/>
<meta name="keywords" content="英文 校稿,翻譯公司" /> 
<meta name="copyright" content="翻譯公司"/>
<meta name="author" content="翻譯公司"/>
<meta name="classification" content="翻譯公司"/>
<meta name="robots" content="index,all"/>
<meta name="rating" content="general"/>
<meta name="webcrawlers" content="ALL"/> 
<meta name="spiders" content="ALL" />
<meta name="revisit-after" content="2 day"/>

<title><%=ClassName%></title>
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
    
    <img src="../images/ban2.jpg" width="955" height="244" alt="英文 校稿"/></div>
<!--主要内容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="英文 校稿"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2 style="background:url(images/hg_12_1.gif) left top no-repeat;">服務項目</h2>
    <h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2>
    <ul>
    <%
        
System.Data.DataSet ds = new BLL.TransTeam().GetAllTeamType();
for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
{
    string[] t = new String[2];
    if (ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim().Split('|').Length > 1)
    {
        t = ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim().Split('|');
    }
    else
    {
        t[0] = ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim();
        t[1] = "";
    }              
      %>
      <li><a href="index.aspx?typeid=<%=ds.Tables[0].Rows[i]["NC_Id"].ToString() %>" onmousemove="changeMove(this,'<%=t[1] %>')" onmouseout="changeLeve(this,'<%=t[0] %>')" ><%=t[0]%></a></li>
<%} %>
     
    </ul> <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
    
  </div>
  <div class="main_right2">
  <div class="main_right_body4">
    <div class="warp">
    <div id="top-title" class="font16px">翻譯團隊</div>
    	<p class="font16px">后冠翻譯公司擁有全球國際不同國家的專業翻譯人才，由世界各地國家級審譯、外籍專家、留學歸國人員以及各大研究院所碩士及博士所組成一流的翻譯精英團隊。</p>
        <div style="background:url(images/kehu_09.gif) no-repeat; color: #008080;font-size: 20px; margin-left:50px;padding-left:100px;width: 600px; height: 50px; line-height: 50px;"><p><%=NewsClassmo == null ? "翻譯團隊" : NewsClassmo.ClassName%></p>
        </div>
        <div class="logolist">
            <div class="clear"></div>
       <div class="comlist">
     	<p class="font14px" style="width:530px;">一直以來，我們以"專業翻譯，最高品質，優質服務"贏得眾多客戶，樹立良好口碑后冠聲明，擁有多種語言的團隊像是中翻英、英翻中、英文校稿、日翻中等等，因翻譯精英團隊人數眾多，僅列舉部份精英。</p>
      </div>
 <asp:Repeater ID="newrp" runat="server" >
 
 <ItemTemplate>       

 <table cellpadding="0" cellspacing="0" border="0" style="margin-top:6px;">
    <tr>
        <td width="24">&nbsp;</td>
        <td valign="middle">
            <span><img src="/<%# Eval("imgpath")%>" alt="英文 校稿" width="160"  /></span>
        </td>
        <td valign="top">
     <div class="team-info">
    <font style="color: #75A907">姓名：</font>
    <span><%# Eval("tname")%></span>
    <br/>
    <font style="color: #75A907">性別：</font>
    <%# Eval("avater").ToString() == "0" ? "男" : "女"%>
    <br/>
    <font style="color: #75A907">自我介紹：</font>
    <div class="descript"> <%# Eval("descript")%></div>
    </div>
    </td>
    </tr>
  </table>   
      
</ItemTemplate>


    </asp:Repeater>
<table width="600" cellspacing="0" cellpadding="0" border="0" style="margin-top:10px;">
<tbody>
<tr>
<td align="center" colspan="2" style="height:10px;">
<div id="AspNetPager1">
<webdiyer:aspnetpager id="AspNetPager2" runat="server" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" PageSize="10" prevpagetext="上一頁" OnPageChanged="AspNetPager2_PageChanged"></webdiyer:aspnetpager>
</div>
</td>
</tr>
</tbody>
</table>
                        
                                
   </div>
  </div>
  <div><img src="images/kehu_133.png" width="745" alt="英文 校稿"/></div>
</div>
</div>
</div>
<div style="clear:both">&nbsp;</div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="英文 校稿"/></div>
<uc2:foot ID="foot1" runat="server" />
    </form>


</body>
</html>

