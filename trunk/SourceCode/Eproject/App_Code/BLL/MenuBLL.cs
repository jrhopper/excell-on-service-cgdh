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
	public MenuBLL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public List<Menu> getAllMenuByRoleId(int roleId)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        MenuDAL menu = new MenuDAL();
        ds = menu.getAllMenuByRoleId(roleId);
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

    public List<Menu> getSubMenuByMenuIdAndRoleId(int roleId,int menuId)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        MenuDAL menu = new MenuDAL();
        ds = menu.getSubMenuByMenuIdAndRoleId(roleId,menuId);
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
}