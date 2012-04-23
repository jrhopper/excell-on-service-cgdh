using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ManageCustomer : System.Web.UI.Page
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
        CustomerBLL cusBLL = new CustomerBLL();
        gvCustomer.DataSource = cusBLL.getAllCustomer();
        gvCustomer.DataBind();
        c.closeConnect();
    }
    protected void gvCustomer_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void gvCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Response.Write("<script>alert('" + e.RowIndex + "');</script>");
    }
}