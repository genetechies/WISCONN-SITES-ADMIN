<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="adminaspx_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>後臺登入</title>
    <link href="./Css.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        if (self != top) {
            top.location = self.location;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <table width="280" align="center" border="1" cellspacing="0" class="lanyubk" style="border-collapse: collapse">
                <tr>
                    <td class="lanyuss" align="center" colspan="2">
                        管理登入</td>
                </tr>
                <tr class="lanyuds">
                    <td class="lanyuds" width="80">
                        &nbsp;用 戶：</td>
                    <td class="lanyuds" style="width: 200px">
                        <asp:TextBox ID="tb_Name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="lanyuds">
                        &nbsp;密 碼：</td>
                    <td class="lanyuds" style="width: 200px">
                        <asp:TextBox ID="tb_Pwd" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td class="lanyuds">
                        &nbsp;驗證碼:</td>
                    <td class="lanyuds" style="width: 200px">
                        <asp:TextBox ID="ChkCode" runat="server" MaxLength="5" Columns="5"></asp:TextBox>
                        <img alt="驗證碼" src="./Validata.aspx" />
                    </td>
                </tr>
                <tr>
                    <td class="lanyuqs" colspan="2" align="center">
                        <asp:Button ID="Button1" runat="server" Text="登入" OnClick="Sub_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>