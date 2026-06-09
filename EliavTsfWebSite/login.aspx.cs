using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) return;

        string gmail = Request.Form["gmail"];
        string pass = Request.Form["password"];

        if (gmail == "eliavtsf123@gmail.com" && pass == "eliavtsf123")
        {
            Session["nihol"] = "ok";
            Session["userName"] = "מנהל";
            Response.Redirect("manager.aspx");
        }
        else
        {
            string sql = "SELECT * FROM tUsers WHERE gmail = N'" + gmail + "' AND password = N'" + pass + "'";
            DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

            if (dt.Rows.Count == 0)
            {
                Session["userName"] = "אורח";
                st = "אימייל או סיסמה שגויים";
            }
            else
            {
                Session["user"] = "ok";
                Session["userName"] = "רשום";

                string userlevel = dt.Rows[0]["level"].ToString();
                string userinterests = dt.Rows[0]["interests"].ToString();

                // עדכון: שמירה בסשן כדי שהנתונים יישמרו גם במעבר בין דפים!
                Session["userInterests"] = userinterests;
                Session["userLevel"] = userlevel;

                Response.Redirect("search.aspx?interests=" + userinterests + "&level=" + userlevel);
            }
        }
    }
}