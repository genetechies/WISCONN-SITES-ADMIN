<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="recruitment_index" %>
<%@ Register src="../top.ascx" tagname="top" tagprefix="uc1" %>
<%@ Register src="../foot.ascx" tagname="foot" tagprefix="uc2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="description" content="后冠翻譯社的客服專員，親切且具高度的專業性，並可針對客戶的需求及用途，量身制定客制化的翻譯流程。如果您需要高品質、迅速的翻譯服務，請聯絡我們！"/>
<meta name="keywords" content="后冠翻譯社,翻譯社,翻譯公司,英文翻譯,日文翻譯,韓文翻譯,論文翻譯社" /> 
<meta name="copyright" content="后冠翻譯社"/>
<meta name="author" content="后冠翻譯社"/>
<meta name="classification" content="翻譯社"/>
<meta name="robots" content="index,all"/>
<meta name="rating" content="general"/>
<meta name="webcrawlers" content="ALL"/> 
<meta name="spiders" content="ALL" />
<meta name="revisit-after" content="2 day"/>

<title>后冠翻譯社- 人才招募</title>
<link href="../css/index.css" rel="stylesheet" type="text/css" />
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
<script type="text/javascript" language="javascript">
<!--
function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}
function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
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
//-->
</script>


    <link rel="stylesheet" type="text/css" href="../css/PubStyle.css" /> 
 <script type="text/javascript">
   
        function verifyInput(form){        
          if(form.username.value.length==0){
             alert("姓名不可空白!");
	         form.username.focus();
	         form.username.select();
	         return;
          }   
          if(form.topgraduation.value.length==0){
             alert("最高學歷不可為空白!");
	         form.topgraduation.focus();
	         form.topgraduation.select();
	         return;
          }    
          if(form.username.value.length==0){
             alert("主要語言需填寫喔!");
	         form.masterlanguage.focus();
	         form.masterlanguage.select();
	         return;
          }      
          if(form.translationamount.value.length==0){
             alert("翻譯量需填寫喔!");
	         form.translationamount.focus();
	         form.translationamount.select();
	         return;
          }
          if(form.tel.value.length==0){
             alert("電話需填寫喔!");
	         form.tel.focus();
	         form.tel.select();
	         return;
          }
          if(form.email.value.length==0){
             alert("E-mail需填寫喔!");
	         form.email.focus();
	         form.email.select();
	         return;
          }
       
          else {
             form.submit();
          }
        }
 </script>
 
<style type="text/css"> 
<!-- 
a:link { 
color: #003366; 
} 
a:visited { 
color: #003366; 
} 
a:hover { 
color: #003366; 
} 
a:active { 
color: #003366; 
} 
--> 
</style>
</head>
<body>
<uc1:top ID="top1" runat="server" />
    <!--廣告位-->
<div class="ban"> <img src="../images/ban8.jpg" width="955" height="244" alt="翻譯社- 唯一推薦翻譯公司"/></div>
<!--主要内 容-->
<div class="main">
<div><img src="../images/page-top.gif" alt="遊戲翻譯"/></div>
<div class="page-middle">
<div style="width:945px; margin:0 auto">
  <div class="main_left">
    <h2 style="background:url(../images/hg_2_10.gif) left top no-repeat;">服務項目</h2>
    <ul>
      <li></li>
     
    </ul>
    <h2 style="background:url(../images/hg_19_li1.gif) left top no-repeat;">&nbsp;</h2>
  </div>
   <div class="main_right " style="width:715px; padding-left:0px;">
    <div class="main_right_body " style="padding:5px;width:745px;">
    <div id="top-title" class="font26px" style="padding-left:32px; padding-top:8px;">Recruitment</div>
