<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Admin_Friendly_Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改友好連結</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="table_main">
    <tr>
    <td class="table_tittle" colspan="2">修改友好連結</td>
    </tr>
    <tr>
    <td  align="right" class="style1">廠商名稱：</td>
    <td  align="left">
        <asp:TextBox ID="txtTitle" runat="server" MaxLength="50" Width="150px" /> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"  ErrorMessage="*"></asp:RequiredFieldValidator></td>
    </tr>
    
     <tr>
    <td align="right" class="style1">超連結：</td>
    <td  align="left">
        <asp:TextBox ID="txtUrl" runat="server" MaxLength="100" Width="350px" /> 
    </td>
    </tr>
    <tr>
      <td align="right" class="style1">擺放位置：</td>
      <td align="left">
         &nbsp;<asp:RadioButton ID="LRadio1" GroupName="LocationRadio" 
              runat="server" Text="整站" />
          &nbsp;&nbsp;<asp:RadioButton ID="LRadio2"  GroupName="LocationRadio" 
              runat="server" Text="友好連結" />
              &nbsp;&nbsp;<asp:RadioButton ID="LRadio3"  GroupName="LocationRadio" 
              runat="server" Text="首頁" />
              &nbsp;&nbsp;<asp:RadioButton ID="LRadio4"  GroupName="LocationRadio" 
              runat="server" Text="友好連結及首頁" /> &nbsp;&nbsp;<asp:RadioButton ID="LRadio5" GroupName="LocationRadio" runat="server"
                        Text="其它頁" />
                    &nbsp;&nbsp;<asp:RadioButton ID="LRadio6" GroupName="LocationRadio" runat="server"
                        Text="其它頁及首頁" />
                    &nbsp;&nbsp;<asp:RadioButton ID="LRadio7" GroupName="LocationRadio" runat="server"
                        Text="其它頁及友好連結" />
      </td>
    </tr>
    
   
   
        <tr>
    <td  align="center" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="修改"  OnClick="Sub_Click"/> 
        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
