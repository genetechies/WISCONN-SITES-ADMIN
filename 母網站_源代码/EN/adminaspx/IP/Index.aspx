<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="adminaspx_IP_Index" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>IP黑名单</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td ><strong>IP黑名单</strong></td>
       </tr>
    </table>
    <center>
            <table class="table_main" cellpadding="0" cellspacing="1" >
                <asp:Repeater ID="rpt_list" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <td>ID</td>
                            <td>IP地址</td>
                            <td>禁用日期</td>
                            <td>操作</td>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td align="left">&nbsp;&nbsp;<%#Eval("D_Id")%></td>
                            <td align="left" >&nbsp;&nbsp;<%#Eval("IPAddress")%></td>
                            <td align="left" ><%#Eval("AddDate")%></td>                         

                            <td align="center">                                
                                [<asp:LinkButton ID="Del" CommandName='<%#Eval("D_Id") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要刪除嗎?')" >刪除</asp:LinkButton>]
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