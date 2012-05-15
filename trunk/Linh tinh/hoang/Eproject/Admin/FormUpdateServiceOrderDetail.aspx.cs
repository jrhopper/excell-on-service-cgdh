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
            ServiceOrderBLL soBLL = new ServiceOrderBLL();
            foreach (DataRow dr in soBLL.getAllServiceOrder().Tables[0].Rows)
                ddlServiceOrder.Items.Add(new ListItem(dr["serviceorder"].ToString(), dr["id"].ToString()));
            EmployeeBLL empBLL = new EmployeeBLL();
            foreach (DataRow dr in empBLL.getAllEmployee().Tables[0].Rows)
                ddlEmployee.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
            ServiceTypeBLL stBLL = new ServiceTypeBLL();
            foreach (DataRow dr in stBLL.getAllServiceType().Tables[0].Rows)
                ddlServiceType.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
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