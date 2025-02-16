<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProClass.ascx.cs" Inherits="ProClass" %>
<%@ Import Namespace="System.Linq" %>
<div class="product clearfix">
    <div class="p_left">
        <div class="p_title">
            <p class="toggleMenu">Connector Product</p>
        </div>
        <ul class="p_toggle list_drop dn">
            <%
                var parents = proClassList.Where(w => w.PC_ParentID == 0);
                foreach (var parent in parents)
                {%>
            <li>
                <div class="p_category">
                    <span class="label">
                        <%=parent.PC_ClassNameEn %></span>
                    <span class="arrow up"></span>
                </div>
                <span class="no">
                    <ul class="list_menu">
                        <% var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id);
                            foreach (var child in childs)
                            {
                        %>
                        <li><a href='Connector-Products-sublist.aspx?PC_Id=<%=child.PC_Id%>'><i></i><%=child.PC_ClassNameEn %> </a></li>
                        <%
                            }
                        %>
                    </ul>
                </span>
            </li>
            <% }
            %>
        </ul>
    </div>
</div>
<aside id="sidebar" class="col-md-3 right_sidebar  right_sidebar_product">
    <h1 class="title">CONNECTOR PRODUCT</h1>
    <ul>
        <%
            foreach (var parent in parents)
            {%>

        <li>
            <a href='Connector-Products-list.aspx?PC_Id=<%=parent.PC_Id %>'><span><%=parent.PC_ClassNameEn %></span></a>
            <ul class="subnav">
                <% 
                    var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id);
                    foreach (var child in childs)
                    {
                %>
                <li><a href='Connector-Products-sublist.aspx?PC_Id=<%=child.PC_Id%>'><%=child.PC_ClassNameEn %> </a></li>
                <%
                    }
                %>
            </ul>
        </li>
        <% }
        %>
    </ul>
    <a href="http://molex.wisconn.com.tw/Index-en.aspx" > <img src="../Content/images/MOLEX.png" skyle="width: 325px ; height: 100px;" /  alt="connector supplier, connector manufacturer, FPC connector" ></a>
                            <a href="http://molex.wisconn.com.tw/Index-en.aspx" >Cannot find the products you need? <br> Please click here. </a>
</aside>
