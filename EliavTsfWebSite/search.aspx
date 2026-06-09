<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        זה הדף שבו תוכלו למצוא את הספר הבא שלכם!<br>
    </p>
        <% if (!string.IsNullOrEmpty(st))
    { %>
<div class="msg"><%= st %></div>
<% } %>

</asp:Content>