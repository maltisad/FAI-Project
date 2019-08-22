using System;
using FAI_lab2.Controllers;
using FAI_lab2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.SqlClient;



namespace FAI_lab2.Views.Vendoret
{
    public partial class Index : System.Web.UI.Page
    {
        public int SelectedID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
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
            List<Vendori> lv = new List<Vendori>();
            VendoretMapper vm = new VendoretMapper(lv);
            vm.SelectAllVendori();
            ListGridView.DataSource = lv;
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
                Session["PreviousPageName"] = "/Views/Vendoret/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }
        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (EmriTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                EmriTextBox.Focus();
                return;
            }
            else if (LokacioniTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                LokacioniTextBox.Focus();
                return;
            }
            else if (NrKontaktuesTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                NrKontaktuesTextBox.Focus();
                return;
            }
            else if (BankAccountTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                BankAccountTextBox.Focus();
                return;
            }

            else
            {
                Vendori obj = new Vendori();
                obj.Emri = EmriTextBox.Text;
                obj.Lokacioni = LokacioniTextBox.Text;
                obj.NrKontaktues = int.Parse(NrKontaktuesTextBox.Text);
                obj.BankAccount = int.Parse(BankAccountTextBox.Text);


                VendoriMapper objm = new VendoriMapper(obj);
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
    

