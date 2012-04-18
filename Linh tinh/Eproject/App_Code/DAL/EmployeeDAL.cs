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

    /*
     *Author:La Quoc Chuong
     *Purpose: check exists of employee by checking user name and password
     *Date: 2012/04/17
     */
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

    /*
     * Author:La Quoc Chuong
     * Purpose:get role id of employee by checking user name
     * Date: 2012/04/17
     */
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

    /*
     * Author:La Quoc Chuong
     * Purpose: get all employee
     * Date:2012/04/17
     */
    public DataSet getAllEmployee()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select e.id,username,password,d.name as department,r.name as role,e.name,"
                        +" cast(DatePart(dd,birthday) as varchar(2))+'-'+"
                        +" cast(DatePart(mm,birthday) as varchar(2))+'-'+"
                        +" cast(DatePart(yyyy,birthday) as varchar(4)) as birthday,"
                        +" (case sex when 1 then 'Male' when 0 then 'Female' end) as gender,"
                        +" address,phone,email  "
                        +" from department d inner join employee e "
                        +" on d.id = e.department inner join role r " 
                        +" on r.id = e.roleid ";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
    
}