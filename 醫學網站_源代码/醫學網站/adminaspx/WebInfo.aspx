<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebInfo.aspx.cs" Inherits="Web.Admin.WebInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>網站信息</title>
    <link href="styles/blue_2010.css" rel="stylesheet" type="text/css" />
    <link href="styles/main.css" rel="stylesheet" type="text/css" />
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
		if(hour < 6){str="早安!"}
		else if (hour < 9){str="早安!"}
		else if (hour < 12){str="早安!"}
		else if (hour < 14){str="午安!"}
		else if (hour < 17){str="午安!"}
		else if (hour < 19){str="晚安!"}
		else if (hour < 22){str="晚安!"}
		else {str="晚安!"} 
		if(hour<10)hour="0"+hour;
		if(minu<10)minu="0"+minu;
		if(sec<10)sec="0"+sec;
		document.getElementById("date").innerHTML=str;
		var timer = setTimeout("clockon()",200);
	}
	</script>
	
</head>
<body onload="clockon()">
    <form id="form1" runat="server">
	<%=this.LoadContent() %>
    </form>
</body>
</html>
