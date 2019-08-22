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
    public class ProduktiMapper
    {
        private Produkti mProdukti;

        public ProduktiMapper(Produkti p)
        {
            mProdukti = p;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", mProdukti.ProduktiID);
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
                SqlCommand cmd = new SqlCommand("ProduktiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mProdukti.Emri);
                cmd.Parameters.AddWithValue("@Pershkrimi", mProdukti.Pershkrimi);
                cmd.Parameters.AddWithValue("@Prodhuesi", mProdukti.Prodhuesi);
                cmd.Parameters.AddWithValue("@Modeli", mProdukti.Modeli);
                cmd.Parameters.AddWithValue("@Jetegjatesia", mProdukti.Jetegjatesia);
                cmd.Parameters.AddWithValue("@Lloji", mProdukti.Lloji);
                cmd.Parameters.AddWithValue("@GrupiID", mProdukti.GrupiID);
                cmd.Parameters.AddWithValue("@Statusi", mProdukti.Statusi);
                cmd.Parameters.AddWithValue("@NrSerik", mProdukti.NrSerik);
                cmd.Parameters.AddWithValue("@salvageValue", mProdukti.salvageValue);
                cmd.Parameters.AddWithValue("@Cmimi", mProdukti.Cmimi);
                cmd.Parameters.AddWithValue("@Data1", mProdukti.Data1);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void Update()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mProdukti.Emri);
                cmd.Parameters.AddWithValue("@Pershkrimi", mProdukti.Pershkrimi);
                cmd.Parameters.AddWithValue("@Prodhuesi", mProdukti.Prodhuesi);
                cmd.Parameters.AddWithValue("@Modeli", mProdukti.Modeli);
                cmd.Parameters.AddWithValue("@Jetegjatesia", mProdukti.Jetegjatesia);
                cmd.Parameters.AddWithValue("@Lloji", mProdukti.Lloji);
                cmd.Parameters.AddWithValue("@GrupiID", mProdukti.GrupiID);
                cmd.Parameters.AddWithValue("@Statusi", mProdukti.Statusi);
                cmd.Parameters.AddWithValue("@NrSerik", mProdukti.NrSerik);
                cmd.Parameters.AddWithValue("@salvageValue", mProdukti.salvageValue);
                cmd.Parameters.AddWithValue("@Cmimi", mProdukti.Cmimi);
                cmd.Parameters.AddWithValue("@Data1", mProdukti.Data1);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int ProduktiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", ProduktiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mProdukti.ProduktiID = (int)rdr["ProduktiID"];

                    if (rdr["Emri"] != DBNull.Value)
                        mProdukti.Emri = (string)rdr["Emri"];
                    if (rdr["Pershkrimi"] != DBNull.Value)
                        mProdukti.Pershkrimi = (string)rdr["Pershkrimi"];
                    if (rdr["Prodhuesi"] != DBNull.Value)
                        mProdukti.Prodhuesi = (string)rdr["Prodhuesi"];
                    if (rdr["Modeli"] != DBNull.Value)
                        mProdukti.Modeli = (string)rdr["Modeli"];
                    if (rdr["Jetegjatesia"] != DBNull.Value)
                        mProdukti.Jetegjatesia = (int)rdr["Jetegjatesia"];
                    if (rdr["Lloji"] != DBNull.Value)
                        mProdukti.Lloji = (string)rdr["Lloji"];
                    if (rdr["GrupiID"] != DBNull.Value)
                        mProdukti.GrupiID = (int)rdr["GrupiID"];
                    if (rdr["Statusi"] != DBNull.Value)
                        mProdukti.Statusi = (bool)rdr["Statusi"];
                    if (rdr["NrSerik"] != DBNull.Value)
                        mProdukti.NrSerik = (string)rdr["NrSerik"];
                    if (rdr["salvageValue"] != DBNull.Value)
                        mProdukti.salvageValue = (decimal)rdr["salvageValue"];
                    if (rdr["Cmimi"] != DBNull.Value)
                        mProdukti.Cmimi = (decimal)rdr["Cmimi"];
                    if (rdr["Data1"] != DBNull.Value)
                        mProdukti.Data1 = (DateTime)rdr["Data1"];
                }
            }
            finally
            {
                con.Close();
            }


        }
     

    }
}
