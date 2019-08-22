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
    public class ObjektiMapper
    {
        private Objekti mObjekti;

        public ObjektiMapper(Objekti o)
        {
            mObjekti = o;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ObjektiDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ObjektiID", mObjekti.ObjektiID);
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
                SqlCommand cmd = new SqlCommand("ObjektiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Lokacioni", mObjekti.Lokacioni);
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
                SqlCommand cmd = new SqlCommand("ObjektiUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ObjektiID", mObjekti.ObjektiID);
                cmd.Parameters.AddWithValue("@Lokacioni", mObjekti.Lokacioni);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int ObjektiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ObjektiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ObjektiID", ObjektiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mObjekti.ObjektiID = (int)rdr["ObjektiID"];

                    if (rdr["Lokacioni"] != DBNull.Value)
                        mObjekti.Lokacioni = (string)rdr["Lokacioni"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
