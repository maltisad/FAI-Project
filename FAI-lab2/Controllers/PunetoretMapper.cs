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
    public class PunetoretMapper
    {
        private List<Punetori> mPunetoret;

        public PunetoretMapper(List<Punetori> p)
        {
            mPunetoret = p;
        }

        public void SelectAllPunetoret()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("PunetoriSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Punetori p = new Punetori();
                    p.PunetoriID = (int)rdr["PunetoriID"];
                    if (rdr["Emri"] != DBNull.Value)
                        p.Emri = (string)rdr["Emri"];
                    if (rdr["Mbiemri"] != DBNull.Value)
                        p.Mbiemri = (string)rdr["Mbiemri"];
                    if (rdr["Gjinia"] != DBNull.Value)
                        p.Gjinia = (string)rdr["Gjinia"];
                    if (rdr["RoliID"] != DBNull.Value)
                        p.RoliID = (int)rdr["RoliID"];
                    if (rdr["NumriPersonal"] != DBNull.Value)
                        p.NumriPersonal = (long)rdr["NumriPersonal"];

                    mPunetoret.Add(p);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
