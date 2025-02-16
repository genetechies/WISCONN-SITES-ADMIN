<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="Web.Admin.Left" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
<link href="Css.css" rel="stylesheet" type="text/css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<script type="text/javascript">
    function SetExpand(No) {        
     var img = "Img_" + No;
     if (document.getElementById(No).style.display == "none") {
         document.getElementById(No).style.display = "block"
         document.getElementById(img).src = "images/expand.gif";
     }
     for (var i =1; i <= 9; i++) {        
         var id=i+"";
         if (id != No) {
             if (document.getElementById(id)) {
                 if (document.getElementById(id).style.display == "block") {
                     document.getElementById(id).style.display = "none";
                     document.getElementById("Img_" + id).src = "images/collapse.gif";
                 }
             }
         }
     }
 }
</script>
</head>
<body style="background-color:#1589DC" oncontextmenu="return false" ondragstart="return false" onselectstart ="return false" onselect="document.selection.empty()" oncopy="document.selection.empty()" onbeforecopy="return false" onmouseup="document.selection.empty()">
<table  id="main" >
  <tr>
    <td valign="top" id="leftmenu">
    <div>
    <table width="100%" class="leftmenutable" id="five" runat="server">
  <tr>
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_5"  style="vertical-align:middle" onclick="SetExpand('5');"/><a onclick="SetExpand('5');" href="#" >&nbsp;&nbsp;基本訊息</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="5" style="display:block">
      <tr id="webset" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="websys/webset.aspx" target="main-frame">網站基本設置</a></td>
      </tr>
    </table>
    </td>
  </tr>
</table>
<%--
<table width="100%" class="leftmenutable">
  <tr>
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_1"  style="vertical-align:middle" onclick="SetExpand('1');"/><a onclick="SetExpand('1');" href="#" >&nbsp;&nbsp;前台網頁管理</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="1" style="display:none">
      <tr>
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="news/jbManage.aspx" target="main-frame">文章列表管理</a></td>
      </tr>
    </table>
    </td>
  </tr>
</table>--%>


<table width="100%" class="leftmenutable" id="eight" runat="server">
  <tr>
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_8"  style="vertical-align:middle" onclick="SetExpand('8');"/>
    <a onclick="SetExpand('8');" href="#" >&nbsp;&nbsp;翻譯資訊管理</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="8" style="display:none">
      <tr id="news" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="news/NewsManage.aspx" target="main-frame">文章列表管理</a></td>
      </tr>
      <tr id="newsInsert" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="news/Add.aspx" target="main-frame">新增文章</a></td>
      </tr>
      <tr id ="articleclass" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="articleclass/Manage.aspx" target="main-frame">文章類別管理</a></td>
      </tr>
      <tr id="newsrover" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="news/DeleteBox.aspx" target="main-frame">回收桶</a></td>
      </tr>
    </table>
    </td>
  </tr>
</table>
<!-- 翻譯領域 -->
<%--<table width="100%" class="leftmenutable" id="nine" runat="server">
  <tr>
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_9"  style="vertical-align:middle" onclick="SetExpand('9');"/>
    <a onclick="SetExpand('9');" href="#" >&nbsp;&nbsp;翻譯領域管理</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="9" style="display:none">
      <tr id="NewsManage" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/Manage.aspx" target="main-frame">翻譯領域列表</a></td>
      </tr>
      <tr id="ElseNewsInsert" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/Add.aspx" target="main-frame">新增翻譯領域</a></td>
      </tr>
      <tr id="transzonetype" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/transzonetype.aspx" target="main-frame">翻譯領域類別管理</a></td>
      </tr>
      <tr id="ElseNewsover" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/DeleteBox.aspx" target="main-frame">回收桶</a></td>
      </tr>
    </table>
    </td>
  </tr>
</table>--%>

<table width="100%" class="leftmenutable" id="one" runat="server">
  <tr>
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_1"  style="vertical-align:middle" onclick="SetExpand('1');"/>
    <a onclick="SetExpand('1');" href="#" >&nbsp;&nbsp;翻譯團隊管理</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="1" style="display:none">
       <tr id="guopic1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/TeamEdit.aspx" target="main-frame">新增翻譯團隊</a></td>
      </tr>
      <tr id="team1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/TeamList.aspx" target="main-frame">翻譯團隊管理</a></td>
      </tr>
       <tr id="transzonetype1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="transzone/TeamType.aspx" target="main-frame">翻譯團隊類別管理</a></td>
      </tr>
     
    </table>
    </td>
  </tr>
</table>

