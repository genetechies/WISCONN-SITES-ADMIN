<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connector-Products-sublist.aspx.cs" Inherits="ZeroStudio.Web.Products_sublist_en" %>

<%@ Register Src="~/Header-en.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/Footer-en.ascx" TagPrefix="uc4" TagName="footer" %>
<%@ Register Src="Css-en.ascx" TagName="Css" TagPrefix="uc2" %>
<%@ Register Src="js-en.ascx" TagName="js" TagPrefix="uc3" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<%@ Register Src="~/ProClass.ascx" TagPrefix="uc1" TagName="ProductClass" %>


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
    <title>Connector Product for <%=name %> </title>  
    <meta content="<%=name %>" name="keywords" />
<meta content=" Wisconn connector manufacturer is a company that provides various connectors, such as <%=name %> for customers and suppliers." name="description" name="description" />

    <!-- Stylesheets-->

    <uc2:Css ID="Css1" runat="server" />
    <link rel="stylesheet" href="content/css/mediaelementplayer.css" />


    <link rel="stylesheet" href="content/css/style2.css" type="text/css" media="all" />
    <link rel="stylesheet" href="content/css/zoomify.css" type="text/css" media="all" />
    <link rel="stylesheet" href="content/css/style-hdq.css" />
    <style>
        #sidebar a {
            color: #555555;
        }

        #sidebar .subnav li a {
            color: #fff;
        }

        .pages {
            color: #999;
            overflow: auto;
        }

            .pages a, .pages .cpb {
                text-decoration: none;
                float: left;
                padding: 10px 5px;
                border: 1px solid #ddd;
                background: #fff;
                margin: 0 4px;
                font-size: 13px;
                color: #444444;
                height: 43px;
                min-width: 43px;
                display: inline-block;
                border-radius: 15%;
                text-align: center;
            }

                .pages a:hover {
                    background-color: #1ccdca;
                    color: #fff;
                    border: 1px solid #1ccdca;
                    text-decoration: none;
                }

            .pages .cpb {
                font-weight: bold;
                color: #fff;
                background: #1ccdca;
                border: 1px solid #1ccdca;
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
        <uc1:header ID="header" runat="server" PageID="product" />
        <div class="banner">
            <img src="content/images/Products-banner.jpg" alt="connector supplier, connector manufacturer, FPC connector">
        </div>
        <form id="form1" runat="server">

            <!-- Our Blog Grids -->
            <section class="content_section">
                <div class="content row_spacer">
                    <div class="main_title centered upper">
                        <h2><span class="line"><span class="dot"></span></span>Connector Product</h2>
                    </div>

                    <!-- All Content -->
                    <div class="content_spacer about clearfix">
                        <uc1:ProductClass runat="server" ID="ProductClass" />
                        <!-- sidebar -->

                        <!-- End sidebar -->

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
                                    <%=nav %>
                                </ul>
                                <div id="emailBox">
                                    <img src="Content/images/email_32.png"/>
                                    <a href="Connector-Contact.aspx">
                                        <span>
                                            Please contact us for more product information.
                                        </span>
                                    </a>
                                </div>
                                <asp:Repeater ID="childList" runat="server">
                                    <ItemTemplate>
                                        <div class="col-md-4">
                                            <div class="service_box">
                                                <div class="icon">
                                                    <a href='javascript:void(0)' onclick="openDetail('<%#Eval("P_Id") %>','<%#Eval("P_Model") %>')">
                                                        <img src='<%#Eval("P_PhotoUrl") %>' alt='<%#Eval("P_Model") %>' /></a>
                                                </div>
                                                <div class="service_box_con">
                                                    <h3 class="centered" style="margin-top: 50px">
                                                        <div class="upkey"><%#Eval("UpKey") %></div>
                                                        <a href='javascript:void(0)' onclick="openDetail('<%#Eval("P_Id") %>','<%#Eval("P_Model") %>','<%#Eval("P_Doc") %>')"><%#Eval("P_Model") %></a>
                                                        <div class="downkey"><%#Eval("DownKey") %></div>
                                                        <%--<a onclick="window.open('/<%#Eval("P_Doc") %>', '_blank', 'width=750,height=600,top=100px,left=0px');"><%#Eval("P_Model") %></a>--%>
                                                    </h3>
                                                    <%-- <ul class="desc">
                                                        <li><a href='Connector-Products-detail.aspx?P_Id=<%#Eval("P_Id") %>' target="_blank"><span><%#Eval("P_Model") %></span></a></li>
                                                    </ul>--%>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>
                                <asp:Repeater ID="cateList" runat="server">
                                    <ItemTemplate>
                                        <div class="col-md-4">
                                            <div class="service_box">
                                                <div class="icon">
                                                    <a href='Connector-Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'>
                                                        <img src='<%#Eval("PC_ImageUrl") %>' alt='<%#Eval("PC_ClassName_En") %>' /></a>
                                                </div>
                                                <div class="service_box_con">
                                                    <h3 class="centered" style="margin-top: 50px">
                                                        <a href='Connector-Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><%#Eval("PC_ClassName_En") %></a>
                                                    </h3>
                                                    <%-- <ul class="desc">
                                                        <li><a href='Connector-Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><span><%#Eval("PC_ClassName_En") %></span></a></li>
                                                    </ul>--%>
                                                </div>
                                            </div>
                                        </div>
                                    </ItemTemplate>
                                </asp:Repeater>




                            </div>
                            <div id="pagination" class="pagination">
                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" ShowFirstLast="false" PageSize="12" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                                    NextPageText="&rarr;" PrevPageText="&larr;" OnPageChanged="AspNetPager1_PageChanged" CssClass="pages">
                                </webdiyer:AspNetPager>
                            </div>
                            <!-- End Content Block -->

                        </div>
                        <!-- All Content -->
                    </div>
            </section>
            <!-- End Our Blog Grids -->
        </form>


        <!-- footer -->
        <uc4:footer ID="footer1" runat="server" />

        <a href="#" class="hm_go_top">Top</a>
    </div>
    <!-- End wrapper -->

    <div class="bigimage_popup dn">
        <button class="mfp-close" onclick="javascript: $('#lookBigImage').hide();">×</button>
        <div class="bigimage">
            <img id="imgMember" src="#" >
        </div>
    </div>


    <uc3:js ID="js1" runat="server" />

    <script type="text/javascript" src="content/js/zoomify.js"></script>
    <script src="Content/js/layer/layer.js"></script>



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

            //$(function () {
            //    $(".icon img").click(function () {
            //        $('.bigimage_popup').removeClass('dn')
            //        //pic src
            //        var src = $(this).attr("src");
            //        var alt = $(this).attr("alt");

            //        $('#imgMember').attr({ "src": src, "alt": alt });

            //    });

            //});
            //$('.bigimage_popup .mfp-close').on('click', function () {
            //    $('.bigimage_popup').addClass('dn')
            //});


        });

        function openDetail(id, name, url) {
            if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
                location.href = "Connector-Products-detail1.aspx?P_Id=" + id;
            } else {
                //layer.open({
                //    type: 2,
                //    title: name,
                //    shadeClose: true,
                //    shade: false,
                //    maxmin: true, //开启最大化最小化按钮
                //    area: ['750px', '600px'],
                //    content: "Products-detail1.aspx?P_Id=" + id
                //});
                window.open("Connector-Products-detail.aspx?P_Id=" + id, name + ",_blank", 'width=750,height=600,top=100px,left=' + (window.screen.availWidth - 800) + 'px');
            }
        }
    </script>


</body>
</html>




