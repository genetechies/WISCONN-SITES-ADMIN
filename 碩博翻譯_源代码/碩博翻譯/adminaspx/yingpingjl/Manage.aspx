<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Web.Admin.GuestBook.Manage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>求職履歷管理</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td ><strong>求職履歷管理</strong></td>
       </tr>
       <tr>
          <td style="height:30px;line-height:30px;" >姓名：<asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox>&nbsp;&nbsp;&nbsp;<asp:Button ID="btnSearch" runat="server" Text="查詢" OnClick="btnSearch_Click" /></td>
       </tr>

    </table>
    <center>
            <table class="table_main" cellpadding="0" cellspacing="1" >
                <asp:Repeater ID="rpt_list" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <td>姓名</td>
                            <td>年齡</td>
                            <td>性別</td>
                            <td>最高學歷</td>
                            <td>電話</td>
                            <td>應聘時間</td>
                            <td>處理情況</td>
                            <td>操作選項</td>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td align="center"><%#Eval("UserName")%></td>
                            <td align="center" ><%#Eval("Age")%></td>
                            <td align="center" ><%#Eval("Sex")%></td>
                            <td align="center"><%#Eval("TopGraduation")%></td>
                            <td align="center"><%#Eval("TEL")%>&nbsp;</td>
                            <td align="center"><%#Eval("CreateDate")%>&nbsp;</td>
                            <td align="center"><asp:Label ID="lblGID" runat="server" Text='<%#Eval("id") %>' Visible="false"></asp:Label>
                                <asp:Label ID="lblIsFinish" runat="server" Text='<%#Eval("state") %>' Visible="false"></asp:Label>
                                <asp:DropDownList ID="ddlFinish" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlFinish_SelectedIndexChanged"  >
                                    <asp:ListItem Text="未處理" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="已處理" Value="1"></asp:ListItem>
                                </asp:DropDownList></td>

                            <td align="center">
                                [<a href='reply.aspx?G_id=<%#Eval("id") %>' >詳細內容</a>]&nbsp;&nbsp;&nbsp;
                                [<asp:LinkButton ID="Del" CommandName='<%#Eval("id") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要刪除嗎?')" >刪除</asp:LinkButton>]
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
                <tr>
                    <td class="lanyuds" colspan="7" align="center">
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
