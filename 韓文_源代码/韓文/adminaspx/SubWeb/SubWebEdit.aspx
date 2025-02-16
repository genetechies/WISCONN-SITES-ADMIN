<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubWebEdit.aspx.cs" Inherits="adminaspx_SubWeb_SubWebEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改子網站</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="../Js/jquery.min.js"></script>
    <script src="../Js/WebCalendar.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <table class="table_main">
            <tr>
            <td class="table_tittle" colspan="2">修改子網站</td>
            </tr>
            <tr>
            <td  align="right" width="10%">網站名：</td>
            <td  align="left">
                <asp:TextBox ID="txtTitle" runat="server" MaxLength="50" Width="350px" /> <input type="hidden" id="hidswid" runat="server" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"  ErrorMessage="*"></asp:RequiredFieldValidator></td>
            </tr>
            
             <tr>
            <td align="right" width="10%">網域名：</td>
            <td  align="left">
                <asp:TextBox ID="txtDomain" runat="server" MaxLength="50" Width="350px" /> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDomain"  ErrorMessage="*"></asp:RequiredFieldValidator>
                <label>以"http://"開始</label>
            </td>
            </tr>
            <tr >
              <td align="right" width="10%">資料庫名稱：</td>
              <td align="left">
                 <asp:TextBox ID="txtDBName" runat="server" MaxLength="50" Width="350px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDBName"  ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
            </tr>
            <tr >
              <td align="right" width="10%">資料庫標誌：</td>
              <td align="left">
                 <asp:TextBox ID="txtDBID" runat="server" MaxLength="50" Width="350px"></asp:TextBox><input type="hidden" id="hiddbid" runat="server" />
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDBID"  ErrorMessage="*"></asp:RequiredFieldValidator>
                 <label>更改資料庫標誌會造成正在使用的數據丟失，請慎重</label>
              </td>
            </tr>
            <tr >
              <td align="right" width="10%">資料庫地址：</td>
              <td align="left">
                 <asp:TextBox ID="txtDBService" runat="server" MaxLength="50" Width="350px"></asp:TextBox>
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDBService"  ErrorMessage="*"></asp:RequiredFieldValidator>
              </td>
            </tr>
            <tr >
              <td align="right" width="10%">帳戶：</td>
              <td align="left">
                 <asp:TextBox ID="txtDBUser" runat="server" MaxLength="50" Width="350px"></asp:TextBox><input type="hidden" id="hiddbuser" runat="server"/>
                 
                 <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtDBUser"  ErrorMessage="*"></asp:RequiredFieldValidator>
                 <label>更改帳戶名稱必須先更改數據庫標識</label>
              </td>
            </tr>
            <tr>
                <td align="right" width="10%">
                    密碼：</td>
                <td align="left">
                    <asp:TextBox ID="txtDBPwd" runat="server" MaxLength="50"/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtDBPwd"  ErrorMessage="*"></asp:RequiredFieldValidator>
                </td>
                    
            </tr>
            <tr>
                <td  align="center" colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="提交"  OnClick="btnSubmit_Click"/> &nbsp;&nbsp;
                    <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
            </tr>
        </table>
           
    </div>
    </form>
</body>
</html>
