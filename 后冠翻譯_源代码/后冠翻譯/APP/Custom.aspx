<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="Custom.aspx.cs" Inherits="APP_Custom" %>
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
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    后冠翻譯公司已成功服務無數國內知名外企業，這些行家的肯定，正是我們品質、價值與服務努力的有力證明！
                </p>
            </div>
            
            <form runat="server">
                <asp:DropDownList runat="server" ID="ddl_category" 
                                  AutoPostBack="True"
                                  OnSelectedIndexChanged="ddl_category_OnSelectedIndexChanged">
                </asp:DropDownList>
            </form>

            <!-- features -->
            <div class="section features bg-second">
                <div class="container">
                        <%
                            string filter = "1=1";
                            if (ddl_category.SelectedItem != null && ddl_category.SelectedItem.Value != "-1")
                            {
                                filter += " AND guoclassid="  + ddl_category.SelectedItem.Value;
                            }

                            var pics = new BLL.guopic().GetList(filter).Tables[0];
                            int totalPage = pics.Rows.Count / 6;
                            for (int i = 0; i < pics.Rows.Count && i < 6; i++)
                            {
                                %>
                                    <% if (i % 2 == 0)
                                       {
                                           %><div class="row"><%
                                       } 
                                    %>
                                            <div class="col s6">
                                                <div class="content" style="height: 150px">
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
                    
                    <%
                            if (totalPage > 0)
                            {%>
                                <div class="row m-bottom">
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

