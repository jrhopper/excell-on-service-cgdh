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
public class ProductDAL:ConfigurationDAL
{
    public ProductDAL()
	{
    
    }

    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Product
     * Date:2012/04/18
     */

    public int deleteProduct(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkProduct(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from Product where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public Boolean checkProduct(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckProduct", conn);
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

    public void updateProduct(int id, String name, String company, String price, String customerid, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateProduct @id,@name,@company,@price,@customerid,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@company", company);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@customerid", customerid);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    public DataSet getProductById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from Product where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

    public int checkProductNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from Product where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

    public int insert(String name, String company, String price, String customerid, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into Product (name,company,price,customerid,description) values (@name,@company,@price,@customerid,@description) ", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@company", company);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@customerid", customerid);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }

    public DataSet getAllProduct()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select a.id,a.name,a.company,a.price,b.name as customer,a.description"
                        + " from product a inner join customer b "
                        + " on a.customerid = b.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    public DataSet getAllProductDetailByProductId(int id)
    {
        DataSet ds = new DataSet();

        SqlConnection conn = connectDB();
        openConnect();

        String query = "  select a.id,a.name,a.company,a.price,b.name as customer,a.description"
                        + " from product a inner join customer b "
                        + " on a.customerid = b.id"
                        + " where a.id = " + id;
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }
    
}