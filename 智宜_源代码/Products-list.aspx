<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products-list.aspx.cs" Inherits="ZeroStudio.Web.Products_list_en" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc4" TagName="footer" %>
<%@ Register Src="Css.ascx" TagName="Css" TagPrefix="uc2" %>
<%@ Register Src="js-en.ascx" TagName="js" TagPrefix="uc3" %>
<%@ Register Src="~/ProClass.ascx" TagPrefix="uc1" TagName="ProClass" %>

<!doctype html>
<!--[if lt IE 7 ]> <html class="ie ie6 ie-lt10 ie-lt9 ie-lt8 ie-lt7 no-js" lang="en"> <![endif]-->
<!--[if IE 7 ]>    <html class="ie ie7 ie-lt10 ie-lt9 ie-lt8 no-js" lang="en"> <![endif]-->
<!--[if IE 8 ]>    <html class="ie ie8 ie-lt10 ie-lt9 no-js" lang="en"> <![endif]-->
<!--[if IE 9 ]>    <html class="ie ie9 ie-lt10 no-js" lang="en"> <![endif]-->
<!--[if gt IE 9]><!-->
<html class="no-js" lang="en">
<!--<![endif]-->
<!-- the "no-js" class is for Modernizr. -->
<head>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

    <!-- Important stuff for SEO, don't neglect. (And don't dupicate values across your site!) -->
    <%--<title>Blog List Sidebar Left | Enar</title>--%>
    <meta name="author" content="" />
      <title><%=title %></title>
    <meta content="<%=name %>" name="keywords" />
<meta content=" 智宜科技為您提供<%=name%>，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。" name="description" name="description" />

    <link rel="stylesheet" href="content/css/style-hdq.css" />

    <uc2:Css ID="Css1" runat="server" />
    <style>
        #sidebar a {
            color: #555555;
        }

        #sidebar .subnav li a {
            color: #fff;
        }
    </style>
</head>

<!-- Class ( site_boxed - dark - preloader1 - preloader2 - preloader3 - light_header - dark_sup_menu - menu_button_mode - transparent_header - header_on_side ) -->
<body class="preloader3 light_header">
    <div id="preloader">
        <div class="spinner">
            <div class="sk-dot1"></div>
            <div class="sk-dot2"></div>
            <div class="rect3"></div>
            <div class="rect4"></div>
            <div class="rect5"></div>
        </div>
    </div>

    <div id="main_wrapper">
        <uc1:header ID="header" runat="server"  PageID="product"/>

        <div class="banner">
            <img src="content/images/Products-banner.jpg" alt="FPC connector">
        </div>
        <form id="form1" runat="server">

            <!-- Our Blog Grids -->
            <section class="content_section">
                <div class="content row_spacer">
                    <div class="main_title centered upper">
                        <h2><span class="line"><span class="dot"></span></span>產品專區</h2>
                    </div>

                    <!-- All Content -->
                    <div class="content_spacer about clearfix">
                        <uc1:ProClass runat="server" ID="ProClass" />
                        <!-- End sidebar -->

                        <div class="content_block col-md-9 f_right">
                            <div class="icon_boxes_con product_boxes style1 clearfix">
                                <ul class="crumb clear">
                                    <li>
                                        <a href="/Index.aspx">首頁</a>
                                        <i class="ico-angle-right"></i>
                                    </li>
                                    <li>
                                        <a href="/Products.aspx">產品專區</a>
                                        <i class="ico-angle-right"></i>
                                    </li>
                                    <li>
                                        <a href="/Products-list.aspx?PC_Id=<%=model.PC_Id %>"><%=model.PC_ClassName %></a>
                                    </li>
                                </ul>

                                <div id="emailBox">
                                    <img src="Content/images/email_32.png"/>
                                    <a href="Contact.aspx">
                                        <span>
                                            請聯繫我們獲取更多產品資訊。
                                        </span>
                                    </a>
                                </div>

                                <asp:Repeater ID="childList" runat="server">
                                    <ItemTemplate>
                                        <div class="col-md-4">
                                            <div class="service_box">
                                                <div class="icon">
                                                    <a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><img src='<%#Eval("PC_ImageUrl") %>' alt='<%#Eval("PC_ClassName") %>' /></a>
                                                </div>
                                                <div class="service_box_con">
                                                    <h3 class="centered" style="margin-top: 50px">
                                                        <a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><%#Eval("PC_ClassName") %></a></h3>
                                                   <%-- <ul class="desc">
                                                        <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><span><%#Eval("PC_ClassName") %></span></a></li>
                                                    </ul>--%>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </div>
                        </div>



                        <%--     <div id="pagination" class="pagination">
                            <ul class="clearfix">
                                <li class="prev_pagination"><a href="#"><i class="ico-arrow-left4"></i></a></li>
                                <li class="active"><a href="#">1</a></li>
                                <li><a href="#">2</a></li>
                                <li><a href="#">3</a></li>
                                <li class="next_pagination"><a href="#"><i class="ico-arrow-right4"></i></a></li>
                            </ul>
                        </div>--%>
                    </div>
                    <!-- End Content Block -->

                </div>
                <!-- All Content -->
            </section>
        </form>
        <!-- End Our Blog Grids -->


        <!-- footer -->
        <uc4:footer ID="footer1" runat="server" />

        <a href="#" class="hm_go_top">Top</a>
    </div>
    <!-- End wrapper -->
    <uc3:js ID="js1" runat="server" />

    <script type="text/javascript">
        $(document).ready(function () {

            $('.p_title').on('click', function () {
                $(this).siblings('ul.p_toggle').toggleClass('dn')
            })

            $("ul.p_toggle li > div.p_category").click(function () {

                var arrow = $(this).find("span.arrow");

                if (arrow.hasClass("up")) {
                    arrow.removeClass("up");
                    arrow.addClass("down");
                } else if (arrow.hasClass("down")) {
                    arrow.removeClass("down");
                    arrow.addClass("up");
                }

                $(this).parent().find("ul.list_menu").slideToggle();
            });
        });
    </script>


</body>
</html>
