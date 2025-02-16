<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vietnam-houguan-translation-customers.aspx.cs" Inherits="houguan_Video_translation_customers" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>


<!DOCTYPE html>
<html lang="zxx">
<head runat="server">
    <title>后冠越語翻譯社—以實績見證實力</title>
    <meta charset="UTF-8">
    <link rel="shortcut icon" href="img/logos/logo-shortcut.png" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="keywords" content="越文翻譯" />
    <meta name="description" content="高雄和台南是台灣重要的中心城市，人流量大，越語翻譯的需求也極大。而后冠設立在此的越語翻譯社不斷壯大，一路走來以絕佳的實績讓廣大客戶見證后冠的翻譯實力">

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

            .section-block-parallax {
                display: none;
            }

            .col-xs-12-1 {
                display: none;
            }

            .col-md-offset-1 {
                display: none;
            }
        }
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
    <div class="page-title-section" style="background-image: url(img/客戶實績banner.jpg);">
        <div class="container">
            <h1>客戶實績</h1>
            <span style="color: white;">高雄和台南是台灣重要的中心城市，人流量大，越語翻譯的需求也極大。而后冠設立在此的越語翻譯社不斷壯大，一路走來以絕佳的實績讓廣大客戶見證后冠的翻譯實力</span>
           
        </div>
    </div>
    <!-- Page Title END -->






    <!-- Testmonials START -->
    <div class="section-block-grey">
        <div class="container">
            <div class="section-heading center-holder">
                <span>后冠越語翻譯社—以實績見證實力</span>
                <h4>客戶實績</h4>
                <div class="section-heading-line"></div>
            </div>
            <div class="col-md-3 col-sm-4 col-xs-12">
                <div class="blog-list-right">

                    <div class="blog-categories" style="padding-top: 120px;">
                        <div class="blog-list-left-heading">
                            <h4>相關介紹</h4>
                        </div>
                        <ul>
                            <%
                                for (int ii = 0; ii < dtClass.Rows.Count; ii++)
                                {
                                    string[] t = new String[2];
                                    if (dtClass.Rows[ii]["nc_classname"].ToString().Trim().Split('|').Length > 1)
                                    {
                                        t = dtClass.Rows[ii]["nc_classname"].ToString().Trim().Split('|');
                                    }
                                    else
                                    {
                                        t[0] = dtClass.Rows[ii]["nc_classname"].ToString().Trim();
                                        t[1] = "";
                                    }
                            %>
                            <li>
                                <a href="Vietnam-houguan-translation-customers.aspx?gid=<%=dtClass.Rows[ii]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a>
                            </li>
                            <%} %>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="col-md-9 col-sm-8 col-xs-12 pr-30-md">
                <div class="owl-carousel owl-theme" id="testmonials-carousel">

                    <%
                        int page = 1;
                        int pageCount = 0;
                        if (!string.IsNullOrEmpty(Request["page"]))
                        {
                            page = Int32.Parse(Request["page"]);
                        }
                        pageCount = page * 4;

                        var tn = dtInfo.Rows.Count;
                        var pageNum = (page - 1) * 4;
                        var n = 0;

                        for (int i = pageNum; i < tn; i++)
                        {
                            if (n % 4 == 0)
                            {%>

                    <div class="testmonial-single" style="height: 700px;">
                        <%} %>

                        <div class="col-md-6 col-sm-12 col-xs-12">
                            <div class="blog-grid" style="height:300px;">
                                <div class="blog-grid-img">
                                    <img src="/<%=dtInfo.Rows[i]["pic"].ToString().Trim() %>" alt="<%=dtInfo.Rows[i]["title"].ToString().Trim() %>" />
                                </div>
                                <div class="blog-grid-text">
                                    <h4><%=dtInfo.Rows[i]["title"].ToString().Trim() %></h4>
                                </div>
                            </div>
                        </div>

                        <%

                            if (n % 4 == 3 || (i == tn - 1))
                            { %>
                    </div>

                    <% 
                            }

                            n++;
                        }
                    %>
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

</body>
</html>
