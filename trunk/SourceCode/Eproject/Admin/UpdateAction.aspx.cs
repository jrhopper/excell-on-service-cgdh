using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_UpdateAction : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (Request.Params["id"] == null || Request.Params["id"].ToString() == "")
                Response.Redirect("ManageRole.aspx");
            else
            {
                int id = int.Parse(Request.Params["id"].ToString());
                ActionBLL actionBLL = new ActionBLL();
                txtId.Value = id.ToString();
                txtName.Value = actionBLL.getActionById(id).Tables[0].Rows[0]["name"].ToString();
                txtLink.Text = actionBLL.getActionById(id).Tables[0].Rows[0]["link"].ToString();
                txtDescription.Text = actionBLL.getActionById(id).Tables[0].Rows[0]["description"].ToString();
            }
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        ActionBLL actionBLL = new ActionBLL();
        int id = int.Parse(Request.Params["id"].ToString());
        DataSet ds = actionBLL.getActionById(id);
        String name = ds.Tables[0].Rows[0]["name"].ToString();
        if (actionBLL.checkActionName(txtName.Value) == true)
        {
            actionBLL.update(int.Parse(txtId.Value), txtName.Value, txtLink.Text, txtDescription.Text);
            Response.Write("<script>alert('Update Successful!');window.location='Action.aspx';</script>");
        }
        else if (actionBLL.checkActionName(txtName.Value) == false)
        {
            if (txtName.Value == name)
            {
                actionBLL.update(int.Parse(txtId.Value), txtName.Value, txtLink.Text, txtDescription.Text);
                Response.Write("<script>alert('Update Successful!');window.location='Action.aspx';</script>");
            }
            else if (txtName.Value != name)
            {
                Response.Write("<script>alert('This action name is existed!');</script>");
            }
        }
    }
}