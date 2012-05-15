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

    /*
     * Author:La Quoc Chuong
     * Purpose:connect database
     * Date:2012/04/17
     */
    public SqlConnection connectDB()
    {        
       strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
       con = new SqlConnection(strCon);
       return con;
    }

    /*
     *Author:La Quoc Chuong 
     * Purpose:open connect
     * Date:2012/04/17
     */
    public void openConnect()
    {
        con.Open();
    }

    /*
     * Author:La Quoc Chuong
     * Purpose:close connect
     * Date:2012/04/17
     */
    public void closeConnect()
    {
        con.Close();
    }
}