using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAI_lab2.Controllers
{
    public class LoginMapper
    {
        private Login mLogin;

        public LoginMapper(Login l)
        {
            mLogin = l;
        }

        public void Login()
        {

            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("UserLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@username", mLogin.username);
                cmd.Parameters.AddWithValue("@password", mLogin.password);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
