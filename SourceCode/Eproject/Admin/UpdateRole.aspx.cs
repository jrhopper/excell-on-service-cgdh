using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Admin_FormUpdateRole : System.Web.UI.Page
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
                RoleBLL roleBLL = new RoleBLL();
                
                DataSet ds = roleBLL.getRoleById(id);
                txtId.Value = id.ToString();
                txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
                txtDescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
            }
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        RoleBLL roleBLL = new RoleBLL();
        int id = int.Parse(Request.Params["id"].ToString());
        DataSet ds = roleBLL.getRoleById(id);
        String name = ds.Tables[0].Rows[0]["name"].ToString();
        if (roleBLL.checkRoleNameByName(txtName.Value) == 0)
        {
            roleBLL.updateRole(int.Parse(txtId.Value), txtName.Value, txtDescription.Text);
            Response.Write("<script>alert('Update Successful!');window.location='ManageRole.aspx';</script>");
        }
        else if (roleBLL.checkRoleNameByName(txtName.Value) == 1)
        {
            if (txtName.Value == name)
            {
                roleBLL.updateRole(int.Parse(txtId.Value), txtName.Value, txtDescription.Text);
                Response.Write("<script>alert('Update Successful!');window.location='ManageRole.aspx';</script>");
            }
            else if (txtName.Value != name)
            {
                Response.Write("<script>alert('This role name is existed!');</script>");
            }
        }
    }
}