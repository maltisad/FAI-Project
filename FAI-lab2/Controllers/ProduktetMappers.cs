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
    public class ProduktetMappers
    {
        private List<Produkti> mProduktet;

        public ProduktetMappers(List<Produkti> p)
        {
            mProduktet = p;
        }

        public void SelectAllProduktet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Produkti p = new Produkti();
                    p.ProduktiID = (int)rdr["ProduktiID"];
                    if (rdr["Emri"] != DBNull.Value)
                        p.Emri = (string)rdr["Emri"];
                    if (rdr["Pershkrimi"] != DBNull.Value)
                        p.Pershkrimi = (string)rdr["Pershkrimi"];
                    if (rdr["Prodhuesi"] != DBNull.Value)
                        p.Prodhuesi = (string)rdr["Prodhuesi"];
                    if (rdr["Modeli"] != DBNull.Value)
                        p.Modeli = (string)rdr["Modeli"];
                    if (rdr["Jetegjatesia"] != DBNull.Value)
                        p.Jetegjatesia = (int)rdr["Jetegjatesia"];
                    if (rdr["Lloji"] != DBNull.Value)
                        p.Lloji = (string)rdr["Lloji"];
                    if (rdr["GrupiID"] != DBNull.Value)
                        p.GrupiID = (int)rdr["GrupiID"];
                    if (rdr["Statusi"] != DBNull.Value)
                        p.Statusi = (bool)rdr["Statusi"];
                    if (rdr["NrSerik"] != DBNull.Value)
                        p.NrSerik = (string)rdr["NrSerik"];
                    if (rdr["salvageValue"] != DBNull.Value)
                        p.salvageValue = (decimal)rdr["salvageValue"];
                    if (rdr["Cmimi"] != DBNull.Value)
                        p.Cmimi = (decimal)rdr["Cmimi"];
                    if (rdr["Data1"] != DBNull.Value)
                        p.Data1 = (DateTime)rdr["Data1"];
                    mProduktet.Add(p);
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void SelectAllAsetet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Produkti p = new Produkti();
                    if (rdr["Lloji"] != DBNull.Value & (string)rdr["Lloji"] != "Inventor")
                    {
                        p.Lloji = (string)rdr["Lloji"];
                        p.ProduktiID = (int)rdr["ProduktiID"];
                        if (rdr["Emri"] != DBNull.Value)
                            p.Emri = (string)rdr["Emri"];
                        if (rdr["Pershkrimi"] != DBNull.Value)
                            p.Pershkrimi = (string)rdr["Pershkrimi"];
                        if (rdr["Prodhuesi"] != DBNull.Value)
                            p.Prodhuesi = (string)rdr["Prodhuesi"];
                        if (rdr["Modeli"] != DBNull.Value)
                            p.Modeli = (string)rdr["Modeli"];
                        if (rdr["Jetegjatesia"] != DBNull.Value)
                            p.Jetegjatesia = (int)rdr["Jetegjatesia"];
                        if (rdr["GrupiID"] != DBNull.Value)
                            p.GrupiID = (int)rdr["GrupiID"];
                        if (rdr["Statusi"] != DBNull.Value)
                            p.Statusi = (bool)rdr["Statusi"];
                        if (rdr["NrSerik"] != DBNull.Value)
                            p.NrSerik = (string)rdr["NrSerik"];
                        if (rdr["salvageValue"] != DBNull.Value)
                            p.salvageValue = (decimal)rdr["salvageValue"];
                        if (rdr["Cmimi"] != DBNull.Value)
                            p.Cmimi = (decimal)rdr["Cmimi"];
                        if (rdr["Data1"] != DBNull.Value)
                            p.Data1 = (DateTime)rdr["Data1"];
                        mProduktet.Add(p);
                    }
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void SelectAllInventoret()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Produkti p = new Produkti();
                    if (rdr["Lloji"] != DBNull.Value & (string)rdr["Lloji"] != "Aset")
                    {
                        p.Lloji = (string)rdr["Lloji"];
                        p.ProduktiID = (int)rdr["ProduktiID"];
                        if (rdr["Emri"] != DBNull.Value)
                            p.Emri = (string)rdr["Emri"];
                        if (rdr["Pershkrimi"] != DBNull.Value)
                            p.Pershkrimi = (string)rdr["Pershkrimi"];
                        if (rdr["Prodhuesi"] != DBNull.Value)
                            p.Prodhuesi = (string)rdr["Prodhuesi"];
                        if (rdr["Modeli"] != DBNull.Value)
                            p.Modeli = (string)rdr["Modeli"];
                        if (rdr["Jetegjatesia"] != DBNull.Value)
                            p.Jetegjatesia = (int)rdr["Jetegjatesia"];
                        if (rdr["GrupiID"] != DBNull.Value)
                            p.GrupiID = (int)rdr["GrupiID"];
                        if (rdr["Statusi"] != DBNull.Value)
                            p.Statusi = (bool)rdr["Statusi"];
                        if (rdr["NrSerik"] != DBNull.Value)
                            p.NrSerik = (string)rdr["NrSerik"];
                        if (rdr["salvageValue"] != DBNull.Value)
                            p.salvageValue = (decimal)rdr["salvageValue"];
                        if (rdr["Cmimi"] != DBNull.Value)
                            p.Cmimi = (decimal)rdr["Cmimi"];
                        if (rdr["Data1"] != DBNull.Value)
                            p.Data1 = (DateTime)rdr["Data1"];
                        mProduktet.Add(p);
                    }
                }
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
                    Produkti mProdukti = new Produkti();
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
                    mProduktet.Add(mProdukti);
                }
            }
            finally
            {
                con.Close();
            }
        }
        public void Count()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ProduktiCount", con);
                cmd.CommandType = CommandType.StoredProcedure;
              
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
