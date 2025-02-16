<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" ValidateRequest="false" Inherits="ZeroStudio.Web.Admin.Product.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>編輯產品</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table_main">
                <tr>
                    <td class="table_tittle" align="center" colspan="2">編輯產品</td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">產品編號：</td>
                    <td class="lanyuds" align="left">
                        <asp:TextBox ID="txtCode" runat="server" MaxLength="50" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" SetFocusOnError="true" ControlToValidate="txtCode"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">產品料號：</td>
                    <td class="lanyuds" align="left">
                        <asp:TextBox ID="txtModel" runat="server" MaxLength="50" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" SetFocusOnError="true" ControlToValidate="txtModel"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">第三層欄位名稱：</td>
                    <td class="lanyuds" align="left">
                        <asp:DropDownList ID="MyDL" runat="server"></asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">第四層JPG圖片檔：</td>
                    <td class="lanyuds" align="left">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:Button ID="Button2" runat="server" Text="上傳" OnClick="UpFile_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">第四層JPG圖片檔路徑：</td>
                    <td class="lanyuds" align="left">
                        <asp:TextBox ID="txtPhotoUrl" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">產品詳細PDF檔：</td>
                    <td class="lanyuds" align="left">
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                        <asp:Button ID="Button3" runat="server" Text="上傳" OnClick="UpFileDoc_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="right">產品詳細PDF檔路徑：</td>
                    <td class="lanyuds" align="left">
                        <asp:TextBox ID="txtDoc" runat="server" ReadOnly="true"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" width="40%">Description：</td>
                    <td align="left">
                        <asp:TextBox ID="description" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right" width="40%">Keywords：</td>
                    <td align="left">
                        <asp:TextBox ID="keywords" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right" width="40%">上文字：</td>
                    <td align="left">
                        <asp:TextBox ID="txtUpKey" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td align="right" width="40%">下文字：</td>
                    <td align="left">
                        <asp:TextBox ID="txtDownKey" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td class="lanyuds" align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="提交" OnClick="Sub_Click" />
                        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
