<%@ Page Title="" Language="C#" MasterPageFile="~/APP/MasterPage.master" AutoEventWireup="true" CodeFile="NewsInfo.aspx.cs" Inherits="APP_NewsInfo" %>
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
                    <%=ClassName %>
                </p>
                <table width="699" border="0" cellspacing="0" cellpadding="0" align="center" style="border: none">
                    <tr >
                        <td width="699" height="60" align="center" style="border: none">
                            <div class="titlename" >
                                <h1 style=" font-size:18px;"><%=moarticle.D_Title%></h1><br/>
                            </div>
                            作者：<%=moarticle.D_Editor%> 　　加入時間：<span class="STYLE6"><%=moarticle.D_Time.ToShortDateString()%></span> 　　點擊次數：：<span class="STYLE6"><%=moarticle.D_Count %></span> 次 
                            <div align="left" style="margin-top:10px; padding:10px;"> 
                                <%=moarticle.D_Content %> 
                                <br/>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
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
    
    <style>
        table {
            display: table;
        }
        
        table, th, td {
            border: 1px solid;
            border-collapse: separate;
            border-spacing: 2px;
            border-color: grey;
        }
    </style>
    <div style="clear:both">&nbsp;</div>
</asp:Content>