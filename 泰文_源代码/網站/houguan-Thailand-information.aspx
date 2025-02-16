<%@ Page Language="C#" AutoEventWireup="true" CodeFile="houguan-Thailand-information.aspx.cs" Inherits="houguan_Thailand_informations" %>

<%@ Register Src="~/mobiletop.ascx" TagPrefix="uc1" TagName="mobiletop" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>

<!DOCTYPE html>
<html lang="en">

<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="后冠泰文翻譯社的翻譯資訊頁面提供最新的翻譯資訊，由后冠的各領域專業譯者提供多年翻譯經驗，加上各資訊管道蒐集而來的相關訊息組成。這不僅是后冠自身實績的側影，也是后冠悉心為泰文客戶著想的一面。">
    <title>后冠泰文翻譯社—為您提供各類泰文翻譯資訊</title>
    <meta name="keywords" content="后冠泰文翻譯社" />
    <meta name="description" content="后冠翻譯公司秉持著專業的態度，不斷精進提供最完善的影片翻譯服務，多年累積下來的經驗，希望與您分享，藉此讓更多人瞭解！提供了許多翻譯的相關文章包含各個語言翻譯、英文校稿知識…等，歡迎自由轉載(若為同業需簽定轉載同意書)，並請附上出處與官方超連結：" />

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

<body class="subPage teamPage">
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
    <!-- header-section -->
    <section class="header-title section-padding" style="background-image: url(assets/images/翻譯資訊詳細頁面banner.jpg);">
        <div class="container text-center">
            <h2 class="title">翻譯資訊</h2>
            <span class="sub-title">Home > Pages > Team</span>
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


                    </div>
                    <!-- left-bar -->
                </div>

                <div class="col-md-9">
                    <div class="right-bar">
                        <div class="product-selection">
                            <div><asp:Literal ID="ltArtListTitle" runat="server"></asp:Literal></div>
                            <div><asp:Literal ID="ltArtListDescription" runat="server"></asp:Literal></div>
                            <div class="row">
                                <%
                                    int page = 1;
                                    int pageCount = 0;
                                    if (!string.IsNullOrEmpty(Request["page"]))
                                    {
                                        page = Int32.Parse(Request["page"]);
                                    }
                                    page = page < 1 ? 1 : page;
                                    pageCount = page * 3;

                                    int tn = dtInfo.Rows.Count > pageCount ? pageCount : dtInfo.Rows.Count;
                                    var pageNum = (page - 1) * 3;

                                    for (int i = (page - 1) * 3; i < tn; i++)
                                    {
                                        var item = dtInfo.Rows[i];
                                %>
                                <!-- <div class="col-sm-7">-->
                                <div class="content">
                                    <h3><a href="houguan-Thailand-information-info.aspx?id=<%= item["D_Id"] %>"><%= item["D_Title"]%></a></h3>
                                    <p style="margin-left: 790px;"><%=Convert.ToDateTime(item["D_Time"]).ToString("yyyy-MM-dd")%></p>
                                    <p><span></span><%=Utils.SubString(item["D_Description"],100,"...")%></p>
                                </div>
                                <% 
                                    }
                                %>
                            </div>
                        </div>
                        <!-- product-selection -->
                    </div>
                    <!-- right-bar -->
                </div>
            </div>
        </div>
        <section class="testimonial-two-section " style="margin-top: 100px; margin-left: 350px;">
            <div id="testimonial-carousel">

                 <% 
                    int totalPage = Convert.ToInt32(Math.Ceiling(dtInfo.Rows.Count / 3M));
                    if (totalPage > 1)
                    {

                        if (page >= 1)
                        {
                %>
                <a class="left carousel-control"   href="houguan-Thailand-information.aspx?cid=<%=Request["gid"] %>&page=<%=page - 1 %>" role="button" data-slide="prev"><i class="fa fa-angle-left" aria-hidden="true"></i></a>
                <%
                    }

                    if (page < totalPage)
                    {
                %>
                <a class="right carousel-control" href="houguan-Thailand-information.aspx?cid=<%=Request["gid"] %>&page=<%=page + 1 %>" role="button" data-slide="next"><i class="fa fa-angle-right" aria-hidden="true"></i></a>
                <%
                        }
                    }
                %>
                <h5>&nbsp;</h5>
            </div>
        </section>
    </section>
    <!-- partner-page-section -->


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
