using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServerControls
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAdmin.Checked)
            {
                CheckBoxAdmin.Text = "System Administrator";
            }
            else
            {
                CheckBoxAdmin.Text = "Check to set as system administrator.";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LabelInformation.Text = "User information saved.";
        }
    }
}