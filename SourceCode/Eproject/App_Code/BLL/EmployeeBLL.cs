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

    public int checkExistsEmployeeByUserNameAndPassword(String user, String pass)
    {
        EmployeeDAL empDal = new EmployeeDAL();
        return empDal.checkExistsEmployeeByUserNamePassword(user, pass);            
    }

    public DataSet getRoleIdOfEmployeeByUserName(String userName)
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        DataSet ds = empDAL.getRoleIdOfEmployeeByUserName(userName);
        return ds;
    }
}