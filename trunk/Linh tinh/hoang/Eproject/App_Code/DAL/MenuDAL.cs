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
    /*
     *Author:La Quoc Chuong
     *Purpose:insert new menu
     *Date:2012/04/17
     */
    public int insert(String name, String link, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "insert into menu (name,link,description) values (@name,@link,@description)";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@name",name);
        cmd.Parameters.AddWithValue("@link",link);
        cmd.Parameters.AddWithValue("@description",description);
        return cmd.ExecuteNonQuery();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:check menu name is existed in db
     *Date:2012/04/17
     */
    public Boolean checkMenuName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from menu where name = '"+name+"'",conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return false;
        }
        return true;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:get all menu
     *Date:2012/04/17
     */
    public DataSet getAllMenu()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from menu",conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:get menu by id
     *Date:2012/04/17
     */
    public DataSet getMenuById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from menu where id = "+id,conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:update menu
     *Date:2012/04/17
     */
    public void update(int id,String name,String link,String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("update menu set name = '"+name+"',link = '"+link+"',description = '"+description+"' where id = "+id,conn);
        cmd.ExecuteNonQuery();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: delete menu. use method check menu to check exists menu
     *Date: 2012/04/17
     */
    public int deleteMenu(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkMenu(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from menu where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: check menu exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/17
     */
    public Boolean checkMenu(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckMenu", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlParameter param = new SqlParameter("@rs", SqlDbType.Int);
        param.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(param);
        cmd.ExecuteNonQuery();
        if (cmd.Parameters["@rs"].Value.ToString() == "0")
            return true;
        return false;
    }
}