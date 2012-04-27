using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_FormCreateRole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        RoleBLL roleBLL = new RoleBLL();
        if (roleBLL.checkRoleNameByName(txtName.Value) == 1)
        {
            lbMessage.Text = "This name is existed.";
        }
        else if (roleBLL.checkRoleNameByName(txtName.Value) == 0)
        {
            lbMessage.Text = "";
            if (roleBLL.insert(txtName.Value, txtDescription.Text) != -1)
            {
                Response.Write("<script>alert('Create Role Successful.');window.location='ManageRole.aspx';</script>");
            }
            else
            {
                Response.Write("<script>alert('Create Role Fail.');window.location='ManageRole.aspx';</script>");
            }
        }


    }
}