<form action="index.aspx?action=save" method="post" > 

            <table width="740" border="0" cellspacing="0" cellpadding="0"> 
                <tr>
                <td valign="top">　</td> 
                <td >
                  <table width="715" border="0" cellspacing="0" cellpadding="0"> 
                    <tr> 
                      <td align="center" bgcolor="#E1E1E1" class="font01" style="width: 712px">Resume</td> 
                    </tr> 
                  </table> 
                    <table width="715" border="1" cellspacing="0" cellpadding="0">
                    
                      <tr style=" border-style:solid; border-width:1;"> 
                        <td class="font03" style="width: 245px">
                            *Name</td> 
                        <td class="font03" style="width: 90px">
                           <span class="font02"> 
                             <input name="username" type="text"  size ="10" /> 
                          </span>
                        </td> 
                        <td class="font03" style="width: 168px">Age</td> 
                        <td class="font03" style="width: 93px">
                           <span class="font02"> 
                             <input name="age" type="text"  size ="10" /> 
                          </span>
                        </td> 
                        <td class="font03" style="width: 128px">Gender</td> 
                        <td  class="font03" style="width: 251px">
                          <span class="font02" > 
                           <input type="radio" name="rGender"  checked="checked" value="M"  />Male&nbsp;
                              <input type="radio" name="rGender" value="W" />Female
                          </span>
                        </td> 
                        <td class="font03" style="width: 246px">*Highest Education</td> 
                        <td class="font03" colspan="3">
                          <span class="font02"> 
                             <input name="topgraduation" type="text"  size ="10" /></span></td> 
                      </tr> 
                      <tr style=" border-style:solid; border-width:1;"> 
                        <td class="font03" style="width: 245px">
                            *Work Role</td> 
                        <td width="350" colspan="5" class="font03" >
                           <span class="font02" style="display:inline"> 
                             <input name="worktype1" type="checkbox"   size ="10" value="筆譯"/> Written Translation
                          </span>
                           <span class="font02"> 
                             <input name="worktype2" type="checkbox" size ="10" value="口譯"/> Interpretation
                          </span>
                           <span class="font02"> 
                             <input name="worktype3" type="checkbox" size ="10" value="專有名詞"/> Special Word
                          </span>
                           <span class="font02"> 
                             <input name="worktype4" type="checkbox" size ="10" value="潤稿"/> Draft Embellish
                          </span>
                           <span class="font02"> 
                             <input name="worktype5" type="checkbox" size ="10" value="排版"/> Type Set
                          </span>
                        </td> 
                        <td class="font03" style="width: 246px">
                            On Campus</td> 
                          <td class="font03" colspan="3">
                          <span class="font02"> 
                             &nbsp;</span><!--<input type="radio" name="rislearning"  checked="" value="Y"  />-->
                             <input type="radio" name="rislearning"   value="Y"  />
                             <span  style="color: #a40000">Yes&nbsp;                                                 
                                 <input type="radio" name="rislearning" value="N" />No</span>
                           <span class="font02" > &nbsp;</span></td>
                      </tr> 
                      <tr style=" border-style:solid; border-width:1;"> 
                        <td class="font03" style="width: 245px">
                            *Main Language</td> 
                        <td class="font03" style="width: 90px">
                           <span class="font02"> 
                             <select name="masterlanguage">
                                <option selected="selected" value=" ">select</option>
                                <option value="英文">英文</option>
                                <option value="日文">日文</option>
                                <option value="繁中">繁中</option>
                                <option value="簡中">簡中</option>
                                <option value="韓文">韓文</option>
                                <option value="菲文">菲文</option>
                                <option value="德文">德文</option>
                                <option value="西文">西文</option>
                                <option value="法文">法文</option>
                                <option value="俄文">俄文</option>
                                <option value="義文">義文</option>
                                <option value="葡文">葡文</option>
                                <option value="荷文">荷文</option>
                                <option value="波蘭">波蘭</option>
                                <option value="阿拉文">阿拉文</option>
                                <option value="越文">越文</option>
                                <option value="泰文">泰文</option>
                                <option value="馬來文">馬來文</option>
                                <option value="印尼文">印尼文</option>
                                <option value="其它">其它</option>

                             </select>
                          </span>
                        </td> 
                        <td class="font03" style="width: 168px">Translation Experience</td> 
                        <td class="font03" style="width: 93px">
                           <span class="font02"> 
                              <select name="seniority">
                                <option selected="selected" value=" ">select</option>
	                            <option value="1">1</option>
	                            <option value="2">2</option>
	                            <option value="3">3</option>
	                            <option value="4">4</option>
	                            <option value="5">5</option>
	                            <option value="6">6</option>
	                            <option value="7">7</option>
	                            <option value="8">8</option>
	                            <option value="9">9</option>
	                            <option value="10">10</option>
	                            <option value="11">11~20</option>
	                            <option value="21">21以上</option>

                             </select> 
                          </span>
                        </td> 
                        <td class="font03" style="width: 128px">
                            *Translation Volumes</td> 
                        <td  class="font03" style="width: 251px">
                          <span class="font02" > 
                           <input name="translationamount" type="text"  size ="10" />Word/Day
                          </span>
                        </td> 
                        <td width="286" colspan="4" class="font03">　</td> 
                      </tr> 
                      <tr style=" border-style:solid; border-width:1;"> 
                        <td class="font03" style="width: 245px">Second Foreign Language</td> 
                          <td class="font03" colspan="9">
                                              <div class="font02" style="display:inline"> 
                              <table border="0">
                           <tr>
                             <td><input name="Language1" type="checkbox" size ="10" value="English"/> English</td>
                             <td><input name="Language2" type="checkbox" size ="10" value="Japanese"/> Japanese</td>
                               <td><input name="Language5" type="checkbox" size ="10" value="Korean"/> Korean</td>
                              <td><input name="Language10" type="checkbox" size ="10" value="Italian"/> Italian </td>
                              <td><input name="Language3" type="checkbox" size ="10" value="Traditional Chinese"/> Traditional Chinese</td>
                              
                                </tr>
                           <tr>
                            
                              <td><input name="Language6" type="checkbox" size ="10" value="Germany"/> Germany</td>
                          
                          
                              <td><input name="Language7" type="checkbox" size ="10" value="Spanish"/> Spanish</td>
                              <td><input name="Language8" type="checkbox" size ="10" value="French" /> French</td>
                              <td><input name="Language9" type="checkbox" size ="10" value="Russian"/> Russian</td>
                             
                              <td><input name="Language4" type="checkbox" size ="10" value="Simplified Chinese"/> Simplified Chinese</td>
                                </tr>
                              
                              <tr>
                              
                            
                              <td><input name="Language12" type="checkbox" size ="10" value="Dutch"/> Dutch</td>
                         
                        
                              <td><input name="Language13" type="checkbox" size ="10" value="Polish"/> Polish</td>
                              <td><input name="Language14" type="checkbox" size ="10" value="Arabic"/> Arabic</td>
                              <td><input name="Language17" type="checkbox" size ="10" value="Malay"/> Malay</td>
                               <td><input name="Language11" type="checkbox" size ="10" value="Portuguese"/> Portuguese</td>
                                 </tr>
                           <tr>
                             
                              <td><input name="Language16" type="checkbox" size ="10" value="Thai"/> Thai</td>
                             
                              <td><input name="Language18" type="checkbox" size ="10" value="Indonesian"/> Indonesian    </td>      
                              <td><input name="Language15" type="checkbox" size ="10" value="Vietnamese"/> Vietnamese</td>
                          
                              <td><input name="Language19" type="checkbox" size ="10" /> Others</td>
                              </tr>
                              </table>
                          </div>
                          <span class="font02"> &nbsp;</span></td>
                      </tr> 
                      <tr style=" border-style:solid; border-width:1;"> 
                        <td class="font03" style="width: 245px">Translation Expertise</td> 
                        <td width="655" colspan="9" class="font03" >
                           Engineering and Science<br />
                           <div class="font02" style="display:inline"> 
                           <table border="0">
                           <tr>
                             <td><input name="translationskill1" type="checkbox" size ="10" value="Medical"/> Medical</td>
                             <td><input name="translationskill4" type="checkbox" size ="10" value="Pharmacy"/> Pharmacy</td>
                             <td><input name="translationskill3" type="checkbox" size ="10" value="Traditional Chinese Medical"/> Traditional Chinese Medical</td>
                             </tr>  
                             <tr>          
                              <td> <input name="translationskill14" type="checkbox" size ="10" value="Geoscience"/> Geoscience</td>
                             <td><input name="translationskill5" type="checkbox" size ="10" value="Biochemistry"/> Biochemistry</td>
                             <td><input name="translationskill6" type="checkbox" size ="10" value="Physics/Photology"/> Physics/Photology </td>
                             </tr>  
                              <tr>     
                             <td> <input name="translationskill9" type="checkbox" size ="10" value="Mathematics"/> Mathematics  </td>
                             <td><input name="translationskill11" type="checkbox" size ="10" value="Electronics"/> Electronics</td>
                             <td><input name="translationskill8" type="checkbox" size ="10" value="Chemistry/Chemical Industry"/> Chemistry/Chemical Industry</td>
                             
                               </tr> 
                               <tr>    
                               <td> <input name="translationskill16" type="checkbox" size ="10" value="Video Game"/> Video Game   </td>                
                             <td> <input name="translationskill18" type="checkbox" size ="10" value="Information"/> Information </td>
                             <td><input name="translationskill12" type="checkbox" size ="10" value="Telecommunication"/> Telecommunication </td> 
                             </tr> 
                             
                             <tr>   
                              <td> <input name="translationskill19" type="checkbox" size ="10" value="Machinery"/> Machinery      </td> 
                           
                              <td> <input name="translationskill26" type="checkbox" size ="10" value="Decoration"/> Decoration</td>
                            <td> <input name="translationskill15" type="checkbox" size ="10" value="Computer Software"/> Computer Software </td> 
                            </tr> 
                            
                            <tr>   
                            <td><input name="translationskill10" type="checkbox" size ="10" value="Electromechanical"/> Electromechanical</td>
                              <td> <input name="translationskill21" type="checkbox" size ="10" value="Automobile"/> Automobile  </td>
                             <td> <input name="translationskill7" type="checkbox" size ="10" value="Engineering and Science"/> Engineering and Science</td>
                             </tr> 
                             
                             <tr>   
                          <td> <input name="translationskill13" type="checkbox" size ="10" value="Computer Hardware"/> Computer Hardware</td>
                            
                             <td> <input name="translationskill29" type="checkbox" size ="10" value="Petrochemical"/> Petrochemical</td>
                              <td><input name="translationskil17" type="checkbox" size ="10" value="Traffic/Transportation"/> Traffic/Transportation</td>
                          
                            </tr> 
                            <tr>   
                            <td> <input name="translationskill22" type="checkbox" size ="10" value="Metro/Express Rail"/> Metro/Express Rail</td>
                            <td> <input name="translationskill23" type="checkbox" size ="10" value="Urban Planning"/> Urban Planning</td>
                             <td> <input name="translationskill27" type="checkbox" size ="10" value="Environment Protection"/> Environment Protection </td> 
                            
                             </tr> 
                             
                             <tr>   
                            <td> <input name="translationskill25" type="checkbox" size ="10" value="Civil Engineering"/> Civil Engineering</td>
                           <td> <input name="translationskill2" type="checkbox" size ="10" value="Medical Equipment"/> Medical Equipment</td>
                            <td><input name="translationskill24" type="checkbox" size ="10" value="Aerospace Science and Technology"/> Aerospace Science and Technology </td> 
                            </tr> 
                            
                            <tr>   
                            <td> <input name="translationskill28" type="checkbox" size ="10" value="Energy/Power Generation"/> Energy/Power Generation</td>
                           <td> <input name="translationskill20" type="checkbox" size ="10" value="Industrial Security"/> Industrial Security</td>
                             <td><input name="translationskill30" type="checkbox" size ="10" value="Nuclear Power/Atomic Science"/> Nuclear Power/Atomic Science  </td>
                             </tr> 
                             
                             <tr>   
                            <td> <input name="translationskill31" type="checkbox" size ="10" value="Semiconductor/IC"/> Semiconductor/IC</td>
                            <td> <input name="translationskill32" type="checkbox" size ="10" value="Construction"/> Construction</td>
                             <td> </td>
                            </tr> 
                            </table>
                          </div><br />
                          Literature, Legal and Business<br />
                         <div class="font02" style="display:inline"> 
                            <table border="0">
                           <tr>
                           
                             <td><input name="translationskill33" type="checkbox" size ="10" value="Legal"/> Legal</td>
                             <td><input name="translationskill34" type="checkbox" size ="10" value="Insurance"/> Insurance</td>
                             <td><input name="translationskill39" type="checkbox" size ="10" value="Business Administration"/> Business Administration</td>
                             </tr>
                              <tr>
                               <td><input name="translationskill35" type="checkbox" size ="10" value="Financial"/> Financial </td>
                             <td><input name="translationskill36" type="checkbox" size ="10" value="Foreign Exchange"/> Foreign Exchange</td>
                             <td><input name="translationskill37" type="checkbox" size ="10" value="Accountant Tax"/> Accountant Tax</td>
                              </tr>
                            <tr>
                             <td><input name="translationskill38" type="checkbox" size ="10" value="Accountant"/> Accountant  </td>
                             <td><input name="translationskill41" type="checkbox" size ="10" value="Securities"/> Securities </td>
                             <td><input name="translationskill40" type="checkbox" size ="10" value="Business/Trading"/> Business/Trading</td>
                              </tr>
                             <tr>
                             <td><input name="translationskill42" type="checkbox" size ="10" value="Statistics"/> Statistics</td>
                             <td><input name="translationskill43" type="checkbox" size ="10" value="History"/> History</td>
                             <td><input name="translationskill45" type="checkbox" size ="10" value="Humanity Culture"/> Humanity Culture</td>
                              </tr>
                            <tr>
                             <td><input name="translationskill44" type="checkbox" size ="10" value="Astronomy"/> Astronomy  </td>
                              <td><input name="translationskill47" type="checkbox" size ="10" value="Politic"/> Politic </td>
                             <td><input name="translationskill46" type="checkbox" size ="10" value="Human Development Science"/> Human Development Science</td>
                              </tr>
                            <tr>
                             <td><input name="translationskill48" type="checkbox" size ="10" value="Journalism"/> Journalism</td>
                             <td><input name="translationskill49" type="checkbox" size ="10" value="Mass Media"/> Mass Media</td>
                             <td><input name="translationskill50" type="checkbox" size ="10" value="Education"/> Education</td> 
                              </tr>
                             <tr>
                             <td><input name="translationskill51" type="checkbox" size ="10" value="Philosophy"/> Philosophy</td>
                             <td><input name="translationskill52" type="checkbox" size ="10" value="Culture"/> Culture</td>
                             <td><input name="translationskill53" type="checkbox" size ="10" value="Literature"/> Literature </td> 
                              </tr>
                             <tr>
                             <td><input name="translationskill54" type="checkbox" size ="10" value="Psychology"/> Psychology</td>
                             <td><input name="translationskill55" type="checkbox" size ="10" value="Art"/> Art</td>
                             <td><input name="translationskill56" type="checkbox" size ="10" value="Social Science"/> Social Science</td>
                              </tr>
                           </table>
                             <br />
                          </div><br />
                          Others<br />
                          <div class="font02" style="display:inline"> 
                            <table border="0">
                           <tr>
                              <td><input name="translationskill57" type="checkbox" size ="10" value="Fire Fight"/> Fire Fight</td>
                              <td><input name="translationskill58" type="checkbox" size ="10" value="Textile"/> Textile</td>
                              <td><input name="translationskill59" type="checkbox" size ="10" value="Biography" /> Biography</td>
                              <td><input name="translationskill60" type="checkbox" size ="10" value="Military/Defense" /> Military/Defense</td>
                              </tr>
                               <tr>
                              <td><input name="translationskill61" type="checkbox" size ="10" value="Beauty" /> Beauty</td>
                             <td><input name="translationskill62" type="checkbox" size ="10" value="Physical Education" /> Physical Education</td>
                              <td><input name="translationskill63" type="checkbox" size ="10" value="Religious" /> Religious</td>
                              <td><input name="translationskill64" type="checkbox" size ="10" value="Liquors" /> Liquors</td>
                               </tr>
                                <tr>
                              <td><input name="translationskill65" type="checkbox" size ="10" value="Touring" /> Touring</td>
                              <td><input name="translationskill66" type="checkbox" size ="10" value="Geology" /> Geology</td>
                            
                              <td><input name="translationskill67" type="checkbox" size ="10" value="Food/Catering" /> Food/Catering</td>
                              <td><input name="translationskill68" type="checkbox" size ="10" value="Fashion" /> Fashion</td>
                               </tr>
                                <tr>
                              <td><input name="translationskill69" type="checkbox" size ="10" value="Music" /> Music</td>
                                <td> <input name="translationskill77" type="checkbox" size ="10" value="Animal Science" /> Animal Science</td>
                              <td><input name="translationskill71" type="checkbox" size ="10" value="Advertise" /> Advertise</td>
                              <td><input name="translationskill72" type="checkbox" size ="10" value="Movie" /> Movie</td>
                               </tr>
                                <tr>
                              <td><input name="translationskill73" type="checkbox" size ="10" value="Sport" /> Sport</td>
                              <td><input name="translationskill74" type="checkbox" size ="10" value="Jewelry" /> Jewelry</td>
                            
                              <td><input name="translationskill75" type="checkbox" size ="10" value="Mining" /> Mining</td>
                              <td><input name="translationskill76" type="checkbox" size ="10" value="Theatre" /> Theatre</td>
                               </tr>
                               </table>
                              
                              <input name="translationskill78" type="checkbox" size ="10" value="Phytology" /> Phytology&nbsp;
                              <input name="translationskill70" type="checkbox" size ="10" value="Agriculture, forestry, fishery and stock husbandary" /> Agriculture, forestry, fishery and stock husbandary
                              <br />
                              <br />

                          </div><br />
                          Professional<br />
                          <div class="font02" style="display:inline"> 
                             <table border="0">
                           <tr>
                              <td><input name="translationskill79" type="checkbox" size ="10" value="Oversea Study" /> Oversea Study</td>
                              <td><input name="translationskill80" type="checkbox" size ="10" value="Thesis" /> Thesis</td>
                              <td><input name="translationskill82" type="checkbox" size ="10" value="Notary and Immigrant" /> Notary and Immigrant</td>
                              
                               </tr>
                               <tr>
                             <td> <input name="translationskill81" type="checkbox" size ="10" value="ISO" /> ISO</td>
                             
                              <td><input name="translationskill83" type="checkbox" size ="10" value="Patent" /> Patent</td>
                              <td><input name="translationskill84" type="checkbox" size ="10" value="Technical Manual" /> Technical Manual</td>
                               </tr>
                               <tr>
                              <td><input name="translationskill85" type="checkbox" size ="10" value="Incorporation Bylaws" /> Incorporation Bylaws</td>
                              <td><input name="translationskill86" type="checkbox" size ="10" value="Press/Publish" /> Press/Publish</td>
                             <td> <input name="translationskill87" type="checkbox" size ="10" value="Contract" /> Contract</td>
                              </tr>
                              </table>
                          </div>
                        </td> 
                      </tr> 
                      <tr style=" border-style:solid; border-width:1;"> 
                        <td class="font03" style="width: 245px">Proficiency Software</td> 
                        <td width="350" colspan="5" class="font03" >
                          <div class="font02" style="display:inline"> 
                            <table border="0">
                           <tr>
                            <td> <input name="softwareskill1" type="checkbox" size ="10" value="Access" /> Access</td> 
                             <td><input name="softwareskill2" type="checkbox" size ="10" value="Publisher" /> Publisher</td> 
                              <td><input name="softwareskill4" type="checkbox" size ="10" value="FrontPage" />FrontPage</td> 
                              <td><input name="softwareskill5" type="checkbox" size ="10" value="Dreamweaver" /> Dreamweaver</td> 
                            
                             </tr>
                          <tr>
                          
                            
                             <td><input name="softwareskill3" type="checkbox" size ="10" value="Visio" /> Visio</td> 
                             <td><input name="softwareskill6" type="checkbox" size ="10" value="PageMaker" /> PageMaker</td> 
                            <td> <input name="softwareskill7" type="checkbox" size ="10" value="FrameMaker" />FrameMaker</td> 
                            <td> <input name="softwareskill8" type="checkbox" size ="10" value="QuarkXPress" /> QuarkXPress</td> 
                            </tr>
                        <tr>
                        
                             
                             <td><input name="softwareskill9" type="checkbox" size ="10" value="Robohelp" /> Robohelp</td> 
                            
                             <td><input name="softwareskill11" type="checkbox" size ="10" value="Photoshop" /> Photoshop</td> 
                             <td><input name="softwareskill12" type="checkbox" size ="10" value="Illustrator" /> Illustrator</td> 
                             <td> <input name="softwareskill10" type="checkbox" size ="10" value="AcrobatWriter" /> AcrobatWriter</td> 
                             </tr>
                         <tr>
                             
                             <td><input name="softwareskill13" type="checkbox" size ="10" value="Corel Draw" /> Corel Draw</td> 
                             <td><input name="softwareskill14" type="checkbox" size ="10" value="InDesign" /> InDesign</td> 
                             <td> <input name="softwareskill15" type="checkbox" size ="10" value="Trados" /> Trados</td> 
                             <td><input name="softwareskill16" type="checkbox" size ="10" value="SDLX" /> SDLX</td> 
                             </tr>
                              <tr>
                             
                          
                         
                            
                             <td><input name="softwareskill17" type="checkbox" size ="10" value="Deja vu" /> Deja vu</td> 
                             <td><input name="softwareskill18" type="checkbox" size ="10" value="STAR Transit" /> STAR Transit   </td> 
                             <td><input name="softwareskill19" type="checkbox" size ="10" value="IBM TM" /> IBM TM</td> 
                             </tr>
                             </table></div>
                        </td> 
                        <td class="font03" style="width: 246px">
                            *Contact Method</td> 
                        <td width="233" colspan="3" class="font03" >
                          <span class="font02"> 
                             Tel&nbsp;&nbsp;&nbsp;&nbsp;<input name="tel" type="text"  size ="10" /><br />
                             E-mail <input name="email" type="text"  size ="10" /><br />
                             QQ &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<input name="qq" type="text"  size ="10" /><br />
                             MSN &nbsp;&nbsp;&nbsp;<input name="msn" type="text"  size ="10" /><br />
                          </span>
                        </td> 
                      </tr> 
                        <tr style="border-top-style: solid; border-right-style: solid; border-left-style: solid;
                            border-bottom-style: solid">
                            <td class="font03" style="width: 245px">
                                Translation Experience</td>
                            <td class="font03" colspan="5" width="350">
                             <textarea name="experience" rows="" cols="" style="width: 349px; height: 73px;"></textarea></td>
                            <td class="font03" style="width: 246px;">
                            </td>
                            <td class="font03" colspan="3" width="233">
                            </td>
                        </tr>
                        <tr>
                        <td style="width: 245px; height: 21px;" ></td>
                        <td style="width: 90px; height: 21px" ></td>
                        <td style="width: 168px; height: 21px;" ></td>
                        <td style="width: 93px; height: 21px" ></td>
                        <td style="width: 128px; height: 21px;" ></td>
                        <td style="width: 251px; height: 21px;" ></td>
                        <td style="width: 246px; height: 21px;" ></td>
                        <td width="105" style="height: 21px" ></td>
                        <td style="width: 39px; height: 21px;" ></td>
                        <td style="width: 99px; height: 21px;" ></td>
                      </tr>
                    </table> 
                     <table width="709" border="0" cellpadding="0" cellspacing="0"> 
                      <tr> 
                        <td height="40" align="center" bgcolor="#E1E1E1" class="font11"><input type="button" name="Submit" value="Send" onclick="verifyInput(this.form)"/> 
                            <input type="reset" name="Submit2" value="Rewrite" /></td> 
                      </tr> 
                    </table> 
                </td> 
                </tr>
            </table> 
</form>  <br /><br /><br /></div>
  </div>
</div>
<div style="clear:both"></div>
<!--#include file="../newspages/downother.html"-->
</div>
</div>
<div><img src="../images/page-bottom.gif" alt="遊戲翻譯"/></div>
<uc2:foot ID="foot1" runat="server" />
</body>
</html>
