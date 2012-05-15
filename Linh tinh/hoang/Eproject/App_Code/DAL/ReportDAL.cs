using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

/// <summary>
/// Summary description for ReportDAL
/// </summary>
public class ReportDAL:ConfigurationDAL
{
	public ReportDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    /*
     Author:La Quoc Chuong
     * Purpose: report
     */
    public List<Report> report(String serviceorderid, String month, String empid, String custid)
    {
        List<Report> list = new List<Report>();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        cmd.CommandText = "SP_Report";
        cmd.Parameters.AddWithValue("@serviceorderid", serviceorderid);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@empid", empid);
        cmd.Parameters.AddWithValue("@custid", custid);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            Report model = new Report();
            model.ServiceOrderId = reader["serviceorderid"].ToString();
            model.ServiceOrderName = reader["serviceordername"].ToString();
            model.EmployeeId = reader["employeeid"].ToString();
            model.EmployeeName = reader["employeename"].ToString();
            model.CustId = reader["customerid"].ToString();
            model.CustName = reader["customername"].ToString();
            model.Charges = reader["charges"].ToString();
            model.BeginDate = reader["begindate"].ToString();
            model.EndDate = reader["enddate"].ToString();           
            list.Add(model);
        }
        return list;
    }

    /*
     *Author:La Quoc Chuong
     *Purpose: report count
     *Date: 2012/04/17
     */
    public int reportCount(String serviceorderid, String month, String empid, String custid)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Connection = conn;
        cmd.CommandText = "SP_Report_Count";
        cmd.Parameters.AddWithValue("@serviceorderid", serviceorderid);
        cmd.Parameters.AddWithValue("@month", month);
        cmd.Parameters.AddWithValue("@empid", empid);
        cmd.Parameters.AddWithValue("@custid", custid);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }
}