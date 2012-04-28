using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Entities;
using System.Collections;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for EmployeeDAL
/// </summary>
public class ServiceTypeDAL:ConfigurationDAL
{
    public ServiceTypeDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceType
     * Date:2012/04/18
     */

    public int deleteServiceType(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkServiceType(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from ServiceType where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public Boolean checkServiceType(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckServiceType", conn);
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

    public void updateServiceType(int id, String name, String image, String charges, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateServiceType @id,@name,@image,@charges,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@image", image);
        cmd.Parameters.AddWithValue("@charges", charges);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    public DataSet getServiceTypeById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from ServiceType where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

    public int checkServiceTypeNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from ServiceType where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

    public int insert(String name, String image, String charges, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into ServiceType (name,image,charges,description) values (@name,@image,@charges,@description) ", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@image", image);
        cmd.Parameters.AddWithValue("@charges", charges);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }

    public DataSet getAllServiceType()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select id,name,image,charges,description"
                        + " from servicetype";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getAllServiceTypeDetailByServiceTypeId(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connectDB();
        openConnect();

        String query = "  select id,name,image,charges,description"
                        + " from servicetype";
                        + " where id = " + id;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }
}