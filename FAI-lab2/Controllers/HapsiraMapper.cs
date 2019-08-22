using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using FAI_lab2.Models;

namespace FAI_lab2.Controllers
{
    public class HapsiraMapper
    {
        
            private Hapsira mHapsira;
        private Hapsira obj;

        public HapsiraMapper(Hapsira g)
            {
                mHapsira = g;
            }

      

        public void Delete()
            {
                SqlConnection con = Generals.GetNewConnection();
                try
                {
                    SqlCommand cmd = new SqlCommand("HapsiraDeleteRow", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HapsiraID", mHapsira.HapsiraID);
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
                    SqlCommand cmd = new SqlCommand("HapsiraInsertRow", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HapsiraID", mHapsira.HapsiraID);
                    cmd.Parameters.AddWithValue("@LlojiID", mHapsira.LlojiID);
                    cmd.Parameters.AddWithValue("@ObjektiID", mHapsira.ObjektiID);
                    cmd.Parameters.AddWithValue("@Emri", mHapsira.emri);
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
                     SqlCommand cmd = new SqlCommand("HapsiraUpdateRow", con);
                     cmd.CommandType = CommandType.StoredProcedure;
                     cmd.Parameters.AddWithValue("@HapsiraID", mHapsira.HapsiraID);
                     cmd.Parameters.AddWithValue("@LlojiID", mHapsira.LlojiID);
                     cmd.Parameters.AddWithValue("@ObjektiID", mHapsira.ObjektiID);
                     cmd.Parameters.AddWithValue("@Emri", mHapsira.emri);
                     cmd.ExecuteNonQuery();
            }
                finally
                {
                    con.Close();
                }
            }

            public void SelectedID(int HapsiraID)
            {
                SqlConnection con = Generals.GetNewConnection();
                try
                {
                    SqlCommand cmd = new SqlCommand("HapsiraRow", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@HapsiraID", HapsiraID);

                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        mHapsira.HapsiraID = (int)rdr["HapsiraID"];

                    if (rdr["LlojiID"] != DBNull.Value)
                        mHapsira.LlojiID = (int)rdr["LlojiID"];
                    if (rdr["ObjektiID"] != DBNull.Value)
                        mHapsira.ObjektiID = (int)rdr["ObjektiID"];

                    if (rdr["Emri"] != DBNull.Value)
                        mHapsira.emri= (string)rdr["Emri"];
                    
                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }




