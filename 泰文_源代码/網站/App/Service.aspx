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
            后冠日文翻譯社的資深翻譯師不僅有深厚的翻譯功底，對於日文文化也是深諳於心，熟練運用專業知識來翻譯。多年來，后冠承接了各類稿件，包括法律、操作手冊、資訊科技、遊戲及一般文件等眾多類別，創造了許多翻譯佳績，因此獲得眾多客戶的推薦，日文翻譯成為后冠的主力翻譯項目之一。
        </p>      

    </div>
</asp:Content>

