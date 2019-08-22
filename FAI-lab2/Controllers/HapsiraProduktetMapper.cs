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
    public class HapsiraProduktetMapper
    {
        private List<HapsiraProdukti> mHapsiraProduktet;

        public HapsiraProduktetMapper(List<HapsiraProdukti> p)
        {
            mHapsiraProduktet = p;
        }


        public void SelectAllPunetoretProduktet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProdukteHapsiraSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    HapsiraProdukti p = new HapsiraProdukti();

                    p.HapsiraID = (int)rdr["HapsiraID"];
                    if (rdr["HapsiraID"] != DBNull.Value)
                        p.HapsiraID = (int)rdr["HapsiraID"];
                   
                    if (rdr["ProduktiID"] != DBNull.Value)
                        p.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["DataPH"] != DBNull.Value)
                        p.DataPH = (DateTime)rdr["DataPH"];

                    mHapsiraProduktet.Add(p);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}