<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reply.aspx.cs" Inherits="Web.Admin.GuestBook.Reply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>詳細內容</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td colspan="3" ><strong>詳細內容</strong></td>
       </tr>
       <tr>
         <td width="18%">聯絡人</td>
         <td width="82%" colspan="2">
             &nbsp;<%=book.LinksName%></td>
       </tr>
       <tr>
         <td>聯絡電話</td>
         <td colspan="2">
             &nbsp;<%=book.LinksTel %></td>
       </tr>
       <tr>
         <td >聯絡郵件</td>
         <td  colspan="2">
             &nbsp;<%=book.LinksEmail %></td>
       </tr>
       <tr>
         <td>服務項目</td>
         <td colspan="2">
             &nbsp;<%=book.SerPro %></td>
       </tr>
        <tr>
         <td>原始語種(從)</td>
         <td colspan="2">
             &nbsp;<%=book.OrgLanguage %></td>
       </tr>
        
        <tr>
         <td>目地語言(翻譯成)</td>
         <td colspan="2">
             &nbsp;<%=book.ToLanguage %></td>
       </tr>
       <tr>
         <td >估計頁數或字數</td>
         <td colspan="2" >
             &nbsp;<%=book.TxtCount%><%=book.TxtSCount%></td>
       </tr>
        <tr>
         <td>是否需要排版</td>
         <td colspan="2">
             &nbsp;<%=book.ispaiban == 1 ? "是" : "否"%></td>
       </tr>
       <tr>
         <td>是否需要二次校稿</td>
         <td colspan="2">
             &nbsp;<%=book.ercijiaogao == 1 ? "是" : "否"%></td>
       </tr>
       <tr>
         <td>是否需要潤稿</td>
         <td colspan="2">
             &nbsp;<%=book.rungao == 1 ? "是" : "否"%></td>
       </tr>
       <tr>
         <td>交件時間</td>
         <td colspan="2">
             &nbsp;<%=book.JiaojianTime%></td>
       </tr>
       <tr>
         <td>工作日</td>
         <td colspan="2">
             &nbsp;<%=book.gongzuori%></td>
       </tr>
        
        <tr>
         <td>專案注意事項</td>
         <td colspan="2">
             &nbsp;<%=book.zhuyicontent %></td>
       </tr>


       <tr>
         <td >文件資料</td>
         <td colspan="2">
             &nbsp;<a href="<%=book.Annex %>" target="_blank"><%=book.Annex%></a></td>
       </tr>
       <tr>
         <td >留言IP地址</td>
         <td colspan="2">
             &nbsp;<%=book.ip %></td>
       </tr>
       <tr>
         <td>處理情況</td>
         <td colspan="2">
             &nbsp;<%=book.Finish == 0 ? "未處理" : "已處理" %></td>
       </tr>
        <tr>
            <td>備註</td>
            <td colspan="2">
                &nbsp;<%=book.Note %></td>
        </tr> 
       <tr>
         <td >&nbsp;</td>
         <td colspan="2">
             <input id="Reset1" type="reset" value="返回" onclick="history.go(-1)" />         
         </td>
       </tr>
    </table>
    </div>
    </form>
</body>
</html>
