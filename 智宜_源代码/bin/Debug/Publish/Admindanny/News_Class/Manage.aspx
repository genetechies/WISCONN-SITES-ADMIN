<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="ZeroStudio.Web.Admin.News_Class.Manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>欄位管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
<table class="table_main" >
    <tr>
    <td class="table_tittle"  colspan="2">欄位管理</td>
    <td>
        <strong><a href="add.aspx" > >>新增欄位</a></strong>
        <asp:Button ID="btnUpdateDB" runat="server" OnClick="btnUpdateDB_Click" Text="插入字段" />
    </td>
    </tr>
    <tr>
    <td align="center" width="30%">欄位名稱</td>
    <td align="center">欄位排序</td>
    <td align="center">操作選項</td>
    </tr>
    <asp:Repeater ID="rpt_list" runat="server">
    <ItemTemplate>
     <tr>
    <td  align="center" width="30%"><%#Eval("NC_ClassName") %></td>
    <td  align="center"><font color="red"><%#Eval("NC_Sort") %></font></td>
    <td  align="center">
       <a href="./Edit.aspx?NC_Id=<%#Eval("NC_Id") %>">編輯</a>&nbsp;&nbsp;
       <asp:LinkButton ID="LinkButton1" CommandName='<%#Eval("NC_Id") %>'
         OnCommand="Del_Click" OnClientClick="return confirm('確定刪除嗎?')"
         runat="server">刪除</asp:LinkButton>
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    </table>
    
    </div>
    </form>
</body>
</html>
