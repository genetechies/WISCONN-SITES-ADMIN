<%@ Page Language="C#" AutoEventWireup="true" CodeFile="masterpage.aspx.cs" Inherits="Web.Admin.masterpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <frameset rows="0,*" framespacing="0" border="0" noresize="noresize">
        <frame src="about:blank" id="header-frame" name="header-frame" frameborder="no" scrolling="no" noresize="noresize">
  <frameset cols="197,6,*" framespacing="0" border="0" id="frame-body">
    <frame src="Left.aspx" id="menu-frame" name="menu-frame" frameborder="no" scrolling="yes">
    <frame src="bar.aspx" id="drag-frame" name="drag-frame" frameborder="no" scrolling="no" noresize="noresize">
    <frame src="WebInfo.aspx" id="main-frame" name="main-frame" frameborder="no" scrolling="yes">
  </frameset>
</frameset>
<noframes></noframes>
</head>
<body>
</body>
</html>
