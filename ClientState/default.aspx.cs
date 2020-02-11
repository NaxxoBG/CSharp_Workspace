using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (ViewState["clicks"] != null)
        //{
        //    ViewState["clicks"] = (int) ViewState["clicks"] + 1;
        //}
        //else
        //{
        //    ViewState["clicks"] = 1;
        //}
        //Label1.Text = " ViewState clicks: " + ((int) ViewState["clicks"]).ToString();

        //int clicks;
        //int.TryParse(HiddenField1.Value, out clicks);
        //clicks++;
        //HiddenField1.Value = clicks.ToString();
        //Label1.Text = "HiddenField clicks: " + HiddenField1.Value;

        //int cookieClicks;
        //if (Request.Cookies["clicks"] != null)
        //{
        //    cookieClicks = int.Parse(Request.Cookies["clicks"].Value) + 1;
        //}
        //else
        //{
        //    cookieClicks = 1;
        //}

        //Response.Cookies["clicks"].Value = cookieClicks.ToString();
        //Label1.Text = "Cookie clicks: " + cookieClicks.ToString();


        if (!IsPostBack)
        {
            //read the query string
            int queryClicks;
            if (Request.QueryString["clicks"] != null)
            {
                queryClicks = int.Parse(Request.QueryString["clicks"]) + 1;
            }
            else
            {
                queryClicks = 1;
            }
            //define the query string in the hyperlink
            HyperLink1.NavigateUrl += "?clicks=" + queryClicks.ToString();
            Label1.Text = "Query clicks: " + queryClicks.ToString();
        }
    }
}