using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataLayer
{
    public class ClsDataLayer
    {
        DS_User.pr_detailsDataTable udt = new DS_User.pr_detailsDataTable();
        DS_UserTableAdapters.pr_detailsTableAdapter utadta = new DataLayer.DS_UserTableAdapters.pr_detailsTableAdapter();
        public void InsertData(string NameOfTheCompany,int Incorporationyear,string Location,string State)
        {
            int i = utadta.Insert(NameOfTheCompany, Incorporationyear, Location, State);
        }
        public object SelectData()
        {
            return udt = utadta.GetData();
        }
    }
}