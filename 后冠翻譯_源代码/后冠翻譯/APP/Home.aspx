<%@ Page Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true"
         CodeFile="Home.aspx.cs" Inherits="APP_Home" 
         Title="首頁" 
         Description=""  %>
<%@ MasterType virtualpath="~/APP/MasterPage.master" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">

    
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">    
    <!-- slider -->
    <div class="slider">
        <ul class="slides">
            <li>
                <img src="img/home-slide1.jpg" alt="">
            </li>
            <li>
                <img src="img/home-slide2.jpg" alt="">
            </li>
            <li>
                <img src="img/home-slide3.jpg" alt="">
            </li>
        </ul>
    </div>
    <!-- end slider -->

    <!-- we are -->
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <span style="font-size: 14px">位於台北的后冠翻譯公司擁有高素質翻譯專員，由世界各地外籍專家、留學歸國人員以及各大研究所碩士、博士組成，能提供中、英、日、韓、德、俄、西等30多種的語言互譯。</span>
            </div>
        </div>
    </div>
    <!-- and we are -->

    <!-- features -->
    <div class="section features bg-second">
        <div class="container">
            <div class="row">
                <div class="col s6">
                    <div class="content">
                        <a href="/APP/AboutUs.aspx"><h5>關於我們</h5></a>
                        <p>  </p>
                        <p>詳細公司介紹</p>
                    </div>
                </div>
                <div class="col s6">
                    <div class="content">
                        <a href="/APP/Services.aspx"><h5>服務項目</h5></a>
                        <p>  </p>
                        <p>多元不同服務</p>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col s6">
                    <div class="content">
                        <a href="/APP/Custom.aspx"><h5>客戶實績</h5></a>
                        <p>  </p>
                        <p>歷年客戶推薦</p>
                    </div>
                </div>
                <div class="col s6">
                    <div class="content">
                        <a href="/APP/Team.aspx"><h5>翻譯團隊</h5></a>
                        <p>  </p>
                        <p>專業一流團隊</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- end features -->

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
    <style>
        h5 {
            color: blue;
            font-weight:bolder 
        }
    </style>
    </asp:Content>