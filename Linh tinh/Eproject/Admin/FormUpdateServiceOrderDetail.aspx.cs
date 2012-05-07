using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateServiceOrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
            DataSet ds = sodBLL.getServiceOrderDetailById(id);
            txtId.Value = id.ToString();
            ddlServiceOrder.SelectedValue = ds.Tables[0].Rows[0]["serviceorderid"].ToString();
            ddlEmployee.SelectedValue = ds.Tables[0].Rows[0]["empid"].ToString();
            ddlServiceType.SelectedValue = ds.Tables[0].Rows[0]["servicetype"].ToString();
            txtTaskName.Value = ds.Tables[0].Rows[0]["taskname"].ToString();
            txtDescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
        sodBLL.updateServiceOrderDetail(int.Parse(txtId.Value), int.Parse(ddlServiceOrder.SelectedValue), int.Parse(ddlEmployee.SelectedValue), int.Parse(ddlServiceType.SelectedValue),txtTaskName.Value, txtDescription.Text);
        Response.Write("<script>alert('Update Successful!');window.location='ManageOrderDetail.aspx';</script>");
    }
}