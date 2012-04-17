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
public class EmployeeDAL:ConfigurationDAL
{
    public EmployeeDAL()
	{
    
    }

    public int checkExistsEmployeeByUserNamePassword(String userName,String password)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select count(*) as count from employee where userName = @user and password = @pass";
        SqlCommand cmd = new SqlCommand(query,conn);
        cmd.Parameters.AddWithValue("@user",userName);
        cmd.Parameters.AddWithValue("@pass", password);
        SqlDataReader reader = cmd.ExecuteReader();
        int count = 0;
        while (reader.Read())
            count = (int)reader["count"];
        closeConnect();
        return count;
    }

    public DataSet getRoleIdOfEmployeeByUserName(String user)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select roleid from employee where userName = '"+user+"'";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}