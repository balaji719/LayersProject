using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class ClsDataLayer
    {
        SqlConnection sql = new SqlConnection("Data Source = DESKTOP - CNEFLRO/BHASKAR_SQL; Initial Catalog = balaji; User ID = sa");
       
        public void InserData(string txtcomanyname, int IYear, string txtlocation ,string state)
        {
            SqlDataAdapter sda = new SqlDataAdapter("insert into details values('" + txtcomanyname + "','"+ IYear + "','"+txtlocation+ "','"+ state + "')",sql );
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }
        public object SelectData()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from details)", sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
    }
}