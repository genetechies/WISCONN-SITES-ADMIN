<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="Online.aspx.cs" Inherits="App_Online" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/線上詢價.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="Server">
    <form runat="server">

        <div class="section we-are">
            <div class="container">
                <div class="section-head">
                    <p class="left-p">
                        如果您想儘快獲得高品質、高效率、合理價位的翻譯服務，請聯繫我們吧！
                    </p>
                </div>
                <br />
                <fieldset>
                    <div class="formFieldWrap">
                        <label class="field-title contactNameField" >姓名:<span>(required)</span></label>
                        <asp:TextBox runat="server" ID="tbName" CssClass="contactField" />
                    </div>           
                    <div class="formFieldWrap">
                        <label class="field-title contactNameField" >電話:<span>(required)</span></label>
                        <asp:TextBox runat="server" ID="tbPhone" CssClass="contactField" />
                    </div>              
                    <div class="formFieldWrap">
                        <label class="field-title contactNameField" >Mail:<span>(required)</span></label>
                        <asp:TextBox runat="server" ID="tbMail" CssClass="contactField" />
                    </div> 
                    <div class="formFieldWrap">
                        <label class="field-title contactNameField">原始語種(從) :<span>(required)</span></label>
                        <asp:DropDownList ID="ddllanguagefrom" runat="server" Width="93px" CssClass="contactField">
                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                            <asp:ListItem>英文</asp:ListItem>
                            <asp:ListItem>日文</asp:ListItem>
                            <asp:ListItem>繁中</asp:ListItem>
                            <asp:ListItem>簡中</asp:ListItem>
                            <asp:ListItem>韓文</asp:ListItem>
                            <asp:ListItem>菲文</asp:ListItem>
                            <asp:ListItem>德文</asp:ListItem>
                            <asp:ListItem>西文</asp:ListItem>
                            <asp:ListItem>法文</asp:ListItem>
                            <asp:ListItem>俄文</asp:ListItem>
                            <asp:ListItem>義文</asp:ListItem>
                            <asp:ListItem>葡文</asp:ListItem>
                            <asp:ListItem>荷文</asp:ListItem>
                            <asp:ListItem>波蘭</asp:ListItem>
                            <asp:ListItem>阿拉文</asp:ListItem>
                            <asp:ListItem>越文</asp:ListItem>
                            <asp:ListItem>泰文</asp:ListItem>
                            <asp:ListItem>馬來文</asp:ListItem>
                            <asp:ListItem>印尼文</asp:ListItem>
                            <asp:ListItem>其它</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="formFieldWrap">
                        <label class="field-title contactNameField">目地語言(翻譯成) :<span>(required)</span></label>
                        <asp:DropDownList ID="ddllanguageto" runat="server" Width="93px" CssClass="contactField">
                            <asp:ListItem Value="0">請選擇</asp:ListItem>
                            <asp:ListItem>英文</asp:ListItem>
                            <asp:ListItem>日文</asp:ListItem>
                            <asp:ListItem>繁中</asp:ListItem>
                            <asp:ListItem>簡中</asp:ListItem>
                            <asp:ListItem>韓文</asp:ListItem>
                            <asp:ListItem>菲文</asp:ListItem>
                            <asp:ListItem>德文</asp:ListItem>
                            <asp:ListItem>西文</asp:ListItem>
                            <asp:ListItem>法文</asp:ListItem>
                            <asp:ListItem>俄文</asp:ListItem>
                            <asp:ListItem>義文</asp:ListItem>
                            <asp:ListItem>葡文</asp:ListItem>
                            <asp:ListItem>荷文</asp:ListItem>
                            <asp:ListItem>波蘭</asp:ListItem>
                            <asp:ListItem>阿拉文</asp:ListItem>
                            <asp:ListItem>越文</asp:ListItem>
                            <asp:ListItem>泰文</asp:ListItem>
                            <asp:ListItem>馬來文</asp:ListItem>
                            <asp:ListItem>印尼文</asp:ListItem>
                            <asp:ListItem>其它</asp:ListItem>
                        </asp:DropDownList>
                        <div class="formFieldWrap">
                            <label class="field-title contactNameField" >字數:<span>(required)</span></label>
                            <asp:TextBox runat="server" ID="tbCharCount" CssClass="contactField" />
                        </div> 
                    </div>
                    <asp:Button CssClass="no-bottom demo-button button-minimal yellow-minimal" type="submit" Text="提交" runat="server"
                                OnClick="btnSubmit_Click" />
                </fieldset>
            </div>
        </div>
    </form>

    <style>
        td {
            font-size: 14px;
        }

            td span {
            }

        td {
            padding: 2px;
        }

        input {
            vertical-align: middle
        }
    </style>
</asp:Content>

