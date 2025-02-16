<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="ZeroStudio.Web.Admin.Product.error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title></title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="robots" content="noindex, nofollow" />
<link href="../styles/blue_2010.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="../../js/common.js"></script>
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

<body leftmargin="10" topmargin="10" marginwidth="10" marginheight="10"><div class="list-div">
  <div style="background:#FFF; padding: 20px 50px; margin: 2px;">
    <table width="400">
      <tr>
        <td width="50" valign="top">
                    <img src="../images/warning.gif" width="32" height="32" border="0" alt="warning" />
                  </td>
        <td style="font-size: 14px; font-weight: bold"><%=Request["err"] != null ? Request["err"].ToString() : "抱歉，系統有誤！"%></td>
      </tr>
      <tr>
        <td></td>
        <td id="redirectionMsg">
          如果您不做出選擇,將在<span id="spanSeconds">10</span>秒後跳轉到第一個鏈接地址.       </td>
      </tr>
      <tr>
        <td></td>
        <td>
          <ul style="margin:0; padding:0px" class="msg-link">
                        <li><a href="javascript:history.go(-1)">返回上一頁</a></li>
                      </ul>

        </td>
      </tr>
    </table>
  </div>
</div>
<script type="text/javascript" language="JavaScript">
<!--
var seconds = 10;
var defaultUrl = "<%=Request["url"]!=null?Request["url"].ToString():"javascript:history.go(-1)" %>";

onload = function(){
  if (defaultUrl == 'javascript:history.go(-1)' && window.history.length == 0){
    document.getElementById('redirectionMsg').innerHTML = '';
    return;
  }
  window.setInterval(redirection, 1000);
}

function redirection(){
  if (seconds <= 0){
    window.clearInterval();
    return;
  }
  seconds --;
  document.getElementById('spanSeconds').innerHTML = seconds;
  if (seconds == 0){
    window.clearInterval();
    location.href = defaultUrl;
  }
}
//-->
</script>

<div style="clear:both; margin-bottom:30px;"></div>
</body>
</html>