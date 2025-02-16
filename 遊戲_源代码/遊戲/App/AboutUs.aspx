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
        <p class="paragraph">后冠翻譯公司擁有眾多優秀的翻譯人員，都是以第一母語為優先，保證遊戲語言能符合當地語言習慣。提供的翻譯語言有：中文、英文、日文、韓文、泰文、印尼文、越南文、葡萄牙文、西班牙文、法文、 德文、義大利文……等。 旗下的翻譯人員都是具有各類專業背景且資深的審稿人員。所有的遊戲翻譯人員對於遊戲中的時代背景、遊戲環境、武器名稱等都有一定程度的了解。他們具有語言天賦並了解遊戲特性，將自己從遊戲中獲得的快感成功地用另一種語言傳遞出來，這樣更加能夠感染遊戲的其他使用者，提高遊戲的使用量，給客戶帶來最大的利益。</p>
        <p class="paragraph">我們經驗豐富的翻譯人員和軟體工程師可以將您的產品從語言到形式都符合當地使用習慣，讓你的遊戲完全融入到本地文化當中。</p>
    </div>
</asp:Content>

