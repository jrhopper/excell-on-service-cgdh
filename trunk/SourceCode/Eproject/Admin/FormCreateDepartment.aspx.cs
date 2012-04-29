using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateDepartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        DepartmentBLL departmentBLL = new DepartmentBLL();
        if (departmentBLL.CheckDepartmentNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (departmentBLL.CheckDepartmentNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (departmentBLL.insert(txtName.Value, txtDescription.Value) != -1)
            {
                Response.Write("<script>alert('Create Department Successful.');window.location='ManageDepartment.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Department Fail.');window.location='ManageDepartment.aspx';</script>");
            }
        }


    }
}