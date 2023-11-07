using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class SiteMaster : MasterPage
    {
        public bool isLogin = false;

        protected void Page_Load(object sender, EventArgs e)

        {

            LabelCounter.Text = "You are Visitor No" + Application["Counter"].ToString();
            HWSettings Settings = (HWSettings)Application["Settings"];
            if (Session["UserID"] != null)
            {
                ButtonLogin.Visible = false;
                ButtonLogout.Visible = true;
            }

        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            Session.Remove("UserID");
            Session.Remove("Counter");
            Response.Redirect("Default.aspx");


        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            
                Response.Redirect("login.aspx");


        }
    }
}