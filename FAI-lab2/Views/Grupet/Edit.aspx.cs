using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Grupet
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                placeShenimet();
        }

        public void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;

            Grupi ex = new Grupi();
            GrupiMapper em = new GrupiMapper(ex);
            em.SelectedID(ID);

            GrupiTextBox.Text = ex.emriGrupit;
            KategoriaDropDownList.SelectedValue = ex.KategoriaID.ToString();
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
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                Grupi ex = new Grupi();
                GrupiMapper em = new GrupiMapper(ex);
                em.SelectedID(ID);
                ex.emriGrupit = GrupiTextBox.Text;
                ex.KategoriaID = Int32.Parse(KategoriaDropDownList.DataValueField);

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