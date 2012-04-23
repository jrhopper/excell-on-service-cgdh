using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for DepartmentBLL
/// </summary>
public class DepartmentBLL
{
	public DepartmentBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataSet getAllDepartment()
    {
        DepartmentDAL depDAL = new DepartmentDAL();
        DataSet ds = depDAL.getAllDepartment();
        return ds;
    }
}