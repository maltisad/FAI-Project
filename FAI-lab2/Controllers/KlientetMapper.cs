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
    public class KlientetMapper
    {
        private List<Klienti> mKlientet;

        public KlientetMapper(List<Klienti> k)
        {
            mKlientet=k;
        }

        public void SelectAllKlients()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("KlientiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Klienti k = new Klienti();
                    k.KlientiID = (int)rdr["KlientiID"];
                    if (rdr["Emri"] != DBNull.Value)
                        k.Emri = (string)rdr["Emri"];
                    if (rdr["Mbiemri"] != DBNull.Value)
                        k.Mbiemri= (string)rdr["Mbiemri"];
                    if (rdr["NumriTelefonit"] != DBNull.Value)
                        k.NumriTelefonit= (int)rdr["NumriTelefonit"];
                    if (rdr["Email"] != DBNull.Value)
                        k.Email = (string)rdr["Email"];
                    mKlientet.Add(k);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
