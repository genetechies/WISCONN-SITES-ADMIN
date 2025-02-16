<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="ZeroStudio.Web.Admin.News_Class.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>編輯欄位</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table_main">
                <tr>
                    <td class="table_tittle" colspan="2">編輯欄位</td>
                </tr>
                <tr>
                    <td align="right" width="40%">欄位名稱：</td>
                    <td align="left">
                        <asp:TextBox ID="tb_ClassName" runat="server"
                            MaxLength="255" Columns="255" />
                    </td>
                </tr>
                <tr>
                    <td align="right" width="40%">欄位排序(請輸入數字鍵，如1,2,3...)：</td>
                    <td align="left">
                        <asp:TextBox ID="tb_Sort" runat="server"
                            MaxLength="25" Columns="25" />
                    </td>
                </tr>
                 <tr>
                    <td align="right" width="40%">Description：</td>
                    <td align="left">
                        <asp:TextBox ID="description" runat="server"/>
                        </td>
                </tr>
                <tr>
                    <td align="right" width="40%">Keywords：</td>
                    <td align="left">
                        <asp:TextBox ID="keywords" runat="server"
                           />
                       </td>
                </tr>
                <tr>
                    <td align="right" width="40%">文章列表標題：</td>
                    <td align="left">
                        <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="right" width="40%">文章列表描述：</td>
                    <td align="left">
                        <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="編輯" OnClick="Sub_Click" />
                        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
