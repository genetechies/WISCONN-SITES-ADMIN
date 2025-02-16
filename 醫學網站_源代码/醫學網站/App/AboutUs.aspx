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

        <p class="paragraph">后冠翻譯社秉持實事求是、精益求精的精神，力求為客戶 提供最完善的醫學翻譯，通過多年的經驗總結，我們制定 了嚴苛的管理制度與服務流程以確保翻譯的品質。我們有 嚴格的翻譯師篩選考核制度與完善的內部管理體制，利用網 際網路，實現翻譯師、審校、排版和專案管理人員之間的密 切配合，確保譯文的準確性與高效性。后冠一直致力於打造一個專業、科學的醫藥翻譯、醫療器材翻譯環境，秉 持客戶至上的原則，我們堅持真誠的對待每位客戶，重視 翻譯品質，力求獲得客戶的信賴與支持。藉由一次次的翻 譯實務，我們不斷整理經驗，完善自己，以「專業、嚴謹 、便捷」為目標，為您提供優質、高效的醫學翻譯服務！
        </p>
    </div>
</asp:Content>

