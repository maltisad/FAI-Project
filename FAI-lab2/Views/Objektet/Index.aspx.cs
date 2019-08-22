using FAI_lab2.Controllers;
using FAI_lab2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Data.SqlClient;

namespace FAI_lab2.Views.Objektet
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
            List<Objekti> lb = new List<Objekti>();
            ObjektetMappers bm = new ObjektetMappers(lb);
            bm.SelectAllObjektet();
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
                Session["PreviousPageName"] = "/Views/Objektet/" + System.IO.Path.GetFileName(Page.Request.FilePath);
                Server.Transfer("Delete.aspx");
            }
        }
       

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (LokacioniTextBox.Text.Length == 0)
            {
              

                LokacioniTextBox.Focus();
                return;
            }
            else
            {
                Objekti obj = new Objekti();
                obj.Lokacioni = LokacioniTextBox.Text;

                ObjektiMapper objm = new ObjektiMapper(obj);
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
