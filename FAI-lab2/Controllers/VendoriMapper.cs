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
    public class VendoriMapper
    {
        private Vendori mVendori;
        public VendoriMapper(Vendori v)
        {
            mVendori = v;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("VendoriDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VendoriID", mVendori.VendoriID);
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
                SqlCommand cmd = new SqlCommand("VendoriInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mVendori.Emri);
                cmd.Parameters.AddWithValue("@Lokacioni", mVendori.Lokacioni);
                cmd.Parameters.AddWithValue("@NrKontaktues", mVendori.NrKontaktues);
                cmd.Parameters.AddWithValue("@BankAccount", mVendori.BankAccount);

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
                SqlCommand cmd = new SqlCommand("VendoriUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VendoriID", mVendori.VendoriID);
                cmd.Parameters.AddWithValue("@Emri", mVendori.Emri);
                cmd.Parameters.AddWithValue("@Lokacioni", mVendori.Lokacioni);
                cmd.Parameters.AddWithValue("@NrKontaktues", mVendori.NrKontaktues);
                cmd.Parameters.AddWithValue("@BankAccount", mVendori.BankAccount);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int VendoriID) // Opsion i select id 
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("VendoriSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VendoriID", VendoriID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mVendori.VendoriID = (int)rdr["VendoriID"];

                    if (rdr["Emri"] != DBNull.Value)
                        mVendori.Emri = (string)rdr["Emri"];
                    if (rdr["Lokacioni"] != DBNull.Value)
                        mVendori.Lokacioni = (string)rdr["Lokacioni"];
                    if (rdr["NrKontaktues"] != DBNull.Value)
                        mVendori.NrKontaktues = (int)rdr["NrKontaktues"];
                    if (rdr["BankAccount"] != DBNull.Value)
                        mVendori.BankAccount = (int)rdr["BankAccount"];

                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
