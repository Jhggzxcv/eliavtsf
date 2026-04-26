using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) return;

        string email = Request.Form["email"];
        string pass = Request.Form["password"];

        if (email == "orimenal@gmail.com" && pass == "manael123")
        {
            Session["nihol"] = "ok";
            Session["userName"] = "מנהל";
            Response.Redirect("menahel.aspx");

        }
        else
        {

            string sql =
                "SELECT * FROM [dbo].[table] " +
                "WHERE email = N'" + email + "' " +
                "AND password = N'" + pass + "'";



            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                Session["userName"] = "אורח";
                st = "אימייל או סיסמה שגויים";

            }
            else
            {
                //st = "משתמש אותר בהצלחה";
                Session["user"] = "ok";
                Session["name"] = dt.Rows[0]["fn"];
                Response.Redirect("home.aspx");

            }
        }
    }
}