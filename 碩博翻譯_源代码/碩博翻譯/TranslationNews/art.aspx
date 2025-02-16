<%@ Page Language="C#" AutoEventWireup="true" CodeFile="art.aspx.cs" Inherits="translationnews_art" %>

<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>

<!doctype html >
<html lang="en-US">

<head runat="server">
    <meta charset="utf-8">
    <title><%=Title %></title>
    <meta name="description" content= <%= model.D_Description %> />
    <meta name="keywords" content= <%= model.D_Keyword %> />
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,300i,400,500,600,700,800,900" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css" media="all">
    <link rel="stylesheet" href="css/all.min.css" media="all">
    <link rel="stylesheet" href="css/owl.carousel.min.css" media="all">
    <link rel="stylesheet" href="css/light-box.css" media="all">
    <link rel="stylesheet" href="css/tp-animation.css" media="all">
    <link rel="stylesheet" href="css/style.css" media="all">
    <link rel="stylesheet" href="css/responsive.css" media="all">
    <link rel="icon" href="../images/SB.png" type="image/ico" />
</head>

<body>
    <!-- perload section -->
    <div id="preloader">
        <div id="preloader-inner"></div>
    </div>
    <!-- header section -->
    <uc1:top runat="server" ID="top" />
    <!-- breadcrumbs -->
    <section class="rafaa-section r-breadcurmbs">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="wrap_breadcrumbs_col">
                    <!--    <h1 class="l-head">Article
                        </h1> -->
                        
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- feature services -->
    <!--<style type="text/css">
			section{
				border: 1px solid #FF0000;
			}
		</style>-->
    <section class="rafaa-section about-us-features">
        <div class="container" style="position: relative; top: -80px;">
            <div class="row">
                <div class="col-lg-3 col-md-12 col-12" style="width: 20%;">
                    <div style="margin: 0px 0px 10px 0px;">
                     
                        <div class="wrap_about_us">
                        <span class="rp-tip"> Article</span>
							<h2 class="l-head">文章專區</h2>
                          </div>

                   
                    </div>
                    <div>
                        <div>
                            <ul>
                                <%
                                    for (int i = 0; i < dtClass.Rows.Count; i++)
                                    {
                                        string[] t = new String[2];
                                        if (dtClass.Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
                                        {
                                            t = dtClass.Rows[i]["ClassName"].ToString().Trim().Split('|');
                                        }
                                        else
                                        {
                                            t[0] = dtClass.Rows[i]["ClassName"].ToString().Trim();
                                            t[1] = "";
                                        }
                                %>
                                <li>
                                    <a style="color: #2d5fde;" href="/translationnews/index-<%=dtClass.Rows[i]["classid"].ToString().Trim() %>.html"><%=t[0].Trim()%></a>
                                </li>
                                <%} %>
                            </ul>
                        </div>
                    </div>
                </div>
                <div class="col-lg-3 col-md-12 col-12" style="width: 80%;">
                    <table style="width:700px;border:0px;margin:0px;padding:0px;">
                            <tr>
                                <td style="width:699px; height:60px;text-align:center;">
                                    <div class="titlename">
                                        <h1 style="font-size: 18px;"><%=model.D_Title %></h1>
                                    </div>
                                    作者：<%=model.D_Author %> 　　加入時間：<span class="STYLE6"><%=model.D_Time.ToString("yyyy-MM-dd") %></span> 　　點擊次數：<span class="STYLE6"><%=model.D_Count%></span> 次
										<div class="content" style="margin-top: 10px; margin-bottom: 30px; padding: 10px; text-align:left;">
                                            <%=model.D_Content %>
                                        </div>
                                    <div style="margin-bottom: 30px; text-align:left;">
                                        <% if (pre.D_ID > 0)
                                            {
                                        %>
                                        <span style="margin-top: 30px; margin-bottom: 30px;">上一篇：<a href="/translationnews/Art-<%=pre.D_ID %>.html"><%=pre.D_Title %></a></span>
                                            <%
                                                }
                                                else
                                                {%>
                                            <span style="margin-top: 30px; margin-bottom: 30px;">上一篇：無</span>
                                            <%
                                                } %>
                                            <br>
                                                <% if (next.D_ID > 0)
                                                    {
                                                %>
                                                <span style="margin-top: 30px; margin-bottom: 30px;">上一篇：<a href="/translationnews/Art-<%=next.D_ID %>.html"><%=next.D_Title %></a></span>
                                                    <%
                                                        }
                                                        else
                                                        {%>
                                                     <span style="margin-top: 30px; margin-bottom: 30px;">下一篇：無</span>
                                                    <%
                                                        } %>
                                            </div>
                                        <p style="text-align:left;">
                                            我們會不斷的提供最新的翻譯資訊，各篇文章也歡迎轉載(若為同業需簽定轉載同意書)，轉載時請您記得在文章結尾附上出處與官方超連結。附上出處的方式如下：<br>
                                            文章來源 ：碩博
											<a href="https://www.translations.com.tw" title="碩博翻譯社">翻譯社</a> （
											<a href="https://www.translations.com.tw" title="碩博翻譯社">https://www.translations.com.tw</a>）
                                        </p>
                                </td>
                            </tr>
                    </table>
                </div>
            </div>
        </div>
    </section>

    <!--<section class="rafaa-section about-us-features">
			<div class="container">
				<div class="row align-items-center f-service-row">
					<div class="col-lg-6 col-md-12 col-12 col-fs-img">
						<div class="feature-service-img ">
							<img src="images/線上詢價banner1.jpg" alt="join us">
						</div>
					</div>
					<div class="col-lg-6 col-md-12 col-12 col-fs-text">
						<div class="feature-service-content ">
							<h2 class="m-head">線上詢價</span></h2>
							<p>Modern design prioritizes content, which is why we develop visuals that guide users and contextualize information without being distracting. Icons, banners, and other illustrated elements.Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium.</p>
							<a class="f-get-quote" href="#" title="join us">Get Qoute</a>
						</div>
					</div>
				</div>
			</div>
		</section>-->
    <!-- footer -->
    <uc1:foot runat="server" ID="foot" />
    <!-- js library including -->
    <script src="js/jquery.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/odometer.min.js"></script>
    <script src="js/chartjs.js"></script>
    <script src="js/masonary.min.js"></script>
    <script src="js/noframework.waypoints.min.js"></script>
    <script src="js/light-box.js"></script>
    <script src="js/index.js"></script>
</body>

</html>
