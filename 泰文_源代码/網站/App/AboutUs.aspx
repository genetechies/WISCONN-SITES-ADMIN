<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="App_AboutUs" %>

<asp:Content ID="Head" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentBarHolder" runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/關於我們.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="Server">
    <div class="container no-bottom">
        <p class="paragraph">隨著各國的政治、經濟、文化、旅遊等各方面的交流日益頻繁，世界逐步縮小為一個地球村。而語言是人類相互交流溝通的第一工具。那麼不同國籍、不同民族的人要相互交際、來往，就要有翻譯作為媒介。近年來，隨著日本文化在世界各地深入，日文翻譯也開始發展。成立於台北的后冠日文翻譯社以專業、細心立足於翻譯界，為每一個客戶提供最全面、最優質的日文翻譯。</p>
        <p class="paragraph">時代的特徵決定了對日文翻譯人才的大量需求，后冠日文翻譯社擁有強大的翻譯團隊和多樣化的業務的內容，盡力滿足客戶的需求！</p>
    </div>
</asp:Content>

