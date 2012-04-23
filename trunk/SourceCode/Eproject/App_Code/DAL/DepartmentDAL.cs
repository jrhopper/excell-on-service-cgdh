using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Department
/// </summary>
public class DepartmentDAL:ConfigurationDAL
{
	public DepartmentDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet getAllDepartment()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "SELECT * FROM Department";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}