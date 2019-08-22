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
    public class KategoritMappers
    {
        private List<Kategoria> mKategorit;

        public KategoritMappers(List<Kategoria> k)
        {
            mKategorit = k;
        }

        public void SelectAllKategorit()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("KategoriaSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Kategoria k = new Kategoria();
                    k.KategoriaID = (int)rdr["KategoriaID"];
                    if (rdr["vleraKategorise"] != DBNull.Value)
                        k.Vlera = (int)rdr["vleraKategorise"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
