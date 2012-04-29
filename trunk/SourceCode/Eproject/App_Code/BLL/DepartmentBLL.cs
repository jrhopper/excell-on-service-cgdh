using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

public class DepartmentBLL
{
    DepartmentDAL departmentDAL = new DepartmentDAL();

    public DepartmentBLL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get all Department 
     *Date: 2012/04/27
     */
    public DataSet getAllDepartment()
    {
        return departmentDAL.getAllDepartment();
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: delete Department 
     *Date: 2012/04/27
     */
    public int deleteDepartment(int id)
    {
        return departmentDAL.deleteDepartment(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: update Department 
     *Date: 2012/04/27
     */
    public void updateDepartment(int id, String name, String description)
    {
        departmentDAL.updateDepartment(id, name, description);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get Department by id
     *Date: 2012/04/27
     */
    public DataSet getDepartmentById(int id)
    {
        return departmentDAL.getDepartmentById(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: check Department name is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckDepartmentNameByName(String name)
    {
        return departmentDAL.CheckDepartmentNameByName(name);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: insert new Department
     *Date: 2012/04/27
     */
    public int insert(String name, String description)
    {
        return departmentDAL.insert(name, description);
    }
}