using System;
using System.Web;
using System.Web.UI;

public partial class search : System.Web.UI.Page
{
    public string st = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        string interests = "";
        string level = "";

        if (Request.QueryString["interests"] != null) interests = Request.QueryString["interests"].Trim();
        if (Request.QueryString["level"] != null) level = Request.QueryString["level"].Trim();

        if (string.IsNullOrEmpty(interests) && Session["userInterests"] != null)
        {
            interests = Session["userInterests"].ToString().Trim();
        }
        if (string.IsNullOrEmpty(level) && Session["userLevel"] != null)
        {
            level = Session["userLevel"].ToString().Trim();
        }

        if (string.IsNullOrEmpty(interests) || string.IsNullOrEmpty(level))
        {
            st = "לא התקבלו נתוני חיפוש. אנא התחבר מחדש למערכת.";
            return;
        }

        string cleanedInterests = interests.ToLower();
        string cleanedLevel = level.ToLower();

        st = "התקבלו נתונים (" + interests + " + " + level + "), אך לא נמצא ספר מתאים בקוד.";

        // --- קטגוריית מחשבים (שימוש ב-Contains במקום ==) ---
        if (cleanedInterests.Contains("computers") && cleanedLevel == "beginner") st = "כדאי לך לקרוא את הספר מבוא למדעי המחשב";
        if (cleanedInterests.Contains("computers") && cleanedLevel == "intermediate") st = "כדאי לך לקרוא את הספר מדעי המחשב אלגוריתמים";
        if (cleanedInterests.Contains("computers") && cleanedLevel == "expert") st = "כדאי לך לקרוא את הספר התעשייה של הבינה המלאכותית";

        // --- קטגוריית ספרות ---
        if (cleanedInterests.Contains("literature") && cleanedLevel == "beginner") st = "כדאי לך לקרוא את הספר הנסיך הקטן";
        if (cleanedInterests.Contains("literature") && cleanedLevel == "intermediate") st = "כדאי לך לקרוא את הספר החטא ועונשו";
        if (cleanedInterests.Contains("literature") && cleanedLevel == "expert") st = "כדאי לך לקרוא את הספר יוליסס";

        // --- קטגוריית פוליטיקה ---
        if (cleanedInterests.Contains("politics") && cleanedLevel == "beginner") st = "כדאי לך לקרוא את הספר דמוקרטיה בשישים שניות";
        if (cleanedInterests.Contains("politics") && cleanedLevel == "intermediate") st = "כדאי לך לקרוא את הספר ההיסטוריה הדיומאית של הפוליטיקה";
        if (cleanedInterests.Contains("politics") && cleanedLevel == "expert") st = "כדאי לך לקרוא את הספר האמנה החברתית";

        // --- קטגוריית ספורט ---
        if (cleanedInterests.Contains("sports") && cleanedLevel == "beginner") st = "כדאי לך לקרוא את הספר סודות האטלטיקה";
        if (cleanedInterests.Contains("sports") && cleanedLevel == "intermediate") st = "כדאי לך לקרוא את הספר הפסיכולוגיה של הספורט";
        if (cleanedInterests.Contains("sports") && cleanedLevel == "expert") st = "כדאי לך לקרוא את הספר מדעי האימון המתקדם";

        // --- קטגוריית מוזיקה ---
        if (cleanedInterests.Contains("music") && cleanedLevel == "beginner") st = "כדאי לך לקרוא את הספר מדריך לנגינה בגיטרה";
        if (cleanedInterests.Contains("music") && cleanedLevel == "intermediate") st = "כדאי לך לקרוא את הספר תולדות המוזיקה הקלאסית";
        if (cleanedInterests.Contains("music") && cleanedLevel == "expert") st = "כדאי לך לקרוא את הספר תאוריית המוזיקה הרמוניה וקונטרפונקט";
    }
}