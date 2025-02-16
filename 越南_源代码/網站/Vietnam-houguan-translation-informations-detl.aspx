<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vietnam-houguan-translation-informations-detl.aspx.cs" Inherits="Houguan_IT_translation_informations_detail" %>

<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<!DOCTYPE html>
<html lang="zxx">
<head >
    <meta charset="UTF-8">
    <link rel="shortcut icon" href="img/logos/logo-shortcut.png" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
     <title><%=Title %></title>
    <meta name="description" content="<%=model.D_Description %>" />
    <meta name="keywords" content="<%=model.D_Keyword %>" />

    <style>
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

            .mt-15 {
                margin-left: 40%;
            }

            .col-xs-12-1 {
                display: none;
            }

            .col-md-offset-1 {
                display: none;
            }

            .t2 {
                width: 100%;
                margin-left: 10%;
                margin-top: 30px;
            }
            .content img {
                overflow-clip-margin: content-box;
                overflow: clip;
                width: auto !important;
            }
        }
    </style>
    <style type="text/css">
			
		</style>
    <link rel="stylesheet" type="text/css" href="css/financity-style-custom.css" />
    <link rel="stylesheet" type="text/css" href="css/style-core.css" />
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

    <!-- Page Title START -->
    <div class="page-title-section" style="background-image: url(img/越文翻譯資訊banner.jpg)">
        <div class="container">
            <h1>越文翻譯資訊詳情</h1>
            <span style="color: white;">后冠越語翻譯社—最快捷的翻譯資訊，最合理的翻譯價位</span>
            <ul>
                <li><a href="Vietnam-houguan-translation-index.aspx">首頁</a></li>
                <li><a href="Vietnam-houguan-translation-contact.html">聯繫我們</a></li>
            </ul>
        </div>
    </div>
    <!-- Page Title END -->





    <!-- Blog Grid START -->
    <div class="section-block">
        <div class="container">
            <div class="row">
                <!-- Left Side START -->

                <div class="col-md-3 col-sm-4 col-xs-12" style="">
                    <div class="blog-list-right">

                        <!-- Categories -->
                        <div class="blog-list-left-heading">
                            <h4>越文翻譯資訊</h4>
                        </div>
                        <div class="blog-categories">
                            <ul>
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
                                        <li >
                                            <a  href="Vietnam-houguan-translation-informations.aspx?cid=<%=dtClass.Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a>
                                        </li>
                                        <%} %>
                            </ul>
                        </div>


                    </div>
                </div>
                <div class="t2 col-md-3 " style="width: 75%;">
                    <h3 style="color: #646464; padding-bottom: 20px;"><%=model.D_Title %></h3>
                    <p><%=model.D_Time.ToString("yyyy-MM-dd")%> </p>

                     <div class="content"><%=model.D_Content %></div>
                </div>
            </div>
        </div>
    </div>
    <!-- Blog Grid END -->

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

</body>
</html>
