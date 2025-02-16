<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" CodeFile="Edit.aspx.cs" Inherits="ZeroStudio.Web.Admin.News.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>編輯文章</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
     <script type="text/javascript" charset="utf-8" src="../ueditor/ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="../ueditor/ueditor.all.min.js"> </script>
    <script type="text/javascript" charset="utf-8" src="../ueditor/lang/zh-cn/zh-cn.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
<table class="table_main">
    <tr>
    <td class="table_tittle" colspan="2">編輯文章</td>
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
        <asp:DropDownList ID="ddl_newsclass" runat="server">
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
      <td align="right" width="10%">來自：</td>
      <td align="left">
         <asp:TextBox ID="txtSource" runat="server" MaxLength="50"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtSource"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">添加時間：</td>
      <td align="left">
         <asp:TextBox ID="txtDateTime" runat="server" MaxLength="50"></asp:TextBox>&nbsp;<span style="color:#AAAAAA" >格式：yyyy-MM-dd;比如2011-01-21</span>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDateTime"  ErrorMessage="*"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator ID="revDate" runat="server" ErrorMessage="時間格式無效" ValidationExpression="((((1[6-9]|[2-9]\d)\d{2})-(0[13578]|1[02])-(0[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0[13456789]|1[012])-(0[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-02-(0[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-02-29-))$" ControlToValidate="txtDateTime" SetFocusOnError="true"></asp:RegularExpressionValidator>
      </td>
    </tr>
      <tr>
      <td align="right" width="10%">對應產品：</td>
      <td align="left">
         <asp:TextBox ID="txtProduct" runat="server" MaxLength="200" Width="350px" Text="輸入對應產品"></asp:TextBox>
      </td>
    </tr>
   <%-- <tr>
      <td align="right" width="10%">跑馬燈顯示：</td>
      <td align="left">
         <asp:CheckBox ID="cbIsShow" runat="server" />&nbsp;
         <asp:Literal ID="ltlIsShow" runat="server"></asp:Literal>
      </td>
    </tr>--%>
    <tr>
      <td align="right" width="10%">Keyword：</td>
      <td align="left">
         <asp:TextBox ID="txtKeyword" runat="server" MaxLength="200" Width="350px"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtKeyword"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
      <td align="right" width="10%">Description：</td>
      <td align="left">
         <asp:TextBox ID="txtDescription" runat="server" MaxLength="500" TextMode="multiLine" Columns="50" Rows="5"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDescription"  ErrorMessage="*"></asp:RequiredFieldValidator>
      </td>
    </tr>
    <tr>
    <td align="center" width="10%">文章內容：<br />換行請按<span style='color:Red'>Shift+Enter</span><br /> 另起一行請按<span style='color:Red'>Enter</span></td>
    <td  align="left">
         <input id="FCK_Content" runat="server" style="display:none"/>
         <script id="editor" type="text/plain" style="width:1024px;height:500px;"></script>
    </td>
    </tr>
        <tr>
    <td align="center" colspan="2">
        <asp:Button ID="Button1" runat="server" Text="編輯"   OnClientClick="setConent()"  OnClick="Sub_Click"/> 
        <input id="Reset1" type="reset" value="取消" onclick="history.go(-1)" />
    </td>
        
        </tr>
    </table>
    
    </div>
    </form>
</body>
       <script type="text/javascript">
           var ue = UE.getEditor('editor');
           var timerId = setInterval(function () {
               try {
                   UE.getEditor('editor').setContent('<%=oldContext  %>', false);
                   clearInterval(timerId);
               } catch {

               }
           }, 100);
        function setConent() {
            document.getElementById('FCK_Content').value = ue.getContent();
        }
       </script>
</html>
