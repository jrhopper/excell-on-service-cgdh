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
public class CustomerDAL:ConfigurationDAL
{
    public CustomerDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Customer
     * Date:2012/04/18
     */
    public DataSet getAllCustomer()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select id,name,address,phone,email,contact,company"
                        + " from customer";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}