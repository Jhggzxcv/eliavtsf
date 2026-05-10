<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="enrollment.aspx.cs" Inherits="enrollment" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      
    
     <script  lenguage="javasctipt">

       

         function checkAll() {

             let phoneErr = document.getElementById("phoneErr");
             let LevelErr = document.getElementById("LevelErr");
             let passwordErr = document.getElementById("passwordErr");
             let gmailErr = document.getElementById("gmailErr");


             phoneErr.innerHTML = "";
             LevelErr.innerHTML = "";
             passwordErr.innerHTML = "";
             gmailErr.innerHTML = "";

             let c = true;

             if (checkPhone() == false)
                 c = false;

             if (checkLevel() == false)
                 c = false;

             if (checkPassword() == false)
                 c = false;

             if (checkGmail() == false)
                 c = false;

             return c;
         }

         function checkPassword() {

             let password = document.getElementById("password").value;

             if (password.length < 2 || password.length > 30) {

                 passwordErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         function checkGmail() {

             let email = document.getElementById("gmail").value;

             if (email.length < 5 || email.indexOf("@") == -1) {

                 gmailErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         function checkPhone() {

             let phone = document.getElementById("phone").value;

             if (phone.length < 5 || phone.length > 10 || isNaN(phone)) {

                 phoneErr.innerHTML = "ERROR";
                 return false;
             }

             return true;
         }

         function checkLevel() {

             let Level = document.getElementById("Level").value;

             if (Level == "") {

                 LevelErr.innerHTML = "ERROR";
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


