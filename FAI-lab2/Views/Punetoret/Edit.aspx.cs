using System;
using FAI_lab2.Controllers;
using FAI_lab2.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FAI_lab2.Views.Punetoret
{
    public partial class Edit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                placeShenimet();

            }
        }
        private void placeShenimet()
        {
            Index form = (Index)Context.Handler;
            int ID = form.SelectedID;
            ViewState["SelectedID"] = ID;
            RoliDLL();


            Punetori ex = new Punetori();
            PunetoriMapper em = new PunetoriMapper(ex);
            em.SelectedID(ID);
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
                int ID = Convert.ToInt32(ViewState["SelectedID"].ToString());
                Punetori obj = new Punetori();
                PunetoriMapper objm = new PunetoriMapper(obj);
                objm.SelectedID(ID);



                obj.Emri = EmriTextBox.Text;
                obj.Mbiemri = MbiemriTextBox.Text;
                obj.Gjinia = Gjinia.SelectedValue;
                obj.RoliID = Int32.Parse(RoliDropDownList.SelectedItem.Value);

                objm.Update();
                Response.Redirect("Index.aspx");
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}
