using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string firstname = Request.Form["firstName"];
        string lastName = Request.Form["lastName"];

        string sql =
            "SELECT * FROM [dbo].[tUsers] " +
            "WHERE FirstName LIKE N '%" + firstname + "%' " +
            "AND LastName LIKE N'%" + lastName + "%'";

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);
    }
}


       
           