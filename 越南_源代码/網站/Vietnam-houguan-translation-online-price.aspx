<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vietnam-houguan-translation-online-price.aspx.cs" Inherits="Houguan_IT_translation_online_price" %>

<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>

<!DOCTYPE html>
<html lang="zxx">
<head>
	<title>后冠越文翻譯社—趕緊詢價好獲得快速的優質報價</title>
	<meta charset="UTF-8">
	<link rel="shortcut icon" href="img/logos/logo-shortcut.png" />	
	<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="keywords" content="越文翻譯社 詢價越文翻譯社 報價" />
	<meta name="description" content="我們相信，能夠設身處地為客戶著想才能走得更遠更久，所以后冠越文翻譯為客戶提供線上詢價，給客戶經濟實惠的翻譯報價，為客戶節省金錢與時間。后冠以熱忱的服務態度隨時歡迎您的光臨。">

	<style>
			@media all and (max-width: 768px) {
				.box-green .box-red .grid-cell-3{
					float:none;
				}
				.section-block-t1{
					display: none;
				}
				.tell{
					display: none;
				}
				.financity-footer-wrapper{
					display: none;
				}
				.mt-15{
					margin-left: 40%;
				}
				.col-xs-12-1{
					display: none;
				}
				.col-md-offset-1{
					display: none;
				}
				.t2{
					padding-left:15px;
					padding-right: 15px;
				}
				#financity-page-wrapper{
					width: 750px;
					padding-left: 0;
				}
				
			}
			@media all and (max-width:480px) ,all and (max-width:320px){
				.tell {
					display: none;
				}
				.financity-footer-wrapper{
					display: none;
				}
				.box-green .box-red .grid-cell-3{
					float:none;
				}
				.section-block-t1{
					display: none;
				}
				.section-block-parallax{
					display: none;
				}
				.col-xs-12-1{
					display: none;
				}
				.col-md-offset-1{
					display: none;
				}
				.t2{
					padding-left:15px;
					padding-right: 15px;
				}
				#financity-page-wrapper{
					width: 320px;
					padding-left: 0;
				}
			}
		</style>
	<link rel="stylesheet" type="text/css" href="css/financity-style-custom.css"/>
	<link rel="stylesheet" type="text/css" href="css/style-core.css"/>
	
	<!-- Bootstrap CSS-->
	<link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">
	
	<!-- Font-Awesome -->
	<link rel="stylesheet" type="text/css" href="css/font-awesome.css">  

	<!-- Icomoon -->
	<link rel="stylesheet" type="text/css" href="css/icomoon.css"> 

	<!-- Animate.css -->
	<link rel="stylesheet" href="css/animate.css">	

	<!-- Owl Carousel  -->
    <link rel="stylesheet" href="css/owl.carousel.css">    
	
	<!-- Main Styles -->
	<link rel="stylesheet" type="text/css" href="css/default.css">
	<link rel="stylesheet" type="text/css" href="css/styles.css">

	<!-- Fonts Google -->
	<!--   <link href="https://fonts.googleapis.com/css?family=Fira+Sans:100,200,300,400,500,600,700,800,900" rel="stylesheet">

	<link rel='stylesheet' href='plugins/revslider/public/assets/css/settings.css' type='text/css' media='all'>
		<link rel='stylesheet' href='css/style-core.css' type='text/css' media='all'>
		<link rel='stylesheet' href='css/financity-style-custom.css' type='text/css' media='all'>
		<link rel='stylesheet' href='plugins/goodlayers-core/plugins/combine/style.css' type='text/css' media='all'>
		<link rel='stylesheet' href='plugins/goodlayers-core/include/css/page-builder.css' type='text/css' media='all'>  -->
