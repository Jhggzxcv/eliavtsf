using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class enrollment : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) return;
        {
                string phone = Request.Form["phone"];
                string password = Request.Form["password"];
                string gmail = Request.Form["gmail"];
                string prefix = Request.Form["prefix"];
                string level = Request.Form["level"];
                string interests = Request.Form["interests"];
                string age = Request.Form["age"];

            string strInsert =
                "INSERT INTO tUsers  " +
                "VALUES ('" + prefix + "', '" + phone + "', '" + gmail + "', '" +
                password + "', '" + level + "', '" + interests + "', '" + age + "')";

            string sql =
           "SELECT * FROM tUsers " +
           "WHERE gmail = N'" + gmail + "'";

            bool exists = MyAdoHelper.IsExist(sql);


            if (exists)
            {
                st = "gmail" + gmail + " קיים במערכת, אנא בחר מייל אחר" + exists;
                // st = "משתמש קיים במערכת עם המייל הזה";
                return;
            }
                MyAdoHelper.DoQuery("MyDB.mdf", strInsert);

            st = "The user has successfully registered";


        }
    }
}