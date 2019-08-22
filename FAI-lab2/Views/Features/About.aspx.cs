using FAI_lab2.Controllers;
using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace FAI_lab2
{
    public partial class About : Page
    {

      
        protected void Page_Load(object sender, EventArgs e)
        {

         
        }

        protected void GrupiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Grupet/Index.aspx");
        }
        protected void ProduktiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Produktet/Index.aspx");
        }
        protected void VendoriButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Vendoret/Index.aspx");
        }
        protected void KlientiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Klientet/Index.aspx");
        }
        protected void ObjektiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Objektet/Index.aspx");
        }
        protected void PunetoriButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Punetoret/Index.aspx");
        }
        protected void PunetoriProduktiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../PunetoriProduktet/Index.aspx");
        }
        protected void HapsiraProduktiButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("../HapsiraProduktet/Index.aspx");
        }
   
    protected void MirembajtjaButton_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Mirembajtje/Index.aspx");
    }
}

}