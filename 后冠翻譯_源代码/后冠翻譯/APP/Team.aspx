<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="Team.aspx.cs" Inherits="APP_Team" %>
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
                <img src="img/team-silder.jpg" alt="">
            </li>
        </ul>
    </div>
    <!-- end slider -->
    
    <form runat="server">
    <div class="section we-are">
        <div class="container">
            <div class="section-head">
                <p class="left-p">
                    后冠翻譯公司擁有全球國際不同國家的專業翻譯人才，由世界各地國家級審譯、外籍專家、留學歸國人員以及各大研究院所碩士及博士所組成一流的翻譯精英團隊
                </p>
            </div>
            
                <asp:DropDownList runat="server" ID="ddl_category" 
                                  AutoPostBack="True" 
                                  OnSelectedIndexChanged="ddl_category_OnSelectedIndexChanged">
                </asp:DropDownList>

            <!-- features -->
            <div class="section features bg-second">
                <div class="container" >
                    <asp:Repeater ID="newrp" runat="server" >
 
                        <ItemTemplate>       

                            <table cellpadding="0" cellspacing="0" border="0" style="margin-top:6px;">
                                <tr>
                                    <td width="24">&nbsp;</td>
                                    <td valign="middle">
                                        <span><img src="/<%# Eval("imgpath")%>" alt="英文 校稿" width="160"  /></span>
                                    </td>
                                    <td valign="top">
                                        <div class="team-info">
                                            <font style="color: #75A907">姓名：</font>
                                            <span><%# Eval("tname")%></span>
                                            <br/>
                                            <font style="color: #75A907">性別：</font>
                                            <%# Eval("avater").ToString() == "0" ? "男" : "女"%>
                                            <br/>
                                            <font style="color: #75A907">自我介紹：</font>
                                            <div class="descript"> <%# Eval("descript")%></div>
                                        </div>
                                    </td>
                                </tr>
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

