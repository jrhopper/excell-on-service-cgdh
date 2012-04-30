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
    ProductDAL productDAL = new ProductDAL();
    public ProductBLL()
    {
    }
    /*
     * Author:Nguyen Kim Hoang
     * Purpose: get all Product
     * Date:2012/04/18
     */

    public int deleteProduct(int id)
    {
        return productDAL.deleteProduct(id);
    }

    public void updateProduct(int id, String name, String company, String price, String customerid, String description)
    {
        productDAL.updateProduct(id, name, company, price, customerid, description);
    }

    public DataSet getProductById(int id)
    {
        return productDAL.getProductById(id);
    }

    public int checkProductNameByName(String name)
    {
        return productDAL.checkProductNameByName(name);
    }

    public int insert(String name, String company, String price, String customerid, String description)
    {
        return productDAL.insert(name, company, price, customerid, description);
    }

    public DataSet getAllProduct()
    {
        return productDAL.getAllProduct();
    }
}