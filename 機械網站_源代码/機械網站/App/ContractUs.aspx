<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="ContractUs.aspx.cs" Inherits="App_ContractUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" Runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>                                                                                    
                <img src="images/聯絡我們.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    后冠翻譯公司的客服人員，都是親切且具高度專業性的，可針對客戶的需求及用途，訂定出最佳的翻譯專案，請聯絡我們！
                </p>
            </div>
            <table class="table" >
                <tr>
                    <td>
                        TEL：
                    </td>
                    <td>
                        <a href="tel:+886-2-2568-3677">+886-2-2568-3677</a>
                    </td>
                </tr>
                <tr>
                    <td>
                        FAX：
                    </td>
                    <td>
                        +886-2-2568-3702
                    </td>
                </tr>
                <tr>
                    <td>
                        E-mail：
                    </td>
                    <td>
                        <a href="mailto:service@crowns.com.tw">service@crowns.com.tw</a>
                    </td>
                </tr>
                <tr>
                    <td>
                        地址：
                    </td>
                    <td>
                        <a href="https://www.google.com.tw/maps/place/%E5%90%8E%E5%86%A0%E7%BF%BB%E8%AF%91%E7%A4%BE/@25.0601912,121.527909,15z/data=!4m5!3m4!1s0x0:0x7bdf362f85ed0e38!8m2!3d25.0601912!4d121.527909">台北市中山區新生北路二段129-2號7F</a>
                    </td>
                </tr>
                <tr>
                    <td>
                        官網：
                    </td>
                    <td>
                        <a href="http://translation.crowns.com.tw">http://translation.crowns.com.tw</a>
                    </td>
                </tr>
                <tr>
                    <td>
                        上班時間：
                    </td>
                    <td>
                        星期一至星期五 AM 9:00 ～ PM 6:00
                    </td>
                </tr>
            </table>
            <p>
                請點選<a href="Online.aspx">線上詢價</a>，我們將會有客服人員與您聯絡。
            </p>
        </div>
    </div>
    <style>
        td {
            padding: 2px
        }
        a {
            color: blue;
            font-weight:bolder 
        }
    </style>
</asp:Content>
