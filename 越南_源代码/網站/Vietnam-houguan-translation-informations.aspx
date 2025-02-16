<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Vietnam-houguan-translation-informations.aspx.cs" Inherits="Houguan_IT_translation_informations" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>

<!DOCTYPE html>
<html lang="zxx">
<head runat="server">
    <title>后冠越語翻譯社—最快捷的翻譯資訊，最合理的翻譯價位</title>
    <meta charset="UTF-8">
    <link rel="shortcut icon" href="img/logos/logo-shortcut.png" />
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <meta name="keywords" content="越文翻譯社" />
    <meta name="description" content="后冠越語翻譯社有專門的市場調查人員，及時提供最新、最全面、最細緻的越文翻譯資訊，並且提供經濟實惠的翻譯價位。">

    <style>
        .blog-grid {
            width: 400px;
            margin-left: 50px !important;
            float: left;
        }

        @media all and (max-width: 635px) {
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

            .blog-grid {
                margin-left: 100px;
            }

            .pp1 {
                display: block;
                margin-left: 100px;
            }

            #n11 {
                padding-top: 1600px;
            }

            #pp1 {
                margin-left: 15%;
            }
        }
    </style>
    <style>
        .n1 li {
            cursor: pointer;
            color: cadetblue;
            height: 50px;
            width: 50px;
            background-color: lavender;
            border-radius: 50%;
            padding-left: 20px;
            margin-left: 10px;
            float: left;
        }

        .n1-1 {
            padding-top: 12px;
        }

        .n1 li.y1 {
            background-color: royalblue;
        }

            .n1 li.y1 a {
                color: white;
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
    <div class="page-title-section" style="background-image: url(img/越文翻譯資訊banner.jpg)">
        <div class="container">
            <h1>越文翻譯資訊</h1>
            <span style="color: white;">后冠越語翻譯社—最快捷的翻譯資訊，最合理的翻譯價位</span>
            
        </div>
    </div>
    <!-- Page Title END -->





    <!-- Blog Grid START -->
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
                                <li>
                                    <a href="Vietnam-houguan-translation-informations.aspx?cid=<%=dtClass.Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a>
                                </li>
                                <%} %>
                            </ul>
                        </div>


                    </div>
                </div>

                <div class="n1">
                    <div style="float:left;margin-top:40px;" class="col-md-9 col-sm-8 col-xs-12">
                        <div><asp:Literal ID="ltArtListTitle" runat="server"></asp:Literal></div>
                        <div><asp:Literal ID="ltArtListDescription" runat="server"></asp:Literal></div>
                    </div>
                    <%
                        int page = 1;
                        int pageCount = 0;
                        if (!string.IsNullOrEmpty(Request["page"]))
                        {
                            page = Int32.Parse(Request["page"]);
                        }
                        pageCount = page * 4;

                        int tn = dtInfo.Rows.Count > pageCount ? pageCount : dtInfo.Rows.Count;
                        var pageNum = (page - 1) * 4;
                        var n = 0;
                        for (int i = (page - 1) * 4; i < tn; i++)
                        {
                            var item = dtInfo.Rows[i];

                            if (n % 2 == 0)
                            {
                    %>
                    <div class="n1-<%=n == 0 ? "1" : "2" %>">
                        <%
                            }
                        %>

                        <div class="blog-grid" style="height:300px;width:380px;">
                            <div class="blog-grid-text">
                                <h4><a href="Vietnam-houguan-translation-informations-detl.aspx?id=<%= item["D_Id"] %>" title="<%= item["D_Title"]%>"><%= item["D_Title"]%></a></h4>
                                <p><%=Convert.ToDateTime(item["D_Time"]).ToString("yyyy-MM-dd")%></p>
                                <p style="height:136px;"><%=Utils.SubString(item["D_Description"], 100, "...")%></p>
                            </div>
                        </div>

                        <% 
                            if (n % 2 == 1 || i == tn - 1)
                            {
                        %>
                    </div>
                <%
                        }

                        n++;
                    }
                %>


                <div id="n11" class="" style="padding-left: 22%; position: relative;">
                    <div class="col-sm-12">
                        <ul class="">
                            <% 
                                int totalPage = Convert.ToInt32(Math.Ceiling(dtInfo.Rows.Count / 4M));
                                if (totalPage > 1)
                                {

                                    if (page > 1)
                                    {
                            %>
                            <li class="n1-1"><a href="Vietnam-houguan-translation-informations.aspx?gid=<%=Request["gid"] %>&page=<%=page-1 %>"><</a></li>
                            <%
                                }

                            %>
                            <li class="n1-1 y1"><a><%=page %></a></li>
                            <%
                                if (page + 1 <= totalPage)
                                {
                            %>
                            <li class="n1-1"><a href="Vietnam-houguan-translation-informations.aspx?gid=<%=Request["gid"] %>&page=<%=page+1 %>"><%=page+1 %> </a>
                            </li>
                            <%
                                }
                                if (page < totalPage)
                                {
                            %>
                            <li class="n1-1"><a href="Vietnam-houguan-translation-informations.aspx?gid=<%=Request["gid"] %>&page=<%=page+1 %>">></a></li>
                            <%
                                    }
                                }
                            %>
                        </ul>
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
