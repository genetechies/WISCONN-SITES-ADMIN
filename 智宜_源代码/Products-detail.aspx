<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Products-detail.aspx.cs" Inherits="ZeroStudio.Web.Products_detail_en" %>

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
     <title><%=title %></title>
    <meta content="<%=title %>" name="keywords" />
<meta content=" 智宜科技為您提供<%=title %>，擁有研發中心、模具中心的廠商，為全球最具專業的連接器供應商。" name="description" name="description" />

    <!-- Important stuff for SEO, don't neglect. (And don't dupicate values across your site!) -->
    <uc2:Css ID="Css1" runat="server" />
    <link rel="stylesheet" href="content/css/mediaelementplayer.css" />


    <link rel="stylesheet" href="content/css/style2.css" type="text/css" media="all" />
    <link rel="stylesheet" href="content/css/zoomify.css" type="text/css" media="all" />
    <style>
        #sidebar a {
            color: #555555;
        }

        #sidebar .subnav li a {
            color: #fff;
        }
        .productModel{
                background: url(../images/16.gif) 0px 2px no-repeat;
                font-size: 12px;
                color: #339;
                padding-left: 12px;
                font-weight: bold;
                margin: 4px 0 2px 5px;
        }
        body{margin:0; padding:0;}
    </style>
</head>
<body>
     <iframe id="mainiframe" width="100%" height="600"  src="/<%=pdoc %>"   frameborder="0" scrolling="auto"></iframe>
</body>
    <uc3:js ID="js1" runat="server" />

    <script>
        function changeFrameHeight() {
            var ifm = document.getElementById("mainiframe");
            ifm.height = document.documentElement.clientHeight - 56;
        }
        window.onresize = function () { changeFrameHeight(); }
        $(function () { changeFrameHeight(); });
    </script>
</html>
