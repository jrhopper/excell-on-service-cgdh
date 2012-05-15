using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


public class ProductBLL
{
    ProductDAL productDAL = new ProductDAL();

    public ProductBLL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get all Product 
     *Date: 2012/04/27
     */
    public DataSet getAllProduct()
    {
        return productDAL.getAllProduct();
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: delete Product 
     *Date: 2012/04/27
     */
    public int deleteProduct(int id)
    {
        return productDAL.deleteProduct(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: update Product 
     *Date: 2012/04/27
     */
    public void updateProduct(int id, String name, String company, String price, int ddlCustomer, String description)
    {
        productDAL.updateProduct(id, name, company, price, ddlCustomer, description);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: get Product by id
     *Date: 2012/04/27
     */
    public DataSet getProductById(int id)
    {
        return productDAL.getProductById(id);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: check Product name is exists. if exists return 1,return 0.
     *Date: 2012/04/27
     */
    public int CheckProductNameByName(String name)
    {
        return productDAL.CheckProductNameByName(name);
    }
    /*
     *Author:Huynh Trong Gia
     *Purpose: insert new Product
     *Date: 2012/04/27
     */
    public int insert(String name, String company, String price, int ddlCustomer, String description)
    {
        return productDAL.insert(name, company,price, ddlCustomer, description);
    }

    public DataSet getAllCustomerName()
    {
        return productDAL.getAllCustomerName();
    }
}