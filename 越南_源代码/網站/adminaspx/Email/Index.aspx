<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Admin_Email_Index" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>指定發送E-MAIL</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td ><strong>指定發送E-MAIL</strong>
          <a href="Edit.aspx?op=add">新增</a></td>
       </tr>

    </table>
    <center>
            <table class="table_main" cellpadding="0" cellspacing="1" >
                <asp:Repeater ID="rpt_list" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <td>聯絡人</td>
                            <td>E-mail</td>
                            <td>操作選項</td>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td align="left">&nbsp;&nbsp;<%#Eval("G_Name")%></td>
                            <td align="left" ><%#Eval("G_Email")%></td>
                            <td align="center">
                                [<a href='Edit.aspx?G_Id=<%#Eval("G_id") %>' >修改</a>]&nbsp;&nbsp;&nbsp;
                                [<asp:LinkButton ID="Del" CommandName='<%#Eval("G_id") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要刪除嗎?')" >刪除</asp:LinkButton>]
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </center>
        </div>
    </form>
</body>
</html>