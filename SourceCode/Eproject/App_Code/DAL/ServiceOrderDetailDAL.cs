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
public class ServiceOrderDetailDAL:ConfigurationDAL
{
    public ServiceOrderDetailDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrderDetail
     * Date:2012/04/18
     */

    public int deleteServiceOrderDetail(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkServiceOrderDetail(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from ServiceOrderDetail where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public Boolean checkServiceOrderDetail(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckServiceOrderDetail", conn);
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

    public void updateServiceOrderDetail(int id, String serviceorderid, String empid, String taskname, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateServiceOrderDetail @id,@serviceorderid,@empid,@taskname,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@serviceorderid", serviceorderid);
        cmd.Parameters.AddWithValue("@empid", empid);
        cmd.Parameters.AddWithValue("@taskname", taskname);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    public DataSet getServiceOrderDetailById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from ServiceOrderDetail where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

    public int checkServiceOrderDetailNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from ServiceOrderDetail where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

    public int insert(String serviceorderid, String empid, String taskname, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into ServiceOrderDetail (serviceorderid,empid,taskname,description) values (@serviceorderid,@empid,@taskname,@description) ", conn);
        cmd.Parameters.AddWithValue("@serviceorderid", serviceorderid);
        cmd.Parameters.AddWithValue("@empid", empid);
        cmd.Parameters.AddWithValue("@taskname", taskname);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }

    public DataSet getAllServiceOrderDetail()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select a.id as id,b.name as serviceorder,c.name as employee,a.taskname,a.description"
                        + " from serviceorderdetail a inner join serviceorder b "
                        + " on a.serviceorderid = b.id inner join employee c "
                        + " on a.empid = c.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getAllServiceOrderDetailDetailByServiceOrderDetailId(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connectDB();
        openConnect();

        String query = "  select a.id as id,b.name as serviceorder,c.name as employee,a.taskname,a.description"
                        + " from serviceorderdetail a inner join serviceorder b "
                        + " on a.serviceorderid = b.id inner join employee c "
                        + " on a.empid = c.id"
                        + " where a.id = " + id;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }
}