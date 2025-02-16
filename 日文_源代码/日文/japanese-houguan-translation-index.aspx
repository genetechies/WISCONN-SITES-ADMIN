<%@ Page Language="C#" AutoEventWireup="true" CodeFile="japanese-houguan-translation-index.aspx.cs" Inherits="japanese_houguan_translation_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>后冠日文翻譯公司—誠信為先，專業為本</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
	<meta http-equiv="X-UA-Compatible" content="IE=EmulateIE9" />
	<meta name="description" content="后冠日文翻譯公司成立以來，已經承接眾多各類翻譯，累積了多種翻譯經驗，擁有強大的翻譯團隊，盡心盡力為每一位客戶提供超越想像價格和品質，給客戶最優質專業的翻譯服務。"/>
	<meta name="keywords" content="日文翻譯公司,日文翻譯,日文翻譯社"/>
    <script type="text/javascript" src="js/jquery-1.7.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-full.min.js"></script>
    <script type="text/javascript" src="js/jquery.mousewheel.min.js"></script>
    <script type="text/javascript" src="js/jquery.customscrollbar.min.js"></script>
    <script type="text/javascript" src="js/jquery.pagescroll2id.js"></script>
    <script type="text/javascript" src="js/jquery.stickyfloat.js"></script>
    <script type="text/javascript" src="js/scripts.js"></script>
    <link href="style.css" media="screen" rel="stylesheet" type="text/css"/>
    <link href="js/jquery.mCustomScrollbar.css" rel="stylesheet" type="text/css"/>
    <link rel="icon" href="images/HG.png" type="image/ico" />
    
    <script type="text/javascript">
        function IsPC() {
            var ie6 = ! -[1, ] && !window.XMLHttpRequest;

            if (/AppleWebKit.*mobile/i.test(navigator.userAgent) || (/MIDP|SymbianOS|NOKIA|SAMSUNG|LG|NEC|TCL|Alcatel|BIRD|DBTEL|Dopod|PHILIPS|HAIER|LENOVO|MOT-|Nokia|SonyEricsson|SIE-|Amoi|ZTE/.test(navigator.userAgent))) {
                if (window.location.href.indexOf("?mobile") < 0) {
                    try {
                        if (/Android|webOS|iPhone|iPod|BlackBerry/i.test(navigator.userAgent)) {
                            //window.location.href="手机页面";
                            this.window.location = '/APP/Home.aspx';
                        } else if (/iPad/i.test(navigator.userAgent)) {
                            //window.location.href="平板页面";
                            this.window.location = '/APP/Home.aspx';
                        }
                        else {
                            //window.location.href="其他移动端页面"
                            this.window.location = '/APP/Home.aspx';
                            
                        }
                    } catch (e) { }
                }
            }

        }
    </script>
