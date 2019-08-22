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
    public class PunetoriProduktiMapper
    {
        private PunetoriProdukti mPunetoriProdukti;

        public PunetoriProduktiMapper(PunetoriProdukti p)
        {
            mPunetoriProdukti = p;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("PunetoriProduktiDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PPID", mPunetoriProdukti.PPID);
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
                SqlCommand cmd = new SqlCommand("PunetoriProduktiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PunetoriID", mPunetoriProdukti.PunetoriID);
            
                cmd.Parameters.AddWithValue("@ProduktiID", mPunetoriProdukti.ProduktiID);
                cmd.Parameters.AddWithValue("@DataPP", mPunetoriProdukti.DataPP);

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
                SqlCommand cmd = new SqlCommand("PunetoriProduktiUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
               
                cmd.Parameters.AddWithValue("@PunetoriID", mPunetoriProdukti.PunetoriID);

                cmd.Parameters.AddWithValue("@ProduktiID", mPunetoriProdukti.ProduktiID);
                cmd.Parameters.AddWithValue("@DataPP", mPunetoriProdukti.DataPP);

                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int PPID) // Opsion i select id 
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("PunetoriProduktiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PPID", PPID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mPunetoriProdukti.PPID = (int)rdr["PPID"];

                    if (rdr["PunetoriID"] != DBNull.Value)
                        mPunetoriProdukti.PunetoriID = (int)rdr["PunetoriID"];
                    
                    if (rdr["ProduktiID"] != DBNull.Value)
                        mPunetoriProdukti.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["DataPP"] != DBNull.Value)
                        mPunetoriProdukti.DataPP = (DateTime)rdr["DataPP"];

                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
