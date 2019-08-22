using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FAI_lab2.Controllers;
using FAI_lab2.Models;

namespace FAI_lab2.Views.Klientet
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
            List<Klienti> lk = new List<Klienti>();
            KlientetMapper km = new KlientetMapper(lk);
            km.SelectAllKlients();
            ListGridView.DataSource = lk;
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
                Session["PreviousPageName"] = "/Views/Klientet/" + System.IO.Path.GetFileName(Page.Request.FilePath);
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
            else if (MbiemriTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                MbiemriTextBox.Focus();
                return;
            }
            else if (NumriTelefonitTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                NumriTelefonitTextBox.Focus();
                return;
            }
            else if (EmailTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                EmailTextBox.Focus();
                return;
            }

            else
            {
                Klienti obj = new Klienti();
                obj.Emri = EmriTextBox.Text;
                obj.Mbiemri = MbiemriTextBox.Text;
                obj.NumriTelefonit = int.Parse(NumriTelefonitTextBox.Text);
                obj.Email = EmailTextBox.Text;


                KlientiMapper objm = new KlientiMapper(obj);
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