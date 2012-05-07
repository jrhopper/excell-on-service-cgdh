using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for EmployeeDAL
/// </summary>
public class DepartmentDAL : ConfigurationDAL
{
    public DepartmentDAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: get all department 
     *Date: 2012/04/27
     */
    public DataSet getAllDepartment()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from department", conn);
        da.Fill(ds);
        return ds;
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: delete department. use method CheckDepartment to check exists department
     *Date: 2012/04/27
     */
    public int deleteDepartment(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkDepartment(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from department where id = @id", conn);
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
     *Purpose: check department exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/27
     */
    public Boolean checkDepartment(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckDepartment", conn);
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
     *Purpose: update department
     *Date: 2012/04/27
     */
    public void updateDepartment(int id, String name, String description)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateDepartment @id,@name,@description", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@description", description);
        cmd.ExecuteNonQuery();
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get department by id
     *Date: 2012/04/27
     */
    public DataSet getDepartmentById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from department where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: check department name is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckDepartmentNameByName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from department where name = '" + name + "'", conn);
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
     *Purpose: insert new department
     *Date: 2012/04/27
     */
    public int insert(String name, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into department (name,description) values (@name,@description) ", conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }

}