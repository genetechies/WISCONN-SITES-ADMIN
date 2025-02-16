<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reply.aspx.cs" Inherits="Web.Admin.GuestBook.Reply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>求職履歷內容</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td colspan="2" ><strong>求職履歷內容</strong></td>
       </tr>
       <tr>
         <td width="18%">姓名</td>
         <td width="82%">
             &nbsp;<%=book.UserName%>&nbsp;&nbsp;年齡：<%=book.Age%> &nbsp;&nbsp;性別：<%=book.Sex%> &nbsp;&nbsp;最高學歷：<%=book.TopGraduation%> &nbsp;&nbsp;應聘時間：<%=book.CreateDate%> </td>
       </tr>
       <tr>
         <td>工作別</td>
         <td>
             &nbsp;<%=worktype(book.WorkType)%></td>
       </tr>
       <tr>
         <td >是否在學</td>
         <td>
             &nbsp;<%=book.IsLearning.Equals("Y")?"是":"否"%></td>
       </tr>
       <tr>
         <td>主要語言</td>
         <td>
             &nbsp;<%=book.MasterLanguage%></td>
       </tr>
        <tr>
         <td>翻譯年資</td>
         <td>
             &nbsp;<%=book.Seniority%></td>
       </tr>
        
        <tr>
         <td>翻譯量</td>
         <td>
             &nbsp;<%=book.TranslationAmount%>&nbsp;字/ 天</td>
       </tr>
        <tr>
         <td>第二外語</td>
         <td>
             &nbsp;<%=language(book.Language)%></td>
       </tr>
       <tr>
         <td >翻譯專長</td>
         <td>
             &nbsp;<%=translationskill(book.TransLationSkill)%></td>
       </tr>
       <tr>
         <td >專長軟件</td>
         <td>
             &nbsp;<%=softwareskill(book.SoftwareSkill)%></td>
       </tr>
       
       <tr>
         <td >電話</td>
         <td>
             &nbsp;<%=book.TEL%></td>
       </tr>
       <tr>
         <td >E-mail</td>
         <td>
             &nbsp;<%=book.Email%></td>
       </tr>
       <tr>
         <td >QQ</td>
         <td>
             &nbsp;<%=book.QQ%></td>
       </tr>
       <tr>
         <td >MSN</td>
         <td>
             &nbsp;<%=book.MSN %></td>
       </tr>
       <tr>
         <td >翻譯經歷</td>
         <td>
             &nbsp;<%=book.Experience%></td>
       </tr>
       <tr>
         <td>處理情況</td>
         <td>
             &nbsp;<%=book.state == 0 ? "未閱" : "已閱"%></td>
       </tr>
       <tr>
         <td >&nbsp;</td>
         <td>
             <input id="Reset1" type="reset" value="返回" onclick="history.go(-1)" />         
         </td>
       </tr>
    </table>
    </div>
    </form>
</body>
</html>
