<%@ Page Language="C#" AutoEventWireup="true" CodeFile="team.aspx.cs" Inherits="team" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>



<!doctype html >
<html lang="en-US">

<head runat="server">
    <meta charset="utf-8">
    <title>翻譯團隊--碩博企業翻譯社 </title>
    <meta name="description" content="碩博翻譯社提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。">
    <meta name="keywords" content="翻譯社" />
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
        @media (min-width: 991px) {
            .displayflex {
                display: flex;
            }

            .dx {
                width: 20%;
            }

            .dx1 {
                width: 80%;
            }
        }

        @media (max-width: 991px) {
            .large-widget-title {
                width: 100%;
            }
        }
							#cs {
								display: flex;
							}
							
							#cs a li {
								margin: 0px 5px 0px 0px;
								border: 1px solid #337abe;
								background-color: #FFFFFF;
								width: 40px;
								height: 40px;
								line-height: 40px;
								text-align: center;
								border-radius: 100%;
								font-size: 20px;
								color: #337abe;
							}
							
							#cs a li:hover {
								border: 1px solid #337abe;
								background-color: #337abe;
								font-size: 20px;
								color: #FFFFFF;
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
    <section class="rafaa-section" style="background-image: url(images/翻譯團隊banner.jpg)">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="wrap_breadcrumbs_col">
                   <!--     <h1 class="l-head">Team
                        </h1>  -->
                        
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- our team -->

    <section class="rafaa-section aboutus_team">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="wrap_team_title">

                          <div style="margin: 0px 0px 10px 0px;">
                        <div class="wrap_about_us">
                        <span class="rp-tip"> Team</span>
							<h2 class="l-head">翻譯團隊</h2>
                          </div>


                                               <p>
                            碩博翻譯社提供30多種的各國語言翻譯,主力包含英語翻譯、日語翻譯、韓語翻譯、英文校稿等國際語系的翻譯團隊。
                        </p>
                       </div>
                    </div>
                </div>
            </div>
            <div class="displayflex">
                <div class="dx">
                    <div style="margin: 0px 0px 10px 0px;">
                        <h3 class="large-widget-title" style="color: #383838;">語言團隊</h3>
                    </div>
                    <div>
                        <div>
                            <ul>
                                <%
                                    for (int ii = 0; ii < dtClass.Rows.Count; ii++)
                                    {
                                        string[] t = new String[2];
                                        if (dtClass.Rows[ii]["NC_ClassName"].ToString().Trim().Split('|').Length > 1)
                                        {
                                            t = dtClass.Rows[ii]["NC_ClassName"].ToString().Trim().Split('|');
                                        }
                                        else
                                        {
                                            t[0] = dtClass.Rows[ii]["NC_ClassName"].ToString().Trim();
                                            t[1] = "";
                                        }
                                %>
                                <li>
                                    <a style="color: #2d5fde;" href="team.aspx?gid=<%=dtClass.Rows[ii]["nc_id"].ToString().Trim() %>"><%=t[0].Trim()%></a>
                                </li>
                                <%} %>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="row dx1">
                    <%
                        int page = 1;
                        int pageCount = 0;
                        if (!string.IsNullOrEmpty(Request["page"]))
                        {
                            page = Int32.Parse(Request["page"]);
                        }
                        pageCount = page * 4;
                        var n = 0;

                        int tn = dtInfo.Rows.Count > pageCount ? pageCount : dtInfo.Rows.Count;

                        for (int i = (page - 1) * 4; i < tn; i++)
                        {
                            var item = dtInfo.Rows[i];

                    %>
                    <div class="col-lg-3 col-md-6 col-sm-6 col-12">
                        <div class="wrap_employee">
                            <span class="employee_img">
                                <img src="<%= Convert.ToString(item["imgpath"])==""?"images/404-background.jpg":item["imgpath"] %>" alt="<%=item["tname"] %>" />
                            </span>
                            <h3><%=item["tname"] %></h3>
                            <p class="employee_position"><%=item["avater"].ToString() == "0" ? "男" : "女" %></p>
                        </div>
                    </div>
                    <% 
                        } %>

                  	
                    <ul id="cs" style="position: relative; left: 0%; top: 7px;">
                        <% 
                            int totalPage = Convert.ToInt32(Math.Ceiling(dtInfo.Rows.Count / 8M));
                            if (totalPage > 1)
                            {

                                if (page > 1)
                                {
                        %>
                        <a href="team.aspx?gid=<%=Request["gid"] %>&page=<%=page-1 %>">
                            <li><</li>
                        </a>
                        <%
                            }

                        %>
                        <a>
                            <li style="background-color: #337abe; color: #FFFFFF;"><%=page %></li>
                        </a>
                        <%
                            if (page + 1 <= totalPage)
                            {
                        %>
                        <a href="team.aspx?gid=<%=Request["gid"] %>&page=<%=page+1 %>">
                            <li><%=page+1 %> </li>
                        </a>
                        <%
                            }
                            if (page < totalPage)
                            {
                        %>
                        <a href="team.aspx?gid=<%=Request["gid"] %>&page=<%=page+1 %>">
                            <li>></li>
                        </a>
                        <%
                                }
                            }
                        %>
                    </ul>
                </div>
            </div>
        </div>
    </section>
    <!--partners -->

    <!-- footer -->
    <footer id="footer1" class="rafaa-section rp-footer rp-footer-1" style="border: 0px solid #ff0000;">
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
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/odometer.min.js"></script>
    <script src="js/chartjs.js"></script>
    <script src="js/masonary.min.js"></script>
    <script src="js/noframework.waypoints.min.js"></script>
    <script src="js/index.js"></script>
</body>

</html>
