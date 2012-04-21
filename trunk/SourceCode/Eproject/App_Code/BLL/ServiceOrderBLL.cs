using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class ServiceOrderBLL
{
    public ServiceOrderBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrder
     * Date:2012/04/18
     */
    public DataSet getAllServiceOrder()
    {
        ServiceOrderDAL soDAL = new ServiceOrderDAL();
        DataSet ds = soDAL.getAllServiceOrder();
        return ds;
    }
}