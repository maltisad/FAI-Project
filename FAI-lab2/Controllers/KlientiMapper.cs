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
    public class KlientiMapper
    {
        private Klienti mKlienti;
        
        public KlientiMapper(Klienti k)
        {
            mKlienti = k;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("KlientiDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KlientiID", mKlienti.KlientiID);
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
                SqlCommand cmd = new SqlCommand("KlientiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mKlienti.Emri);
                cmd.Parameters.AddWithValue("@Mbiemri",mKlienti.Mbiemri);
                cmd.Parameters.AddWithValue("@NumriTelefonit", mKlienti.NumriTelefonit);
                cmd.Parameters.AddWithValue("@Email", mKlienti.Email);
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
                SqlCommand cmd = new SqlCommand("KlientiUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KlientiID", mKlienti.KlientiID);

                cmd.Parameters.AddWithValue("@Emri", mKlienti.Emri);
                cmd.Parameters.AddWithValue("@Mbiemri", mKlienti.Mbiemri);
                cmd.Parameters.AddWithValue("@NumriTelefonit", mKlienti.NumriTelefonit);
                cmd.Parameters.AddWithValue("@Email", mKlienti.Email);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID (int KlientiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("KlientiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@KlientiID", KlientiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    mKlienti.KlientiID = (int)rdr["KlientiID"];
                    if (rdr["Emri"] != DBNull.Value)
                        mKlienti.Emri = (string)rdr["Emri"];
                    if (rdr["Mbiemri"] != DBNull.Value)
                        mKlienti.Mbiemri = (string)rdr["Mbiemri"];
                    if (rdr["NumriTelefonit"] != DBNull.Value)
                        mKlienti.NumriTelefonit = (int)rdr["NumriTelefonit"];
                    if (rdr["Email"] != DBNull.Value)
                        mKlienti.Email = (string)rdr["Email"];

                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
