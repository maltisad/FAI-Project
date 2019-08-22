using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;

namespace FAI_lab2.Views.HapsiraProduktet
{
    public partial class Index : System.Web.UI.Page
    {
        public int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                DataTextBox.ReadOnly = true;
                HapsiraDLL();
                ProduktiDLL();
                Calendar1.Visible = false;
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
            List<HapsiraProdukti> lb = new List<HapsiraProdukti>();
            HapsiraProduktetMapper bm = new HapsiraProduktetMapper(lb);
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
                Session["PreviousPageName"] = "/Views/HapsiraProduktet/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }
        private void HapsiraDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select HapsiraID,Emri from Hapsira", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                HapsiraDropDownList.DataTextField = "Emri";
                HapsiraDropDownList.DataValueField = "HapsiraID";
                HapsiraDropDownList.DataSource = rdr;
                HapsiraDropDownList.DataBind();
                HapsiraDropDownList.Items.Insert(0, "Selekto Hapsiren");
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
           
            
                HapsiraProdukti obj = new HapsiraProdukti();
               // obj.emriGrupit = GrupiTextBox.Text;
                obj.HapsiraID = Int32.Parse(HapsiraDropDownList.SelectedItem.Value);
            obj.ProduktiID = Int32.Parse(ProduktiDropDownList.SelectedItem.Value);
            obj.DataPH = Convert.ToDateTime(DataTextBox.Text).Date;
                HapsiraProduktiMapper objm = new HapsiraProduktiMapper(obj);
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