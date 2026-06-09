using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

/// <summary>
/// Summary description for MyAdoHelper
/// פעולות עזר לשימוש במסד נתונים מסוג SQL SERVER
/// </summary>
public class MyAdoHelper
{
    // נתיב קובץ הדיביי המעודכן לפרויקט שלך
    private const String dbFileName = "~/app_data/MyDB.mdf";

    public MyAdoHelper()
    {
    }

    /// <summary>
    /// יוצרת קשר אל בסיס הנתונים ומחזירה את אובייקט החיבור
    /// </summary>
    public static SqlConnection ConnectToDb()
    {
        string path = HttpContext.Current.Server.MapPath(dbFileName);
        string connStr = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={0}; Integrated Security = True", path);
        SqlConnection conn = new SqlConnection(connStr);
        return conn;
    }

    /// <summary>
    /// ביצוע שאילתות עדכון / הוספה / מחיקה (עם שני פרמטרים)
    /// </summary>
    public static void DoQuery(string fileName, string sql)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand(sql, conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }

    /// <summary>
    /// תיקון: מימוש המתודה עם פרמטר אחד עבור דף ההרשמה
    /// </summary>
    public static void DoQuery(string sql)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand(sql, conn);
        com.ExecuteNonQuery();
        com.Dispose();
        conn.Close();
    }

    /// <summary>
    /// מריצה שאילתה ומחזירה את מספר השורות שהושפעו
    /// </summary>
    public static int RowsAffected(string sql)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand(sql, conn);
        int rowsA = com.ExecuteNonQuery();
        conn.Close();
        return rowsA;
    }

    /// <summary>
    /// מחזירה אמת אם הרשומה קיימת ושקר אחרת
    /// </summary>
    public static bool IsExist(string sql)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand com = new SqlCommand(sql, conn);
        SqlDataReader data = com.ExecuteReader();
        bool found = data.Read();
        conn.Close();
        return found;
    }

    /// <summary>
    /// תיקון: מימוש מלא למתודה עם פרמטר אחד המשמשת את דפי הלוגין והמנהל שלך
    /// </summary>
    public static DataTable ExecuteDataTable(string sql)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close(); // חובה לסגור חיבור כדי למנוע נעילת הדיביי
        return dt;
    }

    /// <summary>
    /// מתודה עם שני פרמטרים (במידה ויש בה צורך במקומות אחרים)
    /// </summary>
    public static DataTable ExecuteDataTable(string sql, SqlConnection conn)
    {
        conn = ConnectToDb();
        conn.Open();
        SqlDataAdapter tableAdapter = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        tableAdapter.Fill(dt);
        conn.Close();
        return dt;
    }

    /// <summary>
    /// תיקון שורה 126: קריאה למתודה הממומשת ללא העברת משתנה 'conn' חסר
    /// </summary>
    public static string printDataTable(string fileName, string sql)
    {
        // קריאה למתודה התקינה שמנהלת את החיבור בעצמה
        DataTable dt = ExecuteDataTable(sql);

        string printStr = "<table border='1'>";

        foreach (DataRow row in dt.Rows)
        {
            printStr += "<tr>";
            foreach (object myItemArray in row.ItemArray)
            {
                if (myItemArray.GetType().ToString().Equals("System.DateTime"))
                {
                    printStr += "<td>" + ((DateTime)myItemArray).ToShortDateString() + "</td>";
                }
                else
                {
                    printStr += "<td>" + myItemArray.ToString() + "</td>";
                }
            }
            printStr += "</tr>";
        }
        printStr += "</table>";

        return printStr + "<br/>";
    }

    /// <summary>
    /// החזרת ערך בודד מהמסד (לדוגמה COUNT, MAX וכדומה)
    /// </summary>
    public static object GetScalar(string sql)
    {
        SqlConnection conn = ConnectToDb();
        conn.Open();
        SqlCommand comm = new SqlCommand(sql, conn);
        object tmp = comm.ExecuteScalar();
        comm.Dispose();
        conn.Close();
        return tmp;
    }
}