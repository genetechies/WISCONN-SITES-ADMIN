<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="ZeroStudio.Web.Header_en" %>
  <header id="site_header">
		<div class="topbar"><!-- class ( topbar_colored  ) -->
			<div class="content clearfix">
			
				<div class="top_details clearfix f_right">
					<span class="top_login"onclick="$('#formSearch').submit()">
                             <a  href="javascript:void(0)" >   </a>
                        </span><span class="top_login">
                            <a  href="https://www.wisconn.com.tw"><img src="Content/images/top-icon.png" alt="connector supplier, connector manufacturer, FPC connector" style="margin-right: 5px;">中文</a>
                        </span>
                        <span class="top_login">
                            <a href="https://www.wis-connector.com"><img src="Content/images/top-icon.png" alt="connector supplier, connector manufacturer, FPC connector" style="margin-right: 5px;">EN</a>
                        </span>
				</div>
                  <form id="formSearch" class="top_search clearfix large_top_search" action="Products-sublist.aspx">
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
					<a href="Index.aspx">
						<img class="logo_dark" src="content/images/logo-dark.png" alt="connector supplier, connector manufacturer, FPC connector">
						<img class="logo_light" src="content/images/logo-light.png" alt="connector supplier, connector manufacturer, FPC connector">
					</a>
				</div>
				
				<nav id="main_nav" style="float:right">
					<div id="nav_menu">
						<span class="mobile_menu_trigger">
						    <a href="#" class="nav_trigger"><span></span></a>
						</span>		
						<ul id="navy" class="clearfix horizontal_menu" style="">
							<li id="index" runat="server" class="normal_menu mobile_menu_toggle">
								<a href="Index.aspx"><span>首頁</span></a>
							</li>
							<li id="about" runat="server" class="normal_menu mobile_menu_toggle">
								<a href="About.aspx"><span>公司簡介</span></a>
							</li>
							<li id="product" runat="server" class="normal_menu mobile_menu_toggle">
							    <a href="Products.aspx"><span>產品專區</span></a>
							</li>
							
							<li id="services" runat="server" class="has_mega_menu mobile_menu_toggle">
							    <a href="Services.aspx"><span>品質管理</span></a>
							</li>
<li id="news" runat="server" class="normal_menu mobile_menu_toggle">
								<a href="Portfolio.aspx"><span>連接器介紹</span></a>
							</li>
							<li id="contact" runat="server" class="has_tab_menu mobile_menu_toggle">
								<a href="Contact.aspx"><span>聯絡我們</span></a>
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