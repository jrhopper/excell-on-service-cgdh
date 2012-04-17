using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class EmployeeBLL
{
    public EmployeeBLL()
    {
    }

    /*
     * Author:La Quoc Chuong 
     * Purpose:check exists of employee by checking user name and password
     * Date:2012/04/17
     */
    public int checkExistsEmployeeByUserNameAndPassword(String user, String pass)
    {
        EmployeeDAL empDal = new EmployeeDAL();
        return empDal.checkExistsEmployeeByUserNamePassword(user, pass);            
    }

    /*
     * Author:La Quoc Chuong
     * Purpose:get role id of employee by checking user name
     * Date:2012/04/17
     */
    public DataSet getRoleIdOfEmployeeByUserName(String userName)
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        DataSet ds = empDAL.getRoleIdOfEmployeeByUserName(userName);
        return ds;
    }

    /*
     * Author:La Quoc Chuong
     * Purpose: get all employee
     * Date:2012/04/17 
     */
    public DataSet getAllEmployee()
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        DataSet ds = empDAL.getAllEmployee();
        return ds;
    }
}