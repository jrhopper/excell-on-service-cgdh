using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormCreateStatusPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }
    public void loadData()
    {
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        foreach (DataRow dr in soBLL.getAllServiceOrder().Tables[0].Rows)
            ddlServiceOrder.Items.Add(new ListItem(dr["serviceorder"].ToString(), dr["id"].ToString()));
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