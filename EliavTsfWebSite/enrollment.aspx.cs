using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class enrollment : System.Web.UI.Page
{
    public string stResult = "";

    protected void Page_Load(object sender, EventArgs e)
    {
         if (Page.IsPostBack)
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

            MyAdoHelper.DoQuery("MyDB.mdf", strInsert);

            stResult = "OK";


        }
    }
}