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
public class StatusPaymentDAL:ConfigurationDAL
{
    public StatusPaymentDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all status payment
     * Date:2012/04/18
     */
    public DataSet getAllStatusPayment()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select e.Status,d.name as serviceorder,"
                        + " cast(DatePart(dd,date) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,date) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,date) as varchar(4)) as date,"
                        + " e.description"
                        + " from serviceorder d inner join statuspayment e "
                        + " on d.id = e.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}