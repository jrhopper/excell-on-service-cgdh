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
public class CustomerDAL:ConfigurationDAL
{
    public CustomerDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Customer
     * Date:2012/04/18
     */
    public int deleteCustomer(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkCustomer(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from customer where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public Boolean checkCustomer(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckCustomer", conn);
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

    public void updateCustomer(int id, String name, String address, String phone, String email, String contact, String company)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateCustomer @id,@name,@address,@phone,@email,@contact,@company", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@phone", phone);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@contact", contact);
        cmd.Parameters.AddWithValue("@company", company);
        cmd.ExecuteNonQuery();
    }
    public DataSet getCustomerById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from customer where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

    public int checkCustomerNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from customer where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

    public int insert(String name, String address, String phone, String email, String contact, String company)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into customer (name,address,phone,email,contact,company) values (@name,@address,@phone,@email,@contact,@company) ", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@phone", phone);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@contact", contact);
        cmd.Parameters.AddWithValue("@company", company);
        return cmd.ExecuteNonQuery();
    }

    public DataSet getAllCustomer()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select id,name,address,phone,email,contact,company"
                        + " from customer";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getAllCustomerDetailByCustomerId(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connectDB();
        openConnect();

        String query = "  select id,name,address,phone,email,contact,company"
                        + " from customer"
                        + " where id = " +id;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }
    
}