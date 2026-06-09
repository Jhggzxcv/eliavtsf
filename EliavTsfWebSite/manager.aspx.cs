using System;
using System.Data;

public partial class manager : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        // חסימת אבטחה קריטית - משתמש שאינו מנהל נזרק לדף ההתחברות
        if (Session["nihol"] == null || Session["nihol"].ToString() != "ok")
        {
            Response.Redirect("login.aspx");
            return;
        }

        // שליפת רשימת המשתמשים כולה להצגה בטבלה
        string sql = "SELECT prefix, phone, gmail, level, interests, age FROM tUsers";
        DataTable dt = MyAdoHelper.ExecuteDataTable(sql, conn);

        if (dt.Rows.Count == 0)
        {
            st = "<p>אין כרגע משתמשים רשומים במסד הנתונים.</p>";
        }
        else
        {
            // בנייה דינמית של טבלת ה-HTML לתוך משתנה המחרוזת הציבורי st
            st = "<table>";
            st += "<tr><th>קידומת</th><th>טלפון</th><th>דואר אלקטרוני</th><th>רמת קריאה</th><th>תחום עניין</th><th>גיל</th></tr>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                st += "<tr>";
                st += "<td>" + dt.Rows[i]["prefix"] + "</td>";
                st += "<td>" + dt.Rows[i]["phone"] + "</td>";
                st += "<td>" + dt.Rows[i]["gmail"] + "</td>";
                st += "<td>" + dt.Rows[i]["level"] + "</td>";
                st += "<td>" + dt.Rows[i]["interests"] + "</td>";
                st += "<td>" + dt.Rows[i]["age"] + "</td>";
                st += "</tr>";
            }
            st += "</table>";
        }
    }
}