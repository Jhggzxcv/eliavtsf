<%@ Page Title="ניהול משתמשים" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="manager.aspx.cs" Inherits="manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .manager-table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 15px;
            direction: rtl;
            font-family: Arial, sans-serif;
        }
        .manager-table th, .manager-table td {
            border: 1px solid #cbd5e1;
            padding: 12px;
            text-align: right;
        }
        .manager-table th {
            background-color: #2c3e50;
            color: white;
        }
        .manager-table tr:nth-child(even) {
            background-color: #f8fafc;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div dir="rtl" style="padding: 20px; font-family: Arial, sans-serif;">
        <h2 style="color: #2c3e50;">דף ניהול - משתמשי המערכת</h2>
        <p>צפייה בכלל המשתמשים הרשומים באתר וביצוע חיפוש חלקי (LIKE) במערכת.</p>
        <hr />

        <fieldset style="margin-bottom: 20px; padding: 15px; border: 1px solid #bdc3c7; border-radius: 5px; background-color: #f8f9fa;">
            <legend style="font-weight: bold; padding: 0 10px; color: #2c3e50;">חיפוש משתמשים במערכת</legend>
            <div style="margin-top: 5px;">
                <label for="txtSearch">חפש לפי אימייל (gmail):</label>
                <asp:TextBox ID="txtSearch" runat="server" Style="padding: 6px; width: 250px; border: 1px solid #ccc; border-radius: 4px;"></asp:TextBox>
                
                <asp:Button ID="btnSearch" runat="server" Text="חפש" OnClick="btnSearch_Click" 
                            Style="padding: 6px 15px; background-color: #3498db; color: white; border: none; border-radius: 4px; cursor: pointer;" />
                
                <asp:Button ID="btnClear" runat="server" Text="הצג הכל" OnClick="btnClear_Click" 
                            Style="padding: 6px 15px; background-color: #7f8c8d; color: white; border: none; border-radius: 4px; cursor: pointer; margin-right: 5px;" />
            </div>
        </fieldset>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Font-Bold="true"></asp:Label>
        
        <h3 style="color: #34495e; margin-top: 25px;">רשימת המשתמשים</h3>
        
        <div>
            <%= st %>
        </div>
    </div>
</asp:Content>