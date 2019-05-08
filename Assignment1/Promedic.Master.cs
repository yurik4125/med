using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class Promedic : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                lbLogin.Visible = false;
                lbUserWellcome.Text = "Wellcome " + Session["userName"].ToString();
                btnLogOut.Visible = true;
            }
           
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("userName");
            Response.Redirect("User.aspx");
        }
    }
}