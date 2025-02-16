<%@ page language="C#" autoeventwireup="true" CodeFile="Main.aspx.cs" inherits="Web.Admin.Main" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>后冠翻譯社後臺管理系統</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link href="styles/blue_2010.css" rel="stylesheet" type="text/css" />
<script language="javascript" src="js/jquery.min.js" type="text/javascript"></script>
<script language="javascript" src="js/quickView.js" type="text/javascript" ></script>
<script type= "text/javascript"> 
function j(flag) {
$(function(){
 
	//Get our elements for faster access and set overlay width
	var div = $('div.navinner'),
		ul = $('ul.navlist'),
		ulPadding = 15;
 
	//Get menu width
	var divWidth = div.width();
 
	//Remove scrollbars
	 div.css({overflow: 'hidden'});
 
	//Find last image container
	var lastLi = ul.find('li:last-child');
 
 
   var ulWidth = lastLi[0].offsetLeft + lastLi.outerWidth() + ulPadding;
 
 
   if(ulWidth <= 730) div.scrollLeft(0);
   //else if(flag) div.scrollLeft(ulWidth-730);
 
	div.mouseover(function(e){
 
		//As images are loaded ul width increases,
		//so we recalculate it each time
		
 
		var left = (e.pageX - div.offset().left) * (ulWidth-divWidth) / divWidth;
		 e = window.event || e;
		 var  srcElement = e.srcElement || e.target;
 
		tabMove(srcElement.id, left, ulWidth);
	
		
	});
 
	//When user move mouse over menu
	div.mousemove(function(e){
 
		//As images are loaded ul width increases,
		//so we recalculate it each time
		//var ulWidth = lastLi[0].offsetLeft + lastLi.outerWidth() + ulPadding;
		var left = (e.pageX - div.offset().left) * (ulWidth-divWidth) / divWidth;
 
 
		 e = window.event || e;
		 var  srcElement = e.srcElement || e.target;
		 tabMove(srcElement.id, left, ulWidth);
		 div.scrollLeft(left);
		
	});
 
});
}
j();
 
 
function k() {
	$('div.navinner').unbind('mouseover');
	$('div.navinner').unbind('mousemove');
	$('ul.navlist').remove();
 
 
}
</script>
<script type="text/javascript"> 
function tabMove(eleId, left, ulWidth) {
 
   eleId1 = eleId.replace(/_/g, '');
 
	if(parseInt(eleId1) > 0) {
 
 var obj = document.getElementById('nav_'+eleId);
 var x = getX(obj);
 if(ulWidth <= 730) {
	document.getElementById('ddsubmenu'+eleId).style.left = x + 4 + 'px';
	 return;
 }
 
// document.getElementById('a').value=document.getElementById('ddsubmenu'+eleId).id;
  
 document.getElementById('ddsubmenu'+eleId).style.left=x - left + 4 + 'px';
 
	}
 
}
 
 
 
function setHeight(obj) {
 
var innerHeight = document.documentElement.clientHeight||document.body.clientHeight;
obj.height = innerHeight-127;
}
 
 function getX(elem){
    var x = 0;
    while(elem){
        x = x + elem.offsetLeft;
        elem = elem.offsetParent;
    }
    return x;
}
function getY(elem){
    var y = 0;
    while(elem){
        y = y + elem.offsetTop;
        elem = elem.offsetParent;
    }
    return y;
}
 
function showMenu (baseID, divID) {
    baseID = document.getElementById(baseID);
    divID  = document.getElementById(divID);
    if (showMenu.timer) clearTimeout(showMenu.timer);
	hideCur();
    divID.style.display = 'block';
	showMenu.cur = divID;

    if (! divID.isCreate) {
        divID.isCreate = true;
        //divID.timer = 0;
        divID.onmouseover = function () {
            if (showMenu.timer) clearTimeout(showMenu.timer);
			hideCur();
            divID.style.display = 'block';
        };
       function hide () {
           divID.style.display = 'none';;
        }
        divID.onmouseout = hide;
    }

	function hideCur () {
		showMenu.cur && (showMenu.cur.style.display = 'none');
	}
}
	function calcTime(offset) {
		d = new Date();
		utc = d.getTime() + (d.getTimezoneOffset() * 60000);
		nd = new Date(utc + (3600000*offset));
		return nd;
	}
