using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for ActionDAL
/// </summary>
public class ActionDAL:ConfigurationDAL
{
	public ActionDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    /*
     *Author:La Quoc Chuong 
     *Purpose:get all action in db
     *Date:2012/04/17
     */
    public DataSet getAllAction()
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        SqlDataAdapter da = new SqlDataAdapter("select * from action", conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:insert new action
     *Date:2012/04/17
     */
    public int insert(String name, String link, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        String query = "insert into action (name,link,description) values (@name,@link,@description)";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = query;
        cmd.Parameters.AddWithValue("@name", name);
        cmd.Parameters.AddWithValue("@link", link);
        cmd.Parameters.AddWithValue("@description", description);
        return cmd.ExecuteNonQuery();
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:check action name is existed in db
     *Date:2012/04/17
     */
    public Boolean checkActionName(String name)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("select count(*) as count from action where name = '" + name + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            if (int.Parse(reader["count"].ToString()) > 0)
                return false;
        }
        return true;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:get action by id
     *Date:2012/04/17
     */
    public DataSet getActionById(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from action where id = " + id, conn);
        da.Fill(ds);
        return ds;
    }
    /*
     *Author:La Quoc Chuong
     *Purpose:update action
     *Date:2012/04/17
     */
    public void update(int id, String name, String link, String description)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("update action set name = '" + name + "',link = '" + link + "',description = '" + description + "' where id = " + id, conn);
        cmd.ExecuteNonQuery();
    }
    /*
    *Author:La Quoc Chuong
    *Purpose: delete action. use method check action to check exists action
    *Date: 2012/04/17
    */
    public int deleteAction(int id)
    {
        DataSet ds = new DataSet();
        SqlConnection conn = connectDB();
        openConnect();
        if (checkAction(id) == true)
        {
            SqlCommand cmd = new SqlCommand("delete from action where id = @id", conn);
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
     *Author:La Quoc Chuong
     *Purpose: check action exists in other table. 0:not exists, 1:exists
     *Date: 2012/04/17
     */
    public Boolean checkAction(int id)
    {
        SqlConnection conn = connectDB();
        openConnect();
        SqlCommand cmd = new SqlCommand("SP_CheckAction", conn);
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
}