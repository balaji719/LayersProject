using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace LayersProject
{
    public partial class Default : System.Web.UI.Page
    {
        ClsBusiness objclb;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
             objclb = new ClsBusiness();
            objclb.InsertUser(TextBox1.Text,Int32.Parse(TextBox2.Text), TextBox3.Text, TextBox4.Text);
            Label3.Text = "Created and saved in Database"; 
            GridView1.DataSource = objclb.SelectUser();
            GridView1.DataBind();

           }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0].ToString());
            
            string scon = "Data Source=DESKTOP-DV6JK3I;Initial Catalog=Balaji;User ID=balaji;Password=balaji";

            using (SqlConnection con = new SqlConnection(scon))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM details WHERE ID =@ID"))
                {
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            Label4.Text = "Created and saved in Database";
            ClsBusiness objclb1 = new ClsBusiness();
            GridView1.DataSource = objclb1.SelectUser();
            GridView1.DataBind();

        }
    }
}