﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateProduct : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            ProductBLL proBLL = new ProductBLL();
            DataSet ds = proBLL.getProductById(id);
            txtId.Value = id.ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            txtCompany.Value = ds.Tables[0].Rows[0]["company"].ToString();
            txtPrice.Value = ds.Tables[0].Rows[0]["price"].ToString();
            CustomerBLL cusBLL = new CustomerBLL();
            foreach (DataRow dr in cusBLL.getAllCustomer().Tables[0].Rows)
                ddlCustomer.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
            txtDescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ProductBLL proBLL = new ProductBLL();
        proBLL.updateProduct(int.Parse(txtId.Value), txtName.Value, txtCompany.Value, txtPrice.Value,int.Parse(ddlCustomer.SelectedValue), txtDescription.Text);
        Response.Write("<script>alert('Update Successful!');window.location='ManageProduct.aspx';</script>");
    }
}