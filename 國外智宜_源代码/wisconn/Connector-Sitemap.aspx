<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connector-Sitemap.aspx.cs" Inherits="ZeroStudio.Web.sitemap_en" %>

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
    <title>Wisconn Connector Manufacturer | Connector Supplier - Sitemap</title>
    <meta name="Keywords" content="connector supplier, FPC connector" />
    <meta name="description" content="The site map may assist you in locating the target product category quickly, such as the RJ45 connector, USB connector, and FPC connector. You may also go to the target page directly. Wisconn connector manufacturer is a company that provides various connectors, such as  RJ45, FPC, USB for customers and suppliers." />

    <!-- Don't forget to set your site up: http://google.com/webmasters -->
    <meta name="google-site-verification" content="" />
    <meta name="Copyright" content="" />
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <uc2:Css ID="Css1" runat="server" />

    <%--<link rel="stylesheet" href="css/reset.css" type="text/css" charset="utf-8" />--%>
    <%--<link rel="stylesheet" href="css/general.css" type="text/css" charset="utf-8" />--%>
    <link rel="stylesheet" href="css/style.css" type="text/css" charset="utf-8" />
    <!-- Menu -->
    <link rel="stylesheet" type="text/css" href="css/superfish.css" media="screen" />
</head>

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
        <uc1:header ID="header1" runat="server"  />

        <!-- OWL Slider -->
        <div id="enar_owl_slider" class="owl-carousel">
            <div class="item">
                <img src="content/images/sliders/owl/slide1.jpg" alt="connector supplier">
                <div class="owl_slider_con">
                   				 <!--	<span class="owl_text_a">
				    <span>
						<span>Enar Theme IS The Best</span>
					<a href="#"><span><i class="ico-angle-right"></i></span></a>
				    </span>
				</span> -->
				<span class="owl_text_a"><span>WE  CONNECT QUALITY AND CUSTOMER-ORIENTATION</span></span>  
			 <!--	 <span class="owl_text_c"><span>Lorem Ipsum Fully Responsive Design Lorem Ipsum Fully Responsive Design</span></span>-->
                </div>
            </div>
            <div class="item">
                <img src="content/images/sliders/owl/slide2.jpg" alt="FPC connector">
                <div class="owl_slider_con">
                   				 <!--	<span class="owl_text_a">
				    <span>
						<span>Enar Theme IS The Best</span>
					<a href="#"><span><i class="ico-angle-right"></i></span></a>
				    </span>
				</span> -->
				<span class="owl_text_a"><span>WE  CONNECT QUALITY AND CUSTOMER-ORIENTATION</span></span>  
			 <!--	 <span class="owl_text_c"><span>Lorem Ipsum Fully Responsive Design Lorem Ipsum Fully Responsive Design</span></span>-->
                </div>
            </div>
            <div class="item">
                <img src="content/images/sliders/owl/slide3.jpg" alt="connector supplier">
                <div class="owl_slider_con">
                   				 <!--	<span class="owl_text_a">
				    <span>
						<span>Enar Theme IS The Best</span>
					<a href="#"><span><i class="ico-angle-right"></i></span></a>
				    </span>
				</span> -->
				<span class="owl_text_a"><span>WE  CONNECT QUALITY AND CUSTOMER-ORIENTATION</span></span>  
			 <!--	 <span class="owl_text_c"><span>Lorem Ipsum Fully Responsive Design Lorem Ipsum Fully Responsive Design</span></span>-->
                    </span>
                </div>
            </div>

            <div class="item">
                <img src="content/images/sliders/owl/slide4.jpg" alt="FPC connector">
                <div class="owl_slider_con">
                    				 <!--	<span class="owl_text_a">
				    <span>
						<span>Enar Theme IS The Best</span>
					<a href="#"><span><i class="ico-angle-right"></i></span></a>
				    </span>
				</span> -->
				<span class="owl_text_a"><span>WE  CONNECT QUALITY AND CUSTOMER-ORIENTATION</span></span>  
			 <!--	 <span class="owl_text_c"><span>Lorem Ipsum Fully Responsive Design Lorem Ipsum Fully Responsive Design</span></span>-->
                </div>
            </div>
        </div>
        <!-- End OWL Slider -->

        <form id="form2" runat="server">
            <div id="container">
                <div id="content">
                    <h1>Sitemap</h1>
                    <div class="sitemap_box">
                        <div class="sitemap_box_h1"><a href="Connector-Index.aspx">Home</a></div>
                        <div class="sitemap_box_h1"><a href="Connector-About.aspx">Company Profile</a></div>
                        <div class="sitemap_box_h1"><a href="Connector-Products.aspx">Connector Product</a></div>
                        <div class="info">
                            <asp:Repeater ID="repParent" runat="server">
                                <ItemTemplate>
                                    <div class="sitemap_box_h2"><a href='<%#FormatLink(Eval("PC_Id")) %>'><%#Eval("PC_ClassName_En") %></a></div>
                                    <asp:Label ID="lblPCId" runat="server" Text='<%#Eval("PC_Id") %>' Visible="false"></asp:Label>
                                    <asp:Repeater ID="repChild" runat="server">
                                        <ItemTemplate>
                                            <div class="sitemap_box_h3"><a href='Connector-Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><%#Eval("PC_ClassName_En") %></a></div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="sitemap_box_h1"><a href="Connector-Services.aspx">Quality Management</a></div>
                        <div class="sitemap_box_h1"><a href="Connector-Contact.aspx">Contact Us</a></div>
                        <div class="sitemap_box_h1"><a href="Connector-sitemap.aspx">Site map</a></div>
                    </div>
                </div>
                <!-- end content -->
            </div>
        </form>
        <!-- footer -->
        <uc4:footer ID="footer1" runat="server" />
        <!-- End footer -->
        <a href="#0" class="hm_go_top"></a>
    </div>
    <!-- End wrapper -->

    <uc3:js ID="js1" runat="server" />

</body>
</html>


