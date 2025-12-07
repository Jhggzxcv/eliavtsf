<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="form.aspx.cs" Inherits="form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form>
         <label for="fullName">Full name:</label><br>
         <input type="text" id="name" name="name" value=""><br>

         <label for="number">telepon number:</label><br>
         <input type="text" id="number" name="number" value=""><br>

         <label for="gmail">gmail:</label><br>
         <input type="text" id="gmail" name="gmail" value=""><br>

         <label for="note">note:</label><br>
         <input type="text" id="note" name="note" value=""><br>

         <input type="submit" value="Submit">
 
    </form>
</asp:Content>

