using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebApplication1.Entities;

public class EmployeeBLL
{
    EmployeeDAL employeeDAL = new EmployeeDAL();
    public EmployeeBLL()
    {
    }



    public int checkExistsEmployeeByUserNameAndPassword(String user, String pass)
    {
        EmployeeDAL empDal = new EmployeeDAL();
        return empDal.checkExistsEmployeeByUserNamePassword(user, pass);
    }

    public DataSet getEmployeeById(int id)
    {
        return employeeDAL.getEmployeeById(id);
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: check Employee username is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckEmployeeUserNameByUserName(String user)
    {
        return employeeDAL.CheckEmployeeUserNameByUserName(user);
    }

    /*
     * Author:Huynh Trong Gia
     * Purpose:get role id of employee by checking user name
     * Date:2012/04/27
     */
    public DataSet getRoleIdOfEmployeeByUserName(String userName)
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        DataSet ds = empDAL.getRoleIdOfEmployeeByUserName(userName);
        return ds;
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: get all Employee 
     *Date: 2012/04/27
     */
    public DataSet getAllEmployee()
    {
        return employeeDAL.getAllEmployee();
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: get employee by user
     *Date: 2012/04/27
     */
    public Employee getEmployeeByUser(String user)
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        return empDAL.getEmployeeByUserName(user);
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: update Employee 
     *Date: 2012/04/27
     */
    public void updateEmployee(int id, String user, String name, String birthday, String address, String phone, String email)
    {
        employeeDAL.updateEmployee(id, user, name, birthday, address, phone, email);
    }


    /*
     *Author:Huynh Trong Gia
     *Purpose: insert new Employee
     *Date: 2012/04/27
     */
    public int insert(String user, String name, String birthday, int sex, String address, String phone, String email)
    {
        return employeeDAL.insert(user, name, birthday, sex, address, phone, email);
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: delete Employee 
     *Date: 2012/04/27
     */
    public int deleteEmployee(int id)
    {
        return employeeDAL.deleteEmployee(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: change password
     *Date: 2012/04/27
     */
    public void changePass(String newPass, String userName)
    {
        EmployeeDAL emplDAL = new EmployeeDAL();
        emplDAL.changePass(newPass, userName);
    }

    public int updateEmployee(String user, String name, String birthday, int sex, String address, String phone, String email)
    {
        EmployeeDAL empDAL = new EmployeeDAL();
        return empDAL.updateEmployee(user, name, birthday, sex, address, phone, email);
    }
}