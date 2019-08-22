using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FAI_lab2.Controllers
{
    public class ZhvlersimetMappers
    {
        private List<Zhvlersimi> mZhvlersimet;

        public ZhvlersimetMappers(List<Zhvlersimi> z)
        {
            mZhvlersimet = z;
        }

        public void SelectAllZhvlersimet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ZhvlersimiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Zhvlersimi z = new Zhvlersimi();
                    z.ZhvlersimiID = (int)rdr["ZhvlersimiID"];
                    if (rdr["Cmimi"] != DBNull.Value)
                        z.Cmimi = (decimal)rdr["Cmimi"];
                    if (rdr["CmimiZh"] != DBNull.Value)
                        z.CmimiZh = (decimal)rdr["CmimiZh"];
                    if (rdr["ProduktiID"] != DBNull.Value)
                        z.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["Viti"] != DBNull.Value)
                        z.Viti = (int)rdr["Viti"];
                    if (rdr["DataZhvlersimit"] != DBNull.Value)
                        z.DataZhvlersimit = (DateTime)rdr["DataZhvlersimit"];
                    mZhvlersimet.Add(z);
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void SelectAll(int Produkti)
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ZhvlersimiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Zhvlersimi z = new Zhvlersimi();
                    if (rdr["ProduktiID"] != DBNull.Value & (int)rdr["ProduktiID"] == Produkti)
                    {
                        z.ProduktiID= (int)rdr["ProduktiID"];
                        z.ZhvlersimiID = (int)rdr["ZhvlersimiID"];
                        if (rdr["Cmimi"] != DBNull.Value)
                            z.Cmimi = (decimal)rdr["Cmimi"];
                        if (rdr["CmimiZh"] != DBNull.Value)
                            z.CmimiZh = (decimal)rdr["CmimiZh"];
                        if (rdr["ProduktiID"] != DBNull.Value)
                            z.ProduktiID = (int)rdr["ProduktiID"];
                        if (rdr["Viti"] != DBNull.Value)
                            z.Viti = (int)rdr["Viti"];
                        if (rdr["DataZhvlersimit"] != DBNull.Value)
                            z.DataZhvlersimit = (DateTime)rdr["DataZhvlersimit"];
                        mZhvlersimet.Add(z);
                    }
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}