</head>
<body class="page-front" onload="IsPC();">
    <div class="header">
        <div class="wrap">
            <a class="logo" title="后冠日文翻譯公司" href="japanese-houguan-translation-index.aspx">后冠日文翻譯公司</a>
            <div id="menu">
				<div class="menu-inner">
                <ul class="level-0">
                    <li class="current"><a href="japanese-houguan-translation-index.aspx" title="首頁"><b>首頁</b><br/><span>ホーム</span></a></li>
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
                            <img src="images/recipe1.png" width="1200" height="245" alt="日文翻譯"/>
                            <div class="text">
                                后冠日文翻譯公司以專業的翻譯團隊、嚴謹的翻譯流程、熱忱的服務給您優質的翻譯
                            </div>
                        </div>
                        <div class="slide transition-1">
                            <div class="img"><img src="images/recipe2.png" width="1200"  height="245" alt="日文翻譯"/></div>
                            <div class="text">
                               后冠日文翻譯公司擁有優質母語翻譯師和耐心、細心的校對人員，為客戶提供最貼切的翻譯
                            </div>
                        </div>
                        <div class="slide transition-1">
                            <div class="img"><img src="images/recipe3.png" width="1200"   height="245" alt="日文翻譯"/></div>
                            <div class="text">
								后冠日文翻譯公司秉持準時而不影響品質的宗旨和為客戶負責的態度完成翻譯
                            </div>
                        </div> 
                    </div>
			</div>
           <div class="wrap">
                <div class="index-content" style="height:720px;">
                    <div class="index-content-detail">
						<ul>
							<li>
								<div class="img"><a href="japanese-houguan-translation-about.html"><img src="images/img1.png" alt="日文翻譯"/></a></div>
								<div class="titles">關於我們 / 会社概要</div>
								<div class="intro">后冠日文翻譯社立足在台北，國際化的腳步一直未停歇，迄今...</div>
								<div class="more"><a href="japanese-houguan-translation-about.html">More>>></a></div>
							</li>
							<li>
								<div class="img"><a href="japanese-houguan-translation-service.html"><img src="images/img2.png" alt="日文翻譯"/></a></div>
								<div class="titles">服務項目 / サービス内容</div>
								<div class="intro">時代的發展與前進代表人們需求的提升，作為服務行業的后冠...</div>
								<div class="more"><a href="japanese-houguan-translation-service.html">More>>></a></div>
							</li>
							<li>
								<div class="img"><a href="japanese-houguan-translation-language-chinese.html"><img src="images/img3.png" alt="日文翻譯"/></a></div>
								<div class="titles">翻譯語言 / 翻訳対応言語</div>
								<div class="intro">后冠為客戶提供日文（日語）翻譯中文和中文翻譯日文（日語...</div>
								<div class="more"><a href="japanese-houguan-translation-language-chinese.html">More>>></a></div>
							</li>
							<li>
								<div class="img"><a href="japanese-houguan-translation-online-price.aspx"><img src="images/img4.png" alt="日文翻譯"/></a></div>
								<div class="titles">線上詢價 / 翻訳料金</div>
								<div class="intro">如果客戶對我們的日文翻譯服務或翻譯價錢有任何問題，都可...</div>
								<div class="more"><a href="japanese-houguan-translation-online-price.aspx">More>>></a></div>
							</li>
							<li>
								<div class="img"><a href="japanese-houguan-translation-contact.html"><img src="images/img5.png" alt="日文翻譯"/></a></div>
								<div class="titles">聯繫我們 / お問い合わ</div>
								<div class="intro">若您有任何需求,可以按照下列方式聯繫我們,我們會在第一時間...</div>
								<div class="more"><a href="japanese-houguan-translation-contact.html">More>>></a></div>
							</li>
							<li>
								<div class="img"><a href="japanese-houguan-translation-faq-problem.html"><img src="images/img6.png" alt="日文翻譯"/></a></div>
								<div class="titles">常見問題 / よくあるご質問-</div>
								<div class="intro">后冠日文翻譯社針對客戶多次提出的問題羅列了專門的表格，...</div>
								<div class="more"><a href="japanese-houguan-translation-faq-problem.html">More>>></a></div>
							</li>
						</ul>
					</div>
				</div>
				
				<div class="content1" style="height:100px">
					<div class="line"></div>
                    <div class="c_l">
						<div class="title">翻譯資訊 / 日本語翻訳情報</div>
						<ul>
                            <li style="display:none"></li>
                        <% BLL.newsdata newdll = new BLL.newsdata();
                           System.Data.DataSet dt = newdll.GetList_top(8, "D_Recycle=0");
                           for (int i = 0; i < dt.Tables[0].Rows.Count; i++)
                           {%>
                               <li><a href="japanese-houguan-translation-detail.aspx?id=<%=dt.Tables[0].Rows[i]["D_Id"].ToString().Trim() %>"><%= dt.Tables[0].Rows[i]["D_Title"].ToString().Length < 11 ? dt.Tables[0].Rows[i]["D_Title"].ToString() : dt.Tables[0].Rows[i]["D_Title"].ToString().Substring(0, 10) + "..."%></a></li>                                   
                               <%
                           };
                            %>
							
						</ul>
					</div>
                    <!--#include file="newspages/downindex.html"-->					
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
<script type="text/javascript">
    $(document).ready(function () {
        $(".index-content-detail img").mouseover(function () {
            $(this).css({ opacity: 0.5 });
            $(this).animate({ 'opacity': 1 }, "slow");
        });
        $(".index-content-detail img").mouseout(function () {
            $(this).css({ opacity: 1 });
            $(this).animate({ 'opacity': 0.5 }, "slow");
        });
    });
</script>
</body>
</html>
