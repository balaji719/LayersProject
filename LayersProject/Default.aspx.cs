using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace LayersProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
            ClsBusiness objclb = new ClsBusiness();
            objclb.InsertUser(TextBox1.Text,Int32.Parse(TextBox2.Text), TextBox3.Text, TextBox4.Text);
            GridView1.DataSource = objclb.SelectUser();
            GridView1.DataBind();

           }

    }
}