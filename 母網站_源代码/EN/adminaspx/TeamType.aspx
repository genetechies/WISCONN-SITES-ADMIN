<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamType.aspx.cs" Inherits="adminaspx_transzone_TeamType" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>服務項目類別管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main" >
    <tr>
    <td class="table_tittle" colspan="2">新增服務項目類別</td>
    </tr>
     <tr>
    <td  align="right" width="10%">發佈網站：</td>
    <td  align="left">
        <asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
        </td>
    </tr>
    <tr>
    <td align="right" width="40%">服務項目類別名稱：</td>
    <td align="left">
        <asp:TextBox ID="tb_classname" runat="server" MaxLength="40" Columns="25" 
            Width="224px"/> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="add" ControlToValidate="tb_classname" ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:Label ID="lblNCID" runat="server" Visible="false"></asp:Label>
    </td>
    </tr>
            <tr>
    <td align="right" width="40%">服務項目類別排序：</td>
    <td align="left"> <strong><asp:Label ID="lblSortKey" runat="server" ></asp:Label></strong></td>
    </tr>
        <tr>
    <td align="center" colspan="2" style="height: 28px">
        <asp:Button ID="Button1" runat="server" Text="新增"  OnClick="Sub_Click" ValidationGroup="add" />&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click" />
    </tr>
    </table>
    
    <table class="table_textcenter">
    <tr>
    <td align="center" width="8%" style="font-weight:bold">編號</td>
    <td align="center" width="30%" style="font-weight:bold">服務項目類別名稱</td>
    <td align="center" style="font-weight:bold" >网站</td>
    <td align="center" style="font-weight:bold" >服務項目類別排序</td>
    <td align="center" style="font-weight:bold">操作選項</td>
    </tr>
    <asp:Repeater ID="rpt_list" runat="server" OnItemDataBound="rpt_list_ItemDataBound" >
    <ItemTemplate>
     <tr>
     <td  align="center" ><%#Eval("NC_Id")%></td>
    <td  align="center" width="30%"><%#Eval("NC_ClassName") %></td>
    <td  align="center"><%#Eval("WebSite") %></td>
    <td  align="center">
        <asp:Label ID="lblNCId" runat="server" Text='<%# Eval("NC_Id") %>' Visible="false"></asp:Label>
        <asp:DropDownList ID="ddlSortKey" runat="server"></asp:DropDownList>
        <asp:LinkButton ID="btnModfiySortKey" runat="server" CssClass="button" OnClick="btnModfiySortKey_Click">修改序號</asp:LinkButton>
   </td>
    <td  align="center">
       <asp:LinkButton ID="btnModfiy" runat="server" CommandArgument='<%#Eval("NC_Id") %>' CommandName='<%#Eval("Swid") %>' OnClick="btnModfiy_Click" >編輯</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="LinkButton1" CommandName='<%#Eval("NC_Id") %>'
         OnCommand="Del_Click" CommandArgument='<%#Eval("Swid") %>' OnClientClick="return confirm('確定刪除嗎?')"
         runat="server">刪除</asp:LinkButton>
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    </table>
    
    </div>
    </form>
</body>
</html>
