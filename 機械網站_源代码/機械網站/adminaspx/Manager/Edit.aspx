<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="Web.Admin.Manager.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改密碼</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table_main">
                <tr>
                    <td  class="table_tittle" align="center" colspan="2">
                        修改密碼</td>
                </tr>
                <tr>
                    <td align="right"  style="width: 200px">舊的密碼：</td>
                    <td width="461" align="left" >
                      <asp:TextBox ID="tb_OldPwd" TextMode="Password" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="tb_OldPwd"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td align="right"  style="width: 200px">新的密碼：</td>
                    <td align="left" >
                      <asp:TextBox ID="tb_NewPwd" TextMode="Password" runat="server"></asp:TextBox>
                      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="tb_NewPwd"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td align="right"  style="width: 200px">確認密碼：</td>
                    <td align="left" >
                      <asp:TextBox ID="tb_ChkPwd" TextMode="Password" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" ControlToValidate="tb_ChkPwd"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td colspan="2" align="center" >
                        <asp:Button ID="btn_Modpwd" runat="server" Text="修改" OnClick="Sub_Click" />
                        <input id="Reset1" type="reset" value="重置" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