</head>
<body>



    <!-- Preloader Start-->
    <div id="preloader">
        <div class="row loader">
            <div class="loader-icon"></div>
        </div>
    </div>
    <!-- Preloader End -->


    <uc1:top runat="server" ID="top" />

    <!-- Page Title START -->
    <div class="page-title-section" style="background-image: url(img/線上詢價banner.jpg)">
        <div class="container">
            <h1>線上詢價</h1>
            <span style="color: white;">后冠越文翻譯社提供線上詢價，給客戶經濟實惠的翻譯報價</span>
           
        </div>
    </div>
    <!-- Page Title END -->



    <div class="financity-page-wrapper height-top" id="financity-page-wrapper" style="background-color: #ffffff;padding-left: 10%;">
        <div class="gdlr-core-page-builder-body">
            <div class="gdlr-core-pbf-wrapper " style="margin: 0px 0px 0px 0px;padding: 0px 0px 60px 0px;" data-skin="Hp3 Cases">
                <div class="gdlr-core-pbf-wrapper-content gdlr-core-js " data-gdlr-animation="fadeInUp" data-gdlr-animation-duration="600ms" data-gdlr-animation-offset="0.8">
                    <div class="gdlr-core-pbf-wrapper-container clearfix gdlr-core-container">
                        <div class="gdlr-core-pbf-element">
                            <div class="gdlr-core-portfolio-item gdlr-core-item-pdb clearfix  gdlr-core-portfolio-item-style-grid gdlr-core-item-pdlr" style="padding-bottom: 40px;">
                                <div class="gdlr-core-flexslider flexslider gdlr-core-js-2 " data-type="carousel" data-column="4" data-nav="no" data-nav-parent="gdlr-core-portfolio-item" data-disable-autoslide="1">
                                    <ul class="slides">
                                        <li>
                                        <div>
                                            <div id="top-title" class="font26px">線上詢價</div>
                                            <form name="form" method="post" enctype="multipart/form-data">
                                                <table>
                                                    <tr style="background-color: #ffffff;">
                                                        <td colspan="2" class="font-align font-hs ">此系統可以讓您的文件傳至我們的客服人員手中，請填好下列資料，並夾帶檔案，后冠收到後會迅速為您服務以獲得價格和優惠的價錢！</td>
                                                    </tr>
                                                    <tr style="background-color: #FFFFFF;">
                                                        <td colspan="2" class="font-align font-hs ">基本資料</td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">姓名：</td>
                                                        <td class="font-align">
                                                            <input id="username" name="llr" type="text" size="30" style="background-color: #F5F5F5;height:27px;">
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">電話</td>
                                                        <td class="font-align">
                                                            <input id="tel" name="phone" type="text" size="30" style="background-color: #f5f5f5;height:27px;">
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">Email*</td>
                                                        <td class="font-align">
                                                            <input id="email" type="text" name="email" size="30" style="background-color: #f5f5f5;height:27px;">
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td colspan="2" class="font-align font-hs ">以下請盡量提供以利給予您準確的報價：</td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">服務項目</td>
                                                        <td class="font-align">
                                                            <select id="ddltranslationskill" name="ddltranslationskill" style="width:180px;">
                                                                <option value="0">請選擇</option>
                                                                <option value="2">文件翻譯</option>
                                                                <option value="3">論文翻譯</option>
                                                                <option value="4">公證文書</option>
                                                                <option value="5">網頁翻譯</option>
                                                                <option value="6">軟體翻譯</option>
                                                            </select>
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">原始語種(從)</td>
                                                        <td class="font-align">
                                                            <select id="ddllanguagefrom" name="ddllanguagefrom" style="width:180px;">
                                                                <option value="0">請選擇</option>
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
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">目地語言(翻譯成)</td>
                                                        <td class="font-align">
                                                            <select id="ddllanguageto" name="ddllanguageto" style="width:180px;">
                                                                <option value="0">請選擇</option>
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
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">估計頁數或字數</td>
                                                        <td class="font-align">
                                                            <input id="translationamount" name="translationamount" type="text" size="30" style="background-color: #f5f5f5;height:27px;">
                                                            <select style="width:40px;" id="ddltranslationtype" name="ddltranslationtype">
                                                                <option value="字">字</option>
                                                                <option value="頁">頁</option>
                                                            </select>
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">是否需要排版</td>
                                                        <td class="font-align" style="height:20px;">
                                                            <span class="font02">
                                                                <input type="radio" name="rtypesetting" id="rty" value="1" checked="checked" style="background-color: #ffffff;">
                                                                <label for="rty">是</label>
                                                                <input type="radio" name="rtypesetting" id="rtn" value="0">
                                                                <label for="rtn">否</label>
                                                            </span>
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">是否需要二次校稿</td>
                                                        <td class="font-align" style="width: 164px; height:20px;">
                                                            <span class="font02">
                                                                <input type="radio" id="rpy" name="rproofreading" value="1" checked="checked">
                                                                <label for="rpy">是</label>
                                                                <input type="radio" id="rpn" name="rproofreading" value="0">
                                                                <label for="rpn">否</label>
                                                            </span>
                                                        </td>

                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">是否需要潤稿</td>
                                                        <td class="font-align" style="height:20px;">
                                                            <span class="font02">
                                                                <input type="radio" id="rdy" name="rdraft" value="1" checked="checked" />
                                                                <label for="rdy">是</label>
                                                                <input type="radio" id="rdn" name="rdraft" value="0">
                                                                <label for="rdn">否</label>
                                                            </span>
                                                        </td>

                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">交件時間</td>
                                                        <td class="font-align">
                                                            <span class="font02">
                                                                <input name="posttime" id="posttime" type="date" size="30" style="background-color: #f5f5f5;">
                                                            </span>
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">工作日</td>
                                                        <td class="font-align">
                                                            <input id="updays" name="updays" type="text" size="30" style="background-color: #f5f5f5;height:27px;">
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align"><span style="position: relative;top: -28px;">專案注意事項</span></td>
                                                        <td class="font-align">
                                                            <textarea name="ttbNotes" rows="4" cols="73" id="ttbNotes" style="width:483px;height: 150px;background-color: #f5f5f5;"></textarea>
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td class="font-align">
                                                            <span class="font04" style="display: inline;">上傳相關文件資料：</span>
                                                            <span class="font03" style="display: inline">上傳檔案（限制檔案大小10 MB；格式：Office文件、圖片檔、pdf、rar、zip)</span>
                                                        </td>
                                                        <td class="font-align">
                                                            <input type="file" name="file1" style="width:606px;">
                                                        </td>
                                                    </tr>
                                                    <tr style="background-color: #ffffff;">
                                                        <td><input type="submit" value="確定提交" onclick="return verifyInput(this.form);" style="background-color: #007AFF;color: white;" ></td>
                                                        <td><input type="button" onclick="window.location.reload();" value="重新填寫" style="background-color: #007AFF;color: white;"></td>
                                                    </tr>
                                                </table>
                                            </form>
                                        </div>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <uc1:foot runat="server" ID="foot" />





    <!-- Scroll to top button Start -->
    <a href="#" class="scroll-to-top"><i class="fa fa-angle-up" aria-hidden="true"></i></a>
    <!-- Scroll to top button End -->
    <!-- Jquery -->
    <script src="js/jquery.min.js"></script>

    <!-- Bootstrap JS-->
    <script src="js/bootstrap.min.js"></script>

    <!-- Owl Carousel-->
    <script src="js/owl.carousel.js"></script>

    <!-- Wow JS -->
    <script src="js/wow.min.js"></script>

    <!-- Countup -->
    <script src="js/jquery.counterup.min.js"></script>
    <script src="js/waypoints.min.js"></script>

    <!-- Tabs -->
    <script src="js/tabs.min.js"></script>

    <!-- Yotube Video Player -->
    <script src="js/jquery.mb.YTPlayer.min.js"></script>

    <!-- Isotop -->
    <script src="js/isotope.pkgd.min.js"></script>

    <!-- Modernizr -->
    <script src="js/modernizr.js"></script>

    <!-- Google Map -->
    <script src="js/map.js"></script>

    <!-- Main JS -->
    <script src="js/main.js"></script>
      <script>
         function verifyInput(form) {
            if (form.username.value.length == 0) {
                alert("請輸入姓名");
                form.username.focus();
                form.username.select();
                return false;
            }
            else if (form.tel.value.length == 0) {
                alert("請輸入電話!");
                form.tel.focus();
                form.tel.select();
                return false;
            }
            else if (form.email.value.length == 0) {
                alert("請輸入郵箱");
                form.email.focus();
                form.email.select();
                return false;
            }
            return true;
        }
    </script>
</body>
</html>
