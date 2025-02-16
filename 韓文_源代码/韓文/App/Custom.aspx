<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="Custom.aspx.cs" Inherits="App_Custom" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" Runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/客戶實績.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
        <!-- end slider -->
    <div class="container no-bottom">
            <p class="paragraph">
                后冠韓文翻譯堅持提供經濟實惠的價格做廣受客戶推薦的翻譯社市場是無限的，客源是無窮的。后冠韓文翻譯公司希望能夠憑藉傲人的客戶實績，爭取更多客戶的青睞與推薦！
            </p>
            <form runat="server">
                <asp:DropDownList runat="server" ID="ddl_category" 
                                  AutoPostBack="True"
                                  OnSelectedIndexChanged="ddl_category_OnSelectedIndexChanged">
                </asp:DropDownList>
            </form>
 
            <!-- features -->
            <div class="section features">
                <div class="container">
                    <div class="page-content">
                        <%
                            string filter = "1=1";
                            if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
                            {
                                filter += " AND guoclassid="  + ddl_category.SelectedItem.Value;
                            }
 
                            var pics = new BLL.guopic().GetList(filter).Tables[0];
                            int totalPage = pics.Rows.Count / 6 + 1;
                            for (int i = 0; i + 6*CurPage < pics.Rows.Count && i < 6; i++)
                            {
                        %>
                            <% if (i % 2 == 0)
                               {
                            %><div class="row"><%
                                       } 
                                                              %>
                            <div class="col s6">
                                <div class="content" style="height: 200px">
                                    <img src="/<%=pics.Rows[i+6*CurPage]["pic"].ToString().Trim() %>" width="120" height="60" />
                                    <p style="margin-top: 15px"><%= pics.Rows[i+6*CurPage]["title"] %></p>
                                </div>
                            </div>                      
                            <% if (i % 2 == 1)
                               {
                            %></div><%
                                       } 
                                                    %>
                        <%
                            }
 
                        %>

                    </div>
                    
                    <div class="decoration"></div>
                    <%
                        if (totalPage > 0)
                        {%>
                            <div class="row m-bottom" style="vertical-align: bottom">
                                <div class="col s12">
                                    <div class="shop-pagination">
                                        <ul>
                                            <%
                                                for (int i = 0; i < totalPage; i++)
                                                {
                                                    %><li <%
                                                                if (i == CurPage)
                                                                {
                                                                    %>class="active"<%
                                                                }
                                                            %>>
                                                        <a href="/APP/Custom.aspx?page=<%=i%>"><%=(i+1) %></a>
                                                    </li><%
                                                }
                                            %>
                                        </ul>
                                    </div>
                                </div>
                            </div>
 
                            <%
                        } 
                    %>
                </div>
            </div>
            <!-- end features -->
        </div>
</asp:Content>

