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
    public class KategoriaMapper
    {
        private Kategoria mKategoria;

        public KategoriaMapper(Kategoria k)
        {
            mKategoria = k;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("KategoriaDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KategoriaID", mKategoria.KategoriaID);
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
                SqlCommand cmd = new SqlCommand("KategoriaInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VleraKategorise", mKategoria.Vlera);
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
                SqlCommand cmd = new SqlCommand("KategoriaInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@VleraKategorise", mKategoria.Vlera);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int KategoriaID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("KategoriaSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KategoriaID", KategoriaID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mKategoria.KategoriaID = (int)rdr["KategoriaID"];

                    if (rdr["VleraKategoris"] != DBNull.Value)
                        mKategoria.Vlera = (int)rdr["VleraKategoris"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
