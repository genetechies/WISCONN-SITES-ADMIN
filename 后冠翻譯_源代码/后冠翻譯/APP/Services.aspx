<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="Services.aspx.cs" Inherits="APP_Services" %>
<%@ MasterType virtualpath="~/APP/MasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <!-- slider -->
    <div class="slider">
        <ul class="slides">
            <li>
                <img src="img/service-silder.jpg" alt="">
            </li>
        </ul>
    </div>
    <!-- end slider -->
    
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    后冠翻譯公司提供30多種的各國語言翻譯包含：中文、英文、日文、韓文等語系及多元化的服務項目，包括筆譯、網頁翻譯、影視翻譯、打字排版、聽打逐字稿、錄音配音、網站多語化等相關翻譯技術。
                </p>
            </div>
        </div>
        <table class="table table-bordered" style="margin-left: 20px; margin-right: 20px">
            <tr>
                <td>
                    <span>筆譯服務</span>
                </td>
                <td>
                    <span>翻譯師至少擁有五年以上的翻譯經驗，和許多政府單位以及公司企業，長期合作以來，翻譯品質獲得相當高的好評。</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span>筆譯服務</span>
                </td>
                <td>
                    <span>翻譯師至少擁有五年以上的翻譯經驗，和許多政府單位以及公司企業，長期合作以來，翻譯品質獲得相當高的好評。</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span>校稿潤稿</span>
                </td>
                <td>
                    <span>校對潤稿可將文章更推至精準、順暢，使文章在不同語言間都展現原有風采！</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span>網頁翻譯</span>
                </td>
                <td>
                    <span>網站的中文翻譯或外文翻譯需要高水準的語文表達，跨文化溝通的能力與技巧更是不可或缺。</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span>影視翻譯</span>
                </td>
                <td>
                    <span>系統化、專業化、經驗豐富的軟體後製，從翻譯到配音、剪接、編輯及上字幕，一連串進行準確而快速的後製。</span>
                </td>
            </tr>
            <tr>
                <td>
                    <span>打字排版</span>
                </td>
                <td>
                    <span>各國語言文件（書寫稿）和聲音（對話記錄、語音旁白）打字，並能依造您的需求格式，彈性調整版面設計。</span>
                </td>
            </tr>
        </table>
    </div>

    <!-- home portfolio -->
    <div class="section" style="display: none">
        <div class="container">
            <div class="gallery">
                <div class="row">
                    <div class="filtr-container">
                        <div class="col s6 filtr-item col-pd" data-category="1, 3">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

