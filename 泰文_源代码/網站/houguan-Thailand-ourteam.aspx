<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houguan-Thailand-ourteam.aspx.cs" Inherits="houguan_Thailand_team" %>

<%@ Register Src="~/mobiletop.ascx" TagPrefix="uc1" TagName="mobiletop" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>后冠泰文翻譯社—打造頂級泰語翻譯團隊創造行情</title>
    <meta name="description" content="后冠泰文翻譯社的泰語翻譯團隊有多年經驗，不僅保留了自己的特色，還不斷吸取行業內的經驗，創造行情，以此完善自我。此外，后冠泰文翻譯團隊還有母語譯者的加入，更讓后冠如虎添翼，為翻譯服務的品質增添了保障。">
    <meta name="keywords" content="泰語翻譯 行情,泰文翻譯 行情" />
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
<body class="subPage shopPage">
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

    <uc1:top runat="server" ID="top" />

    <section class="header-title section-padding" style="background-image: url(assets/images/翻譯團隊banner.jpg)">
        <div class="container text-center">
            <h2 class="title">翻譯團隊</h2>
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
                                    <a style="color: #2d5fde;" href="houguan-Thailand-ourteam.aspx?gid=<%=dtClass.Rows[ii]["nc_id"].ToString().Trim() %>">
                                        <%=t[0].Trim()%>
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
                                    var n = 0;

                                    int tn = dtInfo.Rows.Count > pageCount ? pageCount : dtInfo.Rows.Count;

                                    for (int i = (page - 1) * 6; i < tn; i++)
                                    {
                                        var item = dtInfo.Rows[i];
                                %>
                                <div class="col-md-4 col-sm-6">
                                    <div class="product-wrapper imgstyle">
                                        <img src="<%= Convert.ToString(item["imgpath"])==""?"assets/images/翻譯團隊banner.jpg":item["imgpath"] %>" alt="泰語翻譯 行情">

                                        <div class="product-detail">
                                            <a href="#">
                                                <p>姓名:<%=item["tname"] %></p>
                                                <p>姓別:<%=item["avater"].ToString() == "0" ? "男" : "女" %></p>
                                                <p>自我介紹: <%=item["descript"] %></p>

                                            </a>
                                        </div>
                                    </div>
                                </div>
                                <% 
                                    } %>
                            </div>
                        </div>
                        <!-- product-selection -->
                    </div>
                    <!-- right-bar -->
                </div>
            </div>
        </div>
        <section class="testimonial-two-section " style="margin-top: 10px; margin-left: 350px;">
            <div id="testimonial-carousel">
                <% 
                    int totalPage = Convert.ToInt32(Math.Ceiling(dtInfo.Rows.Count / 6M));
                    if (totalPage > 1)
                    {

                        if (page >= 1)
                        {
                %>
                <a class="left carousel-control" href="houguan-Thailand-ourteam.aspx?gid=<%=Request["gid"] %>&page=<%=page - 1 %>" role="button" data-slide="prev"><i class="fa fa-angle-left" aria-hidden="true"></i></a>
                <%
                    }

                    if (page < totalPage)
                    {
                %>
                <a class="right carousel-control" href="houguan-Thailand-ourteam.aspx?gid=<%=Request["gid"] %>&page=<%=page + 1 %>" role="button" data-slide="next"><i class="fa fa-angle-right" aria-hidden="true"></i></a>
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
    <uc1:mobiletop runat="server" ID="mobiletop" />

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
