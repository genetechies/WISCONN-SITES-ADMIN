<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImportOut.aspx.cs" Inherits="ZeroStudio.Web.Admin.Product.ImportOut" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EXCEL批量匯出</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="robots" content="noindex, nofollow" />
    <link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function download(){
            window.location.href="/data/productdata.xls";
        }
    </script>
</head>
<body leftmargin="10" topmargin="10" marginwidth="10" marginheight="10">
    <form id="form1" runat="server">
    <div class="BodyRight">
	<div class="RightDetill">
		<ul>
			
		</ul>
	</div>
	
	<div class="PageContent">
    <table width="100%" border="0" cellpadding="0" cellspacing="0">
	  <tr>
		<td class="LineRightBlue1">
			<table width="95%" border="0" cellpadding="0" cellspacing="0" style="margin-left:20px;">
		  <tr>
			<td width="88%" height="24">產品管理 > EXCEL批量匯出</td>
			<td width="12%" align="right"></td>
		  </tr>
		</table>
		</td>
	  </tr>
	</table>
	<table width="100%" border="0" cellspacing="0" cellpadding="0" class="ListCategory" style="margin-top:10px;">
		<tr><td style="border:none;">
		<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">				
		<tr class="secondalt">
			<td valign="top" style="padding-left:10px;padding-top:3px; padding-bottom:3px;"><span>使用說明</span></td>
			<td  style="padding-top:3px; padding-bottom:3px;">
   <div style="line-height:18px;"><b>(1)</b> EXCEL可批量下載目前所有的產品內容;</div>
   <div style="line-height:18px;"><b>(2)</b> 若要修改產品內容，可直接在EXCEL檔案中做新增、修改;</div>
   <div style="line-height:18px;"><b>(3)</b> 調整產品內容後，重新批量匯入，即完成內容修正;</div>
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
            <asp:Panel ID="downloadPanel" Width="100%" runat="server" style="text-align:center;margin-top:100px">
                <input type="button" value="匯出" class="bginput" onclick="download();" />
            </asp:Panel>
			</td>
		</tr>
   </table>
   </div>
   </div>
   </form>
</body>
</html>
