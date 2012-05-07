using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateServiceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        if (soBLL.checkServiceOrderNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (soBLL.checkServiceOrderNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (soBLL.insert(ddlEmployee.SelectedIndex, txtName.Value, ddlCustomer.SelectedIndex, ddlServiceType.SelectedIndex,txtBeginDate.Value,txtEndDate.Value,ddlComplete.SelectedIndex, txtDescription.Text) != -1)
            {
                Response.Write("<script>alert('Create Service Order Successful.');window.location='ManageServiceOrder.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Service Order Fail.');window.location='ManageServiceOrder.aspx';</script>");
            }
        }
    }
}