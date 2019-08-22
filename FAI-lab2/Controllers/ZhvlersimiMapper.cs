using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FAI_lab2.Controllers
{
    public class ZhvlersimiMapper
    {
        private Zhvlersimi mZhvlersimi;

        public ZhvlersimiMapper(Zhvlersimi z)
        {
            mZhvlersimi = z;
        }

        public void Insert()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ZhvlersimiInsertRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", mZhvlersimi.ProduktiID);
                cmd.Parameters.AddWithValue("@Viti", mZhvlersimi.Viti);
                cmd.Parameters.AddWithValue("@CmimiZh", mZhvlersimi.CmimiZh);
                cmd.Parameters.AddWithValue("@Cmimi", mZhvlersimi.Cmimi);
                cmd.Parameters.AddWithValue("@DataZhvlersimit", mZhvlersimi.DataZhvlersimit);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void SelectedID(int ZhvlersimiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ZhvlersimiSelectRow", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ZhvlersimiID", ZhvlersimiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mZhvlersimi.ZhvlersimiID = (int)rdr["ZhvlersimiID"];

                    if (rdr["ProduktiID"] != DBNull.Value)
                        mZhvlersimi.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["Cmimi"] != DBNull.Value)
                        mZhvlersimi.Cmimi = (decimal)rdr["Cmimi"];
                    if (rdr["CmimiZh"] != DBNull.Value)
                        mZhvlersimi.CmimiZh = (decimal)rdr["CmimiZh"];
                    if (rdr["Viti"] != DBNull.Value)
                        mZhvlersimi.Viti = (int)rdr["Viti"];
                    if (rdr["DataZhvlersimit"] != DBNull.Value)
                        mZhvlersimi.DataZhvlersimit = (DateTime)rdr["DataZhvlersimit"];
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void SelectLastRecord(int ProduktiID)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ZhvlersimiProdukti", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProduktiID", ProduktiID);

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    mZhvlersimi.ZhvlersimiID = (int)rdr["ZhvlersimiID"];

                    if (rdr["ZhvlersimiID"] != DBNull.Value)
                        mZhvlersimi.ZhvlersimiID = (int)rdr["ZhvlersimiID"];
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}