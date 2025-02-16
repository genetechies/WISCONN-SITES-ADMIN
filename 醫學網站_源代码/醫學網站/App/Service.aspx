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
            隨著科學的進步、世界的發展，國際間的醫學交流往來愈加密切。因應客戶需求，我們可以為您提供客製化服務。我們的主要服務專案包括基礎醫學、臨床醫學、藥學、醫療器材、生技、保健、美容等領域的書籍、論文、雜誌、期刊、實驗報告、病例、說明書、手冊等。

        </p>      

    </div>
</asp:Content>

