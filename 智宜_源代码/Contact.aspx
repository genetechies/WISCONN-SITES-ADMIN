<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="ZeroStudio.Web.Contact_en" %>

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
   <title>連接器有任何問題歡迎聯絡我們 - 智宜科技股份有限公司</title>
    <meta content="fpc connector,rj45 transformer" name="keywords" />
    <meta content="智宜科技為您提供RJ45連接器、USB連接器、FPC連接器、SATA連接器、USB2.0連接器、USB3.0連接器、MEMORY CARD連接器、 HDMI連接器，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。" name="description" />

    <uc2:Css ID="Css1" runat="server" />
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
            <uc1:header ID="header" runat="server"  PageID="contact"/>


        <div class="banner">
            <img src="content/images/contact-banner.jpg" alt="connector supplier">
        </div>

        <!-- Contact Us -->
        <section class="content_section">
            <div class="content row_spacer">
                <div class="main_title centered upper">
                    <h2><span class="line"><span class="dot"></span></span>聯絡我們</h2>
                </div>
                <br />
                <div class="rows_container clearfix">
                    <div class="col-md-6">
                        <h2 class="title1 upper"><i class="ico-pencil5"></i>智宜科技股份有限公司</h2>
                        <div class="contact_details_row clearfix">
                            <span class="icon">
                                <i class="ico-location5"></i>
                            </span>
                            <div class="c_con">
                                <span class="c_title">地址</span>
                             <!--   <span class="c_detail">
                                    <span class="c_name">辦公室 :</span>
                                    <span class="c_desc">1933 Camargue Dr, Zionsville, IN 46077(U.S.A.)  </span> 
</span> -->
  <span class="c_detail">
<span class="c_name">辦公室 :</span>
                                    <span class="c_desc">

