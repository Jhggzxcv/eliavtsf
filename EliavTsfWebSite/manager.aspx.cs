using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

public partial class manager : System.Web.UI.Page
{
    private string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True";

    // הגדרת משתנה הסטרינג הציבורי בדיוק כמו שביקשת!
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindUsersGrid();
        }
    }

    // מתודה לשליפת המשתמשים והרכבת טבלת טקסט בתוך st
    private void BindUsersGrid(string searchTerm = "")
    {
        // תיקון השאילתה: שליפת כל העמודות האמיתיות שקיימות אצלך בבסיס הנתונים
        string query = "SELECT prefix, phone, gmail, password, level FROM Users";

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query += " WHERE gmail LIKE @search";
        }

        using (SqlConnection conn = new SqlConnection(connString))
        {
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");
                }

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);

                        // אם לא חזרו שורות מהחיפוש
                        if (dt.Rows.Count == 0)
                        {
                            st = "<b style='color:orange;'>לא נמצאו משתמשים התואמים לחיפוש זה.</b>";
                            return;
                        }

                        // התחלת בניית טבלת ה-HTML בתוך משתנה הסטרינג st
                        string tableHtml = "<table class='manager-table'>";
                        tableHtml += "<tr><th>קידומת</th><th>טלפון</th><th>אימייל (Gmail)</th><th>סיסמה</th><th>רמת משתמש</th></tr>";

                        // לולאה שעוברת שורה-שורה ומחלצת את הנתונים לתוך הסטרינג
                        foreach (DataRow row in dt.Rows)
                        {
                            tableHtml += "<tr>";
                            tableHtml += "<td>" + row["prefix"] + "</td>";
                            tableHtml += "<td>" + row["phone"] + "</td>";
                            tableHtml += "<td>" + row["gmail"] + "</td>";
                            tableHtml += "<td>" + row["password"] + "</td>";
                            tableHtml += "<td>" + row["level"] + "</td>";
                            tableHtml += "</tr>";
                        }

                        tableHtml += "</table>";

                        // השמת הטבלה המוכנה לתוך st כדי שהדף יציג אותה
                        st = tableHtml;
                        lblMessage.Text = "";
                    }
                    catch (Exception ex)
                    {
                        lblMessage.Text = "שגיאה בחיבור למסד הנתונים: " + ex.Message;
                    }
                }
            }
        }
    }

    // לחיצה על כפתור חיפוש
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string searchWord = txtSearch.Text.Trim();
        BindUsersGrid(searchWord);
    }

    // לחיצה על כפתור הצג הכל
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtSearch.Text = "";
        BindUsersGrid();
    }
}