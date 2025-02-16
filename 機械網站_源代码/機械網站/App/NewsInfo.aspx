<%@ Page Title="" Language="C#" MasterPageFile="~/App/MasterPage.master" AutoEventWireup="true" CodeFile="NewsInfo.aspx.cs" Inherits="App_NewsInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
    <meta name="description" content="<%=Description%>"/>
    <meta name="keywords" content="<%=Keywords%>" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentBarHolder" Runat="Server">
    <div class="bxslider-wrapper" data-snap-ignore="true">
        <div class="bxslider">
            <div>
                <img src="images/翻譯資訊.jpg" alt="img" />
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder" Runat="Server">
    <div class="features bg-second">
        <div class="container">
            <div class="section-head">
                <p class="top-title left-p ">
                    <%=ClassName %>
                </p>
                <table class="table" width="699" border="0" cellspacing="0" cellpadding="0" align="center" >
                    <tr >
                        <td width="699" height="60" align="center" style="border: none;">
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
    
    <style>
        .top-title {
            color: #256775;
            font-size: 15px;
            font-weight: bold;
            line-height: 24px;
            margin-bottom: 12px;
        }
        .left-p {
            font-size: 14px;
            text-align: left
        }
        .section-head {
            margin: 0 auto 25px auto;
            text-align: center;
        }
    </style>
</asp:Content>

