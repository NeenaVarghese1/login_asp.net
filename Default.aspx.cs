using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class _Default : Page
    {
        private int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                HWSettings Settings = (HWSettings)Application["Settings"];
                LabelDefaultPageText1.Text= Settings.DefaultPageText1;
                if (Session["Counter"] != null && Session["con_1"]!=null && Session["con_2"]!=null && Session["con_3"]!=null && Session["con_4"]!=null)
                {
                    Session["Counter"] = (int)Session["Counter"] + 1;



                    var con_1 = Session["con_1"];
                    var con_2 = Session["con_2"];
                    var con_3 = Session["con_3"];
                    var con_4 = Session["con_4"];

                    int counterValue = (int)Session["Counter"];

                    switch (counterValue)
                    {
                        case 1:
                       
                            Label1.Text = con_1.ToString();
                            break;
                        case 2:
                        
                            Label1.Text = con_2.ToString();
                            break;
                        
                    }

                    if (counterValue == 2)
                    {
                        Session["Counter"] = 0; // Reset the counter after the 8th iteration
                    }
                }

            
                else
                {
                    Session["Counter"] = 0;
                }
            }
            catch(Exception )
            {
            }
        }
    }
}