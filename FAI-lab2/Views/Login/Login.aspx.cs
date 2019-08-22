
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["FAI_Connection"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Login where UserName =@username and Password=@password", con);
            cmd.Parameters.AddWithValue("@username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@password", txtPWD.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            if (txtUserName.Text == "admin")
            {
                Response.Redirect("../Features/About.aspx");
            }
            else if (txtUserName.Text=="maltisa")
            {
                Response.Redirect("../Produktet/Index.aspx");
            }
            else {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username and Password')</script>");

            }


        }
    }
}


