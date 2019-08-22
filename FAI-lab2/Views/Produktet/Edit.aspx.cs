using FAI_lab2.Models;
using FAI_lab2.Controllers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FAI_lab2.Views.Produktet
{
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                placeShenimet();
                GrupiDLL();
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

        private void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;

            Produkti ex = new Produkti();
            ProduktiMapper em = new ProduktiMapper(ex);
            em.SelectedID(ID);

            EmriTextBox.Text = ex.Emri;
            PershkrimiTextBox.Text = ex.Pershkrimi;
            ProdhuesiTextBox.Text = ex.Prodhuesi;
            ModeliTextBox.Text = ex.Modeli;
            JetegjatesiaTextBox.Text = ex.Jetegjatesia.ToString();
            GrupiDropDownList.SelectedValue = ex.GrupiID.ToString();
            StatusiCheckBox.Checked = ex.Statusi;
            NrSerikTextBox.Text = ex.NrSerik;
            llojiProduktit.SelectedValue = ex.Lloji;
            salvageValueTextBox.Text = ex.salvageValue.ToString();
            CmimiTextBox.Text = ex.Cmimi.ToString();
            DataTextBox.Text = ex.Data1.ToString("d");
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            if (EmriTextBox.Text.Length == 0)
            {
              
                EmriTextBox.Focus();
                return;
            }
            else if (PershkrimiTextBox.Text.Length == 0)
            {
              

                PershkrimiTextBox.Focus();
                return;
            }
            else if (ProdhuesiTextBox.Text.Length == 0)
            {
              

                ProdhuesiTextBox.Focus();
                return;
            }
            else if (ModeliTextBox.Text.Length == 0)
            {
              

                ModeliTextBox.Focus();
                return;
            }
            else if (JetegjatesiaTextBox.Text.Length == 0)
            {
              

                JetegjatesiaTextBox.Focus();
                return;
            }
            else if (llojiProduktit.SelectedValue == null)
            {
                
                LlojiLabel.Focus();
                return;
            }
            else if (salvageValueTextBox.Text.Length == 0)
            {
               

                salvageValueTextBox.Focus();
                return;
            }
            else
            {
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                Produkti ex = new Produkti();
                ProduktiMapper em = new ProduktiMapper(ex);
                em.SelectedID(ID);


                ex.Emri = EmriTextBox.Text;
                ex.Pershkrimi = PershkrimiTextBox.Text;
                ex.Prodhuesi = ProdhuesiTextBox.Text;
                ex.Modeli = ModeliTextBox.Text;
                ex.Jetegjatesia = Int32.Parse(JetegjatesiaTextBox.Text);
                ex.Lloji = llojiProduktit.SelectedValue;
                ex.NrSerik = NrSerikTextBox.Text;
                ex.GrupiID = Int32.Parse(GrupiDropDownList.DataValueField);
                ex.Statusi = StatusiCheckBox.Checked;
                ex.salvageValue = decimal.Parse(salvageValueTextBox.Text);
                ex.Cmimi = decimal.Parse(CmimiTextBox.Text);
                ex.Data1 = Convert.ToDateTime(DataTextBox.Text).Date;

                em.Update();
                Response.Redirect("Index.aspx");
            }
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