<%@ Page Language="C#" AutoEventWireup="true" CodeFile="newsinfo.aspx.cs" Inherits="newsinfo" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=moarticle.D_Title%></title>
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
     
    </ul>
     <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
  </div>
  <div class="main_right">
    <div class="main_right_body2">
     <div id="top-title" class="font26px">服務項目</div>
    <table width="699" border="0" cellspacing="0" cellpadding="0" align="center">
          <tr >
            <td width="699" height="60" align="center"><div class=titlename><h1 style=" font-size:18px;"><%=moarticle.D_Title%></h1></div>
            作者：<%=moarticle.D_Editor%> 　　加入時間：<span class="STYLE6"><%=moarticle.D_Time.ToShortDateString()%></span> 　　點擊次數：：<span class="STYLE6"><%=moarticle.D_Count %></span> 次 
			<div align="left" style="margin-top:10px; margin-bottom:30px; padding:10px;"> 
			  <%=moarticle.D_Content %>  			<br>
			</div>
             
			
		    </td>
          </tr>
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

