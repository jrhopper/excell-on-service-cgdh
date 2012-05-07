using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateStatusPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        StatusPaymentBLL spBLL = new StatusPaymentBLL();
        lbMessage.Text = "";
        if (spBLL.insert(ddlServiceOrder.SelectedIndex, ddlStatus.SelectedIndex, txtDate.Value, txtDescription.Text) != -1)
        {
            Response.Write("<script>alert('Create Status Payment Successful.');window.location='ManageStatusPayment.aspx';</script>");
        }
        else
        {
            Response.Write("<script>alert('Create Status Payment Fail.');window.location='ManageStatusPayment.aspx';</script>");
        } 
    }
}