using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class ClsDataLayer
       {
          //  SqlConnection sql = new SqlConnection("Data Source =DESKTOP-CNEFLRO/BHASKAR_SQL; Initial Catalog = balaji; User ID = sa");
       // SqlConnection sql = new SqlConnection(" Data Source = DESKTOP - CNEFLRO/BHASKAR_SQL;Initial Catalog = balaji; Integrated Security = True");
       //

        public void InserData(string txtcomanyname, int IYear, string txtlocation ,string state)
        {
            string con = "Data Source=DESKTOP-DV6JK3I;Initial Catalog=Balaji;User ID=balaji;Password=balaji";
            SqlConnection sql = new SqlConnection(con);
            sql.Open();
            string insert = "insert into details values('" + txtcomanyname + "','" + IYear + "','" + txtlocation + "','" + state + "')";
            SqlCommand cmd = new SqlCommand(insert, sql);
            cmd.ExecuteNonQuery();
            sql.Close();
            //   // SqlDataAdapter sda = new SqlDataAdapter("insert into details values('" + txtcomanyname + "','"+ IYear + "','"+txtlocation+ "','"+ state + "')",sql );
            //    DataTable dt = new DataTable();
            //    sda.Fill(dt);
            }
            public object SelectData()
        {
            // string mainconn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            string con = "Data Source=DESKTOP-DV6JK3I;Initial Catalog=Balaji;User ID=balaji;Password=balaji";
            SqlConnection sqlconn = new SqlConnection(con);

         //   SqlConnection sqlconn = new SqlConnection(mainconn);
            sqlconn.Open();
            SqlCommand sqlcomm = new SqlCommand();
            string sqlquery = "select * from details";
            sqlcomm.CommandText = sqlquery;
            sqlcomm.Connection = sqlconn;
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            sda.Fill(dt);

            return dt;


            //SqlDataAdapter sda = new SqlDataAdapter("select * from details)", sqlconn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //return dt;

        }
    }
}