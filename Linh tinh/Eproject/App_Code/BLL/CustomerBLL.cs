using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class CustomerBLL
{
    public CustomerBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Customer
     * Date:2012/04/18
     */
    public DataSet getAllCustomer()
    {
        CustomerDAL cusDAL = new CustomerDAL();
        DataSet ds = cusDAL.getAllCustomer();
        return ds;
    }
}