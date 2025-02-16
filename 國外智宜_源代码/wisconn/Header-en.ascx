<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header-en.ascx.cs" Inherits="ZeroStudio.Web.Header_en" %>
  <header id="site_header">
		<div class="topbar"><!-- class ( topbar_colored  ) -->
			<div class="content clearfix">
			
				<div class="top_details clearfix f_right">
					<span class="top_login">
                            <a  href="https://www.wisconn.com.tw/index.aspx"><img src="Content/images/top-icon.png" alt="connector supplier, connector manufacturer, FPC connector" style="margin-right: 5px;">chinese</a>
                        </span>
                        <span class="top_login">
                            <a href="/Connector-Index.aspx"><img src="Content/images/top-icon.png" alt="connector supplier, connector manufacturer, FPC connector" style="margin-right: 5px;">English</a>
                        </span>
				</div>
                  <form class="top_search clearfix large_top_search" action="Connector-Products-sublist.aspx">
				<!-- Top Search -->
					<div class="top_search_con">
						 <input type="text" class="s" name="k" id="k"  placeholder="Search Here ...">
                            <span class="top_search_icon"><i class="ico-search4"></i></span>
                            <input type="submit" class="top_search_submit"  >
                            <input type="submit" class="go_top_search_submit"  >
							<img src="/Content/images/go.jpg" class="go_top_search_submit_img" />
					</div>
                      </form>
				
			</div>
			<!-- End content -->
			<span class="top_expande not_expanded">
				<i class="no_exp ico-angle-double-down"></i>
				<i class="exp ico-angle-double-up"></i>
			</span>
		</div>
		<!-- End topbar -->
			
		<div id="navigation_bar">
			<div class="content">
				<div id="logo">
					<a href="Connector-Index.aspx">
						<img class="logo_dark" src="content/images/logo-dark.png" alt="connector supplier, connector manufacturer, FPC connector">
						<img class="logo_light" src="content/images/logo-light.png" alt="connector supplier, connector manufacturer, FPC connector">
					</a>
				</div>
				
				<nav id="main_nav">
					<div id="nav_menu">
						<span class="mobile_menu_trigger">
						    <a href="#" class="nav_trigger"><span></span></a>
						</span>		
						<ul id="navy" class="clearfix horizontal_menu" style="">
							<li id="index" runat="server" class="normal_menu mobile_menu_toggle">
								<a href="Connector-Index.aspx"><span>Home</span></a>
							</li>
							<li id="about" runat="server" class="normal_menu mobile_menu_toggle">
								<a href="Connector-About.aspx"><span>Company Profile</span></a>
							</li>
							<li id="product" runat="server" class="normal_menu mobile_menu_toggle">
							    <a href="Connector-Products.aspx"><span>Connector Product</span></a>
							</li>
							
							<li id="services" runat="server" class="has_mega_menu mobile_menu_toggle">
							    <a href="Connector-Services.aspx"><span>Quality Management</span></a>
							</li>
<li id="news" runat="server" class="normal_menu mobile_menu_toggle">
								<a href="Connector-Portfolio.aspx"><span>Article</span></a>
							</li>
							<li id="contact" runat="server" class="has_tab_menu mobile_menu_toggle">
								<a href="Connector-Contact.aspx"><span>Contact Us</span></a>
							</li>
						</ul>
					</div>
				</nav>
				<!-- End Nav -->	
				
				<div class="clear"></div>
			</div>
		</div>
 	</header>
       <%--<asp:Literal ID="ltlBanner" runat="server"></asp:Literal>--%>
       <!-- banner -->