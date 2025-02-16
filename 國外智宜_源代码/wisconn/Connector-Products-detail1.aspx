<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connector-Products-detail1.aspx.cs" Inherits="ZeroStudio.Web.Products_detail_en1" %>

<%@ Register Src="~/Header-en.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/Footer-en.ascx" TagPrefix="uc4" TagName="footer" %>
<%@ Register Src="Css-En.ascx" TagName="Css" TagPrefix="uc2" %>
<%@ Register Src="js-en.ascx" TagName="js" TagPrefix="uc3" %>

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
    <title>Connector Product for <%=title %> </title>

    <!-- Important stuff for SEO, don't neglect. (And don't dupicate values across your site!) -->
    <uc2:Css ID="Css1" runat="server" />
    <link rel="stylesheet" href="content/css/mediaelementplayer.css" />


    <link rel="stylesheet" href="content/css/style2.css" type="text/css" media="all" />
    <link rel="stylesheet" href="content/css/zoomify.css" type="text/css" media="all" />
    <style>
        #sidebar a {
            color: #555555;
        }

        #sidebar .subnav li a {
            color: #fff;
        }
        .productModel{
                background: url(../images/16.gif) 0px 2px no-repeat;
                font-size: 12px;
                color: #339;
                padding-left: 12px;
                font-weight: bold;
                margin: 4px 0 2px 5px;
        }
    </style>
</head>

<!-- Class ( site_boxed - dark - preloader1 - preloader2 - preloader3 - light_header - dark_sup_menu - menu_button_mode - transparent_header - header_on_side ) -->
<body class="preloader3 light_header">
   

    <div id="main_wrapper">

        <form id="form1" runat="server">
            <!-- Our Blog Grids -->
            <section class="content_section">
                <div class="content row_spacer" style="padding:0">
                    <!-- All Content -->
                    <div class="content_spacer about clearfix" style="padding:0">
                        <div class="content_block col-md-9 f_right">
                            <div class="icon_boxes_con product_boxes style1 clearfix">
                                <ul class="crumb">
                                    <li>
                                        <a href="/Connector-Index.aspx">Home</a>
                                        <i class="ico-angle-right"></i>
                                    </li>
                                    <li>
                                        <a href="/Connector-Products.aspx">Connector Product</a>
                                        <i class="ico-angle-right"></i>
                                    </li>
                                    <li>
                                        <asp:Literal ID="ltlPName" runat="server"></asp:Literal>
                                    </li>
                                </ul>
                                <div class="product-details">
                                    <div class="col-md-12 productModel">Product Model</div>
                                    <div  class="col-md-12"><asp:Literal ID="ltlModel" runat="server"></asp:Literal></div>
                                    <iframe id="frameDetail" runat="server" frameborder="0" width="550" height="400" scrolling="auto"></iframe>
                                </div>

                            </div>

                        </div>
                        <!-- End Content Block -->

                    </div>
                    <!-- All Content -->
                </div>
            </section>
            <!-- End Our Blog Grids -->
        </form>

        <a href="#" class="hm_go_top">Top</a>
    </div>
    <!-- End wrapper -->

    <uc3:js ID="js1" runat="server" />

   


</body>
</html>
