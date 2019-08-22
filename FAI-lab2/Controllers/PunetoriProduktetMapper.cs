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
    public class PunetoriProduktetMapper
    {
        private List<PunetoriProdukti> mPunetoriProduktet;

        public PunetoriProduktetMapper(List<PunetoriProdukti> p)
        {
            mPunetoriProduktet = p;
        }


        public void SelectAllPunetoretProduktet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("PunetoriProduktiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    PunetoriProdukti p = new PunetoriProdukti();

                    p.PunetoriID = (int)rdr["PunetoriID"];
                    if (rdr["PunetoriID"] != DBNull.Value)
                        p.PunetoriID = (int)rdr["PunetoriID"];
                   
                    if (rdr["ProduktiID"] != DBNull.Value)
                        p.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["DataPP"] != DBNull.Value)
                        p.DataPP = (DateTime)rdr["DataPP"];

                    mPunetoriProduktet.Add(p);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}