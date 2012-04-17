using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for ConfigurationDAL
/// </summary>
public class ConfigurationDAL
{
    String strCon;
    SqlConnection con;

    public ConfigurationDAL()
    {

    }

    public SqlConnection connectDB()
    {        
       strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
       con = new SqlConnection(strCon);
       return con;
    }

    public void openConnect()
    {
        con.Open();
    }

    public void closeConnect()
    {
        con.Close();
    }
}