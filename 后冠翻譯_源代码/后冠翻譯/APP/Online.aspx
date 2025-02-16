<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="Online.aspx.cs" Inherits="APP_Online" %>
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
                <img src="img/aboutus-silder.jpg" alt="">
            </li>
        </ul>
    </div>
    <!-- end slider -->
    
    <form runat="server">
        
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    此系統可以讓您的文件傳至我們的客服人員手中，請填好下列資料，並夾帶檔案，后冠收到後會迅速為您服務以獲得價格和優惠的價錢！
                </p>
            </div>
            <br/>
            <table>
                <tr>
                    <td>
                        <span>姓名</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="tbName"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>電話</span>  
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="tbPhone"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <span>Mail</span>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="tbMail"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        原始語種(從) 
                    </td>
                    <td> <asp:DropDownList ID="ddllanguagefrom" runat="server" Width="93px">
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
                    </td>
                </tr>
                <tr>
                    <td>
                        目地語言(翻譯成) 
                    </td>
                    <td>
                        <asp:DropDownList ID="ddllanguageto" runat="server" Width="95px">
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
                    </td>
                </tr>
                <tr>
                    <td>
                        字數
                    </td>
                    <td>
                        <div style="display: inline-block">
                            
                            <asp:TextBox runat="server" ID="tbCharCount" Width="100px"></asp:TextBox>
                            &nbsp; 字
                        </div>
                    </td>
                </tr>
            </table>
            <asp:Button type="submit" Text="提交" style="margin-left: 200px; width: 80px"  runat="server"
                        OnClick="btnSubmit_Click" />
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

