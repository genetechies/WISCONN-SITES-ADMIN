<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="App_Home" %>

<asp:Content ID="Content2" ContentPlaceHolderID="head" Runat="Server">
    
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentBarHolder" Runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/首頁1.jpg" alt="img"/>
            </div>
            <div>
                <img src="images/首頁2.jpg" alt="img"/>
            </div>
            <div>
                <img src="images/首頁3.jpg" alt="img"/>
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    
    <div class="container no-bottom">
        <p class="paragraph">
            后冠日文翻譯公司成立以來，已經承接眾多各類翻譯，累積了多種翻譯經驗，擁有強大的翻譯團隊，盡心盡力為每一位客戶提供超越想像價格和品質，給客戶最優質專業的翻譯服務。
        </p>

        <div class="container">
            <img class="image-decoration2 column-icon" src="images/icons-large/icon6@2x.png" alt="img">
            <a href="AboutUs.aspx"><h6 class="uppercase">關於我們</h6></a>
            <p class="no-bottom">詳細的公司介紹</p> 
        </div> 
            
        <div class="container">
            <img class="image-decoration2 column-icon" src="images/icons-large/icon3@2x.png" alt="img">
            <a href="Service.aspx"><h6 class="uppercase">服務項目</h6></a>
            <p class="no-bottom">多元化不同的服務 </p> 
        </div> 
            
        <div class="container">
            <img class="image-decoration2 column-icon" src="images/icons-large/icon4@2x.png" alt="img">
            <a href="Team.aspx"><h6 class="uppercase">翻譯團隊</h6></a>
            <p class="no-bottom">專業一流的團隊 </p> 
        </div>         

        <div class="container">
            <img class="image-decoration2 column-icon" src="images/icons-large/icon1@2x.png" alt="img">
            <a href="Custom.aspx"><h6 class="uppercase">客戶實績</h6></a>
            <p class="no-bottom">歷年客戶一致推薦 </p> 
        </div>         
           
    </div>
</asp:Content>

