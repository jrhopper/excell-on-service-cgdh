using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for EmployeeBLL
/// </summary>
public class ProductBLL
{
    public ProductBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Product
     * Date:2012/04/18
     */
    public DataSet getAllProduct()
    {
        ProductDAL proDAL = new ProductDAL();
        DataSet ds = proDAL.getAllProduct();
        return ds;
    }
}