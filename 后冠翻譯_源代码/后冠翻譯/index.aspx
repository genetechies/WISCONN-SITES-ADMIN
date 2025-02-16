<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<%@ Register src="top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>后冠翻譯公司-受到客戶推薦專業翻譯公司</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="description" content="位於台北的后冠翻譯公司擁有高素質的翻譯專員，翻譯專員由世界各地國家級、外籍專家、留學歸國人員以及各大研究所碩士及博士組成，能提供中文、英語、日語、韓語、德語、俄語、西班牙語等30多種的語言互譯，多元化的服務內容包含：英語翻譯、日語翻譯、韓語翻譯、論文翻譯等相關翻譯技術，受到客戶一致的推薦。"/>
    <meta name="keywords" content="翻譯公司,翻譯公司 推薦" /> 
    <meta name="copyright" content="翻譯公司"/>
    <meta name="author" content="翻譯公司"/>
    <meta name="classification" content="翻譯公司"/>
    <meta name="robots" content="index,all"/>
    <meta name="rating" content="general"/>
    <meta name="webcrawlers" content="ALL"/> 
    <meta name="spiders" content="ALL" />
    <meta name="revisit-after" content="2 day"/>
        <link href="css/index.css" rel="stylesheet" type="text/css" />
    <!--文字切換為英文腳本-->
    <script type="text/javascript" language="javascript">
    function changeMove(objid,value)
    { 
    objid.innerHTML=value;


    }
    function changeLeve(objid,value)
    { 
    objid.innerHTML=value;
    }
    </script>
<script type="text/javascript">
function strPrevious(str){
	var str = str.split("|")
	return str[0];
	}
function strAfterward(str){
	var str = str.split("|")
	return str[1];
	}
</script>
<script type="text/javascript">
function strPrevious1(obj,str){
	var str = str.split("|")
	obj.innerHTML = str[0];
	}
function strAfterward1(obj,str){
	var str = str.split("|")
	obj.innerHTML = str[1];
	}
</script>
<script type="text/javascript">
    function IsPC() {
        var ie6 = ! -[1, ] && !window.XMLHttpRequest;

        if (/AppleWebKit.*mobile/i.test(navigator.userAgent) || (/MIDP|SymbianOS|NOKIA|SAMSUNG|LG|NEC|TCL|Alcatel|BIRD|DBTEL|Dopod|PHILIPS|HAIER|LENOVO|MOT-|Nokia|SonyEricsson|SIE-|Amoi|ZTE/.test(navigator.userAgent))) {
            if (window.location.href.indexOf("?mobile") < 0) {
                try {
                    if (/Android|webOS|iPhone|iPod|BlackBerry/i.test(navigator.userAgent)) {
                        //window.location.href="手机页面";
                        this.window.location = '/APP/Home.aspx';
                    } else if (/iPad/i.test(navigator.userAgent)) {
                        //window.location.href="平板页面";
                        this.window.location = '/APP/Home.aspx';
                    }
                    else {
                        //window.location.href="其他移动端页面"
                        this.window.location = '/APP/Home.aspx';
                            
                    }
                } catch (e) { }
            }
        }

    }
</script>

<script type="text/javascript">
//<![CDATA[
function suolve(str){   
    var sub_length = 16 ;   
    var temp1 = str.replace(/[^\x00-\xff]/g,"**");
    var temp2 = temp1.substring(0,sub_length);   
    var x_length = temp2.split("\*").length - 1 ;   
    var hanzi_num = x_length /2 ;   
    sub_length = sub_length - hanzi_num ; 
    var res = str.substring(0,sub_length);   
    if(sub_length < str.length ){   
        var end  =res+"..." ;   
    }else{    
        var end  = res ;   
    }   
    return end ;   
    //]]>
}  
</script>        
</head>
<body onload="IsPC()">
    <form id="form1" runat="server">
    <uc1:top ID="top1" runat="server" />
    <!--廣告位-->
<div class="ban2">
    <img src="images/ban1.jpg" width="955" height="244" alt="翻譯公司 - 后冠對於翻譯的執著"/></div>
