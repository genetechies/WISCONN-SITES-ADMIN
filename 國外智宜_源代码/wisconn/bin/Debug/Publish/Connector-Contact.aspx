<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Connector-Contact.aspx.cs" Inherits="ZeroStudio.Web.Contact_en" %>

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
    <title>Wisconn Connector Manufacturer | Connector Supplier - Contact Us</title>
    <meta name="Keywords" content="connector supplier, FPC connector" />
    <meta name="description" content="Founded in Taiwan, Wisconn(connector supplier,connector manufacturer) takes advantage of favorable geographical conditions to provide its global customers with a diverse range of connector products (RJ45 connector, USB connector, FPC connector) that are of good quality." />

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
                    <h2><span class="line"><span class="dot"></span></span>Contact   Us</h2>
                </div>
                <br />
                <div class="rows_container clearfix">
                    <div class="col-md-6">
                        <h2 class="title1 upper"><i class="ico-pencil5"></i>Contact Information</h2>
                        <div class="contact_details_row clearfix">
                            <span class="icon">
                                <i class="ico-location5"></i>
                            </span>
                            <div class="c_con">
                                <span class="c_title">Address</span>
                             <!--   <span class="c_detail">
                                    <span class="c_name">Main Office :</span>
                                    <span class="c_desc">1933 Camargue Dr, Zionsville, IN 46077(U.S.A.)  </span> 
</span> -->
  <span class="c_detail">
<span class="c_name">Taiwan Office :</span>
                                    <span class="c_desc">

7F., No.28, Ln. 123, Sec. 6, Minquan E. Rd., Neihu Dist., Taipei City 11465 , Taiwan (R.O.C.)</span>
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
                                <span class="c_title">Phone Numbers</span>
                              <!--   <span class="c_detail">
                                    <span class="c_name">Main Office :</span>
                                    <span class="c_desc">+1 407-282-3220 </span>
                                </span> -->
                                <span class="c_detail">
                                    <span class="c_name">Taiwan Office :</span>
                                    <span class="c_desc">+886 2 2790-1979</span>
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
                                <span class="c_title">Email Address</span>
                                <span class="c_detail">
                                    <span class="c_name">Customer support :</span>
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
                                <span class="c_title">Other Datails</span>
                                <span class="c_detail">
                                    <span class="c_name">Site Name :</span>
                                    <span class="c_desc">www.wis-connector.com</span>
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
                                    <span class="hm_field_name">Name</span>
                                    <span class="hm_requires_star">*</span>
                                </label>
                                 <asp:TextBox ID="txtUserName" runat="server" CssClass="form_fill_fields hm_input_text" ></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvUserName" runat="server" ControlToValidate="txtUserName" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
             
                            </div>
                            <div class="form_row clearfix">
                                <label for="contact-us-mail">
                                    <span class="hm_field_name">Email</span>
                                    <span class="hm_requires_star">*</span>
                                </label>
                                 <asp:TextBox ID="txtEmail" runat="server" CssClass="form_fill_fields hm_input_text" ></asp:TextBox>
                          <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
             
                            </div>
                            <div class="form_row clearfix">
                                <label for="contact-us-subject">
                                    <span class="hm_field_name">Subject</span>
                                </label>
                                 <asp:TextBox ID="txtTitle" runat="server" CssClass="form_fill_fields hm_input_text" ></asp:TextBox>
                           <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
             
                            </div>
                            <div class="form_row clearfix">
                                <label for="contact-us-message">
                                    <span class="hm_field_name">Message</span>
                                    <span class="hm_requires_star">*</span>
                                </label>
                                 <asp:TextBox ID="txtContent" TextMode="multiLine" runat="server" CssClass="form_fill_fields hm_textarea" ></asp:TextBox>                                    
                          <asp:RequiredFieldValidator ID="rfvContent" runat="server" ControlToValidate="txtContent" ValidationGroup="send" ErrorMessage="*" SetFocusOnError="true"></asp:RequiredFieldValidator>
          
                            </div>
                            <div class="form_row clearfix">
                                 <asp:Button ID="btnSend" runat="server" CssClass="send_button full_button" OnClick="btnSend_Click" ValidationGroup="send" Text="&radic; Send Your Message" >
                                    
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
                        <p>There are many variations of passages of Lorem Ipsum available, bute majority.</p>
                        <a href="/Connector-Products.aspx" class="black_button">
                            <i class="ico-angle-right"></i><span>Read More</span>
                        </a>
                        <p>By subscribing to our mailing list you will always be update with the latest news :</p>
                        <a href="/Connector-Portfolio.aspx" class="black_button">
                            <i class="ico-angle-right"></i><span>Read More</span>
                        </a>
                    </div>

                    <div class="col-xs-9">




<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d27288.580330466968!2d121.57584489326288!3d25.071184483752106!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442ad13d02cae59%3A0x180a8e93f321d82!2sWisconn%20Connector%20Manufacturer%20Co.%2CLtd!5e0!3m2!1szh-TW!2stw!4v1698637300564!5m2!1szh-TW!2stw" width="750" height="465" style="border:0;" allowfullscreen="" loading="lazy" referrerpolicy="no-referrer-when-downgrade"></iframe>

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
