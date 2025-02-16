<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connector-Products.aspx.cs" Inherits="ZeroStudio.Web.Products_en" %>

<%@ Import Namespace="System.Linq" %>
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

    <!-- Important stuff for SEO, don't neglect. (And don't dupicate values across your site!) -->
    <title>Wisconn Connector Manufacturer | Connector Supplier - Connector Product</title>
    <meta name="Keywords" content="connector manufacturer,FPC connector" />
    <meta name="description" content="Wisconn(connector supplier,connector manufacturer)  provides a variety of connector products such as RJ45 connectors, USB connectors, and FPC connectors and ensures the quality of these products offered.Given our strong foundation in the electronics industry over the years and our experienced development team." />

    <uc2:Css ID="Css1" runat="server" />
    <link rel="stylesheet" href="content/css/mediaelementplayer.css" />
    <link rel="stylesheet" href="content/css/style-hdq.css" />



    <style>
        #sidebar a {
            color: #555555;
        }

        #sidebar .subnav li a {
            color: #fff;
        }

        #detailHeader {
            list-style: url("Content/images/liDotIcon.png");
            line-height: 2;
            position: relative;
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
            <img src="Content/images//Products-banner.jpg" alt="FPC connector">
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
                        <div class="product clearfix">
                            <div class="p_left">
                                <div class="p_title">
                                    <p class="toggleMenu">Connector Product</p>
                                </div>
                                <ul class="p_toggle list_drop dn">
                                    <%
                                        var parents = proClassList.Where(w => w.PC_ParentID == 0);
                                        foreach (var parent in parents)
                                        {%>
                                    <li>
                                        <div class="p_category">
                                            <span class="label">
                                                <%=parent.PC_ClassNameEn %></span>
                                            <span class="arrow up"></span>
                                        </div>
                                        <span class="no">
                                            <ul class="list_menu">
                                                <% var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id);
                                                    foreach (var child in childs)
                                                    {
                                                %>
                                                <li><a href='Connector-Products-sublist.aspx?PC_Id=<%=child.PC_Id%>'><i></i><%=child.PC_ClassNameEn %> </a></li>
                                                <%
                                                    }
                                                %>
                                            </ul>
                                        </span>
                                    </li>
                                    <% }
                                    %>
                                </ul>
                            </div>
                        </div>



                        <ul class="crumb">
                            <li>
                                <a href="/Connector-Index.aspx">Home</a>
                                <i class="ico-angle-right"></i>
                            </li>
                            <li>
                                <a href="/Connector-Products.aspx">Connector Product</a>
                            </li>
                        </ul>

                        <!-- sidebar -->
                        <aside id="sidebar" class="col-md-3 right_sidebar right_sidebar_product">
                             
                            <h1 class="title">CONNECTOR PRODUCT</h1>
                            <ul>
                                <%
                                    foreach (var parent in parents)
                                    {%>

                                <li>
                                    <a href='Connector-Products-list.aspx?PC_Id=<%=parent.PC_Id %>'><span><%=parent.PC_ClassNameEn %></span></a>
                                    <ul class="subnav">
                                        <% 
                                            var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id);
                                            foreach (var child in childs)
                                            {
                                        %>
                                        <li><a href='Connector-Products-sublist.aspx?PC_Id=<%=child.PC_Id%>'><%=child.PC_ClassNameEn %> </a></li>
                                        <%
                                            }
                                        %>
                                    </ul>
                                </li>
                                <% }
                                %>
                            </ul>
                            <a href="http://molex.wisconn.com.tw/Index-en.aspx" > <img src="../Content/images/MOLEX.png" skyle="width: 325px ; height: 100px;" /  alt="connector manufacturer" ></a>
                            <a href="http://molex.wisconn.com.tw/Index-en.aspx" >Cannot find the products you need? <br> Please click here. </a>
                        </aside>

                        <!-- End sidebar -->

                        <div class="content_block col-md-9 f_right">
                            <div id="emailBox">
                                <img src="Content/images/email_32.png"/>
                                <a href="Connector-Contact.aspx">
                                    <span>
                                        Please contact us for more product information.
                                    </span>
                                </a>
                            </div>
                            <div class="icon_boxes_con product_boxes style1 hover style02 clearfix">
                                <%
                                    foreach (var parent in parents)
                                    {%>
                                <div class="col-md-4">
                                    <div class="service_box">
                                        <div class="icon">
                                            <a href='Connector-Products-list.aspx?PC_Id=<%=parent.PC_Id %>'>
                                                <img src='<%=parent.PC_ImageUrl %>' alt='<%=parent.PC_ClassNameEn%>' /></a>
                                        </div>
                                        <div class="service_box_con">
                                            <h3 class="centered">
                                                <a href='Connector-Products-list.aspx?PC_Id=<%#Eval("PC_Id") %>'><%#Eval("PC_ClassName_En") %></a><asp:Label ID="lblPCId" runat="server" Text='<%#Eval("PC_Id") %>' Visible="false"></asp:Label></h3>
                                                <div>
                                                    
                                                    <h3 class="centered" style="margin-bottom: 5px; ">
                                                        <%=parent.PC_ClassNameEn %>
                                                    </h3>
                                                    <ul class="desc">
                                                        <% 
                                                            var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id).OrderBy(w => w.PC_SortKey).Take(4);
                                                            foreach (var child in childs)
                                                            {
                                                        %>
                                                            <li><a href='Connector-Products-sublist.aspx?PC_Id=<%=child.PC_Id %>'><span><%=child.PC_ClassNameEn %></span></a></li>
                                                        <%
                                                        }
                                                        %>
                                                    </ul>
                                                </div>
                                        </div>
                                    </div>
                                </div>
                                <% }
                                %>
                            </div>
                        </div>
                        <!-- End Content Block -->

                    </div>
                    <!-- All Content -->
                </div>
            </section>
        </form>
        <!-- End Our Blog Grids -->


        <!-- footer -->
        <uc4:footer ID="footer1" runat="server" />

        <a href="#" class="hm_go_top">Top</a>
    </div>
    <!-- End wrapper -->

    <uc3:js ID="js1" runat="server" />
    <!-- End wrapper -->

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
