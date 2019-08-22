using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FAI_lab2.Models;

namespace FAI_lab2.Controllers
{
    public class HapsiratMappers
    {
        private List<Hapsira> mHapsirat;
        private List<Hapsira> lb;

        public HapsiratMappers(List<Hapsira> g)
        {
            mHapsirat = g;
        }

       

        public void SelectAllHapsirat()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("HapsiratSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Hapsira g = new Hapsira();
                    g.HapsiraID = (int)rdr["HapsiraID"];
                    if (rdr["LlojiID"] != DBNull.Value)
                        g.LlojiID = (int)rdr["LlojiID"];
                    mHapsirat.Add(g);
                    if (rdr["ObjektiID"] != DBNull.Value)
                        g.ObjektiID = (int)rdr["ObjeltiID"];
                    mHapsirat.Add(g);
                    if (rdr["Emri"] != DBNull.Value)
                        g.emri = (string)rdr["Emri"];               
                    mHapsirat.Add(g);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}

  