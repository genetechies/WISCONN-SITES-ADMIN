<%@ Page Language="C#"  ValidateRequest="false" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Web.Admin.News.Add" %>

<%@Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新增文章</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="../Js/jquery.min.js"></script>
    <script src="../Js/WebCalendar.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    
        <table class="table_main">
    <tr>
    <td class="table_tittle" colspan="2">新增文章</td>
    </tr>
    <tr>
    <td  align="right" width="10%">發佈網站：</td>
    <td  align="left">
        <asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal" >
        </asp:CheckBoxList>
        <%--     <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
            RepeatDirection="Horizontal">
        </asp:RadioButtonList>--%>
        </td>
    </tr>
    
    <tr>
    <td  align="right" width="10%">標題：</td>
    <td  align="left">
        <asp:TextBox ID="txtTitle" runat="server" MaxLength="50" Width="350px" /> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTitle"  ErrorMessage="*"></asp:RequiredFieldValidator></td>
    </tr>
    
     <tr>
    <td align="right" width="10%">分類：</td>
    <td  align="left">
        <%--<asp:DropDownList ID="ddlCategory" runat="server">
        </asp:DropDownList>--%>
        <asp:DropDownList ID="ddlCategory" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
    <tr >
      <td align="right" width="10%">作者：</td>
      <td align="left">
         <asp:TextBox ID="txtAuthor" runat="server" MaxLength="50" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtAuthor"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
        <tr>
                <td align="right" width="10%">
                    加入时间：</td>
                <td align="left">
                    <asp:TextBox ID="tb_AddTime" runat="server" onfocus="SelectDate(this,'yyyy-MM-dd')"/> &nbsp;</td>
            </tr>
    <tr>
      <td align="right" width="10%">Keyword：</td>
      <td align="left">
         <asp:TextBox ID="txtKeyword" runat="server" MaxLength="200" Width="350px" Text="輸入關鍵詞"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtKeyword"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">Description：</td>
      <td align="left">
         <asp:TextBox ID="txtDescription" runat="server" MaxLength="500" TextMode="multiLine" Columns="50" Rows="5" Text="輸入網頁描述"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDescription"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
    <td align="center" width="10%">網頁內容：<br />換行請按<span style='color:Red'>Shift+Enter</span><br /> 另起一行請按<span style='color:Red'>Enter</span> </td>
    <td  align="left">
        
       
      <CKEditor:CKEditorControl ID="CKEditor1" BasePath="../ckeditor" runat="server"></CKEditor:CKEditorControl>
        
       
    </td>
    </tr>
        <tr>
    <td  align="center" colspan="2">
                            <asp:Button ID="btnInAricle" runat="server" Text="加入關鍵字" OnClick="btnInAricle_Click" />&nbsp;&nbsp;
                    <asp:Button ID="btnCloseAricle" runat="server" Text="加入延伸文章" OnClick="btnCloseAricle_Click" />&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Text="提交"  OnClick="Sub_Click"/> &nbsp;&nbsp;
        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" /></td>
        </tr>
    </table>
    
    </div>
    </form>
</body>
</html>
