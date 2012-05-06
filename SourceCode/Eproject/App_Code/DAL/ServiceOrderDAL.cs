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
public class ServiceOrderDAL:ConfigurationDAL
{
    public ServiceOrderDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all ServiceOrder
     * Date:2012/04/18
     */

    public int deleteServiceOrder(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkServiceOrder(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from ServiceOrder where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public Boolean checkServiceOrder(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckServiceOrder", conn);
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

    public void updateServiceOrder(int id, int empid, String name, int customer, int servicetype, String begindate, String enddate, int complete, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateServiceOrder @id,@empid,@name,@customer,@servicetype,@begindate,@enddate,@complete,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@empid", empid);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@customer", customer);
        cmd.Parameters.AddWithValue("@servicetype", servicetype);
        cmd.Parameters.AddWithValue("@begindate", begindate);
        cmd.Parameters.AddWithValue("@enddate", enddate);
        cmd.Parameters.AddWithValue("@complete", complete);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    public DataSet getServiceOrderById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from ServiceOrder where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

    public int checkServiceOrderNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from ServiceOrder where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

    public int insert(int empid, String name, int customer, int servicetype, String begindate, String enddate, int complete, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into ServiceOrder (empid,name,customer,servicetype,begindate,enddate,complete,description) values (@empid,@name,@customer,@servicetype,@begindate,@enddate,@complete,@description) ", conn);
        cmd.Parameters.AddWithValue("@empid", empid);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@customer", customer);
        cmd.Parameters.AddWithValue("@servicetype", servicetype);
        cmd.Parameters.AddWithValue("@begindate", begindate);
        cmd.Parameters.AddWithValue("@enddate", enddate);
        cmd.Parameters.AddWithValue("@complete", complete);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }

    public DataSet getAllServiceOrder()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select a.id as id,a.name as serviceorder,c.name as employee,d.name as customer,b.name as servicetype,"
                        + " cast(DatePart(dd,begindate) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,begindate) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,begindate) as varchar(4)) as begindate,"
                        + " cast(DatePart(dd,enddate) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,enddate) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,enddate) as varchar(4)) as enddate,"
                        + " a.complete as complete,a.description"
                        + " from serviceorder a inner join servicetype b "
                        + " on a.servicetype = b.id inner join employee c "
                        + " on a.empid = c.id inner join customer d"
                        + " on a.customer = d.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getAllServiceOrderDetailByServiceOrderId(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connectDB();
        openConnect();

        String query = "  select a.id as id,a.name as serviceorder,c.name as employee,d.name as customer,b.name as servicetype,"
                        + " cast(DatePart(dd,begindate) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,begindate) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,begindate) as varchar(4)) as begindate,"
                        + " cast(DatePart(dd,enddate) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,enddate) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,enddate) as varchar(4)) as enddate,"
                        + " a.complete as complete,a.description"
                        + " from serviceorder a inner join servicetype b "
                        + " on a.servicetype = b.id inner join employee c "
                        + " on a.empid = c.id inner join customer d"
                        + " on a.customer = d.id"
                        + " where a.id = " + id;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }
}