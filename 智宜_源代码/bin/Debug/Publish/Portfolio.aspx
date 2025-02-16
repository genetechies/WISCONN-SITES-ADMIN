<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Portfolio.aspx.cs" Inherits="ZeroStudio.Web.Portfolio_en" %>

<%@ Import Namespace="System.Linq" %>

<%@ Register Src="~/Header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/Footer.ascx" TagPrefix="uc4" TagName="footer" %>
<%@ Register Src="Css.ascx" TagName="Css" TagPrefix="uc2" %>
<%@ Register Src="js-en.ascx" TagName="js" TagPrefix="uc3" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

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
      <title>連接器重要資訊介紹 - 智宜科技股份有限公司 - <%= title %></title>
    <meta content="<%= keywords %>" name="keywords" />
    <meta content="<%= description %>" name="description" />

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

        .pages {
            color: #999;
            overflow: auto;
        }

            .pages a, .pages .cpb {
                text-decoration: none;
                float: left;
                padding: 10px 5px;
                border: 1px solid #ddd;
                background: #fff;
                margin: 0 4px;
                font-size: 13px;
                color: #444444;
                height: 43px;
                min-width: 43px;
                display: inline-block;
                border-radius: 15%;
                text-align: center;
            }

                .pages a:hover {
                    background-color: #1ccdca;
                    color: #fff;
                    border: 1px solid #1ccdca;
                    text-decoration: none;
                }

            .pages .cpb {
                font-weight: bold;
                color: #fff;
                background: #1ccdca;
                border: 1px solid #1ccdca;
            }
    </style>
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
        <uc1:header ID="header" runat="server" PageID="news" />


        <div class="banner">
            <img src="Content/images/Blog-banner.jpg" alt="connector supplier">
        </div>

        <form id="form1" runat="server">
            <!-- Our Blog Grids -->
            <section class="content_section">
                <div class="content row_spacer">
                    <div class="main_title centered upper">
                        <h2><span class="line"><span class="dot"></span></span>連接器介紹</h2>
                    </div>
                    <div class="product clearfix">
                        <div class="p_left">
                            <div class="p_title">
                                <p class="toggleMenu">連接器介紹</p>
                            </div>

                            <ul class="p_toggle list_drop dn">
                                <li>
                                    <div class="p_category">
                                        <span class="label">文章專區</span>
                                        <span class="arrow up"></span>
                                    </div>
                                    <span class="no">
                                        <ul class="list_menu" style="display: block;">
                                         
                                            <asp:Repeater ID="Repeater1" runat="server">
                                                <ItemTemplate>
                                                    <li>
                                                        <a href="Portfolio.aspx?ClassID=<%#Eval("NC_Id") %>"><i></i><%#Eval("NC_ClassName") %> </a>
                                                    </li>
                                                </ItemTemplate>
                                            </asp:Repeater>
                                        </ul>
                                    </span>
                                </li>
                                <li>
                                    <div class="p_category">
                                        <span class="label">連接器介紹</span>
                                        <span class="arrow up"></span>
                                    </div>
                                    <span class="no">
                                        <ul class="list_menu" style="display: block;">
                                            <%
                var parents = proClassList.Where(w => w.PC_ParentID == 0);
                foreach (var parent in parents)
                {%>
                                            <li><a href='Products-sublist.aspx?PC_Id=<%=parent.PC_Id%>'><i></i><%=parent.PC_ClassName %> </a></li>
                                            <% }


%>
                                        </ul>
                                    </span>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <!-- All Content -->
                    <div class="content_spacer clearfix">
                        <div class="content_block col-md-8 f_right">

                            <ul class="crumb">
                                <li>
                                    <a href="/Index.aspx">首頁</a>
                                    <i class="ico-angle-right"></i>
                                </li>
                                <li>
                                    <a href="/Portfolio.aspx">連接器介紹</a>
                                    <i class="ico-angle-right"></i>
                                </li>
                                 <li>
                                     <%
                                         if (classInfo != null) {  %>
                                       <a href="/Portfolio.aspx?ClassID=<%=classInfo.Id %>"><%=classInfo.ClassName %></a>
                                        <%   }
                                         %>
                                </li>
                            </ul>

                            <div><asp:Literal ID="ltArtListTitle" runat="server"></asp:Literal></div>
                            <div><asp:Literal ID="ltArtListDescription" runat="server"></asp:Literal></div>

                            <asp:Repeater ID="newsList" runat="server">
                                <ItemTemplate>
                                    <div class="hm_blog_list clearfix">
                                        <div class="blog_grid_block clearfix">
                                            <div class="blog_grid_con">
                                                <h6 class="title">
                                                    <a href='Portfolio-detail.aspx?N_Id=<%#Eval("N_Id") %>'>
                                                        <p><%#Eval("N_DateTime","{0:yyyy-MM-dd}") %></p>
                                                        <p><%#Eval("N_Title") %></p>
                                                    </a>
                                                </h6>
                                                <span class="meta"></span>
                                                <p class="desc"><%#Eval("N_Description") %></p>
                                            </div>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:Repeater>

                            <div id="pagination" class="pagination">
                                <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="false" ShowFirstLast="false" PageSize="20" CurrentPageButtonClass="cpb" PagingButtonSpacing="0"
                                    NextPageText="&rarr;" PrevPageText="&larr;" OnPageChanged="AspNetPager1_PageChanged" CssClass="pages">
                                </webdiyer:AspNetPager>
                            </div>

                        </div>
                        <!-- End Content Block -->

                        <!-- sidebar -->
                        <aside id="sidebar" class="col-md-4 right_sidebar">
                            <h1 class="title">文章專區</h1>
                            <ul>
                                <asp:Repeater ID="newsClassList" runat="server">
                                    <ItemTemplate>
                                        <li>
                                            <a href="Portfolio.aspx?ClassID=<%#Eval("NC_Id") %>"><%#Eval("NC_ClassName") %> </a>
                                        </li>
                                    </ItemTemplate>
                                </asp:Repeater>
                            </ul>
                            <h1 class="title">產品專區</h1>
                            <ul>
                                <%
            foreach (var parent in parents)
            {%>
                                     <li><a href='Products-sublist.aspx?PC_Id=<%=parent.PC_Id%>'><i></i><%=parent.PC_ClassName %> </a></li>
                                <% }
                                %>
                            </ul>
                        </aside>
                        <!-- End sidebar -->
                    </div>
                    <!-- All Content -->
                </div>
            </section>
        </form>
        <!-- End Our Blog Grids -->


        <!-- footer -->
        <uc4:footer ID="footer1" runat="server" />

        <a href="#" class="hm_go_top">Top</a>
    </div>
    <!-- End wrapper -->

    <uc3:js ID="js1" runat="server" />


    <script type="text/javascript">
        $(document).ready(function () {

            $('.p_title').on('click', function () {
                $(this).siblings('ul.p_toggle').toggleClass('dn')
            })

            $("ul.p_toggle li > div.p_category").click(function () {

                var arrow = $(this).find("span.arrow");

                if (arrow.hasClass("up")) {
                    arrow.removeClass("up");
                    arrow.addClass("down");
                } else if (arrow.hasClass("down")) {
                    arrow.removeClass("down");
                    arrow.addClass("up");
                }

                $(this).parent().find("ul.list_menu").slideToggle();
            });
        });
    </script>

</body>
</html>
