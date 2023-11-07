using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["UserID"] == null)
            {
                Response.Redirect("Default.aspx");
                }
            if (!IsPostBack)
            {
                HWSettings Settings = (HWSettings)Application["Settings"];
                TextBoxDefaultPageText.Text = Settings.DefaultPageText1;
            }

        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            HWSettings Settings = (HWSettings)Application["Settings"];
            Settings.DefaultPageText1= TextBoxDefaultPageText.Text ;
            HWManager.SaveSettings(Server.MapPath("~App_Data/Setting.xml"),Settings);
            Application["Settings"]= Settings;
        }
    }
}