11465 台北市內湖區民權東路六段123巷28號7樓</span>
                                </span>
                                <!-- <span class="c_detail">
								<span class="c_name">Customer Center :</span>
								<span class="c_desc">NO.123 - 45 Street Name - City, Country</span>
							</span> -->
                            </div>
                        </div>

                        <div class="contact_details_row clearfix">
                            <span class="icon">
                                <i class="ico-bubble4"></i>
                            </span>
                            <div class="c_con">
                                <span class="c_title">電話</span>
                              <!--   <span class="c_detail">
                                    <span class="c_name">Main Office :</span>
                                    <span class="c_desc">+1 407-282-3220 </span>
                                </span> -->
                                <span class="c_detail">
                                    <span class="c_name">電話 :</span>
                                    <span class="c_desc">02 2790-1979</span>
                                </span>
                                <!-- <span class="c_detail">
								<span class="c_name">Sales :</span>
								<span class="c_desc">+000 123 456 789</span>
							</span> -->
                            </div>
                        </div>

                        <div class="contact_details_row clearfix">
                            <span class="icon">
                                <i class="ico-paperplane"></i>
                            </span>
                            <div class="c_con">
                                <span class="c_title">電子郵件</span>
                                <span class="c_detail">
                                    <span class="c_name">E-mail :</span>
                                    <span class="c_desc">sales@wisconn.com.tw</span>
                                </span>
                                <!--		<span class="c_detail">
								<span class="c_name">Technical support :</span>
								<span class="c_desc">support@mail.com</span>
							</span> -->
                            </div>
                        </div>

                        <div class="contact_details_row clearfix">
                            <span class="icon">
                                <i class="ico-pen2"></i>
                            </span>
                            <div class="c_con">
                                <span class="c_title">其餘資訊</span>
                                <span class="c_detail">
                                    <span class="c_name">網址 :</span>
                                    <span class="c_desc">www.wisconn.com.tw</span>
                                </span>
                            </div>
                        </div>
                    </div>
                    <!-- Grid -->

                    <div class="col-md-6">
                        <h2 class="title1 upper"><i class="ico-envelope3"></i>Get In Touch</h2>
                        <form runat="server" class="hm_contact_form" id="form1" >
                            <div class="form_row clearfix">
                                <label for="contact-us-name">
                                    <span class="hm_field_name">姓名</span>
                                    <span class="hm_requires_star">*</span>
                                </label>
                                 <asp:TextBox ID="txtUserName" runat="server" CssClass="form_fill_fields hm_input_text"  ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
             
                            </div>
                            <div class="form_row clearfix">
                                <label for="contact-us-mail">
                                    <span class="hm_field_name">信箱</span>
                                    <span class="hm_requires_star">*</span>
                                </label>
                                 <asp:TextBox ID="txtEmail" runat="server" CssClass="form_fill_fields hm_input_text" ></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
             
                            </div>
                            <div class="form_row clearfix">
                                <label for="contact-us-subject">
                                    <span class="hm_field_name">主旨</span>
                                </label>
                                 <asp:TextBox ID="txtTitle" runat="server" CssClass="form_fill_fields hm_input_text" ></asp:TextBox>
                           <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
             
                            </div>
                            <div class="form_row clearfix">
                                <label for="contact-us-message">
                                    <span class="hm_field_name">內容</span>
                                    <span class="hm_requires_star">*</span>
                                </label>
                                 <asp:TextBox ID="txtContent" TextMode="multiLine" runat="server" CssClass="form_fill_fields hm_textarea" ></asp:TextBox>                                    
                          <asp:RequiredFieldValidator ID="rfvContent" runat="server" ControlToValidate="txtContent" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
          
                            </div>
                            <div class="form_row clearfix">
                                 <asp:Button ID="btnSend" runat="server" CssClass="send_button full_button" OnClick="btnSend_Click" ValidationGroup="send" Text="&radic; 送出" >
                                    
                                 </asp:Button>
                                <%--<button runat="server" OnClick="btnSend_Click" ValidationGroup="send"  class="send_button full_button" >
                                    <i class="ico-check3"></i>
                                    <span>Send Your Message</span>
                                </button>--%>
                            </div>
                            <div class="form_row clearfix">
                                <div id="form-messages"></div>
                            </div>
                            <div class="form_loader"></div>
                        </form>
                    </div>
                    <!-- Grid -->
                </div>

                <div class="contact_adress_map clearfix">
                    <div class="col-xs-3">
                        <img class="logo" src="content/images/logo-light.png" alt="FPC connector">
                        <p>相關連接器產品專區 :</p>
                        <a href="/Products.aspx" class="black_button">
                            <i class="ico-angle-right"></i><span>更多資訊</span>
                        </a>
                        <p>相關連接器文章介紹 :</p>
                        <a href="/Portfolio.aspx" class="black_button">
                            <i class="ico-angle-right"></i><span>更多資訊</span>
                        </a>
                    </div>

                    <div class="col-xs-9">
<iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d14455.750814656405!2d121.5927548!3d25.0701005!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442ab9c6b5c9189%3A0xcf4f60f09a7dc77e!2z5pm65a6c56eR5oqA6IKh5Lu95pyJ6ZmQ5YWs5Y-4!5e0!3m2!1szh-TW!2stw!4v1698401700807!5m2!1szh-TW!2stw" width="750" height="465" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>
                    </div>
                </div>

            </div>
        </section>
        <!-- End Contact Us -->

        <!-- Google Map -->
        <!-- <section class="content_section">
		<div class="bordered_content">
			<div class="google_map" data-lat="-12.043333" data-long="-77.028333" data-main="yes" data-text="Your location description 2">
				<span class="location" data-lat="-12.040397656836609" data-long="-77.03373871559225" data-text="Your sub location description 1"></span>
				<span class="location" data-lat="-12.050047116528843" data-long="-77.02448169303511" data-text="Your sub location description 2"></span>
			</div>
		</div>
	</section> -->
        <!-- End Google Map -->

        <!-- footer -->
    <uc4:footer ID="footer1" runat="server" />
        <a href="#0" class="hm_go_top"></a>
    </div>
    <!-- End wrapper -->

   <uc3:js ID="js1" runat="server" />

</body>
</html>
