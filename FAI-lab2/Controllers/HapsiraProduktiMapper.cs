using System;
using FAI_lab2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FAI_lab2.Controllers
{
    public class HapsiraProduktiMapper
    {
        private HapsiraProdukti mHapsiraProdukti;

        public HapsiraProduktiMapper(HapsiraProdukti p)
        {
            mHapsiraProdukti = p;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProdukteHapsiraDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PdID", mHapsiraProdukti.PdID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }

        }
        public void Insert()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProdukteHapsiraInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HapsiraID", mHapsiraProdukti.HapsiraID);
            
                cmd.Parameters.AddWithValue("@ProduktiID", mHapsiraProdukti.ProduktiID);
                cmd.Parameters.AddWithValue("@DataPH", mHapsiraProdukti.DataPH);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Update() // Perditsim i te dhenave
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProdukteHapsiraUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@HapsiraID", mHapsiraProdukti.HapsiraID);

                cmd.Parameters.AddWithValue("@ProduktiID", mHapsiraProdukti.ProduktiID);
                cmd.Parameters.AddWithValue("@DataPP", mHapsiraProdukti.DataPH);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int PdID) // Opsion i select id 
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProdukteHapsiraSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PdID", PdID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mHapsiraProdukti.PdID = (int)rdr["PdID"];

                    if (rdr["HapsiraID"] != DBNull.Value)
                        mHapsiraProdukti.HapsiraID = (int)rdr["HapsiraID"];
                    
                    if (rdr["ProduktiID"] != DBNull.Value)
                        mHapsiraProdukti.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["DataPH"] != DBNull.Value)
                        mHapsiraProdukti.DataPH = (DateTime)rdr["DataPH"];

                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
