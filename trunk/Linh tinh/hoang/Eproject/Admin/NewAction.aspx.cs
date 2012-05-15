using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_NewAction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void btnCreate_Click(object sender, EventArgs e)
    {
        ActionBLL actionBLL = new ActionBLL();
        if (txtName.Text != "")
        {
            if (actionBLL.checkActionName(txtName.Text) == false)
                lbMessage.Text = "This action name is existed!";
            if (actionBLL.checkActionName(txtName.Text) == true)
            {
                lbMessage.Text = "create action successful!";
                actionBLL.insert(txtName.Text, txtLink.Text, txtDescription.Text);
                Response.Redirect("Action.aspx");

            }
        }
        else if (txtName.Text == "")
            lbMessage.Text = "Action name is null";
    }
}