using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using WebApplication1.Entities;

/// <summary>
/// Summary description for MenuBLL
/// </summary>
public class MenuBLL:ConfigurationDAL
{
    MenuDAL menuDAL = new MenuDAL();
	public MenuBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /*
     *Author:La Quoc Chuong
     *Purpose:getAllMenuByRoleId
     *Date:2012/04/17
     */
    public List<Menu> getAllMenuByRoleId(int roleId)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();

        ds = menuDAL.getAllMenuByRoleId(roleId);
        List<Menu> list = new List<Menu>();
        if (ds.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Menu m = new Menu();
                m.Id = dr["menuid"].ToString();
                m.Name = dr["name"].ToString();
                m.Link = dr["link"].ToString();
                list.Add(m);
            }
        }
        closeConnect();
        return list;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:getSubMenuByMenuIdAndRoleId
     *Date:2012/04/17
     */
    public List<Menu> getSubMenuByMenuIdAndRoleId(int roleId,int menuId)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();

        ds = menuDAL.getSubMenuByMenuIdAndRoleId(roleId, menuId);
        List<Menu> list = new List<Menu>();
        if (ds.Tables[0].Rows.Count > 0)
        {
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Menu m = new Menu();
                m.Id = dr["id"].ToString();
                m.Name = dr["menuid"].ToString();
                m.RoleId = dr["roleid"].ToString();
                m.ActionId = dr["actionid"].ToString();
                m.Name = dr["name"].ToString();
                m.Link = dr["link"].ToString();
                list.Add(m);
            }
        }
        closeConnect();
        return list;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:checkMenuName
     *Date:2012/04/17
     */
    public bool checkMenuName(String name)
    {
        return menuDAL.checkMenuName(name);
    }

    /*
     *Author:La Quoc Chuong
     *Purpose:insert
     *Date:2012/04/17
     */
    public void insert(String name, String link, String description)
    {
        menuDAL.insert(name, link, description);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:get all menu
     *Date:2012/04/17
     */
    public DataSet getAllMenu()
    {
        return menuDAL.getAllMenu();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:get menu by id
     *Date:2012/04/17
     */
    public DataSet getMenuById(int id)
    {
        return menuDAL.getMenuById(id);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:update menu
     *Date:2012/04/17
     */
    public void update(int id, String name, String link, String description)
    {
        menuDAL.update(id, name, link, description);
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: delete menu 
     *Date: 2012/04/17
     */
    public int deleteMenu(int id)
    {
        return menuDAL.deleteMenu(id);
    }
}