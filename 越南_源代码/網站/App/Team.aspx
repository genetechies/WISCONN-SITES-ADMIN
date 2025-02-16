<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="Team.aspx.cs" Inherits="App_Team" %>

<%@ Register Src="~/App/Pager.ascx" TagPrefix="uc1" TagName="Pager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">

    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/翻譯團隊.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" runat="Server">

    <form runat="server">
        <div class="container no-bottom">
            <p class="paragraph">
                翻翻譯師應該具備廣博的世界觀，同時具備專業領域的基礎知識。而后冠日文翻譯公司的翻譯師不僅了解日本的經濟政治文化，還具備優秀的日文專業知識及語言能力。
            </p>
            <p class="paragraph">
                此外，還有母語翻譯師加入后冠，讓我們的日文翻譯團隊更加強大，也能更加方便、更加專業的為客戶提供優質翻譯。
            </p>
            <asp:DropDownList runat="server" ID="ddl_category"
                AutoPostBack="True"
                OnSelectedIndexChanged="ddl_category_OnSelectedIndexChanged">
            </asp:DropDownList>
            
            <div class="decoration"></div>
            <!-- features -->
            <div class="features">
                <div class="container">
                    <div class="container">
                        <asp:Repeater ID="newrp" runat="server">
                            <ItemTemplate>

                                <table class="table" cellpadding="0" cellspacing="0" border="0" style="margin-top: 6px;">
                                    <tr>
                                        <td width="24">&nbsp;</td>
                                        <td valign="middle" style="width: 80px !important">
                                            <span>
                                                <img src="/<%# Eval("imgpath")%>" alt="英文 校稿" width="80" /></span>
                                        </td>
                                        <td valign="top">
                                            <div class="team-info">
                                                <font style="color: #75A907">姓名：</font>
                                                <span><%# Eval("tname")%></span>
                                                <br />
                                                <font style="color: #75A907">性別：</font>
                                                <%# Eval("avater").ToString() == "0" ? "男" : "女"%>
                                                <br />
                                                <font style="color: #75A907">自我介紹：</font>
                                                <div class="descript"><%# Eval("descript")%></div>
                                            </div>
                                        </td>
                                    </tr>
                                </table>

                            </ItemTemplate>
                        </asp:Repeater>
                    </div>

                    
                    <div class="decoration"></div>
                    <uc1:Pager runat="server" ID="Pager" PageSize="3" />
                </div>
                <!-- end features -->
            </div>
        </div>
    </form>
    <style>
        .team-info {
            display:block;
            width:auto; padding-left:20px;padding-top:16px;
            background:url(images/teambg.jpg) no-repeat;
            background-size: 200px 100px; 
        }
    </style>

</asp:Content>

