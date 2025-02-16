<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Pager.ascx.cs" Inherits="APP_Pager" %>
<div class="row" style="vertical-align: bottom">
    <div class="col s12">
        <div class="shop-pagination">
            <ul>
                <asp:Repeater runat="server" ID="rep">
                    <ItemTemplate>
                        <li class="<%# Eval("Style") %>">
                            <asp:LinkButton runat="server" ToolTip='<%#Eval("ID")%>' Text='<%#Eval("Text")%>' OnClick="LinkButton_Click" />
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </div>
</div>