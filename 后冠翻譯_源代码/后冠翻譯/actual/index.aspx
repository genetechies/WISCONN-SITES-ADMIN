<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="HTML_index" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠翻譯公司提供30多種的各國語言翻譯包含：中文、英文、日文、韓文、法文、德文、義文、俄文、越南、泰國、西班牙、葡萄牙、阿拉伯等語系及多元化的服務項目，包括筆譯、口譯、網頁翻譯、影視翻譯、公證文書、打字排版、聽打逐字稿、錄音配音、網站多語化等相關翻譯技術。 "/>
<meta name="keywords" content="翻譯公司 英文,翻譯公司 日文" /> 
<meta name="copyright" content="后冠翻譯公司"/>
<meta name="author" content="后冠翻譯公司"/>
<meta name="classification" content="翻譯公司"/>
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
    
    <img src="images/kehu_02.jpg" width="955" height="244" alt="翻譯公司 英文"/></div>
<!--主要内容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="翻譯公司 英文"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2 style="background:url(images/hg_2_001.gif) left top no-repeat;">客戶實績</h2>
    <h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2>
    <ul>
    <%
        
        System.Data.DataSet ds=new BLL.guoclass().GetAll();
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
      <li><a href="index.aspx?guoclassid=<%=ds.Tables[0].Rows[i]["NC_Id"].ToString() %>" onmousemove="changeMove(this,'<%=t[1] %>')" onmouseout="changeLeve(this,'<%=t[0] %>')" ><%=t[0]%></a></li>
<%} %>
    </ul>
    <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
  </div>
  <div class="main_right2" style="padding-top: 12px;">
    <div class="main_right_body4">
    <div class="warp">
    <div id="top-title" class="font16px">客戶實績</div>
    	<p class="font16px">后冠翻譯公司已成功服務無數國內知名外企業，這些行家的肯定，正是我們品質、價值與服務努力的有力證明！</p>
        <div class="kehu_title"><div style="background:url(images/kehu_09.gif) no-repeat; font-size:16px; font-weight:bold; height:60px; padding-left:90px; line-height:60px;">翻譯成功案例-
        <%string NC_ClassName = "財金金融類";
          if (Request["guoclassid"] != null)
          {
              NC_ClassName = new BLL.guoclass().GetModel(Convert.ToInt32(Request["guoclassid"])).ClassName.Split('|')[0];
          }
             %>
        <%=NC_ClassName%></div></div>
	 <div class="logolist">
	 <%
	  //string where=" guoclassid=1 ";
      string where = "";   
      if (Request["guoclassid"] != null)
      {
          where = " guoclassid=" + Request["guoclassid"].ToString().Trim();
      }

      System.Data.DataSet dslog = new BLL.guopic().GetList(where);
      for (int i = 0; i < dslog.Tables[0].Rows.Count; i++)
      {
          if (i < 24)
          { %>
       <div class="picbox"><img src="/<%=dslog.Tables[0].Rows[i]["pic"].ToString().Trim() %>" width="120" height="60" alt="<%=dslog.Tables[0].Rows[i]["title"].ToString().Trim() %>" />
         <h3><%=dslog.Tables[0].Rows[i]["title"].ToString().Trim()%></h3></div>
         <% } %>
      <%} %>
       
         
       <div class="clear"></div>
      <div class="bgline" ><img src="images/kehu_51.gif" width="640" height="30" alt="翻譯公司 日文" /></div>
    
       <div class="comlist">
     	<p class="font14px">一直以來，我們以"專業翻譯，最高品質，優質服務"贏得眾多客戶，樹立良好口碑<br/>后冠聲明：因客戶眾多，僅列舉部份客戶的名稱，排名不分先後</p>
      </div>
      </div>
          <table width="84%" align="center" border="0" cellspacing="0" cellpadding="0" class="casetable">
  <tr>
    <td colspan="3">協助國際企業翻譯之成功案例：</td>
    </tr>
    <%System.Data.DataSet dslycs = new BLL.linyuclass().GetAll();
      for (int i = 0; i < dslycs.Tables[0].Rows.Count; i++)
      {
         %>
  <tr>
    <td colspan="3" align="center"><span class="red"><%=dslycs.Tables[0].Rows[i]["ClassName"].ToString().Trim()%></span></td>
    </tr>
  <tr>
  <%
          System.Data.DataSet dslyxx = new BLL.linyuxinxi().GetList(" linyuclassid= " + dslycs.Tables[0].Rows[i]["id"].ToString().Trim());
    for (int j = 0; j < dslyxx.Tables[0].Rows.Count; j++)
    {      
          %>
    <td><%=dslyxx.Tables[0].Rows[j]["title"].ToString().Trim()%></td>
    <%if (  (j==(dslyxx.Tables[0].Rows.Count-1)) && ((j+1)%3!=0) ) {%>
	<td>&nbsp;</td>
	<%}%>
	<%if ((j + 1) % 3 == 0)
   {%>
	</tr><tr>
	<%}%>
    <%} %>
  </tr>
  <%} %>
  
</table>

</div>
<div><img src="images/kehu_133.png" width="745" alt="翻譯公司 日文"/></div>
    </div>
  </div>
</div>
<div style="clear:both"></div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 英文"/></div>
<uc2:foot ID="foot1" runat="server" />
    </form>
</body>
</html>