</script>
<script type="text/javascript">
	$(document).ready(function(){
		$(".btn-slide").click(function(){
			$("#panel").slideToggle("slow");
			$(this).toggleClass("active"); return false;
		});
	});
	</script>
	<script language="JavaScript" type="text/javascript">
	function calcTime(offset) {
		d = new Date();
		utc = d.getTime() + (d.getTimezoneOffset() * 60000);
		nd = new Date(utc + (3600000*offset));
		return nd;
	}
	function clockon(){
		var now = calcTime(+8);
		var hour = now.getHours();
		var minu = now.getMinutes();
		var sec = now.getSeconds();
		var str="";
		if(hour < 6){str="凌晨好!"}
		else if (hour < 9){str="早上好!"}
		else if (hour < 12){str="上午好!"}
		else if (hour < 14){str="中午好!"}
		else if (hour < 17){str="下午好!"}
		else if (hour < 19){str="傍晚好!"}
		else if (hour < 22){str="晚上好!"}
		else {str="夜里好!"} 
		if(hour<10)hour="0"+hour;
		if(minu<10)minu="0"+minu;
		if(sec<10)sec="0"+sec;
		document.getElementById("date_time").innerHTML=str;
		var timer = setTimeout("clockon()",200);
	}
	</script>
<link rel="stylesheet" type="text/css" href="styles/blue_2010_ddlevelsmenu-base.css" />
</head>
<body style="background:url(images/blue_2010/head_bg.jpg) 0px -144px repeat-x;overflow:hidden;" oncontextmenu="return false" ondragstart="return false" onselectstart ="return false" onselect="document.selection.empty()" oncopy="document.selection.empty()" onbeforecopy="return false" onmouseup="document.selection.empty()">
<form id="form1" runat="server">
<div class="Head">
<div style="width:1003px;height:86px;overflow:hidden;">
<div class="TopList"><ul>
<li><a href="../Index.aspx" target="_blank" class="topbar1" title="打開網站前臺首頁">回到前臺</a></li>
<li><asp:LinkButton ID="btnLogOut" runat="server" CssClass="topbar4" ToolTip="退出管理後臺" OnClick="Quit_Click">登出</asp:LinkButton></li>
</ul>
</div>
<div class="Clear"></div><div class="Version"><div class="Namber"></div>
<div class="Publish"></div>
</div></div>
<div class="Menu"><div class="StageDate"></div>
<div class="stagelevel" id="menu999" onclick="level_clickmenu('menu999');"><a href="Manager/Manage.aspx" target="main-frame" title="後臺管理員"></a></div>
<div class="stagefresh"><a href="javascript:reloadMain();" title="刷新"></a></div>
<div class="stageindex" id="menu0" onclick="home_clickmenu('menu0');"><a href="WebInfo.aspx" target="main-frame" title="後臺首頁"></a></div>
<div class="ScrollMenu"><div class="nav"><div class="navinner" id="ddtopmenubar">
<ul class="navlist">
    <li><a href="websys/webset.aspx" target="main-frame"><span>基本訊息</span></a></li>
    <li><a href="news/NewsManage.aspx" target="main-frame"><span>翻譯資訊管理</span></a></li>
    <%--<li><a href="transzone/Manage.aspx" target="main-frame"><span>翻譯領域管理</span></a></li>--%>
    <li><a href="news_class/Manage.aspx" target="main-frame"><span>客戶實績</span></a></li>
    <li><a href="Manager/Manage.aspx" target="main-frame"><span>用戶管理</span></a></li>
    <li><a href="GuestBook/Manage.aspx" target="main-frame"><span>線上咨詢</span></a></li>
    <li><a href="yingpingjl/Manage.aspx" target="main-frame"><span>人才招募</span></a></li>
    <li><a href="Friendly/Manage.aspx" target="main-frame"><span>友好連結及合作夥伴</span></a></li>
</ul></div>
</div></div>
<div id="ddsubmenuall">
</div>
<div class="stagesk">
</div></div></div>
<iframe src="masterpage.aspx" frameborder="0" name="Iframe1" id="Iframe1" scrolling="no" width="100%"  height='433' onload='setHeight(this)'></iframe>
<script type="text/javascript">
function reloadMain()
{
    window.frames['Iframe1'].frames['main-frame'].location.reload();
}
</script>
</form>
</body>
</html>