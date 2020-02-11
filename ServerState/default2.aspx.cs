using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class default2 : System.Web.UI.Page
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