<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="APP_AboutUs" %>
<%@ MasterType virtualpath="~/APP/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- slider -->
    <div class="slider">
        <ul class="slides">
            <li>
                <img src="img/aboutus-silder.jpg" alt="">
            </li>
        </ul>
    </div>
    <!-- end slider -->
    
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    我們是跨足兩岸三地的台北翻譯公司，我們多樣化的翻譯服務，包括文件翻譯、論文翻譯、網頁翻譯、影片翻譯、資料翻譯、履歷翻譯、打字、排版和相關的網站/網頁本地化翻譯。
                </p>
                <p class="left-p">
                    如果您的公司有任何翻譯需求，我們提供了一個簡短的試譯服務，使您可以評估的翻譯品質，我們嚴格審查每一份文件，並經驗豐富的管理有效地計畫管理整個翻譯過程，經由管理和校對檢查的準確性，以達到卓越的品質翻譯。
                </p>
            </div>
        </div>
    </div>

    <!-- home portfolio -->
    <div class="section" style="display: none">
        <div class="container">
            <div class="gallery">
                <div class="row">
                    <div class="filtr-container">
                        <div class="col s6 filtr-item col-pd" data-category="1, 3">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

