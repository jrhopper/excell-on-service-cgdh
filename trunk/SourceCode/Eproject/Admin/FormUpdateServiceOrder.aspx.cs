using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
            ddlEmployee.Value = ds.Tables[0].Rows[0]["empid"].ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            ddlCustomer.Value = ds.Tables[0].Rows[0]["customer"].ToString();
            ddlServiceType.Value = ds.Tables[0].Rows[0]["servicetype"].ToString();
            cBeginDate.Value = ds.Tables[0].Rows[0]["begindate"].ToString();
            cEndDate.Value = ds.Tables[0].Rows[0]["enddate"].ToString();
            txtComplete.Value = ds.Tables[0].Rows[0]["complete"].ToString();
            txtDescription.Value = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        soBLL.updateServiceOrder(int.Parse(txtId.Value), ddlEmployee.Value, txtName.Value, ddlCustomer.Value, ddlServiceType.Value, cBeginDate.Value, cEndDate.Value, txtComplete.Value, txtDescription.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageServiceOrder.aspx';</script>");
    }
}