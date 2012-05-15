using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


public class ProductDAL : ConfigurationDAL
{
    public ProductDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: get all product 
     *Date: 2012/04/27
     */
    public DataSet getAllProduct()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select a.id,a.name,a.company,a.price,b.name as customer,a.description"
                        + " from product a inner join customer b "
                        + " on a.customerid = b.id";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        da.Fill(ds);
        return ds;
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: delete product. use method CheckProduct to check exists product
     *Date: 2012/04/27
     */
    public int deleteProduct(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkProduct(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from product where id = @id", conn);
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
     *Purpose: check product exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/27
     */
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
    /*
     *Author:Huynh Trong Gia
     *Purpose: update product
     *Date: 2012/04/27
     */
    public void updateProduct(int id, String name, String company, String price, int ddlCustomer, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateProduct @id,@name,@company,@price,@customerid,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@company", company);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@customerid", ddlCustomer);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get product by id
     *Date: 2012/04/27
     */
    public DataSet getProductById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from product where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: check product name is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckProductNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from product where name = '" + name + "'", conn);
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
     *Purpose: insert new product
     *Date: 2012/04/27
     */
    public int insert(String name, String company, String price, int ddlCustomer, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into product (name,company,price,ddlCustomer,description) values (@name,@company,@price,@customerid,@description) ", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@company", company);
        cmd.Parameters.AddWithValue("@price", price);
        cmd.Parameters.AddWithValue("@customerid", ddlCustomer);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }


    //internal static object getAllCustomerName()
    //{
    //    throw new NotImplementedException();
    //}

    /*
     *Author:Huynh Trong Gia
     *Purpose:get all customername
     *Date:2012/04/17
     */

    public DataSet getAllCustomerName()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select name from customer", conn);
        da.Fill(ds);
        return ds;
    }


}