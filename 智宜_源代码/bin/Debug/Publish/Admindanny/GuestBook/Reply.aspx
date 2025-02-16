<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reply.aspx.cs" Inherits="ZeroStudio.Web.Admin.GuestBook.Reply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>詳細內容</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td colspan="3" ><strong>詳細內容</strong></td>
       </tr>
       <tr>
         <td width="18%" >主旨</td>
         <td width="82%" colspan="2" >
             <asp:Label ID="lblTitle" runat="server" ></asp:Label>
         </td>
       </tr>
       <tr>
         <td width="18%">聯絡人</td>
         <td width="82%" colspan="2">
             <asp:Label ID="lblUserName" runat="server"></asp:Label>
         </td>
       </tr>
       <tr>
         <td width="18%">E-mail</td>
         <td width="82%" colspan="2">
             <asp:Label ID="lblEmail" runat="server"></asp:Label>
         </td>
       </tr>
       <tr>
         <td width="18%">詳細內容</td>
         <td width="82%" colspan="2">
             <asp:Literal ID="ltlContent" runat="server"></asp:Literal>
         </td>
       </tr>
       <tr>
         <td width="18%">留言時間</td>
         <td width="82%" colspan="2">
             <asp:Label ID="lblTime" runat="server"></asp:Label>
         </td>
       </tr>
       <tr>
         <td width="18%" >&nbsp;</td>
         <td width="82%" colspan="2">
             <input id="Reset1" type="reset" value="返回" onclick="history.go(-1)" />         
         </td>
       </tr>
    </table>
    </div>
    </form>
</body>
</html>
