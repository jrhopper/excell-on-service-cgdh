using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            CustomerBLL customerBLL = new CustomerBLL();
            DataSet ds = customerBLL.getCustomerById(id);
            txtId.Value = id.ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            txtAddress.Value = ds.Tables[0].Rows[0]["address"].ToString();
            txtPhone.Value = ds.Tables[0].Rows[0]["phone"].ToString();
            txtEmail.Value = ds.Tables[0].Rows[0]["email"].ToString();
            txtContact.Value = ds.Tables[0].Rows[0]["contact"].ToString();
            txtCompany.Value = ds.Tables[0].Rows[0]["company"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        CustomerBLL customerBLL = new CustomerBLL();
        customerBLL.updateCustomer(int.Parse(txtId.Value), txtName.Value, txtAddress.Value, txtPhone.Value, txtEmail.Value, txtContact.Value, txtCompany.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageCustomer.aspx';</script>");
    }
}