<table width="100%" class="leftmenutable" id="secondstyle" runat="server">
  <tr> 
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_2" style="vertical-align:middle"  onclick="SetExpand('2');"/><a href="#" onclick="SetExpand('2');">&nbsp;&nbsp;客戶實績</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="2" style="display:none">
      <tr id="guoclass" runat="server">
        <td width="22" bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td width="83" bgcolor="#FFFFFF"><a href="news_class/Manage.aspx" target="main-frame">服務項目類別管理</a></td>
      </tr>
      <tr id="linyuclass" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyu_Class/Manage.aspx" target="main-frame">洲類別管理</a></td>
      </tr>
      <tr id="guopic" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="guopic/Manage.aspx" target="main-frame">LOGO小圖管理</a></td>
      </tr>
   <%--   <tr id="pluppic" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="guopic/ImageUpload.aspx" target="main-frame">LOGO圖批量上傳</a></td>
      </tr>--%>
      <%--<tr>old
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="guopic/outlyxx.aspx" target="main-frame">匯出LOGO圖信息</a></td>
      </tr>--%>
     <%-- <tr id="outlogo" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="guopic/outlyxx2.aspx" target="main-frame">匯出LOGO圖信息</a></td>
      </tr>--%>
      <%--<tr>old
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="guopic/Importlyxx.aspx" target="main-frame">匯入LOGO圖信息</a></td>
      </tr>--%>
      <%--<tr id="logodr" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="guopic/Importlyxx2.aspx" target="main-frame">匯入LOGO圖信息</a></td>
      </tr>--%>
      <tr id="linyuxinxi" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyuxinxi/Manage.aspx" target="main-frame">廠商信息管理</a></td>
      </tr>
      <%--<tr>old
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyuxinxi/outlyxx.aspx" target="main-frame">匯出廠商信息</a></td>
      </tr>--%>
    <%--  <tr id="outlyxx" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyuxinxi/outlyxx2.aspx" target="main-frame">匯出廠商信息</a></td>
      </tr>--%>
      <%--<tr>old
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyuxinxi/Importlyxx.aspx" target="main-frame">匯入廠商信息</a></td>
      </tr>--%>
      <%--<tr id="exceldr" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyuxinxi/Importlyxx2.aspx" target="main-frame">匯入廠商信息</a></td>
      </tr>--%>
      <tr id="lyxxrover" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="lingyuxinxi/DeleteBox.aspx" target="main-frame">回收桶</a></td>
      </tr>
      
    </table></td>
  </tr>
</table>
<table width="100%" class="leftmenutable" id="thrid" runat="server">
  <tr> 
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_3" style="vertical-align:middle" onclick="SetExpand('3');"/><a href="#" onclick="SetExpand('3');">&nbsp;&nbsp;用戶管理</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="3" style="display:none">
      <tr>
        <td width="22" ><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td width="83" bgcolor="#FFFFFF"><a href="Manager/Manage.aspx" target="main-frame">管理員管理</a></td>
      </tr>
      <tr>
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Manager/Edit.aspx" target="main-frame">修改密碼</a></td>
      </tr>
    </table></td>
  </tr>
</table>
<%--<table width="100%" class="leftmenutable" id="four" runat="server">
  <tr> 
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_4" style="vertical-align:middle"  onclick="SetExpand('4');"/><a href="#" onclick="SetExpand('4');">&nbsp;&nbsp;線上咨詢</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="4" style="display:none">
      <tr id="guest1" runat="server">
        <td width="22"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td width="83"><a href="GuestBook/Manage.aspx" target="main-frame">線上咨詢管理</a></td>
      </tr>
      <tr id="guestemail1" runat="server">
        <td width="22"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td width="83"><a href="Email/Index.aspx" target="main-frame">指定發送E-MAIL</a></td>
      </tr>
    </table></td>
  </tr>
</table>--%>
<%--<table width="100%" class="leftmenutable" id="six" runat="server"> 
  <tr>
    <td class="slidebar"><img src="images/expand.gif" alt="日文翻譯"  id="Img_6"  style="vertical-align:middle" onclick="SetExpand('1');"/><a onclick="SetExpand('6');" href="#" >&nbsp;&nbsp人才招募</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="6" style="display:none">
      <tr id="yingpin1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="yingpingjl/Manage.aspx" target="main-frame">求職履歷管理</a></td>
      </tr>
      <tr id="outjianli1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="yingpingjl/outjianli2.aspx" target="main-frame">匯出履歷</a></td>
      </tr>
    </table>
    </td>
  </tr>
</table>--%>
<table width="100%" class="leftmenutable" id="seven" runat="server">
  <tr> 
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_7" style="vertical-align:middle"  onclick="SetExpand('7');"/><a href="#" onclick="SetExpand('7');">友好連結及合作夥伴</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="7" style="display:none">
      
      <tr id="friendlyInsert" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Friendly/Add.aspx" target="main-frame">新增友好連結</a></td>
      </tr>
      <tr id="friendlyManage" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Friendly/Manage.aspx" target="main-frame">友好連結列表</a></td>
      </tr>
      <tr id="friendlyupdown" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Friendly/Importfriendly.aspx" target="main-frame">友好連結匯入</a></td>
      </tr>
      <tr id="friendlyupdown1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Friendly/outfriendly.aspx" target="main-frame">友好連結匯出</a></td>
      </tr>
      
      <tr id="friendly1" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Partners/Add.aspx" target="main-frame">新增合作夥伴</a></td>
      </tr>
      <tr id="friendly2" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Partners/Manage.aspx" target="main-frame">合作夥伴列表</a></td>
      </tr>
      <tr id="friendly3" runat="server"> 
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Partners/ImportPartners.aspx" target="main-frame">合作夥伴匯入</a></td>
      </tr>
      <tr id="friendly4" runat="server">
        <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td><a href="Partners/outpartners.aspx" target="main-frame">合作夥伴匯出</a></td>
      </tr>
      
    </table></td>
  </tr>
</table>

<%--<table width="100%" class="leftmenutable" id="ten" runat="server">
  <tr> 
    <td class="slidebar"><img src="images/collapse.gif" alt="日文翻譯"  id="Img_11" style="vertical-align:middle"  onclick="SetExpand('11');"/><a href="#" onclick="SetExpand('11');">&nbsp;&nbsp;子網站管理</a></td>
  </tr>
  <tr>
    <td><table  class="menu_list" id="11" style="display:none">
      <tr id="WebSubInsert" runat="server">
        <td width="22"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td width="83"><a href="SubWeb/SubWebAdd.aspx" target="main-frame">增加子網站</a></td>
      </tr>
      <tr id="WebSubManage" runat="server">
        <td width="22"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
        <td width="83"><a href="SubWeb/SubWebList.aspx" target="main-frame">子網站列表</a></td>
      </tr>
    </table></td>
  </tr>
</table>--%>


    </div>
    </td>
  </tr>
</table>
</body>
</html>