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
            objclb.InsertUser(txtcomanyname.Text,Int32.Parse( IYear.Text), txtlocation.Text, state.Text);
            GridView1.DataSource = objclb.SelectUser();
            GridView1.DataBind();

           }

    }
}