<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteBox.aspx.cs" Inherits="Web.Admin.Product.DeleteBox" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>回收桶</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript">
        function SelectAll(chk) {
        var flag = false;
        for (var li_i = 0; li_i < document.forms[0].elements.length; li_i++) {
            var e = document.forms[0].elements[li_i];
            var ls_temp;
            ls_temp = e.name;
            if (e.type == "checkbox") {
                e.checked = chk.checked;
            }
        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <table class="table_main">
    <tr>
    <td class="table_tittle"  colspan="6">回收桶</td>
    </tr>
    <tr>
    <td align="center" width="45">選擇</td>
    <td align="center" width="35%">信息名稱</td>
    <td align="center">分類</td>
    <td align="center">网站</td>
    <td align="center">建立時間</td>
    <td align="center">復原</td>
    <td align="center">徹底刪除</td>
    </tr>
    <asp:Repeater ID="rpt_news" runat="server">
    <ItemTemplate>
    <tr>
    <td align="center" width="45"><asp:CheckBox ID="cbSelect" runat="server" /><asp:Label ID="lblPID" runat="server" Visible="false" Text='<%#Eval("id") %>' ></asp:Label></td>
    <td align="left" width="35%"><%#Eval("title")%></td>
    <td align="center"><%#Eval("linyuclassname")%></td>
    <td align="center"><%#Eval("Database")%></td>
    <td align="center"><%# Eval("addtime", "{0:yyyy-MM-dd}")%></td>
    <td align="center">
       [<asp:LinkButton ID="btnUnDel" runat="server" OnCommand="btnUnDel_Click" CommandArgument='<%#Eval("id") %>' CommandName='<%#Eval("SwId") %>' >復原</asp:LinkButton>]
    </td>
    <td align="center">
           [<asp:LinkButton ID="Del" CommandArgument='<%#Eval("id") %>' CommandName='<%#Eval("SwId") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要徹底刪除嗎?');">徹底刪除</asp:LinkButton>]
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    <tr>
       <td width="45">
          <input type="checkbox" onclick="SelectAll(this);" />選擇
       </td>
       <td colspan="6" align="right">
           <asp:LinkButton ID="btnUnDelAll" runat="server" OnCommand="btnUnDelAll_Click" ToolTip="復原所有信息" >復原</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="btnUnDelAllSelect" runat="server" OnCommand="btnUnDelAllSelect_Click" ToolTip="復原選擇的信息">復原選擇</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="btnClear" runat="server" OnCommand="btnClear_Click" ToolTip="徹底刪除回收筒裏所有的信息">清空回收筒</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
           <asp:LinkButton ID="btnDelAll" runat="server" OnClientClick="return confirm('確定要徹底刪除選擇的信息嗎');" OnCommand="btnDelAll_Click" ToolTip="徹底刪除選擇的信息" >徹底刪除所選</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
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
