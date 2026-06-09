<%@ Page Title="אזור מנהל מערכת" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="manager" %>

<asp:Content id="Content1" ContentPlaceHolderID="head" runat="Server">
    <style>
        table { width: 80%; margin: 20px auto; border-collapse: collapse; text-align: center; }
        th, td { padding: 10px; border: 1px solid #ccc; }
        th { background-color: #e2e2e2; }
    </style>
</asp:Content>

<asp:Content id="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h2 style="text-align:center;">ניהול משתמשים במערכת - תצוגת מנהל</h2>
    <div style="text-align: center; margin-top:20px;">
        <%= st %>
    </div>
</asp:Content>