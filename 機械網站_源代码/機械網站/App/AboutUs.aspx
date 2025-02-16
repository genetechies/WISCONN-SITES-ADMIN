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

        <p class="paragraph">后冠是從事翻譯服務多年的機械翻譯公司，在機械翻譯領域經驗豐富，專業的翻譯團隊與成熟的品質管控流程有效保證了我們的服務品質，為我們贏得了客戶的口碑。我們致力於為客戶節省成本，將客戶從繁重的機械翻譯中解放出來，從而在工作中創造更大的財富。后冠擁有最細心、專業的服務人員，以專業的姿態，源源不斷的創新力，立足台灣，為世界各國、各地區的多語種客戶提供高品質的機械翻譯服務。        </p>
    </div>
</asp:Content>

