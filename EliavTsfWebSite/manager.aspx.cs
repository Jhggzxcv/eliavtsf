using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class manager : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack) return;

        string fn = Request.Form["gmail"];
        string ln = Request.Form["password"];


        string sql = "SELECT * FROM TUSERS where " +
            "gmail LIKE N'%" + fn + "%' and "
           +
            "password LIKE N'%" + ln + "%'";

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        if (dt.Rows.Count == 0)
        {
            st = "אין נתנוים";
        }
        else
        {

            st += "<table border='1'>";
            st += "<tr>";
            st += "<td> gmail </td>";
            st += "<td> password </td>";
            st += "<td> age </td>";
          

            st += "</tr>";

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                st += "<tr>";
                for (int k = 0; k < dt.Columns.Count; k++)
                {
                    st += "<td>" + dt.Rows[i][k] + "</td>";
                }
                st += "</tr>";
            }
            st += "</table>";
        }
    }
}