using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            ddlServiceOrder.Value = ds.Tables[0].Rows[0]["serviceorderid"].ToString();
            txtStatus.Value = ds.Tables[0].Rows[0]["status"].ToString();
            cDate.Value = ds.Tables[0].Rows[0]["date"].ToString();
            txtDescription.Value = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        StatusPaymentBLL spBLL = new StatusPaymentBLL();
        spBLL.updateStatusPayment(int.Parse(txtId.Value), ddlServiceOrder.Value, txtStatus.Value, cDate.Value, txtDescription.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageStatusPayment.aspx';</script>");
    }
}