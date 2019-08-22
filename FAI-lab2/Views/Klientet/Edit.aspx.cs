using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Klientet
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                placeShenimet();
        }
        private void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;

            Klienti ex = new Klienti();
            KlientiMapper em = new KlientiMapper(ex);
            em.SelectedID(ID);
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
            else if (NumriTelefonitTextBox.Text.Length == 0)
            {
                lblError.Visible = true;

                NumriTelefonitTextBox.Focus();
                return;
            }
            else
                {
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                Klienti ex = new Klienti();
                KlientiMapper em = new KlientiMapper(ex);
                em.SelectedID(ID);


                ex.Emri = EmriTextBox.Text;
                ex.Mbiemri = MbiemriTextBox.Text;
                ex.NumriTelefonit = int.Parse(NumriTelefonitTextBox.Text);
                ex.Email = EmailTextBox.Text;

                em.Update();
                Response.Redirect("Index.aspx");
              
                }
            }

            protected void CancelButton_Click(object sender, EventArgs e)
            {
                Response.Redirect("Index.aspx");
            }
    }

}