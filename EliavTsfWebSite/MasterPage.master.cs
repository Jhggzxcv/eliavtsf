using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // קוד טעינת דף המאסטר במידת הצורך
    }

    // פונקציית התנתקות מהמערכת (עבור כפתורי היציאה)
    protected void lnkLogout_Click(object sender, EventArgs e)
    {
        // ניקוי הזיכרון של המשתמש המחובר
        Session.Clear();
        Session.Abandon();

        // העברה חזרה לדף הבית כאורח
        Response.Redirect("home.aspx");
    }
}