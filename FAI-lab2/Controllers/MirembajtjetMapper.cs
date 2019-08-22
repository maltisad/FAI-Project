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
    public class MirembajtjetMapper
    {
        private List<Mirembajtja> mMirembajtjet;

        public MirembajtjetMapper(List<Mirembajtja> p)
        {
            mMirembajtjet = p;
        }


        public void SelectAllMirmbajtjet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("MirembajtjaSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Mirembajtja p = new Mirembajtja();

                    p.PunetoriID = (int)rdr["PunetoriID"];
                    if (rdr["PunetoriID"] != DBNull.Value)
                        p.PunetoriID = (int)rdr["PunetoriID"];
                   
                    if (rdr["ProduktiID"] != DBNull.Value)
                        p.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["DataMirmbajtjes"] != DBNull.Value)
                        p.DataMirmbajtjes = (DateTime)rdr["DataMirmbajtjes"];
                    if (rdr["Pershkrimi"] != DBNull.Value)
                        p.Pershkrimi = (string)rdr["Pershkrimi"];

                    mMirembajtjet.Add(p);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}