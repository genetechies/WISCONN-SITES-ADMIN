<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="center01" %>

<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<link rel="icon" href="../images/HG.png" type="image/ico" />
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠翻譯公司 - 線上詢價以獲得價格和優惠的價錢</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠翻譯公司的客服專員，親切且具高度的專業性，並可針對客戶的需求及用途，量身制定客制化的翻譯流程，而報價流程以獲得價格和優惠的價錢。如果您需要高品質、迅速的翻譯服務，請聯絡我們！"/>
<meta name="keywords" content="翻譯公司 價錢,翻譯公司 價格" /> 
<meta name="copyright" content="后冠翻譯公司"/>
<meta name="author" content="后冠翻譯公司"/>
<meta name="classification" content="翻譯公司"/>
<meta name="robots" content="index,all"/>
<meta name="rating" content="general"/>
<meta name="webcrawlers" content="ALL"/> 
<meta name="spiders" content="ALL" />
<meta name="revisit-after" content="2 day"/>

<link href="../css/index.css" rel="stylesheet" type="text/css" />
   <link rel="stylesheet" type="text/css" href="../css/PubStyle.css" />
    <link type="text/css"  rel="stylesheet" href="../css/ui.all.css"/>
   <script type="text/javascript" language="javascript" src="../js/jquery-1.3.2.min.js"></script>

    <script type="text/javascript" language="javascript" src="../js/ui.core.js"></script>

    <script type="text/javascript" language="javascript" src="../js/ui.datepicker.js"></script>
    <script type="text/javascript" language="javascript"> 
           $(function() { 
    $("#posttime").datepicker({changeMonth: true, changeYear: true, dateFormat: 'yy-mm-dd', showOtherMonths: true, 
    onSelect: function(date) { 
    var d = new Date() 
                                             var vYear = d.getFullYear() ;
                                             var vMon = d.getMonth() + 1 ;
                                             var vDay = d.getDate() ;
                                             var sDate=vYear+"-"+(vMon > 10 ? "0" +vMon: vMon )+"-"+(vDay > 10 ? vDay:"0"+ vDay ); 
                                             var iDay = DateDiff(date.toString(),sDate)+1; 
                                             
    $("#updays").attr("value",iDay); } }); 
    }); 

    function DateDiff(sDate1, sDate2){ //sDate1和sDate2是2002-12-18格式 
            var aDate, oDate1, oDate2, iDays; 
            aDate = sDate1.split("-"); 
            oDate1 = new Date(aDate[1] + '-' + aDate[2] + '-' + aDate[0]); 
            aDate = sDate2.split("-"); 
            oDate2 = new Date(aDate[1] + '-' + aDate[2] + '-' + aDate[0]); 
            iDays = parseInt((oDate1 - oDate2) / 1000 / 60 / 60 /24); 
            return iDays; 
            } 

            function verifyInput(form){ 
              if(form.username.value.length==0){ 
                 alert("Please key in your UserName!"); 
    form.username.focus(); 
    form.username.select(); 
    return false; 
              } 
              else if(form.tel.value.length==0){ 
                 alert("Please key in your Telephone!"); 
    form.tel.focus(); 
    form.tel.select(); 
    return false; 
              } 
              else if(form.email.value.length==0){ 
                 alert("Please key in your email!"); 
    form.email.focus(); 
    form.email.select(); 
    return false; 
              } 
              return true; 
            } 
             
           var ImgArr1 = new Array(); 
    var ImgArr2 = new Array(); 
           ImgArr1[0]="images/left_centerbu011.gif"; 
           ImgArr1[1]="images/left_centerbu021.gif"; 

    ImgArr2[0]="images/left_centerbu012.gif"; 
           ImgArr2[1]="images/left_centerbu022.gif"; 

             function overChangeImg(o,vInt){ 
                o.src=ImgArr2[vInt]; 
             } 
             function outChangeImg(o,vInt){ 
                o.src=ImgArr1[vInt]; 
             } 
            
    </script>
       <style type="text/css"> 

    a:link { 
    color: #162A48; 
    } 
    a:visited { 
    color: #162A48; 
    } 
    a:hover { 
    color: #162A48; 
    } 
    a:active { 
    color: #162A48; 
    } 

           .style1
           {
               width: 6px;
           }
           .style2
           {
               height: 20px;
               width: 6px;
           }

           #translationamount
           {
               width: 58px;
           }

       </style>
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

