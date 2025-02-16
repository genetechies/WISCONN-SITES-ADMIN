<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeFile="Edit.aspx.cs" Inherits="Web.Admin.News.Edit" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>編輯類別文章內容</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<table class="table_main">
    <tr>
    <td class="table_tittle" colspan="2">編輯類別文章內容</td>
    </tr>
    <tr>
    <td  align="right" width="10%">標題：</td>
    <td  align="left">
        <asp:TextBox ID="txtTitle" runat="server" MaxLength="50" Width="350px" /> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"  ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:Label ID="lb_ParentID" runat="server" Visible="False"></asp:Label>
        </td>
    </tr>
    
     
    <tr >
      <td align="right" width="10%">作者：</td>
      <td align="left">
         <asp:TextBox ID="txtAuthor" runat="server" MaxLength="50" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAuthor"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    
    <tr>
      <td align="right" width="10%">Keyword：</td>
      <td align="left">
         <asp:TextBox ID="txtKeyword" runat="server" MaxLength="200" Width="350px" Text="輸入關鍵詞"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtKeyword"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">Description：</td>
      <td align="left">
         <asp:TextBox ID="txtDescription" runat="server" MaxLength="1500" TextMode="multiLine" Columns="200" Rows="5" Text="輸入網頁描述"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDescription"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
    <td align="center" width="10%">網頁內容：<br />換行請按<span style='color:Red'>Shift+Enter</span><br /> 另起一行請按<span style='color:Red'>Enter</span> </td>
   </td>
    <td  align="left">
        
       
        <FCKeditorV2:FCKeditor ID="FCKeditor1" Height="450px" runat="server">
        </FCKeditorV2:FCKeditor>
        
       
    </td>
    </tr>
        <tr>
    <td  align="center" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="提交"  OnClick="Sub_Click"/> 
        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
