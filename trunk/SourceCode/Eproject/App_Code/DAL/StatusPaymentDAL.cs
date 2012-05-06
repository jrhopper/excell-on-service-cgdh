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
public class StatusPaymentDAL:ConfigurationDAL
{
    public StatusPaymentDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all status payment
     * Date:2012/04/18
     */

    public int deleteStatusPayment(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkStatusPayment(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from StatusPayment where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public Boolean checkStatusPayment(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckStatusPayment", conn);
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

    public void updateStatusPayment(int id, int serviceorderid, int status, String date, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateStatusPayment @id,@serviceorderid,@status,@date,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@serviceorderid", serviceorderid);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    public DataSet getStatusPaymentById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from StatusPayment where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

    public int checkStatusPaymentNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from StatusPayment where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

    public int insert(int serviceorderid, int status, String date, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into StatusPayment (serviceorderid,status,date,description) values (@serviceorderid,@status,@date,@description) ", conn);
        cmd.Parameters.AddWithValue("@serviceorderid", serviceorderid);
        cmd.Parameters.AddWithValue("@status", status);
        cmd.Parameters.AddWithValue("@date", date);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }

    public DataSet getAllStatusPayment()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select e.id,e.Status,d.name as serviceorder,"
                        + " cast(DatePart(dd,date) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,date) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,date) as varchar(4)) as date,"
                        + " e.description"
                        + " from serviceorder d inner join statuspayment e "
                        + " on d.id = e.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    public DataSet getAllStatusPaymentDetailByStatusPaymentId(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connectDB();
        openConnect();

        String query = "  select e.id,e.Status,d.name as serviceorder,"
                        + " cast(DatePart(dd,date) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,date) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,date) as varchar(4)) as date,"
                        + " e.description"
                        + " from serviceorder d inner join statuspayment e "
                        + " on d.id = e.id"
                        + " where a.id = " + id;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }
}