using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class entry : System.Web.UI.Page

{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            string gmail = Request.Form["gmail"];
            string password = Request.Form["password"];

            string sql =
              "SELECT * FROM tUsers " +
                 "WHERE gmail = N'" + gmail + "' " +
                  "AND Password = N'" + password + "'";
            bool userExists = MyAdoHelper.IsExist(sql);
            if (!userExists)
            {
                st = "אימייל או סיסמה שגויים";
            }
            else
            {
                Response.Redirect("home.aspx");
            }


        }


    }
}