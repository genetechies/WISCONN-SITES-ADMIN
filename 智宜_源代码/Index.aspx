<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="ZeroStudio.Web.Index_en" %>
<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc4" TagName="footer" %>
<%@ Register src="Css.ascx" tagname="Css" tagprefix="uc2" %>
<%@ Register src="js-en.ascx" tagname="js" tagprefix="uc3" %>

<!doctype html>
<!--[if lt IE 7 ]> <html class="ie ie6 ie-lt10 ie-lt9 ie-lt8 ie-lt7 no-js" lang="en"> <![endif]-->
<!--[if IE 7 ]>    <html class="ie ie7 ie-lt10 ie-lt9 ie-lt8 no-js" lang="en"> <![endif]-->
<!--[if IE 8 ]>    <html class="ie ie8 ie-lt10 ie-lt9 no-js" lang="en"> <![endif]-->
<!--[if IE 9 ]>    <html class="ie ie9 ie-lt10 no-js" lang="en"> <![endif]-->
<!--[if gt IE 9]><!--><html class="no-js" lang="en"><!--<![endif]-->
<!-- the "no-js" class is for Modernizr. --> 
<head>

	<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	
	<!-- Important stuff for SEO, don't neglect. (And don't dupicate values across your site!) -->
	 <title>智宜科技為亞洲最專業連接器廠商 - 智宜科技股份有限公司</title>
    <meta content="連接器,FPC連接器" name="keywords" />
    <meta content="智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。" name="description" />

	
	<uc2:Css ID="Css1" runat="server" />
    <style type="text/css">
        .table-striped tbody tr:nth-child(even) td,
        .table-striped tbody tr:nth-child(even) th {background-color:#e7e7e7;}
        .table-striped tbody tr:nth-child(odd) td,
        .table-striped tbody tr:nth-child(odd) th {background-color:white;}

    </style>
</head>

<!-- Class ( site_boxed - dark - preloader1 - preloader2 - preloader3 - light_header - dark_sup_menu - menu_button_mode - transparent_header - header_on_side ) -->
<body class="preloader3 light_header">
<div id="preloader">
	<div class="spinner">
		<div class="sk-dot1"></div><div class="sk-dot2"></div>
		<div class="rect3"></div><div class="rect4"></div>
		<div class="rect5"></div>
	</div>
</div>

<div id="main_wrapper">
	 <uc1:header ID="header" runat="server" PageID="index"/>

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
		    <img src="content/images/sliders/owl/slide2.jpg" alt="connector manufacturer">
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
			</div>
	    </div>

	    <div class="item">
		    <img src="content/images/sliders/owl/slide4.jpg" alt="connector manufacturer">
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
	
	<!-- Intro Banner -->
	<!-- <div class="welcome_banner full_colored">
	    <div class="content clearfix">
		    <h3>Welcome To Our Site</h3>
		<span class="intro_text">There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour randomised words which don't look even slightly believable If you are going to use a passage of Lorem Ipsum.</span>
	    </div>
	</div>     -->
	<!-- End Intro Banner -->
    <form id="form1" runat="server" >
	
	<!-- Icon Boxes Style 1 A -->
	<section class="content_section">
		<div class="container icons_spacer">
			<!--<div class="main_title centered upper">
				<h2><span class="line"><span class="dot"></span></span>OUR PRICE</h2>
			</div>
            
			<div class="icon_boxes_con style1 hover clearfix">
                <table class="table table-striped" style="font-size: 14px" >
                    <tr>
                        <td><h3 class="centered" style="font-size:17px">Reference Price</h3></td>
                        <td><h3 class="centered" style="font-size:17px">Minimum Quantity</h3></td>
                        <td><h3 class="centered" style="font-size:17px">Unit: USD/EA</h3></td>
                    </tr>
                    <tr>
                        <td>SFP CONNECTOR</td>
                        <td style="text-align:center">2,000</td>
                        <td style="text-align:center">$0.22-1.66</td>
                    </tr>
                    <tr>
                        <td>RJ CONNECTOR</td>
                        <td style="text-align:center">2,000</td>
                        <td style="text-align:center">$0.18-1.30</td>
                    </tr>
                    <tr>
                        <td>FPC CONNECTOR</td>
                        <td style="text-align:center">2,000</td>
                        <td style="text-align:center">$0.07-0.23</td>
                    </tr>
                    <tr>
                        <td>USB 2.0 CONNECTOR</td>
                        <td style="text-align:center">2,000</td>
                        <td style="text-align:center">$0.06-0.11</td>
                    </tr>
                    <tr>
                        <td>SATA CONNECTOR</td>
                        <td style="text-align:center">2,000</td>
                        <td style="text-align:center">$0.21-0.49</td>
                    </tr>
                    <tr>
                        <td>HDMI CONNECTOR</td>
                        <td style="text-align:center">2,000</td>
                        <td style="text-align:center">$0.18-0.33</td>
                    </tr>
                    
                </table>
			</div>  -->


			<div class="main_title centered upper">
				<h2><span class="line"><span class="dot"></span></span>產品專區</h2>
			</div>
			<div class="icon_boxes_con style1 hover clearfix">
				<div class="col-md-4">
					<div class="service_box">
						<div class="icon">
							<img src="content/images/indexPro_image5.png" alt="connector manufacturer">
						</div>
						<div class="service_box_con">
							<h3 class="centered">SFP 連接器</h3>
							<ul class="desc">
								<asp:Repeater ID="repList5" runat="server">
                                    <ItemTemplate>
								    <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id_Zh") %> '><span><%#Eval("PC_ClassName") %></span></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
							</ul>
							
							<div class="centered">
								 <asp:HyperLink ID="HyperLink5" runat="server" CssClass="btn_c">
                                    <span class="btn_c_ic_a"><i class="ico-refresh4"></i></span>
									<span class="btn_c_t">See More</span>
									<span class="btn_c_ic_b"><i class="ico-refresh4"></i></span>
                                </asp:HyperLink>
							</div>

						</div>
					</div>
				</div>
				<div class="col-md-4">
					<div class="service_box">
						<div class="icon">
							<img src="content/images/indexPro_image2.png" alt="connector supplier">
						</div>
						<div class="service_box_con">
							<h3 class="centered">RJ 連接器</h3>
							<ul class="desc">
                                <asp:Repeater ID="repList2" runat="server">
                                    <ItemTemplate>
								    <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id_Zh") %> '><span><%#Eval("PC_ClassName") %></span></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
							</ul>
							<div class="centered">
                                <asp:HyperLink ID="HyperLink2" runat="server" CssClass="btn_c">
                                    <span class="btn_c_ic_a"><i class="ico-refresh4"></i></span>
									<span class="btn_c_t">See More</span>
									<span class="btn_c_ic_b"><i class="ico-refresh4"></i></span>
                                </asp:HyperLink>
							</div>

						</div>
					</div>
				</div>
				<div class="col-md-4">
					<div class="service_box">
						<div class="icon">
							<img src="content/images/indexPro_image3.png" alt="connector manufacturer">
						</div>
						<div class="service_box_con">
							<h3 class="centered">FPC 連接器</h3>
							<ul class="desc">
								 <asp:Repeater ID="repList3" runat="server">
                                    <ItemTemplate>
								    <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id_Zh") %> '><span><%#Eval("PC_ClassName") %></span></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
							</ul>
							
							<div class="centered">
								 <asp:HyperLink ID="HyperLink3" runat="server" CssClass="btn_c">
                                    <span class="btn_c_ic_a"><i class="ico-refresh4"></i></span>
									<span class="btn_c_t">See More</span>
									<span class="btn_c_ic_b"><i class="ico-refresh4"></i></span>
                                </asp:HyperLink>
							</div>

						</div>
					</div>
				</div>
				<div class="col-md-4">
					<div class="service_box">
						<div class="icon">
							<img src="content/images/indexPro_image4.png" alt="connector supplier">
						</div>
						<div class="service_box_con">
							<h3 class="centered">USB 2.0 連接器</h3>
							<ul class="desc">
								<asp:Repeater ID="repList4" runat="server">
                                    <ItemTemplate>
								    <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id_Zh") %> '><span><%#Eval("PC_ClassName") %></span></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
							</ul>
							
							
							<div class="centered">
								 <asp:HyperLink ID="HyperLink4" runat="server" CssClass="btn_c">
                                    <span class="btn_c_ic_a"><i class="ico-refresh4"></i></span>
									<span class="btn_c_t">See More</span>
									<span class="btn_c_ic_b"><i class="ico-refresh4"></i></span>
                                </asp:HyperLink>
							</div>

						</div>
					</div>
				</div>

				<div class="col-md-4">
					<div class="service_box">
						<div class="icon">
							<img src="content/images/indexPro_image1.png" alt="connector manufacturer">
						</div>
						<div class="service_box_con">
							<h3 class="centered">SATA 連接器</h3>
							<ul class="desc">
								<asp:Repeater ID="repList1" runat="server">
                                    <ItemTemplate>
								    <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id_Zh") %> '><span><%#Eval("PC_ClassName") %></span></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
							</ul>
							
							<div class="centered">
								 <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn_c">
                                    <span class="btn_c_ic_a"><i class="ico-refresh4"></i></span>
									<span class="btn_c_t">See More</span>
									<span class="btn_c_ic_b"><i class="ico-refresh4"></i></span>
                                </asp:HyperLink>
							</div>

						</div>
					</div>
				</div>
				
				<div class="col-md-4">
					<div class="service_box">
						<div class="icon">
							<img src="content/images/indexPro_image6.png" alt="connector supplier">
						</div>
						<div class="service_box_con">
							<h3 class="centered">HDMI 連接器</h3>
							<ul class="desc">
								<asp:Repeater ID="repList6" runat="server">
                                    <ItemTemplate>
								    <li><a href='Products-sublist.aspx?PC_Id=<%#Eval("PC_Id_Zh") %> '><span><%#Eval("PC_ClassName") %></span></a></li>
                                    </ItemTemplate>
                                </asp:Repeater>
							</ul>
							
							<div class="centered">
								 <asp:HyperLink ID="HyperLink6" runat="server" CssClass="btn_c">
                                    <span class="btn_c_ic_a"><i class="ico-refresh4"></i></span>
									<span class="btn_c_t">See More</span>
									<span class="btn_c_ic_b"><i class="ico-refresh4"></i></span>
                                </asp:HyperLink>
							</div>

						</div>
					</div>
				</div>
                
			</div>
		</div>
	</section>
	<!-- End Icon Boxes Style 1 A -->
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