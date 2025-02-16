<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SubWebList.aspx.cs" Inherits="adminaspx_SubWeb_SubWebList" %>

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
            if (document.getElementById(searchText).value == "查詢網站名") {
                document.getElementById(searchText).value = "";
                document.getElementById("searchText1").style.color="Black";
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
    <td class="table_tittle"  colspan="7">子網站列表管理</td>
    <td colspan="2"><strong><a href="SubWebAdd.aspx" >>>新增子網站</a></strong></td>
    </tr>
    <tr>
        <td colspan="9" style="height:30px;line-height:30px;" >網站名：
網站名：
        <asp:TextBox ID="searchText1" runat="server" style="vertical-align:middle; color:Gray;"  Text="查詢網站名"
                onfocus="javascript:clearSearchText('searchText1');"></asp:TextBox>
        
            <asp:Button 
                        ID="btnSearch" runat="server" Text="查詢" 
                onclick="btnSearch_Click" /></td>
    </tr>
    <tr>
    <td align="center" width="35">選擇</td>
    <td align="center" width="35%">網站名</td>
    <td align="center">網域名</td>
    <td align="center">資料庫名稱</td>
    <td align="center">帳戶</td>
    <td>密碼</td>
    <td align="center" colspan="3">操作選項</td>
    </tr>
        <asp:Repeater ID="productGrid" runat="server" OnItemCommand="productGrid_ItemCommand" OnItemDataBound="productGrid_ItemDataBound">
            <ItemTemplate>
            <tr>
            <td height="25"><asp:CheckBox ID="cbSelect" runat="server" /></td>
            <td><a href="<%#Eval("SWDomainName") %>" target="_blank"><%#Eval("SWName")%></a></td>
            <td align="center"> <a href="<%#Eval("SWDomainName") %>" target="_blank"><%#Eval("SWDomainName")%></a></td>
            <td align="center"><%#Eval("SWDBName")%>&nbsp;</td>
            <td align="center"><%# Eval("SWDBUser")%>&nbsp;</td>

            <td>
                <asp:Label ID="lblPID" runat="server"
                    Text='<%#Eval("SWID") %>' Visible="False"></asp:Label>
                <%# Eval("SWDBUserPwd")%>&nbsp;
            </td>
            <td align="center">						
                <a href="SubWebEdit.aspx?swid=<%#Eval("SWID")+"," + Eval("SWDBID")+ "," + Eval("SWDBUser")  %>" title="編輯"   >
                編輯</a>&nbsp;&nbsp;
            </td>
            <td align="center">
               <asp:Label ID="lbName" runat="server" Text='<%#Eval("SWDBName") %>' Visible="False"></asp:Label>
                <asp:LinkButton ID="Del" CommandArgument='<%#Eval("SWID") +"," + Eval("SWDBID") + "," + Eval("SWDBUser") %>' runat="server" OnClick="Del_Click" OnClientClick="return confirm('確定要刪除嗎?');" ToolTip="刪除" Text="刪除"></asp:LinkButton>
            </td>
            <td align="center">
                <asp:LinkButton ID="Test" CommandArgument='<%#Eval("SWID") + "," + Eval("SWDBService") + "," + Eval("SWDBID") + "," + Eval("SWDBUser") + "," + Eval("SWDBUserPwd") %>' runat="server" OnClick="Test_Click"  ToolTip="測試連接" Text="測試連接"></asp:LinkButton>
            </td>
            </tr>
            </ItemTemplate>
        </asp:Repeater>
    <tr>
       <td colspan="9" align="right"> <input type="checkbox" onclick="SelectAll(this);" />全選 
           [<asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('確定要徹底刪除選擇的文章嗎');" style="color:#888888" OnClick="btnDelAll_Click" ToolTip="刪除選擇的文章" >刪除所選</asp:LinkButton>
           ]      </td>
    </tr>
    <tr>
    <td colspan="9" align="center" >
        &nbsp;<webdiyer:aspnetpager id="AspNetPager1" runat="server" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
    </td>
    </tr>
    </table>
    
    </div>
    </form>

</body>
</html>
