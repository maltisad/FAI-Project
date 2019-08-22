using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;
namespace FAI_lab2.Views.Grupet
{
    public partial class Index : System.Web.UI.Page
    {
        public int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                KategoriaDLL();
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
            List<Grupi> lb = new List<Grupi>();
            GrupetMappers bm = new GrupetMappers(lb);
            bm.SelectAllGrupet();
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
                Session["PreviousPageName"] = "/Views/Grupet/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }
        private void KategoriaDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select KategoriaID, VleraKategorise from Kategoria", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                KategoriaDropDownList.DataTextField = "VleraKategorise";
                KategoriaDropDownList.DataValueField = "KategoriaID";
                KategoriaDropDownList.DataSource = rdr;
                KategoriaDropDownList.DataBind();
                KategoriaDropDownList.Items.Insert(0, "Selekto Kategorin");
            }
            finally
            {
                con.Close();
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (GrupiTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                GrupiTextBox.Focus();
                return;
            }
            else
            {
                Grupi obj = new Grupi();
                obj.emriGrupit = GrupiTextBox.Text;
                obj.KategoriaID = Int32.Parse(KategoriaDropDownList.SelectedItem.Value);

                GrupiMapper objm = new GrupiMapper(obj);
                objm.Insert();
                Response.Redirect("Index.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}