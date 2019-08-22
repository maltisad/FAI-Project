using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FAI_lab2.Controllers
{
    public class AmortizimetMappers
    {
        private List<Amortizimi> mAmortizimi;

        public AmortizimetMappers(List<Amortizimi> a)
        {
            mAmortizimi = a;
        }

        public void SelectAllAmortizimet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("AmortizimiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Amortizimi a = new Amortizimi();
                    a.AmortizimID = (int)rdr["AmortizimID"];
                    if (rdr["AmortizimiAkumuluar"] != DBNull.Value)
                        a.AmortizimiAkumuluar = (decimal)rdr["AmortizimiAkumuluar"];
                    if (rdr["AmortizimiVjetor"] != DBNull.Value)
                        a.AmortizimiVjetor = (decimal)rdr["AmortizimiVjetor"];
                    if (rdr["ProduktiID"] != DBNull.Value)
                        a.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["Viti"] != DBNull.Value)
                        a.Viti = (int)rdr["Viti"];
                    if (rdr["DataAmortizimit"] != DBNull.Value)
                        a.DataAmortizimit = (DateTime)rdr["DataAmortizimit"];
                    mAmortizimi.Add(a);
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void SelectAll(int Produkti)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("AmortizimiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Amortizimi a = new Amortizimi();
                    if (rdr["ProduktiID"] != DBNull.Value & (int)rdr["ProduktiID"] == Produkti)
                    {
                        a.ProduktiID= (int)rdr["ProduktiID"];
                        a.AmortizimID = (int)rdr["AmortizimID"];
                        if (rdr["AmortizimiAkumuluar"] != DBNull.Value)
                            a.AmortizimiAkumuluar = (decimal)rdr["AmortizimiAkumuluar"];
                        if (rdr["AmortizimiVjetor"] != DBNull.Value)
                            a.AmortizimiVjetor = (decimal)rdr["AmortizimiVjetor"];
                        if (rdr["ProduktiID"] != DBNull.Value)
                            a.ProduktiID = (int)rdr["ProduktiID"];
                        if (rdr["Viti"] != DBNull.Value)
                            a.Viti = (int)rdr["Viti"];
                        if (rdr["DataAmortizimit"] != DBNull.Value)
                            a.DataAmortizimit = (DateTime)rdr["DataAmortizimit"];
                        mAmortizimi.Add(a);
                    }
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}