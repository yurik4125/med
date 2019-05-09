using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment1
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLofin_Click(object sender, EventArgs e)
        {
            int userExists =0;
            string nameProfile = "";
            SqlConnection myConn = new SqlConnection(ConfigurationManager.ConnectionStrings["MedicConnectionString"].ConnectionString);
            myConn.Open();
            String query = "select userID from Medic.dbo.Users where userName = '" + userName.Text.Trim() + "' and password = '" + inputPassword.Text.Trim() + "'";
            SqlCommand command = new SqlCommand(query, myConn);
            try
            {
                 userExists = int.Parse(command.ExecuteScalar().ToString());
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                myConn.Close();
           
            }  
            
            if (userExists>0)
            {
                
                Session["testsession"] =  userName.Text;
                string un = Session["testsession"].ToString();
                Response.Write("Login is successful ");
                String query2 = "select Profile.profileName from Users , Profile, UserProfile" +
                                " where Users.userID = UserProfile.userID and UserProfile.profileID = Profile.profileID and" +
                                " Users.userID = " + userExists + "";
                SqlCommand command2 = new SqlCommand(query2, myConn);
                nameProfile = command2.ExecuteScalar().ToString();
                Session["profile"] = nameProfile;
                Response.Redirect("Home.aspx");




                myConn.Close();
            }
            else
            {
                Response.Write("Invalid Login or Password");
            }

        }
    }
}