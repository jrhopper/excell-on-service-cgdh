using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class ServiceTypeBLL
{
    public ServiceTypeBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceType
     * Date:2012/04/18
     */
    public DataSet getAllServiceType()
    {
        ServiceTypeDAL stDAL = new ServiceTypeDAL();
        DataSet ds = stDAL.getAllServiceType();
        return ds;
    }
}