<%@ Page Language="C#" AutoEventWireup="true" CodeFile="outjianli.aspx.cs" Inherits="Web.Admin.GuestBook.Manage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>匯出履歷</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td ><strong>匯出履歷</strong></td>
       </tr>
    </table>
    <table width="100%" border="0" cellspacing="0" cellpadding="0" class="table_main" style="margin-top:10px;">
		<tr><td style="border:none;">
		<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">				
		<tr class="secondalt">
			<td valign="top" style="padding-left:10px;padding-top:3px; padding-bottom:3px;"><span>使用說明</span></td>
			<td  style="padding-top:3px; padding-bottom:3px;">
   <div style="line-height:18px;"><b>(1)</b> EXCEL可批量下載目前所有的履歷;</div>
   </td>
		</tr>
	</table>
		</td></tr>
	</table>
	<table width="100%" height="30" border="0" cellspacing="0" cellpadding="0" style="margin-top:10px;">
		<tr>
			<td align="center">
			<asp:Panel ID="importPanel" Width="100%" runat="server" style="text-align:center;margin-top:100px;">
                <asp:Button ID="btnImportOut" runat="server" CssClass="bginput" Text="匯出Excel" OnClick="btnImportOut_Click" />
            </asp:Panel>
            
			</td>
		</tr>
   </table>
    <center>
            
        </center>
        </div>
    </form>
</body>
</html>
