using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FAI_lab2.Controllers
{
    public static class Generals
    {
        static public SqlConnection GetNewConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["FAI_Connection"].ConnectionString;

            SqlConnection con = new SqlConnection(conStr);
            try
            {
                con.Open();
                return con;
            }
            catch
            {
                con.Close();
                throw new Exception("Lidhja me databaz nuk mund te realizohet");
            }
        }
    }
}
