<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AutoUpload.aspx.cs" Inherits="ZeroStudio.Web.Admin.Product.AutoUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>批量上傳</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="robots" content="noindex, nofollow" />
    <link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
    <script src="../images/js/prototype.js" type="text/javascript"></script>
    <script src="../images/js/scriptaculous.js?load=effects,builder" type="text/javascript"></script>
    <script type="text/javascript" src="../../js/common.js"></script>
   
</head>
<body leftmargin="10" topmargin="10" marginwidth="10" marginheight="10">
<div class="BodyRight">
	<div class="RightDetill">
		<ul>
			
		</ul>
	</div>
	
	<div class="PageContent">
	<%
    if (Request["action"] != null)
    {
        if (Request["action"] == "importconfirm")
        {   
                
                    
	%>
	
	<form name="theForm" method="post" action="AutoUpload.aspx?action=importinsert">
	<table width="100%" border="0" cellspacing="0" cellpadding="0" class="ListCategory">
		<tr>
			<th height="35" align="center" width="45" ><span>選擇</span></th>
			<th>產品編號</th>
			<th>第三層欄位名稱</th>
			<th>類別編號</th>
			<th>產品料號</th>
			<th>第四層JPG圖片檔</th>
			<th>產品詳細PDF文檔</th>	
		</tr>
		<%
    if (table != null && table.Rows.Count > 0)
    {
        int i = 0;
        foreach (System.Data.DataRow row in table.Rows)
        {
        %>
		<tr style="line-height:27px;">
			<td align="center"  height="35" width="45"> 
			<input type="checkbox" name="product[]"   value="<%=i.ToString() %>" checked="checked" />
			</td>
			<td><input type="text" class="FormSmall" style="width:110px;height:65px;" name="pcode[<%=i.ToString() %>]" value="<%=row[0].ToString() %>" /></td>
			<td><input type="text" class="FormSmall" style="width:110px;height:65px;" name="pclassname[<%=i.ToString() %>]" value="<%=row[1].ToString() %>" /></td>
			<td><input type="text" class="FormSmall" style="width:110px;height:65px;" name="pclassid[<%=i.ToString() %>]" value="<%=row[2].ToString() %>" /></td>
			<td><input type="text" class="FormSmall" style="width:110px;height:65px;" name="pmodel[<%=i.ToString() %>]" value="<%=row[3].ToString() %>" /></td>
			<td><input type="text" class="FormSmall" style="width:110px;height:65px;" name="pimageurl[<%=i.ToString() %>]" value="<%=row[4].ToString() %>" /></td>
			<td><input type="text" class="FormSmall" style="width:110px;height:65px;" name="pdoc[<%=i.ToString() %>]" value="<%=row[5].ToString() %>" /></td>
		</tr>
		<%
    i++;
        }
    } %>				
    </table>
	<table width="100%" border="0" cellspacing="0" cellpadding="0">
		  <tr>
			<td height="15" ></td>
		  </tr>
		  <tr>
			<td height="36" class="BotNavBg">
				<table width="100%" border="0" cellspacing="0" cellpadding="0">
			  <tr>
				<td width="50" align="left" style="padding-left:13px;"><input type="checkbox" name="check_all" checked value="yes" onClick="return select_all('product_','theForm');" /> 全選</td>
				<td style="padding-left:5px;" align="left">
				    <input type="hidden" name="productids" id="productids" value="" />
					<input type="hidden" name="category_id" value="<%=category_id %>" />
					<input type="button" id="btSubmit" name="btSubmit" value=" 批量匯入 " onclick="go();" />
				</td>
			  </tr>
			</table>
			</td>
		  </tr>
		</table>	

</form>

	<%}
        if (Request["action"] == "importinsert")
        {
               %>
      
               <%
    }
    }
    else
    { %>
	<table width="100%" border="0" cellpadding="0" cellspacing="0">
	  <tr>
		<td class="LineRightBlue1">
			<table width="95%" border="0" cellpadding="0" cellspacing="0" style="margin-left:20px;">
		  <tr>
			<td width="88%" height="24">產品管理 > 產品批量上傳</td>
			<td width="12%" align="right"></td>
		  </tr>
		</table>
		</td>
	  </tr>
	</table>
	
	
	<form action="AutoUpload.aspx?action=importconfirm" enctype="multipart/form-data" method="post" name="theForm" onsubmit="return doSubmit()">
	
	
	<table width="100%" border="0" cellspacing="0" cellpadding="0" class="ListCategory" style="margin-top:10px;">
		<tr><td style="border:none;">
		<table width="100%" border="0" cellspacing="0" cellpadding="0" class="Font">
		<tr class="secondalt">
			<td><span style="padding-left:10px;">上傳批量Excel檔案</span></td>
			<td style="padding-top:3px; padding-bottom:3px;">
 				<input type="file" class="FormSmall" style="width:210px;" name="excelfile" />
			</td>
		</tr>							
		<tr class="firstalt">
			<td style="padding-left:10px;"><span>下載Excel模版</span></td>
			<td  height="22" style="padding-top:3px; padding-bottom:3px;">
 				<a href="AutoUpload.aspx?action=downloadexcel">下載Excel模版</a>
			</td>
		</tr>							
		<tr class="secondalt">
			<td valign="top" style="padding-left:10px;padding-top:3px; padding-bottom:3px;"><span>使用說明</span></td>
			<td  style="padding-top:3px; padding-bottom:3px;">
   <div style="line-height:18px;"><b>(1)</b> 下載Excel模版檔案;</div>
   <div style="line-height:18px;"><b>(2)</b> 填寫Excel檔案,可以使用Excel打開下載的模版檔案;<br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;產品圖片請直接填寫圖片檔案名,無需帶路徑,如：abc.jpg;<br />
	 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;產品文檔請直接填寫文檔檔案名,無需帶路徑,如：abc.pdf;</div>
   <div style="line-height:18px;"><b>(3)</b> 將填寫的產品圖片通過圖片上傳功能上傳到伺服器;<br />
     &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;將填寫的產品文檔通過文檔上傳功能上傳到伺服器;</div>
   <div><b>(4)</b> 上傳Excel檔案</div>
   <br />
		</tr>
	</table>
		</td></tr>
	</table>
	
	
	<table width="100%" height="30" border="0" cellspacing="0" cellpadding="0" style="margin-top:10px;">
		<tr>
			<td align="center">
			<input type="submit" id="Submit1"  class="bginput" name="btSubmit" value=" 匯入 " />
			</td>
		</tr>
		</table>
	</form>
	<%} %>
	
	</div>
</div>
<%if (Request["action"] == null)
  { %>
<script type="text/javascript">
function doSubmit(submenu,imgbar) {
	//var category=document.theForm.category.value;
	var excelfile=document.theForm.excelfile.value;
	//if(category==0){
	//	alert("請您選擇所屬分類!");
	//	document.theForm.category.focus();  
    //    return false;   
	//}
	if(excelfile == ""){
		alert("請您上傳批量Excel檔案!");
		return false;
	}
	return true;
}


</script>
<%}
  else
  { %>
<script type="text/javascript">
function go()
{
    var num=0; 
    var ids=",";
	var product=document.getElementsByName("product[]")
	for(var i=0;i<product.length;i++){ 
	    if(product[i].checked==true){   
			  num=num+1;
			  if(ids.indexOf(","+product[i].value+",")<0)
			  {
			    ids+=(product[i].value+",");
			  }
			} 
		}
		document.getElementById("productids").value=ids;
		if(num==0){
			alert("沒有選擇產品");
			return;
		}
		if(num>0)
		{
	        document.forms[0].submit();
	    }
}

</script>
<%} %>
<div style="clear:both; margin-bottom:30px;"></div>
</body>
</html>
