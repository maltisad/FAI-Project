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
    public class MirembajtjaMapper
    {
        private Mirembajtja mMirembajtja;

        public MirembajtjaMapper(Mirembajtja p)
        {
            mMirembajtja = p;
        }

        public void Delete()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("MirembajtjaDeleteRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MirembajtjaID", mMirembajtja.MirembajtjaID);
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
                SqlCommand cmd = new SqlCommand("MirembajtjaInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", mMirembajtja.ProduktiID);
                cmd.Parameters.AddWithValue("@DataMirmbajtjes", mMirembajtja.DataMirmbajtjes);
                cmd.Parameters.AddWithValue("@Pershkrimi", mMirembajtja.Pershkrimi);
                cmd.Parameters.AddWithValue("@PunetoriID", mMirembajtja.PunetoriID);

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
                SqlCommand cmd = new SqlCommand("MirembajtjaUpdateRow", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ProduktiID", mMirembajtja.ProduktiID);
                cmd.Parameters.AddWithValue("@DataMirmbajtjes", mMirembajtja.DataMirmbajtjes);
                cmd.Parameters.AddWithValue("@Pershkrimi", mMirembajtja.Pershkrimi);
                cmd.Parameters.AddWithValue("@PunetoriID", mMirembajtja.PunetoriID);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int MirembajtjaID) // Opsion i select id 
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("MirembajtjaSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MirembajtjaID", MirembajtjaID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mMirembajtja.MirembajtjaID = (int)rdr["MirembajtjaID"];

                    if (rdr["PunetoriID"] != DBNull.Value)
                        mMirembajtja.PunetoriID = (int)rdr["PunetoriID"];
                    
                    if (rdr["ProduktiID"] != DBNull.Value)
                        mMirembajtja.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["DataMirmbajtjes"] != DBNull.Value)
                        mMirembajtja.DataMirmbajtjes = (DateTime)rdr["DataMirmbajtjes"];
                    if (rdr["Pershkrimi"] != DBNull.Value)
                        mMirembajtja.Pershkrimi = (string)rdr["Pershkrimi"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
