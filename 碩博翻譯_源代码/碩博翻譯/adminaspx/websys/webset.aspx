<%@ Page Language="C#" AutoEventWireup="true" CodeFile="webset.aspx.cs" ValidateRequest="false" Inherits="Web.Admin.Product.Edit" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>網站基本設置</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
    <tr>
    <td class="table_tittle" align="center" colspan="2">網站基本設置</td>
    </tr>
    <tr>
       <td class="lanyuds" align="center">網站標題：</td>
       <td class="lanyuds" align="left">
           <asp:TextBox ID="txt_sys_Title" runat="server" MaxLength="50" Width="300px" />
           <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="網站標題不能為空" 
               SetFocusOnError="true" ControlToValidate="txt_sys_Title" ></asp:RequiredFieldValidator>
       </td>
    </tr>
        <tr>
       <td class="lanyuds" align="center">網站key：</td>
       <td class="lanyuds" align="left">
           <asp:TextBox ID="txt_searchkey" runat="server" MaxLength="50" Width="400px" 
               Height="86px" TextMode="MultiLine" />
           
       </td>
    </tr>
            <tr>
       <td class="lanyuds" align="center">網站description：</td>
       <td class="lanyuds" align="left">
           <asp:TextBox ID="txt_sys_description" runat="server" MaxLength="50" Width="400px" 
               Height="86px" TextMode="MultiLine" />
           
       </td>
    </tr>
    <tr>
    <td class="lanyuds" align="center" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Sub_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
