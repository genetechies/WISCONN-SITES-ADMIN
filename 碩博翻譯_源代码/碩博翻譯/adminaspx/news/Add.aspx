<%@ Page Language="C#"  ValidateRequest="false" AutoEventWireup="true" CodeFile="Add.aspx.cs" Inherits="Web.Admin.News.Add" %>

<%--<%@ Register assembly="FredCK.FCKeditorV2" namespace="FredCK.FCKeditorV2" tagprefix="FCKeditorV2" %>--%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新增文章</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="../Js/jquery.min.js"></script>
    <script src="../Js/WebCalendar.js" type="text/javascript"></script>
    <script type="text/javascript" charset="utf-8" src="../../Content/ueditorUTF8/ueditor.config.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../Content/ueditorUTF8/ueditor.all.min.js"></script>
    <script type="text/javascript" charset="utf-8" src="../../Content/ueditorUTF8/lang/zh-cn/zh-cn.js"></script>
    <script type="text/javascript">

        //实例化编辑器
        //建议使用工厂方法getEditor创建和引用编辑器实例，如果在某个闭包下引用该编辑器，直接调用UE.getEditor('editor')就能拿到相关的实例
        var ue = UE.getEditor('txtEditorContents');


        function isFocus(e) {
            alert(UE.getEditor('editor').isFocus());
            UE.dom.domUtils.preventDefault(e)
        }
        function setblur(e) {
            UE.getEditor('editor').blur();
            UE.dom.domUtils.preventDefault(e)
        }
        function insertHtml() {
            var value = prompt('插入html代码', '');
            UE.getEditor('editor').execCommand('insertHtml', value)
        }
        function createEditor() {
            enableBtn();
            UE.getEditor('editor');
        }
        function getAllHtml() {
            alert(UE.getEditor('editor').getAllHtml())
        }
        function getContent() {
            var arr = [];
            arr.push("使用editor.getContent()方法可以获得编辑器的内容");
            arr.push("内容为：");
            arr.push(UE.getEditor('editor').getContent());
            alert(arr.join("\n"));
        }
        function getPlainTxt() {
            var arr = [];
            arr.push("使用editor.getPlainTxt()方法可以获得编辑器的带格式的纯文本内容");
            arr.push("内容为：");
            arr.push(UE.getEditor('editor').getPlainTxt());
            alert(arr.join('\n'))
        }
        function setContent(isAppendTo) {
            var arr = [];
            arr.push("使用editor.setContent('欢迎使用ueditor')方法可以设置编辑器的内容");
            UE.getEditor('editor').setContent('欢迎使用ueditor', isAppendTo);
            alert(arr.join("\n"));
        }
        function setDisabled() {
            UE.getEditor('editor').setDisabled('fullscreen');
            disableBtn("enable");
        }

        function setEnabled() {
            UE.getEditor('editor').setEnabled();
            enableBtn();
        }

        function getText() {
            //当你点击按钮时编辑区域已经失去了焦点，如果直接用getText将不会得到内容，所以要在选回来，然后取得内容
            var range = UE.getEditor('editor').selection.getRange();
            range.select();
            var txt = UE.getEditor('editor').selection.getText();
            alert(txt)
        }

        function getContentTxt() {
            var arr = [];
            arr.push("使用editor.getContentTxt()方法可以获得编辑器的纯文本内容");
            arr.push("编辑器的纯文本内容为：");
            arr.push(UE.getEditor('editor').getContentTxt());
            alert(arr.join("\n"));
        }
        function hasContent() {
            var arr = [];
            arr.push("使用editor.hasContents()方法判断编辑器里是否有内容");
            arr.push("判断结果为：");
            arr.push(UE.getEditor('editor').hasContents());
            alert(arr.join("\n"));
        }
        function setFocus() {
            UE.getEditor('editor').focus();
        }
        function deleteEditor() {
            disableBtn();
            UE.getEditor('editor').destroy();
        }
        function disableBtn(str) {
            var div = document.getElementById('btns');
            var btns = UE.dom.domUtils.getElementsByTagName(div, "button");
            for (var i = 0, btn; btn = btns[i++];) {
                if (btn.id == str) {
                    UE.dom.domUtils.removeAttributes(btn, ["disabled"]);
                } else {
                    btn.setAttribute("disabled", "true");
                }
            }
        }
        function enableBtn() {
            var div = document.getElementById('btns');
            var btns = UE.dom.domUtils.getElementsByTagName(div, "button");
            for (var i = 0, btn; btn = btns[i++];) {
                UE.dom.domUtils.removeAttributes(btn, ["disabled"]);
            }
        }

        function getLocalData() {
            alert(UE.getEditor('editor').execCommand("getlocaldata"));
        }

        function clearLocalData() {
            UE.getEditor('editor').execCommand("clearlocaldata");
            alert("已清空草稿箱")
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
       <div>
    
        <table class="table_main">
    <tr>
    <td class="table_tittle" colspan="2">新增文章</td>
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
        <asp:DropDownList ID="ddlCategory" runat="server" >
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
   </td>
    <td  align="left">
        
       
        <%--<FCKeditorV2:FCKeditor ID="FCKeditor1" Height="450px" runat="server">
        </FCKeditorV2:FCKeditor>--%>
        
        <dd style="line-height: 0; width: 89%">
            <asp:TextBox ID="txtEditorContents" name="txtEditorContents" runat="server" TextMode="MultiLine" Height="400px" Width="1000px" ClientIDMode="Static"></asp:TextBox>
        </dd> 
       
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
