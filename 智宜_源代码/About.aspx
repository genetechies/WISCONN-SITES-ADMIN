<%@ Page Language="C#" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="ZeroStudio.Web.About_en" %>

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
        <title>連接器公司簡介-智宜科技股份有限公司</title>
    <meta content="連接器製造商,連接器廠商" name="keywords" />
    <meta content="智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。" name="description" />
        <uc2:Css ID="Css1" runat="server" />
    </head>

    <!-- Class ( site_boxed - dark - preloader1 - preloader2 - preloader3 - light_header - dark_sup_menu - menu_button_mode - transparent_header - header_on_side ) -->
    <body class="preloader3 light_header">
        <div id="preloader">
            <div class="spinner">
                <div class="sk-dot1">
                </div>
                <div class="sk-dot2"></div>
                <div class="rect3"></div>
                <div class="rect4"></div>
                <div class="rect5"></div>
            </div>
        </div>

        <div id="main_wrapper">
            <uc1:header ID="header" runat="server" PageID="about" />

            <div class="banner">
                <img src="content/images/about-banner.jpg" alt="connector supplier">
            </div>

            <!-- Our Blog Grids -->
            <section class="content_section">
                <div class="content row_spacer">
                    <div class="main_title centered upper">
                        <h2><span class="line"><span class="dot"></span></span>公司簡介</h2>
                    </div>
                  
                    <!-- All Content -->
                    <div class="content_spacer about clearfix">
                        <div class="content_block col-md-9 f_left">
                            <div class="about-contact">
                                <h1 class="title">關於我們
                                </h1>
                                <img src="content/images/about-img.jpg" alt="connector manufacturer" style="width: 330px;">
                                <span>智宜科技以「專業、誠信、服務、品質」為經營宗旨，提供SATA、RJ45、FPC、USB、DVI、HDMI等各項連接器產品，提供客戶夥伴創造出更高的商業價值。</span>
                                <br />
                                <br />
                                <span>工廠成立於1997年，短時間內於 2001年獲得國際標準組織 ISO9001及ISO14000的認證，更值得一提是部份產品取得 UL及CUL認證。智宜科技一向專精於OEM與ODM設計與研發製造，憑藉著多年來在電子產業累積的專業基礎，成功導入自創品牌WISCONN，並接連開發出多種連接器相關零組件產品，深獲使用者的信任與喜愛，我們的客戶群已涵蓋國內外知名3C大廠。</span>
                                <br />
                                <br />
                                <span>今後我們將持續秉持「品質至上、客戶為尊」的經營理念，以穩定的品質，迅速的交期和極具競爭力的價格，戮力研發創新，提供具有世界級競爭力的優質產品，以及高效、快捷的服務，與客戶夥伴共創壯闊藍海！</span>
                                <br />
                                <h1 class="title">經營理念</h1>
                                <img src="content/images/about-img2.jpg" alt="connector supplier" style="float: right; margin-left: 10px;  width: 380px;">
                                <span>企業文化的形成，可以說是經由經營理念長期孕育而成。而智宜科技的經營理念，歸納起來，就是以「品質至上、客戶為尊」的態度追求一切事物的最高標準化，並且以「站在客戶的角度思考，為客戶創造出更高的商業價值」做為最終的努力目標。由於客觀環境變動不拘，事實上任何事物是永遠達不到「至善」之境，但是經由智宜科技全體員工永無休止的追求，成為推動企業不斷提升經營績效及競爭條件的原動力，使得本公司能夠不斷研發新產品，達到「永續經營」之目的。</span>
                            </div>

                        </div>
                        <!-- End Content Block -->

                        <!-- sidebar -->
                        <aside id="sidebar" class="col-md-3 right_sidebar mouse">
                            <div class="title1">
                                <img class="titleimg" src="content/images/Abou-menu.jpg" alt="connector manufacturer">
                            </div>
                            <ul>
                              	<li>全自動機</a></li>
                            <li>塑膠射出成型機</a></li>
                            <li>高速精密沖壓機</a></li>
                            </ul>
                            <div class="title1">
                                <img class="titleimg" src="content/images/Abou-menu1.jpg" alt="connector supplier">
                            </div>
                            <ul>
                               <li>網路分析儀</a></li>
                            <li>時域反射傳輸儀</a></li>
                            <li>微歐姆計</a></li>
                            <li>絕緣測試機</a></li>
                            <li>耐壓測試機</a></li>
                            <li>插拔力測試機</a></li>
                            <li>工具顯微鏡</a></li>
                            <li>耐久性測試機</a></li>
                             <li>投影機</a></li>
                            <li>2.5次元攝影機</a></li>
                            <li>焊錫性試驗機</a></li>
                            <li>線材測試機</a></li>
                            <li>高度規</a></li>
                            <li>扭力計</a></li>
                            <li>鹽水噴霧試驗機</a></li>
                            <li>高溫試驗機</a></li>
                            <li>電鍍膜厚測試機</a></li>
                            <li>電源供應測試機</a></li>
                            <li>變阻器</a></li>
                            <li>可程式恒溫恒濕試驗機</a></li>
                            <li>冷熱沖擊儀</a></li>
                            <li>蒸汽老化試驗機</a></li>
                            <li>重金屬實驗設備</a></li>
                            <li>迴焊爐</a></li>
                            </ul>

                        </aside>
                        <!-- End sidebar -->

                        <div class="clear"></div>
                        <div class="about-long-contact">
                            <h1 class="title">經營策略</h1>
                            <img src="content/images/about-img3.jpg" alt="connector manufacturer">
                            <span>智宜科技公司成立之初即以專業、誠信、服務、品質為公司的四大信念，不僅落實於每位智宜科技同仁心中，更實踐於產品品質的控管、客戶服務至上、商譽誠信等日常生活當中。 在品質方面，除了ISO認證之外，未來將導入六個標準差達到世界級的標準。</span>
                            <br />
                            <span>創新是我們的靈魂，專業、誠信、服務、品質是我們截至目前研發已佔本公司營業額相當的比例，我們將持續投入更多的研發經費，開發出更多的世界級水準產品。
生存命脈。</span>
                        </div>
                    </div>
                    <!-- All Content -->
                </div>
            </section>
            <!-- End Our Blog Grids -->


            <!-- footer -->
           <uc4:footer ID="footer1" runat="server" />
            <a href="#" class="hm_go_top">Top</a>
        </div>
        <!-- End wrapper -->

        <uc3:js ID="js1" runat="server" />
    </body>
    </html>
