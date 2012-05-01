using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageServiceOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //Response.Write("<script>alert('" + Session["user"] + "');</script>");
        if (!this.IsPostBack)
        loadData();
    }

    public void loadData()
    {
        ConfigurationDAL c = new ConfigurationDAL();
        c.connectDB();
        c.openConnect();
        ServiceOrderBLL soBLL = new ServiceOrderBLL();
        gvServiceOrder.DataSource = soBLL.getAllServiceOrder();
        gvServiceOrder.DataBind();
        c.closeConnect();
    }

    protected void gvServiceOrder_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void gvServiceOrder_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateServiceOrder")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateServiceOrder.aspx?id=" + int.Parse(gvServiceOrder.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteServiceOrder")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            ServiceOrderBLL serviceOrderBLL = new ServiceOrderBLL();
            //Response.Write("<b style='color:white'>"+CustomerBLL.deletecustomer(int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (serviceOrderBLL.deleteServiceOrder(int.Parse(gvServiceOrder.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This service order is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateServiceOrder.aspx");
    }

    protected void gvServiceOrder_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write("<script>alert('" + e.RowIndex + "');</script>");
    }
}