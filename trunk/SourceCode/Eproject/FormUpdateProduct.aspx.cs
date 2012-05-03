using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using WebApplication1.Entities;

public partial class Admin_FormUpdateProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            loadData();            
        }
    }

    public void loadData()
    {
        int id = int.Parse(Request.Params["id"].ToString());
        ProductBLL productBLL = new ProductBLL();
        DataSet ds = productBLL.getProductById(id);
        txtId.Value = id.ToString();
        txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
        txtCompany.Value = ds.Tables[0].Rows[0]["company"].ToString();
        txtPrice.Value = ds.Tables[0].Rows[0]["price"].ToString();
        ddlCustomer.SelectedValue = ds.Tables[0].Rows[0]["customerid"].ToString();
        foreach (DataRow dr in productBLL.getAllCustomerName().Tables[0].Rows)
        ddlCustomer.Items.Add(new ListItem(dr["name"].ToString()));        
        txtDescription.Value = ds.Tables[0].Rows[0]["description"].ToString();
    }
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ProductBLL productBLL = new ProductBLL();
        productBLL.updateProduct(int.Parse(txtId.Value), txtName.Value, txtCompany.Value, int.Parse(txtPrice.Value), int.Parse(ddlCustomer.SelectedValue), txtDescription.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageProduct.aspx';</script>");


    }
}