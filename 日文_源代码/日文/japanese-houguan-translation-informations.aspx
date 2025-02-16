<%@ Page Language="C#" AutoEventWireup="true" CodeFile="japanese-houguan-translation-informations.aspx.cs" Inherits="japanese_houguan_translation_informations" %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>后冠日語翻譯社—最快捷的翻譯資訊，日語翻譯社價位最具競爭力</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9"/>
	<meta name="description" content="后冠日語翻譯社有專門的市場調查人員，及時提供最新、最全面、最細緻的日文翻譯資訊。后冠日語翻譯社提供最經濟實惠的價位。"/>
	<meta name="keywords" content="日語翻譯社、日語翻譯社價位"/>
    <script type="text/javascript" src="js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-full.min.js"></script>
    <script type="text/javascript" src="js/jquery.mousewheel.min.js"></script>
    <script type="text/javascript" src="js/jquery.customscrollbar.min.js"></script>
    <script type="text/javascript" src="js/jquery.pagescroll2id.js"></script>
    <script type="text/javascript" src="js/jquery.stickyfloat.js"></script>
    <script type="text/javascript" src="js/scripts.js"></script>
    <link href="style.css" media="screen" rel="stylesheet" type="text/css"/>
    <link rel="icon" href="images/HG.png" type="image/ico" />
	<style type="text/css">
		.infossss{
			list-style:none;
		}
		.boxall{
			padding: 6px 0px 6px 0px;
			font-size:14px;
			color:#000000;
			float:left;
			width:100%;
			text-align:left;
			border-bottom:1px solid #98927b;
		}
		.boxallinner{
			padding: 0px 0px 0px 0px;
			font-size:13px;
			color:#000000;
			width:100%;
			font-size:13px;
			text-align:left;
			padding:12px;

		}
		.grid_2,.grid_9{
			display:inline;
			float: left;
			position: relative;
			
		}
		.grid_2 {
			width:14.667%;
		}
		.grid_9 {
			width:73.0%;
		}		
		.ttsssdsd{
			height:32px;
			line-height:32px;
			padding-left:12px;
		}
		.ttsssdsd a{
			text-decoration:none;
		}
	</style>
</head>

