<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Web.Admin.Manager.Manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理員管理</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table_main" >
                <tr>
                    <td class="table_tittle" colspan="3">
                        管理員管理</td>
                </tr>
                <tr>
                    <td align="center" width="40%">
                        用戶名</td>
                    <td align="center">
                        建立時間</td>
                    <td align="center">
                        操作選項</td>
                </tr>
                <asp:Repeater ID="rpt_List" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td class="lanyuds" align="center">
                                <%#Eval("M_AdminName") %>
                            </td>
                            <td class="lanyuds" align="center">
                                <%#Eval("M_DateTime") %>
                            </td>
                            <td class="lanyuds" align="center">
                                <asp:LinkButton ID="LB1" CommandName='<%#Eval("M_id") %>' OnCommand="Del_Click" runat="server"
                                    OnClientClick="return confirm('確定刪除嗎?')" >刪除</asp:LinkButton>&nbsp;&nbsp;
                                <asp:LinkButton ID="lbRight" runat="server" CommandArgument='<%#Eval("M_id") %>' Text="分配權限" OnClick="lbRight_Click"></asp:LinkButton>
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
            <br />
            <table class="table_main">
                <tr>
                    <td class="table_tittle"  colspan="3">
                        添加用戶</td>
                </tr>
                <tr>
                    <td  align="center">
                        用戶名稱：<asp:TextBox ID="tb_adminname" Width="200px" runat="server"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="rfvName" runat="server" SetFocusOnError="true" ControlToValidate="tb_adminname" ErrorMessage="請輸入用戶名稱" ValidationGroup="add"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td  align="center">
                        用戶密碼：<asp:TextBox ID="tb_password" Width="200px" TextMode="Password" runat="server"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="rfvpwd1" runat="server" SetFocusOnError="true" ControlToValidate="tb_password" ErrorMessage="請輸入用戶密碼" ValidationGroup="add"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td  align="center">
                        確認密碼：<asp:TextBox ID="tb_password2" Width="200px" TextMode="Password" runat="server"></asp:TextBox>
                        &nbsp;<asp:RequiredFieldValidator ID="rfvpwd2" runat="server" SetFocusOnError="true" ControlToValidate="tb_password2" ValidationGroup="add" ErrorMessage="請輸入確認密碼"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td  align="center">
                        <asp:Button ID="Button1" runat="server" Text="添加" ValidationGroup="add" OnClick="Sub_Click" />
                        <input id="Reset1" type="reset" value="重置" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
