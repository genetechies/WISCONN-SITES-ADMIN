<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryCategory.aspx.cs" Inherits="ZeroStudio.Web.Admin.ProductClass.QueryCategory" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>查詢分類</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="../../js/quickView.js"></script>
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
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div>
    <table class="table_main">
       <tr  class="table_tittle">
          <td colspan="3" ><strong>查詢分類</strong></td>
       </tr>
       <tr>
         <td width="18%" >類別名稱</td>
         <td width="82%" colspan="2" >
          <strong>
            <asp:TextBox ID="txtCategoryName" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="請輸入類別名稱" ValidationGroup="query" SetFocusOnError ="true" ></asp:RequiredFieldValidator>
            <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Text="查詢分類" ValidationGroup="query" />
          </strong>
         </td>
       </tr>
    </table>
    <asp:GridView ID="categoryGrid" runat="server" AutoGenerateColumns="False" CssClass="table_textcenter" >
        <Columns>
            <asp:BoundField DataField="PC_Id" HeaderText="類別編號"></asp:BoundField>
            <asp:TemplateField HeaderText="類別名稱(中文帶階層)">
                <ItemTemplate>
                 <div style="text-align:left; text-indent:10px;"><asp:Literal ID="ltlName" runat="server" Text='<%#GetImage(Eval("PC_ImageUrl"), Eval("PC_Id"))%>' ></asp:Literal></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="PC_ClassName_En" HeaderText="類別名稱(英文)" />
        </Columns>
    </asp:GridView>
    </div>
    <div style="height:100px">&nbsp;</div>
    </form>
</body>
</html>
