using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormCreateServiceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }
    public void loadData()
    {
        EmployeeBLL empBLL = new EmployeeBLL();
        foreach (DataRow dr in empBLL.getAllEmployee().Tables[0].Rows)
            ddlEmployee.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
        CustomerBLL cusBLL = new CustomerBLL();
        foreach (DataRow dr in cusBLL.getAllCustomer().Tables[0].Rows)
            ddlCustomer.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        foreach (DataRow dr in stBLL.getAllServiceType().Tables[0].Rows)
            ddlServiceType.Items.Add(new ListItem(dr["name"].ToString(), dr["id"].ToString()));
    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        if (soBLL.checkServiceOrderNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (soBLL.checkServiceOrderNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (soBLL.insert(ddlEmployee.SelectedIndex, txtName.Value, ddlCustomer.SelectedIndex, ddlServiceType.SelectedIndex,txtBeginDate.Value,txtEndDate.Value,ddlComplete.SelectedIndex, txtDescription.Text) != -1)
            {
                Response.Write("<script>alert('Create Service Order Successful.');window.location='ManageServiceOrder.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Service Order Fail.');window.location='ManageServiceOrder.aspx';</script>");
            }
        }
    }
}