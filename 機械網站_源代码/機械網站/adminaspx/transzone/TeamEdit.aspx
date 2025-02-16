<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamEdit.aspx.cs" Inherits="adminaspx_transzone_TeamEdit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<table class="table_main" >
    <tr>
    <td class="table_tittle" colspan="2">编辑翻译团队</td>
    </tr>
    <tr>
    <td align="right" width="40%">發佈網站：</td>
    <td align="left">
        <asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal"  >
        </asp:CheckBoxList>
    </td>
    </tr>
    <tr>
    <td align="right" width="40%">姓名：</td>
    <td align="left">
        <asp:TextBox ID="tname" runat="server" MaxLength="25" Columns="25"/> 
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="add" ControlToValidate="tname" ErrorMessage="*"></asp:RequiredFieldValidator>
        <asp:Label ID="tid" runat="server" Visible="false"></asp:Label>
    </td>
    </tr>
    <tr>
    <td align="right" width="40%">
        圖片：</td>
    <td align="left"><asp:TextBox ID="imgpath" runat="server" ReadOnly="true" Width="176px"></asp:TextBox>&nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" /> 
        <asp:Button ID="Button2" runat="server" Text="上傳" OnClick="UpFile_Click" /> 
    </td>
    </tr>
    <tr>
    <td align="right" width="40%">性別：</td>
    <td align="left">
        <asp:DropDownList ID="ddl_avater" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
     <td align="right" width="40%">類別：</td>
    <td align="left">
        <asp:DropDownList ID="ddlCategory" runat="server">
        </asp:DropDownList>
    </td>
    </tr>
  
    
    <tr>
    <td align="right" width="40%">學歷：</td>
    <td align="left"> <strong> <asp:TextBox ID="xueli" runat="server" MaxLength="25" Columns="25"/> </strong></td>
    </tr>
    
    <tr>
    <td align="right" width="40%">國籍：</td>
    <td align="left"> <strong> <asp:TextBox ID="home" runat="server" MaxLength="25" Columns="25"/> </strong></td>
    </tr>
    
    <tr>
    <td align="right" width="40%">自我介紹：</td>
    <td align="left"> <strong> <asp:TextBox ID="descript" runat="server" TextMode="MultiLine"/> </strong></td>
    </tr>
   
    <tr>
    <td align="center" colspan="2" style="height: 28px">
        <asp:Button ID="Button1" runat="server" Text="新增"  OnClick="Sub_Click" ValidationGroup="add" />&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="重置" OnClick="btnReset_Click" />
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
