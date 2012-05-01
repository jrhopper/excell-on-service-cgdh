using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateOrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        ServiceOrderDetailBLL serviceOrderDetailBLL = new ServiceOrderDetailBLL();
        if (serviceOrderDetailBLL.checkServiceOrderDetailNameByName(txtTaskname.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (serviceOrderDetailBLL.checkServiceOrderDetailNameByName(txtTaskname.Value) == 0)
        {
            lbMessage.Text = "";
            if (serviceOrderDetailBLL.insert(ddlServiceOrder.Value, ddlEmployee.Value, txtTaskname.Value, txtDescription.Value) != -1)
            {
                Response.Write("<script>alert('Create Service Order Detail Successful.');window.location='ManageOrderDetail.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Service Order Detail Fail.');window.location='ManageOrderDetail.aspx';</script>");
            }
        }


    }
}