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
    ServiceOrderDAL serviceorderDAL = new ServiceOrderDAL();
    public ServiceOrderBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrder
     * Date:2012/04/18
     */
    public int deleteServiceOrder(int id)
    {
        return serviceorderDAL.deleteServiceOrder(id);
    }

    public void updateServiceOrder(int id, int empid, String name, int customer, int servicetype, String begindate, String enddate, int complete, String description)
    {
        serviceorderDAL.updateServiceOrder(id, empid, name, customer, servicetype, begindate, enddate, complete, description);
    }

    public DataSet getServiceOrderById(int id)
    {
        return serviceorderDAL.getServiceOrderById(id);
    }

    public int checkServiceOrderNameByName(String name)
    {
        return serviceorderDAL.checkServiceOrderNameByName(name);
    }

    public int insert(int empid, String name, int customer, int servicetype, String begindate, String enddate, int complete, String description)
    {
        return serviceorderDAL.insert(empid, name, customer, servicetype, begindate, enddate, complete, description);
    }

    public DataSet getAllServiceOrder()
    {
        return serviceorderDAL.getAllServiceOrder();
    }
}