<%@ Page Language="C#" AutoEventWireup="true" CodeFile ="Manage.aspx.cs" Inherits="ZeroStudio.Web.Admin.ProductClass.Manage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>產品分類管理</title>
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
    <table class="table_main">
       <tr  class="table_tittle">
          <td colspan="3" ><strong>新增分類</strong></td>
       </tr>
       <tr>
         <td width="18%" >類別名稱(中文)</td>
         <td width="82%" colspan="2" >
          <strong>
            <asp:TextBox ID="txtCategoryName" runat="server" ></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName" ErrorMessage="請輸入類別名稱（中文）" ValidationGroup="add" SetFocusOnError ="true" ></asp:RequiredFieldValidator>
            <asp:Label ID="lblCategoryID" runat="server" Visible="false"></asp:Label>
          </strong>
         </td>
       </tr>
       <tr>
         <td width="18%">類別名稱(英文)</td>
         <td width="82%" colspan="2">
             <asp:TextBox ID="txtCategoryNameEn" runat="server" ></asp:TextBox>
             <asp:RequiredFieldValidator ID="rfvCategoryNameEn" runat="server" ControlToValidate="txtCategoryNameEn" ErrorMessage="請輸入類別名稱（英文）" ValidationGroup="add" SetFocusOnError="true"></asp:RequiredFieldValidator>
         </td>
       </tr>
       <tr>
         <td width="18%"> 類別圖片：</td>
         <td width="82%" colspan="2">
            <asp:FileUpload ID="FileUpload1" runat="server" /> 
            <asp:Button ID="Button2" runat="server" Text="上傳" OnClick="UpFile_Click" /> 
         </td>
       </tr>
       <tr>
         <td width="18%" >類別圖片路徑：</td>
         <td width="82%" colspan="2">
             <asp:TextBox ID="txtPhotoUrl" runat="server" ReadOnly="true"></asp:TextBox>
    </td>
    </tr>
       <tr>
         <td >排序號</td>
         <td colspan="2" >
           <strong>
             <asp:Label ID="lblSortKey" runat="server" ></asp:Label>
           </strong>
         </td>
       </tr> 
       <tr>
         <td >所屬類別</td>
         <td colspan="2" ><strong><asp:Label ID="lblParent" runat="server" ></asp:Label></strong><asp:Label ID="lblParentID" runat="server" Visible="false" ></asp:Label></td>
       </tr>
        <tr>
         <td width="18%" >Description：</td>
         <td width="82%" colspan="2">
             <asp:TextBox ID="description" runat="server"></asp:TextBox>
    </td></tr>
        <tr>
         <td width="18%" >Keywords：</td>
         <td width="82%" colspan="2">
             <asp:TextBox ID="keywords" runat="server" ></asp:TextBox>
    </td></tr>

       <tr>
          <td >&nbsp;</td>
          <td colspan="2">
            <asp:Button ID="btnAdd" runat="server"  CssClass="button" Text="新增" onclick="btnAdd_Click"/>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBack" runat="server"  CssClass="button" Text="返回" onclick="btnBack_Click"/>
          </td>
       </tr>
    </table>
    <asp:GridView ID="categoryGrid" runat="server" AutoGenerateColumns="False" CssClass="table_textcenter" 
         onrowdatabound="categoryGrid_RowDataBound" >
        <Columns>
            <asp:BoundField DataField="PC_Id" HeaderText="類別編號"></asp:BoundField>
            <asp:BoundField DataField="PC_SortKey" HeaderText="序 號"></asp:BoundField>
            <asp:TemplateField HeaderText="類別名稱(中文)">
                <ItemTemplate>
                 <div style="text-align:left; text-indent:10px;"><asp:Literal ID="ltlName" runat="server" Text='<%#GetImage(Eval("PC_ImageUrl"), Eval("PC_ClassName"))%>' ></asp:Literal></div>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="PC_ClassName_En" HeaderText="類別名稱(英文)" />
            <asp:TemplateField HeaderText="排序">
                <ItemTemplate>
                    <asp:Label ID="lblCateID" runat="server" Text='<%# Eval("PC_Id") %>' Visible="false"></asp:Label>
                    <asp:DropDownList ID="ddlSortKey" runat="server"></asp:DropDownList>
                    <asp:LinkButton ID="btnModfiySortKey" runat="server" CssClass="button" OnClick="btnModfiySortKey_Click">修改序號</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="操作選項">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# String.Format("Manage.aspx?ParentID={0}",Eval("PC_Id")) %>' >新增/查看子類</asp:HyperLink>&nbsp;&nbsp;
                    <asp:LinkButton ID="btnDelete" runat="server" CommandArgument='<%#Eval("PC_Id") %>' OnClick="btnDelete_Click" OnClientClick="return confirm('確定要刪除嗎?')" >刪除</asp:LinkButton>&nbsp;&nbsp;
                    <asp:LinkButton ID="btnModfiy" runat="server" CommandArgument='<%#Eval("PC_Id") %>' OnClick="btnModfiy_Click" >修改</asp:LinkButton>&nbsp;&nbsp;
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <HeaderStyle CssClass="table_tittle" Font-Bold="False" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" Wrap="False" />
    </asp:GridView>
    <br />
    </div>
    <div style="height:100px">&nbsp;</div>
    </form>
</body>
</html>
