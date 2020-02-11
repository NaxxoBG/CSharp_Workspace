using System;
using System.Web.UI;

public partial class _default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Application.Lock();
        Application["clicks"] = ((int)Application["clicks"]) + 1;
        Application.UnLock();
        LabelApplicationClicks.Text = "Application clicks: " +
        Application["clicks"].ToString();

        Session["session_clicks"] = (int)Session["session_clicks"] + 1;
        LabelSessionClicks.Text = "Session clicks: " + Session["session_clicks"].ToString();
    }
}