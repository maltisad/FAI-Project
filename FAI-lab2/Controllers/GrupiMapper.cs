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
    public class GrupiMapper
    {
        private Grupi mGrupi;

        public GrupiMapper(Grupi g)
        {
            mGrupi = g;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("GrupiDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GrupiID", mGrupi.GrupiID);
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
                SqlCommand cmd = new SqlCommand("GrupiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupi", mGrupi.emriGrupit);
                cmd.Parameters.AddWithValue("@KategoriaID", mGrupi.KategoriaID);
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
                SqlCommand cmd = new SqlCommand("GrupiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Grupi", mGrupi.emriGrupit);
                cmd.Parameters.AddWithValue("@KategoriaID", mGrupi.KategoriaID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int GrupiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("GrupiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@GrupiID", GrupiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mGrupi.GrupiID = (int)rdr["GrupiID"];

                    if (rdr["Grupi"] != DBNull.Value)
                        mGrupi.emriGrupit = (string)rdr["Grupi"];
                    if (rdr["KategoriaID"] != DBNull.Value)
                        mGrupi.KategoriaID = (int)rdr["KategoriaID"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
