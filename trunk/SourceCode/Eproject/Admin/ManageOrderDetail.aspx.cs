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
    protected void gvServiceOrderDetail_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write("<script>alert('" + e.RowIndex + "');</script>");
    }
}