using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class login2aspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            string Username = WebConfigurationManager.AppSettings["PFUsername"];
            string Password = WebConfigurationManager.AppSettings["PFPassword"];
            if (Textbox1.Text == Username || Textbox2.Text == Password)
            {
                Session.Add("UserID", Username);
                Response.Redirect("admin1.aspx");

            }
            else
            {
                Label2.Text = "Please Enter Valid User Name and Password";
            }
        }
    }
}