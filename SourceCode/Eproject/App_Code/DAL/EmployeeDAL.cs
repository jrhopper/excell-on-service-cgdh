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
public class EmployeeDAL
{
    ConfigurationDAL config;   
    SqlConnection con;    

	public EmployeeDAL()
	{
    
    }
		//
		// TODO: Add constructor logic here
		//

    public DataSet getAllEmployee()
    {
        config = new ConfigurationDAL();
        con = config.connectDB();
        config.openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from employee", con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        config.closeConnect();
        return ds;
    }

    public Employee getEmployeeByUserName(String userName)
    {
        Employee emp = new Employee();
        config = new ConfigurationDAL();
        con = config.connectDB();
        config.openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from employee where username = '"+userName+"'",con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return emp;
    }
	
}