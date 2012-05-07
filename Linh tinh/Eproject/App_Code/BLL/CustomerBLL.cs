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
    CustomerDAL customerDAL = new CustomerDAL();

    public CustomerBLL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get all Customer 
     *Date: 2012/04/27
     */
    public DataSet getAllCustomer()
    {
        return customerDAL.getAllCustomer();
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: delete Customer 
     *Date: 2012/04/27
     */
    public int deleteCustomer(int id)
    {
        return customerDAL.deleteCustomer(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: update Customer 
     *Date: 2012/04/27
     */
    public void updateCustomer(int id, String name, String address, String phone, String email, String contact, String company)
    {
        customerDAL.updateCustomer(id, name, address, phone, email, contact, company);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get Customer by id
     *Date: 2012/04/27
     */
    public DataSet getCustomerById(int id)
    {
        return customerDAL.getCustomerById(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: check Customer name is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckCustomerNameByName(String name)
    {
        return customerDAL.CheckCustomerNameByName(name);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: insert new Customer
     *Date: 2012/04/27
     */
    public int insert(String name, String address, String phone, String email, String contact, String company)
    {
        return customerDAL.insert(name, address, phone, email, contact, company);
    }
}