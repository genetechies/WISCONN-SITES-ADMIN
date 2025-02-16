<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ProClass.ascx.cs" Inherits="ProClass" %>
<%@ Import Namespace="System.Linq" %>
<div class="product clearfix">
    <div class="p_left">
        <div class="p_title">
            <p class="toggleMenu">產品專區</p>
        </div>
        <ul class="p_toggle list_drop dn">
            <%
                var parents = proClassList.Where(w => w.PC_ParentID == 0);
                foreach (var parent in parents)
                {%>
            <li>
                <div class="p_category">
                    <span class="label">
                        <%=parent.PC_ClassName %></span>
                    <span class="arrow up"></span>
                </div>
                <span class="no">
                    <ul class="list_menu">
                        <% var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id);
                            foreach (var child in childs)
                            {
                        %>
                        <li><a href='Products-sublist.aspx?PC_Id=<%=child.PC_Id%>'><i></i><%=child.PC_ClassName %> </a></li>
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
    <h1 class="title">產品專區</h1>
    <ul>
        <%
            foreach (var parent in parents)
            {%>

        <li>
            <a href='Products-list.aspx?PC_Id=<%=parent.PC_Id %>'><span><%=parent.PC_ClassName %></span></a>
            <ul class="subnav">
                <% 
                    var childs = proClassList.Where(w => w.PC_ParentID == parent.PC_Id);
                    foreach (var child in childs)
                    {
                %>
                <li><a href='Products-sublist.aspx?PC_Id=<%=child.PC_Id%>'><%=child.PC_ClassName %> </a></li>
                <%
                    }
                %>
            </ul>
        </li>
        <% }
        %>
    </ul>
    <a href="https://molex.wisconn.com.tw/Index-en.aspx" > <img src="../Content/images/MOLEX.png" skyle="width: 325px ; height: 100px;" /  alt="connector supplier, connector manufacturer, FPC connector" ></a>
                            <a href="https://molex.wisconn.com.tw/Index-en.aspx" >找不到您需要的產品？ <br> 請點擊這裡。 </a>
</aside>
