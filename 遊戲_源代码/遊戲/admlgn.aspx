<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admlgn.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<body>
    <form id="form1" runat="server">
          <table width="730" border="0" cellspacing="0" cellpadding="0">   
            <tr>
              <td style="width:80px"><asp:Label ID="lblUserName" runat="server" Text="UserName:"></asp:Label></td>
              <td><asp:TextBox ID="ttbUserName" runat="server" Width="200px"></asp:TextBox></td>
            </tr>
            <tr>
              <td style="width:80px"><asp:Label ID="lblPwd" runat="server" Text="PassWord:"></asp:Label></td>
              <td><asp:TextBox ID="ttbPwd" runat="server" Width="200px" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr> 
              <td style="width:80px"></td>
              <td height="20" valign="top"> 
              
              <asp:Button ID="btnLogin" runat="server" Text="Login" onclick="btnLogin_Click"  />
              </td> 
            </tr> 
            <tr>
             <td colspan="2"><asp:Label ID="lblStatus" runat="server" Width="300px"></asp:Label></td>
            </tr>       
          </table>
    </form>
</body>
</html>
