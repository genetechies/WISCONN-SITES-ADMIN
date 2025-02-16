<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="App_News" %>
<%@ Register TagPrefix="uc1" TagName="pager" Src="~/App/Pager.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/翻譯資訊.jpg" alt="img" />
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
                        后冠日語翻譯社多年來承接了多樣化的翻譯類型，尤其是法律和操作手冊方面更是出類拔萃，積累了多年的翻譯經驗。后冠專門組織翻譯師對此進行歸納總結，提供簡單明瞭的翻譯資訊。
                    </p>
                    <p>
                        文章來源 ：后冠日文翻譯社 （<a style="color: blue" href="https://www.translations-jp.com">https://www.translations-jp.com</a>） 
                    </p>
                </div>

                <asp:DropDownList runat="server" ID="ddl_category"
                    AutoPostBack="True"
                    OnSelectedIndexChanged="ddl_category_OnSelectedIndexChanged">
                </asp:DropDownList>

                <!-- features -->
                <div class="features bg-second" style="height: auto">
                    <div class="container page-content" style="background: #f0f4f8; min-height: 75%">
                        <asp:Repeater ID="newrp" runat="server">
                            <ItemTemplate>
                                <table class="table" style="width: 95%" cellspacing="0" cellpadding="0" border="0" >
                                    <tbody>
                                        <tr >
                                            <td height="26" style="width: 81%; padding-left: 15px">
                                                <a href="newsinfo.aspx?id=<%#Eval("D_ID") %>">
                                                    <b style="color:cadetblue"><%# Eval("D_Title")%></b>
                                                </a>
                                            </td>
                                            <td style="width: 19%;"><%# Eval("D_Time", "{0:yyyy-MM-dd}")%></td>
                                        </tr>
                                        <tr style="border-bottom: #333333 1px dotted;">
                                            <td colspan="2" style="padding-left: 15px"><%# Eval("D_Description")%></td>
                                        </tr>
                                    </tbody>
                                </table>
                            </ItemTemplate>
                        </asp:Repeater>

                    </div>
                    
                    <!-- end features -->
                    <uc1:pager runat="server" id="Pager" pagesize="3" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>

