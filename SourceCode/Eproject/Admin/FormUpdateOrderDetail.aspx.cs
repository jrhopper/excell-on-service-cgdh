using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormUpdateOrderDetail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            int id = int.Parse(Request.Params["id"].ToString());
            ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
            DataSet ds = sodBLL.getServiceOrderDetailById(id);
            txtId.Value = id.ToString();
            ddlServiceOrder.Value = ds.Tables[0].Rows[0]["serviceorderid"].ToString();
            ddlEmployee.Value = ds.Tables[0].Rows[0]["empid"].ToString();
            dllServiceType.Value = ds.Tables[0].Rows[0]["servicetype"].ToString();
            txtTaskname.Value = ds.Tables[0].Rows[0]["taskname"].ToString();
            txtDescription.Value = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }
    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
        sodBLL.updateServiceOrderDetail(int.Parse(txtId.Value), ddlServiceOrder.Value, ddlEmployee.Value,dllServiceType.Value, txtTaskname.Value, txtDescription.Value);
        Response.Write("<script>alert('Update Successful!');window.location='ManageOrderDetail.aspx';</script>");
    }
}