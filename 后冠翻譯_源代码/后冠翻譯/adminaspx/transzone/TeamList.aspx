<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamList.aspx.cs" Inherits="adminaspx_transzone_TeamList" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>LOGO小圖管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
        function clearSearchText(searchText){
	        if(document.getElementById(searchText).value=="查詢文章訊息"){
		        document.getElementById(searchText).value="";
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
    
    
    <table class="table_textcenter">
     <tr>
        <td class="table_tittle"  colspan="4">翻譯團隊列表管理</td>
        <td colspan="1"><strong><a href="TeamEdit.aspx" >>>新增翻譯團隊</a></strong></td>
    </tr>
    <tr>    
        <td colspan="5" style="height:30px;line-height:30px;">標題：
        <asp:TextBox ID="searchText1" runat="server" style="vertical-align:middle" 
                onfocus="javascript:clearSearchText('searchText1');"></asp:TextBox>
        類別：<asp:DropDownList ID="ddlCategory" runat="server" >
		<asp:ListItem Text="請選擇分類" Value="-1"></asp:ListItem></asp:DropDownList>&nbsp;&nbsp;&nbsp;
		<asp:Button  ID="Button2" runat="server" Text="查詢" onclick="Button2_Click" /></td>
    </tr>
    <tr>
    <td align="center" width="30%" style="font-weight:bold">名稱</td>
    <td align="center" width="30%" style="font-weight:bold">图片</td>
    <td align="center" style="font-weight:bold" >服務項目類別</td>
    <td align="center" style="font-weight:bold" >LOGO小圖排序</td>
    <td align="center" style="font-weight:bold">操作選項</td>
    </tr>
    <asp:Repeater ID="rpt_list" runat="server" OnItemDataBound="rpt_list_ItemDataBound"  OnItemCommand="productGrid_ItemCommand" >
    <ItemTemplate>
     <tr>
    <td  align="center" width="30%"><%#Eval("tname")%></td>
    <td  align="center" ><%#Eval("imgpath").ToString().Trim().Equals("") ? "" : "<img src='/" + Eval("imgpath") + "' width=104 height=29>"%></td>
    <td  align="center"><%#Eval("NC_ClassName")%></td>
    <td  align="center">
        <asp:Label ID="tid" runat="server" Text='<%# Eval("tid") %>' Visible="false"></asp:Label>

        <asp:TextBox ID="txtSort" runat="server" Width="40px" Text='<%# Eval("sort") %>' ></asp:TextBox>
        <asp:LinkButton ID="btnModfiySortKey" runat="server" CommandName="modfiy" >修改排序號</asp:LinkButton>
   </td>
    <td  align="center">
      
        <a href="TeamEdit.aspx?P_id=<%#Eval("tid") %>" title="編輯"   >編輯</a>&nbsp;&nbsp;
       <asp:LinkButton ID="LinkButton1" CommandName='<%#Eval("tid") %>'
         OnCommand="Del_Click" OnClientClick="return confirm('確定刪除嗎?')"
         runat="server">刪除</asp:LinkButton>
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>

    </table>
    <table width="100%" align="center" border="0" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="lanyuds" colspan="5" align="center">
                        &nbsp;<webdiyer:aspnetpager id="AspNetPager1" runat="server" 
                            AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" 
                            OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
                        
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
