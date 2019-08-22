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
    public class ObjektetMappers
    {
        private List<Objekti> mObjektet;

        public ObjektetMappers(List<Objekti> o)
        {
            mObjektet = o;
        }

        public void SelectAllObjektet()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("ObjektiSelectAll", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Objekti o = new Objekti();
                    o.ObjektiID = (int)rdr["ObjektiID"];
                    if (rdr["Lokacioni"] != DBNull.Value)
                        o.Lokacioni = (string)rdr["Lokacioni"];
                    mObjektet.Add(o);
                }
            }
            finally
            {
                con.Close();
            }
        }
    }
}
