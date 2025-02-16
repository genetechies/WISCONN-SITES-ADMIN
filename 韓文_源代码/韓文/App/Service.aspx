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
        <p class="paragraph">
            后冠韓文翻譯社憑藉多樣化的服務專案和便宜適中的價格，成為眾多客戶推薦的翻譯社隨著翻譯市場的不斷變化，翻譯界的競爭越來越大，后冠韓文翻譯社也不斷地擴寬服務專案，以滿足客戶的需要。
        </p>      
        <p class="paragraph">
            韓文翻譯筆譯服務： <br/>
            后冠韓文翻譯社的筆譯人員擁有專業素養，不僅瞭解翻譯學的理論知識，也具備高度的語言能力，能夠完成精準優秀的翻譯。后冠的筆譯人員也有多年的翻譯經驗，能夠適時調整翻譯內容，以達到客戶的需求，妥善完成翻譯。
        </p>
        <p class="paragraph">
            韓文翻譯網頁翻譯： <br/>
            后冠韓文翻譯社提供專業的網頁翻譯服務。隨著網際網路的發展，網頁成為人們獲取世界各地資訊的重要途徑之一，但如何讓不同語種的網頁傳播給世界各地的人們卻是一個重要的問題。后冠提供雙語網頁翻譯，讓您的網頁能夠發揮更好的效用，讓資訊傳播至世界各地。
        <p class="paragraph">
            韓文翻譯影視翻譯： <br/>
            后冠韓文翻譯社提供的影視翻譯類型包括電影、電視、教材、紀錄片等，服務內容包括配音、剪接、上字幕等。隨著經濟的發展，人們的精神需求也變得愈發多樣化，所以后冠培養了專門的影視翻譯人才，滿足客戶的各項需求。
        <p class="paragraph">
            韓文翻譯打字排版： <br/>
            后冠韓文翻譯社有專業打字排版人員，提供打字服務，並能根據客戶的需求提供相應的版面編排。
        <p class="paragraph">
            如果您有其他服務需求，請聯繫后冠韓文翻譯社，將有專業的服務人員替您服務。
        </p>
    </div>
</asp:Content>

