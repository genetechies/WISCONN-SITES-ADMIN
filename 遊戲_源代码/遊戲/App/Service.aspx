<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="Service.aspx.cs" Inherits="App_Service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" Runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/服務項目.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div class="container no-bottom">
        <p class="paragraph">電腦遊戲的發展在於全球化</p>
        <p class="paragraph">
            電腦遊戲已經成為一個跨領域、跨國界的大型產業，主要是由於網路技術蓬勃發展，地區、時間之間的界線逐漸模糊，不再成為阻礙。另外遊戲的發展也從單機遊戲發展到線上遊戲，逐漸進入國際市場。
        </p>      
        <p class="paragraph">線上遊戲的地域化</p>
        <p class="paragraph">
            除了線上遊戲需要語言當地化之外，家用的單機遊戲其語言也是相當多元化的。這樣能夠滿足不同需求的客戶，讓遊戲被更多人接受。
        </p>  
        <p class="paragraph">APP遊戲─遊戲翻譯的重點</p>
        <p class="paragraph">
            APP遊戲是近年來新興的一種遊戲，並且在最短的時間內獲得了極大的關注。后冠翻譯公司追隨著時代的步伐，也開始嘗試APP遊戲的翻譯，並探討每個專案的處理方式，以期獲得最佳的翻譯方案及價錢。
        </p>  

    </div>
</asp:Content>

