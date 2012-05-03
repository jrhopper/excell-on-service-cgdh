using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormCreateProduct : System.Web.UI.Page
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
        ProductBLL productBLL = new ProductBLL();
        foreach (DataRow dr in productBLL.getAllCustomerName().Tables[0].Rows)
            ddlCustomer.Items.Add(new ListItem(dr["name"].ToString()));
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        ProductBLL customerBLL = new ProductBLL();
        
            if (customerBLL.insert(txtName.Value, txtCompany.Value, int.Parse(txtPrice.Value), int.Parse(ddlCustomer.SelectedValue), txtDescription.Value) != -1)
            {
                Response.Write("<script>alert('Create Product Successful.');window.location='ManageProduct.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Product Fail.');window.location='ManageProduct.aspx';</script>");
            }        
    }
}