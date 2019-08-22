using FAI_lab2.Controllers;
using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace FAI_lab2.Views.Produktet
{
    public partial class Index : System.Web.UI.Page
    {
        public int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            placeShenimet();
            if (!Page.IsPostBack)
            {
                DataTextBox.ReadOnly = true;
                GrupiDLL();
               
                Calendar1.Visible = false;
            }
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
            List<Produkti> lb = new List<Produkti>();
            ProduktetMappers bm = new ProduktetMappers(lb);
            bm.SelectAllProduktet();
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
                Session["PreviousPageName"] = "/Views/Produktet/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }

    
        private void GrupiDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select GrupiID, Grupi from Grupi", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                GrupiDropDownList.DataTextField = "Grupi";
                GrupiDropDownList.DataValueField = "GrupiID";
                GrupiDropDownList.DataSource = rdr;
                GrupiDropDownList.DataBind();
                GrupiDropDownList.Items.Insert(0, "Selekto Grupin");
            }
            finally
            {
                con.Close();
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
                Produkti obj = new Produkti();
                obj.Emri = EmriTextBox.Text;
                obj.Pershkrimi = PershkrimiTextBox.Text;
                obj.Prodhuesi = ProdhuesiTextBox.Text;
                obj.Modeli = ModeliTextBox.Text;
                obj.Jetegjatesia = Int32.Parse(JetegjatesiaTextBox.Text);
                obj.Lloji = llojiProduktit.SelectedValue;
                obj.GrupiID = Int32.Parse(GrupiDropDownList.SelectedItem.Value);
                obj.Statusi = StatusiCheckBox.Checked;
                obj.NrSerik = NrSerikTextBox.Text;
                obj.salvageValue = decimal.Parse(salvageValueTextBox.Text);
                obj.Cmimi = decimal.Parse(CmimiTextBox.Text);
                obj.Data1 = Convert.ToDateTime(DataTextBox.Text).Date;
                ProduktiMapper objm = new ProduktiMapper(obj);
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

