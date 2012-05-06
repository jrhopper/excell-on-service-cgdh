using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateServiceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            ServiceOrderBLL soBLL = new ServiceOrderBLL();
            DataSet ds = soBLL.getServiceOrderById(id);
            txtId.Value = id.ToString();
            ddlEmployee.SelectedValue = ds.Tables[0].Rows[0]["empid"].ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            ddlCustomer.SelectedValue = ds.Tables[0].Rows[0]["customer"].ToString();
            ddlServiceType.SelectedValue = ds.Tables[0].Rows[0]["servicetype"].ToString();
            txtBeginDate.Value = ds.Tables[0].Rows[0]["begindate"].ToString();
            txtEndDate.Value = ds.Tables[0].Rows[0]["enddate"].ToString();
            ddlComplete.SelectedValue = ds.Tables[0].Rows[0]["complete"].ToString();
            txtDescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        soBLL.updateServiceOrder(int.Parse(txtId.Value), int.Parse(ddlEmployee.SelectedValue), txtName.Value, int.Parse(ddlCustomer.SelectedValue), int.Parse(ddlServiceType.SelectedValue), txtBeginDate.Value, txtEndDate.Value, int.Parse(ddlComplete.SelectedValue),txtDescription.Text);
        Response.Write("<script>alert('Update Successful!');window.location='ManageServiceOrder.aspx';</script>");
    }
}