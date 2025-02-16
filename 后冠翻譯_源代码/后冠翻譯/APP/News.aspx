<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="News.aspx.cs" Inherits="APP_News" %>
<%@ MasterType virtualpath="~/APP/MasterPage.master" %>

<%@ Register Src="~/APP/Pager.ascx" TagPrefix="uc1" TagName="Pager" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <!-- slider -->
    <div class="slider">
        <ul class="slides">
            <li>
                <img src="img/news-silder.jpg" alt="">
            </li>
        </ul>
    </div>
    <!-- end slider -->
    
    <form runat="server">
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    后冠翻譯不斷精進，希望與您分享我們的成果，讓更多人瞭解！文章歡迎自由轉載(若為同業需簽定轉載同意書)，並請附上出處與官方超連結：
                </p>
                <p>
                    文章來源 ：后冠翻譯公司 （<a style="color: blue" href="http://www.houguan-translation-services.com/">http://www.houguan-translation-services.com/</a>） 
                </p>
            </div>
            
            <asp:DropDownList runat="server" ID="ddl_category" 
                              AutoPostBack="True" 
                              OnSelectedIndexChanged="ddl_category_OnSelectedIndexChanged">
            </asp:DropDownList>

            <!-- features -->
            <div class="section features bg-second">
                <div class="container" >
                    <asp:Repeater ID="newrp" runat="server">
                        <ItemTemplate>
                            <table width="600" cellspacing="0" cellpadding="0" border="0" style="margin-top: 10px;">
                                <tbody>
                                <tr>
                                    <td height="26" style="width: 81%;">
                                        <a href="newsinfo.aspx?id=<%#Eval("D_ID") %>">
                                            <b><%# Eval("D_Title")%></b>
                                        </a>
                                    </td>
                                    <td style="width: 19%;"><%# Eval("D_Time", "{0:yyyy-MM-dd}")%></td>
                                </tr>
                                <tr style="border-bottom: #333333 1px dotted;">
                                    <td colspan="2"><%# Eval("D_Description")%></td>
                                </tr>
                                </tbody>
                            </table>
                        </ItemTemplate>
                    </asp:Repeater>
                    <uc1:Pager runat="server" id="Pager" PageSize="3" />
                    
            </div>
            <!-- end features -->
        </div>
    </div>
    </div>
    </form>
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

