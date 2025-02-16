<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Web.Admin.News_Class.Manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>廠商信息管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript">
        function SelectAll(chk) {
            //            var flag = false;
            //            for (var li_i = 0; li_i < document.forms[0].elements.length; li_i++) {
            //                var e = document.forms[0].elements[li_i];
            //                var ls_temp;
            //                ls_temp = e.name;

            //                if (e.type == "checkbox" && ls_temp!="chb_C_show" ) {
            //                    e.checked = chk.checked;
            //                }
            //            }
            var table = document.getElementById("t_list");
            var obj = table.getElementsByTagName("input");
            for (var li_i = 0; li_i < obj.length; li_i++) {
                if (obj[li_i].type == "checkbox" && obj[li_i].id.toString().substring(0, 6) != "cbxWeb") {
                    obj[li_i].checked = chk.checked;
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
    <td class="table_tittle" colspan="2">新增信息</td>
    </tr>
    <tr>
    <td class="table_tittle" colspan="2"><asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal">
        </asp:CheckBoxList></td>
    </tr>
    <tr>
    <td align="right" width="40%">企業名稱：</td>
    <td align="left">
        <asp:TextBox ID="tb_classname" runat="server" MaxLength="25" Columns="25" 
            Width="205px"/> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="add" ControlToValidate="tb_classname" ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:Label ID="lblNCID" runat="server" Visible="false"></asp:Label>
    </td>
    </tr>
    <tr>
    <td align="right" width="40%">所屬類別：</td>
    <td align="left">
        <asp:DropDownList ID="ddl_linyuclass" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
    
            <tr>
    <td align="right" width="40%">排序：</td>
    <td align="left"> <strong><asp:Label ID="lblSortKey" runat="server" ></asp:Label></strong></td>
    </tr>
        <tr>
    <td align="center" colspan="2" style="height: 28px">
        <asp:Button ID="Button1" runat="server" Text="新增"  OnClick="Sub_Click" ValidationGroup="add" />&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click" />
    </tr>
    </table>
    
    <table class="table_textcenter" id="t_list">
    <tr>
    <td height="27">選擇</td>
    <td align="center" width="30%" style="font-weight:bold">企業名稱</td>
    <td align="center" style="font-weight:bold" >所屬類別</td>
    <%--<td align="center" style="font-weight:bold" >网站</td>
    <td align="center" style="font-weight:bold" >排序</td>--%>
<%--    <td align="center" style="font-weight:bold" >首頁顯示</td>--%>
    <td align="center" style="font-weight:bold">操作選項</td>
    </tr>
    <asp:Repeater ID="rpt_list" runat="server" OnItemDataBound="rpt_list_ItemDataBound" >
    <ItemTemplate>
     <tr>
     <td height="25"><asp:CheckBox ID="cbSelect" name="cbSelect" runat="server" /><asp:Label ID="lblPID" runat="server" Text='<%#Eval("id") %>' Visible="false"></asp:Label></td>
    <td  align="center" width="30%"><%#Eval("title")%></td>
    <td  align="center"><%#Eval("linyuclassname")%></td>
    <%--<td  align="center"><%#Eval("WebSite")%></td>
    <td  align="center">
        <asp:Label ID="lblNCId" runat="server" Text='<%# Eval("id")+","+Eval("Swid")%>' Visible="false"></asp:Label>
        <asp:DropDownList ID="ddlSortKey" runat="server"></asp:DropDownList>
        <asp:LinkButton ID="btnModfiySortKey" runat="server" CssClass="button" OnClick="btnModfiySortKey_Click">修改序號</asp:LinkButton>
   </td>--%>
<%--   <td align="center"><%#Eval("C_show").ToString().Trim().Equals("1") ? "顯示" : ""%>&nbsp;</td>--%>
    <td  align="center">
       <asp:LinkButton ID="btnModfiy" runat="server" CommandArgument='<%#Eval("id") %>' CommandName='<%#Eval("Swid") %>' OnClick="btnModfiy_Click" >編輯</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="LinkButton1" CommandName='<%#Eval("id") %>' CommandArgument='<%#Eval("Swid") %>'
         OnCommand="Del_Click" OnClientClick="return confirm('確定刪除嗎?')"
         runat="server">刪除</asp:LinkButton>
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    <tr>
    <td colspan=6 style="text-align:left;">
    &nbsp;&nbsp;
<input type="checkbox" onclick="SelectAll(this);" />全選&nbsp;&nbsp;&nbsp;&nbsp;[<asp:LinkButton ID="btnDelAll" runat="server" OnClientClick="return confirm('確定要徹底刪除選擇的網頁嗎');" style="color:#888888" OnClick="btnDelAll_Click" ToolTip="刪除選擇的網頁" >刪除所選</asp:LinkButton>]
    </td>
    </tr>
    <tr>
    <td colspan=6><table width="100%" align="center" border="0" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="lanyuds"  align="center">
                        &nbsp;<webdiyer:aspnetpager id="AspNetPager1" runat="server" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
                        
                </td>
            </tr>
        </table></td>
    </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
