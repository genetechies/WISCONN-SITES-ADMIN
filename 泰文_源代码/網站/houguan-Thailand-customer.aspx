<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houguan-Thailand-customer.aspx.cs" Inherits="houguan_Thailand_customers" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<%@ Register Src="~/mobiletop.ascx" TagPrefix="uc1" TagName="mobiletop" %>



<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>后冠泰文翻譯—用便宜合理價錢讓客戶做最好的推薦</title>
    <meta name="description" content="后冠泰文翻譯憑藉優秀的翻譯品質和便宜合理的翻譯價錢，成功積累了一批又一批的舊客戶。我們以多年的客戶實績，以及超越行業的翻譯水準向廣大客戶展現了一個不一樣的泰文翻譯公司。后冠希望，能夠借此做受客戶推薦的泰文翻譯公司。">
    <meta name="keywords" content="泰文翻譯社 便宜,泰文翻譯 價錢" />
    <!-- fav icon -->
    <link href="assets/images/favicon.png" rel="shortcut icon" type="image/png">

    <!-- Bootstrap -->
    <link href="assets/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <!-- animated-css -->
    <link href="assets/css/animate.min.css" rel="stylesheet" type="text/css">
    <!-- font-awesome-css -->
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <!-- owl-carrosel-css -->
    <link href="assets/owl-carrosel/owl.carousel.min.css" rel="stylesheet" type="text/css">
    <link href="assets/owl-carrosel/owl.theme.default.min.css" rel="stylesheet" type="text/css">
    <!-- Revulation Slider CSS -->
    <link rel="stylesheet" type="text/css" href="assets/rs/css/settings.css" media="screen" />
    <!-- offcanvas-menu-css -->
    <link href="assets/css/offcanvas-menu.css" rel="stylesheet" type="text/css">
    <!-- style-css -->
    <link href="assets/css/style.css" rel="stylesheet" type="text/css">
</head>
<body class="homepageFive">
    <!-- start preloader -->
    <div id="preloader">
        <div class="preloader">
            <span></span>
            <span></span>
            <span></span>
            <span></span>
            <span></span>
        </div>
    </div>
    <!-- end preloader -->
    <div class="subPage">
        <uc1:top runat="server" ID="top" />
    </div>
    

    <section class="header-title section-padding" style="background-image: url(assets/images/翻譯團隊banner.jpg)">
        <div class="container text-center">
            <h2 class="title">客戶實績</h2>
            <span class="sub-title">Home > Pages > Shop</span>
        </div>
    </section>
    <!-- header-title -->



    <section class="shop-section section-padding">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <div class="left-bar">
                        <div class="wrapper-contant">
                            <h4>CATEGORY</h4>

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
                                    <a href="houguan-Thailand-customer.aspx?gid=<%=dtClass.Rows[ii]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%>
                                        <span class="pull-right"><i class="fa fa-caret-right" aria-hidden="true"></i></span>
                                    </a>
                                </li>
                                <%} %>
                            </ul>
                        </div>


                    </div>
                    <!-- left-bar -->
                </div>

                <div class="col-md-9">
                    <div class="right-bar">
                        <div class="product-selection">
                            <div class="row">

                                <%
                                    int page = 1;
                                    int pageCount = 0;
                                    if (!string.IsNullOrEmpty(Request["page"]))
                                    {
                                        page = Int32.Parse(Request["page"]);
                                    }
                                    page = page < 1 ? 1 : page;

                                    pageCount = page * 6;

                                    var tn = dtInfo.Rows.Count - pageCount > 0 ? pageCount : dtInfo.Rows.Count;

                                    var pageNum = (page - 1) * 6;
                                    var n = 0;

                                    for (int i = pageNum; i < tn; i++)
                                    {%>
                                <div class="col-md-4 col-sm-6">
                                    <div class="product-wrapper">
                                        <img src="/<%=dtInfo.Rows[i]["pic"].ToString().Trim() %>" alt="<%=dtInfo.Rows[i]["title"].ToString().Trim() %>">

                                        <div class="product-detail" style="width:268px;height:100px;">
                                            <a href="#">
                                                <p><%=dtInfo.Rows[i]["title"].ToString().Trim() %></p>
                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <%} %>
                            </div>
                        </div>
                        <!-- product-selection -->
                    </div>
                    <!-- right-bar -->
                </div>
            </div>
        </div>
        <section class="testimonial-two-section" style="margin-top: 10px; margin-left: 350px;">
            <div id="testimonial-carousel">
                <% 
                    int totalPage = Convert.ToInt32(Math.Ceiling(dtInfo.Rows.Count / 6M));
                    if (totalPage > 1)
                    {

                        if (page >= 1)
                        {
                %>
                <a class="left carousel-control"   href="houguan-Thailand-customer.aspx?gid=<%=Request["gid"] %>&page=<%=page - 1 %>" role="button" data-slide="prev"><i class="fa fa-angle-left" aria-hidden="true"></i></a>
                <%
                    }

                    if (page < totalPage)
                    {
                %>
                <a class="right carousel-control" href="houguan-Thailand-customer.aspx?gid=<%=Request["gid"] %>&page=<%=page + 1 %>" role="button" data-slide="next"><i class="fa fa-angle-right" aria-hidden="true"></i></a>
                <%
                        }
                    }
                %>
                <h5>&nbsp;</h5>
            </div>
        </section>
    </section>
    <!-- shop-page -->
    <uc1:foot runat="server" ID="foot" />
    <uc1:mobiletop runat="server" ID="mobiletop1" />
    <script src="assets/js/jquery.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/jquery.inview.min.js"></script>
    <script src="assets/js/wow.js"></script>
    <script src="assets/js/lightbox.js"></script>
    <script src="assets/owl-carrosel/owl.carousel.min.js"></script>
    <script src="assets/js/jquery-ui.js"></script>
    <script src="assets/js/language.js"></script>


    <!-- revolution slider js -->
    <script src="assets/rs/jquery.themepunch.tools.min.js"></script>
    <script src="assets/rs/jquery.themepunch.revolution.min.js"></script>
    <script src="assets/rs/revolution.extension.actions.min.js"></script>
    <script src="assets/rs/revolution.extension.carousel.min.js"></script>
    <script src="assets/rs/revolution.extension.kenburn.min.js"></script>
    <script src="assets/rs/revolution.extension.layeranimation.min.js"></script>
    <script src="assets/rs/revolution.extension.migration.min.js"></script>
    <script src="assets/rs/revolution.extension.navigation.min.js"></script>
    <script src="assets/rs/revolution.extension.parallax.min.js"></script>
    <script src="assets/rs/revolution.extension.slideanims.min.js"></script>
    <script src="assets/rs/revolution.extension.video.min.js"></script>


    <script src="assets/js/filter/jshashtable-2.1_src.js"></script>
    <script src="assets/js/filter/jquery.numberformatter-1.2.3.js"></script>
    <script src="assets/js/filter/tmpl.js"></script>
    <script src="assets/js/filter/jquery.dependClass-0.1.js"></script>
    <script src="assets/js/filter/draggable-0.1.js"></script>
    <script src="assets/js/filter/jquery.slider.js"></script>


    <script>
        jQuery("#Slider1").slider({ from: 1000, to: 100000, step: 500, smooth: true, round: 0, dimension: "&nbsp;$", skin: "plastic" });
    </script>

    <script src="assets/js/script.js"></script>
</body>
</html>
