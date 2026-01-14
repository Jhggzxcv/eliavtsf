<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="enrollment.aspx.cs" Inherits="enrollment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <h1>הרשמה</h1>

<form runat="server" method="post">
    <table  cellpadding="8">

        <!-- Phone -->
        <tr>
            <td><label for="phone">Phone:</label></td>
            <td>
                <select id="prefix" name="prefix">
                    <option value="0">Prefix</option>
                    <option value="050">050</option>
                    <option value="051">051</option>
                    <option value="052">052</option>
                    <option value="053">053</option>
                </select>
                <input type="text" id="phone" name="phone" placeholder="Phone number">
            </td>
        </tr>

        <tr>
            <td><label for="gmail">Gmail:</label></td>
            <td><input type="text" id="gmail" name="gmail"></td>
        </tr>

        <tr>
            <td><label for="password">Password:</label></td>
            <td><input type="password" id="password" name="password"></td>
        </tr>

        <tr>
            <td>Level:</td>
            <td>
                <input type="radio" id="beginner" name="level" value="Beginner">
                <label for="beginner">Beginner</label><br>

                <input type="radio" id="intermediate" name="level" value="Intermediate">
                <label for="intermediate">Intermediate</label><br>

                <input type="radio" id="expert" name="level" value="Expert">
                <label for="expert">Expert</label>
            </td>
        </tr>

        <tr>
            <td>Interests:</td>
            <td>
                <input type="checkbox" id="computers" name="interests" value="Computers">
                <label for="computers">Computers</label><br>

                <input type="checkbox" id="literature" name="interests" value="Literature">
                <label for="literature">Literature</label><br>

                <input type="checkbox" id="politics" name="interests" value="Politics">
                <label for="politics">Politics</label><br>

                <input type="checkbox" id="sports" name="interests" value="Sports">
                <label for="sports">Sports</label><br>

                <input type="checkbox" id="music" name="interests" value="Music">
                <label for="music">Music</label>
            </td>
        </tr>

        <tr>
            <td><label for="age">Age:</label></td>
            <td>
                <select id="age" name="age">
                    <option value="0">Select age</option>
                    <option value="under18">Under 18</option>
                    <option value="18-25">18–25</option>
                    <option value="26-35">26–35</option>
                    <option value="36-50">36–50</option>
                    <option value="50plus">50+</option>
                </select>
            </td>
        </tr>

        <tr>
            <td colspan="2" style="text-align:center;">
                <input type="submit" value="Submit">
            </td>
        </tr>

    </table>
</form>


</asp:Content>


