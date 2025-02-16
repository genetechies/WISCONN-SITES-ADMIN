<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage.aspx.cs" Inherits="Admin_Friendly_Manage" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>合作夥伴管理</title>
    <link href="../Css.css" rel="stylesheet" type="text/css" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
       </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table class="table_main" cellpadding="0" cellspacing="1">
    <tr>
    <td class="table_tittle"  colspan="7">合作夥伴管理</td>
    <td colspan="3"><strong><a href="add.aspx" >>>新增合作夥伴</a></strong></td>
    </tr>
    <tr>
        <td colspan="10" style="height:30px;line-height:30px;" >廠商名稱：<asp:TextBox ID="txtTitle" runat="server" ></asp:TextBox>&nbsp;&nbsp;&nbsp;<%--欄位：<asp:DropDownList ID="ddlCategory" runat="server" ></asp:DropDownList>&nbsp;&nbsp;&nbsp;--%>管理員：<asp:TextBox ID="txtInput" runat="server" ></asp:TextBox>&nbsp;&nbsp;&nbsp;<%--修改者：<asp:TextBox ID="txtModfiy" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;--%><asp:Button ID="btnSearch" runat="server" Text="查詢" OnClick="btnSearch_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a href="#" onmousemove="showDiv('downindex.html')" onmouseout="hideDiv('downindex.html')"> 首頁 </a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="#" onmousemove="showDiv('downlink.html')" onmouseout="hideDiv('downlink.html')"> 友好連結 </a> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <a href="#" onmousemove="showDiv('downother.html')" onmouseout="hideDiv('downother.html')"> 其它頁面  </a></td>
    </tr>
    <tr>
    <td align="center" width="35">選擇</td>
    <td align="center">編號</td>
    <td align="center">廠商名稱</td>
    <td align="center" width="35%">超連結</td>
    <td align="center">擺放位置</td>
    <td align="center">管理員</td>
    <td align="center">排序號</td>
    <td align="center">修改時間</td>
    <td align="center">修改</td>
    <td align="center">刪除</td>
    </tr>
    <asp:Repeater ID="rpt_news" runat="server" OnItemCommand="rpt_news_ItemCommand" OnItemDataBound="rpt_news_ItemDataBound">
    <ItemTemplate>
    <tr>
    <td align="center" width="35"><asp:CheckBox ID="cbSelect" runat="server" /><asp:Label ID="lblNID" runat="server" Visible="false" Text='<%#Eval("F_Id") %>' ></asp:Label><asp:Label ID="lblLCTION" runat="server" Visible="false" Text='<%#Eval("F_Location") %>' ></asp:Label></td>
    <td align="left"><%#Eval("F_Id")%></td>
    <td align="left"><%#Eval("F_Name") %></td>
    <td align="left"width="35%"><%#Eval("F_Url") %></td>
    <td align="center"><%# GetLocationName(Eval("F_Location").ToString()) %></td>
    <td align="center"><%#Eval("F_Author") %></td>
    <td align="center">
     <asp:TextBox ID="txtParentID" runat="server" Width="40px" Text='<%# Eval("F_SortKey") %>' ></asp:TextBox>
     <asp:LinkButton ID="btnModfiySortKey" runat="server" CommandName="modfiy" >修改排序號</asp:LinkButton></td>
    <td align="center"><%#Eval("F_OptionTime","{0:yyyy-MM-dd}") %></td>
    <td align="center">
       [<a href="Edit.aspx?N_id=<%#Eval("F_Id") %>">修改</a>]
    </td>
    <td align="center">
           [<asp:LinkButton ID="Del" CommandArgument='<%#Eval("F_Id") %>' runat="server" OnCommand="Del_Click" OnClientClick="return confirm('確定要刪除嗎?');">刪除</asp:LinkButton>]
    </td>
    </tr>
    </ItemTemplate>
    </asp:Repeater>
    <tr>
       <td colspan="10" align="right">
           <asp:LinkButton ID="btnDelAll" runat="server" OnClientClick="return confirm('確定要刪除所選的行銷實績嗎');" OnCommand="btnDelAll_Click" ToolTip="刪除所選擇的行銷實績" >刪除所選</asp:LinkButton>&nbsp;&nbsp;&nbsp;&nbsp;
       </td>
    </tr>
    <tr>
    <td colspan="10" align="center" >
    <webdiyer:aspnetpager id="AspNetPager1" runat="server" OnPageChanged="AspNetPager1_PageChanged" CenterCurrentPageButton="True" FirstPageText="首頁" PageSize="10" LastPageText="尾頁"></webdiyer:aspnetpager>

    </td>
    </tr>
    </table>
    </div>
    <div id="IndexDiv" runat="server" style="display:none; width:700px; position: absolute;border: 2px solid #fff;background-color:White;font-size:12px;z-index:1000;"></div>
    <div id="LinkDiv" runat="server" style="display:none;width:700px; position: absolute;border: 2px solid #fff;background-color:White;font-size:12px;z-index:1000;"></div>
    <div id="OtherDiv" runat="server" style="display:none;width:700px; position: absolute;border: 2px solid #fff; background-color:White; font-size:12px;z-index:1000;"></div>
    </form>
</body>
</html>
<script language="javascript" type="text/javascript">
    function showDiv(key)
    {
        if(key=="downindex.html")
        {
            document.getElementById("IndexDiv").style.top=(document.documentElement.scrollTop+60)+'px';
            document.getElementById("IndexDiv").style.left=(document.documentElement.scrollLeft+document.documentElement.clientWidth-document.getElementById("IndexDiv").offsetWidth-50)+'px';
            document.getElementById("IndexDiv").style.display="block";
            document.getElementById("LinkDiv").style.display="none";
            document.getElementById("OtherDiv").style.display="none";
        }
        else if(key=="downlink.html")
        {
            document.getElementById("LinkDiv").style.top=(document.documentElement.scrollTop+60)+'px';
            document.getElementById("LinkDiv").style.left=(document.documentElement.scrollLeft+document.documentElement.clientWidth-document.getElementById("LinkDiv").offsetWidth-50)+'px';
            document.getElementById("LinkDiv").style.display="block";
            document.getElementById("IndexDiv").style.display="none";
            document.getElementById("OtherDiv").style.display="none";
        }
        else if(key=="downother.html")
        {
            document.getElementById("OtherDiv").style.top=(document.documentElement.scrollTop+60)+'px';
            document.getElementById("OtherDiv").style.left=(document.documentElement.scrollLeft+document.documentElement.clientWidth-document.getElementById("OtherDiv").offsetWidth-50)+'px';
            document.getElementById("OtherDiv").style.display="block";
            document.getElementById("IndexDiv").style.display="none";
            document.getElementById("LinkDiv").style.display="none";
        }
    }
    
    function hideDiv(key)
    {
        if(key=="downindex.html")
        {
            document.getElementById("IndexDiv").style.display="none";
            document.getElementById("OtherDiv").style.display="none";
            document.getElementById("LinkDiv").style.display="none";
        }
        else if(key=="downlink.html")
        {
            document.getElementById("IndexDiv").style.display="none";
            document.getElementById("OtherDiv").style.display="none";
            document.getElementById("LinkDiv").style.display="none";
        }
        else if(key=="downother.html")
        {
            document.getElementById("IndexDiv").style.display="none";
            document.getElementById("OtherDiv").style.display="none";
            document.getElementById("LinkDiv").style.display="none";
        }
    }
</script>