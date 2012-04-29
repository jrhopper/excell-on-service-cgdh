using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageDepartment : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
            loadData();
    }

    public void loadData()
    {
        DepartmentBLL department = new DepartmentBLL();
        gvDepartment.DataSource = department.getAllDepartment();
        gvDepartment.DataBind();
    }

    protected void gvDepartment_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvDepartment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateDepartment")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateDepartment.aspx?id=" + int.Parse(gvDepartment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvDepartment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteDepartment")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            DepartmentBLL DepartmentBLL = new DepartmentBLL();
            //Response.Write("<b style='color:white'>"+DepartmentBLL.deletedepartment(int.Parse(gvDepartment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (DepartmentBLL.deleteDepartment(int.Parse(gvDepartment.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This department is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateDepartment.aspx");
    }
}