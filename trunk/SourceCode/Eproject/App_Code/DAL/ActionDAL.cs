using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ActionDAL
/// </summary>
public class ActionDAL:ConfigurationDAL
{
	public ActionDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /*
     *Author:La Quoc Chuong 
     *Purpose:get all action in db
     *Date:2012/04/17
     */
    public DataSet getAllAction()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from action", conn);
        da.Fill(ds);
        return ds;
    }
}