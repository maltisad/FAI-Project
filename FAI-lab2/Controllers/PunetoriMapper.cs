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
    public class PunetoriMapper
    {
        private Punetori mPunetori;

        public PunetoriMapper(Punetori p)
        {
            mPunetori = p;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("PunetoriDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PunetoriID", mPunetori.PunetoriID);
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
                SqlCommand cmd = new SqlCommand("PunetoriInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Emri", mPunetori.Emri);
                cmd.Parameters.AddWithValue("@Mbiemri", mPunetori.Mbiemri);
                cmd.Parameters.AddWithValue("@Gjinia", mPunetori.Gjinia);
                cmd.Parameters.AddWithValue("@RoliID", mPunetori.RoliID);
                cmd.Parameters.AddWithValue("@NumriPersonal", mPunetori.NumriPersonal);
               
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
                SqlCommand cmd = new SqlCommand("PunetoriUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PunetoriID", mPunetori.PunetoriID);
                cmd.Parameters.AddWithValue("@Emri", mPunetori.Emri);
                cmd.Parameters.AddWithValue("@Mbiemri", mPunetori.Mbiemri);
                cmd.Parameters.AddWithValue("@Gjinia", mPunetori.Gjinia);
                cmd.Parameters.AddWithValue("@RoliId", mPunetori.RoliID);
                cmd.Parameters.AddWithValue("@NumriPersonal", mPunetori.NumriPersonal);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int PunetoriID) // Opsion i select id 
        {   
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("PunetoriSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PunetoriID", PunetoriID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mPunetori.PunetoriID = (int)rdr["PunetoriID"];

                    if (rdr["Emri"] != DBNull.Value)
                        mPunetori.Emri = (string)rdr["Emri"];
                    if (rdr["Mbiemri"] != DBNull.Value)
                        mPunetori.Mbiemri = (string)rdr["Mbiemri"];
                    if (rdr["Gjinia"] != DBNull.Value)
                        mPunetori.Gjinia = (string)rdr["Gjinia"];
                    if (rdr["RoliID"] != DBNull.Value)
                        mPunetori.RoliID = (int)rdr["RoliID"];
                    if (rdr["NumriPersonal"] != DBNull.Value)
                        mPunetori.NumriPersonal = (long)rdr["NumriPersonal"];
                   
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
