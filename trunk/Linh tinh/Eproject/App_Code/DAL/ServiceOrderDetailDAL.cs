using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for EmployeeDAL
/// </summary>
public class ServiceOrderDetailDAL:ConfigurationDAL
{
    public ServiceOrderDetailDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrderDetail
     * Date:2012/04/18
     */
    public DataSet getAllServiceOrderDetail()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select b.name as serviceorder,c.name as employee,a.taskname,a.description"
                        + " from serviceorderdetail a inner join serviceorder b "
                        + " on a.serviceorderid = b.id inner join employee c"
                        + "on a.empid = c.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}