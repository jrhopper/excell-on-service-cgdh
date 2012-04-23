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
public class ServiceOrderDAL:ConfigurationDAL
{
    public ServiceOrderDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrder
     * Date:2012/04/18
     */
    public DataSet getAllServiceOrder()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select a.id as id,a.name as serviceorder,c.name as employee,d.name as customer,b.name as servicetype,"
                        + " cast(DatePart(dd,begindate) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,begindate) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,begindate) as varchar(4)) as begindate,"
                        + " cast(DatePart(dd,enddate) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,enddate) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,enddate) as varchar(4)) as enddate,"
                        + " a.complete as complete,a.description"
                        + " from serviceorder a inner join servicetype b "
                        + " on a.servicetype = b.id inner join employee c "
                        + " on a.empid = c.id inner join customer d"
                        + " on a.customer = d.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}