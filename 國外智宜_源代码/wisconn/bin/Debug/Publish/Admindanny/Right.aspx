<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Right.aspx.cs" Inherits="ZeroStudio.Web.Admin.Right" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="./Css.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" language="javascript">
    var timer0 = null;
    timer0 = setTimeout(showTime,1000);
    function showTime()
    {
        clearTimeout(timer0);
        dt = new Date();

        var tp = document.getElementById("timePlace");
        result = dt.toLocaleTimeString();
        tp.innerHTML = result;
        timer0 = setTimeout(showTime,1000); 
    }
    </script>

</head>
<body>
    <form id="Form1" runat="server" action="">
        <table width="800" align="center" border="0" cellspacing="0" cellpadding="0" style="border-collapse: collapse">
            <tr>
                <td class="lanyuss" align="center" colspan="2">
                    系统探针</td>
            </tr>
            <tr>
                <td class="lanyuds" width="30%" align="left">
                    &nbsp;管理员名称：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Label1" ForeColor="red" runat="server" /></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器名称：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="ComName" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器IP地址：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="IP" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器域名：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Web" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器端口：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Dk" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器IIS版本：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Iis" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;程序所在目录：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Path" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器操作系统：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Os" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器脚本超时：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="TimeOut" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;.NET Framework 版本：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Framework" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器当前时间：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="Time" ForeColor="red" runat="server"></asp:Label>
                    <span id="timePlace" style="color: Red"></span>
                </td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;服务器已运行时间：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="StartTime" ForeColor="red" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;Asp.net所占内存：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="w3w" ForeColor="red" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;逻辑驱动器数：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="IDE" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;当前Session数量：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="SessionNum" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;CPU总数：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="CpuNum" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td class="lanyuds" align="left">
                    &nbsp;CPU类型：</td>
                <td class="lanyuds" align="left">
                    &nbsp;<asp:Label ID="CpuType" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
    </form>
</body>
</html>
