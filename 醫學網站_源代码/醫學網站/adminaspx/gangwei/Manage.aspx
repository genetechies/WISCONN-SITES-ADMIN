<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Web.Admin.Product.Manage" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>人才招募管理</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../js/common.js"></script>
    <script type="text/javascript" src="../../js/quickView.js"></script>
    <script type="text/javascript">
        function validText(target) {
            var page = document.getElementById(target);
            if (page.value == "") {
                alert('請輸入排序號!');
                page.focus();
                return false;
            }
            if (isNaN(page.value)) {
                alert('排序號須為數字!');
                page.focus();
                return false;
            }
            if (parseInt(page.value) < 0) {
                alert('排序號須為大於等於零的正整數!');
                page.focus();
                return false;
            }
            return true;
        }
        function clearSearchText(searchText){
	        if(document.getElementById(searchText).value=="查詢人才招募訊息"){
		        document.getElementById(searchText).value="";
	        }
        }
        function SelectAll(chk) {
            var flag = false;
            for (var li_i = 0; li_i < document.forms[0].elements.length; li_i++) {
                var e = document.forms[0].elements[li_i];
                var ls_temp;
                ls_temp = e.name;
                if (e.type == "checkbox") {
                    e.checked = chk.checked;
                }
            }
        }
    </script>
</head>

<script language="javascript" type="text/javascript">
function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}
</script>

<body>
<div class="BodyRight">
    <form id="form1" runat="server">
	<div class="PageContent">
	    <br />
		<table width="100%" border="0" cellpadding="0" cellspacing="0" style="border:1px solid #BDC9D6;height:35px">
		  <tr>
			<td>
			<table width="95%" border="0" cellpadding="0" cellspacing="0" style="margin-left:20px;">
			  <tr>
				<td style="width: 300px">人才招募列表</td>
				<td align="center">
				    
		             <asp:TextBox ID="searchText1" runat="server" style="vertical-align:middle" onfocus="javascript:clearSearchText('searchText1');" Text="查詢人才招募訊息"></asp:TextBox>&nbsp;<asp:Button 
                        ID="Button2" runat="server" Text="查詢" onclick="Button2_Click" />
&nbsp;</td>
				<td  class="bt_add">&nbsp;&nbsp;&nbsp;<a href="Add.aspx">新增</a>
				 </td>
			  </tr>
			</table>
			</td>
		  </tr>
		</table>
		<br />
		<br />
		<br />
		
        <div class="tablelist">
        <table width="100%" border="0" cellpadding="0" cellspacing="1" bgcolor="#CCCCCC">
        <tr bgcolor="#FFFFFF">
        <td height="27">選擇</td>
        <td>編號</td>
        <td>人才招募名稱</td>
        <td>學歷要求</td>
        <td>發佈時間</td>
        <td>排序號</td>
        <td colspan=2>操作選項</td>
        </tr>
        
             <asp:Repeater ID="productGrid" runat="server" OnItemCommand="productGrid_ItemCommand" OnItemDataBound="productGrid_ItemDataBound">
                    <ItemTemplate>
                            <tr bgcolor="#FFFFFF">
                                <td height="25"><asp:CheckBox ID="cbSelect" runat="server" /></td>
                                <td><%#Eval("id")%></td>
                                <td><%#Eval("gangwei")%></td>
                                <td><%#Eval("xueli")%></td>
                                <td><%#Eval("time", "{0:yyyy-MM-dd}")%></td>
                                
                                <td>
                                    <asp:Label ID="lblPID" runat="server" Text='<%#Eval("id") %>' Visible="false"></asp:Label>
                                    <asp:TextBox ID="txtParentID" runat="server" Width="40px" Text='<%# Eval("sort") %>' ></asp:TextBox>
                                    <asp:LinkButton ID="btnModfiySortKey" runat="server" CommandName="modfiy" >修改排序號</asp:LinkButton>
                                </td>
                                <td>						
                                    <a href="Edit.aspx?P_id=<%#Eval("id") %>" title="編輯"   >編輯</a>&nbsp;&nbsp;
                                </td>
                                <td>
                                    <asp:LinkButton ID="Del" CommandArgument='<%#Eval("id") %>' runat="server" OnClick="Del_Click" OnClientClick="return confirm('確定要刪除嗎?');" ToolTip="刪除" Text="刪除"></asp:LinkButton>
                                </td>
                            </tr>
                    </ItemTemplate>
                </asp:Repeater>
                </table>
               
        </div>
        <div class="tablelisthead">
             <ul>
                    <li class="li_5">&nbsp;</li>
                    <li class="li_27"><input type="checkbox" onclick="SelectAll(this);" />全選</li>
                    <li class="li_15">[<asp:LinkButton ID="btnDelAll" runat="server" OnClientClick="return confirm('確定要徹底刪除選擇的人才招募嗎');" style="color:#888888" OnClick="btnDelAll_Click" ToolTip="刪除選擇的人才招募" >刪除所選</asp:LinkButton>]</li>
                    <li class="li_15">&nbsp;</li>
                    <li class="li_10">&nbsp;</li>
                    <li class="li_5">&nbsp;</li>
                    <li class="li_10">&nbsp;</li>
                    <li class="li_10"></li>
                </ul>
        </div>
        <div>
        <table width="100%" align="center" border="0" cellpadding="0" cellspacing="0" >
            <tr>
                <td class="lanyuds" colspan="5" align="center">
                        &nbsp;<webdiyer:aspnetpager id="AspNetPager1" runat="server" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager1_PageChanged"></webdiyer:aspnetpager>
                        
                </td>
            </tr>
        </table>
    </div>
    </div>
    </form>
    </div>
</body>
</html>
