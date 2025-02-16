<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Web.Admin.News_Class.Manage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LOGO小圖管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main" >
    <tr>
    <td class="table_tittle" colspan="2">新增LOGO小圖</td>
    </tr>
    <tr>
    <td align="right" width="40%">LOGO小圖名稱：</td>
    <td align="left">
        <asp:TextBox ID="tb_classname" runat="server" MaxLength="25" Columns="25"/> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="add" ControlToValidate="tb_classname" ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:Label ID="lblNCID" runat="server" Visible="false"></asp:Label>
    </td>
    </tr>
    <tr>
    <td align="right" width="40%">
        圖片：</td>
    <td align="left"><asp:TextBox ID="txtPhotoUrl" runat="server" ReadOnly="true" 
            Width="176px"></asp:TextBox>&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" /> 
        <asp:Button ID="Button2" runat="server" Text="上傳" OnClick="UpFile_Click" /> 
    </td>
    </tr>
    <tr>
    <td align="right" width="40%">服務項目類別：</td>
    <td align="left">
        <asp:DropDownList ID="ddl_guoclass" runat="server">
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
    
    <table class="table_textcenter">
    <tr>
    <td align="center" width="30%" style="font-weight:bold">LOGO小圖名稱</td>
    <td align="center" width="30%" style="font-weight:bold">图片</td>
    <td align="center" style="font-weight:bold" >服務項目類別</td>
    <td align="center" style="font-weight:bold" >LOGO小圖排序</td>
    <td align="center" style="font-weight:bold">操作選項</td>
    </tr>
    <asp:Repeater ID="rpt_list" runat="server" OnItemDataBound="rpt_list_ItemDataBound" >
    <ItemTemplate>
     <tr>
    <td  align="center" width="30%"><%#Eval("title")%></td>
    <td  align="center" ><%#Eval("pic").ToString().Trim().Equals("")?"":"<img src='/"+Eval("pic")+"' width=104 height=29>"%></td>
    <td  align="center"><%#Eval("guojianame")%></td>
    <td  align="center">
        <asp:Label ID="lblNCId" runat="server" Text='<%# Eval("id") %>' Visible="false"></asp:Label>
        <asp:DropDownList ID="ddlSortKey" runat="server"></asp:DropDownList>
        <asp:LinkButton ID="btnModfiySortKey" runat="server" CssClass="button" OnClick="btnModfiySortKey_Click">修改序號</asp:LinkButton>
   </td>
    <td  align="center">
       <asp:LinkButton ID="btnModfiy" runat="server" CommandArgument='<%#Eval("id") %>' OnClick="btnModfiy_Click" >編輯</asp:LinkButton>&nbsp;&nbsp;
       <asp:LinkButton ID="LinkButton1" CommandName='<%#Eval("id") %>'
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
