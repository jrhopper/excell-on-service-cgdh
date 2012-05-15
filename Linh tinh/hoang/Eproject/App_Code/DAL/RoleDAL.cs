using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using WebApplication1.Entities;

/// <summary>
/// Summary description for Role
/// </summary>
public class RoleDAL:ConfigurationDAL
{
    public RoleDAL()
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
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from role",conn);
        da.Fill(ds);
        return ds;
    }

    /*
     *Author:La Quoc Chuong
     *Purpose: delete role. use method checkRole to check exists role
     *Date: 2012/04/17
     */
    public int deleteRole(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkRole(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from role where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery(); 
            return 0;
        }else{
            return 1;
        }        
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: check role exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/17
     */
    public Boolean checkRole(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();                
        SqlCommand cmd = new SqlCommand("SP_CheckRole", conn);
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@id", id);
        SqlParameter param = new SqlParameter("@rs",SqlDbType.Int);
        param.Direction = ParameterDirection.Output;
        cmd.Parameters.Add(param);
        cmd.ExecuteNonQuery();
        if (cmd.Parameters["@rs"].Value.ToString() == "0")
            return true;
        return false;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: update role
     *Date: 2012/04/17
     */
    public void updateRole(int id,String name,String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateRole @id,@name,@description", conn);
        cmd.Parameters.AddWithValue("@id",id);
        cmd.Parameters.AddWithValue("@name",name);
        cmd.Parameters.AddWithValue("@description",description);
        cmd.ExecuteNonQuery();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: get role by id
     *Date: 2012/04/17
     */
    public DataSet getRoleById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from role where id = "+id,conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: check role name is exists. if exists return 1,return 0.
     *Date: 2012/04/17
     */
    public int checkRoleNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from role where name = '"+name+"'",conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: insert new role
     *Date: 2012/04/17
     */
    public int insert(String name,String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into role (name,description) values (@name,@description) ", conn);
        cmd.Parameters.AddWithValue("@name",name);
        cmd.Parameters.AddWithValue("@description",description);
        return cmd.ExecuteNonQuery();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: get all role detail
     *Date: 2012/04/17
     */
    public DataSet getAllRoleDetailByRoleId(int id)
    {
        DataSet ds = new DataSet();
        
        SqlConnection conn = connectDB();
        openConnect();
        
        String query = "select d.id as [RoleDetailId],d.menuid as MenuId,d.roleid as RoleId,d.actionid as ActionId,"
                                    +" d.description as RoleDetailDescription,a.name as ActionName,m.name as MenuName,r.name as RoleName "
	                                +" from roledetail d inner join [role] r on d.roleid = r.id "
	                                +" inner join menu m on d.menuid = m.id "
	                                +" inner join [action] a on d.actionid = a.id "
                                    + " where d.roleid = "+id;
        SqlDataAdapter da = new SqlDataAdapter(query,conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose: check role detail. check by menuid,roleid,actionid
     *Date: 2012/04/17
     */
    public int checkRoleDetail(int menuId, int roleId, int actionId)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from roledetail where menuid = @menuId and roleid = @roleId and actionid = @actionId",conn);
        cmd.Parameters.AddWithValue("@menuId",menuId);
        cmd.Parameters.AddWithValue("@roleId",roleId);
        cmd.Parameters.AddWithValue("@actionid",actionId);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }
    /*
    *Author:La Quoc Chuong
    *Purpose: insert roledetail menuid,roleid,actionid
    *Date: 2012/04/17
    */
    public void insertRoleDetail(int menuid,int roleid,int actionid)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into roledetail (menuid,roleid,actionid) values (@menuid,@roleid,@actionid)",conn);
        cmd.Parameters.AddWithValue("@menuid",menuid);
        cmd.Parameters.AddWithValue("@roleid",roleid);
        cmd.Parameters.AddWithValue("@actionid",actionid);
        cmd.ExecuteNonQuery();
    }

    /*
    *Author:La Quoc Chuong
    *Purpose: getAllRoleDetail
    *Date: 2012/04/17
    */
    public DataSet getAllRoleDetail()
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select rd.id as roledetailid,m.name as menuname, r.name as rolename,a.name as actionname "
                               +" from roledetail rd inner join menu m "
                               +" on rd.menuid = m.id inner join [role] r "
                               +" on rd.roleid = r.id inner join [action] a " 
                               +" on rd.actionid = a.id order by rolename,menuname",conn);
        da.Fill(ds);
        return ds;
    }
    /*
    *Author:La Quoc Chuong
    *Purpose: delete role detail by id
    *Date: 2012/04/17
    */
    public void deleteRoleDetail(int roleDetailId)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("delete from roledetail where id = @roledetailid",conn);
        cmd.Parameters.AddWithValue("@roledetailid",roleDetailId);
        cmd.ExecuteNonQuery();
    }
}