<body class="page-front">
<form runat="server">
    <div class="header">
        <div class="wrap">
            <a class="logo" title="后冠日文翻譯公司" href="japanese-houguan-translation-index.aspx">后冠日文翻譯公司</a>
            <div id="menu">
				<div class="menu-inner">
                <ul class="level-0">
                    <li><a href="japanese-houguan-translation-index.aspx" title="首頁"><b>首頁</b><br/><span>ホーム</span></a></li>
                    <li><a href="japanese-houguan-translation-about.html" title="關於我們"><b>關於我們</b><br/><span>会社概要</span></a></li>
                    <li><a href="japanese-houguan-translation-service.html" title="服務項目"><b>服務項目</b><br/><span>サービス内容</span></a></li>
                    <li><a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言"><b>翻譯語言</b><br/><span>翻訳対応言語</span></a></li>
                    <li><a href="japanese-houguan-translation-online-price.aspx" title="線上詢價"><b>線上詢價</b><br/><span>翻訳料金</span></a></li>
                    <li><a href="japanese-houguan-translation-faq-problem.html" title="常見問題"><b>常見問題</b><br/><span>よくあるご質問</span></a></li>
					<li><a href="japanese-houguan-translation-contact.html" title="聯繫我們"><b>聯繫我們</b><br/><span>お問い合わせ</span></a></li>
                </ul>
            </div>
			</div>
        </div>
    </div>

    <div id="page" class="content-page">
        <div id="content">
			<div class="slide_main">
				 <div id="top-header-slider" class="section">
                        <div class="slide transition-1">
                            <img src="images/service_bg.png" width="1200" height="245" alt="日文翻譯"/>

                            <div class="text">
                                后冠日語翻譯社為客戶提供快捷的翻譯資訊、至高的翻譯品質和合理的翻譯價位
                            </div>
                        </div>

                        
                        
                    </div>
			</div>
           <div class="wrap">
              
				
				<div class="content" style="margin-top:-23px;">
					<div class="cont-2">
						<div class="left_menu_top" style="height:650px;">
							<div class="title">翻譯資訊 / 翻訳情報</div>
							
							<div class="l-menu">
								<ul>
                                    <li style="display:none"></li>
                                <%System.Data.DataSet dsleft = new DAL.NewsClass().GetList(" ParentID=1 ");
                                      for (int i = 0; i < dsleft.Tables[0].Rows.Count; i++)
                                      {

                                          string[] t = new String[2];
                                          if (dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
                                          {
                                              t = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim().Split('|');
                                          }
                                          else
                                          {
                                              t[0] = dsleft.Tables[0].Rows[i]["ClassName"].ToString().Trim();
                                              t[1] = "";
                                          }
                                          
                                         %>
                                     <li><a href="japanese-houguan-translation-informations.aspx?cid=<%=dsleft.Tables[0].Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a></li>
                                      <%} %>
									
								
								</ul>
							</div>
						</div>
						<div class="left_menu_bottom"></div>
					</div>
					<div class="about-r">
						<div class="top"></div>
						<div class="con-1 clearfix" style="height:740px;background:#ECE1CD url(images/401.png) no-repeat -56px 20px;">
							<div class="con-t-1 clearfix">
								<div class="c-inner clearfix">
									<span>日文翻譯資訊	日本語翻訳情報</span>
								</div>
								<div class="c-l-l" style="width:98%">
									后冠日語翻譯社多年來承接了多樣化的翻譯類型，尤其是法律和操作手冊方面更是出類拔萃，積累了多年的翻譯經驗。后冠專門組織翻譯師對此進行歸納總結，提供簡單明瞭的翻譯資訊。
								</div>
								
								<div class="c-l-l" style="width:98%;padding:3px 12px;"><asp:Literal ID="ltArtListTitle" runat="server"></asp:Literal></div>
								<div class="c-l-l" style="width:98%;padding:3px 12px;"><asp:Literal ID="ltArtListDescription" runat="server"></asp:Literal></div>
							</div>
						<div class="lines clearfix"></div>
						<div class="about-t-t" style="padding-top:24px;">
							<ul class="infossss">
                                 <li style="display:none"></li>
                                <asp:Repeater ID="rep_list" runat="server">
                                <ItemTemplate>
                                <li>
									<div class="boxall">
										<div class="ttsssdsd">
											<div class="grid_9">
												<a href="japanese-houguan-translation-detail.aspx?id=<%# Eval("D_Id") %>" title="<%# Eval("D_Title")%>"><%# Eval("D_Title")%> </a>
											</div>
											<div class="grid_2" style="float:right;text-align:right;">
												<%# Eval("D_Time", "{0:yyyy-MM-dd}")%>
											</div>
										</div>
										<div class="boxallinner">
											<%# Eval("D_Description")%>
										</div>
									</div>
								</li>
                                </ItemTemplate>
                            </asp:Repeater>

							</ul>
							<div id="AspNetPager1">
<webdiyer:aspnetpager id="AspNetPager2" runat="server" PageSize="6" AlwaysShow="false" firstpagetext="首頁" lastpagetext="尾頁"
                            nextpagetext="下一頁" prevpagetext="上一頁" OnPageChanged="AspNetPager2_PageChanged"></webdiyer:aspnetpager>
</div>
						</div>
					</div>
				</div>
			</div>
		</div>
    </div>
</div>
    <div class="footer">
        <div class="wrap">
			<p class="bottom-menu">
				<a href="japanese-houguan-translation-index.aspx" title="首頁">首頁</a>|
				<a href="japanese-houguan-translation-about.html" title="關於我們">關於我們</a>|
				<a href="japanese-houguan-translation-service.html" title="服務項目">服務項目</a>|
				<a href="japanese-houguan-translation-online-price.aspx" title="線上詢價">線上詢價</a>|
				<a href="japanese-houguan-translation-customers.aspx" title="客戶實績">客戶實績</a>|
				<a href="japanese-houguan-translation-language-chinese.html" title="翻譯語言">翻譯語言</a>|
				<a href="japanese-houguan-translation-team.aspx" title="翻譯團隊">翻譯團隊</a>|
				<a href="japanese-houguan-translation-informations.aspx" title="翻譯資訊">翻譯資訊</a>|
				<a href="japanese-houguan-translation-faq-problem.html" title="常見問題">常見問題</a>|
				<a href="japanese-houguan-translation-contact.html" title="聯絡我們">聯絡我們</a>|
				<a href="japanese-houguan-translation-link.aspx" title="友情連結">友情連結</a>|<a href="sitemap/sitemap.xml" title="sitemap">sitemap</a>
			</p>
			<p class="l">Copyrght(c)2016 Houguan Culture Co., Ltd All rights Reserved.</p>
            <p class="r">Tel:(02)2568-3677     Fax:(02)2568-3702     台北市中山區新生北路二段129-2號7F   Inv:25125082</p>
            
        </div>
    </div>
    </form>
</body>
</html>
