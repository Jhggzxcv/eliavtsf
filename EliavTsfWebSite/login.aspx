<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    

     <label for="gmail">gmail:</label><br>
     <input type="text" id="gmail" name="gmail" value=""><br>

     <label for="pssword">password:</label><br>
     <input type="text" id="password" name="password" value=""><br>

     <input type="submit" value="Submit">
 

        <% if (!string.IsNullOrEmpty(st))
        { %>
    <div class="msg"><%= st %></div>
    <% } %>
</div>

</asp:Content>

