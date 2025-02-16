<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImportPartners.aspx.cs" Inherits="Admin_Partners_ImportPartners" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>合作夥伴匯入</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../Css.css" rel="stylesheet" type="text/css" />
</head>
<body leftmargin="10" topmargin="10" marginwidth="10" marginheight="10">
    <form id="form1" runat="server">
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td ><strong>合作夥伴匯入</strong></td>
       </tr>
    </table>
<table width="100%" border="0" cellspacing="0" cellpadding="0" class="table_main" style="margin-top:10px;">
		<tr><td style="border:none;">
		<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">
		<tr class="secondalt">
			<td>&nbsp; 發佈網站&nbsp;</td>
			<td style="padding-top:3px; padding-bottom:3px;">
        <asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
			</td>
		</tr>							
		<tr class="secondalt">
			<td><span style="padding-left:10px;">批量匯入Excel數據</span></td>
			<td style="padding-top:3px; padding-bottom:3px;">
 				<asp:FileUpload ID="FileUpload1" runat="server" CssClass="FormSmall"/>&nbsp;
        <asp:Button ID="Button1" runat="server" Text=" 匯入 " onclick="Button1_Click" class="bginput" />
			</td>
		</tr>							
		<tr class="firstalt">
			<td style="padding-left:10px;"><span>下載Excel模版</span></td>
			<td  height="22" style="padding-top:3px; padding-bottom:3px;">
 				<a href="?action=downloadexcel">下載Excel模版</a>
			</td>
		</tr>							
		<tr class="secondalt">
			<td valign="top" style="padding-left:10px;padding-top:3px; padding-bottom:3px;"><span>使用說明</span></td>
			<td  style="padding-top:3px; padding-bottom:3px;">
   <div style="line-height:18px;"><b>(1)</b> 下載Excel模版文件;</div>
   <div style="line-height:18px;"><b>(2)</b> 填寫Excel文件,可以使用Excel打開下載的模版文件;<br />
       <div>
           <b>(3)</b> 上傳Excel文件</div>
                                        <br /></div>
		</tr>
	</table>
	
		</td></tr>
	</table>
    </div>
   </form>
</body>
</html>

