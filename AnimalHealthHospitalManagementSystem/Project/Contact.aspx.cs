﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace AnimalHealthHospitalManagementSystem.Project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\asp.net\AnimalHealthHospitalManagementSystem\AnimalHealthHospitalManagementSystem\App_Data\AnimalHospital.mdf;Integrated Security=True");
            SqlCommand cmd;
            con.Open();

            try
            {
                string str = "insert into TBContact values('"+txt_feedbake_name.Text+"','"+txt_feedbake_Email.Text+"','"+txt_feedbake_msg.Text+"')";
                cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Feedback Send Sucessfully')</script>");
                con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }
    }
}