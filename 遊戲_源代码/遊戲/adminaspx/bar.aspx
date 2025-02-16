<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bar.aspx.cs" Inherits="Web.Admin.bar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css"> 
body {
	margin: 0;
	padding: 0;
	width:8px;
	overflow:hidden;
}
.drag {
	width:8px;
	overflow:hidden;
	height:100%;
	text-align:center;
}
.drag a:link, .drag a:visited {
	display:block;
	padding:200px 0px;
}
</style>
<script type="text/javascript" language="JavaScript"> 
<!--
var pic = new Image();
pic.src="images/blue_2010/arrow_right.gif";
function toggleMenu()
{
  frmBody = parent.document.getElementById('frame-body');
  imgArrow = document.getElementById('img');
 
  if (frmBody.cols == "0, 8, *")
  {
    frmBody.cols="197, 8, *";
    imgArrow.src = "images/blue_2010/arrow_left.gif";
  }
  else
  {
    frmBody.cols="0, 8, *";
    imgArrow.src = "images/blue_2010/arrow_right.gif";
  }
}
 
var orgX = 0;
/*document.onmousedown = function(e)
{
  var evt = Utils.fixEvent(e);
  orgX = evt.clientX;
 
  if (Browser.isIE) document.getElementById('tbl').setCapture();
}*/
 
document.onmouseup = function(e)
{
  var evt = Utils.fixEvent(e);
 
  frmBody = parent.document.getElementById('frame-body');
  frmWidth = frmBody.cols.substr(0, frmBody.cols.indexOf(','));
  /*frmWidth = (parseInt(frmWidth) + (evt.clientX - orgX));*/
 
  frmBody.cols = frmWidth + ", 8, *";
 
  if (Browser.isIE) document.releaseCapture();
}
 
var Browser = new Object();
 
Browser.isMozilla = (typeof document.implementation != 'undefined') && (typeof document.implementation.createDocument != 'undefined') && (typeof HTMLDocument != 'undefined');
Browser.isIE = window.ActiveXObject ? true : false;
Browser.isFirefox = (navigator.userAgent.toLowerCase().indexOf("firefox") != - 1);
Browser.isSafari = (navigator.userAgent.toLowerCase().indexOf("safari") != - 1);
Browser.isOpera = (navigator.userAgent.toLowerCase().indexOf("opera") != - 1);
 
var Utils = new Object();
 
Utils.fixEvent = function(e)
{
  var evt = (typeof e == "undefined") ? window.event : e;
  return evt;
}
//-->
</script>
</head>
 
<body onselect="return false;" style="background:#a6d9ff url(images/blue_2010/left_bg.jpg) right 0px no-repeat;">
<div class="drag"> <a href="javascript:toggleMenu();"><img src="images/blue_2010/arrow_left.gif" id="img" alt="遊戲翻譯" border="0"/></a> </div>
</body>
</html>