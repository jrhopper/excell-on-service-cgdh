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

    /*
     *Author:La Quoc Chuong
     *Purpose: get employee by user name
     *Date: 2012/04/17
     */
    public Employee getEmployeeByUserName(String user)
    {
        Employee emp = new Employee();
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select username,password,name, "
                        +" (cast(datepart(dd,birthday) as varchar(2))+'/'+ cast(datepart(mm,birthday) as varchar(2))+'/'+cast(datepart(yyyy,birthday) as varchar(4))) as birthday, "
                        +" sex,address,phone,email "
                        +" from employee where username = @user";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.Add("@user",user);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            emp.Username = reader.GetString(0).ToString();
            emp.Password = reader.GetString(1).ToString();
            emp.Name = reader.GetString(2).ToString();
            emp.Birthday = reader.GetString(3).ToString();
            emp.Sex = reader.GetInt32(4).ToString();
            emp.Address = reader.GetString(5).ToString();
            emp.Phone = reader.GetString(6).ToString();
            emp.Email = reader.GetString(7).ToString();
        }
        return emp;
    }

    /*
     *Author:La Quoc Chuong
     *Purpose: update info of employee
     *Date: 2012/04/17
     */
    public int updateEmployee(String user, String name, String birthday, int sex, String address, String phone, String email)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "update employee set name = @name, birthday= @birthday, sex= @sex, address = @address,"
                        +" phone = @phone, email = @email where username = @user";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@birthday", birthday);
        cmd.Parameters.AddWithValue("@sex", sex);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@phone", phone);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@user", user);
        return cmd.ExecuteNonQuery();
    }

    /*
     *Author:La Quoc Chuong
     *Purpose: change password
     *Date: 2012/04/17
     */
    public void changePass(String newPass,String userName)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("Exec SP_ChangePassword @NewPass,@UserName", conn);
        cmd.Parameters.AddWithValue("@NewPass", newPass);
        cmd.Parameters.AddWithValue("@UserName", userName);
        cmd.ExecuteNonQuery();
    }
    

}