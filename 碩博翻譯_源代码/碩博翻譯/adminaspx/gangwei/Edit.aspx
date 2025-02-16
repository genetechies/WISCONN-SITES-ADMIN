<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeFile="Edit.aspx.cs" Inherits="Web.Admin.News.Edit" %>

<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>編輯招聘崗位</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<table class="table_main">
    <tr>
    <td class="table_tittle" colspan="2">編輯人才招募</td>
    </tr>
    <tr>
    <td  align="right" width="10%">崗位名稱：</td>
    <td  align="left">
        <asp:TextBox ID="txt_gangwei" runat="server" MaxLength="50" Width="350px" /> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txt_gangwei"  ErrorMessage="*"></asp:RequiredFieldValidator></td>
    </tr>
    
     <tr>
    <td align="right" width="10%">學歷要求：</td>
    <td  align="left">
        <asp:TextBox ID="txt_xueli" runat="server" Width="350px"></asp:TextBox>
    </td>
    </tr>
    <tr >
      <td align="right" width="10%">招聘人數：</td>
      <td align="left">
         <asp:TextBox ID="txt_renshu" runat="server" MaxLength="50" ></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">工作地點：</td>
      <td align="left">
          <asp:TextBox ID="txt_didian" runat="server" Width="350px"></asp:TextBox>
          &nbsp;
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">工資待遇：</td>
      <td align="left">
         <asp:TextBox ID="txt_daiyu" runat="server" MaxLength="200" Width="350px" 
              Text="面議"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">有效期限：</td>
      <td align="left">
         <asp:TextBox ID="txt_qixian" runat="server" MaxLength="50" ></asp:TextBox>
      </td>
    </tr>
    <tr>
    <td align="center" width="10%">具體要求：<br />換行請按<span style='color:Red'>Shift+Enter</span><br /> 另起一行請按<span style='color:Red'>Enter</span> </td>
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
