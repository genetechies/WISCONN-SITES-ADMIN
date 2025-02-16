<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageUpload.aspx.cs" Inherits="Web.Admin.Product.ImageUpload" %>
<%@ Register Assembly="FlashUpload" Namespace="FlashUpload" TagPrefix="FlashUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>LOGO圖批量上傳</title>
    <link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
			<td width="88%" height="24">客戶實績 > LOGO圖批量上傳</td>
			<td width="12%" align="right"></td>
		  </tr>
		</table>
		</td>
	  </tr>
      <tr>
    <td class="LineRightBlue1">
        網站：<asp:CheckBoxList ID="cbxWeb" runat="server" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
        </td>
    </tr>
	</table>
	<table width="100%" border="0" cellspacing="0" cellpadding="0" class="ListCategory" style="margin-top:10px;">
		<tr><td style="border:none;">
		<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">				
		<tr class="secondalt">
			<td valign="top" style="padding-left:10px;padding-top:3px; padding-bottom:3px;"><span>使用說明</span></td>
			<td  style="padding-top:3px; padding-bottom:3px;">
            <div style="line-height:18px;"><b>(1)</b> 最佳解析度500*500;</div>
            <div style="line-height:18px;"><b>(2)</b> 最佳圖片大小為250kb內，支持jpg、gif、png，每次可上傳總批量爲5Mb;</div>
            </td>
		</tr>
	</table>
		</td></tr>
	</table>
	<table width="100%" height="30" border="0" cellspacing="0" class="ListCategory" cellpadding="0" style="margin-top:10px;">
	     <tr><td style="border:none;">
		<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">				
		<tr class="secondalt">
			<td valign="top" style="padding-left:10px;padding-top:3px; padding-bottom:3px;"><span>上傳批量圖片</span></td>
			<td  style="padding-top:3px; padding-bottom:3px;">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"></asp:LinkButton>
            <asp:Label ID="Result" runat="server" ></asp:Label>
            <FlashUpload:FlashUpload ID="flashUpload" runat="server" 
            UploadPage="Upload.axd" OnUploadComplete="UploadComplete()" 
            FileTypeDescription="Images(只能為圖片類型!)" FileTypes="*.gif; *.png; *.jpg; *.jpeg" 
            UploadFileSizeLimit="512000" TotalUploadSizeLimit="5242880" />
            </td>
		</tr>
	    </table>
		</td></tr>
   </table>
   </div>
   </div>
    </form>
</body>
</html>
