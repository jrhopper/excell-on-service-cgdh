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
public class EmployeeDAL : ConfigurationDAL
{
    public EmployeeDAL()
    {

    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: check exists of employee by checking user name and password
     *Date: 2012/04/27
     */
    public int checkExistsEmployeeByUserNamePassword(String userName, String password)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select count(*) as count from employee where userName = @user and password = @pass";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@user", userName);
        cmd.Parameters.AddWithValue("@pass", password);
        SqlDataReader reader = cmd.ExecuteReader();
        int count = 0;
        while (reader.Read())
            count = (int)reader["count"];
        closeConnect();
        return count;
    }

    /*
     * Author:Huynh Trong Gia
     * Purpose:get role id of employee by checking user name
     * Date: 2012/04/27
     */
    public DataSet getRoleIdOfEmployeeByUserName(String user)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select roleid from employee where userName = '" + user + "'";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    /*
     * Author:Huynh Trong Gia
     * Purpose: get all employee
     * Date:2012/04/27
     */
    public DataSet getAllEmployee()
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "  select e.id,username,password,d.name as department,r.name as role,e.name,"
                        + " cast(DatePart(dd,birthday) as varchar(2))+'-'+"
                        + " cast(DatePart(mm,birthday) as varchar(2))+'-'+"
                        + " cast(DatePart(yyyy,birthday) as varchar(4)) as birthday,"
                        + " (case sex when 1 then 'Male' when 0 then 'Female' end) as gender,"
                        + " address,phone,email  "
                        + " from department d inner join employee e "
                        + " on d.id = e.department inner join role r "
                        + " on r.id = e.roleid ";
        SqlDataAdapter da = new SqlDataAdapter(query, conn);
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

    /*
     *Author:Huynh Trong Gia
     *Purpose: delete employee. use method CheckEmployee to check exists employee
     *Date: 2012/04/27
     */
    public int deleteEmployee(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkEmployee(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from employee where id = @id", conn);
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
     *Purpose: check employee exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/27
     */
    public Boolean checkEmployee(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckEmployee", conn);
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
     *Purpose: get employee by user name
     *Date: 2012/04/27
     */
    public Employee getEmployeeByUserName(String user)
    {
        Employee emp = new Employee();
        SqlConnection conn = connectDB();
        openConnect();
        String query = "select username,password,name, "
                        + " (cast(datepart(dd,birthday) as varchar(2))+'/'+ cast(datepart(mm,birthday) as varchar(2))+'/'+cast(datepart(yyyy,birthday) as varchar(4))) as birthday, "
                        + " sex,address,phone,email "
                        + " from employee where username = @user";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.Add("@user", user);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            emp.Username = reader.GetString(0).ToString();
//            emp.Password = reader.GetString(1).ToString();
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
     *Author:Huynh Trong Gia
     *Purpose: update employee
     *Date: 2012/04/27
     */
    public void updateEmployee(int id, String user, String name, String birthday, String address, String phone, String email)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("exec SP_UpdateEmployee @id,@username,@name,@birthday,@address,@phone,@email", conn);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@username", user);
//        cmd.Parameters.AddWithValue("@password", password);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@birthday", birthday);
//        cmd.Parameters.AddWithValue("@sex", sex);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@phone", phone);
        cmd.Parameters.AddWithValue("@email", email);
        cmd.ExecuteNonQuery();
    }


    /*
     *Author:Huynh Trong Gia
     *Purpose: change password
     *Date: 2012/04/27
     */
    public void changePass(String newPass, String userName)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("Exec SP_ChangePassword @NewPass,@UserName", conn);
        cmd.Parameters.AddWithValue("@NewPass", newPass);
        cmd.Parameters.AddWithValue("@UserName", userName);
        cmd.ExecuteNonQuery();
    }


    /*
     *Author:Huynh Trong Gia
     *Purpose: insert new employee
     *Date: 2012/04/27
     */
    public int insert(String user, String name, String birthday, int sex, String address, String phone, String email)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("insert into employee (user,password,name,birthday,sex,address,phone,email) values (@user,@password,@name,@birthday,@sex,@address,@phone,@email) ", conn);
        cmd.Parameters.AddWithValue("@username", user);
//        cmd.Parameters.AddWithValue("@password", password);
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@birthday", birthday);
        cmd.Parameters.AddWithValue("@sex", sex);
        cmd.Parameters.AddWithValue("@address", address);
        cmd.Parameters.AddWithValue("@phone", phone);
        cmd.Parameters.AddWithValue("@email", email);
        return cmd.ExecuteNonQuery();
    }


    /*
     *Author:Huynh Trong Gia
     *Purpose: check employee username is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckEmployeeUserNameByUserName(String user)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from employee where username = '" + user + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return 1;
        }
        return 0;
    }

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
     *Author:Huynh Trong Gia
     *Purpose: get customer by id
     *Date: 2012/04/27
     */
    public DataSet getEmployeeById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from employee where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }

}