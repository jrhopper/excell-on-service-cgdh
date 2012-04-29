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
}