using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FAI_lab2.Controllers
{
    public class AmortizimiMapper
    {
        private Amortizimi mAmortizimi;

        public AmortizimiMapper(Amortizimi a)
        {
            mAmortizimi = a;
        }

        public void Insert()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("AmortizimiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", mAmortizimi.ProduktiID);
                cmd.Parameters.AddWithValue("@Viti", mAmortizimi.Viti);
                cmd.Parameters.AddWithValue("@AmortizimiVjetor", mAmortizimi.AmortizimiVjetor);
                cmd.Parameters.AddWithValue("@AmortizimiAkumuluar", mAmortizimi.AmortizimiAkumuluar);
                cmd.Parameters.AddWithValue("@DataAmortizimit", mAmortizimi.DataAmortizimit);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int AmortizimiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("AmortizimiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AmortizimID", AmortizimiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mAmortizimi.AmortizimID = (int)rdr["AmortizimID"];

                    if (rdr["ProduktiID"] != DBNull.Value)
                        mAmortizimi.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["AmortizimiVjetor"] != DBNull.Value)
                        mAmortizimi.AmortizimiVjetor = (decimal)rdr["AmortizimiVjetor"];
                    if (rdr["AmortizimiAkumuluar"] != DBNull.Value)
                        mAmortizimi.AmortizimiAkumuluar = (decimal)rdr["AmortizimiAkumuluar"];
                    if (rdr["Viti"] != DBNull.Value)
                        mAmortizimi.Viti = (int)rdr["Viti"];
                    if (rdr["DataAmortizimit"] != DBNull.Value)
                        mAmortizimi.DataAmortizimit = (DateTime)rdr["DataAmortizimit"];
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void SelectLastRecord(int ProduktiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("AmortizimiProdukti", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", ProduktiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mAmortizimi.AmortizimID = (int)rdr["AmortizimID"];

                    if (rdr["AmortizimID"] != DBNull.Value)
                        mAmortizimi.AmortizimID = (int)rdr["AmortizimID"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}