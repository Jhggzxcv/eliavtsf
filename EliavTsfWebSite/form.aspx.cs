using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class form : System.Web.UI.Page
{
    public string name;
    public string number;
    public string gmail;
    public string note;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack)
        {
            name = "name:" + Request.Form["name1"];
            number = "number:" + Request.Form["number"];
            gmail = "gmail:" + Request.Form["gmail"];
            note = "note:" + Request.Form["note"];
        }
    }
}