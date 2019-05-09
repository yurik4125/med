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
            if (Page.PreviousPage!=null)
            {
                string patID = Session["testsession"].ToString();

                if (string.IsNullOrEmpty(patID))
                {
                    lbLogin.Visible = false;
                    lbUserWellcome.Text = "Wellcome " + Session["userName"].ToString();
                    btnLogOut.Visible = true;

                    switch (Session["profile"])
                    {
                        //case "Administrator":
                        //    Response.Write("Administrator " + Session["userName"].ToString());
                        //    break;
                        case "Practitioner":
                            Response.Write("Practitioner " + Session["userName"].ToString());
                            //Menu2.Items.RemoveAt(1);
                            //Menu2.Items.RemoveAt(3);
                            //Menu2.Items.RemoveAt(4);
                            //Menu2.Items.RemoveAt(5);
                            //Menu2.Items.RemoveAt(6);
                            break;
                        case "Reception":

                            // Menu1.Items.RemoveAt(1);
                            // Menu1.Items[1].Enabled = false;

                            Response.Write("Reception " + Session["userName"].ToString());
                            break;
                            //case "Management":
                            //    lbConsult.Visible = false;
                            //    Response.Write("Management " + Session["userName"].ToString());
                            //    break;


                    }
                }

            }
            else
            {

                Menu1.Items.RemoveAt(1);
                //Menu3.Items.Remove(Menu3.FindItem("Appointment"));
                //Menu3.Items.Remove(Menu3.FindItem("Consultation"));
                //Menu3.Items.Remove(Menu3.FindItem("Diagnostic"));
                //Menu3.Items.Remove(Menu3.FindItem("Procedure"));
                //Menu3.Items.Remove(Menu3.FindItem("Practitioner"));

            }

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Remove("userName");
            Response.Redirect("User.aspx");

        }
    }
}