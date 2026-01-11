<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="enrollment.aspx.cs" Inherits="enrollment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


     <form runat="server" method="post">
          <label for="gmail">gmail:</label><br>
          <input type="text" id="gmail" name="gmail" value=""><br>

           <label for="password">password:</label><br>
           <input type="text" id="password" name="password" value=""><br>

           <%=password %><br />
           <%=gmail %><br />
     </form>

</asp:Content>


