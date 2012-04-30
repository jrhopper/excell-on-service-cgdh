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
    StatusPaymentDAL statuspaymentDAL = new StatusPaymentDAL();
    public StatusPaymentBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all status payment
     * Date:2012/04/18
     */
    public int deleteStatusPayment(int id)
    {
        return statuspaymentDAL.deleteStatusPayment(id);
    }

    public void updateStatusPayment(int id, String serviceorderid, String status, String date, String description)
    {
        statuspaymentDAL.updateStatusPayment(id, serviceorderid, status, date, description);
    }

    public DataSet getStatusPaymentById(int id)
    {
        return statuspaymentDAL.getStatusPaymentById(id);
    }

    public int checkStatusPaymentNameByName(String name)
    {
        return statuspaymentDAL.checkStatusPaymentNameByName(name);
    }

    public int insert(String serviceorderid, String status, String date, String description)
    {
        return statuspaymentDAL.insert(serviceorderid, status, date, description);
    }

    public DataSet getAllStatusPayment()
    {
        return statuspaymentDAL.getAllStatusPayment();
    }
}