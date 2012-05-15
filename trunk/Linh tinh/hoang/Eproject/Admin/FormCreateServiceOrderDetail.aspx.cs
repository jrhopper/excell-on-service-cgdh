using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormCreateServiceOrderDetail : System.Web.UI.Page
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
        EmployeeBLL empBLL = new EmployeeBLL();
        foreach (DataRow dr in empBLL.getAllEmployee().Tables[0].Rows)
            ddlEmployee.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        foreach (DataRow dr in stBLL.getAllServiceType().Tables[0].Rows)
            ddlServiceType.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
        if (sodBLL.checkServiceOrderDetailNameByName(txtTaskName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (sodBLL.checkServiceOrderDetailNameByName(txtTaskName.Value) == 0)
        {
            lbMessage.Text = "";
            if (sodBLL.insert(ddlServiceOrder.SelectedIndex, ddlEmployee.SelectedIndex, ddlServiceType.SelectedIndex, txtTaskName.Value, txtDescription.Text) != -1)
            {
                Response.Write("<script>alert('Create Order Detail Successful.');window.location='ManageCustomer.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Order Detail Fail.');window.location='ManageCustomer.aspx';</script>");
            }
        }
    }
}