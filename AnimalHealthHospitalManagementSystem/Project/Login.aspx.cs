using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnimalHealthHospitalManagementSystem.Project
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");
        }

        protected void btn_login_b_Click(object sender, EventArgs e)
        {
            if(txt_signup_username.Text == "USER" && txt_signup_pass.Text=="123456")
            {
                Response.Redirect("Appointment.aspx");
            }
            else
            {
                Response.Write("<script>alert('Check username or password')</script>");
            }
        }
    }
}