using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateStatusPayment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            StatusPaymentBLL spBLL = new StatusPaymentBLL();
            DataSet ds = spBLL.getStatusPaymentById(id);
            txtId.Value = id.ToString();
            ddlServiceOrder.SelectedValue = ds.Tables[0].Rows[0]["serviceorderid"].ToString();
            ddlStatus.SelectedValue = ds.Tables[0].Rows[0]["status"].ToString();
            txtDate.Value = ds.Tables[0].Rows[0]["date"].ToString();
            txtDescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        StatusPaymentBLL spBLL = new StatusPaymentBLL();
        spBLL.updateStatusPayment(int.Parse(txtId.Value), int.Parse(ddlServiceOrder.SelectedValue), int.Parse(ddlStatus.SelectedValue), txtDate.Value,txtDescription.Text);
        Response.Write("<script>alert('Update Successful!');window.location='ManageStatusPayment.aspx';</script>");
    }
}