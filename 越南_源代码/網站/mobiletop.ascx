<%@ Control Language="C#" AutoEventWireup="true" CodeFile="mobiletop.ascx.cs" Inherits="mobiletop" %>
<div class="financity-mobile-header-wrap">
    <div class="financity-mobile-header financity-header-background financity-style-slide" id="financity-mobile-header">
        <div class="financity-mobile-header-container financity-container">
            <div class="financity-logo  financity-item-pdlr">
                <div class="financity-logo-inner">
                    <a href="index.aspx">
                        <img src="upload/logo-3.png" alt="軟體翻譯" width="263" height="52"></a>
                </div>
            </div>
            <div class="financity-mobile-menu-right">
                <div class="financity-main-menu-search" id="financity-mobile-top-search"><i class="fa fa-search"></i></div>

                <div class="financity-mobile-menu">
                    <a class="financity-mm-menu-button financity-mobile-menu-button financity-mobile-button-hamburger" href="#financity-mobile-menu"><span></span></a>
                    <div class="financity-mm-menu-wrap financity-navigation-font" id="financity-mobile-menu" data-slide="right">
                        <ul id="menu-main-navigation" class="m-menu">
                            <li class="menu-item menu-item-home current-menu-item page_item page-item-2039 current_page_item">
                                <a href="Vietnam-houguan-translation-index.aspx">首頁</a>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-about.aspx">關於我們</a>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-service-introduce.aspx">服務項目</a>
                                <ul class="sub-menu">
                                    <li class="menu-item">
                                        <a href="Vietnam-houguan-translation-service-introduce.aspx">翻譯流程介紹</a>
                                    </li>
                                    <li class="menu-item">
                                        <a href="Vietnam-houguan-translation-service.aspx">翻譯服務</a>
                                    </li>
                                </ul>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-customers.aspx">客戶實績</a>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-team.aspx">翻譯團隊</a>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-informations.aspx">翻譯資訊</a>
                                <ul class="sub-menu">

                                    <%
                                        for (int i = 0; i < dtNewsClass.Rows.Count; i++)
                                        {
                                            string[] t = new String[2];
                                            if (dtNewsClass.Rows[i]["ClassName"].ToString().Trim().Split('|').Length > 1)
                                            {
                                                t = dtNewsClass.Rows[i]["ClassName"].ToString().Trim().Split('|');
                                            }
                                            else
                                            {
                                                t[0] = dtNewsClass.Rows[i]["ClassName"].ToString().Trim();
                                                t[1] = "";
                                            }
                                    %>
                                     <li class="menu-item">
                                        <a  href="Vietnam-houguan-translation-informations.aspx?cid=<%=dtNewsClass.Rows[i]["classid"].ToString().Trim() %>"><%=t[0].Trim()%></a>
                                    </li>
                                    <%} %>
                                    <li class="menu-item">
                                        <a href="Vietnam-houguan-translation-informations-detl.aspx">翻譯資訊</a>
                                    </li>
                                </ul>
                            </li>

                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-online-price.aspx">線上詢價</a>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-link.aspx">友好連結</a>
                            </li>
                            <li class="menu-item menu-item-has-children">
                                <a href="Vietnam-houguan-translation-contact.aspx">聯繫我們</a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
