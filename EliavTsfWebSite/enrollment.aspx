<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="enrollment.aspx.cs" Inherits="enrollment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      
    
     <script  lenguage="javasctipt">

       

         function checkAll() {

             document.getElementById("phoneErr").innerHTML = "";
             document.getElementById("LevelErr").innerHTML = "";
             document.getElementById("passwordErr").innerHTML = "";
             document.getElementById("gmailErr").innerHTML = "";

             let c = true;

             if (!checkPhone()) c = false;
             if (!checkLevel()) c = false;
             if (!checkPassword()) c = false;
             if (!checkGmail()) c = false;

             if (c == false) {
                 document.getElementById("formErr").innerHTML = "ERROR";
             }

             return c;
         }

         function checkPassword() {

             let password = document.getElementById("password").value;
             let passwordErr = document.getElementById("passwordErr");

             if (password.length < 2 || password.length > 30) {
                 passwordErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         function checkGmail() {

             let email = document.getElementById("gmail").value;
             let gmailErr = document.getElementById("gmailErr");

             let pattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

             if (!pattern.test(email)) {
                 gmailErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         function checkPhone() {

             let phone = document.getElementById("phone").value;
             let phoneErr = document.getElementById("phoneErr");

             if (phone.length < 5 || phone.length > 10 || !/^\d+$/.test(phone)) {
                 phoneErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         function checkLevel() {

             let level = document.getElementById("Level").value;
             let levelErr = document.getElementById("LevelErr");

             if (level === "") {
                 levelErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         

       

     </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <h1>הרשמה</h1>

<form runat="server" method="post" onsubmit="return checkAll();">
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
                    <option value="054">054</option>
                    <option value="055">055</option>
                    <option value="056">056</option>
                    <option value="057">057</option>
                    <option value="058">058</option>
                    <option value="059">059</option>
                </select>
               
                <input type="text" id="phone" name="phone" placeholder="Phone number">
            </td>
            <td id="phoneErr"></td>
        </tr>

        <tr>
            <td><label for="gmail">Gmail:</label></td>
            <td><input type="text" id="gmail" name="gmail"></td>
            <td id="gmailErr"></td>
        </tr>

        <tr>
            <td><label for="password">Password:</label></td>
            <td><input type="password" id="password" name="password"></td>
            <td id="passwordErr"></td>
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
            <td id="LevelErr"></td>
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
            <td id="interestsErr"></td>
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
            <td id="ageErr"></td>
        </tr>

        <tr>
            <td colspan="2" style="text-align:center;">
                <input type="submit" value="Submit">
            </td>
        </tr>

    </table>
</form>
        <% if (!string.IsNullOrEmpty(st))
        { %>
    <div class="msg"><%= st %></div>
    <% } %>


</asp:Content>


