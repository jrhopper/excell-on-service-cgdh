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
public class ProductDAL:ConfigurationDAL
{
    public ProductDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Product
     * Date:2012/04/18
     */
    public DataSet getAllProduct()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select a.name,a.company,a.price,b.name as customer,a.description"
                        + " from product a inner join customer b "
                        + " on a.customerid = b.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}