</head>
<body>
<uc1:top ID="top1" runat="server" />

<!--廣告位--><div class="ban"> 
        
        <img src="../images/ban3.jpg" width="955" height="244" alt="翻譯公司 價錢"/></div>

<!--主要内容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="翻譯公司 價格"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2 style="background:url(../images/hg_3_1.gif) left top no-repeat;">服務項目</h2>
    <h2 style="background:url(../images/hg_19_li2.gif) left top no-repeat; height:6px;">&nbsp;</h2>
    <ul>
      <li></li>
     
    </ul> <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat; ">&nbsp;</h2>
  </div>
  <div class="main_right">
    <div class="main_right_body"> 
     <div id="top-title" class="font26px">線上詢價</div>
    <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0" width="680">
        <tr>
                <td colspan="1" style="width: 32px; height: 20px" valign="top">
                </td>
                <td colspan="5" valign="top" width="730" style="height: 20px">
                    &nbsp;<span class="font04" style="display: inline">此系統可以讓您的文件傳至我們的客服人員手中，請填好下列資料，並夾帶檔案，后冠收到後會迅速為您服務以獲得價格和優惠的價錢！<br />
                    </span></td>
            </tr>
            <tr>
                <td colspan="1" style="width: 32px; height: 20px" valign="top">
                </td>
                <td colspan="5" valign="top" width="730" style="height: 20px">
                    <img height="12" src="../images/da01.gif" width="12"  alt="翻譯公司 價錢"/>
                    <span class="font04" style="display: inline">基本資料</span></td>
            </tr>
            <tr>
                <td height="20" style="width: 32px" valign="top">
                </td>
                <td height="20" valign="top" style="width: 213px">
                    <span class="font03" style="display: inline">聯絡人</span></td>
                <td class="font03" colspan="4" width="565">
                    <span class="font02">
                        <input id="username" runat="server" size="30" type="text" /> *</span></td>
            </tr>
            <tr>
                <td height="20" style="width: 32px" valign="top">
                </td>
                <td height="20" valign="top" style="width: 213px">
                    <span class="font03" style="display: inline">聯絡電話</span></td>
                <td class="font03" colspan="4" width="565">
                    <span class="font02">
                        <input id="tel" runat="server" size="30" type="text" />
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px; height: 22px;" valign="top">
                </td>
                <td valign="top" style="width: 213px; height: 22px;">
                    <span class="font03" style="display: inline">聯絡郵件</span></td>
                <td class="font03" colspan="4" width="565" style="height: 22px">
                    <span class="font02">
                        <input id="email" runat="server" size="30" type="text" /> *</span></td>
            </tr>
            <tr>
                <td colspan="1" style="width: 32px; height: 20px;" valign="top">
                </td>
                <td colspan="5" valign="top" width="730" style="height: 20px">
                    <br />
                    <img height="12" src="../images/da01.gif" width="12" alt="翻譯公司 價格"/>
                    <span class="font04" style="display: inline">以下請盡量提供以利給予您準確的報價：</span></td>
            </tr>
            <tr>
                <td height="20" style="width: 32px" valign="top">
                </td>
                <td height="20" valign="top" style="width: 213px">
                    <span class="font03" style="display: inline">服務項目</span></td>
                <td class="font03" colspan="4" width="565">
                    <span class="font02">
                        <asp:DropDownList ID="ddltranslationskill" runat="server" Width="180px">
                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                            <asp:ListItem Value="2">文件翻譯</asp:ListItem>
                            <asp:ListItem Value="3">論文翻譯</asp:ListItem>
                            <asp:ListItem Value="4">公證文書</asp:ListItem>
                            <asp:ListItem Value="5">網頁翻譯</asp:ListItem>
                            <asp:ListItem Value="6">軟體翻譯</asp:ListItem>
                            
                        </asp:DropDownList>
                    </span>
                </td>
            </tr>
            <tr>
                <td height="20" style="width: 32px">
                </td>
                <td height="20" style="width: 213px">
                    <span class="font03">原始語種(從)</span></td>
                <td height="20" style="width: 164px">
                    <span class="font02">
                        <asp:DropDownList ID="ddllanguagefrom" runat="server" Width="93px">
                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                            <asp:ListItem>英文</asp:ListItem>
                            <asp:ListItem>日文</asp:ListItem>
                            <asp:ListItem>繁中</asp:ListItem>
                            <asp:ListItem>簡中</asp:ListItem>
                            <asp:ListItem>韓文</asp:ListItem>
                            <asp:ListItem>菲文</asp:ListItem>
                            <asp:ListItem>德文</asp:ListItem>
                            <asp:ListItem>西文</asp:ListItem>
                            <asp:ListItem>法文</asp:ListItem>
                            <asp:ListItem>俄文</asp:ListItem>
                            <asp:ListItem>義文</asp:ListItem>
                            <asp:ListItem>葡文</asp:ListItem>
                            <asp:ListItem>荷文</asp:ListItem>
                            <asp:ListItem>波蘭</asp:ListItem>
                            <asp:ListItem>阿拉文</asp:ListItem>
                            <asp:ListItem>越文</asp:ListItem>
                            <asp:ListItem>泰文</asp:ListItem>
                            <asp:ListItem>馬來文</asp:ListItem>
                            <asp:ListItem>印尼文</asp:ListItem>
                            <asp:ListItem>其它</asp:ListItem>
                        </asp:DropDownList>
                    </span>
                </td>
                <td height="20" class="style1">
                </td>
                <td height="20" style="width: 120px">
                    <span class="font03">目地語言(翻譯成)</span></td>
                <td height="20">
                    &nbsp;<span class="font02"><asp:DropDownList ID="ddllanguageto" runat="server" Width="95px">
                        <asp:ListItem Value="0">請選擇</asp:ListItem>
                        <asp:ListItem>英文</asp:ListItem>
                        <asp:ListItem>日文</asp:ListItem>
                        <asp:ListItem>繁中</asp:ListItem>
                        <asp:ListItem>簡中</asp:ListItem>
                        <asp:ListItem>韓文</asp:ListItem>
                        <asp:ListItem>菲文</asp:ListItem>
                        <asp:ListItem>德文</asp:ListItem>
                        <asp:ListItem>西文</asp:ListItem>
                        <asp:ListItem>法文</asp:ListItem>
                        <asp:ListItem>俄文</asp:ListItem>
                        <asp:ListItem>義文</asp:ListItem>
                        <asp:ListItem>葡文</asp:ListItem>
                        <asp:ListItem>荷文</asp:ListItem>
                        <asp:ListItem>波蘭</asp:ListItem>
                        <asp:ListItem>阿拉文</asp:ListItem>
                        <asp:ListItem>越文</asp:ListItem>
                        <asp:ListItem>泰文</asp:ListItem>
                        <asp:ListItem>馬來文</asp:ListItem>
                        <asp:ListItem>印尼文</asp:ListItem>
                        <asp:ListItem>其它</asp:ListItem>
                    </asp:DropDownList>
                    </span>
                </td>
            </tr>
            <tr>
                <td height="20" style="width: 32px">
                </td>
                <td height="20" style="width: 120px">
                    <span class="font03">估計頁數或字數</span></td>
                <td height="20" style="width: 170px">
                    <span class="font02">
                        <input id="translationamount" runat="server" size="12" type="text" />
        
                        <asp:DropDownList ID="ddltranslationtype" runat="server" Width="40px">
                            <asp:ListItem Value="字">字</asp:ListItem>
                            <asp:ListItem Value="頁">頁</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;*</span></td>
                <td height="20" class="style1">
                </td>
                <td height="20" style="width: 109px">
                    <span class="font03">是否需要排版</span></td>
                <td height="20">
                    &nbsp;<span class="font02"><asp:RadioButton ID="rty" runat="server" Checked="true"
                        GroupName="rtypesetting" Text="是" /><asp:RadioButton ID="rtn" runat="server" GroupName="rtypesetting"
                            Text="否" />
                    </span>
                </td>
            </tr>
            <tr>
                <td height="20" style="width: 32px">
                </td>
                <td height="20" style="width: 213px">
                    <span class="font03">是否需要二次校稿</span></td>
                <td height="20" style="width: 164px">
                    <span class="font02">
                        <asp:RadioButton ID="rpy" runat="server" Checked="true" GroupName="rproofreading"
                            Text="是" /><asp:RadioButton ID="rpn" runat="server" GroupName="rproofreading" Text="否" />
                    </span>
                </td>
                <td height="20" class="style1">
                </td>
                <td height="20" style="width: 109px">
                    <span class="font03">是否需要潤稿</span></td>
                <td height="20">
                    &nbsp;<span class="font02"><asp:RadioButton ID="rdy" runat="server" Checked="true"
                        GroupName="rdraft" Text="是" /><asp:RadioButton ID="rdn" runat="server" GroupName="rdraft"
                            Text="否" />
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px; height: 20px;">
                </td>
                <td style="width: 213px; height: 20px;">
                    <span class="font03">交件時間</span></td>
                <td style="width: 164px; height: 20px;">
                    <span class="font02">
                        <input id="posttime" runat="server" size="10" type="text" />
         *</span></td>
                <td class="style2">
                </td>
                <td style="width: 109px; height: 20px;">
                    <span class="font03">工作日</span></td>
                <td style="height: 20px">
                    &nbsp;<span class="font02"><input id="updays" runat="server" size="10" type="text" />
                    </span>
                </td>
            </tr>
            <tr>
                <td style="width: 32px">
                </td>
                <td style="width: 213px">
                    <span class="font03" style="display: inline">專案注意事項</span></td>
                <td class="font03" colspan="4" width="565">
                    <span class="font02">
                        <asp:TextBox ID="ttbNotes" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="483px"></asp:TextBox>
                    </span>
                </td>
            </tr>
            <tr>
                <td colspan="1" height="20" style="width: 32px" valign="top">
                </td>
                <td colspan="5" height="20" valign="top" width="730">
                    <br />
                    <img height="12" src="../images/da01.gif" width="12" alt="翻譯公司 價錢"/>
                    <span class="font04" style="display: inline">上傳相關文件資料：</span> <span class="font03"
                        style="display: inline">上傳檔案（限制檔案大小10 MB；格式：Office文件、圖片檔、pdf、rar、zip)</span></td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 32px; height: 22px">
                </td>
                <td colspan="5" style="height: 22px">
                    <span class="font02">
                        <asp:FileUpload ID="file1" runat="server" Width="606px" />
                    </span>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 32px; height: 24px">
                </td>
                <td align="center" colspan="5" style="height: 24px">
                    <span class="font02">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" OnClientClick="return verifyInput(this.form)"
                            Text="確定送出" />
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="重新填寫" />
                    </span>
                </td>
            </tr>
        </table>
    </form>
<br /><br /><br />
    </div>
  </div>
</div>
<div style="clear:both">&nbsp;</div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="翻譯公司 價格"/></div>
    <uc2:foot ID="foot1" runat="server" />


</body>
</html>

