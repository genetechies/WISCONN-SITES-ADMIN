<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="xunjia_index" %>

<%@ Register Src="~/foot.ascx" TagPrefix="uc1" TagName="foot" %>
<%@ Register Src="~/top.ascx" TagPrefix="uc1" TagName="top" %>



<!doctype html >
<html lang="en-US">
  <link rel="icon" href="images/SB.png" type="image/ico" />
<head runat="server">
    <meta charset="utf-8">
    <title>線上詢價_碩博企業翻譯社 </title>
    <meta name="description" content="翻譯的品質是生存和發展的命脈，碩博翻譯社擁有翻譯品質控制系統，能有效地確保從承接業務到翻譯、審稿校稿、排版、印刷等全過程達到“完美”流程。">
    <meta name="keywords" content="翻譯社線上詢價" />
    <link href="https://fonts.googleapis.com/css?family=Poppins:300,300i,400,500,600,700,800,900" rel="stylesheet">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <link rel="stylesheet" href="css/bootstrap.min.css" media="all">
    <link rel="stylesheet" href="css/all.min.css" media="all">
    <link rel="stylesheet" href="css/owl.carousel.min.css" media="all">
    <link rel="stylesheet" href="css/light-box.css" media="all">
    <link rel="stylesheet" href="css/tp-animation.css" media="all">
    <link rel="stylesheet" href="css/style.css" media="all">
    <link rel="stylesheet" href="css/responsive.css" media="all">
    <style>
                    @media (min-width: 769px) {
                        #weizi {
                            width: 100%;
                            height: 600px;
                        }
                    }

                    @media (max-width: 991px) {
                        .guh {
                            display: none;
                        }

                        #weizi {
                            width: 100%;
                            height: 200px;
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
    <!-- breadcrumbs -->
    <section class="rafaa-section r-breadcurmbs">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="wrap_breadcrumbs_col">
                    <!--    <h1 class="l-head">Inquiry
                        </h1>  -->
                       
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
                <div class="col-lg-6 col-md-12 col-12">
                     <div style="margin: 0px 0px 10px 0px;">
                        <div class="wrap_about_us">
                        <span class="rp-tip"> Inquiry</span>
							<h2 class="l-head">線上詢價</h2>
                          </div>

                    </div>


              
                  
                    <div style="position: relative; left: 100px; margin-bottom:10px;">
                        這個系統可以便捷的將您的文件交與我們，經過評估，<br class="guh" />
                        您便可以收到報價評估單，歡迎使用！
                    </div>
                    <form name="form1" runat="server">
                        <table style="width:700px;border:0px;">
                            <tbody>
                                <tr>
                                    <td style="width: 90px; height: 25px;">聯繫人</td>
                                    <td style="width: 610px;">
                                        <input name="L_name" type="text" id="username" runat="server" maxlength="50"></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">聯繫電話</td>
                                    <td>
                                        <input name="L_tel" type="text" id="tel" runat="server" maxlength="50"></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">Email</td>
                                    <td>
                                        <input name="L_email" type="text" id="email" runat="server" maxlength="50"></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">服務項目</td>
                                    <td>
                                        <asp:DropDownList ID="ddltranslationskill" runat="server" >
                                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                                            <asp:ListItem Value="2">文件翻譯</asp:ListItem>
                                            <asp:ListItem Value="3">論文翻譯</asp:ListItem>
                                            <asp:ListItem Value="4">書籍翻譯</asp:ListItem>
                                            <asp:ListItem Value="5">網頁翻譯</asp:ListItem>
                                            <asp:ListItem Value="6">軟體翻譯</asp:ListItem>

                                        </asp:DropDownList></td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">原稿語言</td>
                                    <td>
                                        <asp:DropDownList ID="ddllanguagefrom" runat="server" onchange="showZT(this.value);">
                                            <asp:ListItem Value="中文繁體">中文繁體</asp:ListItem>
                                            <asp:ListItem Value="中文簡體">中文簡體</asp:ListItem>
                                            <asp:ListItem Value="英文">英文</asp:ListItem>
                                            <asp:ListItem Value="韓文">韓文</asp:ListItem>
                                            <asp:ListItem Value="德文">德文</asp:ListItem>
                                            <asp:ListItem Value="法文">法文</asp:ListItem>
                                            <asp:ListItem Value="日文">日文</asp:ListItem>
                                            <asp:ListItem Value="西班牙文">西班牙文</asp:ListItem>
                                            <asp:ListItem Value="義大利文">義大利文</asp:ListItem>
                                            <asp:ListItem Value="其他">其他</asp:ListItem>
                                        </asp:DropDownList>
                                        <span id="info" style="display: none">備注：
                                    		<input name="origin" type="text" size="15" maxlength="50">
                                        </span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">欲翻譯之語言</td>
                                    <td>
                                        <asp:DropDownList ID="ddllanguageto" runat="server" onchange="showZT2(this.value);">
                                            <asp:ListItem Value="中文繁體">中文繁體</asp:ListItem>
                                            <asp:ListItem Value="中文簡體">中文簡體</asp:ListItem>
                                            <asp:ListItem Value="英文">英文</asp:ListItem>
                                            <asp:ListItem Value="韓文">韓文</asp:ListItem>
                                            <asp:ListItem Value="德文">德文</asp:ListItem>
                                            <asp:ListItem Value="法文">法文</asp:ListItem>
                                            <asp:ListItem Value="日文">日文</asp:ListItem>
                                            <asp:ListItem Value="西班牙文">西班牙文</asp:ListItem>
                                            <asp:ListItem Value="義大利文">義大利文</asp:ListItem>
                                            <asp:ListItem Value="其他">其他</asp:ListItem>
                                        </asp:DropDownList>
                                        <span id="info1" style="display: none">備注：
                                   	 		<input name="origin1" type="text" size="15" maxlength="50">
                                        </span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">專業領域</td>
                                    <td>
                                        <asp:DropDownList runat="server" ID="zhuanye">
                                            <asp:ListItem Value="金融保險">金融保險</asp:ListItem>
                                            <asp:ListItem Value="法律學">法律學</asp:ListItem>
                                            <asp:ListItem Value="航太">航太</asp:ListItem>
                                            <asp:ListItem Value="農林魚牧學">農林魚牧學</asp:ListItem>
                                            <asp:ListItem Value="藥學">藥學</asp:ListItem>
                                            <asp:ListItem Value="計算機科學">計算機科學</asp:ListItem>
                                            <asp:ListItem Value="電腦及網絡">電腦及網絡</asp:ListItem>
                                            <asp:ListItem Value="環境工程">環境工程</asp:ListItem>
                                            <asp:ListItem Value="物理化學">物理化學</asp:ListItem>
                                            <asp:ListItem Value="建築工程">建築工程</asp:ListItem>
                                            <asp:ListItem Value="觀光服務">觀光服務</asp:ListItem>
                                            <asp:ListItem Value="其他人文學">其他人文學</asp:ListItem>
                                            <asp:ListItem Value="藝術">藝術</asp:ListItem>
                                            <asp:ListItem Value="企業管理學">企業管理學</asp:ListItem>
                                            <asp:ListItem Value="大眾傳播學">大眾傳播學</asp:ListItem>
                                            <asp:ListItem Value="醫學">醫學</asp:ListItem>
                                            <asp:ListItem Value="政治學">政治學</asp:ListItem>
                                            <asp:ListItem Value="貿易行銷學">貿易行銷學</asp:ListItem>
                                            <asp:ListItem Value="哲學">哲學</asp:ListItem>
                                            <asp:ListItem Value="工業技術學">工業技術學</asp:ListItem>
                                            <asp:ListItem Value="公共衛生學">公共衛生學</asp:ListItem>
                                            <asp:ListItem Value="心理學">心理學</asp:ListItem>
                                            <asp:ListItem Value="生物學">生物學</asp:ListItem>
                                            <asp:ListItem Value="地質學">地質學</asp:ListItem>
                                            <asp:ListItem Value="其他自然科學">其他自然科學</asp:ListItem>
                                            <asp:ListItem Value="社會學">社會學</asp:ListItem>
                                            <asp:ListItem Value="軍事">軍事</asp:ListItem>
                                            <asp:ListItem Value="氣象學">氣象學</asp:ListItem>
                                            <asp:ListItem Value="海洋學">海洋學</asp:ListItem>
                                            <asp:ListItem Value="教育">教育</asp:ListItem>
                                            <asp:ListItem Value="統計學">統計學</asp:ListItem>
                                            <asp:ListItem Value="會計學">會計學</asp:ListItem>
                                            <asp:ListItem Value="經濟學">經濟學</asp:ListItem>
                                            <asp:ListItem Value="運輸通信">運輸通信</asp:ListItem>
                                            <asp:ListItem Value="數學類">數學類</asp:ListItem>
                                            <asp:ListItem Value="歷史">歷史</asp:ListItem>
                                            <asp:ListItem Value="警政">警政</asp:ListItem>
                                            <asp:ListItem Value="體育">體育</asp:ListItem>
                                            <asp:ListItem Value="其他">其他</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">字數</td>
                                    <td>
                                        <input type="text" id="translationamount" runat="server" onblur="check(document.getElementById('zishu'))">
                                        <asp:DropDownList ID="ddltranslationtype" runat="server">
                                            <asp:ListItem Value="字">字</asp:ListItem>
                                            <asp:ListItem Value="頁">頁</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">文件需求描述</td>
                                    <td>
                                         <asp:TextBox ID="ttbNotes" runat="server" Columns="73" Rows="4" TextMode="MultiLine"
                            Width="483px"></asp:TextBox>
                                        </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">交件時間</td>
                                    <td>
                                        <asp:DropDownList ID="posttimeY" runat="server">
                                            <asp:ListItem Value="" >請選擇年</asp:ListItem>

                                            
                                            <asp:ListItem Value="2024">2024</asp:ListItem>
                                            <asp:ListItem Value="2025">2025</asp:ListItem>
                                            <asp:ListItem Value="2026">2026</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="posttimeM" runat="server">
                                            <asp:ListItem Value="" Selected="selected">選擇月</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:DropDownList ID="posttimeD" runat="server">
                                            <asp:ListItem Value="" Selected="selected">選擇日</asp:ListItem>
                                            <asp:ListItem Value="1">1</asp:ListItem>
                                            <asp:ListItem Value="2">2</asp:ListItem>
                                            <asp:ListItem Value="3">3</asp:ListItem>
                                            <asp:ListItem Value="4">4</asp:ListItem>
                                            <asp:ListItem Value="5">5</asp:ListItem>
                                            <asp:ListItem Value="6">6</asp:ListItem>
                                            <asp:ListItem Value="7">7</asp:ListItem>
                                            <asp:ListItem Value="8">8</asp:ListItem>
                                            <asp:ListItem Value="9">9</asp:ListItem>
                                            <asp:ListItem Value="10">10</asp:ListItem>
                                            <asp:ListItem Value="11">11</asp:ListItem>
                                            <asp:ListItem Value="12">12</asp:ListItem>
                                            <asp:ListItem Value="13">13</asp:ListItem>
                                            <asp:ListItem Value="14">14</asp:ListItem>
                                            <asp:ListItem Value="15">15</asp:ListItem>
                                            <asp:ListItem Value="16">16</asp:ListItem>
                                            <asp:ListItem Value="17">17</asp:ListItem>
                                            <asp:ListItem Value="18">18</asp:ListItem>
                                            <asp:ListItem Value="19">19</asp:ListItem>
                                            <asp:ListItem Value="20">20</asp:ListItem>
                                            <asp:ListItem Value="21">21</asp:ListItem>
                                            <asp:ListItem Value="22">22</asp:ListItem>
                                            <asp:ListItem Value="23">23</asp:ListItem>
                                            <asp:ListItem Value="24">24</asp:ListItem>
                                            <asp:ListItem Value="25">25</asp:ListItem>
                                            <asp:ListItem Value="26">26</asp:ListItem>
                                            <asp:ListItem Value="27">27</asp:ListItem>
                                            <asp:ListItem Value="28">28</asp:ListItem>
                                            <asp:ListItem Value="29">29</asp:ListItem>
                                            <asp:ListItem Value="30">30</asp:ListItem>
                                            <asp:ListItem Value="31">31</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">交件方式</td>
                                    <td>
                                        <span style="background-color: #ededed; border-bottom: solid 1px #cccccc;">
                                            <asp:DropDownList ID="ctl00_ContentPlaceHolder1__to_type" runat="server">
                                                <asp:ListItem Value="Email">Email</asp:ListItem>
                                                <asp:ListItem Value="檔案">檔案</asp:ListItem>
                                                <asp:ListItem Value="文件">文件</asp:ListItem>
                                                <asp:ListItem Value="光盤">光碟</asp:ListItem>
                                            </asp:DropDownList>
                                        </span>
                                    </td>
                                </tr>
                                <tr>
                                    <td style="height: 25px;">
                                        <div id="div" dir="ltr">附件</div>
                                    </td>
                                    <td>
                                        <asp:FileUpload ID="file1" runat="server" />
                                    </td>
                                </tr>
                                <tr>
                                    <td></td>
                                    <td>&nbsp; 
                                             <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click"
                                                 Text="確定送出" />
                                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="重新填寫" />
                                </tr>
                            </tbody>
                        </table>
                    </form>
                </div>
                


                <div id="weizi" class="col-lg-6 col-md-12 col-12">
                    <div>
                        <div class="wrap_about_video">
                        <img src="../aboutus/css/imgs/business_city.jpg" style="width: 100%; height: 100%;" alt="video" />
                            </div>
                    </div>
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
    <script src="js/masonary.min.js"></script>
    <script src="js/noframework.waypoints.min.js"></script>
    <script src="js/light-box.js"></script>
    <script src="js/index.js"></script>
</body>

</html>
