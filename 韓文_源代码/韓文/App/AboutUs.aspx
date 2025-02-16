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
        <p class="paragraph">后冠韓文翻譯社成立在臺灣臺北，憑藉優越的經濟條件和地理位置，以及后冠自身的實力和管理制度，給客戶卓越的翻譯品質。</p>
        <p class="paragraph">專業<br/>后冠韓文翻譯社的翻譯團隊都有豐富的翻譯經驗，以及相關領域的知識，提供三十多種語言互譯，多樣化的翻譯領域，以絕對的優勢打造最專業的翻譯服務。</p>
        <p class="paragraph">誠信<br/>后冠韓文翻譯社從接洽開始，不管是國際客戶還是單人客戶，都秉持著一貫的誠信熱心。而在完成翻譯之後，我們都按時聯繫客戶，絕不拖延，給客戶最優質的翻譯品質。</p>
        <p class="paragraph">熱忱<br/>后冠韓文翻譯社的服務人員都有著良好的職業態度和專業素養，耐心、細心地替客戶服務，依據客戶需求量身訂做翻譯方案，確保您的滿意！</p>
        <p class="paragraph">
            后冠韓文翻譯社一直在擴展翻譯領域，推進自身的國際化進程，希望能夠為越來越多需要韓文翻譯的客戶服務。
        </p>
    </div>
</asp:Content>

