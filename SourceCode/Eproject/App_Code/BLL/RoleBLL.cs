﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using WebApplication1.Entities;

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
    /*
     *Author:La Quoc Chuong
     *Purpose: get list role detail by role id
     *Date: 2012/04/17
     */
    public DataSet getAllRoleDetailByRoleId(int id)
    {
        return roleDAL.getAllRoleDetailByRoleId(id);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: check role detail. check by menuid,roleid,actionid
     *Date: 2012/04/17
     */
    public int checkRoleDetail(int menuId, int roleId, int actionId)
    {
        return roleDAL.checkRoleDetail(menuId, roleId, actionId);
    }
    /*
    *Author:La Quoc Chuong
    *Purpose: insert roledetail menuid,roleid,actionid
    *Date: 2012/04/17
    */
    public void insertRoleDetail(int menuid, int roleid, int actionid)
    {
        roleDAL.insertRoleDetail(menuid,roleid,actionid);
    }
    /*
    *Author:La Quoc Chuong
    *Purpose: getAllRoleDetail
    *Date: 2012/04/17
    */
    public DataSet getAllRoleDetail()
    {
        return roleDAL.getAllRoleDetail();
    }
    /*
    *Author:La Quoc Chuong
    *Purpose: delete role detail by id
    *Date: 2012/04/17
    */
    public void deleteRoleDetail(int roleDetailId)
    {
        roleDAL.deleteRoleDetail(roleDetailId);
    }
}