<!--主要内容-->
<div class="main2">
<div><img src="images/page-top.gif" alt="翻譯公司 推薦"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
<div class="content-border">
 <div class="about">
   <div class="about_tp"><a href="about/index.aspx">關於后冠</a></div>
   <div class="about_con">
     <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       后冠統一編號：25125082<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 翻譯專業領域：30個以上<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 翻譯專業語言：40國以上<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 國內外專職翻譯師人數：30位以上 
      <br />
      <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 國內長期合作公司數 
       ：100家以上<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 國外長期合作公司數 
       ：150家以上<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 長期合作翻譯師數 
       ：150位以上<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 長期合作母語翻譯師數 
       ：200位以上<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 辦公據點 
       ：台北、香港、廣州、加拿大、澳洲

   </div>
 </div>
 <div class="about service">
   <div class="about_tp service_tp"><a href="services/index.aspx">服務項目</a></div>
   <div class="about_con">
       服務項目：<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 筆譯&nbsp;&nbsp;&nbsp;&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 翻譯校對&nbsp;&nbsp;  
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 專名校對&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 技術文件翻譯<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 潤稿&nbsp;&nbsp;&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 母語潤稿&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 網站翻譯&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 書籍影帶翻譯
        
       <br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 口譯&nbsp;&nbsp;&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 隨行口譯&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 逐步口譯&nbsp;&nbsp; 
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 同步口譯<br />
       <br />
       主要翻譯語言：<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 英文翻譯&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" />日文翻譯&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 韓文翻譯&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 德文翻譯<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 法文翻譯&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 西文翻譯
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 法文翻譯&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 俄文翻譯<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 越文翻譯&nbsp;
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 泰文翻譯


 </div>
 </div> 
 
 <div class="contact">

  <!--   <div class="address">
       <div class="tel">電話：+886-2-2568-3677<br />傳真：+886-2-2568-3702 
       <br />
            </div>-->
                      
 
  
  
   <div class="address">
       <div class='tel'>電話：+886-2-2568-3677<br />
       <br />
            </div>
         <div class='tel5'>傳真：+886-2-2568-3702 
       <br />
            </div>
         <div class='tel2'> 公司地址：新生北路二段129-2號7F<br />
        </div>
      <div class='tel3'>  公司網站：<a href="https://www.houguan-translation-services.com/"><span style="color:#800080; text-decoration:underline;font-size:11px">
          https://www.houguan-translation-services.com</span></a><br />
        </div>
       <div class='tel4'> 
          
           E-mail：<a href="mailto:service@crowns.com.tw">service@crowns.com.tw</a><br />
       </div>
        <div class='tel6'> 服務時間：週一至週五<br /> AM 9:00- PM 6:00<br /><br />
        </div>
            </div>
 </div>
 <div class="about online">
   <div class="about_tp online_tp"><a href="payment/index.aspx">付款方式</a></div>
   <div class="about_con">
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖"  /> 
       小量的翻譯案件須在翻譯前全額收款。<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       超過3萬元以上的翻譯案件分前後兩次收款。<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       支援Paypal付款、ATM轉帳、銀行匯款、現金付款<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       匯款後請立即以電話通知或Email通知，並傳真收據 ，以確保時效。<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       確認款項後，后冠翻譯公司立即為您進行翻譯作業。</div>
 </div>
 
 <div class="about payments">
   <div class="about_tp payments_tp"><a href="online/index.aspx">線上詢價
       </a></div>
   <div class="about_con">
       主要翻譯產業：<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 商業翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       金融翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       合約翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       法律翻譯&nbsp;&nbsp;&nbsp;<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 工程翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       科技翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       人文翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       醫學翻譯&nbsp;&nbsp;&nbsp;<br />
       <img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 理工翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       遊戲翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 
       專利翻譯&nbsp;&nbsp;&nbsp;<img alt="翻譯公司 - 小標圖" src="images/da03.gif" title="翻譯公司 - 翻譯公司小標圖" /> 技術文件&nbsp;&nbsp;
       <br />
       <br />
       <p style="width:280px">此線詢價為免費服務，若有翻譯需求，后冠隨時為您提供最優質的服務！</p></div>
 </div>
<div style="clear:both;"></div>

