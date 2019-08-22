using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace FAI_lab2.Controllers
{
    public class VendoretMapper
    {
        private List<Vendori> mVendoret;

        public VendoretMapper(List<Vendori> v)
        {
            mVendoret = v;
        }

        public void SelectAllVendori()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("VendoriSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Vendori v = new Vendori();
                    v.VendoriID = (int)rdr["VendoriID"];
                    if (rdr["Emri"] != DBNull.Value)
                        v.Emri = (string)rdr["Emri"];
                    if (rdr["Lokacioni"] != DBNull.Value)
                        v.Lokacioni = (string)rdr["Lokacioni"];
                    if (rdr["NrKontaktues"] != DBNull.Value)
                        v.NrKontaktues = (int)rdr["NrKontaktues"];
                    if (rdr["BankAccount"] != DBNull.Value)
                        v.BankAccount = (int)rdr["BankAccount"];

                    mVendoret.Add(v);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
