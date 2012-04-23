using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class DepartmentBLL
{
    public DepartmentBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Department
     * Date:2012/04/18
     */
    public DataSet getAllDepartment()
    {
        DepartmentDAL deDAL = new DepartmentDAL();
        DataSet ds = deDAL.getAllDepartment();
        return ds;
    }
}