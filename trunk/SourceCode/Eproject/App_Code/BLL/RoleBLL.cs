using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for RoleBLL
/// </summary>
public class RoleBLL
{
    RoleDAL roleDAL = new RoleDAL();

	public RoleBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /*
     *Author:La Quoc Chuong
     *Purpose: get all role 
     *Date: 2012/04/17
     */
    public DataSet getAllRole()
    {        
        return roleDAL.getAllRole();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: delete role 
     *Date: 2012/04/17
     */
    public int deleteRole(int id)
    {
        return roleDAL.deleteRole(id);        
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: update role 
     *Date: 2012/04/17
     */
    public void updateRole(int id, String name, String description)
    {
        roleDAL.updateRole(id,name,description);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: get role by id
     *Date: 2012/04/17
     */
    public DataSet getRoleById(int id)
    {
        return roleDAL.getRoleById(id);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: check role name is exists. if exists return 1,return 0.
     *Date: 2012/04/17
     */
    public int checkRoleNameByName(String name)
    {
        return roleDAL.checkRoleNameByName(name);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: insert new role
     *Date: 2012/04/17
     */
    public int insert(String name, String description)
    {
        return roleDAL.insert(name, description);
    }
}