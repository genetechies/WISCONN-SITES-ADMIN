<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="ZeroStudio.Web.Admin.GuestBook.Manage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>留言管理</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td colspan="3" ><strong>留言管理</strong></td>
       </tr>
    </table>
    <center>
            <table class="table_main" >
                <asp:Repeater ID="rpt_list" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <td>主旨</td>
                            <td>聯絡人</td>
                            <td>E-mail</td>
                            <td>詳細內容</td>
                            <td>留言時間</td>
                            <td>刪除</td>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td class="lanyuds" align="left">&nbsp;&nbsp;
                                <%#Eval("G_title") %></td>
                            <td  align="left" class="lanyuds">&nbsp;&nbsp;
                               <%#Eval("G_username") %></td>
                            <td align="left" class="lanyuds">
                                <%#Eval("G_email")%></td>
                            <td align="center"><a href='reply.aspx?G_id=<%#Eval("G_id") %>' >詳細內容</a></td>
                            <td align="center"><%#Eval("G_datetime","{0:yyyy-MM-dd}") %></td>
                            <td align="center" class="lanyuds">
                                [<asp:LinkButton ID="Del" CommandName='<%#Eval("G_id") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要刪除嗎?')" >刪除</asp:LinkButton>]
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td class="lanyuds" colspan="6" align="center">
                        &nbsp;<webdiyer:AspNetPager ID="AspNetPager1" runat="server" FirstPageText="首頁" LastPageText="尾頁"
                            NextPageText="下一頁" PrevPageText="上一頁" OnPageChanged="AspNetPager1_PageChanged">
                        </webdiyer:AspNetPager>
                    </td>
                </tr>
            </table>
        </center>
        </div>
    </form>
</body>
</html>
