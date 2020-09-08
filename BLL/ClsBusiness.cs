using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;

namespace BLL
{
    public class ClsBusiness
    {
        ClsDataLayer objDAL = new ClsDataLayer();
        public void InsertUser(string txtcomanyname, int IYear, string txtlocation, string state)
        {
            objDAL.InserData(txtcomanyname, IYear, txtlocation, state);
        }
        public object SelectUser()
        {
            return objDAL.SelectData();
        }
    }
}