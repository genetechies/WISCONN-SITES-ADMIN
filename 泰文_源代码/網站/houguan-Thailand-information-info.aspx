<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houguan-Thailand-information-info.aspx.cs" Inherits="houguan_Thailand_informations_detail" %>

<%@ Register Src="~/mobiletop.ascx" TagPrefix="uc1" TagName="mobiletop" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>



<!DOCTYPE html>
<html lang="zh-hant">

<head >
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title><%=Title %></title>
    <meta name="description" content="<%=model.D_Description %>" />
    <meta name="keywords" content="<%=model.D_Keyword %>" />
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
    <style type="text/css">
<!--
.content img {
overflow-clip-margin: content-box;
overflow: clip;
width: auto !important;
}
-->
</style>
</head>

<body class="subPage aboutPage">
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

    <section class="header-title section-padding" style="background-image: url(assets/images/客戶實績banner.jpg);">
        <div class="container text-center">
            <h2 class="title">詳細頁</h2>
            <span class="sub-title">Home > contact</span>
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
                                    <a href="houguan-Thailand-information.aspx?cid=<%=dtClass.Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%>
                                        <span class="pull-right"><i class="fa fa-caret-right" aria-hidden="true"></i></span>
                                    </a>
                                </li>
                                <%} %>
                            </ul>
                        </div>




                        <div class="wrapper-contant last-content">
                            <!--<h4>BY SIZE</h4>-->

                            <!--<ul>
                                    <li>
                                        <a href="#">
                                            X - Small
                                            <span class="pull-right">(20)</span>
                                        </a>
                                    </li>

                                    <li>
                                        <a href="#">
                                            Small
                                            <span class="pull-right">(65)</span>
                                        </a>
                                    </li>

                                    <li>
                                        <a href="#">
                                            Medium
                                            <span class="pull-right">(87)</span>
                                        </a>
                                    </li>
                                </ul>-->
                        </div>
                    </div>
                    <!-- left-bar -->
                </div>
                <!--<section class="about-office-section">-->
                <div class="container" style="margin-bottom: 20px; width:72%; float:right;">
                    <div class="row">
                        <!--<div class="col-md-6">-->
                        <div class="content">
                            <h3><%=model.D_Title %></h3>
                            <p style="text-align:center;">作者：<%=model.D_Author %> 　　加入時間：<%=model.D_Time.ToString("yyyy-MM-dd") %> 　　點擊次數：<%=model.D_Num %>次！</p>
                            <%=model.D_Content %>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </section>

    <!-- project-section -->

		<!-- shop-page -->

    <!--<section class="multi-section section-padding">
			<div class="container">
				<div class="row">
					<div class="col-md-3">
						<div class="faq-content">

						</div>

					</div>

					<div class="col-md-6">
						<div class="client-section">
							<h3>客戶實績</h3>

							<ul class="logo">
								<li class="wow fadeIn"><img src="assets/images/client/1.png" alt=""></li>

								<li class="wow fadeIn" data-wow-delay="0.2s"><img src="assets/images/client/2.png" alt=""></li>

								<li class="wow fadeIn" data-wow-delay="0.3s"><img src="assets/images/client/3.png" alt=""></li>

								<li class="wow fadeIn" data-wow-delay="0.4s"><img src="assets/images/client/4.png" alt=""></li>

								<li class="wow fadeIn" data-wow-delay="0.5s"><img src="assets/images/client/5.png" alt=""></li>

								<li class="wow fadeIn" data-wow-delay="0.6s"><img src="assets/images/client/6.png" alt=""></li>

								<li class="wow fadeIn" data-wow-delay="0.7s"><img src="assets/images/client/7.png" alt=""></li>
							</ul>
						</div>
					</div>
				</div>
			</div>
		</section>-->
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

    <script src="assets/js/script.js"></script>
</body>

</html>
