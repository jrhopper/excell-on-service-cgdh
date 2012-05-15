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
            loadData();
    }
    public void loadData()
    {
        CustomerBLL cusBLL = new CustomerBLL();
        foreach (DataRow dr in cusBLL.getAllCustomer().Tables[0].Rows)
        ddlCustomer.Items.Add(new ListItem(dr["name"].ToString(),dr["id"].ToString()));
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        ProductBLL proBLL = new ProductBLL();
        if (proBLL.CheckProductNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (proBLL.CheckProductNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (proBLL.insert(txtName.Value,txtCompany.Value, txtPrice.Value, ddlCustomer.SelectedIndex,txtDescription.Text) != -1)
            {
                Response.Write("<script>alert('Create Product Successful.');window.location='ManageProduct.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Product Fail.');window.location='ManageProduct.aspx';</script>");
            }
        }
    }
}