using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAI_lab2.Controllers;
using FAI_lab2.Models;
using System.Text.RegularExpressions;

using System.Data.SqlClient;

namespace FAI_lab2.Views.Punetoret
{
    public partial class Index : System.Web.UI.Page
    {
        public int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RoliDLL();

               
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
            List<Punetori> lp = new List<Punetori>();
            PunetoretMapper bm = new PunetoretMapper(lp);
            bm.SelectAllPunetoret();
            ListGridView.DataSource = lp;
            ListGridView.DataBind();
        }
        protected void ListGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            ListGridView.PageIndex = e.NewPageIndex;
            placeShenimet();
        }
        protected void ListGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (e.CommandName == "ViewCommandName")
            //{
            //    SelectedID = Convert.ToInt32(e.CommandArgument.ToString());
            //    Server.Transfer("View.aspx");

            //}
            if (e.CommandName == "EditCommandName")
            {
                SelectedID = Convert.ToInt32(e.CommandArgument.ToString());
                Server.Transfer("Edit.aspx");
            }
            else if (e.CommandName == "DeleteCommandName")
            {
                Session["DeletedID"] = Convert.ToInt32(e.CommandArgument.ToString());
                Session["PreviousPageName"] = "/Views/Punetoret/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }


        private void RoliDLL()
        {
            SqlConnection con = Generals.GetNewConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select RoliID, Roli from Roli", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                RoliDropDownList.DataTextField = "Roli";
                RoliDropDownList.DataValueField = "RoliID";
                RoliDropDownList.DataSource = rdr;
                RoliDropDownList.DataBind();
                RoliDropDownList.Items.Insert(0, "Selekto Rolin");
            }
            finally
            {
                con.Close();
            }
        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (EmriTextBox.Text.Length == 0 || Regex.IsMatch(EmriTextBox.Text, @"^[0-9]+$"))
            {
                lblError.Visible = true;

                EmriTextBox.Focus();
                return;
            }
            else if (MbiemriTextBox.Text.Length == 0 || Regex.IsMatch(MbiemriTextBox.Text, @"^[0-9]+$"))
            {
                lblError.Visible = true;

                MbiemriTextBox.Focus();
                return;
            }
            else if (Gjinia.SelectedValue == null)
            {
                lblError.Visible = true;

                Gjinia.Focus();
                return;
            }
            else
            {
                Punetori obj = new Punetori();
                obj.Emri = EmriTextBox.Text;
                obj.Mbiemri = MbiemriTextBox.Text;
                obj.Gjinia = Gjinia.SelectedValue;
                obj.RoliID = Int32.Parse(RoliDropDownList.SelectedItem.Value);

                PunetoriMapper objm = new PunetoriMapper(obj);
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