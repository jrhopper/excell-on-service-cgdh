using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageRole : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        RoleBLL role = new RoleBLL();
        gvRole.DataSource = role.getAllRole();
        gvRole.DataBind();
    }

    protected void gvRole_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvRole.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateRole")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateRole.aspx?id=" + int.Parse(gvRole.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvRole.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteRole")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            RoleBLL roleBLL = new RoleBLL();
            //Response.Write("<b style='color:white'>"+roleBLL.deleteRole(int.Parse(gvRole.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (roleBLL.deleteRole(int.Parse(gvRole.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete successful');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This role is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateRole.aspx");
    }
}