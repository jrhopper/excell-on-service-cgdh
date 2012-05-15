using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EmployeeDAL
/// </summary>
public class CustomerDAL : ConfigurationDAL
{
    public CustomerDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: get all customer 
     *Date: 2012/04/27
     */
    public DataSet getAllCustomer()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from customer", conn);
        da.Fill(ds);
        return ds;
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: delete customer. use method CheckCustomer to check exists customer
     *Date: 2012/04/27
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
    /*
     *Author:Huynh Trong Gia
     *Purpose: check customer exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/27
     */
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
    /*
     *Author:Huynh Trong Gia
     *Purpose: update customer
     *Date: 2012/04/27
     */
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
    /*
     *Author:Huynh Trong Gia
     *Purpose: get customer by id
     *Date: 2012/04/27
     */
    public DataSet getCustomerById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from customer where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: check customer name is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckCustomerNameByName(String name)
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
    /*
     *Author:Huynh Trong Gia
     *Purpose: insert new customer
     *Date: 2012/04/27
     */
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

}