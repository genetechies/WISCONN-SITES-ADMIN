<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vietnam-houguan-translation-team.aspx.cs" Inherits="Houguan_IT_translation_team" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<!DOCTYPE html>
<html lang="zxx">
<head runat="server">
    <title>后冠越文翻譯公司—專業越文翻譯團隊給您優質翻譯服務</title>
    <meta charset="UTF-8">
    <link rel="shortcut icon" href="img/logos/logo-shortcut.png" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="keywords" content="越文翻譯" />
    <meta name="description" content="后冠越文翻譯公司的翻譯團隊來自五湖四海，都是經歷層層考驗才能進入翻譯社，他們不僅有深厚的越文翻譯功底，還有多年的翻譯經驗，是最專業、最準確、最負責的團隊。">

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
                padding-left: 15px;
                padding-right: 15px;
            }

            #financity-page-wrapper {
                width: 750px;
                padding-left: 0;
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

            .t2 {
                padding-left: 15px;
                padding-right: 15px;
            }

            #financity-page-wrapper {
                width: 320px;
                padding-left: 0;
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
    <div class="page-title-section" style="background-image: url(img/越文翻譯團隊banner.jpg);">
        <div class="container">
            <h1>越文翻譯團隊</h1>
            <span style="color: white;">后冠越文翻譯公司—專業越文翻譯團隊給您優質翻譯服務
            </span>
           
        </div>
    </div>
    <!-- Page Title END -->




    <!-- Partners(Team members) Section START -->
    <div class="section-block-grey">
        <div class="container">
            <div class="section-heading center-holder">
                <span>后冠越文翻譯公司相信，只有好的翻譯團隊才能締造優質的越文翻譯</span>
                <h3>越文翻譯團隊</h3>
                <div class="section-heading-line"></div>
            </div>
            <div class="section-block">
                <div class="container">
                    <div class="row">
                        <div class="col-md-3 col-sm-4 col-xs-12">
                            <div class="blog-list-right">


                                <!-- Categories -->
                                <div class="blog-list-left-heading">
                                    <h4>越文翻譯資訊</h4>
                                </div>
                                <div class="blog-categories">
                                    <ul>
                                        <%
                                            for (int ii = 0; ii < dtClass.Rows.Count; ii++)
                                            {
                                                string[] t = new String[2];
                                                if (dtClass.Rows[ii]["NC_ClassName"].ToString().Trim().Split('|').Length > 1)
                                                {
                                                    t = dtClass.Rows[ii]["NC_ClassName"].ToString().Trim().Split('|');
                                                }
                                                else
                                                {
                                                    t[0] = dtClass.Rows[ii]["NC_ClassName"].ToString().Trim();
                                                    t[1] = "";
                                                }
                                        %>
                                        <li>
                                            <a href="Vietnam-houguan-translation-team.aspx?gid=<%=dtClass.Rows[ii]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a>
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
                                    var n = 0;

                                    int tn = dtInfo.Rows.Count > pageCount ? pageCount : dtInfo.Rows.Count;

                                    for (int i = (page - 1) * 4; i < tn; i++)
                                    {
                                        var item = dtInfo.Rows[i];
                                        if (n % 2 == 0)
                                        {
                                %>
                                <div class="testmonial-single" style="height: 700px;">
                                    <%} %>

                                    <div class="col-md-6 col-sm-12 col-xs-12">
                                        <div class="blog-grid">
                                            <div class="blog-grid-img">
                                                <img src="<%= Convert.ToString(item["imgpath"])==""?"img/其他語言.jpg":item["imgpath"] %>" alt="img">
                                            </div>

                                            <div class="blog-grid-text">
                                                <h4><%=item["tname"] %></h4>
                                                <p>
                                                    <%=item["descript"] %>
                                                </p>
                                            </div>

                                        </div>
                                    </div>

                                    <%

                                        if (n % 2 == 1 || (i == tn - 1))
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
