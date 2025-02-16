<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_Email_Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>編輯指定發送E-MAIL</title>
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
         <td width="18%" >聯絡人</td>
         <td width="82%" colspan="2">
             <asp:TextBox ID="txtUserName" runat="server" Width="100px"></asp:TextBox>
         </td>
       </tr>
       <tr>
         <td >E-mail</td>
         <td  colspan="2">
             <asp:TextBox ID="txtEmail" runat="server" Width="300px"></asp:TextBox>
         </td>
       </tr>
       <tr>
         <td >&nbsp;</td>
         <td colspan="2">
            <input type="hidden" runat="server" id="gid" />
             <asp:Button ID="Button1" runat="server" Text="編輯" onclick="Button1_Click"  />&nbsp;&nbsp;&nbsp;
             <input id="Reset1" type="reset" value="返回" onclick="history.go(-1)" />         
         </td>
       </tr>
    </table>
    </div>
    </form>
</body>
</html>