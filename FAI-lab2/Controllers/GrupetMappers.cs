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
    public class GrupetMappers
    {
        private List<Grupi> mGrupet;

        public GrupetMappers(List<Grupi> g)
        {
            mGrupet = g;
        }

        public void SelectAllGrupet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("GrupiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Grupi g = new Grupi();
                    g.GrupiID = (int)rdr["GrupiID"];
                    if (rdr["Grupi"] != DBNull.Value)
                        g.emriGrupit = (string)rdr["Grupi"];
                    if (rdr["KategoriaID"] != DBNull.Value)
                        g.KategoriaID = (int)rdr["KategoriaID"];
                    mGrupet.Add(g);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
