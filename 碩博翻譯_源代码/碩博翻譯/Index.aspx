<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>



<!doctype html >
<html lang="en-US">
<head runat="server">
    <meta charset="utf-8">
    <title>碩博翻譯社提供英文翻譯,日文翻譯,韓文翻譯,論文翻譯服務</title>
    <meta name="description" content="碩博翻譯社是擁有高評價、優良推薦翻譯的台北專業翻譯服務企業，翻譯過程中客戶可要求校對，翻譯服務範圍：英文翻譯、日文翻譯、論文翻譯、網頁翻譯等多項翻譯服務。" />
    <meta name="keywords" content="翻譯社,英文翻譯" />
    <!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,300i,400,500,600,700,800,900" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css" media="all">
    <link rel="stylesheet" href="css/all.min.css" media="all">
    <link rel="stylesheet" href="css/owl.carousel.min.css" media="all">
    <link rel="stylesheet" href="css/tp-animation.css" media="all">
    <link rel="stylesheet" href="css/style.css" media="all">
    <link rel="stylesheet" href="css/responsive.css" media="all">
    <link rel="icon" href="images/SB.png" type="image/ico" />
    <style>
        @media (min-width: 769px) {
            .lx div {
                font-size: 20px;
                width: 50%;
            }

            .yd {
                position: relative;
                left: 8%;
            }
        }

        .slides {
            width: 100%;
            display: flex;
        }

        .gdlr-core-item-mglr {
            width: 100%;
        }

        @media (min-width: 576px) {
            .slides {
                height: 20px;
            }

            .gdlr-core-item-mglr {
                font-size: 15px;
                height: 300px;
                line-height: 300px;
            }

            .gdlr-core-item-mglr {
                font-size: 15px;
                height: 20px;
                line-height: 20px;
            }

            #mine {
                height: 10px;
            }

            #footers {
                height: 100px;
                padding: 0px;
                margin: 0px;
            }
        }

        @media (min-width: 769px) {
            .slides {
                height: 40px;
            }

            .gdlr-core-item-mglr {
                font-size: 30px;
                height: 100px;
                line-height: 100px;
            }

            #mine {
                height: 200px;
            }

            #footers {
                height: 100px;
                position: relative;
                top: 0px;
            }
        }

        @media (max-width: 576px) {
            .slides {
                height: 40px;
            }

            .gdlr-core-item-mglr {
                font-size: 15px;
                height: 20px;
                line-height: 20px;
            }

            #mine {
                height: 100px;
                padding: 80px 0;
                margin: 0;
            }

            #footers {
                padding: 20px 0;
                margin: 0;
            }

            .index1 {
                position: absolute;
                top: 30px;
            }
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
    <section class="rafaa-slider">
        <div class="owl-carousel r_slider">
            <div class="r_wrap_slider">
                <div class="r_slider_img" style="background-image: url(images/首頁banner1.jpg)"></div>
                <div class="r-slider-container">
                    <div class="r-slider-conten">
                        <h1 class="slider-title tp_animate_when_visible bottom-t-top" data-delay="600">碩博企業翻譯
                        </h1>
                        <p class="tp_animate_when_visible bottom-t-top" data-delay="600" data-speed="600">碩博翻譯社是一家具有一流水準翻譯人才之企業，並有經驗豐富的專案管理人員進行審核以確保最高的品質。翻譯過程中客戶可要求校對，本翻譯社在交件後免費提供修正以符合客戶的需要。 </p>
                        <a href="/aboutus/index.html" class="slider-btn read-more tp_animate_when_visible bottom-t-top" data-delay="800" data-speed="600">Read More</a>
                        <a href="/xunjia/index.aspx" class="slider-btn get-qoute tp_animate_when_visible bottom-t-top" data-delay="900" data-speed="300">Get A Qoute</a>
                    </div>
                </div>
            </div>
            <div class="r_wrap_slider">
                <div class="r_slider_img" style="background-image: url(images/首頁banner2.jpg)"></div>
                <div class="r-slider-container">
                    <div class="r-slider-conten">
                        <h1 class="slider-title tp_animate_when_visible bottom-t-top" data-delay="400">碩博企業翻譯
                        </h1>
                        <p class="tp_animate_when_visible bottom-t-top" data-delay="600" data-speed="600">碩博翻譯社歷年來承接過大量的翻譯文案，是名副其實的翻譯社專家。 </p>
                        <a href="/aboutus/index.html" class="slider-btn read-more tp_animate_when_visible bottom-t-top" data-delay="800" data-speed="600">Read More</a>
                        <a href="/xunjia/index.aspx" class="slider-btn get-qoute tp_animate_when_visible bottom-t-top" data-delay="900" data-speed="300">Get A Qoute</a>
                    </div>
                </div>
            </div>
            <div class="r_wrap_slider">
                <div class="r_slider_img" style="background-image: url(images/首頁banner3.jpg)"></div>
                <div class="r-slider-container">
                    <div class="r-slider-conten">
                        <h1 class="slider-title tp_animate_when_visible bottom-t-top" data-delay="600">碩博企業翻譯
                        </h1>
                        <p class="tp_animate_when_visible bottom-t-top" data-delay="600" data-speed="600">碩博翻譯社提供的翻譯文件種類很多，英文翻譯、網站翻譯等翻譯服務。 </p>
                        <a href="/aboutus/index.html" class="slider-btn read-more tp_animate_when_visible bottom-t-top" data-delay="800" data-speed="600">Read More</a>
                        <a href="/xunjia/index.aspx" class="slider-btn get-qoute tp_animate_when_visible bottom-t-top" data-delay="900" data-speed="300">Get A Qoute</a>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- our feature -->
    <section class="rafaa-section our-features">
        <div class="container">
            <div class="row">
                <div class="col-lg-3 col-md-6 col-sm-6 col-12">
                    <div class="wrap_features">
                        <span class="feature-icon"><i class="fas fa-user"></i></span>
                        <h3>關於碩博</h3>
                        <p>碩博翻譯社是一家具有一流水準翻譯人才之企業，並有經驗豐富的專案管理人員進行審核以確保最高的品質。翻譯過程中客戶可要求校對，本翻譯社在交件後免費提供修正以符合客戶的需要。</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-6 col-12">
                    <div class="wrap_features ">
                        <span class="feature-icon"><i class="fas fa-headset"></i></span>
                        <h3>服務項目</h3>
                        <p>碩博翻譯社提供的翻譯文件種類很多，大體上可歸納為以下幾類：論文翻譯、英文翻譯、日文翻譯、韓文翻譯、德文翻譯、西文翻譯、法文翻譯、書籍影帶、網站翻譯等翻譯服務。</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-6 col-12">
                    <div class="wrap_features ">
                        <span class="feature-icon"><i class="fas fa-lightbulb"></i></span>
                        <h3>線上詢價</h3>
                        <p>碩博翻譯社歷年來承接過大量的翻譯文案，從政府機關／知名企業至一般個人／學生，內容涵蓋商業，科技，人文，醫學，理工等；專業的執筆和平實的價格奠定了今日的碩博，是名副其實的翻譯社專家。</p>
                    </div>
                </div>
                <div class="col-lg-3 col-md-6 col-sm-6 col-12">
                    <div class="wrap_features ">
                        <span class="feature-icon"><i class="fas fa-tablet-alt"></i></span>
                        <h3>付款方式</h3>
                        <p>碩博翻譯社小的翻譯案件，我們全額收款，大的翻譯案件，可以分兩次收款，匯款後請立即以電話通知(或Email通知，不必傳真收據) ，以確保翻譯時效，收到款項後，我們將立即開始翻譯作業。</p>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- chart js -->
    <div class="rafaa-section r-facts">
        <div class="container">
            <div class="row fan-facts">
                <div class="col-12">
                    <div class="wrap-facts footer-grod lx">
                        <div class="footer-grod yd">
                            <div style="text-align: center; width: 100%;">
                                <div style="width: 100%;">公司資訊</div>
                            </div>
                            <img src="images/l_4.jpg" style="height: 80%; width: 80%;" alt="公司資訊" />
                        </div>
                        <div class="yd">
                            <div>TEL：+886-2-2567-3067</div>
                 
                            <div>FAX ：+886-2-2568-3707 </div>
                            <div>E-mail：service@translations.com.tw </div>
                            <div>地址：台北市新生北路二段129-2號7F </div>
                            <div>上班時間：周一至周五 9:00～18:00</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- what we offer -->
    <div class="rafaa-section what-we-offer">
        <div class="container">
            <div class="row">
                <%System.Data.DataSet dsfyzx = new BLL.NewsClass().GetList_top(4, " 1=1 ");
                    for (int i = 0; i < dsfyzx.Tables[0].Rows.Count; i++)
                    {
                %>
                <div class="col-lg-3 col-md-6 col-sm-6 col-12 col-wwo">
                    <div class="wrap_serive ">
                        <div class="service-caption">
                            <h3><%=Utils.SubString(dsfyzx.Tables[0].Rows[i]["ClassName"],7,"") %></h3>
                            <%System.Data.DataSet dsnews = new BLL.newsdata().GetList_top(5, " D_ClassID=" + dsfyzx.Tables[0].Rows[i]["classid"].ToString() + " and D_Recycle=0 ");
                                for (int j = 0; j < dsnews.Tables[0].Rows.Count; j++)
                                {
                            %>
                            <p><%=Utils.SubString(dsnews.Tables[0].Rows[j]["D_Title"],11,"...") %></p>
                            <%--<p><a target="_blank" href="/translationnews/art-<%=dsnews.Tables[0].Rows[j]["D_ID"].ToString().Trim()%>.html"><%=Utils.SubString(dsnews.Tables[0].Rows[j]["D_Title"],11,"...") %></a></p>--%>
                            <%
                                } %>

                            <a  target="_blank" href="/translationnews/index-<%=dsfyzx.Tables[0].Rows[i]["classid"].ToString() %>.html" title="read more"><i class="fas fa-arrow-right"></i></a>
                        </div>
                    </div>
                </div>
                <%}
                    %>
            </div>
        </div>
    </div>  


     <!--#include file="newspages/downindex.html"-->

    <!-- footer -->
    <footer id="footers" class="rafaa-section rp-footer rp-footer-1" style="border: 0px solid #ff0000;">
        <div class="container">
            <div class="row yingcang">
                <ul class="footer-grods" style="margin-top:116px;">
						<li>
							<a title="首頁" href="../index.aspx">首頁</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="翻譯資訊" href="../translationnews/index.html">翻譯資訊</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="翻譯團隊" href="../team.aspx">翻譯團隊</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="客戶實績" href="../actual.aspx">客戶實績</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="線上詢價" href="../xunjia/index.aspx">線上詢價</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="友好連結" href="../link.aspx">友好連結</a>
						</li>
						<li style="width: 30px;">|</li>
						<li>
							<a title="Molex" href="http://molex.wisconn.com.tw/">Molex</a></li>  <li style="width: 30px;">|</li><li> <a title="sitemap" href="../sitemap/sitemap.xml">Sitemap</a></li>
						</li>
					</ul>
				</div>
				<div class="row copywright_row">
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
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/odometer.min.js"></script>
    <script src="js/chartjs.js"></script>
    <script src="js/noframework.waypoints.min.js"></script>
    <script src="js/index.js"></script>
</body>
</html>
