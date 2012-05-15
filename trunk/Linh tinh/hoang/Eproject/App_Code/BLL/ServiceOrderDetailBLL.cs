using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for ServiceOrderDetailBLL
/// </summary>
public class ServiceOrderDetailBLL
{
    ServiceOrderDetailDAL serviceorderdetailDAL = new ServiceOrderDetailDAL();
    public ServiceOrderDetailBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrderDetail
     * Date:2012/04/18
     */

    public int deleteServiceOrderDetail(int id)
    {
        return serviceorderdetailDAL.deleteServiceOrderDetail(id);
    }

    public void updateServiceOrderDetail(int id, int serviceorderid, int empid, int servicetype, String taskname, String description)
    {
        serviceorderdetailDAL.updateServiceOrderDetail(id, serviceorderid, empid,servicetype, taskname, description);
    }

    public DataSet getServiceOrderDetailById(int id)
    {
        return serviceorderdetailDAL.getServiceOrderDetailById(id);
    }

    public int checkServiceOrderDetailNameByName(String name)
    {
        return serviceorderdetailDAL.checkServiceOrderDetailNameByName(name);
    }

    public int insert(int serviceorderid, int empid, int servicetype, String taskname, String description)
    {
        return serviceorderdetailDAL.insert(serviceorderid, empid,servicetype, taskname, description);
    }

    public DataSet getAllServiceOrderDetail()
    {
        return serviceorderdetailDAL.getAllServiceOrderDetail();
    }
}