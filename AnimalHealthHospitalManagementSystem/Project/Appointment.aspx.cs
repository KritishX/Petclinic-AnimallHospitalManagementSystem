using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AnimalHealthHospitalManagementSystem.Project
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Appointmnet_Submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\AnimalHealthHospitalManagementSystem\AnimalHealthHospitalManagementSystem\App_Data\AnimalHospital.mdf;Integrated Security=True");
            SqlCommand cmd;
            con.Open();

            try
            {
                string str = "insert into TBRegistrations values('"+DropDownList_Section_1.SelectedValue.ToString()+"','"+txt_Appoint_name_1.Text+"','"+DropDownList_gender_1.SelectedValue.ToString()+"',"+txt_Apoint_Mobile_1.Text+",'"+txt_Apoint_Email_1.Text+"','"+txtDate.Text+"')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Appointment Confirm')</script>");
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}