<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="translationnews_index" %>

<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>
<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>


<!doctype html >
<html lang="en-US">

<head runat="server">
    <meta charset="utf-8">
    <title>翻譯資訊--碩博企業翻譯社 </title>
    <meta name="description" content="碩博翻譯社是一流水準的專業翻譯公司，我們並擁有經驗豐富的專案人員認真審核以確保最高的翻譯品質。">
    <meta name="keywords" content="翻譯社,翻譯公司" />
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,300i,400,500,600,700,800,900" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css" media="all">
    <link rel="stylesheet" href="css/all.min.css" media="all">
    <link rel="stylesheet" href="css/owl.carousel.min.css" media="all">
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
    <section class="rafaa-section r-breadcurmbs" style="background-image: url(images/翻譯資訊banner.jpg);">
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

    <!-- breadcrumbs -->
    <!--<section class="rafaa-section r-breadcurmbs-2">
			<div class="container">
				<div class="row">
					<div class="col-12">
						<div class="wrap_breadcrumbs_col-2">
							<h1 class="l-head">Blogs
                            </h1>
							<ul class="breadcrumbs_content-2 ">
								<li>
									<a href="#" title="home"> Home </a> /</li>
								<li><span>Blogs</span></li>
							</ul>
						</div>
					</div>
				</div>
			</div>
		</section>-->
    <section class="rafaa-section blogs-page right-sidebar " style="background-color: #f7f8f9;">
        <div class="container">
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
                <div class="col-lg-3 col-md-12 col-12">
                    <table style="width:700px;margin:0px;padding:0px; border:0px;">
                        
                            <tr>
                                <td colspan="2">碩博翻譯不斷精進，希望與您分享我們的成果，迷人的翻譯，讓更多人瞭解！<br data-filtered="filtered">
                                    <br data-filtered="filtered">
                                    文章歡迎自由轉載(若為同業需簽定轉載同意書)，並請附上出處與官方超連結：<br data-filtered="filtered">
                                    文章來源 ：碩博
										<a href="https://www.translations.com.tw" title="碩博翻譯社">翻譯社</a> （
										<a href="https://www.translations.com.tw" title="碩博翻譯社">https://www.translations.com.tw</a>）
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 26px;" colspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">碩博企業翻譯社是一家具有一流水準翻譯人才之企業，並有經驗豐富的專案管理人員進行審核以確保最高的品質。我們提供專業的英文翻譯、日文翻譯、韓文翻譯、網站翻譯、書籍影帶等翻譯服務。我們會不斷的提供最新的翻譯資訊，各篇文章也歡迎轉載，轉載時請您記得在文章結尾附上出處與官方超連結。
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 26px;" colspan="2">
                                    <div><asp:Literal ID="ltArtListTitle" runat="server"></asp:Literal></div>
                                    <div><asp:Literal ID="ltArtListDescription" runat="server"></asp:Literal></div>
                                </td>
                            </tr>
                            <tr>
                                <td style="height: 26px;" colspan="2">&nbsp;</td>
                            </tr>
                            <%
                                int page = 1;
                                int pageCount = 0;
                                if (!string.IsNullOrEmpty(Request["page"]))
                                {
                                    page = Int32.Parse(Request["page"]);
                                }
                                pageCount = page * 30;

                                int tn = dtInfo.Rows.Count > pageCount ? pageCount : dtInfo.Rows.Count;
                                var pageNum = (page - 1) * 30;

                                for (int i = (page - 1) * 30; i < tn; i++)
                                {
                                    var item = dtInfo.Rows[i];
                            %>
                            <tr>
                                <td style="width: 81%; height:26px;">
                                    <a href="Art-<%= item["D_Id"] %>.html" title=""><b>《<%=Utils.SubString(item["D_Title"],30,"...")%>》</b></a>
                                </td>
                                <td style="width: 19%;"><%=Convert.ToDateTime(item["D_Time"]).ToString("yyyy-MM-dd")%></td>
                            </tr>
                            <tr>
                                <td colspan="2"><%=Utils.SubString(item["D_Description"],90,"...")%>
                                </td>
                            </tr>
                            <% 
                                }
                            %>

                            <tr>
                                <td colspan="2" style="border-bottom: #333333 1px dotted; height: 10px;"></td>
                            </tr>

                            <tr>
                                <td style="height: 40px; text-align:center;" colspan="2">



                                    <% 
                                        int totalPage = Convert.ToInt32(Math.Ceiling(dtInfo.Rows.Count / 30M));
                                        if (totalPage > 1)
                                        {

                                    %>
                                     共 <%=totalPage %> 頁
                                            <a href="/translationnews/index-<%=Request["cid"] %>-1.html">[ 頁首 ]</a>
                                    <%
                                        if (page > 1)
                                        {
                                    %>

                                    <a href="/translationnews/index-<%=Request["cid"] %>-<%=page-1 %>.html">[ 上一頁 ]</a>
                                    <%
                                        }

                                    %>
                                    <%
                                        if (page + 1 <= totalPage)
                                        {
                                    %>
                                    <a href="/translationnews/index-<%=Request["cid"] %>-<%=page+1 %>.html">[ 下一頁 ]</a>
                                    <%
                                        }
                                        if (page < totalPage)
                                        {
                                    %>
                                    <a href="/translationnews/index-<%=Request["cid"] %>-<%=page+1 %>.html">[ 頁尾 ]</a>
                                    <%
                                            }
                                        }
                                    %>
                                    轉到
                                    <select name="select" onchange="javascript:window.location='/translationnews/index-<%=Request["cid"] %>-'+this.options[this.selectedIndex].value+'.html'">
                                        <option data-filtered="filtered">跳轉</option>
                                        <% for (int index = 1; index <= totalPage; index++)
                                            {%>
                                        <option value="<%=index %>" data-filtered="filtered">第<%=index %>頁</option>
                                        <%} %>
                                    </select>
                                </td>
                            </tr>
                    </table>
                </div>
            </div>
        </div>
    </section>
    <!-- footer -->
    <uc1:foot runat="server" ID="foot" />
    <!-- js library including -->
    <script src="js/jquery.min.js"></script>
    <script src="js/owl.carousel.min.js"></script>
    <script src="js/odometer.min.js"></script>
    <script src="js/chartjs.js"></script>
    <script src="js/progressbar.min.js"></script>
    <script src="js/noframework.waypoints.min.js"></script>
    <script src="js/masonary.min.js"></script>
    <script src="js/multipleFilterMasonry.js"></script>
    <script src="js/index.js"></script>
</body>

</html>
