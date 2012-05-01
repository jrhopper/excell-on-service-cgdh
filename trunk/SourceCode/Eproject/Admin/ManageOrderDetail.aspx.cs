using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageOrderDetail : System.Web.UI.Page
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
        ServiceOrderDetailBLL sodBLL = new ServiceOrderDetailBLL();
        gvServiceOrderDetail.DataSource = sodBLL.getAllServiceOrderDetail();
        gvServiceOrderDetail.DataBind();
        c.closeConnect();
    }
    protected void gvServiceOrderDetail_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void gvServiceOrderDetail_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Response.Write("<b style='color:white'>"+gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[1].Text+"</b><br />");
        if (e.CommandName == "updateServiceOrderDetail")
        {
            //Response.Write("<b style='color:white'>update</b>");
            Response.Redirect("FormUpdateServiceOrderDetail.aspx?id=" + int.Parse(gvServiceOrderDetail.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)); //int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text);
        }
        if (e.CommandName == "deleteServiceOrderDetail")
        {
            //Response.Write("<b style='color:white'>delete</b>");
            ServiceOrderDetailBLL serviceOrderDetailBLL = new ServiceOrderDetailBLL();
            //Response.Write("<b style='color:white'>"+CustomerBLL.deletecustomer(int.Parse(gvCustomer.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text))+"</b>");
            if (serviceOrderDetailBLL.deleteServiceOrderDetail(int.Parse(gvServiceOrderDetail.Rows[(int.Parse(e.CommandArgument.ToString()))].Cells[0].Text)) == 0)
            {
                Response.Write("<script>alert('Delete is successful.');</script>");
                loadData();
            }
            else
            {
                Response.Write("<script>alert('Delete fail. This service order detail is contraint to another table.');</script>");
            }
        }
    }

    public void btnCreateNew_Click(object sender, EventArgs e)
    {
        Response.Redirect("FormCreateServiceOrderDetail.aspx");
    }

    protected void gvServiceOrderDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write("<script>alert('" + e.RowIndex + "');</script>");
    }
    
}