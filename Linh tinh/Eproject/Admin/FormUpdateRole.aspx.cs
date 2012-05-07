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
            int id = int.Parse(Request.Params["id"].ToString());
            RoleBLL roleBLL = new RoleBLL();
            DataSet ds = roleBLL.getRoleById(id);
            txtId.Value = id.ToString();
            txtName.Value = ds.Tables[0].Rows[0]["name"].ToString();
            txtDescription.Text = ds.Tables[0].Rows[0]["description"].ToString();
        }
    }

    public void btnUpdate_Click(object sender, EventArgs e)
    {
        RoleBLL roleBLL = new RoleBLL();
        roleBLL.updateRole(int.Parse(txtId.Value),txtName.Value,txtDescription.Text);
        Response.Write("<script>alert('Update Successful!');window.location='ManageRole.aspx';</script>");
    }
}