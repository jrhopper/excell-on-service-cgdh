using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateCustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        CustomerBLL customerBLL = new CustomerBLL();
        if (customerBLL.CheckCustomerNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (customerBLL.CheckCustomerNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (customerBLL.insert(txtName.Value, txtAddress.Value, txtPhone.Value, txtEmail.Value, txtContact.Value, txtCompany.Value) != -1)
            {
                Response.Write("<script>alert('Create Customer Successful.');window.location='ManageCustomer.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Customer Fail.');window.location='ManageCustomer.aspx';</script>");
            }
        }


    }
}