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
        <p class="paragraph">
            后冠法律翻譯社起始於台北，從事法律翻譯服務多年，在法律翻譯領域經驗豐富，專業的翻譯團隊與成熟的品質管控流程保證了我們的服務品質。我們的目標是讓客戶減少成本，同時從繁重的翻譯事務中解放出來，創造更大的財富。
        </p>      
        <p class="paragraph">
            法律文件的翻譯須保持高度的正確性與嚴謹性，字斟句酌，確實、準確的表達文件內容 的意涵與立場，避免後續的糾紛和費用支出。劣質的法律翻譯經常出現歧義與表意不清， 導致客戶必須重複核對與校正內容，更甚者需另外聘請律師提供協助，往往造成時間、人 力和金錢的額外投入與浪費。有鑒於此，后冠特別聘請擁有豐富法律翻譯經驗的翻譯師， 以律師的工作態度、工作技術和工作節奏進行翻譯，為您提供品質值得信賴、專業而嚴謹 的法律翻譯服務。
        </p>
    </div>
</asp:Content>

