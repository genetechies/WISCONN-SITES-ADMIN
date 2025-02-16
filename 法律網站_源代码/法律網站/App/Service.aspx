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
            隨著世界經濟一體化，國際間的商業合作往來愈加密切，愈來愈多的企業開始接觸英文法律合約，因此企業需要並重視法律 文件的翻譯品質。經由品質管控流程系統，確保能提供給客戶優質、高效的法律翻譯服務。

        </p>      
        <p class="paragraph">
            翻譯服務： <br/>
            由資深的法律翻譯師提供您專業、精準的翻譯服務，減少客戶時間成本，只需確認翻譯好的文件，讓您有更多時間作準備。
        </p>
        <p class="paragraph">
            校對服務： <br/>
            由專業人員校對譯文，並根據文件的使用場合針對其重要部分加以把關，確保文件的精確性與邏輯性。        </p>
        <p class="paragraph">
            潤飾服務： <br/>
            根據客戶需求，我們可以提供母語潤飾，將翻譯完成的文件交由母語人士做最後潤飾，讓文章更加順暢，更符合母語人士的閱讀習慣。        </p>
        <p class="paragraph">
            排版服務： <br/>
            法律類文件有其制式化的格式限制，如客戶有需求，我們可以提供相關排版服務。        </p>
        <p class="paragraph">
            專名表服務： <br/>
            我們的翻譯師會挑選原稿中的專有名詞，提供翻譯對照，以利客戶方便確認譯名是否符合其需求。 例如：Audit有審核/審查/稽核等翻譯法，意思都通，但每位客戶需求不同，如不符合其需求，客戶可藉由對照譯名表快速修改譯稿。        </p>
    </div>
</asp:Content>

