using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using WebApplication1.Entities;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for MenuDAL
/// </summary>
public class MenuDAL:ConfigurationDAL
{
    public MenuDAL()
    { }
		

    /*
     *Author:La Quoc Chuong 
     *Purpose:get all menu by role id
     *Date:2012/04/17
     */
    public DataSet getAllMenuByRoleId(int roleId)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select distinct m.id as menuid,m.name,m.link "
                        +" from menu m inner join roledetail r "
                        +" on m.id = r.menuid "
                        +" where r.roleid = "+roleId;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        closeConnect();
        return ds;        
    }

    /*
     *Author:La Quoc Chuong
     *Purpose:get sub menu of menu by menu id and role id
     *Date:2012/04/17
     */
    public DataSet getSubMenuByMenuIdAndRoleId(int roleId, int menuId)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select ro.id,ro.menuid,ro.roleid,ro.actionid,a.name,a.link "
                        +" from roledetail ro inner join action a on a.id = ro.actionid "
                        +" where roleid = "+roleId+" and menuid = "+menuId;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        closeConnect();
        return ds;
    }
}