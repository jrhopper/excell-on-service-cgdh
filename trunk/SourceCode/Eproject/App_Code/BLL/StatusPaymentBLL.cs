using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class StatusPaymentBLL
{
    public StatusPaymentBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all status payment
     * Date:2012/04/18
     */
    public DataSet getAllStatusPayment()
    {
        StatusPaymentDAL staDAL = new StatusPaymentDAL();
        DataSet ds = staDAL.getAllStatusPayment();
        return ds;
    }
}