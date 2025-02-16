<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vietnam-houguan-translation-index.aspx.cs" Inherits="Houguan_IT_translation_index" %>

<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>

<!DOCTYPE html>
<html lang="zxx">

<head>
    <title>后冠越文翻譯社—誠信為先，專業為本</title>
    <meta charset="UTF-8">
    <link rel="shortcut icon" href="img/logos/logo-shortcut.png" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="keywords" content="越文翻譯,越文翻譯公司,越文翻譯社" />
    <meta name="description" content="后冠越文翻譯公司成立以來，已經承接眾多種類翻譯，累積了多種翻譯經驗，擁有強大的翻譯團隊，我們越文翻譯翻譯社盡心盡力為每一位客戶提供超越想像價錢和品質，給客戶最優質專業的翻譯服務。">

    <style>
        ul,
        li {
            list-style: none;
        }

        .t1 {
            float: left;
        }

        .t3-1 {
            float: left;
        }

        @media all and (max-width: 768px) {
            .box-green .box-red .grid-cell-3 {
                float: none;
            }

            .section-block-t1 {
                display: none;
            }

            .tell {
                display: none;
            }

            .financity-footer-wrapper {
                display: none;
            }
        }

        @media all and (max-width:480px),all and (max-width:320px) {
            .tell {
                display: none;
            }

            .financity-footer-wrapper {
                display: none;
            }

            .box-green .box-red .grid-cell-3 {
                float: none;
            }

            .section-block-t1 {
                display: none;
            }
        }
    </style>
    <link rel="stylesheet" type="text/css" href="css/tq1.css" />
    <link rel="stylesheet" type="text/css" href="css/financity-style-custom.css" />
    <link rel="stylesheet" type="text/css" href="css/style-core.css" />
    <!-- Bootstrap CSS-->
    <link rel="stylesheet" type="text/css" href="css/bootstrap.min.css">

    <!-- Font-Awesome -->
    <link rel="stylesheet" type="text/css" href="css/font-awesome.css">

    <!-- Icomoon -->
    <link rel="stylesheet" type="text/css" href="css/icomoon.css">

    <!-- Slider -->
    <link rel="stylesheet" type="text/css" href="css/swiper.min.css">
    <link rel="stylesheet" type="text/css" href="css/slider.css">

    <!-- Animate.css -->
    <link rel="stylesheet" href="css/animate.css">

    <!-- Owl Carousel  -->
    <link rel="stylesheet" href="css/owl.carousel.css">

    <!-- Main Styles -->
    <link rel="stylesheet" type="text/css" href="css/default.css">
    <link rel="stylesheet" type="text/css" href="css/styles.css">

    <!-- Fonts Google -->
    <link href="https://fonts.googleapis.com/css?family=Fira+Sans:100,200,300,400,500,600,700,800,900" rel="stylesheet">
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

    <!-- Navbar START -->
   
    <!-- Navbar END -->

    <!-- Slider START -->
    <div class="swiper-main-slider-fade swiper-container">
        <div class="swiper-wrapper">

            <!-- Slide 1 Start -->
            <div class="swiper-slide" style="background-image: url(img/首頁banner.jpg);">
                <!-- <div class="medium-overlay"></div> -->
                <div class="container">
                    <div class="slider-content left-holder">
                        <h2 class="animated fadeInDown">后冠越語翻譯公司 
                        </h2>
                        <div class="row">
                            <div class="col-md-6 col-sm-12 col-xs-12">
                                <p class="animated fadeInDown" style="color: #000000;">
                                    后冠越文翻譯公司立足在台北，國際化的腳步一直未停歇，迄今為止，在深圳、香港、澳門等地都有翻譯據點； 翻譯的語言包括英文翻譯、越文翻譯等三十幾種語言，並且在不斷地發展，為爭取每一位客戶而前進，為每一 位客戶的期待而努力，也是客戶的推薦首選。
                                </p>
                            </div>
                        </div>
                    
                    </div>
                </div>
            </div>
            <!-- Slide 1 End -->

            <!-- Slide 2 Start -->
            <div class="swiper-slide" style="background-image: url(img/首頁banner2.jpg);">
                <div class="container">
                    <div class="slider-content left-holder">
                        <h2 class="animated fadeInDown">后冠越語翻譯公司 
                        </h2>
                        <div class="row">
                            <div class="col-md-6 col-sm-12 col-xs-12">
                                <p class="animated fadeInDown" style="color: #000000;">
                                    在語言翻譯方面，除了越文，還包括、英文、德文等三十幾種語言互譯； 在類別方面，包括筆譯、校稿、潤稿、網頁翻譯、影視翻譯、打字排版等類型； 在流程上，有翻譯、校對、潤飾、專名表等各項服務； 在領域方面，包括醫學、法律、電子、期刊等專業領域。
                                </p>
                            </div>
                        </div>
                 
                    </div>
                </div>
            </div>
            <!-- Slide 2 End -->

            <!-- Slide 3 Start -->
            <div class="swiper-slide" style="background-image: url(img/首頁banner3.jpg);">
                <div class="container">
                    <div class="slider-content left-holder">
                        <h2 class="animated fadeInDown" style="color: gray;">后冠越語翻譯公司 
                        </h2>
                        <div class="row">
                            <div class="col-md-6 col-sm-12 col-xs-12">
                                <p class="animated fadeInDown" style="color: #000000;">
                                    后冠的翻譯團隊都是來自世界各地的頂級翻譯人員，經歷了層層選拔和考驗。 每一個翻翻譯師都有基本的基礎知識和語言能力；在專業能力上， 要有嚴謹的翻譯能力和理性思維能力，並了解該專業領域的內容； 在職業技能上，有高度的責任感，能夠克盡己責。
                                </p>
                            </div>
                        </div>
               
                    </div>
                </div>
            </div>
            <!-- Slide 3 End -->

        </div>
        <!-- Add Arrows -->
        <div class="swiper-button-next"></div>
        <div class="swiper-button-prev"></div>
        <!-- Add Pagination -->
        <div class="swiper-pagination"></div>
    </div>
    <!-- Slider END -->

    <!-- Number Boxes START -->
    <div class="section-block">
        <div class="container">
            <div class="section-heading center-holder">

                <h1>四大翻譯特色</h1>
                <div class="section-heading-line"></div>
                <p>后冠越文翻譯公司成立以來，已經承接眾多種類翻譯，累積了多種翻譯經驗，擁有強大的翻譯團隊，盡心盡力為每一位客戶提供超越想像價錢和品質，給客戶最優質專業的翻譯服務。</p>
            </div>
            <div class="row mt-50">
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="number-box">
                        <h3>01</h3>
                        <div class="number-box-line"></div>
                        <h4>專業品質</h4>
                        <p>在接洽的客戶群中，無論是大型企業還是個人，我們都盡力做到最好，提供最完美的解決方案。</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="number-box">
                        <h3>02</h3>
                        <div class="number-box-line"></div>
                        <h4>資深團隊</h4>
                        <p>后冠的翻譯團隊都是來自世界各地的頂級翻譯人員，經歷了層層選拔和考驗了解該專業領域的內容。</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="number-box">
                        <h3>03</h3>
                        <div class="number-box-line"></div>
                        <h4>多元業務</h4>
                        <p>在語言翻譯方面，除了越文，還包括、英文、德文等三十幾種語言互譯。專業類型服務領域多元。</p>
                    </div>
                </div>
                <div class="col-md-3 col-sm-6 col-xs-12">
                    <div class="number-box">
                        <h3>04</h3>
                        <div class="number-box-line"></div>
                        <h4>忠實傳譯</h4>
                        <p>翻譯有直譯和意譯兩種。翻譯師能夠依據文件類型與狀況隨時調整翻譯的方式已原文為優先考量。</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- Number Boxes END -->

    <!-- Info Section START -->
    <div class="section-block-grey">
        <div class="container">
            <div class="row">
                <div class="col-md-6 col-sm-6 col-xs-12">
                    <div class="pr-30-md">
                        <div class="section-heading">
                            <h4>關於后冠越文翻譯</h4>
                        </div>
                        <div class="section-heading-line-left"></div>
                        <div class="text-content-big mt-20">
                            <p>后冠越文翻譯公司成立以來，已經承接眾多種類翻譯，累積了多種翻譯經驗，擁有強大的翻譯團隊，盡心盡力為每一位客戶提供超越想像價錢和品質，給客戶最優質專業的翻譯服務。</p>
                        </div>
                        <div class="mt-20">
                            <ul class="primary-list">
                                <li><i class="fa fa-caret-right"></i>以熱忱的服務、嚴謹的翻譯流程、專業的翻譯團隊給您優質的越文翻譯</li>
                                <li><i class="fa fa-caret-right"></i>依優質母語翻譯師和耐心、細心的專案人員，為您提供最貼切的翻譯服務</li>
                                <li><i class="fa fa-caret-right"></i>秉持準時而不影響品質為宗旨，負責的態度完成翻譯</li>
                            </ul>
                        </div>
                     
                    </div>
                </div>
                <div class="col-md-6 col-sm-6 col-xs-12">
                    <img src="img/首頁小圖1.jpg" class="rounded-border shadow-primary" alt="img">
                </div>
            </div>
        </div>
    </div>
    <!-- Info Section END -->

    <!-- Services START -->
    <div class="section-block-t1">
        <div class="container">
            <div class="section-heading center-holder" style="margin-top:30px;">
                <h3>翻譯資訊</h3>
                <div class="section-heading-line"></div>
                <p>后冠越語翻譯社多年來承接了多樣化的翻譯類型，尤其是法律和操作手冊方面更是出類拔萃，積累了多年的翻譯經驗。后冠專門組織翻譯師對此進行歸納總結，提供簡單明瞭的翻譯資訊。</p>
            </div>
            <div class="grid box-green">

                
                <%
                    for (int i = 0; i < dtClass.Rows.Count; i++)
                    {
                        string[] t = new String[2];
                        if (dtClass.Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
                        {
                            t = dtClass.Rows[i]["ClassName"].ToString().Trim().Split('|');
                        }
                        else
                        {
                            t[0] = dtClass.Rows[i]["ClassName"].ToString().Trim();
                            t[1] = "";
                        }
                %>

                <div class="grid-cell-3">
                    <div class="box-w" style="width:190px; margin-bottom:30px; padding:0px;">
                        <p style="color: #0083D4; font-size: 20px;"><a href="Vietnam-houguan-translation-informations.aspx?cid=<%=dtClass.Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></p>
                        <%
                            System.Data.DataSet ds_web = new BLL.SubWeb().GetAllList();
                            if (ds_web.Tables.Count > 0)
                            {
                                int swid = Convert.ToInt32(ds_web.Tables[0].Rows[0]["SWID"].ToString());
                                Model.SubWeb web = new BLL.SubWeb().GetModel(swid);
                                System.Data.DataTable NewsTable = new BLL.newsdata().GetList_top(3, " D_Recycle=0  and D_ClassID= '" + dtClass.Rows[i]["classid"].ToString().Trim() + "'").Tables[0];
                                foreach (System.Data.DataRow item in NewsTable.Rows)
                                { %>
                        <p><a href="Vietnam-houguan-translation-informations-detl.aspx?id=<%= item["D_Id"] %>"><%=Utils.SubString(item["D_Title"],12,"...") %></a></p>
                        <%} %>
						
                    </div>
                </div>

                <%}
                    }%>

        </div>
    </div>
</div>
    <div class="section-heading center-holder">
        <h3>友好連結</h3>
        <div class="section-heading-line"></div>
    </div>
    <div>
    <!--#include file="newspages/downindex.html"-->


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

    <!-- Swiper Slider -->
    <script src="js/swiper.min.js"></script>

    <!-- Isotop -->
    <script src="js/isotope.pkgd.min.js"></script>

    <!-- Modernizr -->
    <script src="js/modernizr.js"></script>

    <!-- Google Map -->
    <script src="js/map.js"></script>

    <!-- Main JS -->
    <script src="js/main.js"></script>

</body>

</html>
