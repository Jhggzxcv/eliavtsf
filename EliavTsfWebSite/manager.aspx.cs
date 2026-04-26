using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Menahel : System.Web.UI.Page
{
    public string st = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (!IsPostBack) return;

        string fn = Request.Form["firstname"];
        string ln = Request.Form["lastname"];


        string sql = "SELECT * FROM TUSERS where " +
            "firstName LIKE N'%" + fn + "%' and "
           +
            "lastName LIKE N'%" + ln + "%'";

        DataTable dt = MyAdoHelper.ExecuteDataTable(sql);

        if (dt.Rows.Count == 0)
        {
            st = "אין נתנוים";
        }
        else
        {

            st += "<table border='1'>";
            st += "<tr>";
            st += "<td> email </td>";
            st += "<td> password </td>";
            st += "<td> firstname </td>";
            st += "<td> lastname </td>";
            st += "<td> region </td>";
            st += "<td> fan </td>";
            st += "<td> age </td>";
            st += "<td> reason </td>";
            st += "<td> players </td>";

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