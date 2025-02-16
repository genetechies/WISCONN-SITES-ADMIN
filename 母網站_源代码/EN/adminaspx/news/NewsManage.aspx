<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewsManage.aspx.cs" Inherits="adminaspx_news_NewsManage" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>文章管理</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../css.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function validText(target) {
            var page = document.getElementById(target);
            if (page.value == "") {
                alert('請輸入排序號!');
                page.focus();
                return false;
            }
            if (isNaN(page.value)) {
                alert('排序號須為數字!');
                page.focus();
                return false;
            }
            if (parseInt(page.value) < 0) {
                alert('排序號須為大於等於零的正整數!');
                page.focus();
                return false;
            }
            return true;
        }
        function clearSearchText(searchText) {
            if (document.getElementById(searchText).value == "查詢文章訊息") {
                document.getElementById(searchText).value = "";
            }
        }
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
    
    <table class="table_main" cellpadding="0" cellspacing="1">
    <tr>
    <td class="table_tittle"  colspan="6">文章列表管理</td>
    <td colspan="2"><strong><a href="add.aspx" >>>新增文章</a></strong></td>
    </tr>
    <tr>
        <td style="height:30px;line-height:30px;">網站</td>
        <td colspan="8" style="height:30px;line-height:30px;">  
        <asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal" 
                AutoPostBack="True" onselectedindexchanged="cbxWeb_SelectedIndexChanged">
        </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
        <td colspan="8" style="height:30px;line-height:30px;" >標題：
        
        
        <asp:TextBox ID="searchText1" runat="server" style="vertical-align:middle" 
                onfocus="javascript:clearSearchText('searchText1');"></asp:TextBox>
        欄位：<asp:DropDownList ID="ddlCategory" runat="server">
                <asp:ListItem Value="-1">請選擇分類</asp:ListItem>
            </asp:DropDownList>
            <asp:Button 
                        ID="Button2" runat="server" Text="查詢" onclick="Button2_Click" /></td>
    </tr>
    <tr>
    <td align="center" width="35">選擇</td>
    <td align="center" width="35%">標題</td>
    <td align="center">欄位分類</td>
    <td align="center">管理員</td>
    <td align="center">建立時間</td>
    <td align="center">子網站</td>
<%--    <td>排序號</td>
--%>    <td align="center" colspan=2>操作選項</td>
    </tr>
                <asp:Repeater ID="productGrid" runat="server" OnItemCommand="productGrid_ItemCommand" OnItemDataBound="productGrid_ItemDataBound">
                    <ItemTemplate>
    <tr>
    <td height="25"><asp:CheckBox ID="cbSelect" runat="server" /></td>
    <td><a href="/translation/newsinfo-<%#Eval("D_ID") %>.aspx" target="_blank"><%#Eval("D_Title")%></a></td>
    <td align="center"> <%#Eval("ClassName").ToString().Equals("") ? "&nbsp;" : Eval("ClassName")%></td>
    <td align="center"><%#Eval("D_Editor")%>&nbsp;</td>
    <td align="center"><%# Eval("D_Time", "{0:yyyy-MM-dd}")%></td>
    <td align="center"><%# Eval("Database")%>&nbsp;</td>
   <%-- <td>
        <asp:Label ID="lblPID" runat="server"
            Text='<%#Eval("D_ID") %>' Visible="False"></asp:Label>
        <asp:TextBox ID="txtParentID" runat="server" Width="40px" Text='<%# Eval("OrderID") %>' ></asp:TextBox>
        <asp:TextBox ID="txtSwId" runat="server" Width="40px" Text='<%# Eval("SwId") %>' ></asp:TextBox>
        <asp:LinkButton ID="btnModfiySortKey" runat="server" CommandName="modfiy" >修改排序號</asp:LinkButton>

    </td>--%>
    <td align="center">						
        <a href="Edit.aspx?P_id=<%#Eval("D_ID") %>&SwId=<%#Eval("SwId") %>" title="編輯"   >編輯</a>&nbsp;&nbsp;
    </td>
    <td align="center"><asp:LinkButton ID="Del" CommandArgument='<%#Eval("D_ID_SwId") %>' runat="server" OnClick="Del_Click" OnClientClick="return confirm('確定要刪除嗎?');" ToolTip="刪除" Text="刪除"></asp:LinkButton>
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    <tr>
       <td colspan="8" align="right"> <input type="checkbox" onclick="SelectAll(this);" />全選
                    [<asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('確定要徹底刪除選擇的文章嗎');" style="color:#888888" OnClick="btnDelAll_Click" ToolTip="刪除選擇的文章" >刪除所選</asp:LinkButton>]      </td>
    </tr>
    <tr>
    <td colspan="8" align="center" >
 &nbsp;<webdiyer:aspnetpager id="AspNetPager1" runat="server" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
    </td>
    </tr>
    </table>
    
    </div>
    
    </form>

</body>
</html>
