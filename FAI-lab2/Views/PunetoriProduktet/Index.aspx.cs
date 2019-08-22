using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace FAI_lab2.Views.PunetoriProduktet
{
    public partial class Index : System.Web.UI.Page
    {
        public int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
               
            {
                PunetoriDLL();
                ProduktiDLL();
                Calendar1.Visible = false;
                DataTextBox.ReadOnly = true;

            }
            placeShenimet();
        }


        protected void ListGridView_DataBound(object sender, EventArgs e)
        {
            ListGridView.HeaderRow.TableSection = TableRowSection.TableHeader;
            ListGridView.HeaderStyle.CssClass = "flip-content";
        }
        protected void ListGridView_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.TableSection = TableRowSection.TableHeader;
                ListGridView.HeaderStyle.CssClass = "flip-content";
            }

        }

        private void placeShenimet()
        {
            List<PunetoriProdukti> lb = new List<PunetoriProdukti>();
            PunetoriProduktetMapper bm = new PunetoriProduktetMapper(lb);
            bm.SelectAllPunetoretProduktet();
            ListGridView.DataSource = lb;
            ListGridView.DataBind();
        }
        protected void ListGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ListGridView.PageIndex = e.NewPageIndex;
            placeShenimet();
        }

        protected void ListGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditCommandName")
            {
                SelectedID = Convert.ToInt32(e.CommandArgument.ToString());
                Server.Transfer("Edit.aspx");
            }
            else if (e.CommandName == "DeleteCommandName")
            {
                Session["DeletedID"] = Convert.ToInt32(e.CommandArgument.ToString());
                Session["PreviousPageName"] = "/Views/PunetoriProduktet/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }
        private void PunetoriDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select PunetoriID, Emri from Punetori", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                PunetoriDropDownList.DataTextField = "Emri";
                PunetoriDropDownList.DataValueField = "PunetoriID";
                PunetoriDropDownList.DataSource = rdr;
                PunetoriDropDownList.DataBind();
                PunetoriDropDownList.Items.Insert(0, "Selekto Punetorin");
            }
            finally
            {
                con.Close();
            }
        }
        private void ProduktiDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select ProduktiID, Emri from Produkti", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                ProduktiDropDownList.DataTextField = "Emri";
                ProduktiDropDownList.DataValueField = "ProduktiID";
                ProduktiDropDownList.DataSource = rdr;
                ProduktiDropDownList.DataBind();
                ProduktiDropDownList.Items.Insert(0, "Selekto Produktin");
            }
            finally
            {
                con.Close();
            }
        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
           
            
                PunetoriProdukti obj = new PunetoriProdukti();
               // obj.emriGrupit = GrupiTextBox.Text;
                obj.PunetoriID = Int32.Parse(PunetoriDropDownList.SelectedItem.Value);
            obj.ProduktiID = Int32.Parse(ProduktiDropDownList.SelectedItem.Value);
            obj.DataPP = Convert.ToDateTime(DataTextBox.Text).Date;
                PunetoriProduktiMapper objm = new PunetoriProduktiMapper(obj);
                objm.Insert();
                Response.Redirect("Index.aspx");
            }
        

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }

    
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible)
        {
            Calendar1.Visible = false;
        }
        else
        {
            Calendar1.Visible = true;
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DataTextBox.Text = Calendar1.SelectedDate.ToString("d");
        Calendar1.Visible = false;
    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.IsOtherMonth)
        {
            e.Day.IsSelectable = false;
            e.Cell.ForeColor = System.Drawing.Color.Red;
        }
    }
}
}