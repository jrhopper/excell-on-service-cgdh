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
            EmployeeBLL empBLL = new EmployeeBLL();
            foreach (DataRow dr in empBLL.getAllEmployee().Tables[0].Rows)
                ddlEmployee.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            CustomerBLL cusBLL = new CustomerBLL();
            foreach (DataRow dr in cusBLL.getAllCustomer().Tables[0].Rows)
                ddlCustomer.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
            ServiceTypeBLL stBLL = new ServiceTypeBLL();
            foreach (DataRow dr in stBLL.getAllServiceType().Tables[0].Rows)
                ddlServiceType.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
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