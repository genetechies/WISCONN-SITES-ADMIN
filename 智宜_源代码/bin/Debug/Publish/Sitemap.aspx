<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sitemap.aspx.cs" Inherits="ZeroStudio.Web.sitemap_en" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc4" TagName="footer" %>
<%@ Register Src="Css.ascx" TagName="Css" TagPrefix="uc2" %>
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
    <title>網站地圖 - 智宜科技股份有限公司</title>
    <meta content="sata connector,usb connector" name="keywords" />
    <meta content="智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。" name="description" />

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
                        <div class="sitemap_box_h1"><a href="Index.aspx">首頁</a></div>
    <div class="sitemap_box_h1"><a href="About.aspx">公司簡介</a></div>
    <div class="sitemap_box_h1"><a href="Products.aspx">產品專區</a></div>
                        <div class="info">
                            <asp:Repeater ID="repParent" runat="server">
                                <ItemTemplate>
                                    <div class="sitemap_box_h2"><a href='<%#FormatLink(Eval("PC_Id")) %>'><%#Eval("PC_ClassName") %></a></div>
                                    <asp:Label ID="lblPCId" runat="server" Text='<%#Eval("PC_Id") %>' Visible="false"></asp:Label>
                                    <asp:Repeater ID="repChild" runat="server">
                                        <ItemTemplate>
                                            <div class="sitemap_box_h3"><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id") %>'><%#Eval("PC_ClassName") %></a></div>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                        <div class="sitemap_box_h1"><a href="Services.aspx">品質管理</a></div>
                        <div class="sitemap_box_h1"><a href="Contact.aspx">聯絡我們</a></div>
                        <div class="sitemap_box_h1"><a href="sitemap.aspx">網站地圖</a></div>
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


