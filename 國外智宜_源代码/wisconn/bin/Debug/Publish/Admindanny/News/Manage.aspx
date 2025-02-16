<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="ZeroStudio.Web.Admin.News.Manage" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>文章管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
     <div>
    
    <table class="table_main">
    <tr>
    <td class="table_tittle"  colspan="5">文章管理</td>
    <td colspan="2"><strong><a href="add.aspx" >>>新增文章</a></strong></td>
    </tr>
    <tr>
    <td align="center" width="35">選擇</td>
    <td align="center" width="35%">標題</td>
    <td align="center">欄位分類</td>
    <td align="center">管理員</td>
    <td align="center">建立時間</td>
    <td align="center">修改</td>
    <td align="center">刪除</td>
    </tr>
    <asp:Repeater ID="rpt_news" runat="server">
    <ItemTemplate>
    <tr>
    <td align="center" width="35"><asp:CheckBox ID="cbSelect" runat="server" /><asp:Label ID="lblNID" runat="server" Visible="false" Text='<%#Eval("N_id") %>' ></asp:Label></td>
    <td align="left" width="35%">&nbsp;&nbsp;&nbsp;<a href='../../Portfolio-detail.aspx?N_Id=<%#Eval("N_id") %>' target="_blank"><%#Eval("N_Title") %></a></td>
    <td align="center"><%#Eval("NC_ClassName") %></td>
    <td align="center"><%#Eval("N_Input") %></td>
    <td align="center"><%# Eval("N_DateTime", "{0:yyyy-MM-dd}") %></td>
    <td align="center">
       [<a href="Edit.aspx?N_id=<%#Eval("N_id") %>&v=1">修改</a>]
    </td>
    <td align="center">
           [<asp:LinkButton ID="Del" CommandArgument='<%#Eval("N_id") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要刪除嗎?');">刪除</asp:LinkButton>]
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    <tr>
       <td colspan="7" align="right">
           <asp:LinkButton ID="btnDelAll" runat="server" OnClientClick="return confirm('確定要刪除所選的文章嗎');" OnCommand="btnDelAll_Click" ToolTip="刪除所選擇的文章" >刪除所選</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
       </td>
    </tr>
    <tr>
    <td colspan="7" align="center" >
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged" CenterCurrentPageButton="True" FirstPageText="首頁" PageSize="20" LastPageText="尾頁"></webdiyer:aspnetpager>

    </td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
