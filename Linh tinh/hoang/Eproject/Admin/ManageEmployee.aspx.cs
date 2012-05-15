using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageEmployee : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        EmployeeBLL employee = new EmployeeBLL();
        gvEmployee.DataSource = employee.getAllEmployee();
        gvEmployee.DataBind();
    }

    protected void gvEmployee_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "updateEmployee")
        {
            Response.Redirect("FormUpdateEmployee.aspx?id=" + int.Parse(gvEmployee.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text));
        }
        if (e.CommandName == "deleteEmployee")
        {
            EmployeeBLL EmployeeBLL = new EmployeeBLL();
            if (EmployeeBLL.deleteEmployee(int.Parse(gvEmployee.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This employee is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateEmployee.aspx");
    }
}