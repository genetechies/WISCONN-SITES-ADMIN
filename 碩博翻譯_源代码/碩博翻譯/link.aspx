<%@ Page Language="C#" AutoEventWireup="true" CodeFile="link.aspx.cs" Inherits="link" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>



<!doctype html >
<html lang="en-US">

	<head runat="server">
		<meta charset="utf-8">
		<title> 友好連結--碩博企業翻譯社 </title>
		<meta name="description" content="碩博翻譯社自成立以來，致力提供最專業的本地化翻譯服務，與國內外知名科技、網頁公司等長期合作，以最專業的翻譯技術和最高效率的翻譯速度聞名業界。">
		<meta name="keywords" content="翻譯社" />
		<link href="https://fonts.googleapis.com/css?family=Poppins:300,300i,400,500,600,700,800,900" rel="stylesheet">
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
		<link rel="stylesheet" href="css/bootstrap.min.css" media="all">
		<link rel="stylesheet" href="css/all.min.css" media="all">
		<link rel="stylesheet" href="css/light-box.css" media="all">
		<link rel="stylesheet" href="css/owl.carousel.min.css" media="all">
		<link rel="stylesheet" href="css/tp-animation.css" media="all">
		<link rel="stylesheet" href="css/style.css" media="all">
		<link rel="stylesheet" href="css/responsive.css" media="all">
        <link rel="icon" href="images/SB.png" type="image/ico" />
        <style>
						@media (min-width: 769px) {
							.partner_list li {
								width: 224px;
								text-align: center;
							}
							.partner_list {
								display: flex;
								flex-flow: row nowrap;
								justify-content: space-around;
							}
						}
						@media (max-width: 991px) {
							.partner_list li {
								width: 100px;
								text-align: center;
							}
							.partner_list {
								display: flex;
								flex-flow: row nowrap;
								justify-content: space-around;
							}
						}
           #huahang div {
				width: 100%;
			}
			
			#zitidx {
				height: 100px;
				line-height: 100px;
				font-family: "agency fb";
				font-size: 60px;
				color: #000000;
			}
					</style>
	</head>

	<body>
		<!-- perload section -->
		<div id="preloader">
			<div id="preloader-inner"></div>
		</div>
		<!-- header section -->
        <uc1:top runat="server" ID="top" />
		<!-- breadcrumbs -->
		<section class="rafaa-section" style=" background: url(images/友好連結-banner.jpg);">
			<div class="container">
				<div class="row">
					<div class="col-12">
						<div class="wrap_breadcrumbs_col">
						<!--	<h1 class="l-head"> Link
                            </h1> -->
						
						</div>
					</div>
				</div>
			</div>
		</section>

		<!--partners -->
		<section class="rafaa-section what-we-offer" style="background-color: #ffffff;">
			<div class="container">
				<div id="huahang" class="row">

                     <div style="margin: 0px 0px 10px 0px;">
                        <div class="wrap_about_us">
                        <span class="rp-tip"> Link</span>
							<h2 class="l-head">友好連結</h2>
                          </div>

                    </div>

					
					<div>歡迎各大優質網站交換連結。下列為友站連結網站，歡迎至下列網站參觀！請注意下列事項，歡迎各大優質網站，互換連結。</div>
					<div>1、受理情色、違法、盜版、暴力等違反社會善良風俗之網站交換連結。</div>
					<div>2、保有隨時終止交換連結之權利。</div>
					<div>3、連結經常無法正常顯示，本站有移除連結之權力，並不另行通知，如貴站已恢復正常運作，歡迎重新申請。</div>
					<div>4、不定期瀏覽貴站連結頁，如發現未放置本站連結，我們將刪除與貴站的連結。</div>
					<div>5、置本站連結後，於3日內完成貴站的連結作業。</div>
				</div>
			</div>
		</section>
		<section class="rafaa-section" style="padding: 0;">
			<div class="container">
					
                    <%
                        for (int i = 0; i < dtClass.Rows.Count; i++)
                        {
                            if (i % 5 == 0)
                            {
                        %>
					<%="<ul class='partner_list'>" %>
                        <%} %>
                        <li>
							<a href="https://<%=dtClass.Rows[i][2].ToString() %>" title="<%= dtClass.Rows[i][1].ToString() %>"><%= dtClass.Rows[i][1].ToString() %></a>
						</li>
                        <% if (i % 5 == 4 || (i == dtClass.Rows.Count - 1))
                            { %>
                    <%="</ul>"%>
                    <% 
                            }
                        } %>
				<h2>&nbsp;</h2>
				</div>
			</section>
			<!-- footer -->
            <footer id="footers" class="rafaa-section rp-footer rp-footer-1" style="border: 0px solid #ff0000;">
        <div class="container">
            <div class="row yingcang">
                <ul class="footer-grods">
						<li>
							<a title="首頁" href="index.aspx">首頁</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="翻譯資訊" href="translationnews/index.html">翻譯資訊</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="翻譯團隊" href="team.aspx">翻譯團隊</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="客戶實績" href="actual.aspx">客戶實績</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="線上詢價" href="xunjia/index.aspx">線上詢價</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="友好連結" href="link.aspx">友好連結</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="Molex" href="index.aspx">Molex</a></li><li style="width: 30px;">|</li><li> <a title="sitemap" href="/sitemap/sitemap.xml">Sitemap</a></li>
					</ul>
				</div>
				<div class="row copywright_row" style="margin-bottom:-200px;">
					<div class="col-lg-7 col-md-7 col-12 ">
						<p class="copywright">版權所有 碩博企業翻譯社- 專業翻譯社</p>
					</div>
					<div class="col-5 col-md-5 col-12">
						<ul class="privacy_list ">
							<li>
								<a href="tel:+886-2-2567-3067">Tel：+886-2-2567-3067 </a>|</li>
							<li>
								<a href="../contact.html">台北市新生北路二段129-2號7F</a>|</li>
							<!--<li>
								<a href="#">Terms &amp; Conditions</a>
							</li>-->
						</ul>
					</div>
				</div>
			</div>
		</footer>
			<!-- js library including -->
			<script src="js/jquery.min.js"></script>
			<script src="js/light-box.js"></script>
			<script src="js/owl.carousel.min.js"></script>
			<script src="js/odometer.min.js"></script>
			<script src="js/chartjs.js"></script>
			<script src="js/masonary.min.js"></script>
			<script src="js/noframework.waypoints.min.js"></script>
			<script src="js/index.js"></script>
	</body>

</html>