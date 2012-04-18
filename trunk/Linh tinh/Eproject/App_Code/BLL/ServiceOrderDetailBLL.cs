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
    public ServiceOrderDetailBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrderDetail
     * Date:2012/04/18
     */
    public DataSet getAllServiceOrderDetail()
    {
        ServiceOrderDetailDAL sodDAL = new ServiceOrderDetailDAL();
        DataSet ds = sodDAL.getAllServiceOrderDetail();
        return ds;
    }
}