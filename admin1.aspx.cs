using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class admin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            
            if (Textbox1.Text !="" && Textbox2.Text !="" &&  Textbox3.Text !="" &&  Textbox4.Text !="" )
            {
                Session.Add("con_1", Textbox1.Text);
                Session.Add("con_2", Textbox2.Text);
                Session.Add("con_3", Textbox3.Text);
                Session.Add("con_4", Textbox4.Text);
                Response.Redirect("Default.aspx");

            }
            else
            {
                Label2.Text = "please enter all configuraton";
            }
        }
    }
}
      

       