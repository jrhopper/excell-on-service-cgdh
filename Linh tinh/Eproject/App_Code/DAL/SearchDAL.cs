using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

class SearchDAL:ConfigurationDAL
{
    /*
     Author:La Quoc Chuong
     * Purpose: search
     */
    public List<Search> search(string serviceordername, string employeename, string customername, string servicetype, string begindate, string enddate, string status, string customeraddress, string customerphone, string customeremail)
    {
        List<Search> list = new List<Search>();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        cmd.CommandText = "SP_Search";
        cmd.Parameters.AddWithValue("@serviceordername",serviceordername);
        cmd.Parameters.AddWithValue("@employeename",employeename);
        cmd.Parameters.AddWithValue("@customername",customername);
        cmd.Parameters.AddWithValue("@servicetype",servicetype);
        cmd.Parameters.AddWithValue("@begindate",begindate);
        cmd.Parameters.AddWithValue("@enddate",enddate);
        cmd.Parameters.AddWithValue("@status",status);
        cmd.Parameters.AddWithValue("@customeraddress",customeraddress);
        cmd.Parameters.AddWithValue("@customerphone",customerphone);
        cmd.Parameters.AddWithValue("@customeremail",customeremail);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Search model = new Search();
            model.Serviceorderid = reader["serviceorderid"].ToString();
            model.Serviceordername = reader["serviceordername"].ToString();
            model.Employeeid = reader["employeeid"].ToString();
            model.Employeename = reader["employeename"].ToString();
            model.CustomerId = reader["customerid"].ToString();
            model.CustomerName = reader["customername"].ToString();
            model.ServiceTypeId = reader["servicetypeid"].ToString();
            model.ServiceTypeName = reader["servicetypename"].ToString();
            model.Status = reader["status"].ToString();
            model.BeginDate = reader["begin_date"].ToString();
            model.EndDate = reader["end_date"].ToString();
            model.Complete = reader["complete"].ToString();
            model.ServiceOrderDescription = reader["serviceorderdescription"].ToString();
            model.CustomerPhone = reader["customerphone"].ToString();
            model.CustomerEmail = reader["customeremail"].ToString();
            model.CustomerAddress = reader["customeraddress"].ToString();
            list.Add(model);
        }
        return list;
    }
}
