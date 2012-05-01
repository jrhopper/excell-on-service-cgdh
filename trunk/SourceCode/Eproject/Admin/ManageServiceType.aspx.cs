using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageServiceType : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        loadData();
    }
    public void loadData()
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        ServiceTypeBLL stBLL = new ServiceTypeBLL();
        gvServiceType.DataSource = stBLL.getAllServiceType();
        gvServiceType.DataBind();
        c.closeConnect();
    }
    protected void gvServiceType_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvServiceType_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateServiceType")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateServiceType.aspx?id=" + int.Parse(gvServiceType.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteServiceType")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            ServiceTypeBLL serviceTypeBLL = new ServiceTypeBLL();
            //Response.Write("<b style='color:white'>"+CustomerBLL.deletecustomer(int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (serviceTypeBLL.deleteServiceType(int.Parse(gvServiceType.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This service type is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateServiceType.aspx");
    }
    protected void gvServiceType_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write("<script>alert('" + e.RowIndex + "');</script>");
    }
}