<div class="result" style="margin-left:5px;">
<table cellpadding="0" cellspacing="0" border="0" width="940">
<tr>
<td>
<div class="service128">
<a href="/translationteam/index.aspx">翻譯團隊</a>
</div>
<img style="position:relative;left:4px; margin-bottom:8px;" src="images/line.jpg" alt="翻譯公司 推薦" />
 <div id="demod" class="Mar">
        <div id="indemod" class="inMar">
        <div id="demod1" style="float:left;">  
          
        <table cellpadding="0" cellspacing="0" border="0">
         <tr>
        
    <asp:Repeater ID="rpt_list" runat="server">
    <ItemTemplate>
     <td><a href="/translationteam/index.aspx"><img border="0" src="<%#Eval("imgpath").ToString().Trim().Equals("") ? "" : Eval("imgpath")%>" width="79" alt="翻譯公司 推薦" /></a></td>   
    </ItemTemplate>
    </asp:Repeater>
    </tr>
    <tr>
     <asp:Repeater ID="Repeater1" runat="server">
    <ItemTemplate>
     <td valign="top" align="center"><a href="/translationteam/index.aspx"><%#Eval("tname").ToString().Trim().Equals("") ? "" : Eval("tname")%></a></td>   
    </ItemTemplate>
    </asp:Repeater>
    </tr>
    </table>
    
    
        </div>
        <div id="demod2" style="float:left;"> </div>
        </div>
        </div> 
        <script language="javascript" type="text/javascript">
        //<![CDATA[
        var speedd=40;
			var tabd=document.getElementById("demod");
			var tabd1=document.getElementById("demod1");
			var tabd2=document.getElementById("demod2");
			tabd2.innerHTML=tabd1.innerHTML;
			function Marqueedd(){
			if(tabd2.offsetWidth-tabd.scrollLeft<=0)
			tabd.scrollLeft-=tabd1.offsetWidth;
			else{
			tabd.scrollLeft++;
			}
			}
			var MyMardd=setInterval(Marqueedd,speedd);
			tabd.onmouseover=function() {clearInterval(MyMardd)};
			tabd.onmouseout=function() {MyMardd=setInterval(Marqueedd,speedd)};
     //]]>
        </script>
</td>
<td>
<div class="service129">
<a  href="/actual/index.aspx">品牌客戶</a>
</div>

<img style="position:relative;left:4px; margin-bottom:8px;" src="images/line.jpg" alt="翻譯公司 推薦" />
        <div id="qwdemo" class="Mar">
        <div id="qwindemo" class="inMar">
        <div id="qwdemo1" style="float:left;">   
           
        <table cellpadding="0" cellspacing="0" border="0" align="center">
         <tr>
     
    <asp:Repeater ID="Repeater2" runat="server">
    <ItemTemplate>
     <td valign='bottom' align="center" height="70"><a href="/actual/index.aspx"> <img border="0" src="<%#Eval("pic").ToString().Trim().Equals("") ? "" : Eval("pic")%>"  alt="翻譯公司 推薦" /></a></td>   
    </ItemTemplate>
    </asp:Repeater>    
    </tr>
    <tr>
     <asp:Repeater ID="Repeater3" runat="server">
    <ItemTemplate>
     <td align="center" valign="top" height="50"><a href="/actual/index.aspx"> <script type="text/javascript">document.write(suolve('<%#Eval("title").ToString().Trim().Equals("") ? "" : Eval("title")%>'))</script></a></td>   
    </ItemTemplate>
    </asp:Repeater>
   
         
         
         
         </tr>
       </table> 
        
        </div>
        <div id="qwdemo2" style="float:left;"> </div>
        </div>
        </div> 
        <script language="javascript" type="text/javascript">
         //<![CDATA[
		   var speed=40;
			var tab=document.getElementById("qwdemo");
			var tab1=document.getElementById("qwdemo1");
			var tab2=document.getElementById("qwdemo2");
			tab2.innerHTML=tab1.innerHTML;
			function Marqueed(){
			if(tab2.offsetWidth-tab.scrollLeft<=0)
			tab.scrollLeft-=tab1.offsetWidth;
			else{
			tab.scrollLeft++;
			}
			}
			var MyMar=setInterval(Marqueed,speed);
			tab.onmouseover=function() {clearInterval(MyMar)};
			tab.onmouseout=function() {MyMar=setInterval(Marqueed,speed)};
   //]]>
        </script>
</td>
</tr>
</table>
</div>


<div class="index-main">
<div class="index-content">
  <div class="content-bottom" style="margin-left:0px;">
