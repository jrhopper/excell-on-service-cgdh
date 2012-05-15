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
    ServiceTypeDAL servicetypeDAL = new ServiceTypeDAL();
    public ServiceTypeBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceType
     * Date:2012/04/18
     */
    public int deleteServiceType(int id)
    {
        return servicetypeDAL.deleteServiceType(id);
    }

    public void updateServiceType(int id, String name, String image, String charges, String description)
    {
        servicetypeDAL.updateServiceType(id, name, image, charges, description);
    }

    public DataSet getServiceTypeById(int id)
    {
        return servicetypeDAL.getServiceTypeById(id);
    }

    public int checkServiceTypeNameByName(String name)
    {
        return servicetypeDAL.checkServiceTypeNameByName(name);
    }

    public int insert(String name, String image, String charges, String description)
    {
        return servicetypeDAL.insert(name, image, charges, description);
    }

    public DataSet getAllServiceType()
    {
        return servicetypeDAL.getAllServiceType();
    }
}