<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Left.aspx.cs" Inherits="ZeroStudio.Web.Admin.Left" %>

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
             if(document.getElementById(id).style.display=="block"){
                 document.getElementById(id).style.display="none";
                 document.getElementById("Img_"+id).src="images/collapse.gif";
             }
         }
     }
 }
</script>
</head>
<body style="background-color:#1589DC" oncontextmenu="return false" ondragstart="return false" onselectstart ="return false" onselect="document.selection.empty()" oncopy="document.selection.empty()" onbeforecopy="return false" onmouseup="document.selection.empty()">
<table  id="main" >
  <tr>
    <td valign="top" id="leftmenu"><div>
        <table width="100%" class="leftmenutable">
          <tr>
            <td class="slidebar"><img src="images/collapse.gif" alt=""  id="Img_1"  style="vertical-align:middle" onclick="SetExpand('1');"/> <a onclick="SetExpand('1');" href="#" >&nbsp;&nbsp;產品專區</a></td>
          </tr>
          <tr>
            <td><table  class="menu_list" id="1" style="display:none">
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="Product/Manage.aspx" target="main-frame">產品管理</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="Product/Add.aspx" target="main-frame">新增產品</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="ProductClass/Manage.aspx" target="main-frame">產品分類</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="ProductClass/QueryCategory.aspx" target="main-frame">分類查詢</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="Product/AutoUpload.aspx" target="main-frame">EXCEL批量匯入</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="Product/ImageUpload.aspx" target="main-frame">圖片批量上傳</a></td>
                </tr>
                <tr>
                  <td><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td><a href="Product/DocUpload.aspx" target="main-frame">文檔批量上傳</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="Product/ImportOut.aspx" target="main-frame">EXCEL批量匯出</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="Product/DeleteBox.aspx" target="main-frame">回收筒</a></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <!-- Filed  -->
        <table width="100%" class="leftmenutable">
          <tr>
            <td class="slidebar"><img src="images/collapse.gif" alt=""  id="Img_2"  style="vertical-align:middle" onclick="SetExpand('2');"/> <a onclick="SetExpand('2');" href="#" >&nbsp;&nbsp;連接器介紹</a></td>
          </tr>
          <tr>
            <td><table  class="menu_list" id="2" style="display:none">
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="News/Manage.aspx" target="main-frame">文章管理</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="News/Add.aspx" target="main-frame">新增文章</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="News_Class/Manage.aspx" target="main-frame">欄位管理</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="News_Class/Add.aspx" target="main-frame">新增欄位</a></td>
                </tr>
                <tr>
                  <td bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td bgcolor="#FFFFFF"><a href="News/DeleteBox.aspx" target="main-frame">回收筒</a></td>
                </tr>
              </table></td>
          </tr>
        </table>
        
        <table width="100%" class="leftmenutable">
          <tr>
            <td class="slidebar"><img src="images/collapse.gif" alt=""  id="Img_3" style="vertical-align:middle"  onclick="SetExpand('3');"/><a href="#" onclick="SetExpand('3');">&nbsp;&nbsp;用戶管理</a></td>
          </tr>
          <tr>
            <td><table  class="menu_list" id="3" style="display:none">
            	<tr>
                  <td width="22" bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td width="83" bgcolor="#FFFFFF"><a href="Manager/Manage.aspx" target="main-frame">管理員管理</a></td>
                </tr>
                <tr>
                  <td width="22" bgcolor="#FFFFFF"><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td width="83" bgcolor="#FFFFFF"><a href="Manager/Edit.aspx" target="main-frame">修改密碼</a></td>
                </tr>
              </table></td>
          </tr>
        </table>
        <table width="100%" class="leftmenutable">
          <tr>
            <td class="slidebar"><img src="images/collapse.gif" alt=""  id="Img_4" style="vertical-align:middle" onclick="SetExpand('4');"/><a href="#" onclick="SetExpand('4');">&nbsp;&nbsp;聯絡我們</a></td>
          </tr>
          <tr>
            <td><table  class="menu_list" id="4" style="display:none">
                <tr>
                  <td width="22" bgcolor="#FFFFFF" ><img src="images/icon_dotline.gif" width="24" height="17" /></td>
                  <td width="83" bgcolor="#FFFFFF"><a href="GuestBook/Manage.aspx" target="main-frame">留言管理</a></td>
                </tr>
              </table></td>
          </tr>
        </table>
        
      </div></td>
  </tr>
</table>
</body>
</html>