<div class="service123"><a href="actual/index.aspx">客戶實績</a></div>
<img style="position:relative;left:4px; margin-bottom:8px;" src="images/line.jpg" alt="翻譯公司 台北"/>
<ul>
 <%

     System.Data.DataSet ds=new BLL.guoclass().GetAll();
     //  for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
     for (int i = 0; i < 5; i++)
     {
         string[] t = new String[2];
         if (i < ds.Tables[0].Rows.Count)
         {
             if (ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim().Split('|').Length > 1)
             {
                 t = ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim().Split('|');
             }
             else
             {
                 t[0] = ds.Tables[0].Rows[i]["NC_ClassName"].ToString().Trim();
                 t[1] = "";
             }

      %>
      <li><span><a href="/actual/index-<%=ds.Tables[0].Rows[i]["NC_Id"].ToString() %>.aspx" onmousemove="changeMove(this,'<%=t[1] %>')" onmouseout="changeLeve(this,'<%=t[0] %>')" ><%=t[0]%></a></span>
      <%  System.Data.DataSet dslog = new BLL.guopic().GetList("guoclassid=" + ds.Tables[0].Rows[i]["NC_Id"].ToString().Trim());
          for (int j = 0; j < dslog.Tables[0].Rows.Count; j++)
          {

              if (j < 5)
              { %>
    <div class="icon"><a href="/actual/index-<%=ds.Tables[0].Rows[i]["NC_Id"].ToString() %>.aspx" title='<%=dslog.Tables[0].Rows[j]["title"].ToString().Trim() %>'><%=dslog.Tables[0].Rows[j]["title"].ToString().Trim() %></a></div>
    <%
            }
        } %>

      </li>
<%}
    } %>
    </ul>
 <%--
<div style="clear:both"></div>    
<ul>
<%System.Data.DataSet dslyclass = new BLL.linyuclass().GetList_top(5, " 1=1");
  for (int i = 0; i < dslyclass.Tables[0].Rows.Count; i++)
  {
      if (i < 5)
      {
      %>
<li><span><a href="/actual/index.aspx" title='<%=dslyclass.Tables[0].Rows[i]["ClassName"].ToString()%>'><%=dslyclass.Tables[0].Rows[i]["ClassName"].ToString()%></a></span>
<%System.Data.DataSet dslyxx = new BLL.linyuxinxi().GetList_top(5, " linyuclassid=" + dslyclass.Tables[0].Rows[i]["id"].ToString().Trim() + " and C_show=0");
  for (int j = 0; j < dslyxx.Tables[0].Rows.Count; j++)
  {
      if (j < 5)
      { %>
    <div class="icon"><a href="/actual/index.aspx" title='<%=dslyxx.Tables[0].Rows[j]["title"].ToString().Trim()%>'><%=dslyxx.Tables[0].Rows[j]["title"].ToString().Trim()%></a></div>
    <%
}
  } %>

</li>
<%
}
  } %>

</ul>
--%>   
</div>

<div style=" clear:both">&nbsp;</div>
<div class="content-bottom"  style="margin-left:0px;">
<div class="service124"><a href="../translation/Newlist.aspx">翻譯資訊</a></div>
<img style="position:relative;left:4px; margin-bottom:8px;" src="images/line.jpg" alt="翻譯公司 台北"/>
<ul>
<%System.Data.DataSet dsfyzx = new BLL.NewsClass().GetList_top(10, " 1=1 ");
  for (int i = 0; i < dsfyzx.Tables[0].Rows.Count; i++)
  {
      if (i < 10)
      {
     %>

<li><span><a href="translation/newlist-<%=dsfyzx.Tables[0].Rows[i]["classid"].ToString() %>.aspx"  onmousemove="strAfterward1(this,'<%=dsfyzx.Tables[0].Rows[i]["ClassName"].ToString()%>');" onmouseout="strPrevious1(this,'<%=dsfyzx.Tables[0].Rows[i]["ClassName"].ToString()%>');" title='<%=dsfyzx.Tables[0].Rows[i]["ClassName"].ToString()%>'><script type='text/javascript'>document.write(strPrevious('<%=dsfyzx.Tables[0].Rows[i]["ClassName"].ToString()%>'));</script></a></span>
<%System.Data.DataSet dsnews = new BLL.newsdata().GetList_top(5, " D_ClassID=" + dsfyzx.Tables[0].Rows[i]["classid"].ToString() + " and D_Recycle=0 ");
  for (int j = 0; j < dsnews.Tables[0].Rows.Count; j++)
  {
      if (j < 5)
      {
       %>
 
    <div class="icon"><a href="/translation/newsinfo-<%=dsnews.Tables[0].Rows[j]["D_ID"].ToString().Trim()%>.aspx" title='<%=dsnews.Tables[0].Rows[j]["D_Title"].ToString().Trim()%>'><%=Helper.MyTool.CutTitle(dsnews.Tables[0].Rows[j]["D_Title"].ToString().Trim(), 24)%></a></div>
    <%}
  } %>
</li>
<%}
  }%>
</ul>
</div>
    <div style=" clear:both">&nbsp;</div>
    <div style="margin-left:-5px;">
    <!--#include file="newspages/downindex.html"-->
    </div>
</div>

</div>
</div>
</div>

</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 推薦"/></div>
<uc2:foot ID="foot1" runat="server" />
    </form>
</body>
</html>
